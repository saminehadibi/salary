using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Localization;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adibi.Salareis.Dtos
{
    [AutoMapTo(typeof(Salary))]
    public class SalaryInputDto:AuditedEntityDto,ICustomValidate
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

            if (Year < 1401 || Year > 1500) 
            context.Results.Add(new ValidationResult("yearoutofRange"));

            if (Month < 1 || Month > 12) 
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
