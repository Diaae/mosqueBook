using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using mosquebookapi.Data;
using mosquebookapi.Data.Repositories;
using mosquebookapi.Data.Repositories.Abstraction;
using mosquebookapi.Data.Repositories.Implementation;
using mosquebookapi.Services;
using mosquebookapi.Services.Abstraction;
using mosquebookapi.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace mosquebookapi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddJsonOptions(
                configure=>configure.JsonSerializerOptions.PropertyNameCaseInsensitive = true
            );
            
            var mySqlConnectionStr = Configuration.GetConnectionString("MosqueBookDB");
            services.AddDbContextPool<MosqueBookContext>(
                options => options.UseLazyLoadingProxies().UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr))
            );
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IAppointmentRepository, AppointmentRepository>()
            .AddScoped<IUserRepository, UserRepository>()
            .AddScoped<IMosqueRepository, MosqueRepository>()
            .AddScoped<IEventRepository, EventRepository>()
            .AddScoped<IEventTypeRepository, EventTypeRepository>()
            .AddScoped<IEventGroupRepository, EventGroupRepository>()
            .AddScoped<IAppointmentManager, AppointmentManager>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env )
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("*");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}/{id?}"
                    );
            });
        }
    }
}