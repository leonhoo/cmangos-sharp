﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Mangos.Data.Entities.MangosDatabase;

[Table("questgiver_greeting")]
public class QuestgiverGreeting
{
    /* Emote delay of the greeting */
    [Column("EmoteDelay", TypeName="int")]
    public virtual uint EmoteDelay { get; set; }

    /* Emote ID of greeting */
    [Column("EmoteId", TypeName="int")]
    public virtual uint EmoteId { get; set; }

    /* Entry of Questgiver */
    [Column("Entry", TypeName="int")]
    public virtual uint Entry { get; set; }

    /* Text of the greeting */
    [Column("Text", TypeName="longtext")]
    public virtual string Text { get; set; }

    /* Type of entry */
    [Column("Type", TypeName="int")]
    public virtual uint Type { get; set; }

}