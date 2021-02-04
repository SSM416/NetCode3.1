using Autofac;
using System.Linq;
using System.Reflection;

namespace gp_admin_Code
{
    public class ConfigureAutofac:Autofac.Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            //程序集范围注入
            Assembly service = Assembly.Load("Exercise.Services");
            Assembly Iservice = Assembly.Load("Exercise.IServices");
            containerBuilder.RegisterAssemblyTypes(service, Iservice)
.Where(t => t.Name.EndsWith("Service"))
.AsImplementedInterfaces().PropertiesAutowired();


            //在控制器中使用属性依赖注入，其中注入属性必须标注为public
            var controllersTypesInAssembly = typeof(Startup).Assembly.GetExportedTypes()
.Where(type => typeof(Microsoft.AspNetCore.Mvc.ControllerBase).IsAssignableFrom(type)).ToArray();
            containerBuilder.RegisterTypes(controllersTypesInAssembly).PropertiesAutowired();
        }
    }
}
