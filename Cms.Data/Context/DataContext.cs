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


    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<AppointmentManager> AppointmentManagers { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<DepartmentBlog> DepartmentBlogs { get; set; }
    public DbSet<DepartmentDetail> DepartmentDetails { get; set; }
    public DbSet<BlogImage> BlogImages { get; set; }
    public DbSet<BlogComment> BlogComments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<DoctorPatient> DoctorPatients { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Introduction> Introductions { get; set; }
    public DbSet<WorkingHour> WorkingHours { get; set; }
    public DbSet<Surgery> Surgeries { get; set; }
    public DbSet<SurgeryDoctor> SurgeryDoctors { get; set; }






  
    
   

  }
}
