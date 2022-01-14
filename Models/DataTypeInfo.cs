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
		public int Length = -1;
		public string Value = "";
		public List<string> ValueMulti = null;
		public SelectList SelectList = null;
		public object Attr = null;
	}
}