using System.Drawing;
using System.Threading;

using PentWareX.SDK;
using PentWareX.Utilitati;

namespace PentWareX.Threaduri
{
    internal class Glow
    {
        public static void Run()
        {
            while (true)
            {
                //Thread.Sleep(10);

                //if (!Checks.IsIngame) continue;

                //int gObject = MemoryManager.ReadMemory<int>((int)Structs.Base.Client + Offsets.dwGlowObjectManager);
                ////int gCount = MemoryManager.ReadMemory<int>((int)Structs.Base.Client + Offsets.dwGlowObjectManager + 0x4);

                ////byte[] gEntities = MemoryManager.ReadMemory(gObject, gCount * 0x32);


                //for (int i = 0; i < 64; i++)
                //{
                //    int gEntity = MemoryManager.ReadMemory<int>((i * 0x38) + Offsets.dwGlowObjectManager);

                //    // int gEntity = Math.GetInt(, i * 0x32);

                //    //int gEntity = MemoryManager.ReadMemory<int>((i * 0x38) + gObject);
                //    if (gEntity == 0) continue;

                //    int classID = Extensions.Other.GetClassID(gEntity);
                //    if (classID < 0) continue;

                //    if (Settings.Glow.C4 && Checks.IsC4(classID))
                //    {
                //        Structs.Glow_t currGlowObject = MemoryManager.ReadMemory<Structs.Glow_t>((gObject + (i * 0x38) + 0x4));

                //        currGlowObject.r = Settings.Glow.C4_Color_R / 255f;
                //        currGlowObject.g = Settings.Glow.C4_Color_G / 255f;
                //        currGlowObject.b = Settings.Glow.C4_Color_B / 255f;
                //        currGlowObject.a = Settings.Glow.C4_Color_A / 255f;
                //        currGlowObject.m_bRenderWhenOccluded = true;
                //        currGlowObject.m_bRenderWhenUnoccluded = false;

                //        if (Settings.Glow.FullBloom) currGlowObject.m_bFullBloom = true;

                //        MemoryManager.WriteMemory<Structs.Glow_t>((gObject + (i * 0x38) + 0x8), currGlowObject);
                //    }
                //    else if (Settings.Glow.Grenades && Checks.IsGrenade(classID))
                //    {
                //        Structs.Glow_t currGlowObject = MemoryManager.ReadMemory<Structs.Glow_t>((gObject + (i * 0x38) + 0x4));

                //        currGlowObject.r = Settings.Glow.Grenades_Color_R / 255f;
                //        currGlowObject.g = Settings.Glow.Grenades_Color_G / 255f;
                //        currGlowObject.b = Settings.Glow.Grenades_Color_B / 255f;
                //        currGlowObject.a = Settings.Glow.Grenades_Color_A / 255f;
                //        currGlowObject.m_bRenderWhenOccluded = true;
                //        currGlowObject.m_bRenderWhenUnoccluded = false;

                //        if (Settings.Glow.FullBloom) currGlowObject.m_bFullBloom = true;

                //        MemoryManager.WriteMemory<Structs.Glow_t>((gObject + (i * 0x38) + 0x4), currGlowObject);
                //    }
                //    else if (Settings.Glow.Allies || Settings.Glow.Enemies && classID == (int)Enums.ClassIDs.CCSPlayer)
                //    {
                //        Structs.Enemy_t glowEntity = MemoryManager.ReadMemory<Structs.Enemy_t>(gEntity);

                //        int local = MemoryManager.ReadMemory<int>((int)Structs.Base.Client + Offsets.dwLocalPlayer);
                //        //bool IsVisible = EntIsVisible(gEntity);
                //        bool IsFlashed = EntIsFlashed(gEntity);
                //        bool IsDefusing = EntIsDefusing(gEntity);

                //        if (
                //             glowEntity.Dormant 
                //             || !glowEntity.Team.HasTeam()            
                //             || glowEntity.Dormant) continue;


                //        if (Settings.Glow.Enemies && !glowEntity.Team.IsMyTeam())
                //        {
                //            if (Settings.Glow.PlayerColorMode == 0)
                //            {

                //            Structs.Glow_t currGlowObject = MemoryManager.ReadMemory<Structs.Glow_t>((gObject + (i * 0x38) + 0x4));

                //            Color color = Extensions.Colors.FromHealth(glowEntity.Health / 100f);

                //            currGlowObject.r = color.R / 255f;
                //            currGlowObject.g = color.G / 255f;
                //            currGlowObject.b = color.B / 255f;
                //            currGlowObject.a = Settings.Glow.Enemies_Color_A / 255f;

                //            if (IsFlashed)
                //            {
                //                currGlowObject.r = 30 / 255f;
                //                currGlowObject.g = 100 / 255f;
                //                currGlowObject.b = 160 / 255f;
                //                currGlowObject.a = 250 / 255f;
                //            }

                //            if (IsDefusing)
                //            {
                //                currGlowObject.r = 0 / 255f;
                //                currGlowObject.g = 150 / 255f;
                //                currGlowObject.b = 104 / 255f;
                //                currGlowObject.a = 220 / 255f;
                //            }           

                //            currGlowObject.m_bRenderWhenOccluded = true;
                //            currGlowObject.m_bRenderWhenUnoccluded = false;

                //            if (Settings.Glow.FullBloom) currGlowObject.m_bFullBloom = true;

                //            MemoryManager.WriteMemory<Structs.Glow_t>((gObject + (i * 0x38) + 0x4), currGlowObject);

                //            }
                //            else if (Settings.Glow.PlayerColorMode == 1)
                //            {
                //                Structs.Glow_t currGlowObject = MemoryManager.ReadMemory<Structs.Glow_t>((gObject + (i * 0x38) + 0x4));

                //                currGlowObject.r = Settings.Glow.Enemies_Color_R / 255f;
                //                currGlowObject.g = Settings.Glow.Enemies_Color_G / 255f;
                //                currGlowObject.b = Settings.Glow.Enemies_Color_B / 255f;
                //                currGlowObject.a = Settings.Glow.Enemies_Color_A / 255f;
                //                currGlowObject.m_bRenderWhenOccluded = true;
                //                currGlowObject.m_bRenderWhenUnoccluded = false;

                //                if (Settings.Glow.FullBloom) currGlowObject.m_bFullBloom = true;

                //                MemoryManager.WriteMemory<Structs.Glow_t>((gObject + (i * 0x38) + 0x4), currGlowObject);
                //            }
                //        }

                //        if (Settings.Glow.Allies && glowEntity.Team.IsMyTeam())
                //        {
                //            if (Settings.Glow.PlayerColorMode == 0)
                //            {
                //                Structs.Glow_t currGlowObject = MemoryManager.ReadMemory<Structs.Glow_t>((gObject + (i * 0x38) + 0x4));

                //                Color color = Extensions.Colors.FromHealth(glowEntity.Health / 100f);

                //                currGlowObject.r = color.R / 255f;
                //                currGlowObject.g = color.G / 255f;
                //                currGlowObject.b = color.B / 255f;
                //                currGlowObject.a = Settings.Glow.Allies_Color_A / 255f;
                //                currGlowObject.m_bRenderWhenOccluded = true;
                //                currGlowObject.m_bRenderWhenUnoccluded = false;

                //                if (Settings.Glow.FullBloom) currGlowObject.m_bFullBloom = true;

                //                MemoryManager.WriteMemory<Structs.Glow_t>((gObject + (i * 0x38) + 0x4), currGlowObject);
                //            }
                //            else if (Settings.Glow.PlayerColorMode == 1)
                //            {
                //                Structs.Glow_t currGlowObject = MemoryManager.ReadMemory<Structs.Glow_t>((gObject + (i * 0x38) + 0x4));

                //                currGlowObject.r = Settings.Glow.Allies_Color_R / 255f;
                //                currGlowObject.g = Settings.Glow.Allies_Color_G / 255f;
                //                currGlowObject.b = Settings.Glow.Allies_Color_B / 255f;
                //                currGlowObject.a = Settings.Glow.Allies_Color_A / 255f;
                //                currGlowObject.m_bRenderWhenOccluded = true;
                //                currGlowObject.m_bRenderWhenUnoccluded = false;

                //                if (Settings.Glow.FullBloom) currGlowObject.m_bFullBloom = true;

                //                MemoryManager.WriteMemory<Structs.Glow_t>((gObject + (i * 0x38) + 0x4), currGlowObject);
                //            }
                //        }
                //    }
                //}

                Thread.Sleep(10);

                if (!Checks.IsIngame) continue;

                int gObject = MemoryManager.ReadMemory<int>((int)Structs.Base.Client + Offsets.dwGlowObjectManager);

                for (int i = 0; i < Structs.ClientState.MaxPlayers; i++)
                {
                    int gEntity = MemoryManager.ReadMemory<int>((int)Structs.Base.Client + Offsets.dwEntityList + i * 0x10);
                    int gIndex = MemoryManager.ReadMemory<int>(gEntity + Offsets.m_iGlowIndex);

                    if (gEntity == 0) continue;

                    int classID = Extensions.Other.GetClassID(gEntity);
                    if (classID < 0) continue;

                    if (Settings.Glow.C4 && Checks.IsC4(classID))
                    {
                        Structs.Glow_t currGlowObject = MemoryManager.ReadMemory<Structs.Glow_t>((gObject + (gIndex * 0x38) + 0x8));

                        currGlowObject.r = Settings.Glow.C4_Color_R / 255f;
                        currGlowObject.g = Settings.Glow.C4_Color_G / 255f;
                        currGlowObject.b = Settings.Glow.C4_Color_B / 255f;
                        currGlowObject.a = Settings.Glow.C4_Color_A / 255f;
                        currGlowObject.m_bRenderWhenOccluded = true;
                        currGlowObject.m_bRenderWhenUnoccluded = false;

                        if (Settings.Glow.FullBloom) currGlowObject.m_bFullBloom = true;

                        MemoryManager.WriteMemory<Structs.Glow_t>((gObject + (gIndex * 0x38) + 0x8), currGlowObject);
                    }
                    else if (Settings.Glow.Grenades && Checks.IsGrenade(classID))
                    {
                        Structs.Glow_t currGlowObject = MemoryManager.ReadMemory<Structs.Glow_t>((gObject + (gIndex * 0x38) + 0x8));

                        currGlowObject.r = Settings.Glow.Grenades_Color_R / 255f;
                        currGlowObject.g = Settings.Glow.Grenades_Color_G / 255f;
                        currGlowObject.b = Settings.Glow.Grenades_Color_B / 255f;
                        currGlowObject.a = Settings.Glow.Grenades_Color_A / 255f;
                        currGlowObject.m_bRenderWhenOccluded = true;
                        currGlowObject.m_bRenderWhenUnoccluded = false;

                        if (Settings.Glow.FullBloom) currGlowObject.m_bFullBloom = true;

                        MemoryManager.WriteMemory<Structs.Glow_t>((gObject + (gIndex * 0x38) + 0x8), currGlowObject);
                    }

                    Structs.Enemy_t glowEntity = MemoryManager.ReadMemory<Structs.Enemy_t>(gEntity);

                    bool IsFlashed = EntIsFlashed(gEntity);
                    bool IsDefusing = EntIsDefusing(gEntity);

                    if (
                            glowEntity.Dormant
                            || !glowEntity.Team.HasTeam()
                            || glowEntity.Dormant) continue;


                    if (Settings.Glow.Enemies && !glowEntity.Team.IsMyTeam())
                    {
                        if (Settings.Glow.PlayerColorMode == 0)
                        {

                            Structs.Glow_t currGlowObject = MemoryManager.ReadMemory<Structs.Glow_t>((gObject + (gIndex * 0x38) + 0x8));

                            Color color = Extensions.Colors.FromHealth(glowEntity.Health / 100f);

                            currGlowObject.r = color.R / 255f;
                            currGlowObject.g = color.G / 255f;
                            currGlowObject.b = color.B / 255f;
                            currGlowObject.a = Settings.Glow.Enemies_Color_A / 255f;

                            if (IsFlashed)
                            {
                                currGlowObject.r = 30 / 255f;
                                currGlowObject.g = 100 / 255f;
                                currGlowObject.b = 160 / 255f;
                                currGlowObject.a = 250 / 255f;
                            }

                            if (IsDefusing)
                            {
                                currGlowObject.r = 0 / 255f;
                                currGlowObject.g = 150 / 255f;
                                currGlowObject.b = 104 / 255f;
                                currGlowObject.a = 220 / 255f;
                            }

                            currGlowObject.m_bRenderWhenOccluded = true;
                            currGlowObject.m_bRenderWhenUnoccluded = false;

                            if (Settings.Glow.FullBloom) currGlowObject.m_bFullBloom = true;

                            MemoryManager.WriteMemory<Structs.Glow_t>((gObject + (gIndex * 0x38) + 0x8), currGlowObject);

                        }
                    }
                }
            }
        }

        public static bool EntIsFlashed(int ent)
        {
            float entFlash = MemoryManager.ReadMemory<float>(ent + Offsets.m_flFlashDuration);

            if(entFlash > 0.1f)
            {
                return true;
            }

            return false;
        }

        public static bool EntIsDefusing(int ent)
        {
            bool entDefusing = MemoryManager.ReadMemory<bool>(ent + Offsets.m_bIsDefusing);

            if(entDefusing)
            {
                return true;
            }

            return false;
        }
    }
}
