using OpenLibSys;
using System;
using System.Collections.Generic;

namespace nForce2XT.Components
{
    public class Nforce2Pll
    {
        private const ushort PCI_VENDOR_ID_NVIDIA = 0x10de;
        private const ushort PCI_DEVICE_ID_NVIDIA_NFORCE2 = 0x01e0;
        private const double NFORCE2_XTAL = 25.0;
        private const byte NFORCE2_BOOTFSB = 0x48;
        private const byte NFORCE2_PLLENABLE = 0xa8;
        private const byte NFORCE2_PLLREG = 0xa4;
        private const byte NFORCE2_PLLADR = 0xa0;
        private readonly uint Nforce2Dev;
        private readonly Ols ols = new Ols();
        //private readonly List<KeyValuePair<double, int>> PossibleFsb = new List<KeyValuePair<double, int>>();
        private readonly SortedList<double, int> PossibleFsb = new SortedList<double, int>();

        private static int MakePll(byte mul, byte div)
        {
            return 0x100000 | (mul << 8) | div;
        }

        internal static double CalcFsb(int pll)
        {
            byte mul = (byte)((pll >> 8) & 0xff);
            byte div = (byte)(pll & 0xff);

            if (div > 0)
                return NFORCE2_XTAL * mul / div;

            return 0;
        }

        internal static int CalcPll(uint fsb)
        {
            byte xmul, xdiv;
            byte mul = 0, div = 0;
            int tried = 0;

            /* Try to calculate multiplier and divider up to 4 times */
            while (((mul == 0) || (div == 0)) && (tried <= 3))
            {
                for (xdiv = 2; xdiv <= 0x80; xdiv++)
                    for (xmul = 0xf0; xmul <= 0xfa; xmul++)
                        if (CalcFsb(MakePll(xmul, xdiv)) == (fsb * 1.0) + tried)
                        {
                            mul = xmul;
                            div = xdiv;
                        }
                tried++;
            }

            if ((mul == 0) || (div == 0))
                return 0;

            return MakePll(mul, div);
        }

        internal bool WritePll(int pll)
        {
            bool res = true;
            /* Set the pll addr. to 0x00 */
            ols.WritePciConfigDwordEx(Nforce2Dev, NFORCE2_PLLADR, 0);

            /* Now write the value in all 64 registers */
            for (var temp = 0; temp <= 0x3f; temp++)
                res = ols.WritePciConfigDwordEx(Nforce2Dev, NFORCE2_PLLREG, Convert.ToUInt32(pll)) == 1;

            return res;
        }

        public uint ReadFsb(bool bootfsb = false)
        {
            uint nforce2_sub5;
	        uint fsb, temp = 0;

            /* Get chipset boot FSB from subdevice 5 (FSB at boot-time) */
            nforce2_sub5 = ols.FindPciDeviceById(PCI_VENDOR_ID_NVIDIA, 0x01EF, 0);

	        if (nforce2_sub5 == 0xFFFFFFFF)
		        return 0;

            fsb = ols.ReadPciConfigDword(nforce2_sub5, NFORCE2_BOOTFSB);
            fsb /= 1000000;

	        /* Check if PLL register is already set */
	        temp = ols.ReadPciConfigByte(Nforce2Dev, NFORCE2_PLLENABLE);

	        if (bootfsb || temp == 0)
		        return fsb;

	        /* Use PLL register FSB value */
	        temp = ols.ReadPciConfigDword(Nforce2Dev, NFORCE2_PLLREG);
            fsb = (uint)CalcFsb(Convert.ToInt32(temp));

	        return fsb;
        }

        public bool SetFsb(uint fsb)
        {
            uint temp = 0;
            uint tfsb;
            int diff = 0;
            int pll = 0;

            /*if ((fsb > 350) || (fsb < 50))
            {
                printk(KERN_ERR PFX "FSB %d is out of range!\n", fsb);
                return -EINVAL;
            }*/

            tfsb = ReadFsb(false);
            if (tfsb == 0)
            {
                //printk(KERN_ERR PFX "Error while reading the FSB\n");
                return false;
            }

            /* First write? Then set actual value */
            temp = ols.ReadPciConfigByte(Nforce2Dev, NFORCE2_PLLENABLE);
            if (temp == 0)
            {
                pll = CalcPll(tfsb);

                if (pll == 0)
                    return false;

                WritePll(pll);
            }

            /* Enable write access */
            ols.WritePciConfigByte(Nforce2Dev, NFORCE2_PLLENABLE, 0x01);

            diff = Convert.ToInt32(tfsb) - (Convert.ToInt32(fsb));

            if (diff == 0)
                return true;

            while ((tfsb != fsb) && (tfsb <= 350/*max_fsb*/) && (tfsb >= 50/*min_fsb*/))
            {
                if (diff < 0)
                    tfsb++;
                else
                    tfsb--;

                /* Calculate the PLL reg. value */
                pll = CalcPll(tfsb);
                if (pll == 0)
                    return false;

                WritePll(pll);
            }

            ols.WritePciConfigByte(Nforce2Dev, NFORCE2_PLLADR, 0x40);

            return true;
        }

        public int GetNextPll(double fsb)
        {
            foreach (var item in PossibleFsb)
            {
                if (item.Key > fsb)
                {
                    Console.WriteLine(item.Key);
                    return item.Value;
                }
            }
            return -1;
        }

        public int GetPrevPll(double fsb)
        {
            int ret = -1;
            double d = 0;
            foreach (var item in PossibleFsb)
            {
                if (item.Key >= fsb)
                    break;

                d = item.Key;
                ret = item.Value;
            }

            Console.WriteLine(d);
            return ret;
        }

        internal void GenerateFsbTable()
        {
            byte xmul, xdiv;

            for (xdiv = 2; xdiv <= 0x80; xdiv++)
            {
                for (xmul = 1; xmul <= 0xfe; xmul++)
                {
                    int pll = MakePll(xmul, xdiv);
                    double fsb = Math.Round(CalcFsb(pll), 2, MidpointRounding.AwayFromZero);

                    if (fsb >= 30 && fsb <= 350 && !PossibleFsb.ContainsKey(fsb))
                    {
                        PossibleFsb.Add(fsb, pll);
                    }
                }
            }

            foreach (var item in PossibleFsb)
            {
                Console.WriteLine($"{item.Key:f2}: 0x{item.Value:X8}");
            }
        }

        public Nforce2Pll()
        {
            Nforce2Dev = ols.FindPciDeviceById(PCI_VENDOR_ID_NVIDIA, PCI_DEVICE_ID_NVIDIA_NFORCE2, 0);

            //if (Nforce2Dev == 0xFFFFFFFF)
            //    throw new Exception("Not a NForce2 chipset");

            GenerateFsbTable();
        }
    }
}
