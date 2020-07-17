
using System;
namespace OnlineStore.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int ModelNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Video { get; set; }
        public string CompanyName { get; set; }
        public string Category { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
    }
}
