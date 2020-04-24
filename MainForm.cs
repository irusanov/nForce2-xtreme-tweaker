using nForce2XT.Components;
using nForce2XT.Utils;
using OpenLibSys;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Permissions;
using System.Windows.Forms;

namespace nForce2XT
{
    public partial class MainForm : Form
    {
        private static readonly List<TimingDef> TimingDefs = new List<TimingDef>() {
             new TimingDef("CAS",                   new PciDev(0, 0, 1, 0xB0),  4, 3),

             new TimingDef("TRC",                   new PciDev(0, 0, 1, 0x90),  0, 5),
             new TimingDef("TRFC",                  new PciDev(0, 0, 1, 0x90),  8, 5),
             new TimingDef("TRAS",                  new PciDev(0, 0, 1, 0x90), 15, 4),
             new TimingDef("TRCDR",                 new PciDev(0, 0, 1, 0x90), 20, 4),
             new TimingDef("TRCDW",                 new PciDev(0, 0, 1, 0x90), 24, 4),
             new TimingDef("TRP",                   new PciDev(0, 0, 1, 0x90), 28, 4),

             new TimingDef("TDOE",                  new PciDev(0, 0, 1, 0x94), 28, 3),
             new TimingDef("TRRD",                  new PciDev(0, 0, 1, 0x94), 24, 3),
             new TimingDef("TWTP",                  new PciDev(0, 0, 1, 0x94), 20, 3),
             new TimingDef("TWTR",                  new PciDev(0, 0, 1, 0x94), 16, 3),
             new TimingDef("TREXT",                 new PciDev(0, 0, 1, 0x94), 12, 2),
             new TimingDef("TRTP",                  new PciDev(0, 0, 1, 0x94),  8, 3),
             new TimingDef("TRTW",                  new PciDev(0, 0, 1, 0x94),  4, 3),

             new TimingDef("CR",                    new PciDev(0, 0, 1, 0x84), 29, 1),
             new TimingDef("TREF",                  new PciDev(0, 0, 1, 0x60), 0, 16),

             new TimingDef("BurstMode",             new PciDev(0, 0, 1, 0xA0), 3, 1),
             new TimingDef("DLL",                   new PciDev(0, 0, 1, 0xA4), 0, 1),
             new TimingDef("DriveStrengthMode",     new PciDev(0, 0, 1, 0xA4), 1, 1),
             new TimingDef("SuperBypass",           new PciDev(0, 0, 1, 0xFC), 0, 1),
             new TimingDef("DataScavengedRate",     new PciDev(0, 0, 1, 0xF8), 2, 1),

             new TimingDef("AutoPrecharge",         new PciDev(0, 0, 1, 0x84), 17, 1),

             new TimingDef("DIMM0DrvStrA",          new PciDev(0, 0, 4, 0x64),  8, 4),
             new TimingDef("DIMM1DrvStrA",          new PciDev(0, 0, 4, 0x64), 24, 4),
             new TimingDef("DIMM2DrvStrA",          new PciDev(0, 0, 4, 0x7C),  8, 4),
             new TimingDef("DIMM0DrvStrB",          new PciDev(0, 0, 4, 0x70),  8, 4),
             new TimingDef("DIMM1DrvStrB",          new PciDev(0, 0, 4, 0x70), 24, 4),
             new TimingDef("DIMM2DrvStrB",          new PciDev(0, 0, 4, 0x80),  8, 4),

             new TimingDef("DIMM0SlewRate",         new PciDev(0, 0, 4, 0x64),  0, 4),
             new TimingDef("DIMM1SlewRate",         new PciDev(0, 0, 4, 0x64), 16, 4),
             new TimingDef("DIMM2SlewRate",         new PciDev(0, 0, 4, 0x7C),  0, 4),

             new TimingDef("CPUDisconnect",         new PciDev(0, 0, 0, 0x6C), 28, 1),

             new TimingDef("AGPFastWrite",          new PciDev(0, 0, 0, 0x44),  4, 1),
             new TimingDef("AGPSBA",                new PciDev(0, 0, 0, 0x48),  8, 2),
             new TimingDef("AGPControllerLatency",  new PciDev(0, 30, 0, 0xC),  8, 8),
             new TimingDef("AGPBusLatency",         new PciDev(0, 30, 0, 0x18), 24, 8),
             new TimingDef("PCILatency",            new PciDev(0, 8, 0, 0x18),  24, 8),
        };

