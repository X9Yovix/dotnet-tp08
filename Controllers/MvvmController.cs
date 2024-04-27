using Microsoft.AspNetCore.Mvc;
using TP08.Models;
using TP08.VM;

namespace TP08.Controllers
{
	public class MvvmController : Controller
	{
		private readonly IViewModel _viewModelService;

		public MvvmController(IViewModel viewModelService)
		{
			_viewModelService = viewModelService;
		}

		public ActionResult Index()
		{
			ViewModel viewModel = _viewModelService.GetViewModel();
			return View(viewModel);
		}

		public IActionResult DetailClient(int id)
		{
			Client client = _viewModelService.GetClientById(id);

			if (client == null)
			{
				return Content("Client not found");
			}

			return View(client);
		}
	}
}
