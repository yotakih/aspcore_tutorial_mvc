using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace tutorial_mvc.Models
{
	public class Test3
	{
		public string Text { get; set; }
		public string Text2 { get; set; }
		public Test3Inner Inner {get; set; }

		public Test3()
		{
			this.Inner = new Test3Inner();
		}
	}

	public class Test3Inner
	{
		public string Text { get; set; }
		public string Text2 { get; set; }
		public List<string> Lst { get; set; }
		public List<string> Lst2 { get; set; }

		public Test3Inner()
		{
			this.Lst = new List<string>()
			{
				"hoge"
			};
			this.Lst2 = new List<string>()
			{
				"fuga"
			};
		}
	}
}