        private const ushort PCI_ADDR_PORT = 0xCF8;
        private const ushort PCI_DATA_PORT = 0xCFC;

        private readonly Ols ols;
        private readonly Util utils;

        private void CheckOlsStatus()
        {
            // Check support library status
            switch (ols.GetStatus())
            {
                case (uint)Ols.Status.NO_ERROR:
                    break;
                case (uint)Ols.Status.DLL_NOT_FOUND:
                    throw new ApplicationException("WinRing DLL_NOT_FOUND");
                case (uint)Ols.Status.DLL_INCORRECT_VERSION:
                    throw new ApplicationException("WinRing DLL_INCORRECT_VERSION");
                case (uint)Ols.Status.DLL_INITIALIZE_ERROR:
                    throw new ApplicationException("WinRing DLL_INITIALIZE_ERROR");
            }

            // Check WinRing0 status
            switch (ols.GetDllStatus())
            {
                case (uint)Ols.OlsDllStatus.OLS_DLL_NO_ERROR:
                    break;
                case (uint)Ols.OlsDllStatus.OLS_DLL_DRIVER_NOT_LOADED:
                    throw new ApplicationException("WinRing OLS_DRIVER_NOT_LOADED");
                case (uint)Ols.OlsDllStatus.OLS_DLL_UNSUPPORTED_PLATFORM:
                    throw new ApplicationException("WinRing OLS_UNSUPPORTED_PLATFORM");
                case (uint)Ols.OlsDllStatus.OLS_DLL_DRIVER_NOT_FOUND:
                    throw new ApplicationException("WinRing OLS_DLL_DRIVER_NOT_FOUND");
                case (uint)Ols.OlsDllStatus.OLS_DLL_DRIVER_UNLOADED:
                    throw new ApplicationException("WinRing OLS_DLL_DRIVER_UNLOADED");
                case (uint)Ols.OlsDllStatus.OLS_DLL_DRIVER_NOT_LOADED_ON_NETWORK:
                    throw new ApplicationException("WinRing DRIVER_NOT_LOADED_ON_NETWORK");
                case (uint)Ols.OlsDllStatus.OLS_DLL_UNKNOWN_ERROR:
                    throw new ApplicationException("WinRing OLS_DLL_UNKNOWN_ERROR");
            }
        }

        private uint ReadPciReg(uint pciDev)
        {
            ols.WriteIoPortDwordEx(PCI_ADDR_PORT, pciDev);
            return ols.ReadIoPortDword(PCI_DATA_PORT);
        }

        private bool WritePciReg(uint pciDev, uint value)
        {
            ols.WriteIoPortDwordEx(PCI_ADDR_PORT, pciDev);
            return ols.WriteIoPortDwordEx(PCI_DATA_PORT, value) == 1;
        }

        private int GetTimingFromRegValue(uint value, int offset, int n = 1)
        {
            return Convert.ToInt32(utils.GetBits(value, offset, n));
        }

        private int ReadCASValue()
        {
            // Read value for DIMM_B0
            TimingDef def = TimingDefs.Find(x => x.Name == "CAS");
            uint reg = ReadPciReg(def.PciDev.GetPciAddressFull());

            // CAS is bits [5:4], bit 6 is Half Latency toggle
            // CAS 2.0 = 010 2
            // CAS 2.5 = 110 5
            // CAS 3.0 = 011 3
            // 001, 101 and 111 are reserved
            uint value = utils.GetBits(reg, def.Offset, def.Bits);

            if (value == 2) return 1; // CAS 2.0
            if (value == 6) return 2; // CAS 2.5
            if (value == 3) return 3; // CAS 3.0

            return 0;
        }

        private void WriteTimings(nForce2XTLibrary.TimingItem[] l)
        {
            nForce2XTLibrary.TimingItem[] changed = Array.FindAll(l, x => x.Changed);

            if (changed.Length == 0) return;

            TimingDef def = TimingDefs.Find(x => x.Name == changed[0].Name);
            uint regValue = ReadPciReg(def.PciDev.GetPciAddressFull());

            foreach (nForce2XTLibrary.TimingItem item in changed)
            {
                def = TimingDefs.Find(x => x.Name == item.Name);
                regValue = utils.SetBits(regValue, def.Offset, def.Bits, Convert.ToUInt32(item.Value));
            }

            ols.WriteIoPortDwordEx(PCI_DATA_PORT, regValue);
        }

