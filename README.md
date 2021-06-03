![eisbison banner](./Images/TOR_logo.png)
<p align="center">
这个模组不属于 Among Us 或者 Innersloth LLC, 其中所使用的部分素材可能未经 Innersloth LLC 允许或以其他方式赞助. 这部分素材属于 Innersloth LLC. © Innersloth LLC.</p>

[![Discord](./Images/TOR_server.png)](https://discord.gg/77RkMJHWsM)
![eisbison infographic](./Images/TOR_roles.jpg)


# The Other Roles

 **The Other Roles**  是一个为 [Among Us](https://store.steampowered.com/app/945360/Among_Us) 增加许多新角色的模组, 新 [设定](#settings), 新 [自定义帽子](#custom-hats) 并且允许 [10个以上玩家](#Custom-Servers-and-10+-Players) 进行游玩.
更多角色正在锐意制作中 :)

# 汉化人员
简中字版本由 [RHWong](https://github.com/rhwong) 维护，AE、KGB1234560、Level6东风谷早苗、LexingtonCV-2 参与翻译工作，遵循原项目GPL3.0协议，但请保留汉化人员署名。
特别感谢大佬 Tualin14 对我的指导！

# 角色阵营索引

| 内鬼阵营 | 船员阵营 | 中立阵营 |
|----------|-------------|-----------------|
| [恶堕之子](#mini) | [善良之子](#mini) | [纵火犯](#arsonist) |
| [伪装者](#camouflager) | [侦探](#detective) | [小丑](#jester) |
| [清洁工](#cleaner) | [工程师](#engineer) | [豺狼](#jackal) |
| [黑衣人](#eraser) | [黑客](#hacker) | [助手](#sidekick) |
| [内鬼情人](#lovers) | [情人](#lovers) |  |
| [教父 (黑手党)](#mafia) | [明灯](#lighter) |  |
| [黑手党](#mafia) | [市长](#mayor) |  |
| [清道夫 (黑手党)](#mafia)  | [医生](#medic) |  |
| [变体精灵](#morphling) | [保安](#security-guard) |  |
| [魔术师](#trickster) | [先知](#seer) |  |
| [吸血鬼](#vampire) | [警长](#sheriff) |  |
| [术士](#warlock) | [变形者](#shifter) |  |
| [恶堕猜测者](#guesser) | [守序猜测者](#guesser) |  |
|  | [告密者](#snitch) |  |
|  | [间谍](#spy) |  |
|  | [交换者](#swapper) |  |
|  | [时间大师](#time-master) |  |
|  |  [追踪者](#tracker) |  |

[角色分配](#role-assignment) 章节解释了角色是如何在玩家之间分配的.

# Releases
| Among Us - 版本| 中文模组版本 | 链接 |
|----------|-------------|-----------------|
| 2021.5.25.2s| v2.6.7(CHN)| [Download](https://github.com/rhwong/TheOtherRoles/releases/download/v2.6.7_CN03/TheOtherRoles.zip)


# 更新日志
<details>
  <summary>单击以显示详细信息</summary>

**Version 2.6.7（CHN）**
- **新角色:** [猜测者](#guesser)
Master分支更新：
- Changed the colors of some roles
- Changed name of Child to [Mini](#mini)
- Changed Version check to allow to check for modified versions of the mod. (Forks don't need to use different versioning now)
- Changed Role Assignment to make [Spy](#spy) incompatible with [Mini](#mini) (former child)
- Fixed a bug where a [Jester](#jester) win was triggered, when the partner of a [Jester Lover](#lovers) was voted out
- Fixed a bug where a [Mini](#mini) lose was triggered, when the partner of a Crew [Mini Lover](#lovers) was voted out
</details>

# 安装

**在客户端上安装:**
1. 下载对应版本的Release
2. 解压缩文件到游戏根目录
3. 享受游戏

**在服务器上安装:**
1. 使用 [Impostor](https://github.com/Impostor/Impostor) 进行开服，版本为 **2021.3.31 - 2021.4.2**
2. 按照官方文档上的步骤安装开服器（使用刚刚下载的服务器版本） [Impostor-Documentation](https://github.com/Impostor/Impostor/wiki/Running-the-server)
3. 请确保在`config.json`中将以下值设置为false:
```
    ...
    "AntiCheat": {
      "Enabled": false,
      "BanIpFromGame": false
    }
```
4. 确保转发主机上的端口正确
5. 运行服务器并设置客户端

# 贡献 & 素材
[OxygenFilter](https://github.com/NuclearPowered/Reactor.OxygenFilter) - For all the version v2.3.0 to v2.6.1, we were using the OxygenFilter for automatic deobfuscation\
[Reactor](https://github.com/NuclearPowered/Reactor) - The framework used for all version before v2.0.0\
[BepInEx](https://github.com/BepInEx) - Used to hook game functions\
[Essentials](https://github.com/DorCoMaNdO/Reactor-Essentials) - Custom game options by **DorCoMaNdO**:
- Before v1.6: We used the default Essentials release
- v1.6-v1.8: We slightly changed the default Essentials. The changes can be found on this [branch](https://github.com/Eisbison/Reactor-Essentials/tree/feature/TheOtherRoles-Adaption) of our fork.
- v2.0.0 and later: As we're not using Reactor anymore, we are using our own implementation, inspired by the one from **DorCoMaNdO**

[Jackal and Sidekick](https://www.twitch.tv/dhalucard) - Original idea for the Jackal and Sidekick comes from **Dhalucard**\
[Among-Us-Love-Couple-Mod](https://github.com/Woodi-dev/Among-Us-Love-Couple-Mod) - Idea for the Lovers role comes from **Woodi-dev**\
[Jester](https://github.com/Maartii/Jester) - Idea for the Jester role comes from **Maartii**\
[ExtraRolesAmongUs](https://github.com/NotHunter101/ExtraRolesAmongUs) - Idea for the Engineer and Medic role comes from **NotHunter101**. Also some code snippets come of the implementation were used.\
[Among-Us-Sheriff-Mod](https://github.com/Woodi-dev/Among-Us-Sheriff-Mod) - Idea for the Sheriff role comes from **Woodi-dev**\
[TooManyRolesMods](https://github.com/Hardel-DW/TooManyRolesMods) - Idea for the Detective and Time Master roles comes from **Hardel-DW**. Also some code snippets of the implementation were used.\
[TownOfUs](https://github.com/slushiegoose/Town-Of-Us) - Idea for the Swapper, Shifter, Arsonist and a similar Mayor role come from **Slushiegoose**\
[Ottomated](https://twitter.com/ottomated_) - Idea for the Morphling, Snitch and Camouflager role come from **Ottomated**\
[Crowded-Mod](https://github.com/CrowdedMods/CrowdedMod) - Our implementation for 10+ player lobbies is inspired by the one from the **Crowded Mod Team**\

# 设置

以下暂未完成翻译工作


The mod adds a few new settings to Among Us (in addition to the role settings):
- **主播模式:** 您可以在我们中间的设置中激活主播模式。它隐藏了大厅代码，自定义服务器ip和自定义服务器端口。您可以通过更改`BepInEx\config\me.eisbison.theotherroles.cfg`文件中的 *主播模式替换文本* 来设置自定义大厅代码替换文本。
- **内鬼数量:** 在大厅内设置内鬼的数量。
- **地图:** 在大厅内改变地图。
- **最大会议数量:** 您可以设置总共可以调用的最大会议数量（每个玩家仍然拥有个人最大按钮数，但如果达到最大会议数您将无法使用您的会议，即使你还剩下一些，内鬼和豺狼的会议也算数）
- **允许在紧急会议上跳过：**如果设置为否，紧急会议中将没有跳过按钮。如果玩家不投票，则会投票给自己。
- **隐藏玩家姓名:** 隐藏您未知角色的玩家的姓名. 队伍 情人/内鬼/豺狼 仍然可以看到队友的名字。内鬼还可以看到间谍的名字，并且每个人仍然能看孩子的年龄。
- **幽灵可以看到角色**
- **幽灵可以看到投票**
- **幽灵可以看到剩余任务的数量**
- **德莱克斯:**你可以选择德莱克斯地图了。
- **任务计数:** 您现在可以选择更多任务了。
- **角色摘要:** 游戏结束时，会列出所有玩家及其角色和任务进度。

### 每个地图的任务计数限制
你可以配置:
- 最多4个普通任务
- 最多23个短任务
- 最多15个长任务

请注意，如果配置的选项超过地图的可用任务数，则任务将限制为该任务数。  \
示例：如果原地图提供的普通任务不会超过 2 个，而您配置了4个普通任务，那么船员只会收到2个普通任务。

| 地图 | 普通任务 | 短任务 | 常任务 |
|----------|:-------------:|:-------------:|:-------------:|
| 骷髅舰 / 德莱克斯 | 2 | 19 | 8
| 米拉总部 | 2 | 13 | 11
| 派鲁斯 | 4 | 14 | 15
| 飞艇 | 2 | 23 | 15
-----------------------


# 自定义帽子
## 创建并提交新的帽子设计
我们正在等待您的创意帽子设计，我们会将所有好的设计整合到我们的模组中。
以下是有关如何创建自定义帽子的一些说明:

- **创作:** 一顶帽子最多包含三个纹理。纹理的横纵比必须是`4:5`, 我们建议使用 `300px:375px`:
  - `主要纹理(必须)`:
    - 这是你帽子的主要纹理。它通常会在玩家前面呈现，如果你设置了`behind`参数，将玩家的背后呈现
    - 纹理的名称需要遵循 *hatname.png* 模式，但也可以在文件名中添加`_parametername`来设置一些额外的参数  (在 *.png* 之前)。
    - 参数`bounce`:这项参数决定了你走路的时候帽子是否会弹跳。
    - 参数`adaptive`: 如果设置了此参数，则将应用 Among Us 的着色器来着色 (该着色器将某些颜色替换为您的角色在游戏中所穿的颜色).  红色 (#ff0000) 将替换为玩家的主要颜色，蓝色 (#0000ff) 将替换为辅助颜色. 其他颜色也会被影响和改变,详细参照 [Crewmate Hat](https://static.wikia.nocookie.net/among-us-wiki/images/e/e0/Crewmate_hat.png)以了解如何使用此功能。
    - 参数`behind`: 如果设置了此参数, 主要纹理将会在玩家背后渲染。
  - `翻转纹理（可选）`:
    - 当面向左侧时，将渲染此纹理而不是主纹理。
    - 纹理的名称需要遵循图案`hatname_flip.png`.
  - `背面纹理（可选）`:
    - 此纹理将在玩家身后渲染.
    - 纹理的名称需要遵循图案`hatname_back.png`.
  - `翻转背纹理（可选）`:
    - 当面向左侧时，将渲染此纹理而不是背面纹理。 
    - 纹理的名称需要遵循图案`hatname_back_flip.png`.
  - `攀爬纹理（可选）`:
    - 当玩家攀爬时，此纹理将呈现在玩家面前。
    - 纹理的名称需要遵循图案`hatname_climb.png`.
- **测试:**您可以通过将所有文件放在 mod 文件夹的`\TheOtherHats\Test`子文件夹中来测试您的帽子设计。然后每当您开始自由模式时，您和所有假人都会戴上新帽子。如果您改变了帽子文件，您不需要重新启动Among Us只需要退出并且重新进入自由模式即可。

- **提交:** 如果您有帽子设计，可以在我们的网站上提交[Discord server](https://discord.gg/77RkMJHWsM). 我们将查看所有的帽子并将所有好的帽子添加到游戏中。

# 颜色
![TOR Colors](./Images/TOR_colors.png)

# 角色

## 角色分配
我们仍在完善角色分配系统。它现在不是那么直观，但它比旧的更灵活 
如果你使用得当的话。

首先，您需要在游戏中选择您想要的各种特殊角色（内鬼/中立/船员）的数量。 
只有在游戏中有足够多的船员/内鬼并且游戏中设置了足够多的角色（即它们设置为>0%）时，才会达到您设置的计数。然后将角色分配如下： 
- 首先，所有设置为 100% 的角色都被分配给任意玩家。
- 之后，每个选择了 10%-90% 的角色将 1-9 张ticket添加到ticket池中（有船员、中立和内鬼三个阵营的ticket池）。然后将尽可能从池中随机选择角色（直到达到选定的数量，直到没有更多的船员/内鬼或直到没有更多的ticket）。如果从池中选择了一个角色，显然该角色的所有ticket都将被删除。
- 黑手党、恋人和孩子将根据您选择的独立生成（不使用ticket系统）。之后，船员、中立和内鬼角色被随机选择和分配。

**Example:**\
设置：2个特殊的船员角色，告密者：100%，黑客：10%，追踪者：30%\
结果：分配了告密者，然后选择了池中的一个角色[黑客，追踪者，追踪者，追踪者]。\
注:将设置更改为黑客: 20%, 追踪者: 60% 会在统计上产生相同的结果。


## 黑手党（三人组） 
### **阵营: 内鬼**
黑手党是由三个内鬼组成的阵营。\
教父和普通内鬼一样。\
黑手党是在教父死亡前不能进行击杀和破坏的内鬼。\
清道夫是不能进行击杀和破坏的内鬼，但是他们可以藏匿尸体\
\
**注解:**
- 必须激活3名内鬼才能产生黑手党

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 黑手党产生概率 | -
| 清道夫冷却时间 | -
-----------------------

## 变体精灵
### **阵营: 内鬼**
变体精灵是一个可以额外扫描玩家的外表的内鬼，之后的任意时间他们可以保持该外表持续10秒钟 。
\
**注解:**
- 当他们复制孩子的外观时候，他们会缩小到孩子的大小。
- 黑客在管理台上看到了新颜色。 
- 脚印的颜色会相应地发生变化（也包括已经在地面上的脚印）。
- 其他内鬼仍然可以看到他们是内鬼（名称保持红色）。
- 护盾指示器相应地改变（在变体精灵获得或失去护盾指示） 。
- 追踪者和告密者的箭头依然有效。

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 变体精灵产生概率 | -
| 变形冷却 | -
| 变形持续时间 | 变体精灵保持变形状态的时间
-----------------------

## 伪装者
### **阵营: 内鬼**
伪装者是一个可以额外激活伪装模式的内鬼。 
伪装模式持续 10 秒，当它处于活动状态时，所有玩家名称/宠物/帽子是隐藏的，所有玩家都有相同的颜色。\
\
**注解:**
- 孩子会和其他玩家长得一样
- 脚印的颜色变成灰色（也是那些已经在地上的脚印）。
- 黑客在管理台上看到灰色图标。
- 护盾不再可见。
- 追踪者和告密者的箭头依然有效。

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 伪装者产生概率 | -
| 伪装模式冷却时间 | -
| 迷彩持续时间 | 玩家保持伪装的时间
-----------------------

## 吸血鬼❤啾❤
### **阵营: 内鬼**
吸血鬼是一个可以噬咬其他玩家的内鬼。被咬伤的玩家会在可配置的时间后死亡。\
如果吸血鬼产生概率大于0（即使游戏中没有吸血鬼），所有玩家都可以放置一个大蒜。 \
如果受害者靠近大蒜，“噬咬按钮”会变成默认的“击杀按钮”，吸血鬼只能执行普通的击杀。\
\
**注解:**
- 如果在召开会议时被噬咬的玩家还活着，他会在会议开始时死亡。 
- 冷却时间与默认击杀冷却时间相同（如果吸血鬼噬咬目标，则会从目标死亡时重置冷却时间）。 
- 如果游戏中有吸血鬼，就不可能有术士。

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 吸血鬼产生概率 | -
| 吸血鬼击杀延迟 | -
| 吸血鬼冷却时间 | 设定击杀/噬咬冷却时间
| 吸血鬼可以在大蒜附近击杀 | 当受害者靠近大蒜时，吸血鬼永远不能噬咬人。如果此选项设置为是，他仍然可以在那里执行普通的击杀。 
-----------------------

## 黑衣人
### **队伍: 内鬼**
黑衣人是个可以消除每个玩家角色的能力。\
会议结束后，目标玩家将在自己被流放之前失去他们的能力。\
在每次消除之后，冷却时间会增加10s。\
即使黑衣人或他的目标在下一次会议之前死亡，也将执行消除。\
默认情况下，黑衣人可以消除除间谍和其他内鬼之外的所有人的能力。根据选项，他也可以消除它们（内鬼将失去他们特殊的内鬼能力）\
**注解:**
- 变形者的变形优先级永远高于黑衣人的消除触发(hence either the new role of the Shifter will be erased or the Shifter saves the role of his target, depending on who the Eraser erased)
- 擦除一个情人也会自动消除另一个情人（如果第二个情人是内鬼情人，他会变成一个普通内鬼） 
- Erasing a Jackal that has a Sidekick, triggers the Sidekick promotion if it's activated in the settings
- 由于擦除是在玩家被驱逐之前触发的，（如：在同一轮中擦除并投票投出一位情人，将导致另一位情人幸存，因为伙伴关系之前已被擦除。也不会触发小丑获胜，因为在小丑获胜判定触发之前会触发擦除。）

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 黑衣人产生概率 | -
| 消除冷却时间 | 每次消除后，黑衣人的冷却时间将增加10秒。
| 黑衣人可以消除每个人 | 如果设置为否，他将无法清除间谍和其他内鬼
-----------------------

## 魔术师
### **队伍: 内鬼**
魔术师是一个内鬼，可以放置 3 个一开始对其他玩家不可见的盒子。 \
如果魔术师已经放置了他所有的盒子，它们将被转换成只有骗子自己才能使用的通风网络，但盒子会展示其他人面前。\
如果盒子被转换为通风网络，魔术师会获得一项新能力“谢幕”以限制非内鬼阵营的视野，这是其他玩家无法修复的。视野会在一段时间后自动恢复。\

\
**注解:**
- 内鬼将在屏幕底部获得一个文本指示器，以通知他们是否由于魔术师的能力而灯灭，因为没有破坏箭头或任务来破坏文本以通知他们。 
### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 魔术师产生概率 | -
| 魔术师盒子冷却时间 | 放置盒子的冷却时间
| 魔术师谢幕冷却时间 | 他的“谢幕”技能冷却时间 
| 魔术师谢幕持续时间 | 灯光自动恢复的持续时间
-----------------------

## 清洁工
### **阵营: 内鬼**
清洁工是具有清理尸体能力的内鬼。 \

\
**注解:**
- 击杀和清理冷却是共享的，防止他立即清理自己的击杀。

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 清洁工产生概率 | -
| 清洁冷却时间 | 清理尸体的冷却时间
-----------------------


## 术士
### **阵营: 内鬼**
术士是一个内鬼，可以诅咒其他玩家（被诅咒的玩家不会得到通知）。\
如果被诅咒的玩家站在另一个玩家旁边，术士可以利用被诅咒的玩家击杀另一个玩家（无论他离多远）。\
在被诅咒的玩家的帮助下进行击杀，将解除诅咒这将导致术士在可一定（可在设置中选择）的时间内无法移动。\
术士仍然可以进行普通击杀，但两个按钮共享冷却时间。

\
**注解:**
- 术士可以使用“咒杀”杀死他的内鬼伙伴（甚至是他自己） 
- 如果游戏中有术士，就不可能有吸血鬼。
- 执行普通击杀，并不会解除诅咒。

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 术士产生概率 | -
| 术士冷却时间 | 使用诅咒和咒杀的冷却时间
| 术士定身时间 | 术士在使用咒杀后定身的时间 
-----------------------

## 猜测者
### **阵营: 船员或内鬼**
猜测者可以是船员或内鬼（取决于设置） 。\
猜测者可以在会议期间通过猜测其角色来射杀玩家。如果猜错了，猜测者就会死。 \
每次会议只能射杀一个人，您可以设置最大射杀次数。 \
The guesses Impostor and Crewmate are only right, if the player is part of the corresponding team and has no special role. \
您只能在投票期间射杀。 

\
**注解:**
- 被射杀玩家的投票不会被计算在内。
- 由于显而易见的原因，您无法猜测角色 **Nice Mini**。 
- 你猜不到**情人**的角色，你必须猜其中一个情人的主要角色，从而杀死他们两个。
- 如果猜测者在小丑被投票淘汰之前射杀了小丑，则不会触发小丑获胜。

### 游戏选项 
| 名称 | 描述 |
|----------|:-------------:|
| 猜测者产生概率 | -
| 猜测者是内鬼的概率 | -
| 猜测者的射杀次数 | -

-----------------------

## 情人
### **阵营: 情人 (次要阵营)**
总有两个恋人绑定在一起。\
他们的主要目标是在比赛结束前一起存活。\
如果一名情人死了(殉情选项被激活时), 另一名情人则会自杀。\
您可以选择情人们，是否可以存在于第二个阵营（可以是中立、船员或内鬼）\ \
您可以指定其中一名情人成为内鬼的概率。 \
恋人永远不知道他们伴侣的角色，他们只知道他们的伴侣是谁。\
如果在游戏结束时他们都还活着，则恋人获胜。他们也可以用他们原来的团队获胜（例如，一个死去的内鬼可以通过内鬼获胜，纵火者情人仍然可以赢得纵火者的胜利）\
如果其中一个恋人是杀手（即豺狼/助手/内鬼），他们可以实现只有恋人获胜的“恋人独赢”。 \
如果情人中没有杀手（例如纵火情人+船员情人），并且游戏结束时他们都还活着，则他们与船员人一起获胜。\
If there's an team Impostor/Jackal Lover in the game, the tasks of a Crewmate Lover won't be counted (for a task win) as long as he's alive. If the Lover dies, his tasks will also be counted.\
\
**注解:**
- 在2船员 vs 2内鬼（或豺狼阵营的2名成员）和情人不在同一个阵营中，游戏不会自动结束，因为情人仍然可以取得“恋人独赢”。 例如：如果还剩下以下角色内鬼+内鬼情人+情人+船员，则游戏不会结束，下一次击杀将决定内鬼获胜或情人们获胜。 
- 如果变形者扮演恋人的角色，则恋人可以改变。 

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 情人产生概率 | -
| 一名情人是内鬼的概率 | -
| 殉情 | 第二名情人是否随第一名情人的死亡而自杀
| 情人可以存在于另一个阵营 | 如果设置为是，则情人可以存在于另一个阵营 
-----------------------


## 警长
### **阵营: 船员**
警长有击杀内鬼的能力。
如果他试图杀死一名船员，他会被反杀（而船员不会死）

**注解:**
- 如果警长射杀了有医疗护盾的人，警长和被保护的人**都不会受到伤害** .
- 如果警长射杀了孩子（内鬼），如果孩子（内鬼）还在成长，警长就会死亡。 如果是孩子已成年，则孩子（内鬼）死亡 

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 警长产生概率 | -
| 警长冷却时间 | -
| 警长是否可以击杀中立阵营 | -
-----------------------

## 小丑 
### **阵营: 中立**
小丑没有任何任务。如果他们在会议上被投票否决，他们会以单人身份赢得比赛。 

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 小丑产生概率 | -
| 小丑可以召开紧急会议 | 禁用小丑紧急按钮的选项 
| 小丑可以破坏 | 允许小丑破坏的选项 
-----------------------

## 纵火狂
### **阵营: 中立**
纵火犯没有任何任务，他必须独自赢得比赛。\
纵火犯可以通过按下浇汽油按钮并在玩家旁边停留几秒钟来向其他玩家浇汽油。 \
如果纵火犯正在浇汽油的玩家走出射程，则浇汽油冷却时间将重置为 0。 \
在将所有活着的人浇上汽油后，纵火犯可以点燃所有玩家，则纵火犯获胜。 

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 纵火狂产生概率 | -
| 浇汽油冷却时间 | -
| 纵火狂浇汽油持续时间 | 向一名玩家浇上汽油所需的时间 
-----------------------

## 先知 
### **阵营: 船员**
先知有两种能力（在游戏选项中设置选择）
先知可以看到前一回合死去的玩家的灵魂，灵魂慢慢褪色。 
如果玩家在地图上的某个地方死亡，先知的屏幕上会出现蓝色闪光。

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 先知产生概率 | -
| 先知模式 | 选项：显示死亡闪光和灵魂，显示死亡闪光，显示灵魂 
| 先知限制灵魂持续时间 | 切换灵魂是否应该在一段时间后隐身 
| 先知灵魂持续时间 | 设置会议结束后灵魂隐身所需的时间 
-----------------------

## 工程师（攻城狮）
### **阵营: 船员**
工程师（如果还活着）可以在每场比赛中从地图上的任何地方修复一次破坏。\
工程师可以使用通风管道。如果工程师在通风管道内，内鬼将在地图上的所有通风口周围看到蓝色轮廓（以警告内鬼）。 
由于通风管道，工程师可能无法使用“使用”按钮开始某些任务，您可以改为双击任务。 
\
**注解:**
- 如果冒名顶替者站在工程师所在的通风口旁边，则会激活他们的击杀按钮。他们也可以在那里杀死他们。没有其他动作（例如变形精灵的样本、变形者的变形等）可以影响通风口内的玩家。 
### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 工程师产生概率 | -
-----------------------

## 侦探（柯南）
### **阵营: 船员**
侦探可以看到其他玩家留下的脚印。 
侦探的另一个特点是在他们报告尸体时显示：他们收到有关凶手身份的线索。他们获得的信息类型取决于他们找到尸体所用的时间。 
\
**注解:**
- 当人们改变他们的颜色（因为变形或伪装）时，所有的脚印也会改变它们的颜色（包括已经在地上的那些）。 如果效果结束，所有足迹将切换回原始颜色。 
- 侦探看不到在通风口内的玩家的脚印。
- 有关[colors](#colors)的更多信息。 

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 侦探产生概率 | -
| 匿名足迹 | 如果设置为是，则所有足迹将具有相同的颜色。否则，它们将具有相应玩家的颜色。 
| 足迹间隔 | 两个脚印之间的间隔 
| 足迹持续时间 | 设置足迹保持可见的时间。
| 可获得名字的侦探报告时间 | 从死亡到发现的时间，在这个时间段内发现尸体，侦探可以获得凶手的名字。   |
| 可获得颜色类型的侦探报告时间 | 从死亡到发现的时间，在这个时间段内发现尸体，侦探可以获得凶手的颜色类型。|
-----------------------

## 明灯
### **阵营: 船员**
明灯可以不时地打开他的明灯模式，这会增加他的视野。 

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 明灯产生概率 | -
| 照明开启时，明灯模式的视野范围 | 照明开启时，明灯模式的视野范围
| 照明关闭时，明灯模式的视野范围 | 照明关闭时，明灯模式的视野范围
| 明灯模式冷却时间 | -
| 明灯模式持续时间 | -
-----------------------

## 孩子
### **阵营: 船员或内鬼**
孩子可以是船员（67% 的几率）或内鬼（33% 的几率）。\
孩子的角色较小，因此游戏中的每个人都可以看到。\
孩子在成年之前不能被杀死，但它可以被投票扔出去。 \
**恶堕之子:**
  - 在成长过程中，击杀冷却时间加倍。当它成年，它的击杀冷却时间是默认冷却时间的2/3。 
  - 如果它在成年之前被扔出船，则什么都不会发生。

**善良之子:**
  - 善良之子旨在发挥其在早期游戏中的无敌实力。
  - 如果它成年之前被扔出船，那么每个人都会输。因此在投票淘汰孩子之前请三思。 

**注解:**
- 内鬼不能杀死迷你（击杀按钮不起作用）直到它成年 
- 警长可以杀死恶堕之子，但前提是它成年了 

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 孩子产生概率 | -
| 孩子  | 孩子长大所需时间
-----------------------

## 医师
### **阵营: 船员**
医师可以在每场游戏中给一名玩家套上医师护盾（玩家周围轮廓高亮显示），使这名玩家无法被击杀。\
被护盾的玩家仍然可以被投票投出，也有可能是一个内鬼。\
如果有人（内鬼、警长……）试图谋杀他们，被屏蔽的玩家将在屏幕上闪烁红色（在选项中设置了） 
如果医生死了，护盾也会随之消失。 \
如果警长试图杀死一个有保护的船员，船员和警长不会死，如果他试图杀死一个有医师护盾的内鬼，也不会执行击杀。\
医生的另一个功能是在他们报告尸体时显示：他们会看到玩家死了多久。
\
**注解:**
- 如果被护盾保护的玩家是一位情人而另一个情人死亡，他仍然会自杀。 
- 如果变形者有护盾或他们的目标有护盾，则被护盾保护的玩家会切换。 


### 游戏选项
| 名称 | 描述 | 选项 |
|----------|:-------------:|:-------------:|
| 医师产生概率 | - | -
| 显示护盾玩家 | 设置谁可以查看玩家是否有护盾 | "每个人", "被保护的人+医师", "仅医师"
| 受保护的玩家看到谋杀企图 | 被保护的玩家是否看到有人试图杀死他  | 是/否 |
-----------------------

## 市长
### **阵营: 成员**
市长通过两次计数的投票来领导船员。 \
市长始终可以使用他的会议，即使达到了最大会议次数。 

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 市长产生概率 | -
-----------------------

## 黑客
### **阵营: 船员**
如果黑客激活“黑客模式”，黑客在设定的时间内从管理台和生命体征中获得的信息比其他人更多。\
其他情况下，他会看到与其他人相同的信息。 
**管理台:** 黑客可以在管理台上看到玩家的颜色（或颜色类型）。 \
**命脉**: 黑客可以看到死去的玩家已经死了多久。\
\
**注解:**
- 如果变体精灵使用变形或伪装者发动伪装，管理台上的颜色会相应改变。 
- 有关[colors](#colors)的更多信息。

###游戏选项 
| 名称 | 描述 |
|----------|:-------------:|
| 黑客产生概率 | -
| 黑客冷却时间 | -
| 黑客模式持续时间 | 设置“黑客模式”保持激活的时间
| 黑客只看到颜色类型 | 设置黑客是在管理表上看到玩家颜色还是只看到白色/灰色（用于较浅和较深的颜色） 
-----------------------


## 变形者
### **阵营: 船员**
变形者可以接任另一个普通船员的角色，另一个玩家将转变为普通船员。\
转移将始终在下一次会议结束时玩家被放逐之前进行。 需要在回合中选择目标。\
即使转移者或目标在会议前死亡，转移仍然会被执行。\
与内鬼或中立者交换角色失败，而变形者在下一次会议后自杀（不会有任何尸体）。\
变形者旨在通过保存离开游戏的角色，例如接管被内鬼认识的警长或医生。\
这对黑衣人特别有效，但也使黑衣人有可能像变形者干一样的活。\
与变形者的**特殊交互**在相应角色的章节中注明。 \
\
**注解:**
- 变形者的变形优先级永远高于黑衣人的消除触发 (hence either the new role of the Shifter will be erased or the Shifter saves the role of his target, depending on who the Eraser erased) 
- 如果变形者接替角色，他们的新冷却时间将从该技能的最大冷却时间开始计算
- 一次使用能力（例如保护玩家或工程师破坏修复）只能由游戏中的一名玩家使用（即变形者只能在之前玩家没有使用过能力的时候使用它们）

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 变形者产生概率 | -
-----------------------

## 时间大师
### **阵营: 船员**
时间大师有一个他可以激活的时间护盾。时间护盾可在根据需要激活。 \
如果玩家在时间护盾处于活动状态时试图杀死时间大师，则不会发生击杀并触发时光倒流（时间会倒退一段设定的时间。） \
杀手的击杀冷却时间不会重置，所以时间大师不得不确保游戏不会导致相同的情况。（及时跑路）\
时间大师不会受到时光倒流的影响。\
\
**NOTE:**
- 只有移动受时光倒流的影响 
- 吸血鬼噬咬会触发时光倒流。如果时间大师没有在护盾激活期间被噬咬，他仍然会护盾结束后几秒钟被噬咬击杀。 
- 如果时间大师在召开会议之前被噬咬并激活了他的护盾，他会活下来，但不会触发时光倒流。 
- 如果时间大师有医疗护盾，他就不会触发时光倒流。 
- 护盾本身在触发时立即结束。因此，只要时光倒流结束，时间大师就可以再次被攻击。 

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 时间大师产生概率 | - |
| 时间护盾冷却时间 | - |
| 时光倒流持续时间 | 时光倒流多少时间 |
| 时间护盾持续时间 |
-----------------------

## 交换者
### **阵营: 船员**
在会议期间，交换者可以交换两个人获得的选票（即玩家A得到所有选票的将被给予玩家B，反之亦然）。\
由于交换者在会议上的优势，他们可能不会召开紧急会议，也无法修理电灯和通讯设备。

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 交换者产生概率 | -
| 交换者可以召集紧急会议 | 禁用交换者紧急按钮的选项 
| 交换者只能交换其他人 | 设置交换者是否可以交换自己
-----------------------

## 追踪者
### **阵营: 船员**
追踪者可以在游戏中选择一个玩家并在游戏的剩余时间跟踪该玩家。箭头指向玩家最后跟踪的位置。
箭头每隔几秒更新一次它的位置（可配置）。

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 追踪者 | -
| 跟踪器更新间隔 | 设置位置更新的频率
-----------------------

## 告密者 
### **阵营: 船员**
当告密者完成所有任务后，会出现指向内鬼的箭头（仅对告密者可见）。
当告密者还剩下一项任务（可配置）时，告密者将显示给内鬼，也带有箭头。 

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 告密者产生概率 | -
| 内鬼看到告密者的任务计数 | -
-----------------------

## 豺狼 
### **阵营: 豺狼 **
豺狼是一个额外团队的一部分，该团队旨在于消灭所有其他玩家。\
豺狼没有任务，可以杀死内鬼、船员和中立人物。\
豺狼（如果选项允许）可以选择另一个玩家作为他的助手。
创建助手会删除助手的所有任务并将他添加到豺狼阵营。助手失去了他目前的角色（除非他是情人，否则他会在两个阵营中共同存在）。
“创建搭档动作”每只豺狼或每场比赛只能使用一次（取决于选项）。 
豺狼也可以将内鬼提升为他的助手，根据选项，内鬼可以真的变成助手并离开内鬼阵营，也可以仅让豺狼认为他得到助手（实际上没有）。\
\
豺狼阵营的启用导致游戏出现多个新结果，在此处列出了一些示例： 
- 内鬼可以被全数淘汰，然后船员阵营与豺狼阵营继续游戏。 
- 可以消灭船员，然后豺狼阵营与内鬼阵营战斗（在这种情况下，船员仍然可以赢得任务） 

获胜条件的优先级如下： 
1. 善良之子被投票投出 
2. 小丑通过投票获胜 
3. 纵火狂获胜
4. 内鬼阵营通过破坏取胜 
5. 船员阵营通过任务获胜（如果整个船员阵营都死了，也有可能） 
6. 最后三名玩家中的恋人获胜 
7. 豺狼阵营以人数多胜数获胜（当豺狼阵营包含的玩家数量等于或大于船员，并且还剩下0个内鬼且豺狼阵营没有情人时） 
8. 内鬼阵营以人数多胜数获胜（当内鬼阵营包含的玩家数量等于或大于船员，并且豺狼阵营剩下0个玩家并且内鬼阵营没有情人时） 
9. 船员阵营以人数多的方式获胜（当豺狼阵营和内鬼阵营中没有玩家时） 

**注解:**
- 豺狼（和他的助手）可以被警长杀死。 
- 豺狼不能把未成年的孩子作为目标。成年之后他可以杀死它或选择它作为豺狼的助手 
- 即使船员的所有成员都死了，如果船员足够快地完成任务，船员仍然可以获胜（这就是为什么将最后一个有任务的船员转换为助手会导致船员通过任务获得胜利） 
如果内鬼和豺狼都在游戏中，即使所有船员都死了，游戏也会继续。在这种情况下，船员们仍然可以通过完成他们的任务来获胜。豺狼和内鬼必须自相残杀。 



### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 豺狼产生概率 | - |
| 豺狼/助手击杀冷却时间 | 击杀冷却时间 |
| 豺狼创造助手冷却时间 | 可以创建助手之前的冷却时间  |
| 豺狼可以使用通风口  | 是/否 |
| 豺狼可以创造助手 | 是/否 |
| 从助手晋升的豺狼可以创建一个助手  | 是/否（阻止豺狼阵营成长）  |
| 豺狼可以让内鬼成为他的助手  | 是/否 (为了防止豺狼将内鬼变成助手, 如果他对内鬼使用该能力，他会将内鬼视为助手，但内鬼不会转换为助手。如果此选项设置为“否”，豺狼和助手可以互相残杀） |
| 豺狼和助手有内鬼的视野  | - |
-----------------------

## 助手
### **阵营: 豺狼**
在游戏过程中被豺狼的“创建搭档动作”指派给一名玩家，并加入豺狼队以消灭所有其他玩家。\
在豺狼死后（取决于选项），他可能会自己晋升为豺狼，甚至有可能指派他自己的助手。
\
**注解:**
- 转换为助手的玩家将失去他之前的角色和任务（如果他有的话），除了情人角色。 
- 助手可以被警长杀死。
- The Sidekick cannot target the Mini, while it's growing up.

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 豺狼/助手击杀冷却时间 | 使用与豺狼相同的击杀冷却设置  |
| 在豺狼死后，助手被晋升为豺狼 | 是/否 |
| 助手可以进行击杀 | 是/否 |
| 助手可以使用通风口 | 是/否 |
-----------------------

## 间谍
### **阵营: 船员**
间谍是没有特殊能力的船员。\
对内鬼来说间谍看起来像是额外的内鬼，他们无法区分。\
有两种选项（取决于设置）:
- 内鬼不能杀死间谍（否则他们的杀死按钮会透露间谍是谁）
- 内鬼可以杀死间谍，但他们也可以杀死他们的内鬼同志（如果他们将另一个内鬼误认为是间谍） 
您可以设置警长是否可以杀死间谍（以保持谎言的存在）。 

### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 间谍产生概率 |
| 间谍是否会被警长射杀 |
| 如果有间谍，内鬼可以杀死任何人 | 这允许内鬼杀死间谍和他们的内鬼同志 
| 间谍可以进入通风口 | 允许间谍进入/退出通风口（但实际上不会移动到连接的通风口）
| 间谍有内鬼的视野  | 间谍的视野与内鬼的视野相同 
-----------------------

## 保安
### **阵营: 船员**
保安是使用螺钉进行放置新的监视摄像机的船员，也可以使用螺丝封堵通风口。\
放置新监视摄像机和封堵通风口需要一定数量的螺丝。保安的螺丝总数可以在设置中选择。\
新的监视摄像机将在下一次会议后可见，并且可供所有人使用。\
通风口将在下一次会议后被封堵，玩家无法进入或退出密封的通风口，但他们仍然可以在地下“移动到它们下面”。 \
**注解:**
- 魔术师的盒子无法被封堵 
- 保安不能在米拉总部上放置摄像头 
- 剩余的螺丝数量可以在他的特殊按钮上方看到 
- 在骷髅舰上，四个监视摄像机画面每3秒更换一次（接下来的四个摄像头）。您还可以使用箭头键手动导航。 


### 游戏选项
| 名称 | 描述 |
|----------|:-------------:|
| 保安产生概率 |
| 保安冷却时间 |
| 保安螺丝数量  | 保安在一场游戏中可以使用的螺丝数量 
| 每个监视摄像机的螺钉数 | 放置监视摄像机所需的螺丝数量 
| 每个通风口的螺钉数量 | 封堵通风口所需的螺钉数量 
-----------------------


# 源代码 
It's bad I know, this is a side project and my second week of modding. So there are no best practices around here.
You can use parts of the code but don't copy paste the whole thing. Make sure you give credits to the other developers, because some parts of the code are based on theirs.

# Bugs,建议和请求 
如果您发现任何错误，对新角色或任何其他请求有想法，请加入我们的[Discord server](https://discord.gg/77RkMJHWsM)
