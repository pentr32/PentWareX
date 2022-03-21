namespace PentWareX.SDK
{
    internal class Settings
    {
        public struct OtherControls
        {
            public static int ToggleBunnyhop = Keyboard.VK_NUMPAD3;
            public static int ToggleTrigger = Keyboard.VK_NUMPAD2;
            public static int ToggleGlow = Keyboard.VK_NUMPAD0;
            public static int ToggleRadar = Keyboard.VK_NUMPAD4;
            public static int ToggleAimbot = Keyboard.VK_NUMPAD1;
            public static int ToggleAntiflash = Keyboard.VK_NUMPAD5;
        }

        public struct Radar
        {
            public static bool Enabled = false;
        }

        public struct Bunnyhop
        {
            public static bool Enabled = false;
            public static int Key = Keyboard.VK_SPACE;
        }

        public struct Trigger
        {
            public static bool Enabled = true;
            public static int Delay = 0;
        }

        public struct Antiflash
        {
            public static bool Enabled = false;
        }

        public struct Glow
        {
            public static bool Enabled = true;
            public static int PlayerColorMode = 0;
            public static bool FullBloom = false;

            public static bool C4 = true;
            public static float C4_Color_R = 231;
            public static float C4_Color_G = 76;
            public static float C4_Color_B = 60;
            public static float C4_Color_A = 255;

            public static bool Grenades = true;
            public static float Grenades_Color_R = 241;
            public static float Grenades_Color_G = 196;
            public static float Grenades_Color_B = 15;
            public static float Grenades_Color_A = 255;

            public static bool Enemies = true;
            public static float Enemies_Color_R = 192;
            public static float Enemies_Color_G = 57;
            public static float Enemies_Color_B = 43;
            public static float Enemies_Color_A = 180;

            public static bool Allies = false;
            public static float Allies_Color_R = 39;
            public static float Allies_Color_G = 174;
            public static float Allies_Color_B = 96;
            public static float Allies_Color_A = 200;
        }

        public struct Aimbot
        {
            public static bool Enabled = true;
            public static float Fov = 4f;
            public static int Bone = 8;
            public static float Smooth = 2f;
            public static bool VisibleCheck;
            public static bool RecoilControl = true;
            public static float YawRecoilReductionFactory = 2f;
            public static float PitchRecoilReductionFactory = 2f;
            public static bool Curve = false;
            public static float CurveY = 0.5f;
            public static float CurveX = 10f;
        }
    }
}
