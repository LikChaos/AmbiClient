using System;
using System.Collections.Generic;

namespace ClientApi.Models.Home
{
	public class HomeViewModel
	{
		public List<Tender> DataList = new List<Tender>();

		public HomeViewModel(List<Tender> result)
		{
			DataList = result;
		}
	}
}