using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Adibi.Configuration.Dto;

namespace Adibi.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AdibiAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
