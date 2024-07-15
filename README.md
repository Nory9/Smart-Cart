# Smart Shopping Cart Application

## Overview

This project is a console-based smart shopping cart application where users can add and remove items, view their cart contents, and calculate the total cost of their purchases. The application simulates shopping at a mall, where users can select items from different shops such as grocery stores and clothing stores.

## Features

- **Product Management**: Represents individual items available for purchase with properties such as name, price, and category.
- **Shopping Cart Management**: Allows users to add, remove, and view items in their shopping cart, and calculate the total cost of their purchases.
- **Random Product Generation**: Generates random products with varying attributes.
- **Multiple Shops**: Includes different types of shops, each with its own list of available products.
- **Console-Based User Interface**: Provides a menu-driven interface for interacting with the shopping cart and shops.

## Class Structure

### 1. `Product`
Represents individual items available for purchase.

#### Properties:
- `Name`: The name of the product.
- `Price`: The price of the product.
- `Category`: The category of the product (using the `ProductCategory` enum).

### 2. `ProductCategory`
An enum to categorize different types of products.
- `Food`
- `Clothing`
- `Electronics`

### 3. `ProductGenerator`
Generates random products with varying attributes.

#### Methods:
- `GenerateProduct(ProductCategory category)`: Generates a product with a random name, price, and the specified category.

### 4. `ShoppingCart`
Manages the items added by the user.

#### Methods:
- `AddProduct(Product product)`: Adds a product to the cart.
- `RemoveProduct(int productIndex)`: Removes a product from the cart based on its index.
- `ViewCart()`: Displays the current items in the cart.
- `CalculateTotalCost()`: Calculates and returns the total cost of items in the cart.

### 5. `GroceryStore`
Represents a grocery store with a list of available products.

#### Methods:
- `DisplayProducts()`: Displays the available products in the store.
- `SelectProduct(int productId)`: Selects a product by its ID to add to the cart.

### 6. `ClothingStore`
Represents a clothing store with a list of available products.

#### Methods:
- `DisplayProducts()`: Displays the available products in the store.
- `SelectProduct(int productId)`: Selects a product by its ID to add to the cart.

## How to Run

1. **Clone the Repository**
   ```sh
   git clone https://github.com/yourusername/smart-shopping-cart.git
   cd smart-shopping-cart

2. **Build the Project**
Ensure you have .NET SDK installed. Open a terminal and navigate to the project directory.
    
    ```
    dotnet build
    
    ```
    
3. **Run the Application**
    
    ```
    dotnet run
    
    ```
    
3. **Follow the On-Screen Instructions**
Use the menu options to shop at different stores, view your cart, remove items, and check out.

## Example Usage

1. Select a shop (e.g., Grocery Store).
2. Browse and select products to add to your cart.
3. View the cart to see the items added.
4. Remove items from the cart if needed.
5. Check out to see the total cost of your purchases.


## License

This project is licensed under the MIT License.


Enjoy shopping with the Smart Shopping Cart Application!
