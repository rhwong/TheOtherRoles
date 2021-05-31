using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;
using Il2CppSystem;
using HarmonyLib;
using UnhollowerBaseLib;
using Assets.CoreScripts;

namespace TheOtherRoles {
    public class CustomColors {
        protected static Dictionary<int, string> ColorStrings = new Dictionary<int, string>();
        public static List<int> lighterColors = new List<int>(){ 3, 4, 5, 7, 10, 11};
        public static uint pickableColors = 12;

        public static void Load() {
            List<StringNames> longlist = Enumerable.ToList<StringNames>(Palette.ColorNames);
            List<StringNames> shortlist = Enumerable.ToList<StringNames>(Palette.ShortColorNames);
            List<Color32> colorlist = Enumerable.ToList<Color32>(Palette.PlayerColors);
            List<Color32> shadowlist = Enumerable.ToList<Color32>(Palette.ShadowColors);

            List<CustomColor> colors = new List<CustomColor>();

            colors.Add(new CustomColor { longname = "鲑鱼粉", shortname = "深粉", 
                                        color = new Color32(239, 191, 192, byte.MaxValue), 
                                        shadow = new Color32(182, 119, 114, byte.MaxValue),
                                        isLighterColor = true });
            colors.Add(new CustomColor { longname = "波尔多红", shortname = "酒红", 
                                        color = new Color32(109, 7, 26, byte.MaxValue), 
                                        shadow = new Color32(54, 2, 11, byte.MaxValue),
                                        isLighterColor = false });
            colors.Add(new CustomColor { longname = "青果绿", shortname = "青绿", 
                                        color = new Color32(154, 140, 61, byte.MaxValue), 
                                        shadow = new Color32(104, 95, 40, byte.MaxValue),
                                        isLighterColor = false });
            colors.Add(new CustomColor { longname = "绿松石蓝", shortname = "翠蓝", 
                                        color = new Color32(22, 132, 176, byte.MaxValue), 
                                        shadow = new Color32(15, 89, 117, byte.MaxValue),
                                        isLighterColor = false });
            colors.Add(new CustomColor { longname = "薄荷绿", shortname = "浅绿", 
                                        color = new Color32(111, 192, 156, byte.MaxValue), 
                                        shadow = new Color32(65, 148, 111, byte.MaxValue),
                                        isLighterColor = true });
            colors.Add(new CustomColor { longname = "薰衣草紫", shortname = "淡紫", 
                                        color = new Color32(173, 126, 201, byte.MaxValue), 
                                        shadow = new Color32(131, 58, 203, byte.MaxValue),
                                        isLighterColor = true });
            colors.Add(new CustomColor { longname = "杏仁糖棕", shortname = "棕褐", 
                                        color = new Color32(160, 101, 56, byte.MaxValue), 
                                        shadow = new Color32(115, 15, 78, byte.MaxValue),
                                        isLighterColor = false });
            colors.Add(new CustomColor { longname = "桃子粉", shortname = "桃粉", 
                                        color = new Color32(255, 164, 119, byte.MaxValue), 
                                        shadow = new Color32(238, 128, 100, byte.MaxValue),
                                        isLighterColor = true });
            colors.Add(new CustomColor { longname = "芥末绿", shortname = "芥绿", 
                                        color = new Color32(112, 143, 46, byte.MaxValue), 
                                        shadow = new Color32(72, 92, 29, byte.MaxValue),
                                        isLighterColor = true });
            colors.Add(new CustomColor { longname = "热情亮粉色", shortname = "亮粉", 
                                        color = new Color32(255, 51, 102, byte.MaxValue), 
                                        shadow = new Color32(232, 0, 58, byte.MaxValue),
                                        isLighterColor = true });
            colors.Add(new CustomColor { longname = "灰色", shortname = "灰色", 
                                        color = new Color32(147, 147, 147, byte.MaxValue), 
                                        shadow = new Color32(120, 120, 120, byte.MaxValue),
                                        isLighterColor = false });
            colors.Add(new CustomColor { longname = "沥青蓝", shortname = "青蓝", 
                                        color = new Color32(0, 99, 105, byte.MaxValue), 
                                        shadow = new Color32(0, 61, 54, byte.MaxValue),
                                        isLighterColor = false });

            pickableColors += (uint)colors.Count; // Colors to show in Tab
            /** Hidden Colors **/
            colors.Add(new CustomColor { longname = "熊猫色", shortname = "熊猫", 
                                        color = new Color32(255, 255, 255, 0), 
                                        shadow = new Color32(12, 12, 12, 0),
                                        isLighterColor = true });
            colors.Add(new CustomColor { longname = "午夜黑", shortname = "深黑", 
                                        color = new Color32(64, 8, 71, 0), 
                                        shadow = new Color32(24, 32, 116, 0),
                                        isLighterColor = false });

            /** Batch 2 **/
            colors.Add(new CustomColor { longname = "皮卡丘黄", shortname = "深黄", 
                                        color = new Color32(0xDB, 0xFD, 0x2F, 0), 
                                        shadow = new Color32(0x89, 0x9E, 0x1E, 0),
                                        isLighterColor = true });
            colors.Add(new CustomColor { longname = "信号橙", shortname = "橙黄", 
                                        color = new Color32(0xF7, 0x44, 0x17, 0), 
                                        shadow = new Color32(0x9B, 0x2E, 0x0F, 0),
                                        isLighterColor = true });        
            colors.Add(new CustomColor { longname = "海军蓝", shortname = "军蓝", 
                                        color = new Color32(0x35, 0x7B, 0x9E, 0), 
                                        shadow = new Color32(0x16, 0x2B, 0x62, 0),
                                        isLighterColor = false });      
            colors.Add(new CustomColor { longname = "Eisbison蓝", shortname = "浅蓝", 
                                        color = new Color32(0xA8, 0xDF, 0xFF, 0), 
                                        shadow = new Color32(0x59, 0x9F, 0xC8, 0),
                                        isLighterColor = true });                         

            /** Add Colors **/
            int id = 50000;
            foreach (CustomColor cc in colors) {
                longlist.Add((StringNames)id);
                CustomColors.ColorStrings[id++] = cc.longname;
                shortlist.Add((StringNames)id);
                CustomColors.ColorStrings[id++] = cc.shortname;
                colorlist.Add(cc.color);
                shadowlist.Add(cc.shadow);
                if (cc.isLighterColor)
                    lighterColors.Add(colorlist.Count - 1);
            }

            Palette.ShortColorNames = shortlist.ToArray();
            Palette.ColorNames = longlist.ToArray();
            Palette.PlayerColors = colorlist.ToArray();
            Palette.ShadowColors = shadowlist.ToArray();
            MedScanMinigame.ColorNames = Palette.ColorNames;
            Telemetry.ColorNames = Palette.ColorNames;
        }

