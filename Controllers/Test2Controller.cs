using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using tutorial_mvc.Models;

using CurModel = tutorial_mvc.Models.Test2;

namespace tutorial_mvc.Controllers
{
	public partial class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Test2()
		{
			return View();
		}

		[HttpGet]
		public IActionResult InitTest2()
		{
			var selectlist = new List<object>() {
								new { @val = "", @text = "デフォルト" },
								new { @val = "1", @text = "選択肢1" },
								new { @val = "2", @text = "選択肢2" },
						};
			var m = new CurModel();
			return Json(
				new
				{
					@key = $"div.{nameof(m.Text)}",
					@type = "text",
					@attr = new
					{
						@class = "hoge fuga",
						@value = m.Text,
					}
				}
			);
		}

		[HttpPost]
		public IActionResult Test2(Test m)
		{
			this._logger.LogInformation($"{nameof(m.Text)}: {m.Text}");
			// this._logger.LogInformation($"{nameof(m.Drop)}: {m.Drop}");
			// this._logger.LogInformation($"{nameof(m.Listbox)}: {m.Listbox[0]}");
			// this._logger.LogInformation($"{nameof(m.Check)}: {m.Check}");

			var err = ModelState[nameof(m.Text)].Errors.ToList();
			if (err.Count > 0)
			{
				this._logger.LogInformation(err[0].ErrorMessage);
			}

			// foreach(var ms in ModelState.Values)
			// {
			//     foreach(var e in ms.Errors)
			//     {
			//         this._logger.LogInformation(e.ErrorMessage);
			//     }
			// }

			this.InitData(m);
			return View(m);
		}

	}
}
