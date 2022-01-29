﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mangos.Data.Entities.MangosDatabase;

[Table("dbscript_random_templates")]
public class DbScriptRandomTemplate
{
    /* Id of template */
    [Column("id", TypeName="int")]
    public virtual uint Id { get; set; }

    /* Type of template */
    [Column("type", TypeName="int")]
    public virtual uint Type { get; set; }

    /* Id of chanced element */
    [Column("target_id", TypeName="int")]
    public virtual int TargetId { get; set; }

    /* Chance for element to occur in % */
    [Column("chance", TypeName="int")]
    public virtual int Chance { get; set; }

    [Column("comments", TypeName="varchar")]
    [MaxLength(500)]
    public virtual string Comments { get; set; }

}