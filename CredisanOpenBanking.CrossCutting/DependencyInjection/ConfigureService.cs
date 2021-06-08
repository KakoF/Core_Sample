using CredisanOpenBanking.Service.Interfaces;
using CredisanOpenBanking.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUsuarioService, UsuarioService>();
        }
    }
}