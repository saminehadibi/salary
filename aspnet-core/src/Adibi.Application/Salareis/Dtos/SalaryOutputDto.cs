using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adibi.Salareis.Dtos
{
    [AutoMapFrom(typeof(Salary))]
    public class SalaryOutputDto: AuditedEntityDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual decimal BasicSalary { get; set; }
        public virtual decimal Attraction { get; set; }
        public virtual decimal Transportation { get; set; }
        public virtual decimal Tax { get; set; }
        public virtual decimal Receipt { get; set; }
        public virtual short Year { get; set; }
        public virtual short Month { get; set; }

    }
}
