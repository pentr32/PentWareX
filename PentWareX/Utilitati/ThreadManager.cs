using System;
using System.Threading;
using System.Collections.Generic;

using PentWareX.SDK;
using System.Runtime.InteropServices;

namespace PentWareX.Utilitati
{
    internal class ThreadManager
    {
        [DllImport("kernel32.dll")]
        private static extern int Beep(int dwFreq, int dwDuration);

        public static Dictionary<string, Thread> threads = new Dictionary<string, Thread>();
        public static Dictionary<string, Thread> activeThreads = new Dictionary<string, Thread>();
        public static Dictionary<string, Thread> pausedThreads = new Dictionary<string, Thread>();

        public static void Add(string name, ThreadStart function)
        {
            if (threads.TryGetValue(name, out Thread temp)) return;

            threads.Add(name, new Thread(function));
        }

        public static void ToggleThread(string name)
        {
            if (activeThreads.TryGetValue(name, out Thread temp))
            {
                #pragma warning disable CS0618 // Typ oder Element ist veraltet
                temp.Suspend();
                #pragma warning restore CS0618 // Typ oder Element ist veraltet

                activeThreads.Remove(name);
                Beep(250, 100);

                pausedThreads.Add(name, temp);

                Extensions.Information($"* PENTWARE#~:  { name }    ->      * OFF * ", true);
            }
            else
            {
                if (!threads.TryGetValue(name, out temp))
                {
                    Extensions.Error("* PENTWARE#~:  Nu am putut initializa A5????B3N8??C4?? PentWare %%% /0x50/0x2C/0xF4/0xFC/", 1500, false);
                    return;
                }

                if (pausedThreads.TryGetValue(name, out Thread temp2))
                {
                    #pragma warning disable CS0618 // Typ oder Element ist veraltet
                    temp2.Resume();
                    Beep(300, 100);

                    #pragma warning restore CS0618 // Typ oder Element ist veraltet

                    pausedThreads.Remove(name);

                    Extensions.Information($"* PENTWARE#~:  { name }    ->      * ON * ", true);
                }
                else
                {
                    temp.Start();

                    Extensions.Information($"* PENTWARE#~:  { name }    ->      * Intializat * ", true);
                }

                activeThreads.Add(name, temp);
            }
        }
    }
}