        private void PopulateTimingFromRegValue(nForce2XTLibrary.TimingItem[] items)
        {
            TimingDef def = TimingDefs.Find(x => x.Name == items[0].Name);
            uint regValue = ReadPciReg(def.PciDev.GetPciAddressFull());

            foreach (nForce2XTLibrary.TimingItem item in items)
            {
                def = TimingDefs.Find(x => x.Name == item.Name);
                item.Value = GetTimingFromRegValue(regValue, def.Offset, def.Bits);
            }
        }

        private void PopulateTimingFromRegValue(nForce2XTLibrary.TimingItem item)
        {
            TimingDef def = TimingDefs.Find(x => x.Name == item.Name);
            uint regValue = ReadPciReg(def.PciDev.GetPciAddressFull());
            item.Value = GetTimingFromRegValue(regValue, def.Offset, def.Bits);
        }

        private void ReadTimings()
        {
            CAS.Value = ReadCASValue();
            PopulateTimingFromRegValue(new nForce2XTLibrary.TimingItem[] { TRC, TRFC, TRAS, TRCDR, TRCDW, TRP });
            PopulateTimingFromRegValue(new nForce2XTLibrary.TimingItem[] { TDOE, TRRD, TWTP, TWTR, TREXT, TRTP, TRTW });
            PopulateTimingFromRegValue(CR);
            PopulateTimingFromRegValue(TREF);
            PopulateTimingFromRegValue(AutoPrecharge);
            PopulateTimingFromRegValue(BurstMode);
            PopulateTimingFromRegValue(DriveStrengthMode);
            PopulateTimingFromRegValue(SuperBypass);
            PopulateTimingFromRegValue(DataScavengedRate);
            PopulateTimingFromRegValue(DIMM0DrvStrA);
            PopulateTimingFromRegValue(DIMM1DrvStrA);
            PopulateTimingFromRegValue(DIMM0SlewRate);
            PopulateTimingFromRegValue(DIMM1SlewRate);
            PopulateTimingFromRegValue(DIMM0DrvStrB);
            PopulateTimingFromRegValue(DIMM1DrvStrB);
            PopulateTimingFromRegValue(DIMM2DrvStrA);
            PopulateTimingFromRegValue(DIMM2SlewRate);
            PopulateTimingFromRegValue(DIMM2DrvStrB);
            PopulateTimingFromRegValue(CPUDisconnect);

            uint romsip1 = ReadPciReg(utils.MakePciAddress(0, 0, 3, 0x64));
            advancedTextBox1.Value = Convert.ToByte(GetTimingFromRegValue(romsip1, 8, 8));
            advancedTextBox2.Value = Convert.ToByte(GetTimingFromRegValue(romsip1, 16, 8));
            advancedTextBox3.Value = Convert.ToByte(GetTimingFromRegValue(romsip1, 24, 8));

            uint romsip2 = ReadPciReg(utils.MakePciAddress(0, 0, 3, 0x68));
            advancedTextBox4.Value = Convert.ToByte(GetTimingFromRegValue(romsip2, 0, 8));
            advancedTextBox5.Value = Convert.ToByte(GetTimingFromRegValue(romsip2, 8, 8));
            advancedTextBox6.Value = Convert.ToByte(GetTimingFromRegValue(romsip2, 16, 8));
            advancedTextBox7.Value = Convert.ToByte(GetTimingFromRegValue(romsip2, 24, 8));

            uint romsip3 = ReadPciReg(utils.MakePciAddress(0, 0, 3, 0x6C));
            advancedTextBox8.Value = Convert.ToByte(GetTimingFromRegValue(romsip3, 0, 8));
            advancedTextBox9.Value = Convert.ToByte(GetTimingFromRegValue(romsip3, 8, 8));
            advancedTextBox10.Value = Convert.ToByte(GetTimingFromRegValue(romsip3, 24, 8));

            PopulateTimingFromRegValue(AGPFastWrite);
            PopulateTimingFromRegValue(AGPSBA);
            PopulateTimingFromRegValue(AGPControllerLatency);
            PopulateTimingFromRegValue(AGPBusLatency);
            PopulateTimingFromRegValue(PCILatency);
        }

