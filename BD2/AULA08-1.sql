#AGRUPAMENTO OU GRUPO DE DADOS (GROUP BY)
SELECT orderNumber, status FROM orders ORDER BY status ASC;

SELECT status FROM orders GROUP BY status;

SELECT status, COUNT(status) FROM orders GROUP BY status;

SELECT status FROM orders 
INNER JOIN orderdetails USING(orderNumber) 
ORDER BY status ASC;

SELECT od.quantityOrdered, od.priceEach, o.status FROM orders o
INNER JOIN orderdetails od USING(orderNumber) 
ORDER BY status ASC;

SELECT status, SUM(od.quantityOrdered * od.priceEach) AS 'TOTAL' 
FROM orders o
INNER JOIN orderdetails od USING(orderNumber)
GROUP BY status; 

SELECT productLine, MAX(buyPrice), MIN(buyPrice) 
FROM products
GROUP BY productLine;
  