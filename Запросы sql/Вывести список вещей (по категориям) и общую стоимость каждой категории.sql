--**������� ������ ����� (�� ����������) � ����� ��������� ������ ���������:**
SELECT
cat.Category as [���������],
COUNT(t.ThingID) AS [���������� �����],
SUM(t.Cost) AS [����� ���������]
FROM
Category cat LEFT JOIN Thing t ON cat.CategoryID = t.CategoryID
GROUP BY cat.Category