        public MainForm()
        {
            InitializeComponent();

            try
            {
                ols = new Ols();
                utils = new Util();

                CheckOlsStatus();
                ReadTimings();
            }
            catch (ApplicationException ex)
            {
                SplashForm.CloseForm();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
                Application.Exit();
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Text = $"{Application.ProductName} {Application.ProductVersion.Substring(0, Application.ProductVersion.LastIndexOf('.'))}";
#if DEBUG
            Text += " (debug)";
#endif

            trayMenuItemApp.Text = Text;

            /*ChipsetGroup.Dispose();
            DRAMAdvancedGroup.Dispose();

            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Width = 195;
            Height = 200;*/
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            ReadTimings();
        }

        private void WriteCASTest()
        {
            uint pciDev = ols.PciBusDevFunc(0, 0, 1);
            int value = CAS.Value;

            uint reg0 = ReadPciReg(utils.MakePciAddress(0, 0, 1, 0x70)); // half latency
            uint reg1 = ReadPciReg(utils.MakePciAddress(0, 0, 1, 0x74)); // half latency
            uint reg2 = ReadPciReg(utils.MakePciAddress(0, 0, 1, 0x98));
            uint reg3 = ReadPciReg(utils.MakePciAddress(0, 0, 1, 0xF8));

            uint reg4 = ReadPciReg(utils.MakePciAddress(0, 0, 1, 0xA0));
            uint reg5 = ReadPciReg(utils.MakePciAddress(0, 0, 1, 0xA8));
            uint reg6 = ReadPciReg(utils.MakePciAddress(0, 0, 1, 0xB0));
            uint reg7 = ReadPciReg(utils.MakePciAddress(0, 0, 1, 0xB8));

            //uint reg8 = ReadPciReg(1, 0x78);
            //uint reg9 = ReadPciReg(1, 0x7C);

            if (value == 1) // CL2.0
            {
                /*reg0 = utils.SetBits(reg0, 13, 1, 0);
                reg1 = utils.SetBits(reg1, 13, 1, 0);
                reg2 = utils.SetBits(reg2, 16, 8, 0x54);
                reg2 = utils.SetBits(reg2, 12, 4, 0x2);
                reg2 = utils.SetBits(reg2, 24, 4, 0x2);
                reg3 = utils.SetBits(reg3, 8, 8, 0x44);*/

                reg4 = utils.SetBits(reg4, 4, 3, 0x2);
                reg5 = utils.SetBits(reg5, 4, 3, 0x2);
                reg6 = utils.SetBits(reg6, 4, 3, 0x2);
                reg7 = utils.SetBits(reg7, 4, 3, 0x2);

                //reg8 = utils.SetBits(reg8, 0, 4, 0xC);
                //reg9 = utils.SetBits(reg9, 0, 4, 0xA);
            }
            else if (value == 2) // CL2.5
            {
                /*reg0 = utils.SetBits(reg0, 13, 1, 1);
                reg1 = utils.SetBits(reg1, 13, 1, 1);
                reg2 = utils.SetBits(reg2, 16, 8, 0x65);
                reg2 = utils.SetBits(reg2, 12, 4, 0x2);
                reg2 = utils.SetBits(reg2, 24, 4, 0x2);
                reg3 = utils.SetBits(reg3, 8, 8, 0x45);*/

                reg4 = utils.SetBits(reg4, 4, 3, 0x6);
                reg5 = utils.SetBits(reg5, 4, 3, 0x6);
                reg6 = utils.SetBits(reg6, 4, 3, 0x6);
                reg7 = utils.SetBits(reg7, 4, 3, 0x6);

                //reg8 = utils.SetBits(reg8, 0, 4, 0xC);
                //reg9 = utils.SetBits(reg9, 0, 4, 0xA);
            }
            else if (value == 3) // CL3.0
            {
                /*reg0 = utils.SetBits(reg0, 13, 1, 0);
                reg1 = utils.SetBits(reg1, 13, 1, 0);
                reg2 = utils.SetBits(reg2, 16, 8, 0x65);
                reg2 = utils.SetBits(reg2, 12, 4, 0x3);
                reg2 = utils.SetBits(reg2, 24, 4, 0x3);
                reg3 = utils.SetBits(reg3, 8, 8, 0x45);*/

                reg4 = utils.SetBits(reg4, 4, 3, 0x3);
                reg5 = utils.SetBits(reg5, 4, 3, 0x3);
                reg6 = utils.SetBits(reg6, 4, 3, 0x3);
                reg7 = utils.SetBits(reg7, 4, 3, 0x3);

                //reg8 = utils.SetBits(reg8, 0, 4, 0x6);
                //reg9 = utils.SetBits(reg9, 0, 4, 0x2);
            }

            //ols.WritePciConfigDwordEx(pciDev, 0x98, reg2);

            reg4 = utils.SetBits(reg4, 31, 1, 1);
            reg5 = utils.SetBits(reg5, 31, 1, 1);
            reg6 = utils.SetBits(reg6, 31, 1, 1);
            reg7 = utils.SetBits(reg7, 31, 1, 1);

            ols.WritePciConfigDwordEx(pciDev, 0xA0, reg4);
            ols.WritePciConfigDwordEx(pciDev, 0xA8, reg5);
            ols.WritePciConfigDwordEx(pciDev, 0xB0, reg6);
            ols.WritePciConfigDwordEx(pciDev, 0xB8, reg7);

            //ols.WritePciConfigDwordEx(pciDev, 0x78, reg8);
            //ols.WritePciConfigDwordEx(pciDev, 0x7C, reg9);


            /*ols.WritePciConfigDwordEx(pciDev, 0x74, reg1);
            ols.WritePciConfigDwordEx(pciDev, 0x70, reg0);

            ols.WritePciConfigDwordEx(pciDev, 0xF8, reg3);*/
        }

        private void ApplyDRAMTabSettings()
        {
            WriteTimings(new nForce2XTLibrary.TimingItem[] { TRC, TRFC, TRAS, TRCDR, TRCDW, TRP });
            WriteTimings(new nForce2XTLibrary.TimingItem[] { TDOE, TRRD, TWTP, TWTR, TREXT, TRTP, TRTW });
            WriteTimings(new nForce2XTLibrary.TimingItem[] { TREF });

            WriteTimings(new nForce2XTLibrary.TimingItem[] { AutoPrecharge });
            WriteTimings(new nForce2XTLibrary.TimingItem[] { SuperBypass });
            WriteTimings(new nForce2XTLibrary.TimingItem[] { DataScavengedRate });

            WriteTimings(new nForce2XTLibrary.TimingItem[] { DIMM0DrvStrA, DIMM1DrvStrA, DIMM0SlewRate, DIMM1SlewRate });
            WriteTimings(new nForce2XTLibrary.TimingItem[] { DIMM0DrvStrB, DIMM1DrvStrB });
            WriteTimings(new nForce2XTLibrary.TimingItem[] { DIMM2DrvStrA, DIMM2SlewRate });
            WriteTimings(new nForce2XTLibrary.TimingItem[] { DIMM2DrvStrB });

            if (BurstMode.Changed)
            {
                // A0, A8, B0
                TimingDef def = TimingDefs.Find(x => x.Name == BurstMode.Name);
                byte reg = def.PciDev.Offset;
                uint pciDev = def.PciDev.GetPciAddress();
                uint regValue = ols.ReadPciConfigDword(pciDev, reg);

                uint selectedValue = Convert.ToUInt32(BurstMode.Value);
                regValue = utils.SetBits(regValue, def.Offset, def.Bits, selectedValue);
                //regValue = utils.SetBits(burstMode, 31, 1, 1);
                ols.WritePciConfigDwordEx(pciDev, 0xA0, regValue);
                ols.WritePciConfigDwordEx(pciDev, 0xA8, regValue);
                ols.WritePciConfigDwordEx(pciDev, 0xB0, regValue);
            }

            if (DriveStrengthMode.Changed)
            {
                TimingDef def = TimingDefs.Find(x => x.Name == DriveStrengthMode.Name);
                byte reg = def.PciDev.Offset;
                uint pciDev = def.PciDev.GetPciAddress();
                uint regValue = ols.ReadPciConfigDword(pciDev, reg);

                uint selectedValue = Convert.ToUInt32(DriveStrengthMode.Value);
                regValue = utils.SetBits(regValue, def.Offset, def.Bits, selectedValue);

                ols.WritePciConfigDwordEx(pciDev, 0xA4, regValue);
                ols.WritePciConfigDwordEx(pciDev, 0xAC, regValue);
                ols.WritePciConfigDwordEx(pciDev, 0xB4, regValue);
            }

            if (advancedTextBox1.Changed || advancedTextBox2.Changed || advancedTextBox3.Changed)
            {
                uint pciReg = utils.MakePciAddress(0, 0, 3, 0x64);
                uint romsip1 = ReadPciReg(pciReg);
                romsip1 = utils.SetBits(romsip1, 8, 8, advancedTextBox1.Value);
                romsip1 = utils.SetBits(romsip1, 16, 8, advancedTextBox2.Value);
                romsip1 = utils.SetBits(romsip1, 24, 8, advancedTextBox3.Value);
                WritePciReg(pciReg, romsip1);
            }

            if (advancedTextBox4.Changed || advancedTextBox5.Changed || advancedTextBox6.Changed || advancedTextBox7.Changed)
            {
                uint pciReg = utils.MakePciAddress(0, 0, 3, 0x68);
                uint romsip2 = ReadPciReg(pciReg);
                romsip2 = utils.SetBits(romsip2, 0, 8, advancedTextBox4.Value);
                romsip2 = utils.SetBits(romsip2, 8, 8, advancedTextBox5.Value);
                romsip2 = utils.SetBits(romsip2, 16, 8, advancedTextBox6.Value);
                romsip2 = utils.SetBits(romsip2, 24, 8, advancedTextBox7.Value);
                WritePciReg(pciReg, romsip2);
            }

            if (advancedTextBox8.Changed || advancedTextBox9.Changed || advancedTextBox10.Changed)
            {
                uint pciReg = utils.MakePciAddress(0, 0, 3, 0x6C);
                uint romsip3 = ReadPciReg(pciReg);
                romsip3 = utils.SetBits(romsip3, 0, 8, advancedTextBox8.Value);
                romsip3 = utils.SetBits(romsip3, 8, 8, advancedTextBox9.Value);
                romsip3 = utils.SetBits(romsip3, 24, 8, advancedTextBox10.Value);
                WritePciReg(pciReg, romsip3);
            }
        }

        private void ApplyChipsetTabSettings()
        {
            if (CPUDisconnect.Changed)
            {
                TimingDef def = TimingDefs.Find(x => x.Name == CPUDisconnect.Name);
                byte reg = def.PciDev.Offset;
                uint pciDev = def.PciDev.GetPciAddress();
                uint regValue = ols.ReadPciConfigDword(pciDev, reg);

                uint selectedValue = Convert.ToUInt32(CPUDisconnect.Value);
                regValue = utils.SetBits(regValue, def.Offset, def.Bits, selectedValue);
                regValue = utils.SetBits(regValue, 31, 1, ~selectedValue);

                ols.WritePciConfigDword(pciDev, reg, regValue);
            }

            WriteTimings(new nForce2XTLibrary.TimingItem[] { AGPFastWrite });
            WriteTimings(new nForce2XTLibrary.TimingItem[] { AGPSBA });
            WriteTimings(new nForce2XTLibrary.TimingItem[] { AGPControllerLatency });
            WriteTimings(new nForce2XTLibrary.TimingItem[] { AGPBusLatency });
            WriteTimings(new nForce2XTLibrary.TimingItem[] { PCILatency });
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            if (tabControlSettings.SelectedIndex == 0)
            {
                ApplyDRAMTabSettings();
            }
            else
            {
                ApplyChipsetTabSettings();
            }

            ReadTimings();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                trayIcon.Visible = true;
            }
        }

        private void ShowWindow()
        {
            Show();
            Activate();
            BringToFront();
            WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowWindow();
        }

        private void TrayMenuItemExit_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                ShowWindow();
            }
            base.WndProc(ref m);
        }

        private void ExitApp()
        {
            Dispose();
            Application.Exit();
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        }

        static void MinimizeFootprint()
        {
            NativeMethods.EmptyWorkingSet(Process.GetCurrentProcess().Handle);
        }

        // Get rid of flicker on form when painting child user controls
        int originalExStyle = -1;
        bool enableFormLevelDoubleBuffering = true;

        protected override CreateParams CreateParams
        {
            get
            {
                if (originalExStyle == -1)
                    originalExStyle = base.CreateParams.ExStyle;

                CreateParams cp = base.CreateParams;
                if (enableFormLevelDoubleBuffering)
                    cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                else
                    cp.ExStyle = originalExStyle;

                return cp;
            }
        }

        private void TurnOffFormLevelDoubleBuffering()
        {
            enableFormLevelDoubleBuffering = false;
            MinimizeBox = true;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            SplashForm.CloseForm();
            ShowWindow();
            MinimizeFootprint();
            TurnOffFormLevelDoubleBuffering();
        }
    }
}
