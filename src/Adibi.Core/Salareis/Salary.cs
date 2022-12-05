using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adibi.Salareis
{
  public  class Salary: AuditedEntity
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Column(TypeName = "decimal(28, 6)")]
        public virtual decimal BasicSalary { get; set; }//حقوق پایه
        [Column(TypeName = "decimal(28, 6)")]
        public virtual decimal Attraction { get; set; }//حق جذب
        [Column(TypeName = "decimal(28, 6)")]
        public virtual decimal Transportation { get; set; }//ایاب و ذهاب
        [Column(TypeName = "decimal(28, 6)")]
        public virtual decimal Tax { get; set; }//مالیات
        [Column(TypeName = "decimal(28, 6)")]
        public virtual decimal Receipt { get; set; }//دریافتی
        public virtual short Year { get; set; }
        public virtual short Month { get; set; }
    }
}
