﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Entity
{
	public class BaseObject
	{
		public int Id { get; set; }
		public DateTime CreatedAt { get; set; }

		public DateTime DeletedAt { get; set; }

		public bool IsActive { get; set; } = true;
	}
}
