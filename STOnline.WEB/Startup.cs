using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using STOnline.DAL.DBContext;
using STOnline.DAL.Infrastructure;
using STOnline.DAL.Interfaces;
using STOnline.DAL.Interfaces.EntityInterfaces.SQLInterfaces.ISQLServices;
using STOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using STOnline.DAL.Services.SQLServices;
using STOnline.DAL.UnitOfWork;
using STOnline.Repositoryes;
using Microsoft.EntityFrameworkCore;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;
using STOnline.DAL.Repositoryes.Repositoryes;
using STOnline.DAL.Interfaces.Interfaces.IServices;
using STOnline.DAL.Services.Services;

namespace STOnline.WEB
{
    public class Startup
    {
        private IConfigurationRoot _confString;
        public Startup(IHostEnvironment hostEnvironment)
        {
           _confString = new ConfigurationBuilder().SetBasePath(hostEnvironment.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IConnectionFactory, ConnectionFactory>();
            services.AddDbContext<ApplicationContext>(options => options
                    .UseSqlServer(_confString.GetConnectionString("DefaultConnection")
              ));
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IClientService, ClientService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
