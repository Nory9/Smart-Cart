using Smart_Cart.Shop_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Cart
{
    public class UserInterface
    {
        clothingShop clothingShop=new clothingShop();
        pizza pizza=new pizza();    
        desserts desserts = new desserts(); 
        ShoppingCart shoppingCart = new ShoppingCart(); 
        public void InterfaceFlow() {
            Console.WriteLine("Wellcome to mario mall let's get started!");

            while (true) {
                Console.WriteLine("\n Select a choice:\n" +
                    "1.Desserts shop \n" +
                    "2. pizza shop \n" +
                    "3. clothing store\n" +
                    "4. view cart\n" +
                    "5. remove product from cart\n"+
                    "6. check out"+
                    "\n7. Exit the mall");

                string userInput= Console.ReadLine();
                int userChoise = 0;
                switch (userInput) {

                    case "1": 
                         desserts.ViewProducts();
                         userChoise=Convert.ToInt32(Console.ReadLine());
                        if (desserts.SelectProduct(userChoise) != null)
                            shoppingCart.AddProduct(desserts.SelectProduct(userChoise));
                        
                        break;

                    case "2":
                        pizza.ViewProducts();
                        userChoise = Convert.ToInt32(Console.ReadLine());
                        if (pizza.SelectProduct(userChoise) != null)
                            shoppingCart.AddProduct(pizza.SelectProduct(userChoise));
                        break;

                    case "3":
                        clothingShop.ViewProducts();    
                        userChoise=Convert.ToInt32((Console.ReadLine()));
                        if (clothingShop.SelectProduct(userChoise) != null)
                            shoppingCart.AddProduct(clothingShop.SelectProduct(userChoise));
                        break;

                    case "4":
                        shoppingCart.ViewAll();
                        break;

                    case "5":
                        shoppingCart.ViewAll();
                        Console.WriteLine("Select the product you want to delete");
                        userChoise = Convert.ToInt32((Console.ReadLine()));
                        shoppingCart.RemoveProduct(userChoise);
                         break;

                     case "6":
                        decimal cost= shoppingCart.CalculateCost();
                        Console.WriteLine($"Total cost: {cost:C}");
                        break;

                    case "7":
                        Environment.Exit(0);    
                        break;

                    default:
                        Console.WriteLine("Invalid choice try again!");
                        break;
                
                }
            }
        
        }
    }
}
