namespace Cms.Data.Entity
{
  public class Surgery : BaseEntity.BaseEntity
  {
    //[ForeignKey(nameof(Patient.Id))]
    public string PatientId { get; set; }
    public Patient Patient { get; set; }

    //[ForeignKey(nameof(Department.Id))]
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

    //[ForeignKey(nameof(Doctor.Id))]
    public string DoctorId { get; set; }
    public ICollection<Doctor> Doctors { get; set; }
    public DateTime SurgeryDate { get; set; }
  }
}
