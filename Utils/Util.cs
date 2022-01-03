using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using System.Linq.Expressions;

namespace tutorial_mvc.Utils
{
	public static class Util
	{
		public static string GetName<T>(Expression<Func<T>> e)
		{
			var member = (MemberExpression)e.Body;
			return member.Member.Name;
		}

		public static string gettag(string name, object val)
		{
			return $"<input	id=\"{name}\" name=\"{name}\" value=\"{val.ToString()}\"";
		}
	}
}