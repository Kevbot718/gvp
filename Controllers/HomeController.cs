using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GoodVibesPresents.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Buy_Tickets()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}
		
        public IActionResult News()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Gallery()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Videos()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

        public IActionResult Company()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

		public IActionResult RewardsProgram()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Rewards_Program_SignUp()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}


		public IActionResult Privacy_Policy()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Terms_Of_Use()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

        public IActionResult Error()
        {
            return View();
        }
    }
}
