﻿using Bussiness.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
	public class CartService : ICartService
	{
		public void AddToCart(Cart cart, Product product)
		{
			CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
			if (cartLine != null)
			{
				cartLine.Quantity++;
				return;
			}
			cart.CartLines.Add(new CartLine { Product = product, Quantity = 1 });
		}

		public void RemoveFromCart(Cart cart, int productId)
		{
			cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId));
		}

		public List<CartLine> List(Cart cart)
		{
			return cart.CartLines;
		}
	}
}
