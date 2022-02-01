﻿using Mangos.Data.Entities.MangosDatabase;
using Microsoft.EntityFrameworkCore;

namespace Mangos.Data.Context;

public class ClassicmangosDbContext : DbContext
{
    public ClassicmangosDbContext() {}
    public ClassicmangosDbContext(DbContextOptions options) : base(options) {}
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<AreatriggerInvolvedrelation>().HasKey(e => new { e.Id });
        builder.Entity<AreatriggerTavern>().HasKey(e => new { e.Id });
        builder.Entity<AreatriggerTeleport>().HasKey(e => new { e.Id });
        builder.Entity<Auction>().HasKey(e => new { e.Id });
        builder.Entity<BattlegroundEvents>().HasKey(e => new { e.Description, e.Event1, e.Event2, e.Map });
        builder.Entity<BattlegroundTemplate>().HasKey(e => new { e.Id });
        builder.Entity<BattlemasterEntry>().HasKey(e => new { e.BgTemplate, e.Entry });
        builder.Entity<BroadcastText>().HasKey(e => new { e.Id });
        builder.Entity<BroadcastTextLocale>().HasKey(e => new { e.Id, e.Locale });
        builder.Entity<Bugreport>().HasKey(e => new { e.Id });
        builder.Entity<Command>().HasKey(e => new { e.Help, e.Name });
        builder.Entity<Conditions>().HasKey(e => new { e.Comments, e.ConditionEntry });
        builder.Entity<Creature>().HasKey(e => new { e.Curhealth, e.Guid });
        builder.Entity<CreatureAddon>().HasKey(e => new { e.Auras, e.Guid });
        builder.Entity<CreatureAiScripts>().HasKey(e => new { e.Id });
        builder.Entity<CreatureAiSummons>().HasKey(e => new { e.Id });
        builder.Entity<CreatureAiTexts>().HasKey(e => new { e.BroadcastTextId, e.Entry });
        builder.Entity<CreatureBattleground>().HasKey(e => new { e.Event1, e.Guid });
        builder.Entity<CreatureConditionalSpawn>().HasKey(e => new { e.Comments, e.Guid });
        builder.Entity<CreatureCooldowns>().HasKey(e => new { e.CooldownMax, e.Entry, e.SpellId });
        builder.Entity<CreatureEquipTemplate>().HasKey(e => new { e.Entry });
        builder.Entity<CreatureImmunities>().HasKey(e => new { e.Entry, e.SetId, e.Type, e.Value });
        builder.Entity<CreatureInvolvedrelation>().HasKey(e => new { e.Id, e.Quest });
        builder.Entity<CreatureLinking>().HasKey(e => new { e.Flag, e.Guid });
        builder.Entity<CreatureLinkingTemplate>().HasKey(e => new { e.Entry, e.Map });
        builder.Entity<CreatureLootTemplate>().HasKey(e => new { e.ChanceOrQuestChance, e.Entry, e.Item });
        builder.Entity<CreatureModelInfo>().HasKey(e => new { e.BoundingRadius, e.Modelid });
        builder.Entity<CreatureModelRace>().HasKey(e => new { e.CreatureEntry, e.Modelid, e.Racemask });
        builder.Entity<CreatureMovement>().HasKey(e => new { e.Id, e.Point });
        builder.Entity<CreatureMovementTemplate>().HasKey(e => new { e.Comment, e.Entry, e.PathId, e.Point });
        builder.Entity<CreatureOnkillReputation>().HasKey(e => new { e.CreatureId });
        builder.Entity<CreatureQuestrelation>().HasKey(e => new { e.Id, e.Quest });
        builder.Entity<CreatureSpawnData>().HasKey(e => new { e.Guid });
        builder.Entity<CreatureSpawnDataTemplate>().HasKey(e => new { e.CurHealth, e.CurMana, e.Entry, e.EquipmentId, e.ModelId, e.SpawnFlags, e.UnitFlags });
        builder.Entity<CreatureSpawnEntry>().HasKey(e => new { e.Entry, e.Guid });
        builder.Entity<CreatureSpellList>().HasKey(e => new { e.Id, e.Position });
        builder.Entity<CreatureSpellListEntry>().HasKey(e => new { e.Id });
        builder.Entity<CreatureSpellTargeting>().HasKey(e => new { e.Id });
        builder.Entity<CreatureTemplate>().HasKey(e => new { e.AIName, e.Entry });
        builder.Entity<CreatureTemplateAddon>().HasKey(e => new { e.Auras, e.Entry });
        builder.Entity<CreatureTemplateArmor>().HasKey(e => new { e.AIName, e.Entry });
        builder.Entity<CreatureTemplateClasslevelstats>().HasKey(e => new { e.BaseArmor, e.Class, e.Level });
        builder.Entity<CreatureTemplateSpells>().HasKey(e => new { e.Entry, e.SetId });
        builder.Entity<CustomTexts>().HasKey(e => new { e.BroadcastTextId, e.Entry });
        builder.Entity<DbscriptRandomTemplates>().HasKey(e => new { e.Id, e.TargetId, e.Type });
        builder.Entity<DbscriptString>().HasKey(e => new { e.BroadcastTextId, e.Entry });
        builder.Entity<DbscriptStringTemplate>().HasKey(e => new { e.Id, e.StringId });
        builder.Entity<DbscriptsOnCreatureDeath>().HasKey(e => new { e.BuddyEntry });
        builder.Entity<DbscriptsOnCreatureMovement>().HasKey(e => new { e.BuddyEntry });
        builder.Entity<DbscriptsOnEvent>().HasKey(e => new { e.BuddyEntry });
        builder.Entity<DbscriptsOnGoTemplateUse>().HasKey(e => new { e.BuddyEntry });
        builder.Entity<DbscriptsOnGoUse>().HasKey(e => new { e.BuddyEntry });
        builder.Entity<DbscriptsOnGossip>().HasKey(e => new { e.BuddyEntry });
        builder.Entity<DbscriptsOnQuestEnd>().HasKey(e => new { e.BuddyEntry });
        builder.Entity<DbscriptsOnQuestStart>().HasKey(e => new { e.BuddyEntry });
        builder.Entity<DbscriptsOnRelay>().HasKey(e => new { e.BuddyEntry });
        builder.Entity<DbscriptsOnSpell>().HasKey(e => new { e.BuddyEntry });
        builder.Entity<DisenchantLootTemplate>().HasKey(e => new { e.ChanceOrQuestChance, e.Entry, e.Item });
        builder.Entity<ExplorationBasexp>().HasKey(e => new { e.Basexp, e.Level });
        builder.Entity<FishingLootTemplate>().HasKey(e => new { e.ChanceOrQuestChance, e.Entry, e.Item });
        builder.Entity<GameEvent>().HasKey(e => new { e.Description, e.Entry });
        builder.Entity<GameEventCreature>().HasKey(e => new { e.Event, e.Guid });
        builder.Entity<GameEventCreatureData>().HasKey(e => new { e.EntryId, e.Event, e.Guid });
        builder.Entity<GameEventGameobject>().HasKey(e => new { e.Event, e.Guid });
        builder.Entity<GameEventMail>().HasKey(e => new { e.Event, e.Quest, e.RaceMask });
        builder.Entity<GameEventQuest>().HasKey(e => new { e.Event, e.Quest });
        builder.Entity<GameEventTime>().HasKey(e => new { e.EndTime, e.Entry });
        builder.Entity<GameGraveyardZone>().HasKey(e => new { e.GhostLoc, e.Id, e.LinkKind });
        builder.Entity<GameTele>().HasKey(e => new { e.Id });
        builder.Entity<GameWeather>().HasKey(e => new { e.FallRainChance, e.Zone });
        builder.Entity<Gameobject>().HasKey(e => new { e.Animprogress, e.Guid });
        builder.Entity<GameobjectAddon>().HasKey(e => new { e.Guid });
        builder.Entity<GameobjectBattleground>().HasKey(e => new { e.Event1, e.Guid });
        builder.Entity<GameobjectInvolvedrelation>().HasKey(e => new { e.Id, e.Quest });
        builder.Entity<GameobjectLootTemplate>().HasKey(e => new { e.ChanceOrQuestChance, e.Entry, e.Item });
        builder.Entity<GameobjectQuestrelation>().HasKey(e => new { e.Id, e.Quest });
        builder.Entity<GameobjectSpawnEntry>().HasKey(e => new { e.Entry, e.Guid });
        builder.Entity<GameobjectTemplate>().HasKey(e => new { e.CustomData1, e.Entry });
        builder.Entity<GossipMenu>().HasKey(e => new { e.ConditionId, e.Entry, e.ScriptId, e.TextId });
        builder.Entity<GossipMenuOption>().HasKey(e => new { e.Id, e.MenuId });
        builder.Entity<GossipTexts>().HasKey(e => new { e.Comment, e.Entry });
        builder.Entity<InstanceDungeonEncounters>().HasKey(e => new { e.Id });
        builder.Entity<InstanceEncounters>().HasKey(e => new { e.CreditEntry, e.Entry });
        builder.Entity<InstanceTemplate>().HasKey(e => new { e.GhostEntranceMap, e.Map });
        builder.Entity<ItemConvert>().HasKey(e => new { e.Entry });
        builder.Entity<ItemEnchantmentTemplate>().HasKey(e => new { e.Chance, e.Ench, e.Entry });
        builder.Entity<ItemExpireConvert>().HasKey(e => new { e.Entry });
        builder.Entity<ItemLootTemplate>().HasKey(e => new { e.ChanceOrQuestChance, e.Entry, e.Item });
        builder.Entity<ItemRequiredTarget>().HasKey(e => new { e.Entry, e.TargetEntry, e.Type });
        builder.Entity<ItemTemplate>().HasKey(e => new { e.AllowableClass, e.Entry });
        builder.Entity<LocalesAreatriggerTeleport>().HasKey(e => new { e.Entry });
        builder.Entity<LocalesCreature>().HasKey(e => new { e.Entry });
        builder.Entity<LocalesGameobject>().HasKey(e => new { e.Entry });
        builder.Entity<LocalesGossipMenuOption>().HasKey(e => new { e.Id, e.MenuId });
        builder.Entity<LocalesItem>().HasKey(e => new { e.DescriptionLoc1, e.Entry });
        builder.Entity<LocalesNpcText>().HasKey(e => new { e.Entry });
        builder.Entity<LocalesPageText>().HasKey(e => new { e.Entry });
        builder.Entity<LocalesPointsOfInterest>().HasKey(e => new { e.Entry });
        builder.Entity<LocalesQuest>().HasKey(e => new { e.DetailsLoc1, e.Entry });
        builder.Entity<LocalesQuestgiverGreeting>().HasKey(e => new { e.Entry, e.Type });
        builder.Entity<LocalesTrainerGreeting>().HasKey(e => new { e.Entry });
        builder.Entity<MailLevelReward>().HasKey(e => new { e.Level, e.RaceMask });
        builder.Entity<MailLootTemplate>().HasKey(e => new { e.ChanceOrQuestChance, e.Entry, e.Item });
        builder.Entity<MangosString>().HasKey(e => new { e.ContentDefault, e.Entry });
        builder.Entity<NpcGossip>().HasKey(e => new { e.NpcGuid });
        builder.Entity<NpcSpellclickSpells>().HasKey(e => new { e.CastFlags });
        builder.Entity<NpcText>().HasKey(e => new { e.ID });
        builder.Entity<NpcTextBroadcastText>().HasKey(e => new { e.Id });
        builder.Entity<NpcTrainer>().HasKey(e => new { e.ConditionId, e.Entry, e.Spell });
        builder.Entity<NpcTrainerTemplate>().HasKey(e => new { e.ConditionId, e.Entry, e.Spell });
        builder.Entity<NpcVendor>().HasKey(e => new { e.Comments, e.Entry, e.Item });
        builder.Entity<NpcVendorTemplate>().HasKey(e => new { e.Comments, e.Entry, e.Item });
        builder.Entity<PageText>().HasKey(e => new { e.Entry });
        builder.Entity<PetFamilystats>().HasKey(e => new { e.ArmorModifier, e.Family });
        builder.Entity<PetLevelstats>().HasKey(e => new { e.Agi, e.CreatureEntry, e.Level });
        builder.Entity<PetLevelstatsCopy>().HasKey(e => new { e.Agi, e.CreatureEntry, e.Level });
        builder.Entity<PetNameGeneration>().HasKey(e => new { e.Id });
        builder.Entity<PetcreateinfoSpell>().HasKey(e => new { e.Entry });
        builder.Entity<PickpocketingLootTemplate>().HasKey(e => new { e.ChanceOrQuestChance, e.Entry, e.Item });
        builder.Entity<PlayerClasslevelstats>().HasKey(e => new { e.Basehp, e.Class, e.Level });
        builder.Entity<PlayerLevelstats>().HasKey(e => new { e.Agi, e.Class, e.Level, e.Race });
        builder.Entity<PlayerXpForLevel>().HasKey(e => new { e.Lvl });
        builder.Entity<Playercreateinfo>().HasKey(e => new { e.Class, e.Race });
        builder.Entity<PlayercreateinfoAction>().HasKey(e => new { e.Action, e.Button, e.Class, e.Race });
        builder.Entity<PlayercreateinfoItem>().HasKey(e => new { e.Amount });
        builder.Entity<PlayercreateinfoSkills>().HasKey(e => new { e.ClassMask, e.RaceMask, e.Skill });
        builder.Entity<PlayercreateinfoSpell>().HasKey(e => new { e.Class, e.Race, e.Spell });
        builder.Entity<PointsOfInterest>().HasKey(e => new { e.Data, e.Entry });
        builder.Entity<PoolCreature>().HasKey(e => new { e.Chance, e.Guid });
        builder.Entity<PoolCreatureTemplate>().HasKey(e => new { e.Id });
        builder.Entity<PoolGameobject>().HasKey(e => new { e.Chance, e.Guid });
        builder.Entity<PoolGameobjectTemplate>().HasKey(e => new { e.Id });
        builder.Entity<PoolPool>().HasKey(e => new { e.Chance, e.PoolId });
        builder.Entity<PoolTemplate>().HasKey(e => new { e.Description, e.Entry });
        builder.Entity<ProspectingLootTemplate>().HasKey(e => new { e.ChanceOrQuestChance, e.Entry, e.Item });
        builder.Entity<QuestPoi>().HasKey(e => new { e.FloorId, e.PoiId, e.QuestId });
        builder.Entity<QuestPoiPoints>().HasKey(e => new { e.PoiId });
        builder.Entity<QuestTemplate>().HasKey(e => new { e.CompleteEmote, e.Entry });
        builder.Entity<QuestgiverGreeting>().HasKey(e => new { e.EmoteDelay, e.Entry, e.Type });
        builder.Entity<ReferenceLootTemplate>().HasKey(e => new { e.ChanceOrQuestChance, e.Entry, e.Item });
        builder.Entity<ReferenceLootTemplateNames>().HasKey(e => new { e.Entry });
        builder.Entity<ReputationRewardRate>().HasKey(e => new { e.CreatureRate, e.Faction });
        builder.Entity<ReputationSpilloverTemplate>().HasKey(e => new { e.Faction });
        builder.Entity<ReservedName>().HasKey(e => new { e.Name });
        builder.Entity<ScriptTexts>().HasKey(e => new { e.BroadcastTextId, e.Entry });
        builder.Entity<ScriptWaypoint>().HasKey(e => new { e.Comment, e.Entry, e.PathId, e.Point });
        builder.Entity<ScriptedAreatrigger>().HasKey(e => new { e.Entry });
        builder.Entity<ScriptedEventId>().HasKey(e => new { e.Id });
        builder.Entity<SkillDiscoveryTemplate>().HasKey(e => new { e.Chance, e.ReqSpell, e.SpellId });
        builder.Entity<SkillExtraItemTemplate>().HasKey(e => new { e.AdditionalCreateChance, e.SpellId });
        builder.Entity<SkillFishingBaseLevel>().HasKey(e => new { e.Entry });
        builder.Entity<SkinningLootTemplate>().HasKey(e => new { e.ChanceOrQuestChance, e.Entry, e.Item });
        builder.Entity<SpamRecords>().HasKey(e => new { e.Id });
        builder.Entity<SpawnGroup>().HasKey(e => new { e.Id });
        builder.Entity<SpawnGroupEntry>().HasKey(e => new { e.Entry, e.Id });
        builder.Entity<SpawnGroupFormation>().HasKey(e => new { e.Id });
        builder.Entity<SpawnGroupLinkedGroup>().HasKey(e => new { e.Id, e.LinkedId });
        builder.Entity<SpawnGroupSpawn>().HasKey(e => new { e.Guid, e.Id });
        builder.Entity<SpellAffect>().HasKey(e => new { e.EffectId, e.Entry });
        builder.Entity<SpellArea>().HasKey(e => new { e.Area, e.AuraSpell, e.Gender, e.QuestStart, e.QuestStartActive, e.Racemask, e.Spell });
        builder.Entity<SpellBonusData>().HasKey(e => new { e.ApBonus, e.Entry });
        builder.Entity<SpellChain>().HasKey(e => new { e.FirstSpell, e.SpellId });
        builder.Entity<SpellCone>().HasKey(e => new { e.Id });
        builder.Entity<SpellElixir>().HasKey(e => new { e.Entry });
        builder.Entity<SpellFacing>().HasKey(e => new { e.Entry });
        builder.Entity<SpellLearnSpell>().HasKey(e => new { e.Active, e.Entry, e.SpellID });
        builder.Entity<SpellLootTemplate>().HasKey(e => new { e.ChanceOrQuestChance, e.Entry, e.Item });
        builder.Entity<SpellPetAuras>().HasKey(e => new { e.Aura, e.Pet, e.Spell });
        builder.Entity<SpellProcEvent>().HasKey(e => new { e.Cooldown, e.Entry });
        builder.Entity<SpellProcItemEnchant>().HasKey(e => new { e.Entry });
        builder.Entity<SpellScriptTarget>().HasKey(e => new { e.Entry, e.TargetEntry, e.Type });
        builder.Entity<SpellScripts>().HasKey(e => new { e.Id });
        builder.Entity<SpellTargetPosition>().HasKey(e => new { e.Id });
        builder.Entity<SpellTemplate>().HasKey(e => new { e.Id });
        builder.Entity<SpellThreat>().HasKey(e => new { e.ApBonus, e.Entry });
        builder.Entity<TaxiShortcuts>().HasKey(e => new { e.Comments, e.Pathid });
        builder.Entity<TrainerGreeting>().HasKey(e => new { e.Entry });
        builder.Entity<Transports>().HasKey(e => new { e.Entry });
        builder.Entity<VehicleAccessory>().HasKey(e => new { e.AccessoryEntry, e.Seat, e.VehicleEntry });
        builder.Entity<WardenScans>().HasKey(e => new { e.Id });
        builder.Entity<WaypointPath>().HasKey(e => new { e.Comment, e.PathId, e.Point });
        builder.Entity<WorldSafeLocs>().HasKey(e => new { e.Id });
        builder.Entity<WorldTemplate>().HasKey(e => new { e.Map });
    }

    public virtual DbSet<AreatriggerInvolvedrelation> AreatriggerInvolvedrelations { get; set; }
    public virtual DbSet<AreatriggerTavern> AreatriggerTaverns { get; set; }
    public virtual DbSet<AreatriggerTeleport> AreatriggerTeleports { get; set; }
    public virtual DbSet<Auction> Auctions { get; set; }
    public virtual DbSet<BattlegroundEvents> BattlegroundEventss { get; set; }
    public virtual DbSet<BattlegroundTemplate> BattlegroundTemplates { get; set; }
    public virtual DbSet<BattlemasterEntry> BattlemasterEntrys { get; set; }
    public virtual DbSet<BroadcastText> BroadcastTexts { get; set; }
    public virtual DbSet<BroadcastTextLocale> BroadcastTextLocales { get; set; }
    public virtual DbSet<Bugreport> Bugreports { get; set; }
    public virtual DbSet<Command> Commands { get; set; }
    public virtual DbSet<Conditions> Conditionss { get; set; }
    public virtual DbSet<Creature> Creatures { get; set; }
    public virtual DbSet<CreatureAddon> CreatureAddons { get; set; }
    public virtual DbSet<CreatureAiScripts> CreatureAiScriptss { get; set; }
    public virtual DbSet<CreatureAiSummons> CreatureAiSummonss { get; set; }
    public virtual DbSet<CreatureAiTexts> CreatureAiTextss { get; set; }
    public virtual DbSet<CreatureBattleground> CreatureBattlegrounds { get; set; }
    public virtual DbSet<CreatureConditionalSpawn> CreatureConditionalSpawns { get; set; }
    public virtual DbSet<CreatureCooldowns> CreatureCooldownss { get; set; }
    public virtual DbSet<CreatureEquipTemplate> CreatureEquipTemplates { get; set; }
    public virtual DbSet<CreatureImmunities> CreatureImmunitiess { get; set; }
    public virtual DbSet<CreatureInvolvedrelation> CreatureInvolvedrelations { get; set; }
    public virtual DbSet<CreatureLinking> CreatureLinkings { get; set; }
    public virtual DbSet<CreatureLinkingTemplate> CreatureLinkingTemplates { get; set; }
    public virtual DbSet<CreatureLootTemplate> CreatureLootTemplates { get; set; }
    public virtual DbSet<CreatureModelInfo> CreatureModelInfos { get; set; }
    public virtual DbSet<CreatureModelRace> CreatureModelRaces { get; set; }
    public virtual DbSet<CreatureMovement> CreatureMovements { get; set; }
    public virtual DbSet<CreatureMovementTemplate> CreatureMovementTemplates { get; set; }
    public virtual DbSet<CreatureOnkillReputation> CreatureOnkillReputations { get; set; }
    public virtual DbSet<CreatureQuestrelation> CreatureQuestrelations { get; set; }
    public virtual DbSet<CreatureSpawnData> CreatureSpawnDatas { get; set; }
    public virtual DbSet<CreatureSpawnDataTemplate> CreatureSpawnDataTemplates { get; set; }
    public virtual DbSet<CreatureSpawnEntry> CreatureSpawnEntrys { get; set; }
    public virtual DbSet<CreatureSpellList> CreatureSpellLists { get; set; }
    public virtual DbSet<CreatureSpellListEntry> CreatureSpellListEntrys { get; set; }
    public virtual DbSet<CreatureSpellTargeting> CreatureSpellTargetings { get; set; }
    public virtual DbSet<CreatureTemplate> CreatureTemplates { get; set; }
    public virtual DbSet<CreatureTemplateAddon> CreatureTemplateAddons { get; set; }
    public virtual DbSet<CreatureTemplateArmor> CreatureTemplateArmors { get; set; }
    public virtual DbSet<CreatureTemplateClasslevelstats> CreatureTemplateClasslevelstatss { get; set; }
    public virtual DbSet<CreatureTemplateSpells> CreatureTemplateSpellss { get; set; }
    public virtual DbSet<CustomTexts> CustomTextss { get; set; }
    public virtual DbSet<DbscriptRandomTemplates> DbscriptRandomTemplatess { get; set; }
    public virtual DbSet<DbscriptString> DbscriptStrings { get; set; }
    public virtual DbSet<DbscriptStringTemplate> DbscriptStringTemplates { get; set; }
    public virtual DbSet<DbscriptsOnCreatureDeath> DbscriptsOnCreatureDeaths { get; set; }
    public virtual DbSet<DbscriptsOnCreatureMovement> DbscriptsOnCreatureMovements { get; set; }
    public virtual DbSet<DbscriptsOnEvent> DbscriptsOnEvents { get; set; }
    public virtual DbSet<DbscriptsOnGoTemplateUse> DbscriptsOnGoTemplateUses { get; set; }
    public virtual DbSet<DbscriptsOnGoUse> DbscriptsOnGoUses { get; set; }
    public virtual DbSet<DbscriptsOnGossip> DbscriptsOnGossips { get; set; }
    public virtual DbSet<DbscriptsOnQuestEnd> DbscriptsOnQuestEnds { get; set; }
    public virtual DbSet<DbscriptsOnQuestStart> DbscriptsOnQuestStarts { get; set; }
    public virtual DbSet<DbscriptsOnRelay> DbscriptsOnRelays { get; set; }
    public virtual DbSet<DbscriptsOnSpell> DbscriptsOnSpells { get; set; }
    public virtual DbSet<DisenchantLootTemplate> DisenchantLootTemplates { get; set; }
    public virtual DbSet<ExplorationBasexp> ExplorationBasexps { get; set; }
    public virtual DbSet<FishingLootTemplate> FishingLootTemplates { get; set; }
    public virtual DbSet<GameEvent> GameEvents { get; set; }
    public virtual DbSet<GameEventCreature> GameEventCreatures { get; set; }
    public virtual DbSet<GameEventCreatureData> GameEventCreatureDatas { get; set; }
    public virtual DbSet<GameEventGameobject> GameEventGameobjects { get; set; }
    public virtual DbSet<GameEventMail> GameEventMails { get; set; }
    public virtual DbSet<GameEventQuest> GameEventQuests { get; set; }
    public virtual DbSet<GameEventTime> GameEventTimes { get; set; }
    public virtual DbSet<GameGraveyardZone> GameGraveyardZones { get; set; }
    public virtual DbSet<GameTele> GameTeles { get; set; }
    public virtual DbSet<GameWeather> GameWeathers { get; set; }
    public virtual DbSet<Gameobject> Gameobjects { get; set; }
    public virtual DbSet<GameobjectAddon> GameobjectAddons { get; set; }
    public virtual DbSet<GameobjectBattleground> GameobjectBattlegrounds { get; set; }
    public virtual DbSet<GameobjectInvolvedrelation> GameobjectInvolvedrelations { get; set; }
    public virtual DbSet<GameobjectLootTemplate> GameobjectLootTemplates { get; set; }
    public virtual DbSet<GameobjectQuestrelation> GameobjectQuestrelations { get; set; }
    public virtual DbSet<GameobjectSpawnEntry> GameobjectSpawnEntrys { get; set; }
    public virtual DbSet<GameobjectTemplate> GameobjectTemplates { get; set; }
    public virtual DbSet<GossipMenu> GossipMenus { get; set; }
    public virtual DbSet<GossipMenuOption> GossipMenuOptions { get; set; }
    public virtual DbSet<GossipTexts> GossipTextss { get; set; }
    public virtual DbSet<InstanceDungeonEncounters> InstanceDungeonEncounterss { get; set; }
    public virtual DbSet<InstanceEncounters> InstanceEncounterss { get; set; }
    public virtual DbSet<InstanceTemplate> InstanceTemplates { get; set; }
    public virtual DbSet<ItemConvert> ItemConverts { get; set; }
    public virtual DbSet<ItemEnchantmentTemplate> ItemEnchantmentTemplates { get; set; }
    public virtual DbSet<ItemExpireConvert> ItemExpireConverts { get; set; }
    public virtual DbSet<ItemLootTemplate> ItemLootTemplates { get; set; }
    public virtual DbSet<ItemRequiredTarget> ItemRequiredTargets { get; set; }
    public virtual DbSet<ItemTemplate> ItemTemplates { get; set; }
    public virtual DbSet<LocalesAreatriggerTeleport> LocalesAreatriggerTeleports { get; set; }
    public virtual DbSet<LocalesCreature> LocalesCreatures { get; set; }
    public virtual DbSet<LocalesGameobject> LocalesGameobjects { get; set; }
    public virtual DbSet<LocalesGossipMenuOption> LocalesGossipMenuOptions { get; set; }
    public virtual DbSet<LocalesItem> LocalesItems { get; set; }
    public virtual DbSet<LocalesNpcText> LocalesNpcTexts { get; set; }
    public virtual DbSet<LocalesPageText> LocalesPageTexts { get; set; }
    public virtual DbSet<LocalesPointsOfInterest> LocalesPointsOfInterests { get; set; }
    public virtual DbSet<LocalesQuest> LocalesQuests { get; set; }
    public virtual DbSet<LocalesQuestgiverGreeting> LocalesQuestgiverGreetings { get; set; }
    public virtual DbSet<LocalesTrainerGreeting> LocalesTrainerGreetings { get; set; }
    public virtual DbSet<MailLevelReward> MailLevelRewards { get; set; }
    public virtual DbSet<MailLootTemplate> MailLootTemplates { get; set; }
    public virtual DbSet<MangosString> MangosStrings { get; set; }
    public virtual DbSet<NpcGossip> NpcGossips { get; set; }
    public virtual DbSet<NpcSpellclickSpells> NpcSpellclickSpellss { get; set; }
    public virtual DbSet<NpcText> NpcTexts { get; set; }
    public virtual DbSet<NpcTextBroadcastText> NpcTextBroadcastTexts { get; set; }
    public virtual DbSet<NpcTrainer> NpcTrainers { get; set; }
    public virtual DbSet<NpcTrainerTemplate> NpcTrainerTemplates { get; set; }
    public virtual DbSet<NpcVendor> NpcVendors { get; set; }
    public virtual DbSet<NpcVendorTemplate> NpcVendorTemplates { get; set; }
    public virtual DbSet<PageText> PageTexts { get; set; }
    public virtual DbSet<PetFamilystats> PetFamilystatss { get; set; }
    public virtual DbSet<PetLevelstats> PetLevelstatss { get; set; }
    public virtual DbSet<PetLevelstatsCopy> PetLevelstatsCopys { get; set; }
    public virtual DbSet<PetNameGeneration> PetNameGenerations { get; set; }
    public virtual DbSet<PetcreateinfoSpell> PetcreateinfoSpells { get; set; }
    public virtual DbSet<PickpocketingLootTemplate> PickpocketingLootTemplates { get; set; }
    public virtual DbSet<PlayerClasslevelstats> PlayerClasslevelstatss { get; set; }
    public virtual DbSet<PlayerLevelstats> PlayerLevelstatss { get; set; }
    public virtual DbSet<PlayerXpForLevel> PlayerXpForLevels { get; set; }
    public virtual DbSet<Playercreateinfo> Playercreateinfos { get; set; }
    public virtual DbSet<PlayercreateinfoAction> PlayercreateinfoActions { get; set; }
    public virtual DbSet<PlayercreateinfoItem> PlayercreateinfoItems { get; set; }
    public virtual DbSet<PlayercreateinfoSkills> PlayercreateinfoSkillss { get; set; }
    public virtual DbSet<PlayercreateinfoSpell> PlayercreateinfoSpells { get; set; }
    public virtual DbSet<PointsOfInterest> PointsOfInterests { get; set; }
    public virtual DbSet<PoolCreature> PoolCreatures { get; set; }
    public virtual DbSet<PoolCreatureTemplate> PoolCreatureTemplates { get; set; }
    public virtual DbSet<PoolGameobject> PoolGameobjects { get; set; }
    public virtual DbSet<PoolGameobjectTemplate> PoolGameobjectTemplates { get; set; }
    public virtual DbSet<PoolPool> PoolPools { get; set; }
    public virtual DbSet<PoolTemplate> PoolTemplates { get; set; }
    public virtual DbSet<ProspectingLootTemplate> ProspectingLootTemplates { get; set; }
    public virtual DbSet<QuestPoi> QuestPois { get; set; }
    public virtual DbSet<QuestPoiPoints> QuestPoiPointss { get; set; }
    public virtual DbSet<QuestTemplate> QuestTemplates { get; set; }
    public virtual DbSet<QuestgiverGreeting> QuestgiverGreetings { get; set; }
    public virtual DbSet<ReferenceLootTemplate> ReferenceLootTemplates { get; set; }
    public virtual DbSet<ReferenceLootTemplateNames> ReferenceLootTemplateNamess { get; set; }
    public virtual DbSet<ReputationRewardRate> ReputationRewardRates { get; set; }
    public virtual DbSet<ReputationSpilloverTemplate> ReputationSpilloverTemplates { get; set; }
    public virtual DbSet<ReservedName> ReservedNames { get; set; }
    public virtual DbSet<ScriptTexts> ScriptTextss { get; set; }
    public virtual DbSet<ScriptWaypoint> ScriptWaypoints { get; set; }
    public virtual DbSet<ScriptedAreatrigger> ScriptedAreatriggers { get; set; }
    public virtual DbSet<ScriptedEventId> ScriptedEventIds { get; set; }
    public virtual DbSet<SkillDiscoveryTemplate> SkillDiscoveryTemplates { get; set; }
    public virtual DbSet<SkillExtraItemTemplate> SkillExtraItemTemplates { get; set; }
    public virtual DbSet<SkillFishingBaseLevel> SkillFishingBaseLevels { get; set; }
    public virtual DbSet<SkinningLootTemplate> SkinningLootTemplates { get; set; }
    public virtual DbSet<SpamRecords> SpamRecordss { get; set; }
    public virtual DbSet<SpawnGroup> SpawnGroups { get; set; }
    public virtual DbSet<SpawnGroupEntry> SpawnGroupEntrys { get; set; }
    public virtual DbSet<SpawnGroupFormation> SpawnGroupFormations { get; set; }
    public virtual DbSet<SpawnGroupLinkedGroup> SpawnGroupLinkedGroups { get; set; }
    public virtual DbSet<SpawnGroupSpawn> SpawnGroupSpawns { get; set; }
    public virtual DbSet<SpellAffect> SpellAffects { get; set; }
    public virtual DbSet<SpellArea> SpellAreas { get; set; }
    public virtual DbSet<SpellBonusData> SpellBonusDatas { get; set; }
    public virtual DbSet<SpellChain> SpellChains { get; set; }
    public virtual DbSet<SpellCone> SpellCones { get; set; }
    public virtual DbSet<SpellElixir> SpellElixirs { get; set; }
    public virtual DbSet<SpellFacing> SpellFacings { get; set; }
    public virtual DbSet<SpellLearnSpell> SpellLearnSpells { get; set; }
    public virtual DbSet<SpellLootTemplate> SpellLootTemplates { get; set; }
    public virtual DbSet<SpellPetAuras> SpellPetAurass { get; set; }
    public virtual DbSet<SpellProcEvent> SpellProcEvents { get; set; }
    public virtual DbSet<SpellProcItemEnchant> SpellProcItemEnchants { get; set; }
    public virtual DbSet<SpellScriptTarget> SpellScriptTargets { get; set; }
    public virtual DbSet<SpellScripts> SpellScriptss { get; set; }
    public virtual DbSet<SpellTargetPosition> SpellTargetPositions { get; set; }
    public virtual DbSet<SpellTemplate> SpellTemplates { get; set; }
    public virtual DbSet<SpellThreat> SpellThreats { get; set; }
    public virtual DbSet<TaxiShortcuts> TaxiShortcutss { get; set; }
    public virtual DbSet<TrainerGreeting> TrainerGreetings { get; set; }
    public virtual DbSet<Transports> Transportss { get; set; }
    public virtual DbSet<VehicleAccessory> VehicleAccessorys { get; set; }
    public virtual DbSet<WardenScans> WardenScanss { get; set; }
    public virtual DbSet<WaypointPath> WaypointPaths { get; set; }
    public virtual DbSet<WorldSafeLocs> WorldSafeLocss { get; set; }
    public virtual DbSet<WorldTemplate> WorldTemplates { get; set; }
}