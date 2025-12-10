-- Users table for authentication
CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL DEFAULT 'User'
);

-- Products table (renamed from Item to match requirements)
CREATE TABLE Products (
    ProductId INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    ProductCode NVARCHAR(50) NOT NULL UNIQUE,
    Price DECIMAL(18,2) NOT NULL,
    Stock INT NOT NULL DEFAULT 0,
    Description NVARCHAR(500),
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE()
);

-- Agents table
CREATE TABLE Agents (
    AgentId INT IDENTITY(1,1) PRIMARY KEY,
    AgentName NVARCHAR(100) NOT NULL,
    AgentCode NVARCHAR(50) NOT NULL UNIQUE,
    Email NVARCHAR(100),
    Phone NVARCHAR(20),
    Address NVARCHAR(200),
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE()
);

-- Orders table
CREATE TABLE Orders (
    OrderId INT IDENTITY(1,1) PRIMARY KEY,
    OrderNumber NVARCHAR(50) NOT NULL UNIQUE,
    OrderDate DATETIME NOT NULL DEFAULT GETDATE(),
    AgentId INT NOT NULL,
    TotalAmount DECIMAL(18,2) NOT NULL DEFAULT 0,
    Status NVARCHAR(20) NOT NULL DEFAULT 'Pending',
    CreatedBy INT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (AgentId) REFERENCES Agents(AgentId),
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserId)
);

-- OrderDetails table
CREATE TABLE OrderDetails (
    OrderDetailId INT IDENTITY(1,1) PRIMARY KEY,
    OrderId INT NOT NULL,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(18,2) NOT NULL,
    TotalPrice DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (OrderId) REFERENCES Orders(OrderId) ON DELETE CASCADE,
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);


-- Sample data

-- Insert Users
INSERT INTO Users (Username, Password, FullName, Role) VALUES
('admin', '123456', 'Administrator', 'Admin'),
('john', '123456', 'John Doe', 'User'),
('jane', '123456', 'Jane Smith', 'User');

-- Insert Products
INSERT INTO Products (ProductName, ProductCode, Price, Stock, Description, IsActive, CreatedDate) VALUES
('T-Shirt Medium', 'TSHIRT-M', 120000, 100, 'Cotton T-Shirt Size M', 1, GETDATE()),
('T-Shirt Large', 'TSHIRT-L', 125000, 100, 'Cotton T-Shirt Size L', 1, GETDATE()),
('T-Shirt XL', 'TSHIRT-XL', 130000, 100, 'Cotton T-Shirt Size XL', 1, GETDATE()),
('Jeans 32', 'JEANS-32', 350000, 50, 'Denim Jeans Size 32', 1, GETDATE()),
('Jeans 34', 'JEANS-34', 360000, 50, 'Denim Jeans Size 34', 1, GETDATE()),
('Shorts Medium', 'SHORTS-M', 150000, 80, 'Cotton Shorts Size M', 1, GETDATE()),
('Shorts Large', 'SHORTS-L', 155000, 80, 'Cotton Shorts Size L', 1, GETDATE()),
('Jacket Medium', 'JACKET-M', 500000, 30, 'Winter Jacket Size M', 1, GETDATE()),
('Jacket Large', 'JACKET-L', 520000, 30, 'Winter Jacket Size L', 1, GETDATE()),
('Cap', 'CAP-FREE', 70000, 150, 'Baseball Cap One Size', 1, GETDATE()),
('Socks', 'SOCKS-FREE', 20000, 200, 'Cotton Socks One Size', 1, GETDATE()),
('Shoes 42', 'SHOES-42', 800000, 40, 'Sports Shoes Size 42', 1, GETDATE()),
('Shoes 43', 'SHOES-43', 820000, 40, 'Sports Shoes Size 43', 1, GETDATE()),
('Bag Medium', 'BAG-M', 250000, 60, 'Backpack Medium Size', 1, GETDATE()),
('Bag Large', 'BAG-L', 300000, 60, 'Backpack Large Size', 1, GETDATE());

-- Insert Agents
INSERT INTO Agents (AgentName, AgentCode, Email, Phone, Address, IsActive, CreatedDate) VALUES
('Agent A', 'AGT-001', 'agenta@mail.com', '0901234567', 'District 1', 1, GETDATE()),
('Agent B', 'AGT-002', 'agentb@mail.com', '0901234568', 'District 3', 1, GETDATE()),
('Agent C', 'AGT-003', 'agentc@mail.com', '0901234569', 'District 5', 1, GETDATE()),
('Agent D', 'AGT-004', 'agentd@mail.com', '0901234570', 'District 7', 1, GETDATE()),
('Agent E', 'AGT-005', 'agente@mail.com', '0901234571', 'District 4', 1, GETDATE()),
('Agent F', 'AGT-006', 'agentf@mail.com', '0901234572', 'Thu Duc', 1, GETDATE()),
('Agent G', 'AGT-007', 'agentg@mail.com', '0901234573', 'Go Vap', 1, GETDATE()),
('Agent H', 'AGT-008', 'agenth@mail.com', '0901234574', 'Tan Binh', 1, GETDATE()),
('Agent I', 'AGT-009', 'agenti@mail.com', '0901234575', 'Tan Phu', 1, GETDATE()),
('Agent J', 'AGT-010', 'agentj@mail.com', '0901234576', 'District 10', 1, GETDATE()),
('Agent K', 'AGT-011', 'agentk@mail.com', '0901234577', 'District 12', 1, GETDATE()),
('Agent L', 'AGT-012', 'agentl@mail.com', '0901234578', 'District 2', 1, GETDATE()),
('Agent M', 'AGT-013', 'agentm@mail.com', '0901234579', 'District 6', 1, GETDATE()),
('Agent N', 'AGT-014', 'agentn@mail.com', '0901234580', 'District 8', 1, GETDATE()),
('Agent O', 'AGT-015', 'agento@mail.com', '0901234581', 'Nha Be', 1, GETDATE());

-- Insert Sample Orders
INSERT INTO Orders (OrderNumber, OrderDate, AgentId, TotalAmount, Status, CreatedBy, CreatedDate) VALUES
('ORD-2025-001', '2025-01-10', 1, 250000, 'Completed', 1, '2025-01-10'),
('ORD-2025-002', '2025-01-12', 2, 480000, 'Completed', 1, '2025-01-12'),
('ORD-2025-003', '2025-01-13', 3, 720000, 'Processing', 1, '2025-01-13'),
('ORD-2025-004', '2025-01-15', 4, 1500000, 'Pending', 1, '2025-01-15');

-- Insert Sample Order Details
INSERT INTO OrderDetails (OrderId, ProductId, Quantity, UnitPrice, TotalPrice) VALUES
(1, 1, 2, 120000, 240000),
(1, 11, 1, 20000, 20000),
(2, 4, 1, 350000, 350000),
(2, 10, 2, 70000, 140000),
(3, 8, 1, 500000, 500000),
(3, 12, 1, 800000, 800000),
(4, 2, 3, 125000, 375000),
(4, 6, 5, 150000, 750000),
(4, 15, 1, 300000, 300000);

