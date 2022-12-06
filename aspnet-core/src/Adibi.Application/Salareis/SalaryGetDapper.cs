using Abp.AutoMapper;
using Abp.Dapper.Repositories;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Web.Models;
using Adibi.Salareis.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adibi.Salareis
{
    public class SalaryGetDapper : ISalaryGetDapper
    {
        private readonly IDapperRepository<Salary> _salaryDapperRepository;
        private readonly IRepository<Salary, int> _salaryRepository;
        public SalaryGetDapper(IRepository<Salary, int> salaryRepository,
                               IDapperRepository<Salary> salaryDapperRepository)
        {
            _salaryDapperRepository = salaryDapperRepository;
            _salaryRepository = salaryRepository;
        }

        public List<Salary> GetperMounth(int getyear, int getmonth)
        {

            var salaryList = _salaryDapperRepository.Query("SELECT  * FROM  dbo.Salareis WHERE (Year = @year) AND (Month =@month)"
                                                      , new { year = getyear, month = getmonth }).ToList<Salary>();
            return salaryList;
        }
        public List<Salary> GetRange(DateTime firstDate, DateTime lastDate)
        {
            var salaryList = _salaryDapperRepository.Query("SELECT  * FROM  dbo.Salareis WHERE  (CreationTime BETWEEN @fromdate AND @toDate)"
                                                     , new { fromdate = firstDate, toDate = lastDate }).ToList<Salary>();
            return salaryList;
        }
        [HttpPost]
       
        [Produces("text/xml")]
        [Consumes("text/xml")]
        //[Consumes("application/xml")]
        //[Consumes("multipart/form-data")]
        //[DontWrapResult]
        //[FromForm]
        public int create (MultiSalaryDto input)
        {
            var b = input;
            return 1;
        }

        [HttpPost]
        [Produces("text/xml")]
        public int Post([FromBody] MultiSalaryDto value)
        {
            value.FirstName = $"From Post {value.FirstName}";
            return 1;
        }

    }
}
