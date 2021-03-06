using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace tutorial_mvc.Models
{
	public class Test2
	{
		[Required]
		[Display(Name = "テキスト")]
		public string Text { get; set; }

		[Display(Name = "テキストエリア")]
		public string TextArea { get; set; }

		[Required]
		[Display(Name = "ドロップダウン")]
		public string Drop { get; set; }

		[Required]
		[Display(Name = "リスト")]
		public List<string> Listbox { get; set; }

		[Required]
		[Display(Name = "日付")]
		public DateTime Dt { get; set; }

		[Required]
		[Display(Name = "チェック")]
		public bool Check { get; set; }

	}
}