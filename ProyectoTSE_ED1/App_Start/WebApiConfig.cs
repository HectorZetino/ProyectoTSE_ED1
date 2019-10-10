using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProyectoTSE_ED1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "servicios/{dln}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
