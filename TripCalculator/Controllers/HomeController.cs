using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripCalculator.Models;
using TripCalculator.Models.TripCalculatorViewModel;
using TripCalculator.Models.TripRepositoryViewModel;

namespace TripCalculator.Controllers
{
	public class HomeController : Controller
	{
		//private IHostingEnvironment _env;
		//TripRepository _TripRepository = new TripRepository();
		vmTripCalculator vm = new vmTripCalculator();

		public IActionResult Index()
		{			
			return View(vm); // vm is not in use
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
