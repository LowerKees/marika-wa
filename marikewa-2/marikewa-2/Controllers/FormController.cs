using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace marikewa_2.Controllers
{
	public class FormController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult FormOne(string Voornaam, string Achternaam, string Advies)
		{
			string FileName = string.Format("wwwroot/sav/{0}_{1}_{2}.json",
				Voornaam, Achternaam, DateTime.Now.ToFileTime());
			string Input = JsonConvert.SerializeObject(
				new { voornaam = Voornaam, achternaam = Achternaam, advies = Advies.Replace(" ", "-") });
			System.IO.File.WriteAllText(FileName, Input);

			return RedirectToAction("Index", "Home");
		}
	}
}