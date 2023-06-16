using empresa.webapi.Areas.Implementation;
using empresa.webapi.Areas.Interface;

namespace empresa.webapi.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void Config(IServiceCollection services)
        {
            services.AddTransient<IEmpresaApplication, EmpresaApplication>();
        }
    }
}
