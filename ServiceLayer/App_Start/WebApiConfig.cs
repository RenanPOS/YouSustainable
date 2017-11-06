﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ServiceLayer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web
            //var cors = new EnableCorsAttribute("http://localhost,http://127.0.0.1", "*", "*", "X-Custom-Header");
            var cors = new EnableCorsAttribute("*",
                                               "Origin, Content-Type, Accept",
                                               "GET, PUT, POST, DELETE, OPTIONS");
            config.EnableCors(cors);
            // Rotas da API da Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
        }
    }
}
