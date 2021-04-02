using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using mosquebookapi.Data.Repositories.Implementation;
using mosquebookapi.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddDbContextPool<ApplicationContext>(
                options => {
                    options.UseLazyLoadingProxies();
                    var mySqlConnectionStr = configuration.GetConnectionString("MosqueBookDB");
                    options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr));
                }
            );
            services.AddScoped<IUnitOfWork,UnitOfWork>()
            .AddScoped<IAppointmentRepository, AppointmentRepository>()
            .AddScoped<IUserRepository, UserRepository>()
            .AddScoped<IMosqueRepository, MosqueRepository>()
            .AddScoped<IEventRepository, EventRepository>()
            .AddScoped<IEventTypeRepository, EventTypeRepository>()
            .AddScoped<IEventGroupRepository, EventGroupRepository>();
            return services;
        }
    }
}
