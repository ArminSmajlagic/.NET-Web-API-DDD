namespace Infrastructure.Database
{
    public interface IDatabaseContext : IDisposable
    {
        //DbEntityEntry Entry(object entity);
        //DbSet<T> Set<T>() where T : class;
        //DbSet Set(System.Type entityType);
        int SaveChanges();

        Task<int> SaveChangesAsync();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}