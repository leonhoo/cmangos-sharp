﻿using Mangos.Data.Entities.CharacterDatabase;
using Microsoft.EntityFrameworkCore;

namespace Mangos.Data.Context;

public class ClassiccharactersDbContext : DbContext
{
    public ClassiccharactersDbContext() {}
    public ClassiccharactersDbContext(DbContextOptions options) : base(options) {}
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<AccountInstancesEntered>().HasKey(e => new { e.AccountId, e.InstanceId });
        builder.Entity<AhbotItems>().HasKey(e => new { e.AddChance, e.Item });
        builder.Entity<Auction>().HasKey(e => new { e.Id });
        builder.Entity<Bugreport>().HasKey(e => new { e.Id });
        builder.Entity<CharacterAction>().HasKey(e => new { e.Action, e.Button, e.Guid });
        builder.Entity<CharacterAura>().HasKey(e => new { e.Basepoints0, e.CasterGuid, e.Guid, e.ItemGuid, e.Spell });
        builder.Entity<CharacterBattlegroundData>().HasKey(e => new { e.Guid });
        builder.Entity<CharacterGifts>().HasKey(e => new { e.Entry, e.ItemGuid });
        builder.Entity<CharacterHomebind>().HasKey(e => new { e.Guid });
        builder.Entity<CharacterHonorCp>().HasKey(e => new { e.Date });
        builder.Entity<CharacterInstance>().HasKey(e => new { e.Guid, e.Instance });
        builder.Entity<CharacterInventory>().HasKey(e => new { e.Bag, e.Item });
        builder.Entity<CharacterPet>().HasKey(e => new { e.Id });
        builder.Entity<CharacterQueststatus>().HasKey(e => new { e.Explored, e.Guid, e.Quest });
        builder.Entity<CharacterQueststatusWeekly>().HasKey(e => new { e.Guid, e.Quest });
        builder.Entity<CharacterReputation>().HasKey(e => new { e.Faction, e.Guid });
        builder.Entity<CharacterSkills>().HasKey(e => new { e.Guid, e.Skill });
        builder.Entity<CharacterSocial>().HasKey(e => new { e.Flags, e.Friend, e.Guid });
        builder.Entity<CharacterSpell>().HasKey(e => new { e.Active, e.Guid, e.Spell });
        builder.Entity<CharacterSpellCooldown>().HasKey(e => new { e.Category, e.Guid, e.SpellId });
        builder.Entity<CharacterStats>().HasKey(e => new { e.Agility, e.Guid });
        builder.Entity<CharacterTutorial>().HasKey(e => new { e.Account });
        builder.Entity<Characters>().HasKey(e => new { e.Account, e.Guid });
        builder.Entity<Corpse>().HasKey(e => new { e.CorpseType, e.Guid });
        builder.Entity<CreatureRespawn>().HasKey(e => new { e.Guid, e.Instance });
        builder.Entity<GameEventStatus>().HasKey(e => new { e.Event });
        builder.Entity<GameobjectRespawn>().HasKey(e => new { e.Guid, e.Instance });
        builder.Entity<GmSurveys>().HasKey(e => new { e.Answer1, e.Ticketid });
        builder.Entity<GmTickets>().HasKey(e => new { e.Id });
        builder.Entity<GroupInstance>().HasKey(e => new { e.Instance, e.LeaderGuid });
        builder.Entity<GroupMember>().HasKey(e => new { e.Assistant, e.GroupId, e.MemberGuid });
        builder.Entity<Groups>().HasKey(e => new { e.GroupId });
        builder.Entity<Guild>().HasKey(e => new { e.BackgroundColor, e.Guildid });
        builder.Entity<GuildEventlog>().HasKey(e => new { e.EventType, e.Guildid, e.LogGuid });
        builder.Entity<GuildMember>().HasKey(e => new { e.Guid });
        builder.Entity<GuildRank>().HasKey(e => new { e.Guildid, e.Rid });
        builder.Entity<Instance>().HasKey(e => new { e.Id });
        builder.Entity<InstanceReset>().HasKey(e => new { e.Mapid });
        builder.Entity<ItemInstance>().HasKey(e => new { e.Charges, e.Guid });
        builder.Entity<ItemLoot>().HasKey(e => new { e.Amount, e.Guid, e.Itemid });
        builder.Entity<ItemText>().HasKey(e => new { e.Id });
        builder.Entity<Mail>().HasKey(e => new { e.Id });
        builder.Entity<MailItems>().HasKey(e => new { e.ItemGuid, e.MailId });
        builder.Entity<PetAura>().HasKey(e => new { e.Basepoints0, e.CasterGuid, e.Guid, e.ItemGuid, e.Spell });
        builder.Entity<PetSpell>().HasKey(e => new { e.Active, e.Guid, e.Spell });
        builder.Entity<PetSpellCooldown>().HasKey(e => new { e.Guid, e.Spell });
        builder.Entity<Petition>().HasKey(e => new { e.Name, e.Ownerguid });
        builder.Entity<PetitionSign>().HasKey(e => new { e.Ownerguid, e.Petitionguid, e.Playerguid });
        builder.Entity<PlayerbotSavedData>().HasKey(e => new { e.CombatDelay, e.Guid });
        builder.Entity<PvpstatsBattlegrounds>().HasKey(e => new { e.Id });
        builder.Entity<PvpstatsPlayers>().HasKey(e => new { e.Attr1, e.BattlegroundId, e.CharacterGuid });
        builder.Entity<SavedVariables>().HasKey(e => new { e.CleaningFlags });
        builder.Entity<World>().HasKey(e => new { e.Data, e.Map });
        builder.Entity<WorldState>().HasKey(e => new { e.Id });
    }

    public virtual DbSet<AccountInstancesEntered> AccountInstancesEntereds { get; set; }
    public virtual DbSet<AhbotItems> AhbotItemss { get; set; }
    public virtual DbSet<Auction> Auctions { get; set; }
    public virtual DbSet<Bugreport> Bugreports { get; set; }
    public virtual DbSet<CharacterAction> CharacterActions { get; set; }
    public virtual DbSet<CharacterAura> CharacterAuras { get; set; }
    public virtual DbSet<CharacterBattlegroundData> CharacterBattlegroundDatas { get; set; }
    public virtual DbSet<CharacterGifts> CharacterGiftss { get; set; }
    public virtual DbSet<CharacterHomebind> CharacterHomebinds { get; set; }
    public virtual DbSet<CharacterHonorCp> CharacterHonorCps { get; set; }
    public virtual DbSet<CharacterInstance> CharacterInstances { get; set; }
    public virtual DbSet<CharacterInventory> CharacterInventorys { get; set; }
    public virtual DbSet<CharacterPet> CharacterPets { get; set; }
    public virtual DbSet<CharacterQueststatus> CharacterQueststatuss { get; set; }
    public virtual DbSet<CharacterQueststatusWeekly> CharacterQueststatusWeeklys { get; set; }
    public virtual DbSet<CharacterReputation> CharacterReputations { get; set; }
    public virtual DbSet<CharacterSkills> CharacterSkillss { get; set; }
    public virtual DbSet<CharacterSocial> CharacterSocials { get; set; }
    public virtual DbSet<CharacterSpell> CharacterSpells { get; set; }
    public virtual DbSet<CharacterSpellCooldown> CharacterSpellCooldowns { get; set; }
    public virtual DbSet<CharacterStats> CharacterStatss { get; set; }
    public virtual DbSet<CharacterTutorial> CharacterTutorials { get; set; }
    public virtual DbSet<Characters> Characterss { get; set; }
    public virtual DbSet<Corpse> Corpses { get; set; }
    public virtual DbSet<CreatureRespawn> CreatureRespawns { get; set; }
    public virtual DbSet<GameEventStatus> GameEventStatuss { get; set; }
    public virtual DbSet<GameobjectRespawn> GameobjectRespawns { get; set; }
    public virtual DbSet<GmSurveys> GmSurveyss { get; set; }
    public virtual DbSet<GmTickets> GmTicketss { get; set; }
    public virtual DbSet<GroupInstance> GroupInstances { get; set; }
    public virtual DbSet<GroupMember> GroupMembers { get; set; }
    public virtual DbSet<Groups> Groupss { get; set; }
    public virtual DbSet<Guild> Guilds { get; set; }
    public virtual DbSet<GuildEventlog> GuildEventlogs { get; set; }
    public virtual DbSet<GuildMember> GuildMembers { get; set; }
    public virtual DbSet<GuildRank> GuildRanks { get; set; }
    public virtual DbSet<Instance> Instances { get; set; }
    public virtual DbSet<InstanceReset> InstanceResets { get; set; }
    public virtual DbSet<ItemInstance> ItemInstances { get; set; }
    public virtual DbSet<ItemLoot> ItemLoots { get; set; }
    public virtual DbSet<ItemText> ItemTexts { get; set; }
    public virtual DbSet<Mail> Mails { get; set; }
    public virtual DbSet<MailItems> MailItemss { get; set; }
    public virtual DbSet<PetAura> PetAuras { get; set; }
    public virtual DbSet<PetSpell> PetSpells { get; set; }
    public virtual DbSet<PetSpellCooldown> PetSpellCooldowns { get; set; }
    public virtual DbSet<Petition> Petitions { get; set; }
    public virtual DbSet<PetitionSign> PetitionSigns { get; set; }
    public virtual DbSet<PlayerbotSavedData> PlayerbotSavedDatas { get; set; }
    public virtual DbSet<PvpstatsBattlegrounds> PvpstatsBattlegroundss { get; set; }
    public virtual DbSet<PvpstatsPlayers> PvpstatsPlayerss { get; set; }
    public virtual DbSet<SavedVariables> SavedVariabless { get; set; }
    public virtual DbSet<World> Worlds { get; set; }
    public virtual DbSet<WorldState> WorldStates { get; set; }
}
