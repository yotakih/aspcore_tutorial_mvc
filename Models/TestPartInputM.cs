using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace tutorial_mvc.Models
{
	public class TestPartInputM
	{
		public Dictionary<string, DataTypeInfo> GetDataInfo()
		{
				return new Dictionary<string, DataTypeInfo>()
				{
					{nameof(TestPartInputM.Text), new DataTypeInfo() { Type = "text", Length = 10, Attr = new { @class = "form-control", style = "" } }},
					{nameof(TestPartInputM.Drop), new DataTypeInfo() { Type = "drop", SelectList = new SelectList(this.Drop_op, "Value", "Text" ), Attr = new { @class = "form-control", style = "" }}},
				};
		}

		[Required]
		[Display(Name = "テキスト")]
		public string Text { get; set; }

		[Display(Name = "テキストエリア")]
		public string TextArea { get; set; }

		[Required]
		[Display(Name = "ドロップダウン")]
		public string Drop { get; set; }
		public List<SelectListItem> Drop_op { get; set; }

		[Required]
		[Display(Name = "リスト")]
		public List<string> Listbox { get; set; }
		public List<SelectListItem> Listbox_op { get; set; }

		[Required]
		[Display(Name = "日付")]
		public DateTime Dt { get; set; }

		[Required]
		[Display(Name = "チェック")]
		public bool Check { get; set; }
	}
}