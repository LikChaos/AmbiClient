using ClientApi.Models;
using ClientApi.Models.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ClientApi.Servise;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace ClientApi.Controllers
{
	public class HomeController : Controller
	{
		private readonly IOptions<ServiceSettings> _serviceSettings;
		private readonly Network network;
		public HomeController(IOptions<ServiceSettings> serviceSettings)
		{
			_serviceSettings = serviceSettings;
			network = new Network(_serviceSettings.Value.URL);
		}


		[Authorize]
		public IActionResult Index()
		{
			List<Tender> datas = network.GetDatasAsync().Result;

			return View(new HomeViewModel(datas));
		}

		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
