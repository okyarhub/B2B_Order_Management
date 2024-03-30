using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Entity
{
	public class User : BaseObject
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public int RoleId { get; set; }
		public Role Role { get; set; }
		public string PositionTitle { get; set; }
		public int CompanyId { get; set; }
		public Firm Company { get; set; }

		//public virtual FullName=> $"{FirstName} {LastName}";
    }
}
