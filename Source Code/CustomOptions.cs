using System.Collections.Generic;
using UnityEngine;
using BepInEx.Configuration;
using System;
using System.Linq;
using HarmonyLib;
using Hazel;
using System.Reflection;
using System.Text;
using static TheOtherRoles.TheOtherRoles;

namespace TheOtherRoles {
    public class CustomOptionHolder {
        public static string[] rates = new string[]{"0%", "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%"};
        public static string[] presets = new string[]{"预设 1", "预设 2", "预设 3", "预设 4", "预设 5"};

        public static CustomOption presetSelection;
        public static CustomOption crewmateRolesCountMin;
        public static CustomOption crewmateRolesCountMax;
        public static CustomOption neutralRolesCountMin;
        public static CustomOption neutralRolesCountMax;
        public static CustomOption impostorRolesCountMin;
        public static CustomOption impostorRolesCountMax;

        public static CustomOption mafiaSpawnRate;
        public static CustomOption janitorCooldown;

        public static CustomOption morphlingSpawnRate;
        public static CustomOption morphlingCooldown;
        public static CustomOption morphlingDuration;

        public static CustomOption camouflagerSpawnRate;
        public static CustomOption camouflagerCooldown;
        public static CustomOption camouflagerDuration;

        public static CustomOption vampireSpawnRate;
        public static CustomOption vampireKillDelay;
        public static CustomOption vampireCooldown;
        public static CustomOption vampireCanKillNearGarlics;

        public static CustomOption eraserSpawnRate;
        public static CustomOption eraserCooldown;
        public static CustomOption eraserCanEraseAnyone;

        public static CustomOption miniSpawnRate;
        public static CustomOption miniGrowingUpDuration;

        public static CustomOption loversSpawnRate;
        public static CustomOption loversImpLoverRate;
        public static CustomOption loversBothDie;
        public static CustomOption loversCanHaveAnotherRole;

        public static CustomOption guesserSpawnRate;
        public static CustomOption guesserIsImpGuesserRate;
        public static CustomOption guesserNumberOfShots;

        public static CustomOption jesterSpawnRate;
        public static CustomOption jesterCanCallEmergency;
        public static CustomOption jesterCanSabotage;

        public static CustomOption arsonistSpawnRate;
        public static CustomOption arsonistCooldown;
        public static CustomOption arsonistDuration;

        public static CustomOption jackalSpawnRate;
        public static CustomOption jackalKillCooldown;
        public static CustomOption jackalCreateSidekickCooldown;
        public static CustomOption jackalCanUseVents;
        public static CustomOption jackalCanCreateSidekick;
        public static CustomOption sidekickPromotesToJackal;
        public static CustomOption sidekickCanKill;
        public static CustomOption sidekickCanUseVents;
        public static CustomOption jackalPromotedFromSidekickCanCreateSidekick;
        public static CustomOption jackalCanCreateSidekickFromImpostor;
        public static CustomOption jackalAndSidekickHaveImpostorVision;

        public static CustomOption shifterSpawnRate;

        public static CustomOption mayorSpawnRate;

        public static CustomOption engineerSpawnRate;

        public static CustomOption sheriffSpawnRate;
        public static CustomOption sheriffCooldown;
        public static CustomOption sheriffCanKillNeutrals;

        public static CustomOption lighterSpawnRate;
        public static CustomOption lighterModeLightsOnVision;
        public static CustomOption lighterModeLightsOffVision;
        public static CustomOption lighterCooldown;
        public static CustomOption lighterDuration;

        public static CustomOption detectiveSpawnRate;
        public static CustomOption detectiveAnonymousFootprints;
        public static CustomOption detectiveFootprintIntervall;
        public static CustomOption detectiveFootprintDuration;
        public static CustomOption detectiveReportNameDuration;
        public static CustomOption detectiveReportColorDuration;

        public static CustomOption timeMasterSpawnRate;
        public static CustomOption timeMasterCooldown;
        public static CustomOption timeMasterRewindTime;
        public static CustomOption timeMasterShieldDuration;

        public static CustomOption medicSpawnRate;
        public static CustomOption medicShowShielded;
        public static CustomOption medicShowAttemptToShielded;

        public static CustomOption swapperSpawnRate;
        public static CustomOption swapperCanCallEmergency;
        public static CustomOption swapperCanOnlySwapOthers;

        public static CustomOption seerSpawnRate;
        public static CustomOption seerMode;
        public static CustomOption seerSoulDuration;
        public static CustomOption seerLimitSoulDuration;

        public static CustomOption hackerSpawnRate;
        public static CustomOption hackerCooldown;
        public static CustomOption hackerHackeringDuration;
        public static CustomOption hackerOnlyColorType;

