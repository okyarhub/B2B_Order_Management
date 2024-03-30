using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Entity
{
	public class Product : BaseObject
	{
		public string Name { get; set; }
		public string Category { get; set; }
		public string Details { get; set; }
		public string Price { get; set; }
		
	}
}
