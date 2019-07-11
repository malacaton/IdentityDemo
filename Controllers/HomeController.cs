using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityDemo.Models;
using Microsoft.AspNetCore.Authorization;

namespace IdentityDemo.Controllers
{
	// [Authorize(Roles = "Administrator")] si fuese necesario filtrar por roles
	public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize] // [Authorize(Roles = "Administrator")] si fuese necesario filtrar por roles
		public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
