using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class ShoppingCart
    {
        List<Product> shoppingCart  = new List<Product>(); 

        public ShoppingCart() { 
        }   
        public bool AddProduct(Product product) { 
            shoppingCart.Add(product);
            Console.WriteLine($"{product.Name} has been added to the shopping cart successfully"); 
            return true;
        }

        public bool RemoveProduct(int productIndex) {

            if (productIndex > 0 && productIndex <= shoppingCart.Count)
            {
                Product product = shoppingCart[productIndex-1];
                shoppingCart.RemoveAt(productIndex-1);
                Console.WriteLine($"the {product.Name} has been deleted seccussfully");
                return true;
            }
            else {

                Console.WriteLine("Invalid input or the product doesnt exist try again");
                return false;
            }
        }


        public bool RemoveAllProducts() {
            if (shoppingCart.Count != 0)
            {
                shoppingCart.Clear();
                Console.WriteLine("your shopping cart is now empty!");
                return true;
            }
            else { 
            
            Console.WriteLine("your shopping cart is already empty");  
                return false;   

            }
        }

        public bool ViewAll() {

              Console.WriteLine(shoppingCart.Count);
            if (shoppingCart.Count != 0)
            {
                for(int i = 0; i < shoppingCart.Count; i++) 
                {
                        Console.WriteLine($" {i+1}. {shoppingCart[i].Name}, {shoppingCart[i].price},  {shoppingCart[i].category}\n");
                }
                return true;
            }
            else { 
            Console.WriteLine(" nothing to view your shopping cart is empty!");
                return false;   
            }
        }

        public decimal CalculateCost() {

            decimal sum = 0;
            foreach (Product product in shoppingCart) {
                sum += product.price;
            }
            return sum; 
        }
    }
}
