using Basic.Entity;
using Microsoft.EntityFrameworkCore;

namespace Basic.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }

    public DbSet<Game> Games { get; set; }
}
