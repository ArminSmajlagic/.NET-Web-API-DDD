using Domain.Models;
using Domain.Models.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Database
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        private readonly IConfiguration configuration;

        public DatabaseContext(IConfiguration configuration) : base()
        {
            this.configuration = configuration;
        }

        public DbSet<Account> accounts { get; set; }
        public DbSet<Loan> loans { get; set; }
        public DbSet<Transfer> transfers { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                foreach (var entry in ChangeTracker.Entries<BaseEntity>())
                {
                    switch (entry.State)
                    {
                        case EntityState.Detached:
                            break;

                        case EntityState.Unchanged:
                            break;

                        case EntityState.Deleted:
                            break;

                        case EntityState.Modified:
                            entry.Entity.UpdatedAt = DateTime.Now;
                            break;

                        case EntityState.Added:
                            entry.Entity.CreatedAt = DateTime.Now;
                            break;

                        default:
                            break;
                    }
                }

                return await base.SaveChangesAsync(cancellationToken);
            }

            return 0;
        }

        public async Task<int> SaveChangesAsync()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Detached:
                        break;

                    case EntityState.Unchanged:
                        break;

                    case EntityState.Deleted:
                        break;

                    case EntityState.Modified:
                        entry.Entity.UpdatedAt = DateTime.Now;
                        break;

                    case EntityState.Added:
                        entry.Entity.CreatedAt = DateTime.Now;
                        break;

                    default:
                        break;
                }
            }

            return await base.SaveChangesAsync();
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Detached:
                        break;

                    case EntityState.Unchanged:
                        break;

                    case EntityState.Deleted:
                        break;

                    case EntityState.Modified:
                        entry.Entity.CreatedAt = DateTime.Now;
                        break;

                    case EntityState.Added:
                        entry.Entity.CreatedAt = DateTime.Now;
                        break;

                    default:
                        break;
                }
            }

            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = configuration.GetConnectionString("MSSQL")!;

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString, x =>
                {
                    x.EnableRetryOnFailure();
                });
            }
        }
    }
}