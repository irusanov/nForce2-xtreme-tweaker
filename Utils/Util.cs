using System;

namespace nForce2XT.Utils
{
    public class Util: IDisposable
    {
        public uint SetBits(uint val, int offset, int n, uint newValue)
        {
            return val & ~(((1U << n) - 1) << offset) | (newValue << offset);
        }

        public uint GetBits(uint val, int offset, int n)
        {
            return (val >> offset) & ~(~0U << n);
        }

        public uint MakePciAddress(uint bus, uint device, uint function, byte offset)
        {
            return 0x80000000 | bus << 16 | device << 11 | function << 8 | offset;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Util()
        // {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
