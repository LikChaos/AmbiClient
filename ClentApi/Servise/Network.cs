using ClientApi.Models.Home;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ClientApi.Servise
{
	public class Network
	{
		private String URL;

		public Network(String URL)
		{
			this.URL = URL;
		}

		public async System.Threading.Tasks.Task<List<Tender>> GetDatasAsync()
		{
			List<Tender> answer = new List<Tender>();
			HttpClient client = new HttpClient();
			//String URL = "http://localhost:60000/data";
			var result = client.GetAsync(URL).Result;
			if (result.IsSuccessStatusCode)
			{
				String buff = await result.Content.ReadAsStringAsync();
				answer = JsonConvert.DeserializeObject<List<Tender>>(buff);
			}
			return answer;
		}
	}
}
