using System;
using System.Threading;

using PentWareX.SDK;

namespace PentWareX.Utilitati
{
    internal class Watcher
    {
        public static void Run()
        {
            while (true)
            {
                Thread.Sleep(75);

                if (Convert.ToBoolean((long)Globals.Imports.GetAsyncKeyState(Settings.OtherControls.ToggleGlow) & 0x8000)) ThreadManager.ToggleThread("Glow");
                if (Convert.ToBoolean((long)Globals.Imports.GetAsyncKeyState(Settings.OtherControls.ToggleAimbot) & 0x8000)) ThreadManager.ToggleThread("Aimbot");
                if (Convert.ToBoolean((long)Globals.Imports.GetAsyncKeyState(Settings.OtherControls.ToggleBunnyhop) & 0x8000)) ThreadManager.ToggleThread("Bunnyhop");
                if (Convert.ToBoolean((long)Globals.Imports.GetAsyncKeyState(Settings.OtherControls.ToggleTrigger) & 0x8000)) ThreadManager.ToggleThread("Trigger");
                
                if (Convert.ToBoolean((long)Globals.Imports.GetAsyncKeyState(Settings.OtherControls.ToggleRadar) & 0x8000)) ThreadManager.ToggleThread("Radar");
                if (Convert.ToBoolean((long)Globals.Imports.GetAsyncKeyState(Settings.OtherControls.ToggleAntiflash) & 0x8000)) ThreadManager.ToggleThread("Antiflash");

            }
        }
    }
}
