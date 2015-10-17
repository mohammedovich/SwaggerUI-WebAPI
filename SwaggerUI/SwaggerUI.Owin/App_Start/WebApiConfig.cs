using System.Web.Http;

namespace SwaggerUI.Owin
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new {id = RouteParameter.Optional});
        }
    }
}
