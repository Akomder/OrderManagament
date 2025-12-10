CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    UserName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100),
    Password NVARCHAR(100) NOT NULL,
    Lock BIT DEFAULT 0
);

CREATE TABLE Agent (
    AgentID INT IDENTITY(1,1) PRIMARY KEY,
    AgentName NVARCHAR(100) NOT NULL,
    Address NVARCHAR(200)
);

CREATE TABLE Item (
    ItemID INT IDENTITY(1,1) PRIMARY KEY,
    ItemName NVARCHAR(100) NOT NULL,
    Size NVARCHAR(20),
    UnitPrice DECIMAL(10,2) NOT NULL
);

CREATE TABLE [Order] (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    OrderDate DATE NOT NULL,
    AgentID INT NOT NULL,
    FOREIGN KEY (AgentID) REFERENCES Agent(AgentID)
);

CREATE TABLE OrderDetail (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    ItemID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitAmount DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES [Order](OrderID),
    FOREIGN KEY (ItemID) REFERENCES Item(ItemID)
);


--Sample data--

INSERT INTO Users (UserName, Email, Password, Lock) VALUES
('admin', 'admin@gmail.com', '123456', 0),
('akhom', 'akhom@gmail.com', '5230076', 1),
('tan', 'tan@gmail.com', '5230017', 2),
('kevin', 'kevin@gmail.com', '222222', 0),
('peter', 'peter@mail.com', '111111', 0),
('mary', 'mary@mail.com', '123456', 0),
('james', 'james@mail.com', '654321', 0),
('susan', 'susan@mail.com', '777777', 0),
('michael', 'michael@mail.com', '888888', 0),
('david', 'david@mail.com', '999999', 0),
('lucas', 'lucas@mail.com', '222222', 0),
('steve', 'steve@mail.com', '333333', 0),
('victor', 'victor@mail.com', '444444', 0),
('katie', 'katie@mail.com', '555555', 0),
('leo', 'leo@mail.com', '666666', 0);

INSERT INTO Agent (AgentName, Address) VALUES
('Agent A', 'District 1'),
('Agent B', 'District 3'),
('Agent C', 'District 5'),
('Agent D', 'District 7'),
('Agent E', 'District 4'),
('Agent F', 'Thu Duc'),
('Agent G', 'Go Vap'),
('Agent H', 'Tan Binh'),
('Agent I', 'Tan Phu'),
('Agent J', 'District 10'),
('Agent K', 'District 12'),
('Agent L', 'District 2'),
('Agent M', 'District 6'),
('Agent N', 'District 8'),
('Agent O', 'Nha Be');

INSERT INTO Item (ItemName, Size, UnitPrice) VALUES
('T-Shirt', 'M', 120000),
('T-Shirt', 'L', 125000),
('T-Shirt', 'XL', 130000),
('Jeans', '32', 350000),
('Jeans', '34', 360000),
('Shorts', 'M', 150000),
('Shorts', 'L', 155000),
('Jacket', 'M', 500000),
('Jacket', 'L', 520000),
('Cap', 'Free', 70000),
('Socks', 'Free', 20000),
('Shoes', '42', 800000),
('Shoes', '43', 820000),
('Bag', 'Medium', 250000),
('Bag', 'Large', 300000);

INSERT INTO [Order] (OrderDate, AgentID) VALUES
('2025-01-10', 1),
('2025-01-12', 2),
('2025-01-13', 3),
('2025-01-15', 4),
('2025-01-17', 5),
('2025-01-18', 6),
('2025-01-20', 7),
('2025-01-21', 8),
('2025-01-22', 9),
('2025-01-23', 10),
('2025-01-24', 11),
('2025-01-25', 12),
('2025-01-26', 13),
('2025-01-27', 14),
('2025-01-28', 15);

