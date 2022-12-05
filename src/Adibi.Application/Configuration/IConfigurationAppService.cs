using System.Threading.Tasks;
using Adibi.Configuration.Dto;

namespace Adibi.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
