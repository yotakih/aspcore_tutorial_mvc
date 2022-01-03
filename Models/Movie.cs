using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using FluentValidation;

namespace tutorial_mvc.Models
{
	public class Movie
	{
		[Required]
		public int Id { get; set; }

		[Required]
		[Display(Name = "タイトル")]
		public string Title { get; set; }

		[Display(Name = "値段")]
		[DisplayFormat(DataFormatString = "{0:C0}")]
		public decimal Price { get; set; }

		[Display(Name = "カテゴリ")]
		public string Category { get; set; }

		[Display(Name = "発売日")]
		[DisplayFormat(DataFormatString = "{0:ggyy年M月d日}")]
		public DateTime ReleaseDate { get; set; }

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