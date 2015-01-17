using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace TestingAsp.net5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // the string q is the q variable in query string or POST request //
        public IActionResult Qamar(string q, string htmlHelperTextBox)
        {
            ViewData["htmlHelperTextBox"] = htmlHelperTextBox;
            ViewData["Model"] = "Ok";
            // Please note how I'll use it inside Html helper TextBox //
            // To set its id and name and value //
            // @Html.TextBox("Message"); //
            // in Qamar.cshtml // in submit form 2's textbox //
            // this is awesome //
            ViewBag.Message = "Hello Qamar";
            ViewBag.test = 2; // Declaring a variable in Viewbag that doesnt even exist //
            // trying to pass a model to the view //
            ViewBag.q = q;
            int modelPass = 23;
            return View(modelPass);
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}