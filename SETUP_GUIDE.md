# Order Management System - Complete Setup Guide

This guide provides step-by-step instructions to set up and deploy the Order Management System.

## Table of Contents
1. [Prerequisites](#prerequisites)
2. [Development Environment Setup](#development-environment-setup)
3. [Database Setup](#database-setup)
4. [Application Configuration](#application-configuration)
5. [Building and Running](#building-and-running)
6. [Production Deployment](#production-deployment)
7. [Testing](#testing)
8. [Troubleshooting](#troubleshooting)

## Prerequisites

### Required Software
- **Visual Studio 2017 or later** (Community, Professional, or Enterprise)
- **.NET Framework 4.7.2 SDK** or higher
- **SQL Server** (one of the following):
  - SQL Server 2016 or later (Full version)
  - SQL Server Express 2016 or later
  - SQL Server LocalDB (comes with Visual Studio)
- **IIS or IIS Express** (comes with Visual Studio)

### Optional Tools
- SQL Server Management Studio (SSMS) for database management
- Git for version control

## Development Environment Setup

### Step 1: Clone the Repository
```bash
git clone https://github.com/Akomder/OrderManagament.git
cd OrderManagament
```

### Step 2: Open Solution in Visual Studio
1. Open Visual Studio
2. File → Open → Project/Solution
3. Navigate to the cloned directory
4. Select `OrderManagament.sln`
5. Wait for Visual Studio to load the solution

### Step 3: Restore NuGet Packages
Visual Studio should automatically restore NuGet packages. If not:

**Option 1: Visual Studio**
- Right-click on the solution in Solution Explorer
- Select "Restore NuGet Packages"

**Option 2: Package Manager Console**
```powershell
Update-Package -reinstall
```

### Step 4: Build the Solution
1. Build → Build Solution (or press Ctrl+Shift+B)
2. Verify that the build completes without errors

## Database Setup

### Option 1: Using SQL Server Management Studio (SSMS)

#### Step 1: Connect to SQL Server
1. Open SQL Server Management Studio
2. Connect to your SQL Server instance
   - Server name: `(LocalDb)\MSSQLLocalDB` (for LocalDB)
   - Or: `.\SQLEXPRESS` (for SQL Server Express)
   - Or: Your SQL Server instance name

#### Step 2: Create Database
```sql
CREATE DATABASE OrderManagement;
GO
```

#### Step 3: Execute SQL Script
1. Open the `Database.sql` file from the project root
2. Ensure you're connected to the OrderManagement database
3. Execute the script (F5)
4. Verify that all tables and sample data are created

### Option 2: Using Visual Studio

#### Step 1: Open SQL Server Object Explorer
1. View → SQL Server Object Explorer
2. Expand your SQL Server instance

#### Step 2: Create Database
1. Right-click on "Databases"
2. Select "Add New Database"
3. Name it "OrderManagement"

#### Step 3: Execute SQL Script
1. Right-click on the OrderManagement database
2. Select "New Query"
3. Copy and paste contents from `Database.sql`
4. Execute the script

### Verify Database Setup
Run this query to verify tables were created:
```sql
USE OrderManagement;
GO

SELECT TABLE_NAME 
FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_NAME;
```

You should see: Agents, OrderDetails, Orders, Products, Users

## Application Configuration

### Step 1: Update Connection String

Open `OrderManagementWeb/Web.config` and update the connection string:

**For LocalDB (default):**
```xml
<connectionStrings>
  <add name="OrderManagementEntities" 
       connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=OrderManagement;Integrated Security=True;MultipleActiveResultSets=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

**For SQL Server Express:**
```xml
<connectionStrings>
  <add name="OrderManagementEntities" 
       connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=OrderManagement;Integrated Security=True;MultipleActiveResultSets=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

**For SQL Server with SQL Authentication:**
```xml
<connectionStrings>
  <add name="OrderManagementEntities" 
       connectionString="Data Source=YOUR_SERVER;Initial Catalog=OrderManagement;User ID=YOUR_USERNAME;Password=YOUR_PASSWORD;MultipleActiveResultSets=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

### Step 2: Configure SSL (Optional for Development)

For development, you may want to disable SSL requirement:

In `Web.config`, change:
```xml
<forms loginUrl="~/Account/Login" timeout="2880" requireSSL="true" />
```

To:
```xml
<forms loginUrl="~/Account/Login" timeout="2880" requireSSL="false" />
```

**Important:** Keep requireSSL="true" for production!

### Step 3: Enable Debug Mode for Development

For development, enable debug mode in `Web.config`:
```xml
<compilation debug="true" targetFramework="4.7.2" />
```

Change to `debug="false"` for production deployment.

## Building and Running

### Step 1: Set Startup Project
1. Right-click on "OrderManagementWeb" project
2. Select "Set as StartUp Project"

### Step 2: Run the Application
1. Press F5 (Debug) or Ctrl+F5 (Run without debugging)
2. The application should open in your default browser
3. You should see the login page

### Step 3: Login
Use the default credentials:
- **Username:** admin
- **Password:** 123456

## Production Deployment

### Step 1: Prepare for Deployment

#### 1.1 Update Web.config for Production
```xml
<!-- Set debug to false -->
<compilation debug="false" targetFramework="4.7.2" />

<!-- Enable SSL requirement -->
<forms loginUrl="~/Account/Login" timeout="2880" requireSSL="true" />

<!-- Enable custom errors -->
<customErrors mode="On" defaultRedirect="~/Home/Index" />
```

#### 1.2 Update Connection String
Use production database connection string with proper credentials.

### Step 2: Publish to IIS

#### 2.1 Using Visual Studio Publish
1. Right-click on "OrderManagementWeb" project
2. Select "Publish"
3. Choose target:
   - **IIS, FTP, etc.** for custom deployment
   - **Folder** for file system deployment
   - **Azure** for Azure App Service

4. Configure publish settings:
   - **Configuration:** Release
   - **Target Framework:** .NET Framework 4.7.2
   - **Target Runtime:** win-x64 (or appropriate)

5. Click "Publish"

#### 2.2 Manual Deployment to IIS

**Build the Application:**
1. Build → Publish or use MSBuild:
```bash
msbuild OrderManagementWeb.csproj /p:Configuration=Release /p:DeployOnBuild=true
```

**Configure IIS:**
1. Open IIS Manager
2. Create new Application Pool:
   - Name: OrderManagement
   - .NET CLR Version: .NET CLR Version v4.0
   - Managed Pipeline Mode: Integrated

3. Create new Website or Application:
   - Site name: OrderManagement
   - Application pool: OrderManagement
   - Physical path: [Path to published files]
   - Binding: http/https, port 80/443

4. Set Application Pool Identity with database permissions

**Configure Database Permissions:**
Grant database access to the IIS application pool identity:
```sql
USE OrderManagement;
GO

CREATE USER [IIS APPPOOL\OrderManagement] FOR LOGIN [IIS APPPOOL\OrderManagement];
GO

ALTER ROLE db_datareader ADD MEMBER [IIS APPPOOL\OrderManagement];
ALTER ROLE db_datawriter ADD MEMBER [IIS APPPOOL\OrderManagement];
GO
```

### Step 3: SSL Certificate Setup (Production)

1. Obtain SSL certificate (Let's Encrypt, purchased, or self-signed for testing)
2. Install certificate in IIS
3. Update site binding to use HTTPS
4. Redirect HTTP to HTTPS in Web.config:

```xml
<system.webServer>
  <rewrite>
    <rules>
      <rule name="HTTPS Redirect" stopProcessing="true">
        <match url="(.*)" />
        <conditions>
          <add input="{HTTPS}" pattern="^OFF$" />
        </conditions>
        <action type="Redirect" url="https://{HTTP_HOST}/{R:1}" redirectType="Permanent" />
      </rule>
    </rules>
  </rewrite>
</system.webServer>
```

## Testing

### Test Scenarios

#### 1. Authentication
- [x] Login with valid credentials
- [x] Login with invalid credentials
- [x] Logout
- [x] Session persistence
- [x] Redirect to login when not authenticated

#### 2. Product Management
- [x] Create new product
- [x] Edit existing product
- [x] Deactivate product
- [x] Search products
- [x] Validate required fields
- [x] Validate unique product code

#### 3. Agent Management
- [x] Create new agent
- [x] Edit existing agent
- [x] Deactivate agent
- [x] Search agents
- [x] Validate email format
- [x] Validate phone format
- [x] Validate unique agent code

#### 4. Order Management
- [x] Create order with single item
- [x] Create order with multiple items
- [x] Edit existing order
- [x] Add/remove order items dynamically
- [x] Verify price auto-population
- [x] Verify total calculations
- [x] Filter orders by date, agent, status
- [x] Print order invoice

#### 5. Reports
- [x] Best Selling Items report
- [x] Customer Purchases report
- [x] Purchase Summary report
- [x] Date range filtering
- [x] Data accuracy

## Troubleshooting

### Database Connection Issues

**Error: "Login failed for user"**
- Verify SQL Server is running
- Check connection string credentials
- Verify database exists
- Check SQL Server authentication mode (Windows/Mixed)

**Error: "Cannot open database"**
- Ensure database exists
- Run Database.sql script
- Check user permissions

### Build Errors

**Error: "Could not find package"**
Solution:
```powershell
# In Package Manager Console
Update-Package -reinstall
```

**Error: "The type or namespace name could not be found"**
Solution:
- Clean solution (Build → Clean Solution)
- Rebuild solution (Build → Rebuild Solution)
- Verify all project references

### Runtime Errors

**Error: 404 - Page not found**
- Verify routing configuration in RouteConfig.cs
- Check controller and action names
- Ensure views are in correct folders

**Error: "Invalid Model State"**
- Check validation attributes on models
- Verify form field names match model properties
- Check for JavaScript errors in browser console

**Error: "CSRF token validation failed"**
- Ensure @Html.AntiForgeryToken() is in forms
- Verify ValidateAntiForgeryToken attribute on POST actions
- Check if anti-forgery token is being sent in AJAX calls

### Performance Issues

**Slow page loading**
- Enable output caching
- Optimize LINQ queries
- Add database indexes
- Enable bundling and minification

**Slow database queries**
- Check for missing indexes
- Use Include() for eager loading in Entity Framework
- Avoid N+1 query problems

## Support and Maintenance

### Logging

Add logging for troubleshooting:

1. Install NLog or log4net via NuGet
2. Configure logging in Web.config
3. Add logging to controllers and services

Example:
```csharp
private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

public ActionResult Index()
{
    try
    {
        Logger.Info("Loading product index");
        // Your code
    }
    catch (Exception ex)
    {
        Logger.Error(ex, "Error loading products");
        throw;
    }
}
```

### Backup and Recovery

**Database Backup:**
```sql
BACKUP DATABASE OrderManagement 
TO DISK = 'C:\Backups\OrderManagement_backup.bak'
WITH FORMAT, NAME = 'OrderManagement Full Backup';
```

**Database Restore:**
```sql
RESTORE DATABASE OrderManagement
FROM DISK = 'C:\Backups\OrderManagement_backup.bak'
WITH REPLACE;
```

### Monitoring

Monitor these metrics:
- Application errors and exceptions
- Database connection pool
- Response times
- Failed login attempts
- User sessions

## Additional Resources

- [ASP.NET MVC Documentation](https://docs.microsoft.com/en-us/aspnet/mvc/)
- [Entity Framework 6 Documentation](https://docs.microsoft.com/en-us/ef/ef6/)
- [SQL Server Documentation](https://docs.microsoft.com/en-us/sql/)
- [IIS Documentation](https://docs.microsoft.com/en-us/iis/)

## Contact and Support

For issues or questions:
- Check this guide's troubleshooting section
- Review the main README.md
- Check project documentation
- Contact the development team

---

**Version:** 1.0  
**Last Updated:** December 2025
