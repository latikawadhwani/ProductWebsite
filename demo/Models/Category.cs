﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}