USE classicmodels;

DESCRIBE products;

#########################################################

SELECT buyPrice, productName FROM products
WHERE buyPrice < 100;

SELECT buyPrice, productName FROM products
WHERE buyPrice > 100;

SELECT buyPrice, productName FROM products
WHERE buyPrice <= 100;

SELECT buyPrice, productName FROM products
WHERE buyPrice >= 100;

SELECT buyPrice, productName FROM products
WHERE buyPrice != 100;

#########################################################

DESCRIBE customers;

SELECT creditLimit FROM customers
WHERE creditLimit >= 25000 AND creditLimit <= 100000;

SELECT creditLimit FROM customers
WHERE creditLimit != 0 AND creditLimit <= 100000;

SELECT creditLimit FROM customers
WHERE creditLimit
BETWEEN 25000 AND 100000;

SELECT creditLimit FROM customers
WHERE creditLimit
BETWEEN 1 AND 100000;

#########################################################

SELECT firstName AS 'NOME', 
lastName AS 'SOBRENOME', 
email AS 'E-MAIL'
FROM employees
ORDER BY firstName ASC;

SELECT firstName AS 'NOME', 
lastName AS 'SOBRENOME', 
email AS 'E-MAIL'
FROM employees
ORDER BY firstName DESC;

#########################################################

SELECT 
customerName AS 'NOME', 
contactLastName AS 'SOBRENOME', 
phone AS 'TELEFONE'
FROM customers  
WHERE phone LIKE '+34%';

SELECT 
customerName AS 'NOME', 
contactLastName AS 'SOBRENOME', 
phone AS 'TELEFONE'
FROM customers  
WHERE phone LIKE '%55';

SELECT 
customerName AS 'NOME', 
contactLastName AS 'SOBRENOME', 
phone AS 'TELEFONE'
FROM customers  
WHERE phone NOT LIKE '%55';

#########################################################

SELECT 
productName AS 'NOME PRODUTO',
productScale AS 'TAMANHO',
buyPrice AS 'VALOR',
textDescription AS 'DESCRIÇÂO'
FROM products tp
INNER JOIN productlines tpl
ON tpl.productLine = tp.productLine
ORDER BY productName;

SELECT 
productName AS 'NOME PRODUTO',
productScale AS 'TAMANHO',
buyPrice AS 'VALOR',
textDescription AS 'DESCRIÇÂO'
FROM products tp 
INNER JOIN productlines tpl USING(productLine)
ORDER BY productName;
