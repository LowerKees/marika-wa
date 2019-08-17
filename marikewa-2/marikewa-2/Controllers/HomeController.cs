using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using marikewa_2.Models;

namespace marikewa_2.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			string advies = GetRandomAdvies();
			ViewData["Advies"] = advies;
			return View();
		}

		private string GetRandomAdvies()
		{
			DirectoryInfo dir = new DirectoryInfo("wwwroot/sav");
			int nrOfFiles = dir.GetFiles().Count();
			if(nrOfFiles == 0) { return "Ga zo door"; }
			Random rnd = new System.Random();
			int rand = rnd.Next(0, nrOfFiles);
			var files = dir.GetFiles();
			var file = files[rand];
			FormData outcome = new FormData();

			using (StreamReader reader = file.OpenText())
			{
				JsonSerializer ser = new JsonSerializer();
				outcome = (FormData)ser.Deserialize(reader, typeof(FormData));
			}

			string advies = outcome.Advies;
			return advies;
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