        public static CustomOption trackerSpawnRate;
        public static CustomOption trackerUpdateIntervall;

        public static CustomOption snitchSpawnRate;
        public static CustomOption snitchLeftTasksForImpostors;

        public static CustomOption spySpawnRate;
        public static CustomOption spyCanDieToSheriff;
        public static CustomOption spyImpostorsCanKillAnyone;
        public static CustomOption spyCanEnterVents;
        public static CustomOption spyHasImpostorVision;

        public static CustomOption tricksterSpawnRate;
        public static CustomOption tricksterPlaceBoxCooldown;
        public static CustomOption tricksterLightsOutCooldown;
        public static CustomOption tricksterLightsOutDuration;

        public static CustomOption cleanerSpawnRate;
        public static CustomOption cleanerCooldown;
        
        public static CustomOption warlockSpawnRate;
        public static CustomOption warlockCooldown;
        public static CustomOption warlockRootTime;

        public static CustomOption securityGuardSpawnRate;
        public static CustomOption securityGuardCooldown;
        public static CustomOption securityGuardTotalScrews;
        public static CustomOption securityGuardCamPrice;
        public static CustomOption securityGuardVentPrice;

        public static CustomOption maxNumberOfMeetings;
        public static CustomOption blockSkippingInEmergencyMeetings;
        public static CustomOption noVoteIsSelfVote;
        public static CustomOption hidePlayerNames;

        internal static Dictionary<byte, byte[]> blockedRolePairings = new Dictionary<byte, byte[]>();

        public static string cs(Color c, string s) {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
        }
 
        private static byte ToByte(float f) {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }

        public static void Load() {
            
            // Role Options
            presetSelection = CustomOption.Create(0, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "预设"), presets, null, true);

