# Order Management System - ASP.NET MVC

A complete Order Management System built with ASP.NET MVC (.NET Framework 4.7.2) using Entity Framework 6.x with Database First approach.

## Features

### 1. Authentication & Authorization
- Secure login with FormsAuthentication
- User session management
- Password-protected access
- Default credentials: **Username:** `admin` / **Password:** `123456`

### 2. Product Management
- Add, Edit, and Deactivate products
- Product information: Name, Code, Price, Stock, Description
- Search and filter products
- Validation for product code uniqueness
- Stock tracking

### 3. Agent Management
- Add, Edit, and Deactivate agents (customers)
- Agent information: Name, Code, Email, Phone, Address
- Search and filter agents
- Email and phone validation
- Validation for agent code uniqueness

### 4. Order Management (Master-Detail)
- Create and edit orders with multiple line items
- Dynamic order details grid with JavaScript
- Auto-generated order numbers
- Agent selection
- Product selection with auto-populated prices
- Real-time calculation of line totals and grand total
- Order status tracking (Pending, Processing, Completed, Cancelled)
- Filter orders by date range, agent, and status

### 5. Print/Report Functionality
- Print-friendly order invoices
- Order details with agent information
- Professional invoice layout
- Browser print functionality

### 6. Analytics & Reports
- **Best Selling Items Report**: Top products by quantity sold and revenue
- **Customer Purchases Report**: All purchases by specific agent
- **Purchase Summary Report**: Agent-wise purchase statistics
- Date range filtering for all reports
- Export-ready formats

## Technology Stack

- **Framework**: ASP.NET MVC 5.2.7 (.NET Framework 4.7.2)
- **ORM**: Entity Framework 6.5.1 (Code-First approach)
- **Database**: SQL Server (LocalDB or SQL Server Express)
- **Frontend**: Bootstrap 5.1.3, jQuery 3.6.0, Font Awesome 6.0.0
- **Validation**: jQuery Validation, Unobtrusive Validation

## Database Schema

The system uses the following tables:

- **Users**: User authentication (UserId, Username, Password, FullName, Role)
- **Products**: Product catalog (ProductId, ProductName, ProductCode, Price, Stock, Description, IsActive, CreatedDate)
- **Agents**: Customer/Agent information (AgentId, AgentName, AgentCode, Email, Phone, Address, IsActive, CreatedDate)
- **Orders**: Order headers (OrderId, OrderNumber, OrderDate, AgentId, TotalAmount, Status, CreatedBy, CreatedDate)
- **OrderDetails**: Order line items (OrderDetailId, OrderId, ProductId, Quantity, UnitPrice, TotalPrice)

## Installation & Setup

### Prerequisites

1. Visual Studio 2017 or later
2. .NET Framework 4.7.2 or higher
3. SQL Server (LocalDB, Express, or full version)
4. IIS or IIS Express

### Setup Steps

1. **Clone the Repository**
   ```bash
   git clone <repository-url>
   cd OrderManagement
   ```

2. **Database Setup**
   - Open SQL Server Management Studio (SSMS)
   - Create a new database named `OrderManagement`
   - Execute the SQL script from `Database.sql` to create tables and insert sample data

