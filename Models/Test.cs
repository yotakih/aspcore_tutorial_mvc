using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using FluentValidation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace tutorial_mvc.Models
{
	public class Test
	{
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

		public static InlineValidator<Movie> Validator
			= new InlineValidator<Movie>{
				v => v.RuleFor(x => x.Price).GreaterThan(1000)
			};

		public static FluentValidation.Results.ValidationResult Validate(Movie x)
		{
			return Validator.Validate(x);
		}
	}
}