using HarmonyLib;
using System.Linq;
using System;
using System.Collections.Generic;
using static TheOtherRoles.TheOtherRoles;
using UnityEngine;

namespace TheOtherRoles
{
    class RoleInfo {
        public Color color;
        public string name;
        public string introDescription;
        public string shortDescription;
        public RoleId roleId;

        RoleInfo(string name, Color color, string introDescription, string shortDescription, RoleId roleId) {
            this.color = color;
            this.name = name;
            this.introDescription = introDescription;
            this.shortDescription = shortDescription;
            this.roleId = roleId;
        }

        public static RoleInfo jester = new RoleInfo("小丑", Jester.color, "被投票出局", "被投票出局", RoleId.Jester);
        public static RoleInfo mayor = new RoleInfo("市长", Mayor.color, "你的投票视作两票", "你的投票视作两票", RoleId.Mayor);
        public static RoleInfo engineer = new RoleInfo("工程师",  Engineer.color, "维护船上的重要设备", "修复飞船", RoleId.Engineer);
        public static RoleInfo sheriff = new RoleInfo("警长", Sheriff.color, "击毙 <color=#FF1919FF>内鬼</color>", "击毙内鬼", RoleId.Sheriff);
        public static RoleInfo lighter = new RoleInfo("明灯", Lighter.color, "你的灯火永远不会熄灭", "你的灯火永远不会熄灭", RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo("教父", Godfather.color, "杀死所有船员", "杀死所有船员", RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo("黑手党", Mafioso.color, "帮助 <color=#FF1919FF>黑手党</color> 杀死所有船员", "杀死所有船员", RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo("清道夫", Janitor.color, "帮助 <color=#FF1919FF>黑手党</color> 隐藏尸体", "隐藏尸体", RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo("变体精灵", Morphling.color, "改头换面，以免被抓住", "改变你的形象", RoleId.Morphling);
        public static RoleInfo camouflager = new RoleInfo("伪装者", Camouflager.color, "伪装并杀死船员", "隐藏在人群之中", RoleId.Camouflager);
        public static RoleInfo vampire = new RoleInfo("吸血鬼", Vampire.color, "咬死船员", "咬死敌人", RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo("黑衣人", Eraser.color, "杀死船员，抹除他们的角色", "抹除船员的角色", RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo("魔术师", Trickster.color, "用你的惊吓盒给别人惊喜", "给敌人一个惊喜", RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo("清洁工", Cleaner.color, "杀掉敌人，不留痕迹", "清理尸体", RoleId.Cleaner);
        public static RoleInfo warlock = new RoleInfo("术士", Warlock.color, "诅咒其他玩家，杀死所有人", "诅咒所有人去死", RoleId.Warlock);
        public static RoleInfo detective = new RoleInfo("侦探", Detective.color, "通过寻找脚印来找出 <color=#FF1919FF>内鬼</color>", "检查脚印", RoleId.Detective);
        public static RoleInfo timeMaster = new RoleInfo("时间大师", TimeMaster.color, "用你的时间护盾拯救你自己", "使用你的时间护盾", RoleId.TimeMaster);
        public static RoleInfo medic = new RoleInfo("医生", Medic.color, "用你的盾牌保护某个玩家", "保护其他玩家", RoleId.Medic);
        public static RoleInfo shifter = new RoleInfo("变形者", Shifter.color, "改变你的角色", "改变你的角色", RoleId.Shifter);
        public static RoleInfo swapper = new RoleInfo("交换者", Swapper.color, "交换选票流放 <color=#FF1919FF>内鬼</color>", "交换选票", RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo("先知", Seer.color, "你可以看到玩家的死亡", "你可以看到玩家的死亡", RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo("黑客", Hacker.color, "骇入系统找到 <color=#FF1919FF>内鬼</color>", "骇入系统找到内鬼", RoleId.Hacker);
        public static RoleInfo niceMini = new RoleInfo("善良之子", Mini.color, "没有人可以在你长大前伤害你", "没有人会伤害你", RoleId.Mini);
        public static RoleInfo evilMini = new RoleInfo("恶堕之子", Palette.ImpostorRed, "没有人可以在你长大前伤害你", "没有人会伤害你", RoleId.Mini);
        public static RoleInfo tracker = new RoleInfo("追踪者", Tracker.color, "追踪 <color=#FF1919FF>内鬼</color>", "追踪找到内鬼", RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo("告密者", Snitch.color, "完成你的任务以找到 <color=#FF1919FF>内鬼</color>", "完成你的任务", RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo("豺狼", Jackal.color, "杀掉所有船员和 <color=#FF1919FF>内鬼</color> 取得胜利", "杀死所有人", RoleId.Jackal);
        public static RoleInfo sidekick = new RoleInfo("助手", Sidekick.color, "帮助你的豺狼杀死所有人", "帮助你的豺狼杀死所有人", RoleId.Sidekick);
        public static RoleInfo spy = new RoleInfo("间谍", Spy.color, "混入<color=#FF1919FF>内鬼</color>之中", "迷惑内鬼", RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo("保安", SecurityGuard.color, "密封通风口并放置摄像头", "密封通风口并放置摄像头", RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo("纵火犯", Arsonist.color, "烧吧，死吧！", "让我们燃起来！", RoleId.Arsonist);
        public static RoleInfo goodGuesser = new RoleInfo("守序猜测者", Guesser.color, "猜猜看然后开枪", "猜猜看然后开枪", RoleId.Guesser);
        public static RoleInfo badGuesser = new RoleInfo("恶堕猜测者", Palette.ImpostorRed, "猜猜看然后开枪", "猜猜看然后开枪", RoleId.Guesser);
        public static RoleInfo impostor = new RoleInfo("内鬼", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "破坏并杀死所有人"), "破坏并杀死所有人", RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo("船员", Color.white, "揪出内鬼", "揪出内鬼", RoleId.Crewmate);
        public static RoleInfo lover = new RoleInfo("情人", Lovers.color, $"你发情了", $"你发情了", RoleId.Lover);

        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
            impostor,
            godfather,
            mafioso,
            janitor,
            morphling,
            camouflager,
            vampire,
            eraser,
            trickster,
            cleaner,
            warlock,
            niceMini,
            evilMini,
            goodGuesser,
            badGuesser,
            lover,
            jester,
            arsonist,
            jackal,
            sidekick,
            crewmate,
            shifter,
            mayor,
            engineer,
            sheriff,
            lighter,
            detective,
            timeMaster,
            medic,
            swapper,
            seer,
            hacker,
            tracker,
            snitch,
            spy,
            securityGuard
        };

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Special roles
            if (p == Jester.jester) infos.Add(jester);
            if (p == Mayor.mayor) infos.Add(mayor);
            if (p == Engineer.engineer) infos.Add(engineer);
            if (p == Sheriff.sheriff) infos.Add(sheriff);
            if (p == Lighter.lighter) infos.Add(lighter);
            if (p == Godfather.godfather) infos.Add(godfather);
            if (p == Mafioso.mafioso) infos.Add(mafioso);
            if (p == Janitor.janitor) infos.Add(janitor);
            if (p == Morphling.morphling) infos.Add(morphling);
            if (p == Camouflager.camouflager) infos.Add(camouflager);
            if (p == Vampire.vampire) infos.Add(vampire);
            if (p == Eraser.eraser) infos.Add(eraser);
            if (p == Trickster.trickster) infos.Add(trickster);
            if (p == Cleaner.cleaner) infos.Add(cleaner);
            if (p == Warlock.warlock) infos.Add(warlock);
            if (p == Detective.detective) infos.Add(detective);
            if (p == TimeMaster.timeMaster) infos.Add(timeMaster);
            if (p == Medic.medic) infos.Add(medic);
            if (p == Shifter.shifter) infos.Add(shifter);
            if (p == Swapper.swapper) infos.Add(swapper);
            if (p == Seer.seer) infos.Add(seer);
            if (p == Hacker.hacker) infos.Add(hacker);
            if (p == Mini.mini) infos.Add(p.Data.IsImpostor ? evilMini : niceMini);
            if (p == Tracker.tracker) infos.Add(tracker);
            if (p == Snitch.snitch) infos.Add(snitch);
            if (p == Jackal.jackal || (Jackal.formerJackals != null && Jackal.formerJackals.Any(x => x.PlayerId == p.PlayerId))) infos.Add(jackal);
            if (p == Sidekick.sidekick) infos.Add(sidekick);
            if (p == Spy.spy) infos.Add(spy);
            if (p == SecurityGuard.securityGuard) infos.Add(securityGuard);
            if (p == Arsonist.arsonist) infos.Add(arsonist);
            if (p == Guesser.guesser) infos.Add(p.Data.IsImpostor ? badGuesser : goodGuesser);

            // Default roles
            if (infos.Count == 0 && p.Data.IsImpostor) infos.Add(impostor); // Just Impostor
            if (infos.Count == 0 && !p.Data.IsImpostor) infos.Add(crewmate); // Just Crewmate

            // Modifier
            if (p == Lovers.lover1|| p == Lovers.lover2) infos.Add(lover);

            return infos;
        }
    }
}
