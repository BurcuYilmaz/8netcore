﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
	public interface ICartService
	{
		void AddToCart(Cart cart, Product product);
		void RemoveFromCart(Cart cart, int productId);
		List<CartLine> List(Cart cart);
	}


}
