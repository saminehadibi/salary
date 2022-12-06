using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Runtime.Validation;
using System.ComponentModel.DataAnnotations;

namespace Adibi.Salareis.Dtos
{
    [AutoMapFrom(typeof(Salary))]
    public class SalaryOutputDto: AuditedEntityDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual decimal BasicSalary { get; set; }
        public virtual decimal Allowance { get; set; }
        public virtual decimal Transportation { get; set; }
        public virtual decimal Tax { get; set; }
        public virtual decimal Receipt { get; set; }
        public virtual decimal Overtime { get; set; }
        public virtual short Year { get; set; }
        public virtual short Month { get; set; }

        public void AddValidationErrors(CustomValidationContext context)
        {

            if (Year < 1401 || Year > 1500) { }
            context.Results.Add(new ValidationResult("yearoutofRange"));

            if (Month < 1 || Year > 12) { }
            context.Results.Add(new ValidationResult("MonthoutofRange"));

            if (BasicSalary < 1)
                context.Results.Add(new ValidationResult("Please enter BasicSalary"));

            if (Allowance < 1)
                context.Results.Add(new ValidationResult("Please enter Allowance"));

            if (Transportation < 1)
                context.Results.Add(new ValidationResult("Please enter Transportation"));

        }

    }
}
