﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
  public class Education: BaseEntity.BaseEntity
  {
    public string Year { get; set; }

    public string University { get; set; }

    public string Explanation { get; set; }

    //[ForeignKey(nameof(Doctor.Id))]//calisiyor mu denemek lazim
    public string DoctorId { get; set; }
  }
}
