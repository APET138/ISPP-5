CREATE TABLE ���������
(	
	���_���������	int	 NOT NULL,
		Constraint PK1 primary key (���_���������),
	�������		varchar(50) not null,
	���			varchar(50) not null,
	��������	varchar(50),
	�������		char(11) not null
)

CREATE TABLE ������
(	
	���_������		int  IDENTITY(1,1) NOT NULL,
		Constraint PK2 primary key (���_������),
	������_�������	varchar(20)		NOT NULL,
	��������		CHAR(50)		NOT NULL,
	����			MONEY			NOT NULL,
	����_�������	Date 			not null,
	���_���������	int				not null
		CONSTRAINT FK1 FOREIGN KEY (���_���������)
			REFERENCES ��������� (���_���������)
)

CREATE TABLE ����������
(	
	���_����������	int		IDENTITY(1,1) NOT NULL,
		Constraint PK3 primary key (���_����������),
	��������		CHAR(50)			NOT NULL,
	�����			varchar(80)			NOT NULL,
	�����_������	CHAR(7)				not null
)

CREATE TABLE �����
(	
	���_������		int		IDENTITY(1,1) NOT NULL,
		Constraint PK4 primary key (���_������),
	���_������		int					not null
		CONSTRAINT FK2 FOREIGN KEY (���_������)
			REFERENCES ������ (���_������),
	���_����������	int					not null
		CONSTRAINT FK3 FOREIGN KEY (���_����������)
			REFERENCES ���������� (���_����������),
	�����			int 				not null
)

CREATE TABLE [�������� ���������]
(	
	������_�����	int	 NOT NULL,
		Constraint PK5 primary key (������_�����),
	�����		varchar(80)		NOT NULL,
	�������		char(11) not null
)

CREATE TABLE ������������
(	
	���_������		int		IDENTITY(1,1) NOT NULL,
		Constraint PK6 primary key (���_������),
	���_������		int		NOT NULL
		CONSTRAINT FK4 FOREIGN KEY (���_������)
			REFERENCES ����� (���_������),
	������_�����	int,
		CONSTRAINT FK5 FOREIGN KEY (������_�����)
			REFERENCES [�������� ���������] (������_�����),
	����������		int 	not null,
	����_�������	Date 	not null
)