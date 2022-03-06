using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MyApp.Helpers
{
	public static class MyHTMLHelpers
	{
		public static IHtmlContent Test<TModel>(this IHtmlHelper<TModel> html,
		Expression<Func<TModel, string>> expression)
		{
			var mdl = new ModelExpressionProvider(html.MetadataProvider).CreateModelExpression(html.ViewData, expression);
			Console.WriteLine($"{mdl.Name}:{mdl.Model}");
			var id = TagBuilder.CreateSanitizedId(mdl.Name, html.IdAttributeDotReplacement);
			return new HtmlString($"<input id={id} name={mdl.Name} value={mdl.Model}>");
		}
	}
}
