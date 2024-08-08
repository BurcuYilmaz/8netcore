using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;
using Bussiness.Abstract;

namespace WebUI.ViewComponents
{
	public class CategoryListViewComponent : ViewComponent
	{
		private ICategoryService _categoryService;

		public CategoryListViewComponent(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public ViewViewComponentResult Invoke()
		{
			var model = new CategoryListViewModel
			{
				Categories = _categoryService.GetAll(),
				CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["category"])
			};
			return View(model);
		}
	}
}

