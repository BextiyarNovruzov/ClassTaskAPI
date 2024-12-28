using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ECommerce.Core.Entityes
{
	public class Product: BaseEntity
	{
		public string Name { get; set; } = null!;
		public string Description { get; set; } = null!;
		public string CoverImage { get; set; } = null!;
		public int Quantity { get; set; }
		public int Discount { get; set; }
		public decimal CostPrice { get; set; }
		public decimal SellPrice { get; set; }
		public int CategoryId { get; set; }
		public Category? Categories { get; set; }
		public ICollection<Tag> Tags { get; set; }
	}
}
