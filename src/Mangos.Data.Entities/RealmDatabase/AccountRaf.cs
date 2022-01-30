﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Mangos.Data.Entities.RealmDatabase;

[Table("account_raf")]
public class AccountRaf
{
    [Column("referrer", TypeName="int")]
    public virtual uint Referrer { get; set; }

    [Column("referred", TypeName="int")]
    public virtual uint Referred { get; set; }

}