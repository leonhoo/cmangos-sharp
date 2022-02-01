﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Mangos.Data.Entities.MangosDatabase;

[Table("spell_loot_template")]
public class SpellLootTemplate
{
    [Column("ChanceOrQuestChance", TypeName="float")]
    public virtual float ChanceOrQuestChance { get; set; }

    [Column("condition_id", TypeName="mediumint")]
    public virtual uint ConditionId { get; set; }

    [Column("entry", TypeName="mediumint")]
    public virtual uint Entry { get; set; }

    [Column("groupid", TypeName="tinyint")]
    public virtual byte Groupid { get; set; }

    [Column("item", TypeName="mediumint")]
    public virtual uint Item { get; set; }

    [Column("maxcount", TypeName="tinyint")]
    public virtual byte Maxcount { get; set; }

    [Column("mincountOrRef", TypeName="mediumint")]
    public virtual int MincountOrRef { get; set; }

}