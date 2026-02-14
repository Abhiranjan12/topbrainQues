CREATE DATABASE _2_TopBrain_Sales
use _2_TopBrain_Sales
go

CREATE TABLE CustomerMaster
(
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    CustomerPhone VARCHAR(20),
    CustomerCity VARCHAR(50)
)


CREATE TABLE SalesPersonsMaster
(
    SalesPersonID INT PRIMARY KEY,
    SalesPersonName VARCHAR(100)
)


CREATE TABLE ProductsMaster
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    UnitPrice DECIMAL(10,2)
)


CREATE TABLE OrdersMaster
(
    OrderID INT PRIMARY KEY,
    OrderDate DATE,
    CustomerID INT,
    SalesPersonID INT,
    FOREIGN KEY (CustomerID) REFERENCES CustomerMaster(CustomerID),
    FOREIGN KEY (SalesPersonID) REFERENCES SalesPersonsMaster(SalesPersonID)
)


CREATE TABLE OrderDetails
(
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (OrderID) REFERENCES OrdersMaster(OrderID),
    FOREIGN KEY (ProductID) REFERENCES ProductsMaster(ProductID)
)


------------------------Customer----------------------------
INSERT INTO CustomerMaster VALUES
(1,'Ravi Kumar','9876543210','Chennai'),
(2,'Priya Sharma','9123456789','Bangalore'),
(3,'John Peter','9988776655','Hyderabad')


------------------------SalesPerson-------------------------
INSERT INTO SalesPersonsMaster VALUES
(1,'Anitha'),
(2,'Suresh')


------------------------Product-----------------------------
INSERT INTO ProductsMaster VALUES
(1,'Laptop',5500.00),
(2,'Mouse',500.00),
(3,'Keyboard',300.00),
(4,'Monitor',1000.00)


------------------------Order-------------------------------
INSERT INTO OrdersMaster VALUES
(101,'2024-01-05',1,1),
(102,'2024-01-06',2,1),
(103,'2024-01-10',1,2),
(104,'2024-02-01',3,1),
(105,'2024-02-10',2,2)


------------------------Order_Details-----------------------
INSERT INTO OrderDetails VALUES
(1,101,1,1),
(2,101,2,2),
(3,102,3,1),
(4,102,2,1),
(5,103,1,1),
(6,104,4,1),
(7,104,2,1),
(8,105,1,1),
(9,105,3,1)


/*
Question 1 – Normalization (Design Thinking)
*/
select * from CustomerMaster;
select * from ProductsMaster;
select * from SalesPersonsMaster;
select * from OrderDetails;
select * from OrdersMaster;


/*
Question 2 – Third Highest Total Sales (Analytical Query)
*/
WITH OrderTotal AS
(
    SELECT
        o.OrderID,
        SUM(od.Quantity * p.UnitPrice) AS TotalSales
    FROM OrdersMaster o
    JOIN OrderDetails od ON o.OrderID = od.OrderID
    JOIN ProductsMaster p ON od.ProductID = p.ProductID
    GROUP BY o.OrderID
)
SELECT TotalSales
FROM OrderTotal
ORDER BY TotalSales DESC
OFFSET 2 ROWS
FETCH NEXT 1 ROW ONLY



/*
Question 3 – GROUP BY & HAVING (Business Rule)
*/
SELECT SP.SalesPersonName, COUNT(PM.ProductID) AS 'TOTAL PRODUCT SOLD',SUM(OD.Quantity * PM.UnitPrice) AS 'TOTAL SOLD'
FROM [dbo].[SalesPersonsMaster] SP
JOIN OrdersMaster OM ON SP.SalesPersonID = OM.SalesPersonID
JOIN OrderDetails OD ON OM.OrderID = OD.OrderID
JOIN ProductsMaster PM ON OD.ProductID = PM.ProductID
GROUP BY SP.SalesPersonName
HAVING  SUM(OD.Quantity * PM.UnitPrice) > 9000;



/*
QUESTION 5 – STRING & DATE FUNCTIONS
*/
SELECT
    UPPER(C.CustomerName) AS CustomerName,
    MONTH(OM.OrderDate) AS OrderMonth,
    OM.OrderDate
FROM CustomerMaster C
JOIN OrdersMaster OM ON C.CustomerID = OM.CustomerID
WHERE MONTH(OM.OrderDate) = 1;

