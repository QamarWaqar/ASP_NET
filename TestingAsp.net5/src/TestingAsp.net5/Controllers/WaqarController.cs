using Microsoft.AspNet.Mvc;
using TestingAsp.net5.Models;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TestingAsp.net5.Controllers
{
    public class WaqarController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(WaqarViewModels.IndexViewModel model)
        {
            //if (ModelState.IsValid) { return Redirect("http://www.google.com/"); } else { return Redirect("http://www.bing.com/"); }
            
            return View(model);
        }

        [HttpGet]
        public IActionResult Waqar()
        {
            return View();
        }

        // Testing Json Response Like some kind of Web API Stuff! //
        // As you know _Layout.cshtml View defines a Scripts Section //
        // So I have put a Script in Waqar.cshtml View in @Scripts body //
        // That Body executes a jQuery script which is present in Lib/myScripts/getJSONresponse.js //
        // That jQuery Script responsibility is to get JSON Response and show it in the Waqar.cshtml view //
        [HttpGet]
        public IActionResult Movies()
        {
            var movies = new List<object>();

            movies.Add(new { Title = "Ghostbusters", Genre = "Comedy", Year = 1984 });
            movies.Add(new { Title = "Gone with Wind", Genre = "Drama", Year = 1939 });
            movies.Add(new { Title = "Star Wars", Genre = "Science Fiction", Year = 1977 });

            return Json(movies);
        }

        // shotting at Identity //
        // ApplicationUser is defined in IdentitdyModels.cs //
        // UserManager is defined is Microsoft.AspNet.Identity //
        public UserManager<ApplicationUser> UserManager { get; set; }
        public RoleManager<ApplicationUser> RoleManager { get; set; }
        public SignInManager<ApplicationUser> SignInManager { get; set; }
    }
}
