CREATE TABLE Users(
UserID int identity(1,1), 
CONSTRAINT PK7 PRIMARY KEY(UserID),
Login VARCHAR(20),
Password VARCHAR(8),
Rights VARCHAR(20) DEFAULT 'guest',
)