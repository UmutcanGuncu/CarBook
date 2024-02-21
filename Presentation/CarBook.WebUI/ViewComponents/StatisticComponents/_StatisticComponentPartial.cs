using System;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.StatisticComponents
{
	public class _StatisticComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

