use SampleDB;

CREATE TABLE Products (
  ProductId INT IDENTITY(1,1) PRIMARY KEY,
  ProductName VARCHAR(100) NOT NULL,
  UnitPrice DECIMAL NOT NULL,
  StockQuantity INT NOT NULL,
  SupplierName VARCHAR(50),
  Weight DECIMAL,
);

Create Table AdminInfo(
  AdminId Int Identity(1,1) Not null Primary Key,
  FirstName Varchar(30) Not null,
  LastName Varchar(30) Not null,
  UserName Varchar(30) Not null,
  Email Varchar(50) Not null,
  Password Varchar(20) Not null
);


INSERT INTO Products (ProductName, UnitPrice, StockQuantity, SupplierName, Weight)
VALUES
  ('Product1', 29.99, 100, 'SupplierA', 1.5),
  ('Product2', 19.99, 150, 'SupplierB', 2.0),
  ('Product3', 39.99, 80, 'SupplierC', 1.2),
  ('Product4', 49.99, 120, 'SupplierA', 1.8),
  ('Product5', 14.99, 200, 'SupplierB', 1.0);

  select * from Products;

  INSERT INTO AdminInfo (FirstName, LastName, UserName, Email, Password)
VALUES
  ('John', 'Doe', 'john_doe', 'john@example.com', '$admin@2024');

  select * from AdminInfo;


