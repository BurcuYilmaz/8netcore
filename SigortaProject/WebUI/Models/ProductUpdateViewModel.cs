using Entities.Concrete;

namespace WebUI.Models
{
	public class ProductUpdateViewModel
	{
		public List<Category> Categories { get; set; }
		public Product Product { get; set; }
	}
}
