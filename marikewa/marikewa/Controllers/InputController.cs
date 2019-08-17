using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace marikewa.Controllers
{
	public class InputController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public ActionResult Edit(FormCollection values)
		{
			var voornaam = values["Voornaam"];
			var achternaam = values["Achternaam"];
			var advies = values["Advies"];
			string FileName = string.Format("~/sav/{0}_{1}_{2}.json",
				voornaam, achternaam, DateTime.Now.ToFileTime());
			string Input = JsonConvert.SerializeObject(
				new { voornaam = voornaam, achternaam = achternaam, advies = advies });
			System.IO.File.WriteAllText(FileName, Input);

			return View();
		}
	}
}