using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using tutorial_mvc.Models;

using CurModel = tutorial_mvc.Models.Test3;

namespace tutorial_mvc.Controllers
{
	public partial class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Test3()
		{
			var mdl = new CurModel();
			return View(mdl);
		}

		[HttpPost]
		public IActionResult Test3(CurModel m)
		{
			ModelState.Clear();
			return View(m);
		}
	}
}
