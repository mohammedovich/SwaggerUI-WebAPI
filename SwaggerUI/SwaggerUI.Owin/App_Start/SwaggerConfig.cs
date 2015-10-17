using System.Web.Http;
using WebActivatorEx;
using SwaggerUI.Owin;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace SwaggerUI.Owin
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration 
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "SwaggerUI");
                        c.IncludeXmlComments(GetAPIDocumentations());
                    }).EnableSwaggerUi(c => { });
        }

        protected static string GetAPIDocumentations()
        {
            return System.String.Format(@"{0}\bin\SwaggerUI.Owin.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
