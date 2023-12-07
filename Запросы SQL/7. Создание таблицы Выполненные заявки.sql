CREATE TABLE CompletedApplications(
CompAppID int identity(1,1), 
CONSTRAINT PK8 PRIMARY KEY(CompAppID),
Application_Code INT,
CONSTRAINT FK5 FOREIGN KEY (Application_Code)
REFERENCES Applications(Application_Code),
Department_Code INT,
CONSTRAINT FK6 FOREIGN KEY (Department_Code)
REFERENCES Departments(Department_Code),
Inspector DATE NOT NULL,
Time VARCHAR (40) NOT NULL,
DateWorker DATE NOT NULL,
Cash BIT NULL,
DateCost DATE NOT NULL,
Value INT NULL,
DateStop DATE NOT NULL,
Finish BIT NULL,
Comment TEXT NULL,
)
