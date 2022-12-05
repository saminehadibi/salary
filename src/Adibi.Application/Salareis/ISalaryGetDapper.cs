using Abp.Application.Services;
using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adibi.Salareis
{
  public  interface ISalaryGetDapper: IApplicationService, ITransientDependency
    {
        List<Salary> GetperMounth(int getyear, int getmonth);
        List<Salary> GetRange(DateTime firstDate, DateTime lastDate);
    }
}
