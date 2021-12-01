CREATE DATABASE comercio;

USE comercio;

CREATE TABLE tbl_produto(
	cod_produto INT(10) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    nome_produto VARCHAR(100) NOT NULL,
    desc_produto TEXT NOT NULL,
    valor DECIMAL(10,2) UNSIGNED NOT NULL
);

CREATE TABLE tbl_cliente(
	cod_cliente INT(10) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    nome_cliente VARCHAR(45) NOT NULL
); 

CREATE TABLE tbl_pedido(
	cod_pedido INT(10) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    cod_cliente INT(10) UNSIGNED NOT NULL,
    data_pedido DATETIME NOT NULL,
    data_entrega DATETIME
); 

CREATE TABLE tbl_itempedido(
	qtd INT(10) UNSIGNED NOT NULL,
    cod_produto INT(10) UNSIGNED NOT NULL,
    cod_pedido INT(10) UNSIGNED NOT NULL
);

ALTER TABLE tbl_itempedido ADD CONSTRAINT fk_produto
FOREIGN KEY (cod_produto)
REFERENCES tbl_produto (cod_produto);

ALTER TABLE tbl_itempedido ADD CONSTRAINT fk_pedido
FOREIGN KEY (cod_pedido)
REFERENCES tbl_pedido (cod_pedido);

ALTER TABLE tbl_pedido ADD CONSTRAINT fk_cliente
FOREIGN KEY (cod_cliente)
REFERENCES tbl_cliente (cod_cliente);


############    1    ##########
INSERT INTO tbl_produto(nome_produto, desc_produto, valor) 
VALUES 
('Borracha', 'Borracha Branca', 0.50),
('Caneta', 'Caneta Esferográfica Azul', 1.00),
('Caneta', 'Caneta Esferográfica Vermelha', 1.00),
('Caneta', 'Caneta Esferográfica Preta', 1.00),
('Lápis', 'Lápis de Carbono', 0.60),
('Tesoura', 'Tesoura S/ Ponta', 3.50),
('Cola Branca', 'Cola Branca 50ML', 2.50),
('Corretivo', 'Corretivo Branco', 1.50), 
('Canetão', 'Canetão Preto Permanente', 1.50),
('Giz', 'Caixa de Giz de Cera C/12U', 5.00);

SELECT * FROM tbl_produto;

INSERT INTO tbl_cliente(nome_cliente) 
VALUES 
('Ana'),
('José'),
('Carlos'),
('Marcos'),
('Jurandi');

SELECT * FROM tbl_cliente;

INSERT INTO tbl_pedido(cod_cliente, data_pedido, data_entrega) 
VALUES 
('1', NOW(), '2021/11/15'),
('1', NOW(), '2021/11/19'),
('5', NOW(), ''),
('4', NOW(), ''),
('5', NOW(), '2021/05/28'),
('4', NOW(), '2021/09/16'),
('3', NOW(), ''),
('3', NOW(), '2021/03/11'),
('2', NOW(), ''),
('2', NOW(), '2021/07/12');

SELECT * FROM tbl_pedido;

INSERT INTO tbl_itempedido(qtd, cod_produto, cod_pedido) 
VALUES
('2','1','1'),
('4','2','2'),
('6','3','3'),
('8','4','4'),
('10','5','5'),
('1','9','6'),
('3','7','7'),
('5','3','8'),
('7','10','9'),
('9','6','10');

SELECT * FROM tbl_itempedido;

#Contar a quantidade total de produtos -2-
SELECT COUNT(cod_produto) AS 'TOTAL DE PRODUTOS' FROM tbl_produto;

#Contar a quantidade de produtos em pedidos -3-
SELECT 
qtd AS 'Quantidade de Produtos', 
nome_produto AS 'Nome do Produto', 
cod_pedido AS 'Código do Pedido' 
FROM tbl_itempedido ip
INNER JOIN tbl_produto tprod USING(cod_produto)
INNER JOIN tbl_pedido tped USING(cod_pedido);

#Contar a quantidade de clientes em pedidos -4-
SELECT COUNT(cod_cliente) AS 'Total de Clientes' FROM tbl_pedido;

#Informar valor	total dos produtos -5-
SELECT SUM(valor) AS 'Valor Total Dos Produtos' FROM tbl_produto;

#Valor total de pedidos -6-
SELECT SUM(ip.qtd * tprod.valor) AS 'Valor Total' 
FROM tbl_itempedido ip
INNER JOIN tbl_produto tprod USING(cod_produto);

#MÉDIA DOS PREÇOS -7-
SELECT AVG (valor) AS 'PREÇO MÉDIO' FROM tbl_produto;

#MAIOR VALOR  -8-
SELECT MAX(valor) AS 'MAIOR VALOR' FROM tbl_produto;

#MENOR VALOR  -9-
SELECT MIN(valor) AS 'MENOR VALOR' FROM tbl_produto;