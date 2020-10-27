using Microsoft.EntityFrameworkCore;

public class AquaBackendContext : DbContext
{
    public AquaBackendContext(DbContextOptions<AquaBackendContext> options)
        : base(options)
    {
    }

    public DbSet<AquaBackend.Models.Portfolio> Portfolio { get; set; }

    public DbSet<AquaBackend.Models.File> File { get; set; }

    public DbSet<AquaBackend.Models.Reports> ApxReports { get; set; }

    public DbSet<AquaBackend.Models.Transaction> Transaction { get; set; }

    public DbSet<AquaBackend.Models.Client> Client { get; set; }

    public DbSet<AquaBackend.Models.MarketSummary> MarketSummary { get; set; }

    public DbSet<AquaBackend.Models.Price> Price { get; set; }
}
