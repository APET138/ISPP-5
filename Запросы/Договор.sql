CREATE TABLE ��������
(	
	[��� ��������]		int		IDENTITY(1,1) NOT NULL,
		Constraint PK5 primary key ([��� ��������]),
	[����� ���������]		tinyint		NOT NULL
		CONSTRAINT FK4 FOREIGN KEY ([����� ���������])
			REFERENCES ��������� ([����� ���������]),
	[������������� ����������]	int NOT NULL,
		CONSTRAINT FK5 FOREIGN KEY ([������������� ����������])
			REFERENCES ���������� ([������������� ����������]),
	[������������� ��������]	int NOT NULL,
		CONSTRAINT FK6 FOREIGN KEY ([������������� ��������])
			REFERENCES �������� ([������������� ��������]),
	������ CHAR(50) ,
	[���� ������]	Date 	not null,
	[���� ���������]	Date 	not null,
	[������������� ������]	VARCHAR(50) 	not null,
	[����� ������]	money 	not null,
	[���� ������] VARCHAR(50),
	[����� �� ���������] money,
	���������� varchar(1000))
