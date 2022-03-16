using System;
namespace ReactBackend.Models
{
    public class SalesProduct
    {
        public int Id { get; set; }
        public ProductModel Product { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
    }
}
