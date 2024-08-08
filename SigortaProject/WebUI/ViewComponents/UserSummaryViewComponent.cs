using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.ViewComponents
{
	public class UserSummaryViewComponent : ViewComponent
	{
		public ViewViewComponentResult Invoke()
		{

			UserDetailsViewModel model = new UserDetailsViewModel
			{
				UserName = HttpContext.User.Identity.Name
			};
			return View(model);
		}
	}
}
