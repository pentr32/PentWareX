using System;
using System.Threading;

using PentWareX.SDK;
using PentWareX.Utilitati;

namespace PentWareX.Threaduri
{
    internal class Antiflash
    {
        public static void Run()
        {
            while (true)
            {
                Thread.Sleep(5);

                int Local = MemoryManager.ReadMemory<int>((int)Structs.Base.Client + Offsets.dwLocalPlayer);
                int LocalFlash = MemoryManager.ReadMemory<int>(Local + Offsets.m_flFlashMaxAlpha);

                if (!Checks.IsIngame
                    || !Structs.LocalPlayer.Health.IsAlive()) continue;

                if (LocalFlash > 1)

                    MemoryManager.WriteMemory<int>(Local + Offsets.m_flFlashMaxAlpha, 0);
            }          
        }       
    }
}
