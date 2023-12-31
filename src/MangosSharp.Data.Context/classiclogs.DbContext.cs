/* THIS FILE IS AUTOMATICALLY GENERATED */
using MangosSharp.Data.Entities.LogsDatabase;
using Microsoft.EntityFrameworkCore;
// ReSharper disable All
namespace MangosSharp.Data.Context;
public sealed class ClassiclogsDbContext : DbContext
{
    public ClassiclogsDbContext() { }
    public ClassiclogsDbContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<LogsAnticheat>().HasKey(e => new { e.Id });
        builder.Entity<LogsAnticheat>().ToTable("logs_anticheat");
        builder.Entity<LogsSpamdetect>().HasKey(e => new { e.Id });
        builder.Entity<LogsSpamdetect>().ToTable("logs_spamdetect");
        builder.Entity<LogsAnticheat>().Property(e => e.Account).HasColumnName("account");
        builder.Entity<LogsAnticheat>().Property(e => e.Account).HasColumnType("int unsigned");
        builder.Entity<LogsAnticheat>().Property(e => e.ActionMask).HasColumnName("actionMask");
        builder.Entity<LogsAnticheat>().Property(e => e.ActionMask).HasColumnType("int unsigned");
        builder.Entity<LogsAnticheat>().Property(e => e.Fingerprint).HasColumnName("fingerprint");
        builder.Entity<LogsAnticheat>().Property(e => e.Fingerprint).HasColumnType("int unsigned");
        builder.Entity<LogsAnticheat>().Property(e => e.Id).HasColumnName("id");
        builder.Entity<LogsAnticheat>().Property(e => e.Id).HasColumnType("int unsigned");
        builder.Entity<LogsAnticheat>().Property(e => e.Info).HasColumnName("info");
        builder.Entity<LogsAnticheat>().Property(e => e.Info).HasColumnType("varchar(512)");
        builder.Entity<LogsAnticheat>().Property(e => e.Info).HasMaxLength(512);
        builder.Entity<LogsAnticheat>().Property(e => e.Ip).HasColumnName("ip");
        builder.Entity<LogsAnticheat>().Property(e => e.Ip).HasColumnType("varchar(16)");
        builder.Entity<LogsAnticheat>().Property(e => e.Ip).HasMaxLength(16);
        builder.Entity<LogsAnticheat>().Property(e => e.Player).HasColumnName("player");
        builder.Entity<LogsAnticheat>().Property(e => e.Player).HasColumnType("varchar(32)");
        builder.Entity<LogsAnticheat>().Property(e => e.Player).HasMaxLength(32);
        builder.Entity<LogsAnticheat>().Property(e => e.Realm).HasColumnName("realm");
        builder.Entity<LogsAnticheat>().Property(e => e.Realm).HasColumnType("int unsigned");
        builder.Entity<LogsAnticheat>().Property(e => e.Time).HasColumnName("time");
        builder.Entity<LogsAnticheat>().Property(e => e.Time).HasColumnType("datetime");
        builder.Entity<LogsSpamdetect>().Property(e => e.AccountId).HasColumnName("accountId");
        builder.Entity<LogsSpamdetect>().Property(e => e.AccountId).HasColumnType("int");
        builder.Entity<LogsSpamdetect>().Property(e => e.Comment).HasColumnName("comment");
        builder.Entity<LogsSpamdetect>().Property(e => e.Comment).HasColumnType("varchar(8192)");
        builder.Entity<LogsSpamdetect>().Property(e => e.Comment).HasMaxLength(8192);
        builder.Entity<LogsSpamdetect>().Property(e => e.FromFingerprint).HasColumnName("fromFingerprint");
        builder.Entity<LogsSpamdetect>().Property(e => e.FromFingerprint).HasColumnType("int unsigned");
        builder.Entity<LogsSpamdetect>().Property(e => e.FromGuid).HasColumnName("fromGuid");
        builder.Entity<LogsSpamdetect>().Property(e => e.FromGuid).HasColumnType("bigint unsigned");
        builder.Entity<LogsSpamdetect>().Property(e => e.FromIP).HasColumnName("fromIP");
        builder.Entity<LogsSpamdetect>().Property(e => e.FromIP).HasColumnType("varchar(16)");
        builder.Entity<LogsSpamdetect>().Property(e => e.FromIP).HasMaxLength(16);
        builder.Entity<LogsSpamdetect>().Property(e => e.Id).HasColumnName("id");
        builder.Entity<LogsSpamdetect>().Property(e => e.Id).HasColumnType("int unsigned");
        builder.Entity<LogsSpamdetect>().Property(e => e.Realm).HasColumnName("realm");
        builder.Entity<LogsSpamdetect>().Property(e => e.Realm).HasColumnType("int unsigned");
        builder.Entity<LogsSpamdetect>().Property(e => e.Time).HasColumnName("time");
        builder.Entity<LogsSpamdetect>().Property(e => e.Time).HasColumnType("timestamp");
    }
    public DbSet<LogsAnticheat> LogsAnticheats { get; set; }
    public DbSet<LogsSpamdetect> LogsSpamdetects { get; set; }
}
