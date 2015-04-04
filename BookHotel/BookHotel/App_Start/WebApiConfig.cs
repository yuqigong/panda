//using System.Net.Http.Headers;
//using System.Web.Http;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Converters;

//namespace BookHotel
//{
//    public static class WebApiConfig
//    {
//        public static void Register(HttpConfiguration config)
//        {
//            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
//            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/json"));
//            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/plain"));
//            config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new CustomDateTimeConverter());

//            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
//            json.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
//            json.SerializerSettings.DefaultValueHandling = DefaultValueHandling.Ignore;

//            config.Routes.MapHttpRoute(
//                name: "DefaultApi",
//                routeTemplate: "api/{controller}/{id}",
//                defaults: new { id = RouteParameter.Optional }
//            );
//        }
//    }
//    class CustomDateTimeConverter : IsoDateTimeConverter
//    {
//        public CustomDateTimeConverter()
//        {
//            base.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
//        }
//    }
//}
