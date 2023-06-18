using PMFrameworks.Models;

namespace PMFrameworks.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.UseSerialColumns();
    // }
    
    public DbSet<User> Users => Set<User>();
}