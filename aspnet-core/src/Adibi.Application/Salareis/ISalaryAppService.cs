using Abp.Application.Services;
using Adibi.Salareis.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adibi.Salareis
{
  public  interface ISalaryAppService: IAsyncCrudAppService<SalaryOutputDto,
                                                      int,
                                                      GetAllSalaryFilterDto,
                                                      SalaryInputDto,
                                                      SalaryInputDto>
    {
    }
}
