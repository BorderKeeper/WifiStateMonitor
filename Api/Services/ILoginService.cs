using System.Threading.Tasks;
using WiFiStateMonitor.Api.Configuration.Entities;
using WiFiStateMonitor.Api.Services.Entities;

namespace WiFiStateMonitor.Api.Services
{
    public interface ILoginService
    {
        Task<LoginResult> Login(RestConfiguration configuration, string username, string password);
    }
}