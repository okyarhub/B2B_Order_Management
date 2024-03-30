using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Entity
{
	public class Order:BaseObject
	{
		public string Details { get; set; }
		public decimal OrderTotalAmount { get; set; }
		public decimal Price { get; set; }
		public decimal OrderQuantity { get; set; }
		public List<Product> OrderProductList { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime OrderTime { get; set; }
		public int OrderedUserId { get; set; }
		public User User { get; set; }
		public int OrderedFirmId { get; set; }
		public Firm Firm { get; set; }
	}
}
