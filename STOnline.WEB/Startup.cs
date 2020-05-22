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
using Microsoft.AspNetCore.Identity;
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
using Microsoft.AspNetCore.Authentication.Cookies;
using STOnline.DAL.Models;
using STOnline.DAL.Models.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.CodeAnalysis;
using System.Text;
using Microsoft.IdentityModel.Tokens;
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
            //services.Configure<AplicationSettings>(Configuration.GetSection("AplicationSettings"));
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

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            });

            //JWT Auth
            var securityKey = Encoding.UTF8.GetBytes("12345678987654321");
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x => {
                x.RequireHttpsMetadata = false;
                x.SaveToken = false;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(securityKey),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                };
            });

            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IWorkerRepository, WorkerRepository>();
            services.AddTransient<IWorkerCategoryRepository, WorkerCategoryRepository>();
            
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IWorkerService, WorkerService>();
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
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}

