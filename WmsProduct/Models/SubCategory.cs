﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WmsProduct.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Category MainCategory { get; set; }
        public int MainCategoryId { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}