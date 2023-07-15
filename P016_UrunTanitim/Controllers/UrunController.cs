using Microsoft.AspNetCore.Mvc;
using P016_UrunTanitim.Models;

namespace P016_UrunTanitim.Controllers
{
	public class UrunController : Controller
	{
		//Context -> veritabanım nerde? Bu veritabanında hangi tablolarım (modellerim) var?
		//TedarikciIsmi verisini consructor dan içeri alma

		private string tedarikciIsmi = "";
		//Urun u = new Urun();
		//public UrunController()
		//{
		//	//this.tedarikciIsmi = tedarikciIsmi;
		//}

		public IActionResult Index()
		{
			Urun u1 = new Urun { Id = 1, UrunKodu = "K001", UrunTanim = "105 Tuşlu klavye", UrunTur = "PC", Miktar = 56 };

			Urun u2 = new Urun { Id = 2, UrunKodu = "M001", UrunTanim = "21 inç monitör", UrunTur = "PC", Miktar = 3 };

			Urun u3 = new Urun { Id = 3, UrunKodu = "K002", UrunTanim = "Kahve", UrunTur = "Hazır Gıda", Miktar = 560 };

			List<Urun> list = new List<Urun>();
			list.Add(u1);
			list.Add(u2);	
			list.Add(u3);

			return View(list);
		}	
	}
}