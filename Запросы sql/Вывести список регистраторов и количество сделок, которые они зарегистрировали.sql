--*������� ������ ������������� � ���������� ������, ������� ��� ����������������:**
SELECT
r.RegistrarID as [��� ���������],
r.Surname as [������� ���������],
r.Names as [��� ���������],
r.Patronymic as [�������� ���������],
COUNT(a.AgreementID) AS [���������� ����������� ���������]
FROM
Registrar r LEFT JOIN Agreement a ON r.RegistrarID = a.RegistrarID
GROUP BY r.RegistrarID, r.Surname, r.Names, r.Patronymic