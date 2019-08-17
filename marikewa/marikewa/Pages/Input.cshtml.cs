using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace marikewa.Pages
{
	public class InputModel : PageModel
	{
		public void OnGet()
		{
		}

		public string Voornaam { get; set; }
		public string Achternaam { get; set; }
		public string Advies { get; set; }
	}
}