CREATE TABLE Customers (Customer_Code int identity(1,1), 
Fam VARCHAR (20) NOT NULL,
Name VARCHAR(20) NOT NULL,
Surname VARCHAR (20) NOT NULL,
Phone VARCHAR (10),
Receipt BIT,
Bank VARCHAR (60),
Account VARCHAR (20),
CONSTRAINT PK1 PRIMARY KEY(Customer_Code))
