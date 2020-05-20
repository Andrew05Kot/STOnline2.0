using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
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
using STOnline.DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using STOnline.BLL.Interfaces.IServices;
using STOnline.BLL.Services.Services;
using STOnline.DAL.Interfaces.Interfaces.IRepositories;
using STOnline.DAL.Repositoryes.Repositoryes;
using Microsoft.AspNetCore.Hosting;
//using STOnline.DAL.AppContexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using STOnline.DAL.Models;
using STOnline.DAL.Models.Entities;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.IdentityModel.Tokens;
//using STOnline.WEB.Options;

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
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IConnectionFactory, ConnectionFactory>();
            services.AddDbContext<ApplicationContext>(options => options
                    .UseSqlServer(_confString.GetConnectionString("DefaultConnection")
              ));
            services.AddIdentity<User, Role>(options =>
            {
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<ApplicationContext>();
            //services.AddDbContext<AuthContext>(options => options
            //        .UseSqlServer(_confString.GetConnectionString("DefaultConnection")
            //        ));
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IRepairRepository, RepairRepository>();
            services.AddTransient<IRepairService, RepairService>();
            services.AddTransient<IWorkerRepository, WorkerRepository>();
            services.AddTransient<IWorkerService, WorkerService>();
            services.AddTransient<IWorkerCategoryRepository, WorkerCategoryRepository>();
            services.AddTransient<IWorkerCategoryService, WorkerCategoryService>();
            //services.AddIdentity<IdentityUser, IdentityRole>()
            //        .AddEntityFrameworkStores<AuthContext>()
            //        .AddDefaultTokenProviders();
            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //    .AddCookie(options =>
            //    {
            //        options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
            //        options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
            //    });
            //services.AddIdentity<Client, IdentityRole>()
            //    .AddEntityFrameworkStores<AuthContext>();

            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //        .AddJwtBearer(options =>
            //        {
            //            options.RequireHttpsMetadata = false;
            //            options.TokenValidationParameters = new TokenValidationParameters
            //            {
            //                // укзывает, будет ли валидироваться издатель при валидации токена
            //                ValidateIssuer = true,
            //                // строка, представляющая издателя
            //                ValidIssuer = AuthOptions.ISSUER,

            //                // будет ли валидироваться потребитель токена
            //                ValidateAudience = true,
            //                // установка потребителя токена
            //                ValidAudience = AuthOptions.AUDIENCE,
            //                // будет ли валидироваться время существования
            //                ValidateLifetime = true,

            //                // установка ключа безопасности
            //                IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
            //                // валидация ключа безопасности
            //                ValidateIssuerSigningKey = true,
            //            };
            //        });
            //// services.AddPaging();
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
            //app.UseAuthentication();
            //app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}

