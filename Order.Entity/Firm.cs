using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Entity
{
	public class Firm : BaseObject
	{
		public string Title { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public string TelephoneNumber { get; set; }
		public string WebSite { get; set; }
		public List<Product> FirmProducts { get; set; }
		public bool IsRestricted { get; set; } = false;
		public int LiasionUserId { get; set; }
		public User User { get; set; }


	}
}
