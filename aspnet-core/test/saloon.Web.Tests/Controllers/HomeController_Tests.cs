using System.Threading.Tasks;
using saloon.Models.TokenAuth;
using saloon.Web.Controllers;
using Shouldly;
using Xunit;

namespace saloon.Web.Tests.Controllers
{
    public class HomeController_Tests: saloonWebTestBase
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