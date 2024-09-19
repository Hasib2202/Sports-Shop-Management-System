# Sports Shop Management Project

This is a C# desktop application built to manage a sports shop, offering functionalities such as user management, product management, sales handling, and order processing. The project utilizes Microsoft SQL Server as the backend for data storage and retrieval.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Project Structure](#project-structure)
- [Requirements](#requirements)
- [Setup Instructions](#setup-instructions)
- [Usage](#usage)
- [Database Design](#database-design)
- [Contributing](#contributing)
- [License](#license)

## Overview

The **Sports Shop Management** project provides an all-in-one solution for managing users, products, and sales operations in a sports shop. It features an admin interface for user and product management, and a seller interface for handling sales and generating cash memos. The application supports role-based access control where admins can add/edit/remove products and users, while sellers can process orders and view messages.

## Features

### Admin Features
- **User Management**: Add, edit, and remove users (Admins and Sellers).
- **Product Management**: Add, edit, and remove products in the inventory.
- **View User List**: View the list of users and their details.
- **Sales Tracking**: View and manage sales data.

### Seller Features
- **Order Processing**: Process customer orders and generate cash memos.
- **Messages**: Send and receive messages between sellers and admins.
- **View Products**: View product details and availability.

### Common Features
- **Login**: Secure login system with role-based navigation.
- **Database Connectivity**: Seamless connection with Microsoft SQL Server for managing data.

## Project Structure

The project is structured as follows, containing UI components, user controls, and logic files for managing data and user interactions.

- **AddNewUserUC.cs**: Handles adding new users.
- **AddProductUC.cs**: Handles adding new products.
- **AdminHome.cs**: Admin dashboard for managing users, products, and sales.
- **CashMemo.cs**: Generates cash memos for completed orders.
- **DataAccess.cs**: Manages database operations such as connecting, inserting, updating, and deleting data.
- **EditProductUC.cs**: Handles editing existing product details.
- **EditUserUC.cs**: Handles editing user details.
- **Login.cs**: Login form and authentication logic.
- **MessageUC.cs**: Manages messages between admins and sellers.
- **OrderUC.cs**: Manages order processing and sales.
- **ProductUC.cs**: Displays product list and details.
- **RemoveProductUC.cs**: Handles product deletion.
- **RemoveUserUC.cs**: Handles user deletion.
- **SalesAdminUC.cs**: Displays sales data for admins.
- **SellerHome.cs**: Seller dashboard for handling orders and sales.
- **SellerMessageUC.cs**: Manages messages for sellers.
- **UserlistUC.cs**: Displays the list of users.

## Requirements

To run this project, you need:

- **Windows OS** (for desktop application)
- **Visual Studio** (for development and running the project)
- **Microsoft SQL Server** (for database management)
- **.NET Framework 4.7.2** or higher
- **SQL Server Management Studio (SSMS)** for managing the database

## Setup Instructions

1. **Clone the repository**:
   Clone this project to your local machine using the following command:
   ```bash
   git clone <repository-link>
   ```

2. **Open the project**:
   Open the `SportsShopManagement.sln` file in Visual Studio.

3. **Database setup**:
   - Use Microsoft SQL Server to create a new database.
   - Execute the SQL script provided in the `App.config` or manually in SQL Server Management Studio to set up the necessary tables for the application.

4. **Configure the connection string**:
   - Update the connection string in the `App.config` file to match your SQL Server instance.
   ```xml
   <connectionStrings>
     <add name="DBConnection" connectionString="Data Source=YourServerName;Initial Catalog=YourDatabaseName;Integrated Security=True;" providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

5. **Run the project**:
   Build and run the project from Visual Studio.

## Usage

### Admin Actions:
1. **Login**: Use the admin credentials to log into the system.
2. **Manage Users**: Add new users, update or delete existing users.
3. **Manage Products**: Add, edit, or remove products from the inventory.
4. **View Sales**: Access and track the sales history of the shop.
5. **Messages**: Send and receive messages from sellers.

### Seller Actions:
1. **Login**: Use the seller credentials to log into the system.
2. **Process Orders**: Enter order details and generate a cash memo.
3. **View Products**: Check the available products.
4. **Messages**: Send and receive messages from the admin.

## Database Design

The database contains multiple tables to manage users, products, orders, and sales data.

### Key Tables:
- **Users**: Stores user information like user ID, username, role, and password.
- **Products**: Stores product details such as product ID, name, quantity, and price.
- **Orders**: Stores details of customer orders.
- **Sales**: Logs sales transactions and cash memo generation.

The database is connected to the C# application through `DataAccess.cs`, which handles queries and operations like inserting, updating, and fetching data from the database.

## Contributing

Feel free to fork this project and submit pull requests. If you find any bugs or have suggestions, feel free to open an issue.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
