using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SistemaEscolar
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var politicas = new EnableCorsAttribute(
          origins: "*",
          methods: "*",
          headers: "*"
          );
        config.EnableCors(politicas);
            // Web API configuration and services
            config.EnableCors();
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
