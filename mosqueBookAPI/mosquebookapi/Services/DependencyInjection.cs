using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace mosquebookapi.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<MosqueService>();
            services.AddScoped<EventService>();
            services.AddScoped<EventTypeService>();
            services.AddScoped<EventGroupService>();
            return services;
        }
    }
}