        protected internal struct CustomColor {
            public string longname;
            public string shortname;
            public Color32 color;
            public Color32 shadow;
            public bool isLighterColor;
        }

        [HarmonyPatch]
        public static class CustomColorPatches {
            [HarmonyPatch(typeof(TranslationController), nameof(TranslationController.GetString), new[] {
                typeof(StringNames),
                typeof(Il2CppReferenceArray<Il2CppSystem.Object>)
            })]
            private class ColorStringPatch {
                public static bool Prefix(ref string __result, [HarmonyArgument(0)] StringNames name) {
                    if ((int)name >= 50000) {
                        string text = CustomColors.ColorStrings[(int)name];
                        if (text != null) {
                            __result = text;
                            return false;
                        }
                    }
                    return true;
                }
            }
            [HarmonyPatch(typeof(PlayerTab), nameof(PlayerTab.OnEnable))]
            private static class PlayerTabEnablePatch {
                public static void Postfix(PlayerTab __instance) { // Replace instead
                    Il2CppArrayBase<ColorChip> chips = __instance.ColorChips.ToArray();
                    int cols = 4; // TODO: Design an algorithm to dynamically position chips to optimally fill space
                    for (int i = 0; i < chips.Length; i++) {
                        ColorChip chip = chips[i];
                        int row = i / cols, col = i % cols; // Dynamically do the positioning
                        chip.transform.localPosition = new Vector3(1.46f + (col * 0.6f), -0.43f - (row * 0.55f), chip.transform.localPosition.z);
                        chip.transform.localScale *= 0.9f;

                        if (i >= pickableColors) {
                            chip.transform.localScale *= 0f; // Needs to exist for PlayerTab
                            chip.enabled = false;
                            chip.Button.enabled = false;
                            chip.Button.OnClick.RemoveAllListeners();
                        }
                    }
                }
            }
            [HarmonyPatch(typeof(SaveManager), nameof(SaveManager.LoadPlayerPrefs))]
            private static class LoadPlayerPrefsPatch { // Fix Potential issues with broken colors
                private static bool needsPatch = false;
                public static void Prefix([HarmonyArgument(0)] bool overrideLoad) {
                    if (!SaveManager.loaded || overrideLoad)
                        needsPatch = true;
                }
                public static void Postfix() {
                    if (!needsPatch) return;
                    SaveManager.colorConfig %= CustomColors.pickableColors;
                    needsPatch = false;
                }
            }
            [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.CheckColor))]
            private static class PlayerControlCheckColorPatch {
                private static bool isTaken(PlayerControl player, uint color) {
                    foreach (GameData.PlayerInfo p in GameData.Instance.AllPlayers)
                        if (!p.Disconnected && p.PlayerId != player.PlayerId && p.ColorId == color)
                            return true;
                    return false;
                }
                public static bool Prefix(PlayerControl __instance, [HarmonyArgument(0)] byte bodyColor) { // Fix incorrect color assignment
                    uint color = (uint)bodyColor;
                   if (isTaken(__instance, color) || color >= Palette.PlayerColors.Length) {
                        int num = 0;
                        while (num++ < 50 && (color >= CustomColors.pickableColors || isTaken(__instance, color))) {
                            color = (color + 1) % CustomColors.pickableColors;
                        }
                    }
                    __instance.RpcSetColor((byte)color);
                    return false;
                }
            }
        }
    }
}
