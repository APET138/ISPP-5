CREATE VIEW Orders AS
SELECT Клиент.ClientID, Model AS [Марка], StartDate AS [Дата заказа], Price AS [Цена]
FROM Заказы JOIN Клиент ON Заказы.ClientID = Клиент.ClientID JOIN Автомобиль ON Заказы.CarID = Автомобиль.CarID JOIN Марки ON Автомобиль.ModelID = Марки.ModelID