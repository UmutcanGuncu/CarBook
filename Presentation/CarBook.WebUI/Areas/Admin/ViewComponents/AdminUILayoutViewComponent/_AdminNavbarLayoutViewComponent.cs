using System;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.ViewComponents.AdminUILayoutViewComponent
{
    [ViewComponent(Name = "_AdminNavbarLayoutViewComponent")]
    public class _AdminNavbarLayoutViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

