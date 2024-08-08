﻿using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;
using WebUI.Services;

namespace WebUI.ViewComponents
{
	public class CartSummaryViewComponent : ViewComponent
	{
		private ICartSessionService _cartSessionService;

		public CartSummaryViewComponent(ICartSessionService cartSessionService)
		{
			_cartSessionService = cartSessionService;
		}

		public ViewViewComponentResult Invoke()
		{
			var model = new CartSummaryViewModel
			{
				Cart = _cartSessionService.GetCart()
			};
			return View(model);
		}
	}
}

