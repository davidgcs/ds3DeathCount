using IgroGadgets.Memory;
using System;

namespace DarkSouls_DeathCount.DeathCount
{
    class Logic
    {
        private ProcessMemory ProcessMemory { get; set; }

        private IntPtr _seathAddress;

        public IntPtr DeathAddress => _seathAddress;

        public Logic()
        {
            try
            {
                ProcessMemory = new ProcessMemory("DarkSoulsIII");
                ReadBasePointer();
            }
            catch (Exception e)
            {
                // ToDo bring NoAdminPrivilegesException and NoProcessFoundException to user. As MessageBox for example
                throw e;
            }
            
        }

        public void ReadBasePointer()
        {
            if (ProcessMemory.ReadPointer(0x14473a818, new int[] {0x98}, out _seathAddress))
            {
                int deaths = 0;
                if (ProcessMemory.ReadMemoryInt(_seathAddress, out deaths))
                {
                    Console.WriteLine(deaths);
                }
            }
        }
    }
}
