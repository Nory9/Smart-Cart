using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart.Shop_Classes
{
    public class pizza
    {
        public List<Product> AvailableProducts;

        public pizza()
        {

            AvailableProducts = new List<Product>();
            ProductGenerator Generator = new ProductGenerator();
            for (int i = 0; i < 10; i++)
            {
                Product product = Generator.GenerateProduct(ProductCategory.pizza);
                AvailableProducts.Add(product);
            }
        }

        public bool ViewProducts()
        {
            if (AvailableProducts.Count > 0)
            {
                for (int i = 0; i < AvailableProducts.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.  {AvailableProducts[i].Name} , Price: {AvailableProducts[i].price}\n");
                }
                return true;
            }
            else
            {

                return false;
            }
        }

        public Product SelectProduct(int ProductID)
        {

            ShoppingCart shoppingCart = new ShoppingCart();
            if (ProductID > 0 && ProductID <= AvailableProducts.Count)
            {
                return AvailableProducts[ProductID - 1];
                // shoppingCart.AddProduct(AvailableProducts[ProductID-1]);
            }
            else
                Console.WriteLine("Invalid Id!");
            return null;
        }
    }
}