using System;
using System.Threading;

using PentWareX.SDK;

namespace PentWareX.Threaduri
{
    internal class Trigger
    {
        public static void Run()
        {
            while (true)
            {
                Thread.Sleep(1);

                if (
                    !Checks.IsIngame
                    || !Structs.LocalPlayer.Health.IsAlive()
                    || !Structs.Enemy_Crosshair.Health.IsAlive()
                    || !Structs.Enemy_Crosshair.Team.HasTeam()
                    || Structs.Enemy_Crosshair.Team.IsMyTeam()
                    || Structs.Enemy_Crosshair.Dormant) continue;

                if (Settings.Trigger.Delay > 0) Thread.Sleep(Settings.Trigger.Delay);

                Globals.Imports.mouse_event(Mouse.MOUSEEVENTF_LEFTDOWN | Mouse.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            }
        }
    }
}
