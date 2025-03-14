using Microsoft.EntityFrameworkCore;

namespace Mission10_Harrison.Data;

public class BowlerLeagueContext : DbContext
{
    public BowlerLeagueContext(DbContextOptions<BowlerLeagueContext> options) : base(options)
    {
        
    }
    public DbSet<Bowler> Bowlers { get; set; }
    public DbSet<Team> Teams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "BowlingLeague.sqlite");
        optionsBuilder.UseSqlite($"Data Source = {path}");
    }
}