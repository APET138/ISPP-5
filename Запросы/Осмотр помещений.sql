CREATE TABLE [������ ���������]
(	
	[��� ������]	int		IDENTITY(1,1),
		Constraint PK4 primary key ([��� ������]),
	[����� ���������]		tinyint					not null
		CONSTRAINT FK1 FOREIGN KEY ([����� ���������])
			REFERENCES ��������� ([����� ���������]),
	[������������� ����������]	int					not null
		CONSTRAINT FK2 FOREIGN KEY ([������������� ����������])
			REFERENCES ���������� ([������������� ����������]),
	[������������� ��������]	int					not null
		CONSTRAINT FK3 FOREIGN KEY ([������������� ��������])
			REFERENCES �������� ([������������� ��������]),
	[���� �������]			Date 	not null
)
