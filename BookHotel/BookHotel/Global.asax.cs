using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DAL;
using Entities;

namespace BookHotel
{

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //GlobalConfiguration.Configuration.Formatters.Clear();
            //GlobalConfiguration.Configuration.Formatters.Add(new JsonMediaTypeFormatter());
            //GlobalConfiguration.Configuration.Formatters.Add(new XmlMediaTypeFormatter());

            //WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            DBManager.Load();

            //await collection.InsertOneAsync(new Person { Name = "Jack" });

            // var list = await collection.Find(x => x.Name == "Jack").ToListAsync();
            //foreach (var person in list)
            //{
            //    Console.WriteLine(person.Name);
            //}
        }
    }
}