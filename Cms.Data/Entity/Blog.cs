﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Entity
{
  public class Blog: BaseEntity.BaseEntity
  {
    [Required(ErrorMessage = "{0} boş geçilemez")]
    [ForeignKey("AppUser")]
    public int AppUserId { get; set; }

    [Required(ErrorMessage = "{0} boş geçilemez")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "{0} alanı en az {2} en fazla {1} karakter olabilir")]
    [DisplayName("Başlık")]
    public string Title { get; set; }

    [Required(ErrorMessage = "{0} boş geçilemez")]
    [DisplayName("İçerik")]
    public string Content { get; set; }
    public string Tag { get; set; }

    public ICollection<DepartmentBlog> DepartmentBlogs { get; set; }
    public ICollection<BlogImage> BlogImages { get; set; }
    public ICollection<BlogComment> BlogComments { get; set; }
  }
}
