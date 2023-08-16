SELECT p.Name AS ProductName, c.Name AS CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID


/*Обратите внимание на использование оператора LEFT JOIN, который позволяет выбирать все продукты даже если у них нет категорий.*/