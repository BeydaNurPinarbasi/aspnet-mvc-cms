﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
  public class Appointment :BaseEntity.BaseEntity
  
  {
		[ForeignKey("DepartmentId")]
    public int DepartmentId { get; set; }

    public Department Department { get; set; }

    [ForeignKey("DoctorId")]
    public string DoctorId { get; set; }

    public Doctor Doctor { get; set; }

    [ForeignKey("PatientId")]
    public string PatientId { get; set; }

    public Patient Patient { get; set; }

    public string Email { get; set; }

    public string FullName { get; set; }

    public string Phone { get; set; }

    public string Message { get; set; }

    [Required]
    public DateTime AppointmentDate { get; set; }

    [ForeignKey(nameof(AppointmentManager.AppointmentManagerId))]
    public int AppointmentManagerId { get; set; }
    public AppointmentManager AppointmentManeger { get; set; }




  }
}
