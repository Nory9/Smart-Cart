using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ProductGenerator
    {

        Random random = new Random();

        List<string> desserts = new List<string>() { "cheesecake", "coockies", "brownies","blueburry ice creem", "mango pudding", "vanilla ice creem","blueburry cake" };
        List<string> pizza = new List<string>() { " pepperoni pizza", "Hawaiian pizza", "garlic butter pizza", "margarita pizza", "potato & rosemary pizza" };
        List<string> clothingShop = new List<string>() { " jumpsuit", "jacket", "sweater", "skirt", "short", "pant", "blouse", "shirt", "t - shirts" };

        public void GenerateProduct()
        {
            ProductCategory category = (ProductCategory)random.Next(0, Enum.GetNames(typeof(ProductCategory)).Length);

            int price = (int)(random.Next(100, 10000) / 100.0);
            string name="";
            switch (category) { 
            
                case ProductCategory.clothingShop:
                     name = clothingShop[random.Next(clothingShop.Count)];
                    break;

                case ProductCategory.pizza:
                    name = pizza[random.Next(pizza.Count)];
                    break;

                case ProductCategory.desserts:
                    name = desserts[random.Next(desserts.Count)];
                    break;
                    
            }

            Product product = new Product(name, price, category);



        }
    }
}
