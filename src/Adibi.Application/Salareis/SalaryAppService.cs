using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Dapper.Repositories;
using Abp.Domain.Repositories;
using Adibi.Salareis.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adibi.Salareis
{
    public class SalaryAppService : AsyncCrudAppService<Salary,
                                                        SalaryOutputDto,
                                                        int,
                                                        GetAllSalaryFilterDto,
                                                        SalaryInputDto,
                                                        SalaryInputDto>, ISalaryAppService
    {
        private readonly IRepository<Salary, int> _salaryRepository;
        public  SalaryAppService(IRepository<Salary> salaryRepository) : base(salaryRepository)
        {
            _salaryRepository = salaryRepository;
        }

        public override Task<SalaryOutputDto> CreateAsync(SalaryInputDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<SalaryOutputDto> UpdateAsync(SalaryInputDto input)
        {
            return base.UpdateAsync(input);
        }
     
    }
}
