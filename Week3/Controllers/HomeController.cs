using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace Week3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Table()
        {
            ViewBag.Message = "Lets create a multiplication table!";

            return View();
        }

        [HttpPost]
        public ActionResult CreateTable(string num)
        {
            int n = Convert.ToInt32(num);

            StringBuilder multiply = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    multiply.Append(i * j);
                    multiply.Append(" ");                   
                }
                multiply.Append("</br>");
            }
            return Content(multiply.ToString());
        }
    }
}