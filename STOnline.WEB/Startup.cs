using System;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
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
using STOnline.DAL.Models.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using FluentValidation;
using Microsoft.OpenApi.Models;

namespace STOnline.WEB
{
    public class Startup
    {
        private IConfigurationRoot _confString;
        public Startup(IHostEnvironment hostEnvironment)
        {
            _confString = new ConfigurationBuilder().
                SetBasePath(hostEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
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

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            });

            /**JWT Auth**/
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

            services.AddValidatorsFromAssembly(typeof(Startup).Assembly);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Test API",
                    Description = "ASP.NET Core Web API"
                });
            });

            services.AddCors();
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(options =>
                        options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()); if (env.IsDevelopment())
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
            app.UseStaticFiles();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test API V1");
            });
            
            app.UseMvc();

        }

    }
}

