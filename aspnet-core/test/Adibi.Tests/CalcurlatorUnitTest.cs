using Adibi.Salareis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Adibi.Tests
{
  public  class CalcurlatorUnitTest
    {
        [Fact]
        public void  CalcurlatorA()
        {
            OvetimePolicies op = new OvetimePolicies();
             var actual = op.CalcurlatorA(150000000 , 10);
            Assert.Equal(expected: 10937500, actual);
        }
    }
}
