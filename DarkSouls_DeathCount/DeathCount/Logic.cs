using IgroGadgets.Memory;
using System;

namespace DarkSouls_DeathCount.DeathCount
{
    class Logic
    {
        private ProcessMemory ProcessMemory { get; set; }
        public IntPtr DeathAddress { get; private set; }

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
            DeathAddress = ProcessMemory.ReadPointer(0x14473a818, new int[] { 0x98 });
            Console.WriteLine(ProcessMemory.ReadMemoryInt(DeathAddress));
        }
    }
}
