using System;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.ViewComponents.AdminUILayoutViewComponent
{
   [ViewComponent(Name = "_AdminHeadLayoutViewComponent")] 

    public class _AdminHeadLayoutViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

