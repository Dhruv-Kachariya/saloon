using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace saloon.Controllers
{
    public abstract class saloonControllerBase: AbpController
    {
        protected saloonControllerBase()
        {
            LocalizationSourceName = saloonConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
