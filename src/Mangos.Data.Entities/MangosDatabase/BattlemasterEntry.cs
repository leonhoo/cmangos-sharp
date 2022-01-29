﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Mangos.Data.Entities.MangosDatabase;

[Table("battlemaster_entry")]
public class BattlemasterEntry
{
    /* Entry of a creature */
    [Column("entry", TypeName="mediumint")]
    public virtual uint Entry { get; set; }

    /* Battleground template id */
    [Column("bg_template", TypeName="mediumint")]
    public virtual uint BgTemplate { get; set; }

}