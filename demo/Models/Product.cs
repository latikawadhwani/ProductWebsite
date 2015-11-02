using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace demo.Models
{
    [Bind(Exclude = "ProductID")]
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductID { get; set; }
        [DisplayName("CategoryName")]
        public int CategoryID { get; set; }
        [DisplayName("CompanyName")]
        public int CompanyID { get; set; }
        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(150)]
        public string Name { get; set; }
        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 10000.00, ErrorMessage = "price must be between 0.01 and 10000.00")]
        public Decimal Price { get; set; }
        public string ProductImageURL { get; set; }
        public string Description { get; set; }
    }
}