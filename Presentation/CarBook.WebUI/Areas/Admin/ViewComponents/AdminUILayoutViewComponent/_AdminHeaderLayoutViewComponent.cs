using System;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.ViewComponents.AdminUILayoutViewComponent
{
	[ViewComponent(Name = "_AdminHeaderLayoutViewComponent")]
	public class _AdminHeaderLayoutViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
