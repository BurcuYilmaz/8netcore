using Entities.Concrete;

namespace WebUI.Models
{
	public class ProductAddViewModel
	{
		public List<Category> Categories { get; internal set; }
		public Product Product { get; set; }
	}
}
