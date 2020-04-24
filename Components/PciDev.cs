namespace nForce2XT.Components
{
    public class PciDev
    {
        public PciDev(uint bus, uint device, uint function, byte offset)
        {
            Bus = bus;
            Device = device;
            Function = function;
            Offset = offset;
        }

        public uint Bus { get; set; } = 0;
        public uint Device { get; set; } = 0;
        public uint Function { get; set; } = 0;
        public byte Offset { get; set; } = 0;

        // Ols-compatible PCI Device Address
        public uint GetPciAddress()
        {
            return ((Bus & 0xFF) << 8) | ((Device & 0x1F) << 3) | (Function & 7);
        }

        public uint GetPciAddressFull()
        {
            return 0x80000000 | Bus << 16 | Device << 11 | Function << 8 | Offset;
        }
    }
}