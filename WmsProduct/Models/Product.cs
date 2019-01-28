using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WmsProduct.Models
{
    public class Product
    {
        // for Database only
        public int Id { get; set; }

        //how is it generated?
        public string SKU { get; set; }
        public string Description { get; set; }

        //how is it generated?
        public int Barcode { get; set; }

        // maybe a class
        public string Brand { get; set; }

        public string Color { get; set; }

        // ti eidous proionta exoume?
        public int? Size { get; set; }

        public string CountryOrigin { get; set; }

        // maybe a class
        public string Image { get; set; }

        public int SalesUnitPrice { get; set; }

        public int PurchaseUnitPrice { get; set; }

        public bool Discontinued { get; set; }
        //public bool InInventory { get; set; }


        //inventory or not?
        //enumeration?
        //public virtual Package Package { get; set; }
        public int PackageId { get; set; }


        public virtual SubCategory SubCategory { get; set; }
        public int SubCategoryId { get; set; }

        //TODO Relationships
        //Supplier
        //Employee
        //Inventory
    }
}