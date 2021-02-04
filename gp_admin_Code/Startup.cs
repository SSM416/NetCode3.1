using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using gp_DataBase.gp15_base_Models;
using gp_DataBase.unified_users_Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace gp_admin_Code
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
       
            var csredis = new CSRedis.CSRedisClient("127.0.0.1:6379,defaultDatabase=0,poolsize=50,ssl=false,writeBuffer=10240");
            //初始化 RedisHelper
            RedisHelper.Initialization(csredis);
            //cookies
            services.AddAuthentication("CookieAuthentication")
                .AddCookie("CookieAuthentication", config =>
                {
                    config.Cookie.Name = "enet_studentname";
                    config.LoginPath = "/Login/Login";
                    //config.AccessDeniedPath = "/Error/Forbidden";//没有权限时的跳转页面
                    config.ExpireTimeSpan = new TimeSpan(1, 0, 0);//默认14天

                });
            services.AddControllers().AddControllersAsServices();
            services.AddControllersWithViews();
            services.AddScoped<DbContext, unified_usersContext>();
            services.AddScoped<DbContext, gp15_baseContext>();
            //services.AddScoped<DbContext, gp15_studentContext>();
            //services.AddScoped<DbContext, unified_usersContext>();
            string gp15_base_connection = Configuration.GetConnectionString("gp15_BaseContextReadDataBase");
            // string gp15_student_connection = Configuration.GetConnectionString("Gp15_student_MysqlConnection");
            var unified_users_connection = Configuration.GetConnectionString("unified_usersContextReadDataBase");

            //string hb16_gp15_student_connection = Configuration.GetConnectionString("Hb16_gp15_student_MysqlConnection");

            services.AddDbContext<gp15_baseContext>(options => options.UseMySql(gp15_base_connection));
            //services.AddDbContext<gp15_studentContext>(options => options.UseMySql(gp15_student_connection));
            services.AddDbContext<unified_usersContext>(options => options.UseMySql(unified_users_connection));
            services.AddSession();
            services.AddHttpContextAccessor();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
        public void ConfigureContainer(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule<ConfigureAutofac>();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors();
           
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseForwardedHeaders(new ForwardedHeadersOptions { ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Login}/{id?}");
            });
        }
    }
}
