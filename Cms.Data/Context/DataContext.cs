using Microsoft.EntityFrameworkCore;

namespace Cms.Data.Context
{
  public class DataContext: DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    //public DbSet<User> User { get; set; }
  }
}
