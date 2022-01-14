using System;
using System.Reflection;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;

namespace tutorial_mvc
{
	public static class CommonMdl
	{
		public static string GetProperty(object obj, string prpName)
		{
			var attr = Attribute.GetCustomAttribute(obj.GetType().GetProperty(prpName), typeof(DisplayAttribute)) as DisplayAttribute;
			return attr.GetName();
		}

		public static Expression<Func<TModel, TResult>> GetExpression<TModel, TResult>(Type mdlTyp, string prpName)
		{
			ParameterExpression arg = Expression.Parameter(mdlTyp, "Model");
			MemberExpression prp = Expression.Property(arg, prpName);
			return Expression.Lambda<Func<TModel, TResult>>(prp, arg);
		}
	}
}