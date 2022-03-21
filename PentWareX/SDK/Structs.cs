using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace PentWareX.SDK
{
    internal class Structs
    {
        public struct clrRender_t
        {
            public byte r;
            public byte g;
            public byte b;
            public byte a;
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe struct Glow_t
        {
            public float r;                         //0x8
            public float g;                         //0xC
            public float b;                         //0x10
            public float a;                         //0x14

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] junk1;

            public bool m_bRenderWhenOccluded;      //0x28
            public bool m_bRenderWhenUnoccluded;    //0x29
            public bool m_bFullBloom;               //0x2A
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct LocalPlayer_t
        {
            [FieldOffset(Offsets.m_lifeState)]
            public int LifeState;

            [FieldOffset(Offsets.m_iHealth)]
            public int Health;

            [FieldOffset(Offsets.m_fFlags)]
            public int Flags;

            [FieldOffset(Offsets.m_iTeamNum)]
            public int Team;

            [FieldOffset(Offsets.m_iShotsFired)]
            public int ShotsFired;

            [FieldOffset(Offsets.m_iCrosshairId)]
            public int CrosshairID;

            [FieldOffset(Offsets.m_bDormant)]
            public bool Dormant;

            [FieldOffset(Offsets.m_MoveType)]
            public int MoveType;

            [FieldOffset(Offsets.m_vecOrigin)]
            public Vector3 Position;

            [FieldOffset(Offsets.m_aimPunchAngle)]
            public Vector3 AimPunch;

            [FieldOffset(Offsets.m_vecViewOffset)]
            public Vector3 VecView;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Enemy_Crosshair_t
        {
            [FieldOffset(Offsets.m_iHealth)]
            public int Health;

            [FieldOffset(Offsets.m_flFlashDuration)]
            public int Flashed;

            [FieldOffset(Offsets.m_iTeamNum)]
            public int Team;

            [FieldOffset(Offsets.m_bDormant)]
            public bool Dormant;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Enemy_t
        {
            [FieldOffset(Offsets.m_iHealth)]
            public int Health;

            [FieldOffset(Offsets.m_iTeamNum)]
            public int Team;

            [FieldOffset(Offsets.m_bDormant)]
            public bool Dormant;

            [FieldOffset(Offsets.m_bSpotted)]
            public bool Spotted;

            [FieldOffset(Offsets.m_vecOrigin)]
            public Vector3 Position;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct ClientState_t
        {
            [FieldOffset(Offsets.dwClientState_State)]
            public int GameState;

            [FieldOffset(Offsets.dwClientState_MaxPlayer)]
            public int MaxPlayers;

            [FieldOffset(Offsets.dwClientState_ViewAngles)]
            public Vector3 ViewAngles;
        }

        public struct Base
        {
            public static IntPtr Client { get; set; }
            public static IntPtr Engine { get; set; }
        }

        public struct LocalPlayer
        {
            public static int Base { get; set; }
            public static int LifeState { get; set; }
            public static int Health { get; set; }
            public static bool Dormant { get; set; }
            public static int Flags { get; set; }
            public static int MoveType { get; set; }
            public static int Team { get; set; }
            public static int ShotsFired { get; set; }
            public static int CrosshairID { get; set; }
            public static Vector3 Position { get; set; }
            public static Vector3 AimPunch { get; set; }
            public static Vector3 VecView { get; set; }
        }

        public struct Enemy_Crosshair
        {
            public static int Base { get; set; }
            public static int Health { get; set; }
            public static int Flashed { get; set; }
            public static int Team { get; set; }
            public static bool Dormant { get; set; }
        }

        public struct Enemy
        {
            public static int Base { get; set; }
            public int Health { get; set; }
            public int Team { get; set; }
            public bool Dormant { get; set; }
            public bool Spotted { get; set; }
            public Vector3 Position { get; set; }
        }

        public struct ClientState
        {
            public static int Base { get; set; }
            public static int GameState { get; set; }
            public static int MaxPlayers { get; set; }
            public static Vector3 ViewAngles { get; set; }
        }
    }
}
