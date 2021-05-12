using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace nForce2XT.Utils
{
    public class QueryPerformance
    {
        [DllImport("Kernel32.dll", SetLastError = true)]
        private static extern IntPtr VirtualAlloc(IntPtr lpAddress, UIntPtr dwSize, uint flAllocationType, uint flProtect);

        [DllImport("Kernel32.dll", SetLastError = true)]
        private static extern bool VirtualFree(IntPtr lpAddress, UIntPtr dwSize, uint dwFreeType);

        private const uint PAGE_EXECUTE_READWRITE = 0x40;
        private const uint MEM_COMMIT = 0x1000;
        private const uint MEM_RELEASE = 0x00008000;
        private IntPtr Alloc(byte[] bytes)
        {
            var pAddress = VirtualAlloc(IntPtr.Zero, (UIntPtr)bytes.Length, MEM_COMMIT, PAGE_EXECUTE_READWRITE);
            Marshal.Copy(bytes, 0, pAddress, bytes.Length);
            return pAddress;
        }

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpFrequency);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate ulong RDTSC();
        private static RDTSC pRDTSC;

        private static readonly byte[] RDTSC_32 = new byte[] {
            0x0F, 0x31,                     // rdtsc
            0xC3                            // ret 
        };

        private static long GetQPCTime()
        {
            QueryPerformanceCounter(out long qpcTime);
            return qpcTime;
        }

        private static long GetQPCRate()
        {
            QueryPerformanceFrequency(out long qpcRate);
            return qpcRate;
        }

        public QueryPerformance() { }

        public double MeasureCpuSpeed()
        {
            IntPtr pAddress = Alloc(RDTSC_32);
            double qpcRate = GetQPCRate();
            //uint eax = 0;
            //uint edx = 0;
            double frequency = -1;
            int retries = 6;

            pRDTSC = (RDTSC)Marshal.GetDelegateForFunctionPointer(pAddress, typeof(RDTSC));

            while (frequency < 0 && retries > 0)
            {
                //ols.Rdtsc(ref eax, ref edx);
                long rdtscStart = (long)pRDTSC(); // eax;
                long qpcStart = GetQPCTime();

                Thread.Sleep(50);

                //ols.Rdtsc(ref eax, ref edx);
                long rdtscEnd = (long)pRDTSC();  //eax;

                long rdtscElapsed = rdtscEnd - rdtscStart;
                long qpcElapsed = GetQPCTime() - qpcStart;

                // frequency = 1.0e6 * rdtscElapsed / (qpcElapsed / qpcRate) / 1000000000000;
                frequency = rdtscElapsed / (qpcElapsed / qpcRate) / 1000000;
                retries--;
            }

            VirtualFree(pAddress, (UIntPtr)RDTSC_32.Length, MEM_RELEASE);

            if (frequency == -1)
                return 0;
            else
                return frequency;
        }
    }
}
