using Microsoft.EntityFrameworkCore;

public class AquaBackendContext : DbContext
{
    public AquaBackendContext(DbContextOptions<AquaBackendContext> options)
        : base(options)
    {
    }

    public DbSet<AquaBackend.Models.Portfolio> Portfolio { get; set; }

    public DbSet<AquaBackend.Models.File> File { get; set; }

    public DbSet<AquaBackend.Models.ApxReports> ApxReports { get; set; }
}
