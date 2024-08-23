# DeliverySystem

**DeliverySystem** is a comprehensive order and delivery management system designed for restaurants. It provides two separate panels for customers and restaurant administrators, allowing them to manage orders, view menus, and perform various other actions related to restaurant operations.

## Features

### Restaurant Administrator Panel
- **Add Menu Items:** Administrators can add new items to the restaurant's menu, specifying details such as name, description, and price.
- **Remove Menu Items:** Administrators can remove items from the menu when they are no longer available.
- **View Orders:** Administrators can view all orders placed by customers.
- **Process Orders:** Administrators can update the status of orders, including marking them as "Sent" once they are ready for delivery.

### Customer Panel
- **View Previous Orders:** Customers can view their past orders.
- **View Restaurant Menu:** Customers can browse the restaurant's menu to see available items.
- **View Cart Items:** Customers can add items to their carts and then see the cart items from "Cart" section
- **Place Orders:** Customers can select items from the menu, add them to their cart, and place an order.

### Order Page
- **Select Products:** Customers can choose products from the restaurant's menu and add them to their cart.
- **Confirm Order:** Customers can confirm their orders, which will then be sent to the restaurant administrator's panel.
- **Order Processing:** Once an order is confirmed, the restaurant administrator can prepare the order and mark it as "Sent" when it is dispatched.

## Technical Requirements

- **User Authentication:** Login records for both roles (Customer and Restaurant Administrator) are stored in a database. Each user only sees their respective panel.
- **Menu Management:** The menu includes functionalities for adding and updating products, with each product containing attributes such as name, description, and price.
- **Order Information:** Orders contain details such as product names, quantities, total price, and customer information. Order status can also be viewed.
- **Session Management:** Cart information for customers is maintained using backend session management, allowing customers to see their cart items even after logging in and out.
- **Responsive UI:** The project uses a third-party theme for improved visual appeal.

## Code Principles

- **SOLID Principles:** The project adheres to SOLID principles, ensuring a clean and maintainable codebase.
- **Dependency Injection:** Dependencies are injected, and an IoC container is used to manage them.
- **Clean Architecture:** The architecture is clear and understandable, with the domain layer remaining independent of external dependencies.
- **Code Documentation:** Business logic is well-documented with comments to explain key operations and decisions.

## Installation

To set up this project locally, follow these steps:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/yourusername/DeliverySystem.git
   cd DeliverySystem
2. **Database Setup:**
- Ensure you have SQL Server installed.
- Update the connection string in `appsettings.json` with your database credentials.
- Run the provided SQL scripts in the `Database` folder to set up the database schema.
3. **Run Migrations (If using Entity Framework):**
   ```bash
   dotnet ef database update
4. **Build The Project:**
   ```bash
   dotnet build
5. **Run The Project:**
  dotnet run
6. **Access the Application:**
- Navigate to http://localhost:5000 in your browser.
- Use the login credentials provided in the database seed data to log in as a customer or administrator.

## Usage
**Administrator Panel**
- After logging in as an administrator, navigate to the Menu Management section to add, edit, or remove menu items.
- Go to the Order Management section to view and process customer orders.
- 
**Customer Panel**
- After logging in as a customer, browse the menu and add items to your cart.
- Review your cart and place an order when ready.
- View your previous orders in the Order History section.
- 
## Contributing
Contributions to this project are welcome! Please follow these steps to contribute:
1. **Fork the repository**
2. **Create a new branch for your feature or bug fix**
   ```bash
   git checkout -b feature/new-feature
3. **Commit your changes**
   ```bash
   git commit -m "Add new feature"
4. **Push to the branch**
   ```bash
   git push origin feature/new-feature
5. **Create a pull request on GitHub.**

## Contact
For any questions or suggestions, please feel free to reach out:
- Email: hilalsinemsayar@gmail.com
- GitHub: hilallsinem
