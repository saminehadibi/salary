using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adibi.Salareis.Dtos
{

    public  class MultiSalaryDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BasicSalary { get; set; }
        public int Allowance { get; set; }
    }
}
