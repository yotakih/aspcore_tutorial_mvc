using System;
using System.Reflection;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace tutorial_mvc
{
	public static class CommonMdl
	{
		public static string GetProperty(object obj, string prpName)
		{
			var attr = Attribute.GetCustomAttribute(obj.GetType().GetProperty(prpName), typeof(DisplayAttribute)) as DisplayAttribute;
			return attr.GetName();
		}
	}
}