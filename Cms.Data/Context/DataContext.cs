using Azure;
using Cms.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Cms.Data.Context
{
  public class DataContext: DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
   public DbSet<Blog>Blog{ get; set; }

   public DbSet <Department>Department { get; set; }

    public DbSet<Doctor>Doctor { get; set; }
    public DbSet<Patient>Patient { get; set; }

  }
}
