﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mangos.Data.Entities.MangosDatabase;

[Table("playercreateinfo_spell")]
public class PlayerCreateInfoSpell
{
    [Column("race", TypeName="tinyint")]
    public virtual byte Race { get; set; }

    [Column("class", TypeName="tinyint")]
    public virtual byte Class { get; set; }

    [Column("Spell", TypeName="mediumint")]
    public virtual uint Spell { get; set; }

    [Column("Note")]
    [MaxLength(255)]
    public virtual string Note { get; set; }

}