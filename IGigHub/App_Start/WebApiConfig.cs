﻿using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Web.Http;

namespace IGigHub
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var settings = GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settings.Formatting = Formatting.Indented;
            // Web API configuration and services

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
