using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Adibi.Controllers
{
    public abstract class AdibiControllerBase: AbpController
    {
        protected AdibiControllerBase()
        {
            LocalizationSourceName = AdibiConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