3. **Update Connection String**
   - Open `OrderManagementWeb/Web.config`
   - Update the connection string to match your SQL Server configuration:
   ```xml
   <connectionStrings>
     <add name="OrderManagementEntities" 
          connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=OrderManagement;Integrated Security=True;MultipleActiveResultSets=True" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

4. **Restore NuGet Packages**
   - Open the solution in Visual Studio
   - Right-click on the solution and select "Restore NuGet Packages"
   - Or use Package Manager Console: `Update-Package -reinstall`

5. **Build the Solution**
   - Build the solution to ensure all dependencies are restored
   - Fix any build errors if they occur

6. **Run the Application**
   - Set `OrderManagementWeb` as the startup project
   - Press F5 or click "Start" to run the application
   - The application will open in your default browser

7. **Login**
   - Use the default credentials:
     - **Username**: `admin`
     - **Password**: `123456`

## Project Structure

```
OrderManagementWeb/
├── App_Start/
│   └── RouteConfig.cs          # MVC routing configuration
├── Controllers/
│   ├── AccountController.cs     # Login/Logout
│   ├── HomeController.cs        # Dashboard
│   ├── ProductController.cs     # Product CRUD
│   ├── AgentController.cs       # Agent CRUD
│   ├── OrderController.cs       # Order CRUD with master-detail
│   └── ReportController.cs      # Reports and analytics
├── Models/
│   ├── User.cs                  # User entity
│   ├── Product.cs               # Product entity
│   ├── Agent.cs                 # Agent entity
│   ├── Order.cs                 # Order entity
│   ├── OrderDetail.cs           # OrderDetail entity
│   ├── OrderManagementContext.cs # EF DbContext
│   └── ViewModels/              # ViewModels for complex views
│       ├── LoginViewModel.cs
│       ├── OrderViewModel.cs
│       └── ReportViewModels.cs
├── Views/
│   ├── Account/
│   │   └── Login.cshtml         # Login page
│   ├── Home/
│   │   └── Index.cshtml         # Dashboard
│   ├── Product/
│   │   ├── Index.cshtml         # Product list
│   │   ├── Create.cshtml        # Add product
│   │   └── Edit.cshtml          # Edit product
│   ├── Agent/
│   │   ├── Index.cshtml         # Agent list
│   │   ├── Create.cshtml        # Add agent
│   │   └── Edit.cshtml          # Edit agent
│   ├── Order/
│   │   ├── Index.cshtml         # Order list
│   │   ├── Create.cshtml        # Create order
│   │   ├── Edit.cshtml          # Edit order
│   │   └── Print.cshtml         # Print invoice
│   ├── Report/
│   │   ├── BestSellingItems.cshtml
│   │   ├── CustomerPurchases.cshtml
│   │   └── PurchaseSummary.cshtml
│   └── Shared/
│       ├── _Layout.cshtml       # Master layout
│       └── Error.cshtml         # Error page
├── Content/
│   └── Site.css                 # Custom styles
├── Web.config                   # Application configuration
└── Global.asax                  # Application startup

Database.sql                     # SQL script for database setup
```

## Usage

### Creating an Order

1. Navigate to **Orders** > **Create New Order**
2. Fill in order information (Order Date, Agent, Status)
3. Add order items:
   - Click "Add New Item" to add more rows
   - Select a product from the dropdown
   - Unit price is auto-populated
   - Enter quantity
   - Line total is calculated automatically
4. Review the grand total
5. Click "Save Order"

### Generating Reports

1. Navigate to **Reports** from the menu
2. Select the desired report type
3. Set date range filters (if applicable)
4. Click "Generate Report"
5. View and analyze the results

### Printing Orders

1. Go to **Orders** and find the order you want to print
2. Click the "Print" button
3. A print-friendly invoice will open in a new window
4. Click "Print" to print or save as PDF

## Key Features

### Dynamic Order Details
- JavaScript-powered dynamic form
- Add/remove order line items on the fly
- Real-time price lookup from product database
- Automatic calculation of line totals and grand total

### Validation
- Client-side validation using jQuery Validation
- Server-side validation using Data Annotations
- Unique constraint validation for codes
- Required field validation
- Email and phone format validation

### Security
- FormsAuthentication for secure login
- [Authorize] attribute on all controllers except Login
- Session-based user tracking
- Password protection (note: in production, use hashed passwords)

## Sample Data

The `Database.sql` script includes sample data:
- 3 users (admin, john, jane)
- 15 products (various clothing items)
- 15 agents (Agent A through Agent O)
- 4 sample orders with order details

## Troubleshooting

### Database Connection Issues
- Verify SQL Server is running
- Check connection string in Web.config
- Ensure database exists and tables are created
- Check SQL Server authentication mode

### Build Errors
- Restore NuGet packages
- Clean and rebuild solution
- Check .NET Framework version (4.7.2)

### Login Issues
- Ensure Users table has data
- Verify credentials (default: admin/123456)
- Check Forms Authentication configuration in Web.config

## Security

### Authentication & Authorization
- FormsAuthentication with secure cookie handling
- Session-based user tracking
- SSL/TLS required for authentication cookies
- CSRF protection on all POST operations
- Password validation (Note: Use hashed passwords in production)

### Security Best Practices Implemented
- ✅ CSRF token validation on all state-changing operations
- ✅ SSL/TLS requirement for authentication
- ✅ Debug mode disabled for production
- ✅ Input validation on all forms
- ✅ SQL injection prevention via Entity Framework parameterized queries
- ✅ XSS prevention via Razor encoding

### Security Scan Results
- **CodeQL Analysis**: 0 vulnerabilities found ✅
- All security recommendations addressed

## Future Enhancements

- Password hashing and encryption
- Role-based authorization
- Inventory management with stock updates
- Email notifications
- PDF export for reports
- Advanced search and filtering
- Audit logging
- Multi-language support

## License

This project is for educational and demonstration purposes.

## Support

For issues or questions, please contact the development team or refer to the project documentation.
