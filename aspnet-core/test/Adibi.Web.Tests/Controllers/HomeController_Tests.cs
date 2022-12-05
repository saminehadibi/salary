using System.Threading.Tasks;
using Adibi.Models.TokenAuth;
using Adibi.Web.Controllers;
using Shouldly;
using Xunit;

namespace Adibi.Web.Tests.Controllers
{
    public class HomeController_Tests: AdibiWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}