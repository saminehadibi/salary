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
        public virtual decimal Attraction { get; set; }
        public virtual decimal Transportation { get; set; }
        public virtual decimal Tax { get; set; }
        public virtual decimal Receipt { get; set; }
        public virtual short Year { get; set; }
        public virtual short Month { get; set; }

        public void AddValidationErrors(CustomValidationContext context)
        {

            if (Year <= 1400 || Year > 1500) { }
                //context.Results.Add(new ValidationResult(LocalizationHelper.GetString(ShareHoldersConsts.LocalizationSourceName, "yearoutofRange")));
        }
        }
}
