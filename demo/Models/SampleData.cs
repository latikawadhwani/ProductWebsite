using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace demo.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<ProductCatalogEntities>
    {
        protected override void Seed(ProductCatalogEntities context)
        {
            var Category = new List<Category>
            {
                new Category { CategoryName = "Electronics" },
                new Category { CategoryName = "Kitchen" },
                new Category { CategoryName = "Furnishings" },
                new Category { CategoryName = "Clothing" },
                new Category { CategoryName = "Sports" },
                new Category { CategoryName = "Media" },
                
            };

            var Company = new List<Company>
            {
                new Company { CompanyName = "Nokia" },
                new Company { CompanyName = "Samsung" },
                new Company { CompanyName = "Apple" },
                new Company { CompanyName = "Dell" },
                new Company { CompanyName = "Canon" },
                new Company { CompanyName = "Aeropostale" },
                new Company { CompanyName = "Hollister" },
                new Company { CompanyName = "GAP" },
                new Company { CompanyName = "GE" },
                new Company { CompanyName = "LG" },
                new Company { CompanyName = "Bosch" },
                new Company { CompanyName = "Phillips" },
                new Company { CompanyName = "Ikea" },
                new Company { CompanyName = "Intex" },
                new Company { CompanyName = "Whitmor" },
                new Company { CompanyName = "Puma" },
                new Company { CompanyName = "Nike" },
                new Company { CompanyName = "Casio" },
                new Company { CompanyName = "BBC" },
                new Company { CompanyName = "Cisco" },
                new Company{CompanyName="Motorola"}
            };

            new List<Product>
            {
                new Product { Name = "Nokia Lumia 638", ProductImageURL="/Content/Images/placeholder.jpg", Description="With 5.6 inch HD display and 13 MP camera", Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 9.12M, Company = Company.Single(a => a.CompanyName == "Nokia") },
                new Product { Name = "Nokia Lumia 640", ProductImageURL="/Content/Images/placeholder.jpg", Description="With 5.8 inch HD display and 11 MP camera", Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 9.12M, Company = Company.Single(a => a.CompanyName == "Nokia") },
                new Product { Name = "Nokia Lumia 635", ProductImageURL="/Content/Images/placeholder.jpg", Description="With 5.3 inch HD display and 10 MP camera", Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 9.12M, Company = Company.Single(a => a.CompanyName == "Nokia") },
                new Product { Name = "Samsung Galaxy S5",ProductImageURL="/Content/Images/placeholder.jpg", Description="With 5.5 inch HD display and 11 MP camera",Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 10.12M, Company = Company.Single(a => a.CompanyName == "Samsung") },
                new Product { Name = "Samsung Galaxy S4",ProductImageURL="/Content/Images/placeholder.jpg", Description="With 5.5 inch HD display and 11 MP camera",Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 10.12M, Company = Company.Single(a => a.CompanyName == "Samsung") },
                new Product { Name = "Samsung Galaxy S3",ProductImageURL="/Content/Images/placeholder.jpg", Description="With 5.5 inch HD display and 11 MP camera",Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 10.12M, Company = Company.Single(a => a.CompanyName == "Samsung") },
                new Product { Name = "Samsung Galaxy S2",ProductImageURL="/Content/Images/placeholder.jpg", Description="With 5.5 inch HD display and 11 MP camera",Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 10.12M, Company = Company.Single(a => a.CompanyName == "Samsung") },
                new Product { Name = "Samsung Galaxy Note2",ProductImageURL="/Content/Images/placeholder.jpg", Description="With 5.5 inch HD display and 11 MP camera",Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 10.12M, Company = Company.Single(a => a.CompanyName == "Samsung") },
                new Product { Name = "Samsung Galaxy Note3",ProductImageURL="/Content/Images/placeholder.jpg", Description="With 5.5 inch HD display and 11 MP camera",Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 10.12M, Company = Company.Single(a => a.CompanyName == "Samsung") },
                new Product { Name = "Samsung Galaxy Note4",ProductImageURL="/Content/Images/placeholder.jpg", Description="With 5.5 inch HD display and 11 MP camera",Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 10.12M, Company = Company.Single(a => a.CompanyName == "Samsung") },
                new Product { Name = "Samsung Galaxy Note5",ProductImageURL="/Content/Images/placeholder.jpg", Description="With 5.5 inch HD display and 11 MP camera",Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 10.12M, Company = Company.Single(a => a.CompanyName == "Samsung") },
                new Product { Name = "Moto G",ProductImageURL="/Content/Images/placeholder.jpg", Description="With 5.5 inch HD display and 11 MP camera",Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 10.12M, Company = Company.Single(a => a.CompanyName == "Motorola") },
                new Product { Name = "Moto E",ProductImageURL="/Content/Images/placeholder.jpg", Description="With 5.5 inch HD display and 11 MP camera",Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 10.12M, Company = Company.Single(a => a.CompanyName == "Motorola") },
                new Product { Name = "Moto X",ProductImageURL="/Content/Images/placeholder.jpg", Description="With 5.5 inch HD display and 11 MP camera",Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 10.12M, Company = Company.Single(a => a.CompanyName == "Motorola") },
                new Product { Name = "Microwave",ProductImageURL="/Content/Images/placeholder.jpg",Description="With.....", Category = Category.Single(c => c.CategoryName == "Kitchen"), Price = 7.23M, Company = Company.Single(a => a.CompanyName == "GE") },
                new Product { Name = "Refrigerator",ProductImageURL="/Content/Images/placeholder.jpg", Description="With.....",Category = Category.Single(c => c.CategoryName == "Kitchen"), Price = 11.23M, Company = Company.Single(a => a.CompanyName == "Bosch") },
                new Product { Name = "King Size Bed", ProductImageURL="/Content/Images/placeholder.jpg",Description="With.....",Category = Category.Single(c => c.CategoryName == "Furnishings"), Price = 5.99M, Company = Company.Single(a => a.CompanyName == "Ikea") },
                new Product { Name = "AirBed",ProductImageURL="/Content/Images/placeholder.jpg", Category = Category.Single(c => c.CategoryName == "Furnishings"), Price = 8.99M, Company = Company.Single(a => a.CompanyName == "Intex") },
                new Product { Name = "Jeans",ProductImageURL="/Content/Images/placeholder.jpg", Description="With.....",Category = Category.Single(c => c.CategoryName == "Clothing"), Price = 5.99M, Company = Company.Single(a => a.CompanyName == "Aeropostale") },
                new Product { Name = "Shirt",ProductImageURL="/Content/Images/placeholder.jpg", Description="With.....",Category = Category.Single(c => c.CategoryName == "Clothing"), Price = 7.99M, Company = Company.Single(a => a.CompanyName == "Hollister") },
                new Product { Name = "Running Shoes",ProductImageURL="/Content/Images/placeholder.jpg",Description="With.....", Category = Category.Single(c => c.CategoryName == "Sports"), Price = 8.99M, Company = Company.Single(a => a.CompanyName == "Nike") },
                new Product { Name = "Golf Shoes",ProductImageURL="/Content/Images/placeholder.jpg", Description="With.....",Category = Category.Single(c => c.CategoryName == "Sports"), Price = 5.99M, Company = Company.Single(a => a.CompanyName == "Puma") },
                new Product { Name = "A Real Dead One",ProductImageURL="/Content/Images/placeholder.jpg",Description="With.....", Category = Category.Single(c => c.CategoryName == "Sports"), Price = 7.34M, Company = Company.Single(a => a.CompanyName == "Nike") },
                new Product { Name = "Video1",ProductImageURL="/Content/Images/placeholder.jpg",Description="With.....", Category = Category.Single(c => c.CategoryName == "Media"), Price = 2.22M, Company = Company.Single(a => a.CompanyName == "BBC") },
                new Product { Name = "Video2",ProductImageURL="/Content/Images/placeholder.jpg", Description="With.....",Category = Category.Single(c => c.CategoryName == "Media"), Price = 5.66M, Company = Company.Single(a => a.CompanyName == "Cisco") },
                new Product { Name = "Video3",ProductImageURL="/Content/Images/placeholder.jpg",Description="With.....", Category = Category.Single(c => c.CategoryName == "Media"), Price = 4.67M, Company = Company.Single(a => a.CompanyName == "BBC") },
                new Product { Name = "IPhone",ProductImageURL="/Content/Images/placeholder.jpg",Description="With.....", Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 9.79M, Company = Company.Single(a => a.CompanyName == "Apple")},
                new Product { Name = "Dell Inspiron",ProductImageURL="/Content/Images/placeholder.jpg", Category = Category.Single(c => c.CategoryName == "Electronics"), Price = 3.89M, Company = Company.Single(a => a.CompanyName == "Dell") },
                new Product { Name = "CD1",ProductImageURL="/Content/Images/placeholder.jpg", Description="With.....",Category = Category.Single(c => c.CategoryName == "Media"), Price = 6.19M, Company = Company.Single(a => a.CompanyName == "BBC")},
                new Product { Name = "CD2",ProductImageURL="/Content/Images/placeholder.jpg", Description="With.....",Category = Category.Single(c => c.CategoryName == "Media"), Price = 9.67M, Company = Company.Single(a => a.CompanyName == "Cisco") },
                new Product { Name = "Shoes",ProductImageURL="/Content/Images/placeholder.jpg", Description="With.....",Category = Category.Single(c => c.CategoryName == "Sports"), Price = 8.55M, Company = Company.Single(a => a.CompanyName == "Puma") },
                new Product { Name = "Watch",ProductImageURL="/Content/Images/placeholder.jpg",Description="With.....", Category = Category.Single(c => c.CategoryName == "Sports"), Price = 8.45M, Company = Company.Single(a => a.CompanyName == "Nike") },
                new Product { Name = "Shelves",ProductImageURL="/Content/Images/placeholder.jpg", Description="With.....",Category = Category.Single(c => c.CategoryName == "Kitchen"), Price = 23.99M, Company = Company.Single(a => a.CompanyName == "Whitmor") },
                new Product { Name = "RAcks",ProductImageURL="/Content/Images/placeholder.jpg", Description="With.....",Category = Category.Single(c => c.CategoryName == "Furnishings"), Price = 8.69M, Company = Company.Single(a => a.CompanyName == "Intex")},
                new Product { Name = "Washer",ProductImageURL="/Content/Images/placeholder.jpg",Description="With.....", Category = Category.Single(c => c.CategoryName == "Kitchen"), Price = 6.99M, Company = Company.Single(a => a.CompanyName == "LG") },
                new Product { Name = "Sweater",ProductImageURL="/Content/Images/placeholder.jpg",Description="With.....", Category = Category.Single(c => c.CategoryName == "Clothing"), Price = 7.95M, Company = Company.Single(a => a.CompanyName == "GAP")},
                new Product { Name = "Shirt",ProductImageURL="/Content/Images/placeholder.jpg",Description="With.....", Category = Category.Single(c => c.CategoryName == "Clothing"), Price = 5.98M, Company = Company.Single(a => a.CompanyName == "Hollister") }
               }.ForEach(a => context.Products.Add(a));
        }
    }
}