using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Cms.Data.Entity
{
  public class Admin : BaseEntity.BaseEntity
  {
    [Required(ErrorMessage = "{0} boş geçilemez")]
    [StringLength(200, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir")]
    [DisplayName("İsim")]
    public string Name { get; set; }

    [Required(ErrorMessage = "{0} boş geçilemez")]
    [StringLength(200, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir")]
    [DisplayName("Soyad")]
    public string Surname { get; set; }

    public int RoleId { get; set; }

    public int Password { get; set; }
    [Required(ErrorMessage = "{0} boş geçilemez")]
    [StringLength(400, ErrorMessage = "{0} alanı en fazla {1} karakter olabilir")]
    [DisplayName("Değer")]
    public string Value { get; set; }

  }
}
