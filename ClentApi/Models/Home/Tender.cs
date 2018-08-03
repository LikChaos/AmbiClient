using System;
using System.ComponentModel.DataAnnotations;

namespace ClientApi.Models.Home
{
	public class Tender
	{
		public Tender(string Name, DateTime DateStart, DateTime DateEnd, string URL)
		{
			this.Name = Name;
			this.DateStart = DateStart;
			this.DateEnd = DateEnd;
			this.URL = URL;
		}

		public string Name { get; set; }
		[DataType(DataType.Date)]
		public DateTime DateStart { get; set; }
		public DateTime DateEnd { get; set; }
		[DataType(DataType.Date)]
		public string URL { get; set; }
	}
}
