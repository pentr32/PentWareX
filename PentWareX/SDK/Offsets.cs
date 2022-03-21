using System;
using System.Collections.Generic;

using PentWareX.Utilitati;

namespace PentWareX.SDK
{
    internal class Offsets
    {
        public static List<string> ScanPatterns()
        {
            List<string> outdatedSignatures = new List<string> { };

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            dwGlowObjectManager = MemoryManager.ScanPattern((int)Structs.Base.Client, "A1????????A801754B", 1, 4, true);
            {
                if (dwGlowObjectManager == 0) outdatedSignatures.Add("dwGlowObjectManager");


                Console.WriteLine($"dwGlowObjectManager    ->      0x{ dwGlowObjectManager.ToString("X") }", true);
            }

            dwEntityList = MemoryManager.ScanPattern((int)Structs.Base.Client, "BB????????83FF010F8C????????3BF8", 1, 0, true);
            {
                if (dwEntityList == 0) outdatedSignatures.Add("dwEntityList");

                Console.WriteLine($"dwEntityList           ->      0x{ dwEntityList.ToString("X") }", true);
            }

            dwClientState = MemoryManager.ScanPattern((int)Structs.Base.Engine, "A1????????33D26A006A0033C989B0", 1, 0, true);
            {
                if (dwClientState == 0) outdatedSignatures.Add("dwClientState");

                Console.WriteLine($"dwClientState          ->      0x{ dwClientState.ToString("X") }", true);
            }

            dwForceJump = MemoryManager.ScanPattern((int)Structs.Base.Client, "8B0D????????8BD68BC183CA02", 2, 0, true);
            {
                if (dwForceJump == 0) outdatedSignatures.Add("dwForceJump");

                Console.WriteLine($"dwForceJump            ->      0x{ dwForceJump.ToString("X") }", true);
            }

            dwLocalPlayer = MemoryManager.ScanPattern((int)Structs.Base.Client, "8D?34?85?????????89?15", 3, 4, true);
            {
                if (dwLocalPlayer == 0) outdatedSignatures.Add("dwLocalPlayer");

                Console.WriteLine($"dwLocalPlayer          ->      0x{ dwLocalPlayer.ToString("X") }", true);
            }

            dwRadarBase = MemoryManager.ScanPattern((int)Structs.Base.Client, "A1????????8B0CB08B01FF50??463B35????????7CEA8B0D", 1, 0, true);
            {
                if (dwRadarBase == 0) outdatedSignatures.Add("dwRadarBase");

                Console.WriteLine($"dwRadarBase            ->      0x{ dwRadarBase.ToString("X") }", true);
            }

            Console.WriteLine("\n\n");

            //Console.ForegroundColor = ConsoleColor.Gray;
            //Console.WriteLine("= Module =");
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("client_panorama.dll" + "\n" + "engine.dll");

            return outdatedSignatures;
        }

        public const Int32 m_ArmorValue = 0x117CC;
        public const Int32 m_Collision = 0x320;
        public const Int32 m_CollisionGroup = 0x474;
        public const Int32 m_Local = 0x2FCC;
        public const Int32 m_MoveType = 0x25C;
        public const Int32 m_OriginalOwnerXuidHigh = 0x31D4;
        public const Int32 m_OriginalOwnerXuidLow = 0x31D0;
        public const Int32 m_aimPunchAngle = 0x303C;
        public const Int32 m_aimPunchAngleVel = 0x3048;
        public const Int32 m_bGunGameImmunity = 0x9990;
        public const Int32 m_bHasDefuser = 0x117DC;
        public const Int32 m_bHasHelmet = 0x117C0;
        public const Int32 m_bInReload = 0x32B5;
        public const Int32 m_bIsDefusing = 0x997C;
        public const Int32 m_bIsScoped = 0x9974;
        public const Int32 m_bSpotted = 0x93D;
        public const Int32 m_bSpottedByMask = 0x980;
        public const Int32 m_dwBoneMatrix = 0x26A8;
        public const Int32 m_fAccuracyPenalty = 0x3340;
        public const Int32 m_fFlags = 0x104;
        public const Int32 m_flFallbackWear = 0x31E0;
        public const Int32 m_flFlashDuration = 0x10470;
        public const Int32 m_flFlashMaxAlpha = 0x1046C;
        public const Int32 m_flNextPrimaryAttack = 0x3248;
        public const Int32 m_hActiveWeapon = 0x2F08;
        public const Int32 m_hMyWeapons = 0x2E08;
        public const Int32 m_hObserverTarget = 0x339C;
        public const Int32 m_hOwner = 0x29DC;
        public const Int32 m_hOwnerEntity = 0x14C;
        public const Int32 m_iAccountID = 0x2FD8;
        public const Int32 m_iClip1 = 0x3274;
        public const Int32 m_iCrosshairId = 0x11838;
        public const Int32 m_iEntityQuality = 0x2FBC;
        public const Int32 m_iFOVStart = 0x31F8;
        public const Int32 m_iGlowIndex = 0x10488;
        public const Int32 m_iHealth = 0x100;
        public const Int32 m_iItemDefinitionIndex = 0x2FBA;
        public const Int32 m_iItemIDHigh = 0x2FD0;
        public const Int32 m_iObserverMode = 0x3388;
        public const Int32 m_iShotsFired = 0x103E0;
        public const Int32 m_iState = 0x3268;
        public const Int32 m_iTeamNum = 0xF4;
        public const Int32 m_lifeState = 0x25F;
        public const Int32 m_nFallbackPaintKit = 0x31D8;
        public const Int32 m_nFallbackSeed = 0x31DC;
        public const Int32 m_nFallbackStatTrak = 0x31E4;
        public const Int32 m_nForceBone = 0x268C;
        public const Int32 m_nTickBase = 0x3440;
        public const Int32 m_rgflCoordinateFrame = 0x444;
        public const Int32 m_szCustomName = 0x304C;
        public const Int32 m_szLastPlaceName = 0x35C4;
        public const Int32 m_vecOrigin = 0x138;
        public const Int32 m_vecVelocity = 0x114;
        public const Int32 m_vecViewOffset = 0x108;
        public const Int32 m_viewPunchAngle = 0x3030;

        public const Int32 m_bDormant = 0xED;
        public const Int32 m_clrRender = 0x70;

        public const Int32 dwClientState_ViewAngles = 0x4D90;
        public const Int32 dwClientState_State = 0x108;
        public const Int32 dwClientState_MaxPlayer = 0x388;

        public static Int32 dwGlowObjectManager = 0x0;
        public static Int32 dwEntityList = 0x0;
        public static Int32 dwClientState = 0x0;
        public static Int32 dwForceJump = 0x0;
        public static Int32 dwLocalPlayer = 0x0;
        public static Int32 dwRadarBase = 0x0;
    }
}
