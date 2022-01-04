using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace tutorial_mvc.Models
{
	public class DataTypeInfo
	{
		public string Type = "";
		public int Length = 0;
	}
	public class Test
	{
		public static Dictionary<string, DataTypeInfo> DataInfo = new Dictionary<string, DataTypeInfo>()
		{
			{nameof(Test.Text), new DataTypeInfo() { Type = "text", Length = 10 }},
		};

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

		public static Expression<Func<TModel, TResult>> GetExpression<TModel, TResult>(string prpName)
		{
			ParameterExpression arg = Expression.Parameter(typeof(Test), "Model");
			MemberExpression prp = Expression.Property(arg, prpName);
			return Expression.Lambda<Func<TModel, TResult>>(prp, arg);
		}
	}
}