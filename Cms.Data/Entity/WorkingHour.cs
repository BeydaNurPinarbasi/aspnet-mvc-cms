﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
  public class WorkingHour: BaseEntity.BaseEntity
  {
    [Key]
    public int WorkingHourId { get; set; }

    [Required]
    [ForeignKey("Doctor")]
    public string DoctorId { get; set; }

    public Doctor Doctor { get; set; }

    [Required]
    public DayOfWeek DayOfWeek { get; set; }

    [Required]
    public TimeSpan StartTime { get; set; }

    [Required]
    public TimeSpan EndTime { get; set; }


    public bool IsOffDay { get; set; } 
  }
}
