using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Product
    {
        public Product(string title, string description, string image, decimal price, int quantityAvalible)
        {
            Title = title;
            Description = description;
            Image = image;
            Price = price;
            QuantityAvalible = quantityAvalible;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int QuantityAvalible { get; set; }
    }
}
