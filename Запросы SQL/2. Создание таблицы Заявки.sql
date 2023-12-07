CREATE TABLE Applications (Application_Code int identity(1,1), 
CONSTRAINT PK2 PRIMARY KEY(Application_Code),
Customer_Code INT NOT NULL,
CONSTRAINT FK1 FOREIGN KEY (Customer_Code)
REFERENCES Customers(Customer_Code),
DateStart DATE NOT NULL,
Document VARCHAR(50) NOT NULL,
Speed BIT NOT NULL,
Address VARCHAR (40) NOT NULL,
District VARCHAR (30) NOT NULL,
Cost INT NOT NULL,
)
