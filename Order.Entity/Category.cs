﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Entity
{
	public class Category:BaseObject
	{
        public string Title { get; set; }
				public List<Product> ProductList { get; set;}
    }
}
