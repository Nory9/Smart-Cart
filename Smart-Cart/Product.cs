using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{

    public enum ProductCategory {

        pizza,
        clothingShop,
        desserts
    
    }
    public class Product
    {
        public string Name { get; set; }
        public int price { get; set; }
        public ProductCategory category { get; set; }

        public Product(string Name, int price, ProductCategory category) { 
        
            this.Name = Name;   
            this.price = price; 
            this.category = category;
        }
    }
}
