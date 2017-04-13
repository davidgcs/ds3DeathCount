using IgroGadgets.Memory;
using System;

namespace DarkSouls_DeathCount.DeathCount
{
    class DeathCounter
    {
        private ProcessMemory ProcessMemory { get; set; }

        private IntPtr _heroBaseAddress;
        private IntPtr _deathAddress;

        public IntPtr DeathAddress => _deathAddress;

        public DeathCounter()
        {
            try
            {
                ProcessMemory = new ProcessMemory("DarkSoulsIII");
                InitHeroBaseAddress();
                InitDeathAddress();
            }
            catch (Exception e)
            {
                // ToDo bring NoAdminPrivilegesException and NoProcessFoundException to user. As MessageBox for example
                throw e;
            }
            
        }

        private void InitHeroBaseAddress()
        {
            try
            {
                IntPtr baseAddress = ProcessMemory.Process.MainModule.BaseAddress;
                SigScan sigScan = new SigScan(ProcessMemory.Process, IntPtr.Add(baseAddress, 0x580000), 0x20000);
                IntPtr address = sigScan.FindPattern(new byte[] { 0x48, 0x8B, 0x05, 0xFF, 0xFF, 0xFF, 0xFF, 0x48, 0x85, 0xC0, 0xFF, 0xFF, 0x48, 0x8b, 0x40, 0xFF, 0xC3 }, "xxx????xxx??xxx?x", 0);
                // Pointer logic from CE: heroBaseAddress = address + ReadMemoryInt(address + 3) + 7
                if (!address.Equals(IntPtr.Zero))
                {
                    int offset;
                    if (ProcessMemory.ReadMemoryInt(IntPtr.Add(address, 3), out offset))
                    {
                        _heroBaseAddress = IntPtr.Add(IntPtr.Add(address, offset),7);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void InitDeathAddress()
        {
            if (!_heroBaseAddress.Equals(IntPtr.Zero))
            {
                ProcessMemory.ReadPointer(_heroBaseAddress, new int[] {0x98}, out _deathAddress);
            }
        }

        public int GetDeaths()
        {
            var deaths = 0;
            if (!_deathAddress.Equals(IntPtr.Zero))
            {
                if (ProcessMemory.ReadMemoryInt(_deathAddress, out deaths))
                {
                    Console.WriteLine(deaths);
                }
            }
            return deaths;
        }
    }
}
