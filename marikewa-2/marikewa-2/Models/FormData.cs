using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace marikewa_2.Models
{
	public class FormData
	{
		public string Voornaam { get; set; }
		public string Achternaam { get; set; }
		public string Advies { get; set; }

		public FormData()
		{
			Voornaam = null;
			Achternaam = null;
			Advies = null;
		}
	}

}
