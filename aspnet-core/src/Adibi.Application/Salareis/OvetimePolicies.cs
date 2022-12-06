using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adibi.Salareis
{
  public  class OvetimePolicies
    {
        
        public decimal CalcurlatorA(decimal basicSalary,decimal overtime)
        {
            //اضافه کار بر اساس 192 ساعت در ماه
            var factor = Convert.ToDecimal(1.4);
            return  (basicSalary / 192)* factor * overtime;
            
        }
        public int CalcurlatorB()
        {
            return 1;
        }
        public int CalcurlatorC()
        {
            return 1;
        }
    }
}
