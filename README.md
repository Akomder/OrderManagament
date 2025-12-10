# OrderManagament

An Order Management System built with C# Windows Forms using a 3-tier architecture (UI, BLL, DAL) and Entity Framework for database operations.

## Project Structure

- **WinFormUI** - Windows Forms user interface layer
- **BLL** - Business Logic Layer
- **DAL** - Data Access Layer (Entity Framework)
- **Database.sql** - SQL Server database schema and sample data

## Prerequisites

Before running this project, ensure you have the following installed: 

1. **Visual Studio 2017 or later**
   - Download from [Visual Studio Downloads](https://visualstudio.microsoft.com/downloads/)
   - Ensure . NET Framework 4.7.2 is installed

2. **SQL Server**
   - SQL Server 2016 or later (Express Edition is sufficient)
   - SQL Server Management Studio (SSMS) - Optional but recommended

3. **NuGet Package Manager**
   - Comes pre-installed with Visual Studio

## Step-by-Step Setup Instructions

### Step 1: Clone the Repository

```bash
git clone https://github.com/Akomder/OrderManagament.git
cd OrderManagament
```

### Step 2: Set Up the Database

1. **Open SQL Server Management Studio (SSMS)** or any SQL client

2. **Connect to your SQL Server instance**

3. **Create a new database:**
   ```sql
   CREATE DATABASE OrderManagamentDB;
   GO
   ```

4. **Execute the Database.sql script:**
   - Open the `Database.sql` file from the project root
   - Select the `OrderManagamentDB` database
   - Execute the entire script to create tables and insert sample data

5. **Verify the database setup:**
   ```sql
   USE OrderManagamentDB;
   GO
   
   -- Check if tables were created
   SELECT * FROM Users;
   SELECT * FROM Agent;
   SELECT * FROM Item;
   SELECT * FROM [Order];
   SELECT * FROM OrderDetail;
   ```

### Step 3: Configure Database Connection

1. **Locate the connection string configuration**
   - The connection string is typically in `DAL` or `WinFormUI` project
   - Look for `App.config` or a connection string class

2. **Update the connection string** with your SQL Server details:
   ```xml
   <connectionStrings>
     <add name="OrderManagamentDB" 
          connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=OrderManagamentDB;Integrated Security=True" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```
   
   Replace `YOUR_SERVER_NAME` with:
   - `localhost` or `(localdb)\MSSQLLocalDB` for local SQL Server
   - Your specific server name if using a remote instance

### Step 4: Open the Solution in Visual Studio

1. **Double-click** the `OrderManagament.sln` file, or

2. **Open Visual Studio** and select: 
   - File → Open → Project/Solution
   - Navigate to the folder and select `OrderManagament.sln`

### Step 5: Restore NuGet Packages

1. In Visual Studio, right-click on the **Solution** in Solution Explorer

2. Select **Restore NuGet Packages**

3. Wait for the packages (especially Entity Framework) to download and install

### Step 6: Build the Solution

1. In Visual Studio, select **Build → Build Solution** (or press `Ctrl+Shift+B`)

2. Ensure there are no build errors in the Output window

3. All three projects (WinFormUI, BLL, DAL) should build successfully

### Step 7: Set Startup Project

1. Right-click on **WinFormUI** project in Solution Explorer

2. Select **Set as Startup Project**

### Step 8: Run the Application

1. Press **F5** or click the **Start** button in Visual Studio

2. The Windows Forms application should launch

## Login Credentials

Use the following sample credentials to log in (from the Database.sql sample data):

| Username | Email | Password |
|----------|-------|----------|
| admin | admin@gmail.com | 123456 |
| akhom | akhom@gmail.com | 5230076 |
| tan | tan@gmail.com | 5230017 |
| kevin | kevin@gmail.com | 222222 |
| peter | peter@mail.com | 111111 |

## Database Schema

The application uses the following tables:

- **Users** - User authentication and management
- **Agent** - Agent information and addresses
- **Item** - Product catalog with sizes and prices
- **Order** - Order headers with dates and agent references
- **OrderDetail** - Order line items with quantities and amounts

## Troubleshooting

### Connection String Issues
- Verify your SQL Server instance is running
- Check if SQL Server Browser service is enabled
- Ensure Windows Authentication or SQL Authentication is properly configured

### Entity Framework Errors
- Rebuild the solution after restoring NuGet packages
- Check that Entity Framework 6.x is properly installed in the DAL project

### Build Errors
- Ensure . NET Framework 4.7.2 is installed
- Clean the solution (Build → Clean Solution) and rebuild

## Technology Stack

- **Language:** C# (. NET Framework 4.7.2)
- **UI Framework:** Windows Forms
- **ORM:** Entity Framework 6
- **Database:** SQL Server
- **Architecture:** 3-Tier (UI → BLL → DAL)

## Project Architecture

```
OrderManagament/
├── WinFormUI/          # Presentation Layer (Windows Forms)
├── BLL/                # Business Logic Layer
├── DAL/                # Data Access Layer (Entity Framework)
├── Database.sql        # Database schema and sample data
└── OrderManagament.sln # Visual Studio Solution
```

## Support

For issues or questions, please open an issue on the [GitHub repository](https://github.com/Akomder/OrderManagament/issues).
