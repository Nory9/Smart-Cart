using Smart_Cart;
using Smart_Cart.Shop_Classes;

namespace Smart_Cart_Test
{
    public class UnitTest1
    {
        [Fact]
        public void AddProduct_Test_Pass()
        {
            ShoppingCart cart = new ShoppingCart();
            Product product = new Product("cake",10,ProductCategory.desserts);
            Assert.True(cart.AddProduct(product));
        }

        [Fact]
        public void AddProduct_Test_Fail()
        {
            ShoppingCart cart = new ShoppingCart();
            Assert.False(cart.AddProduct(null));
        }

        [Fact]
        public void RemoveProduct_Test_Pass()
        {
            ShoppingCart cart = new ShoppingCart();
            Product product1 = new Product("cake", 10, ProductCategory.desserts);
            Product product2 = new Product("cheesecake", 20, ProductCategory.desserts);
            Product product3 = new Product("pizza", 10, ProductCategory.pizza);
              cart.AddProduct(product1);
              cart.AddProduct(product2);
              cart.AddProduct(product3);
            Assert.True(cart.RemoveProduct(1)); // to remove product with index 1 "cake"
        }

        [Fact]
        public void RemoveProduct_Test_Fail()
        {
            ShoppingCart cart = new ShoppingCart();
            Product product1 = new Product("cake", 10, ProductCategory.desserts);
            Product product2 = new Product("cheesecake", 20, ProductCategory.desserts);
            Product product3 = new Product("pizza", 10, ProductCategory.pizza);
            cart.AddProduct(product1);
            cart.AddProduct(product2);
            cart.AddProduct(product3);
            Assert.False(cart.RemoveProduct(7));
        }
        
        
        [Fact]
        public void CalculateCost_Test()
        {
            ShoppingCart cart = new ShoppingCart();
            Product product1 = new Product("cake", 10, ProductCategory.desserts);
            Product product2 = new Product("cheesecake", 20, ProductCategory.desserts);
            Product product3 = new Product("pizza", 10, ProductCategory.pizza);
            cart.AddProduct(product1);
            cart.AddProduct(product2);
            cart.AddProduct(product3);

            decimal cost = cart.CalculateCost();
            decimal ExpectedCost = 40;
            Assert.Equal(ExpectedCost,cost);
        }
    }
}