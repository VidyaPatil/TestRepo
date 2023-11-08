using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationForCodeQl.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string firstname = null;
            string lastname = Console.ReadLine();
            var fullname = string.Format("{0} {1}", firstname);
            Console.WriteLine("My name is ", fullname);

            object myObject1 = null;
            string myString1 = (string)myObject1;
            object myObject2 = null;
            string myString2 = myObject1 as string;
            List<string> distributionGroups = new List<string>();
            Guid.TryParse(null, out Guid refID);
            string convertStr = Convert.ToString(myString1);
            string directStr = myString1.ToString();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}