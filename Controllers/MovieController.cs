using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tutorial_mvc.Models;
using tutorial_mvc.Utils;
using FluentValidation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace tutorial_mvc.Controllers
{
	public partial class HomeController : Controller
	{
		public IActionResult MovieDetail()
		{
			var ja = new System.Globalization.CultureInfo("ja-JP", false);
			ja.DateTimeFormat.Calendar = new System.Globalization.GregorianCalendar(System.Globalization.GregorianCalendarTypes.Localized);
			System.Threading.Thread.CurrentThread.CurrentCulture = ja;
			var movie = new Movie();
			movie.Id = 1;
			movie.Title = "ハリーポッター";
			movie.Price = 1500;
			movie.ReleaseDate = DateTime.Now;
			return View(movie);
			// var v = View("MovieDetail2", movie);
			// v.ContentType = "application/json; charset=utf-8";
			// return v;
			// return Json(new { hoge = "ふが", bar = "baz" });
		}

		public IActionResult MovieDetail3()
		{
			var movie = new Movie();
			movie.Id = 1;
			movie.Title = "ハリーポッター";
			movie.Price = 1500;
			movie.ReleaseDate = DateTime.Now;

			return Json(
					new Dictionary<string, string>() {
										{ nameof(movie.Id), Util.gettag(nameof(movie.Id), movie.Id) },
										{ nameof(movie.Title), Util.gettag(nameof(movie.Title), movie.Title) },
										{ nameof(movie.Price), Util.gettag(nameof(movie.Price), movie.Price) },
										{ nameof(movie.ReleaseDate), Util.gettag(nameof(movie.ReleaseDate), movie.ReleaseDate.ToString("{0:ggyy年M月d日}")) },
					}
			);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult MovieUpd(Movie movie)
		{
			if (ModelState.IsValid)
			{
				// ModelState.AddModelError(string.Empty, "1つ目のエラーです。");
				// ModelState.AddModelError(string.Empty, "2つ目のエラーです。");

				foreach (var e in Movie.Validate(movie).Errors)
				{
					ModelState.AddModelError(e.PropertyName, $"項目：{e.PropertyName}：{e.ErrorMessage}");
				}
			}
			return View("MovieDetail", movie);
		}

	}
}
