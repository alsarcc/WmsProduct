using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WmsProduct.Models
{
    public class Category
    {
        //signifies the Id of each subcategory
        public int Id { get; set; }

        //signifies the Id of each parent category
        public int? MainCategoryId { get; set; }

        public string Name { get; set; }

        //?
        public string Description { get; set; }

        public virtual ICollection<Category> SubCategory { get; set; }
    }
}