namespace Cms.Data.Entity
{
  public class Doctor : BaseEntity.BaseEntity
  {
    public string Speacialty { get; set; }

    public ICollection<DoctorPatient> DoctorPatients { get; set; }

    //[ForeignKey(nameof(Department.Id))]
    public int DepartmentId { get; set; }

    public Department Department { get; set; }

    //[ForeignKey(nameof(Role.Id))]
    public string RoleId { get; set; }
    public AppRole Role { get; set; }

    //[ForeignKey(nameof(Introduction.Id))]
    public int IntroductionId { get; set; }

    public Introduction Introduction { get; set; }
    public virtual ICollection<WorkingHour> WorkingHours { get; set; }
    public virtual ICollection<Appointment> Appointments { get; set; }

    public string DocFacebook { get; set; }
    public string DocX { get; set; }
    public string DocPinterest { get; set; }
    public string DocSkype { get; set; }
    public string DocLinkedIn { get; set; }

    public string DocTitle { get; set; }


  }
}
