CREATE VIEW Orders AS
SELECT ������.ClientID, Model AS [�����], StartDate AS [���� ������], Price AS [����]
FROM ������ JOIN ������ ON ������.ClientID = ������.ClientID JOIN ���������� ON ������.CarID = ����������.CarID JOIN ����� ON ����������.ModelID = �����.ModelID