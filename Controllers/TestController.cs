using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using tutorial_mvc.Models;

namespace tutorial_mvc.Controllers
{
    public partial class HomeController : Controller
    {
        [HttpGet]
        public IActionResult TestInitData()
        {
            var m = new Test();
            m.Drop_op = new List<SelectListItem> {
                new SelectListItem() { Value="1", Text="テスト１" },
                new SelectListItem() { Value="2", Text="テスト2" },
                new SelectListItem() { Value="3", Text="テスト3" },
            };
            m.Listbox_op = new List<SelectListItem> {
                new SelectListItem() { Value="1", Text="テスト１" },
                new SelectListItem() { Value="2", Text="テスト2" },
                new SelectListItem() { Value="3", Text="テスト3" },
            };
            return View("TestInitData", m);
        }

        [HttpGet]
        public IActionResult Test()
        {
            return View(new Test());
        }

        [HttpPost]
        public IActionResult Test(Test m)
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

            return View(m);
        }

    }
}
