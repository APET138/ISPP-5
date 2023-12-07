CREATE TABLE Departments (Department_Code int identity(1,1), 
CONSTRAINT PK6 PRIMARY KEY(Department_Code),
Chief_Code INT NOT NULL,
CONSTRAINT FK2 FOREIGN KEY (Chief_Code)
REFERENCES HeadsOfDepartments(Chief_Code),
Executor_Code INT NOT NULL,
CONSTRAINT FK3 FOREIGN KEY (Executor_Code)
REFERENCES Executors(Executor_Code),
Worker_Code INT NOT NULL,
CONSTRAINT FK4 FOREIGN KEY (Worker_Code)
REFERENCES TechnicalWorkers(Worker_Code),
)
