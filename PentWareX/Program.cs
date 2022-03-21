using System;
using System.Collections.Generic;
using System.Management;
using System.Threading;

using PentWareX.SDK;
using PentWareX.Utilitati;
using PentWareX.Threaduri;
using System.Linq;

namespace PentWareX
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            //ManagementObjectSearcher query = new ManagementObjectSearcher("select * from Win32_DiskDrive");
            //foreach (ManagementObject disk in query.Get())
            //{

            //    string serialnumber = "W382455E";
            //    string sn = disk["Serialnumber"].ToString();
            //    var result = sn.Substring(sn.Length - 16);

            //    if (result == serialnumber)
            //    {
            //        Console.WriteLine(" Starting PentWare...");
            //        Thread.Sleep(2000);
            //        Console.Clear();
            //        LoadPentWare();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Serialul este invalid !");
            //        Thread.Sleep(5000);
            //        Environment.Exit(1);
            //    }
            //}

            Console.WriteLine("* PENTWARE#~:  Starting PentWareX...");
            Thread.Sleep(1000);
            Console.Clear();
            LoadPentWare();
        }

        public static string RandomString(int length)
        {
            const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static void LoadPentWare()
        {
            Console.SetWindowSize(150, 30);

            Console.Title = RandomString(10);

            Globals.Proc.Process = Extensions.Proc.WaitForProcess(Globals.Proc.Name);

            Extensions.Proc.WaitForModules(Globals.Proc.Modules, Globals.Proc.Name);

            MemoryManager.Initialize(Globals.Proc.Process.Id);

            List<string> outdatedSignatures = Offsets.ScanPatterns();

            if (outdatedSignatures.Count > 0)
            {
                foreach (string sig in outdatedSignatures) Extensions.Error($"* PENTWARE#~:  Offseturile sunt invalide: { sig }", 0, false);

                Console.ReadKey();
            }

            string titlu = @"

    ______ _____ _   _ _____ _    _  ___  ______ _____        .o oOOOOOOOo                                            OOOo
    | ___ \  ___| \ | |_   _| |  | |/ _ \ | ___ \  ___|          Ob.OOOOOOOo  OOOo.      oOOo.                      .adOOOOOOO
    | |_/ / |__ |  \| | | | | |  | / /_\ \| |_/ / |__             OboO''''''''''''.OOo. .oOOOOOo.    OOOo.oOOOOOo..'''''''''OO
    |  __/|  __|| . ` | | | | |/\| |  _  ||    /|  __|            OOP.oOOOOOOOOOOO ''POOOOOOOOOOOo.   `''OOOOOOOOOP,OOOOOOOOOOOB'
    | |   | |___| |\  | | | \  /\  / | | || |\ \| |___             `O'OOOO'     `OOOOo''OOOOOOOOOOO` .adOOOOOOOOO''oOOO'OOOO`OOOOo
    \_|   \____/\_| \_/ \_/  \/  \/\_| |_/\_| \_\____/             .OOOO'            `OOOOOOOOOOOOOOOOOOOOOOO'               `OOOO
                                                                OOOOO                 '''OOOOOOOOOOOOOOOO''`                 OOO
    |---------------------------------------------|              oOOOOOba.                .adOOOOOOOOOOba.                   'OOOO
    | PENTWARE #   Glow:                  NUMPAD0 |             oOOOOOOOOOOOOOba.OOOO..adOOOOOOOOOOOOOOOOOOOba.         .OOOOOOOO
    | PENTWARE #   Aimbot:                NUMPAD1 |            OOOOOOOOOOOOOOOOO.OOOOOOOOOOOOOO`     'OOOOOOOOOOO.OOOOOOOOOOOOOOOO
    | PENTWARE #   Trigger:               NUMPAD2 |            ''OOOO'       'YOoOOOOMOIONODOO''      '''OOROAOPOEOOOoOY''     ''OOO''
    | PENTWARE #   Bunnyhop:              NUMPAD3 |               Y           'OOOOOOOOOOOOOO: .o....o. :OOOOOOOOOOO?'               :`
    | PENTWARE #   Radar:                 NUMPAD4 |               :            .oO % OOOOOOOOOOo.OOOOOO.oOOOOOOOOOOOO?.
    | PENTWARE #   Antiflash:             NUMPAD5 |                         .oOOP''%OOOOOOOOoOOOOOOO?oOOOOO?OOOO''OOoOo.
    |---------------------------------------------|                            '%o  OOOO''%OOOO%''%OOOOO''OOOOOO''OOO':
                                                                                    `$''  `OOOO' `O''Y ' `OOOO'  o.
                                                                    D               .OP          : o     I                      K 
                                                                             3                  :                     L 
                                                                                                V                                      
";
            foreach (char caracter in titlu)
            {
                //Thread.Sleep(3);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(caracter);
            }
            Console.WriteLine("\n\n\n");

            ThreadManager.Add("Watcher", Watcher.Run);
            ThreadManager.Add("Reader", Reader.Run);

            ThreadManager.Add("Bunnyhop", Bunnyhop.Run);
            ThreadManager.Add("Trigger", Trigger.Run);
            ThreadManager.Add("Glow", Glow.Run);
            ThreadManager.Add("Radar", Radar.Run);
            ThreadManager.Add("Aimbot", Aimbot.Run);
            ThreadManager.Add("Antiflash", Antiflash.Run);

            ThreadManager.ToggleThread("Watcher");
            ThreadManager.ToggleThread("Reader");

            if (Settings.Bunnyhop.Enabled) ThreadManager.ToggleThread("Bunnyhop");
            if (Settings.Trigger.Enabled) ThreadManager.ToggleThread("Trigger");
            if (Settings.Glow.Enabled) ThreadManager.ToggleThread("Glow");
            if (Settings.Radar.Enabled) ThreadManager.ToggleThread("Radar");
            if (Settings.Aimbot.Enabled) ThreadManager.ToggleThread("Aimbot");
            if (Settings.Antiflash.Enabled) ThreadManager.ToggleThread("Antiflash");
        }
    }
}
