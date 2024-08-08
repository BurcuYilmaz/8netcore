using Entities.Concrete;

namespace WebUI.Models
{
	public class ProductListViewModel
	{
		public int CurrentCategory { get; internal set; }
		public int CurrentPage { get; internal set; }
		public int PageCount { get; internal set; }
		public int PageSize { get; internal set; }
		public List<Product> Products { get; internal set; }
	}
}
