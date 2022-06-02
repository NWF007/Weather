using Microsoft.EntityFrameworkCore;

namespace CloudWeather.Precipitation.DataAccess
{
    public class PrecipDbContext : DbContext
    {
        public PrecipDbContext()
        {

        }

        public PrecipDbContext(DbContextOptions opts) : base(opts)
        {

        }

        public DbSet<Percipitation> Percipitations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SnakeCaseIdentityTableNames(modelBuilder);
        }

        private void SnakeCaseIdentityTableNames(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Percipitation>(b => { b.ToTable("percipitation"); });
        }
    }
}
