--**������� ������ ������ � ����� ��������� ������ ������ � ������ ���������:**
SELECT
a.AgreementID as [��� ��������],
c.Surname AS [������� �������],
c.Names AS [��� �������],
c.Patronymic AS [�������� �������],
SUM(t.Cost - COALESCE(b.BackSum, 0)) AS [����� ��������� � ������ ���������]
FROM
Agreement a
JOIN Client c ON a.ClientID = c.ClientID JOIN Thing t ON a.ThingID = t.ThingID LEFT JOIN Back b ON c.ClientID = a.ClientID
GROUP BY a.AgreementID, c.Surname, c.Names, c.Patronymic