using System;

namespace nForce2XT.Components
{
    class TimingDef
    {
        public TimingDef(string name, PciDev pciDev, int offset, int bits)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            PciDev = pciDev ?? throw new ArgumentNullException(nameof(pciDev)); ;
            Offset = offset;
            Bits = bits;
        }

        public string Name { get; set; }
        public PciDev PciDev { get; set; }
        public int Offset { get; set; }
        public int Bits { get; set; }
    }
}
