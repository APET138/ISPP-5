--������� ������ �������� � ����� ��������� ���� �� ������:
SELECT
Client.ClientID,
Surname AS [�������],
Names AS [���],
Patronymic AS [��������],
COUNT(AgreementID) AS [���������� ���������],
SUM(Cost) AS [����� ���������]
FROM
Client LEFT JOIN Agreement ON Client.ClientID = Agreement.ClientID LEFT JOIN Thing ON Thing.ThingID = Agreement.ThingID
GROUP BY Client.ClientID, Surname, Names, Patronymic