            // Using new id's for the options to not break compatibilty with older versions
            crewmateRolesCountMin = CustomOption.Create(300, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小船员角色数量"), 0f, 0f, 15f, 1f, null, true);
            crewmateRolesCountMax = CustomOption.Create(301, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最大船员角色数量"), 0f, 0f, 15f, 1f);
            neutralRolesCountMin = CustomOption.Create(302, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小中立角色数量"), 0f, 0f, 15f, 1f);
            neutralRolesCountMax = CustomOption.Create(303, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最大中立角色数量"), 0f, 0f, 15f, 1f);
            impostorRolesCountMin = CustomOption.Create(304, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最小内鬼角色数量"), 0f, 0f, 3f, 1f);
            impostorRolesCountMax = CustomOption.Create(305, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "最大内鬼角色数量"), 0f, 0f, 3f, 1f);

            mafiaSpawnRate = CustomOption.Create(10, cs(Janitor.color, "黑手党"), rates, null, true);
            janitorCooldown = CustomOption.Create(11, "清道夫冷却时间", 30f, 10f, 60f, 2.5f, mafiaSpawnRate);

            morphlingSpawnRate = CustomOption.Create(20, cs(Morphling.color, "变体精灵"), rates, null, true);
            morphlingCooldown = CustomOption.Create(21, "变形冷却时间", 30f, 10f, 60f, 2.5f, morphlingSpawnRate);
            morphlingDuration = CustomOption.Create(22, "变形持续时间", 10f, 1f, 20f, 0.5f, morphlingSpawnRate);

            camouflagerSpawnRate = CustomOption.Create(30, cs(Camouflager.color, "伪装者"), rates, null, true);
            camouflagerCooldown = CustomOption.Create(31, "伪装冷却时间", 30f, 10f, 60f, 2.5f, camouflagerSpawnRate);
            camouflagerDuration = CustomOption.Create(32, "伪装持续时间", 10f, 1f, 20f, 0.5f, camouflagerSpawnRate);

            vampireSpawnRate = CustomOption.Create(40, cs(Vampire.color, "吸血鬼"), rates, null, true);
            vampireKillDelay = CustomOption.Create(41, "吸血鬼击杀延迟", 10f, 1f, 20f, 1f, vampireSpawnRate);
            vampireCooldown = CustomOption.Create(42, "吸血鬼冷却时间", 30f, 10f, 60f, 2.5f, vampireSpawnRate);
            vampireCanKillNearGarlics = CustomOption.Create(43, "吸血鬼可在大蒜附近击杀", true, vampireSpawnRate);

            eraserSpawnRate = CustomOption.Create(230, cs(Eraser.color, "黑衣人"), rates, null, true);
            eraserCooldown = CustomOption.Create(231, "黑衣人冷却时间", 30f, 10f, 120f, 5f, eraserSpawnRate);
            eraserCanEraseAnyone = CustomOption.Create(232, "黑衣人能抹除任何角色", false, eraserSpawnRate);

            tricksterSpawnRate = CustomOption.Create(250, cs(Trickster.color, "魔术师"), rates, null, true);
            tricksterPlaceBoxCooldown = CustomOption.Create(251, "惊吓盒子冷却时间", 10f, 0f, 30f, 2.5f, tricksterSpawnRate);
            tricksterLightsOutCooldown = CustomOption.Create(252, "熄灯冷却时间", 30f, 10f, 60f, 5f, tricksterSpawnRate);
            tricksterLightsOutDuration = CustomOption.Create(253, "熄灯持续时间", 15f, 5f, 60f, 2.5f, tricksterSpawnRate);

            cleanerSpawnRate = CustomOption.Create(260, cs(Cleaner.color, "清洁工"), rates, null, true);
            cleanerCooldown = CustomOption.Create(261, "清洁工冷却时间", 30f, 10f, 60f, 2.5f, cleanerSpawnRate);

            warlockSpawnRate = CustomOption.Create(270, cs(Cleaner.color, "术士"), rates, null, true);
            warlockCooldown = CustomOption.Create(271, "定身冷却时间", 30f, 10f, 60f, 2.5f, warlockSpawnRate);
            warlockRootTime = CustomOption.Create(272, "定身持续时间", 5f, 0f, 15f, 1f, warlockSpawnRate);
            
            miniSpawnRate = CustomOption.Create(180, cs(Mini.color, "孩子"), rates, null, true);
            miniGrowingUpDuration = CustomOption.Create(181, "孩子成长所需时间", 400f, 100f, 1500f, 100f, miniSpawnRate);

            loversSpawnRate = CustomOption.Create(50, cs(Lovers.color, "情人"), rates, null, true);
            loversImpLoverRate = CustomOption.Create(51, "一个情人是内鬼的概率", rates, loversSpawnRate);
            loversBothDie = CustomOption.Create(52, "情人殉情", true, loversSpawnRate);
            loversCanHaveAnotherRole = CustomOption.Create(53, "情人可以拥有其他职业", true, loversSpawnRate);

            guesserSpawnRate = CustomOption.Create(310, cs(Guesser.color, "猜测者"), rates, null, true);
            guesserIsImpGuesserRate = CustomOption.Create(311, "猜测者是骗子的可能性", rates, guesserSpawnRate);
            guesserNumberOfShots = CustomOption.Create(312, "猜测者射击次数", 2f, 1f, 15f, 1f, guesserSpawnRate);

            jesterSpawnRate = CustomOption.Create(60, cs(Jester.color, "小丑"), rates, null, true);
            jesterCanCallEmergency = CustomOption.Create(61, "小丑可以召集紧急会议", true, jesterSpawnRate);
            jesterCanSabotage = CustomOption.Create(62, "小丑可以破坏", true, jesterSpawnRate);

            arsonistSpawnRate = CustomOption.Create(290, cs(Arsonist.color, "纵火犯"), rates, null, true);
            arsonistCooldown = CustomOption.Create(291, "纵火冷却时间", 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate);
            arsonistDuration = CustomOption.Create(292, "纵火熄灭时间", 3f, 1f, 10f, 1f, arsonistSpawnRate);

            jackalSpawnRate = CustomOption.Create(220, cs(Jackal.color, "豺狼"), rates, null, true);
            jackalKillCooldown = CustomOption.Create(221, "豺狼/帮凶击杀冷却时间", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCreateSidekickCooldown = CustomOption.Create(222, "豺狼创建帮凶冷却时间", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCanUseVents = CustomOption.Create(223, "豺狼可以使用通风管道", true, jackalSpawnRate);
            jackalCanCreateSidekick = CustomOption.Create(224, "豺狼可以创建帮凶", false, jackalSpawnRate);
            sidekickPromotesToJackal = CustomOption.Create(225, "豺狼死亡时帮凶被提升为豺狼", false, jackalSpawnRate);
            sidekickCanKill = CustomOption.Create(226, "帮凶可以击杀", false, jackalSpawnRate);
            sidekickCanUseVents = CustomOption.Create(227, "帮凶可以使用下水道", true, jackalSpawnRate);
            jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228, "从帮凶提升的豺狼可以创建帮凶", true, jackalSpawnRate);
            jackalCanCreateSidekickFromImpostor = CustomOption.Create(229, "豺狼可以从内鬼创建帮凶", true, jackalSpawnRate);
            jackalAndSidekickHaveImpostorVision = CustomOption.Create(430, "豺狼和帮凶拥有内鬼视野", false, jackalSpawnRate);

            shifterSpawnRate = CustomOption.Create(70, cs(Shifter.color, "变形者"), rates, null, true);

            mayorSpawnRate = CustomOption.Create(80, cs(Mayor.color, "市长"), rates, null, true);

            engineerSpawnRate = CustomOption.Create(90, cs(Engineer.color, "工程师"), rates, null, true);

            sheriffSpawnRate = CustomOption.Create(100, cs(Sheriff.color, "警长"), rates, null, true);
            sheriffCooldown = CustomOption.Create(101, "警长开枪冷却时间", 30f, 10f, 60f, 2.5f, sheriffSpawnRate);
            sheriffCanKillNeutrals = CustomOption.Create(102, "警长能击杀中立角色", false, sheriffSpawnRate);


            lighterSpawnRate = CustomOption.Create(110, cs(Lighter.color, "明灯"), rates, null, true);
            lighterModeLightsOnVision = CustomOption.Create(111, "明灯模式：视野开灯光开", 2f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterModeLightsOffVision = CustomOption.Create(112, "明灯模式：视野开灯光关", 0.75f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterCooldown = CustomOption.Create(113, "明灯冷却时间", 30f, 5f, 120f, 5f, lighterSpawnRate);
            lighterDuration = CustomOption.Create(114, "明灯持续时间", 5f, 2.5f, 60f, 2.5f, lighterSpawnRate);

            detectiveSpawnRate = CustomOption.Create(120, cs(Detective.color, "侦探"), rates, null, true);
            detectiveAnonymousFootprints = CustomOption.Create(121, "匿名脚印", false, detectiveSpawnRate); 
            detectiveFootprintIntervall = CustomOption.Create(122, "脚印间隔", 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveFootprintDuration = CustomOption.Create(123, "脚印持续时间", 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveReportNameDuration = CustomOption.Create(124, "侦探报告显示名字的时间", 0, 0, 60, 2.5f, detectiveSpawnRate);
            detectiveReportColorDuration = CustomOption.Create(125, "侦探报告显示颜色类型的时间", 20, 0, 120, 2.5f, detectiveSpawnRate);

            timeMasterSpawnRate = CustomOption.Create(130, cs(TimeMaster.color, "时间大师"), rates, null, true);
            timeMasterCooldown = CustomOption.Create(131, "时间大师冷却时间", 30f, 10f, 120f, 2.5f, timeMasterSpawnRate);
            timeMasterRewindTime = CustomOption.Create(132, "回溯时间", 3f, 1f, 10f, 1f, timeMasterSpawnRate);
            timeMasterShieldDuration = CustomOption.Create(133, "时间大师盾牌持续时间", 3f, 1f, 20f, 1f, timeMasterSpawnRate);

            medicSpawnRate = CustomOption.Create(140, cs(Medic.color, "医生"), rates, null, true);
            medicShowShielded = CustomOption.Create(143, "显示被保护的玩家", new string[] {"所有人可见", "当事人和医生可见", "仅医生可见"}, medicSpawnRate);
            medicShowAttemptToShielded = CustomOption.Create(144, "当事人能看到谋杀尝试", false, medicSpawnRate);

            swapperSpawnRate = CustomOption.Create(150, cs(Swapper.color, "交换者"), rates, null, true);
            swapperCanCallEmergency = CustomOption.Create(151, "交换者可以召开紧急会议", false, swapperSpawnRate);
            swapperCanOnlySwapOthers = CustomOption.Create(152, "只能交换其他人的选票", false, swapperSpawnRate);

            seerSpawnRate = CustomOption.Create(160, cs(Seer.color, "先知"), rates, null, true);
            seerMode = CustomOption.Create(161, "先知模式", new string[]{ "死亡瞬间和幽灵", "仅显示死亡瞬间", "仅可见幽灵"}, seerSpawnRate);
            seerLimitSoulDuration = CustomOption.Create(163, "限制幽灵可见持续时间", false, seerSpawnRate);
            seerSoulDuration = CustomOption.Create(162, "会议后幽灵持续时间", 15f, 0f, 60f, 5f, seerLimitSoulDuration);
        
            hackerSpawnRate = CustomOption.Create(170, cs(Hacker.color, "黑客"), rates, null, true);
            hackerCooldown = CustomOption.Create(171, "黑客冷却时间", 30f, 0f, 60f, 5f, hackerSpawnRate);
            hackerHackeringDuration = CustomOption.Create(172, "黑客持续时间", 10f, 2.5f, 60f, 2.5f, hackerSpawnRate);
            hackerOnlyColorType = CustomOption.Create(173, "黑客只能看到颜色类型", false, hackerSpawnRate);

            trackerSpawnRate = CustomOption.Create(200, cs(Tracker.color, "追踪者"), rates, null, true);
            trackerUpdateIntervall = CustomOption.Create(201, "追踪者更新间隔", 5f, 2.5f, 30f, 2.5f, trackerSpawnRate);

            snitchSpawnRate = CustomOption.Create(210, cs(Snitch.color, "告密者"), rates, null, true);
            snitchLeftTasksForImpostors = CustomOption.Create(211, "内鬼可以看到告密者的剩余任务数量", 1f, 0f, 5f, 1f, snitchSpawnRate);

            spySpawnRate = CustomOption.Create(240, cs(Spy.color, "间谍"), rates, null, true);
            spyCanDieToSheriff = CustomOption.Create(241, "警长可以杀死间谍", false, spySpawnRate);
            spyImpostorsCanKillAnyone = CustomOption.Create(242, "存在间谍时内鬼可以击杀所有角色", true, spySpawnRate);
            spyCanEnterVents = CustomOption.Create(243, "间谍可以进入通风口", false, spySpawnRate);
            spyHasImpostorVision = CustomOption.Create(244, "间谍拥有内鬼视野", false, spySpawnRate);

            securityGuardSpawnRate = CustomOption.Create(280, cs(SecurityGuard.color, "保安"), rates, null, true);
            securityGuardCooldown = CustomOption.Create(281, "保安冷却时间", 30f, 10f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardTotalScrews = CustomOption.Create(282, "保安螺丝数量", 7f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamPrice = CustomOption.Create(283, "部署监控消耗的螺丝数量", 2f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardVentPrice = CustomOption.Create(284, "封堵管道消耗的螺丝数量", 1f, 1f, 15f, 1f, securityGuardSpawnRate);

            // Other options
            maxNumberOfMeetings = CustomOption.Create(3, "会议次数 (市长不受限)", 10, 0, 15, 1, null, true);
            blockSkippingInEmergencyMeetings = CustomOption.Create(4, "不允许跳过紧急会议", false);
            noVoteIsSelfVote = CustomOption.Create(5, "不投票会被视作给自己投票", false, blockSkippingInEmergencyMeetings);
            hidePlayerNames = CustomOption.Create(6, "隐藏玩家名字", false);

            blockedRolePairings.Add((byte)RoleId.Vampire, new [] { (byte)RoleId.Warlock});
            blockedRolePairings.Add((byte)RoleId.Warlock, new [] { (byte)RoleId.Vampire});
            
        }
    }

    public class CustomOption {
        public static List<CustomOption> options = new List<CustomOption>();
        public static int preset = 0;

        public int id;
        public string name;
        public System.Object[] selections;

        public int defaultSelection;
        public ConfigEntry<int> entry;
        public int selection;
        public OptionBehaviour optionBehaviour;
        public CustomOption parent;
        public bool isHeader;

        // Option creation

        public CustomOption(int id, string name,  System.Object[] selections, System.Object defaultValue, CustomOption parent, bool isHeader) {
            this.id = id;
            this.name = parent == null ? name : "- " + name;
            this.selections = selections;
            int index = Array.IndexOf(selections, defaultValue);
            this.defaultSelection = index >= 0 ? index : 0;
            this.parent = parent;
            this.isHeader = isHeader;
            selection = 0;
            if (id != 0) {
                entry = TheOtherRolesPlugin.Instance.Config.Bind($"Preset{preset}", id.ToString(), defaultSelection);
                selection = Mathf.Clamp(entry.Value, 0, selections.Length - 1);
            }
            options.Add(this);
        }

        public static CustomOption Create(int id, string name, string[] selections, CustomOption parent = null, bool isHeader = false) {
            return new CustomOption(id, name, selections, "", parent, isHeader);
        }

        public static CustomOption Create(int id, string name, float defaultValue, float min, float max, float step, CustomOption parent = null, bool isHeader = false) {
            List<float> selections = new List<float>();
            for (float s = min; s <= max; s += step)
                selections.Add(s);
            return new CustomOption(id, name, selections.Cast<object>().ToArray(), defaultValue, parent, isHeader);
        }

        public static CustomOption Create(int id, string name, bool defaultValue, CustomOption parent = null, bool isHeader = false) {
            return new CustomOption(id, name, new string[]{"关", "开"}, defaultValue ? "开" : "关", parent, isHeader);
        }

        // Static behaviour

        public static void switchPreset(int newPreset) {
            CustomOption.preset = newPreset;
            foreach (CustomOption option in CustomOption.options) {
                if (option.id == 0) continue;

                option.entry = TheOtherRolesPlugin.Instance.Config.Bind($"Preset{preset}", option.id.ToString(), option.defaultSelection);
                option.selection = Mathf.Clamp(option.entry.Value, 0, option.selections.Length - 1);
                if (option.optionBehaviour != null && option.optionBehaviour is StringOption stringOption) {
                    stringOption.oldValue = stringOption.Value = option.selection;
                    stringOption.ValueText.text = option.selections[option.selection].ToString();
                }
            }
        }

        public static void ShareOptionSelections() {
            if (PlayerControl.AllPlayerControls.Count <= 1 || AmongUsClient.Instance?.AmHost == false && PlayerControl.LocalPlayer == null) return;
            foreach (CustomOption option in CustomOption.options) {
                MessageWriter messageWriter = AmongUsClient.Instance.StartRpc(PlayerControl.LocalPlayer.NetId, (byte)CustomRPC.ShareOptionSelection, Hazel.SendOption.Reliable);
                messageWriter.WritePacked((uint)option.id);
                messageWriter.WritePacked((uint)Convert.ToUInt32(option.selection));
                messageWriter.EndMessage();
            }
        }

        // Getter

        public int getSelection() {
            return selection;
        }

        public bool getBool() {
            return selection > 0;
        }

        public float getFloat() {
            return (float)selections[selection];
        }

        // Option changes

        public void updateSelection(int newSelection) {
            selection = Mathf.Clamp((newSelection + selections.Length) % selections.Length, 0, selections.Length - 1);
            if (optionBehaviour != null && optionBehaviour is StringOption stringOption) {
                stringOption.oldValue = stringOption.Value = selection;
                stringOption.ValueText.text = selections[selection].ToString();

                if (AmongUsClient.Instance?.AmHost == true && PlayerControl.LocalPlayer) {
                    if (id == 0) switchPreset(selection); // Switch presets
                    else if (entry != null) entry.Value = selection; // Save selection to config

                    ShareOptionSelections();// Share all selections
                }
           }
        }
    }

    [HarmonyPatch(typeof(GameOptionsMenu), nameof(GameOptionsMenu.Start))]
    class GameOptionsMenuStartPatch {
        public static void Postfix(GameOptionsMenu __instance) {
            var template = UnityEngine.Object.FindObjectsOfType<StringOption>().FirstOrDefault();
            if (template == null) return;

            List<OptionBehaviour> allOptions = __instance.Children.ToList();
            for (int i = 0; i < CustomOption.options.Count; i++) {
                CustomOption option = CustomOption.options[i];
                if (option.optionBehaviour == null) {
                    StringOption stringOption = UnityEngine.Object.Instantiate(template, template.transform.parent);
                    allOptions.Add(stringOption);

                    stringOption.OnValueChanged = new Action<OptionBehaviour>((o) => {});
                    stringOption.TitleText.text = option.name;
                    stringOption.Value = stringOption.oldValue = option.selection;
                    stringOption.ValueText.text = option.selections[option.selection].ToString();

                    option.optionBehaviour = stringOption;
                }
                option.optionBehaviour.gameObject.SetActive(true);
            }
            
            var commonTasksOption = allOptions.FirstOrDefault(x => x.name == "NumCommonTasks").TryCast<NumberOption>();
            if(commonTasksOption != null) commonTasksOption.ValidRange = new FloatRange(0f, 4f);

            var shortTasksOption = allOptions.FirstOrDefault(x => x.name == "NumShortTasks").TryCast<NumberOption>();
            if(shortTasksOption != null) shortTasksOption.ValidRange = new FloatRange(0f, 23f);

            var longTasksOption = allOptions.FirstOrDefault(x => x.name == "NumLongTasks").TryCast<NumberOption>();
            if(longTasksOption != null) longTasksOption.ValidRange = new FloatRange(0f, 15f);
            
            __instance.Children = allOptions.ToArray();
        }
    }

    [HarmonyPatch(typeof(StringOption), nameof(StringOption.OnEnable))]
    public class StringOptionEnablePatch {
        public static bool Prefix(StringOption __instance) {
            CustomOption option = CustomOption.options.FirstOrDefault(option => option.optionBehaviour == __instance);
            if (option == null) return true;

            __instance.OnValueChanged = new Action<OptionBehaviour>((o) => {});
            __instance.TitleText.text = option.name;
            __instance.Value = __instance.oldValue = option.selection;
            __instance.ValueText.text = option.selections[option.selection].ToString();
            
            return false;
        }
    }

    [HarmonyPatch(typeof(StringOption), nameof(StringOption.Increase))]
    public class StringOptionIncreasePatch
    {
        public static bool Prefix(StringOption __instance)
        {
            CustomOption option = CustomOption.options.FirstOrDefault(option => option.optionBehaviour == __instance);
            if (option == null) return true;
            option.updateSelection(option.selection + 1);
            return false;
        }
    }

    [HarmonyPatch(typeof(StringOption), nameof(StringOption.Decrease))]
    public class StringOptionDecreasePatch
    {
        public static bool Prefix(StringOption __instance)
        {
            CustomOption option = CustomOption.options.FirstOrDefault(option => option.optionBehaviour == __instance);
            if (option == null) return true;
            option.updateSelection(option.selection - 1);
            return false;
        }
    }

    [HarmonyPatch(typeof(PlayerControl), nameof(PlayerControl.RpcSyncSettings))]
    public class RpcSyncSettingsPatch
    {
        public static void Postfix()
        {
            CustomOption.ShareOptionSelections();
        }
    }


    [HarmonyPatch(typeof(GameOptionsMenu), nameof(GameOptionsMenu.Update))]
    class GameOptionsMenuUpdatePatch
    {
        private static float timer = 1f;
        public static void Postfix(GameOptionsMenu __instance) {
            __instance.GetComponentInParent<Scroller>().YBounds.max = -0.5F + __instance.Children.Length * 0.55F; 
            timer += Time.deltaTime;
            if (timer < 0.1f) return;
            timer = 0f;

            float offset = -7.85f;
            foreach (CustomOption option in CustomOption.options) {
                if (option?.optionBehaviour != null && option.optionBehaviour.gameObject != null) {
                    bool enabled = true;
                    var parent = option.parent;
                    while (parent != null && enabled) {
                        enabled = parent.selection != 0;
                        parent = parent.parent;
                    }
                    option.optionBehaviour.gameObject.SetActive(enabled);
                    if (enabled) {
                        offset -= option.isHeader ? 0.75f : 0.5f;
                        option.optionBehaviour.transform.localPosition = new Vector3(option.optionBehaviour.transform.localPosition.x, offset, option.optionBehaviour.transform.localPosition.z);
                    }
                }
            }
        }
    }

    [HarmonyPatch(typeof(GameSettingMenu), "OnEnable")]
    class GameSettingMenuPatch {
        public static void Prefix(GameSettingMenu __instance) {
            __instance.HideForOnline = new Transform[]{};
        }

        public static void Postfix(GameSettingMenu __instance) {
            var mapNameTransform = __instance.AllItems.FirstOrDefault(x => x.gameObject.activeSelf && x.name.Equals("MapName", StringComparison.OrdinalIgnoreCase));
            if (mapNameTransform == null) return;

            var options = new Il2CppSystem.Collections.Generic.List<Il2CppSystem.Collections.Generic.KeyValuePair<string, int>>();
            for (int i = 0; i < GameOptionsData.MapNames.Length; i++) {
                var kvp = new Il2CppSystem.Collections.Generic.KeyValuePair<string, int>();
                kvp.key = GameOptionsData.MapNames[i];
                kvp.value = i;
                options.Add(kvp);
            }
            mapNameTransform.GetComponent<KeyValueOption>().Values = options;
        }
    }

    [HarmonyPatch(typeof(Constants), nameof(Constants.ShouldFlipSkeld))]
    class ConstantsShouldFlipSkeldPatch {
        public static bool Prefix(ref bool __result) {
            if (PlayerControl.GameOptions == null) return true;
            __result = PlayerControl.GameOptions.MapId == 3;
            return false;
        }
    }

    [HarmonyPatch] 
    class GameOptionsDataPatch
    {
        private static IEnumerable<MethodBase> TargetMethods() {
            return typeof(GameOptionsData).GetMethods().Where(x => x.ReturnType == typeof(string) && x.GetParameters().Length == 1 && x.GetParameters()[0].ParameterType == typeof(int));
        }

        private static void Postfix(ref string __result)
        {
            StringBuilder sb = new StringBuilder(__result);
            foreach (CustomOption option in CustomOption.options) {
                if (option.parent == null) {
                    if (option == CustomOptionHolder.crewmateRolesCountMin) {
                        var optionName = CustomOptionHolder.cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "船员角色");
                        var min = CustomOptionHolder.crewmateRolesCountMin.getSelection();
                        var max = CustomOptionHolder.crewmateRolesCountMax.getSelection();
                        if (min > max) min = max;
                        var optionValue = (min == max) ? $"{max}" : $"{min} - {max}";
                        sb.AppendLine($"{optionName}: {optionValue}");
                    } else if (option == CustomOptionHolder.neutralRolesCountMin) {
                        var optionName = CustomOptionHolder.cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "中立角色");
                        var min = CustomOptionHolder.neutralRolesCountMin.getSelection();
                        var max = CustomOptionHolder.neutralRolesCountMax.getSelection();
                        if (min > max) min = max;
                        var optionValue = (min == max) ? $"{max}" : $"{min} - {max}";
                        sb.AppendLine($"{optionName}: {optionValue}");
                    } else if (option == CustomOptionHolder.impostorRolesCountMin) {
                        var optionName = CustomOptionHolder.cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "内鬼角色");
                        var min = CustomOptionHolder.impostorRolesCountMin.getSelection();
                        var max = CustomOptionHolder.impostorRolesCountMax.getSelection();
                        if (min > max) min = max;
                        var optionValue = (min == max) ? $"{max}" : $"{min} - {max}";
                        sb.AppendLine($"{optionName}: {optionValue}");
                    } else if ((option == CustomOptionHolder.crewmateRolesCountMax) || (option == CustomOptionHolder.neutralRolesCountMax) || (option == CustomOptionHolder.impostorRolesCountMax)) {
                        continue;
                    } else {
                        sb.AppendLine($"{option.name}: {option.selections[option.selection].ToString()}");
                    }
                    
                }
            }
            CustomOption parent = null;
            foreach (CustomOption option in CustomOption.options)
                if (option.parent != null) {
                    if (option.parent != parent) {
                        sb.AppendLine();
                        parent = option.parent;
                    }
                    sb.AppendLine($"{option.name}: {option.selections[option.selection].ToString()}");
                }

            var hudString = sb.ToString();

            int defaultSettingsLines = 19;
            int roleSettingsLines = defaultSettingsLines + 33;
            int detailedSettingsP1 = roleSettingsLines + 34;
            int detailedSettingsP2 = detailedSettingsP1 + 35;
            int end1 = hudString.TakeWhile(c => (defaultSettingsLines -= (c == '\n' ? 1 : 0)) > 0).Count();
            int end2 = hudString.TakeWhile(c => (roleSettingsLines -= (c == '\n' ? 1 : 0)) > 0).Count();
            int end3 = hudString.TakeWhile(c => (detailedSettingsP1 -= (c == '\n' ? 1 : 0)) > 0).Count();
            int end4 = hudString.TakeWhile(c => (detailedSettingsP2 -= (c == '\n' ? 1 : 0)) > 0).Count();
            int counter = TheOtherRolesPlugin.optionsPage;
            if (counter == 0) {
                hudString = hudString.Substring(0, end1) + "\n";   
            } else if (counter == 1) {
                hudString = hudString.Substring(end1 + 1, end2 - end1);
                // Temporary fix, should add a new CustomOption for spaces
                int gap = 1;
                int index = hudString.TakeWhile(c => (gap -= (c == '\n' ? 1 : 0)) > 0).Count();
                hudString = hudString.Insert(index, "\n");
                gap = 5;
                index = hudString.TakeWhile(c => (gap -= (c == '\n' ? 1 : 0)) > 0).Count();
                hudString = hudString.Insert(index, "\n");
                gap = 17;
                index = hudString.TakeWhile(c => (gap -= (c == '\n' ? 1 : 0)) > 0).Count();
                hudString = hudString.Insert(index + 1, "\n");
                gap = 21;
                index = hudString.TakeWhile(c => (gap -= (c == '\n' ? 1 : 0)) > 0).Count();
                hudString = hudString.Insert(index + 1, "\n");
            } else if (counter == 2) {
                hudString = hudString.Substring(end2 + 1, end3 - end2);
            } else if (counter == 3) {
                hudString = hudString.Substring(end3 + 1, end4 - end3);
            } else if (counter == 4) {
                hudString = hudString.Substring(end4 + 1);
            }

            hudString += $"\n 按下TAB查看更多... ({counter+1}/5)";
            __result = hudString;
        }
    }

    [HarmonyPatch(typeof(KeyboardJoystick), nameof(KeyboardJoystick.Update))]
    public static class GameOptionsNextPagePatch
    {
        public static void Postfix(KeyboardJoystick __instance)
        {
            if(Input.GetKeyDown(KeyCode.Tab)) {
                TheOtherRolesPlugin.optionsPage = (TheOtherRolesPlugin.optionsPage + 1) % 5;
            }
        }
    }

    
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class GameSettingsScalePatch {
        public static void Prefix(HudManager __instance) {
            if (__instance.GameSettings != null) __instance.GameSettings.fontSize = 1.2f; 
        }
    }
}