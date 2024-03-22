using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
  public class DoctorPatient: BaseEntity.BaseEntity
  {
    public string DoctorId { get; set; }
    public Doctor Doctor { get; set; }

    public string PatientId { get; set; }
    public Patient Patient { get; set; }
  }
}
