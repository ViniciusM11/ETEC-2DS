#Criação do banco de dados
CREATE DATABASE loja;

#Selecão do banco de dados
USE loja;

#Criação da tabela tbl_produt
CREATE TABLE tbl_produto (
	cod_prod INT(10) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(500) NOT NULL,
    descricao TEXT NOT NULL,
    preco DECIMAL(10,2) UNSIGNED
);

#Criação da tabela tbl_pedido
CREATE TABLE tbl_pedido (
	cod_ped INT(10) UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    data_ped VARCHAR(10) 
);

#Criação da tabela tbl_item_pedido
CREATE TABLE tbl_item_pedido (
	cod_prod INT(10) UNSIGNED ,
    cod_ped INT(10) UNSIGNED 
);

#Criação da FK
ALTER TABLE tbl_item_pedido ADD CONSTRAINT FK_PRODUTO
FOREIGN KEY (cod_prod)
REFERENCES tbl_produto (cod_prod);

#Criação da Fk
ALTER TABLE tbl_item_pedido ADD CONSTRAINT FK_PEDIDO
FOREIGN KEY (cod_ped)
REFERENCES tbl_pedido (cod_ped);

#Inserção de dados na tabela tbl_produto
INSERT INTO tbl_produto(nome, descricao, preco) 
VALUES ('Borracha', 'Borracha Branca', 0.50); 

INSERT INTO tbl_produto(nome, descricao, preco) 
VALUES ('Caneta', 'Caneta Esferográfica Azul', 1.00); 

INSERT INTO tbl_produto(nome, descricao, preco) 
VALUES ('Caneta', 'Caneta Esferográfica Vermelha', 1.00); 

INSERT INTO tbl_produto(nome, descricao, preco) 
VALUES ('Caneta', 'Caneta Esferográfica Preta', 1.00); 

INSERT INTO tbl_produto(nome, descricao, preco) 
VALUES ('Lápis', 'Lápis de Carbono', 0.60); 

INSERT INTO tbl_produto(nome, descricao, preco) 
VALUES ('Tesoura', 'Tesoura S/ Ponta', 3.50); 

INSERT INTO tbl_produto(nome, descricao, preco) 
VALUES ('Cola Branca', 'Cola Branca 50ML', 2.50); 

INSERT INTO tbl_produto(nome, descricao, preco) 
VALUES ('Corretivo', 'Corretivo Branco', 1.50); 

INSERT INTO tbl_produto(nome, descricao, preco) 
VALUES ('Canetão', 'Canetão Preto Permanente', 1.50); 

INSERT INTO tbl_produto(nome, descricao, preco) 
VALUES ('Giz', 'Caixa de Giz de Cera C/12U', 5.00);

#Inserção de dados na tbl_pedido
INSERT INTO tbl_pedido(data_ped) 
VALUES ('03/11/21');

INSERT INTO tbl_pedido(data_ped) 
VALUES ('02/11/21');

INSERT INTO tbl_pedido(data_ped) 
VALUES ('04/11/21');

INSERT INTO tbl_item_pedido(cod_prod, cod_ped) 
VALUES ('1', '1');

INSERT INTO tbl_item_pedido(cod_prod, cod_ped) 
VALUES ('2', '2');

INSERT INTO tbl_item_pedido(cod_prod, cod_ped) 
VALUES ('3', '3');

#Selects
SELECT * FROM tbl_produto;
SELECT * FROM tbl_pedido;
SELECT * FROM tbl_item_pedido;

SELECT nome, descricao
FROM tbl_produto;

SELECT nome, descricao FROM tbl_produto;

SELECT nome AS 'PRODUTO', descricao AS 'DETALHES' FROM tbl_produto;

#Atualização de dados
UPDATE tbl_produto SET
nome = 'Borracha',
descricao = 'Borracha Rosa',
preco = 0.70
WHERE cod_prod = 1;

UPDATE tbl_produto SET
nome = 'Caneta Azul',
descricao = 'Caneta Esferográfica Azul de Ponta Fina',
preco = 1.20
WHERE cod_prod = 2;

UPDATE tbl_produto SET
nome = 'Caneta Vermelha',
descricao = 'Caneta Esferográfica Vermelha de Ponta Fina',
preco = 1.20
WHERE cod_prod = 3;

################################################################################################################ 2

SELECT * FROM tbl_produto;

USE loja;

DESCRIBE tbl_produto;

SELECT * FROM tbl_produto
WHERE
preco >= 1 AND preco <= 3
ORDER BY nome ASC;

SELECT * FROM tbl_produto
WHERE 
preco BETWEEN 4 AND 7
ORDER BY nome ASC;

SELECT nome
FROM tbl_produto
WHERE nome LIKE '%a'
ORDER BY nome ASC;

SELECT *
FROM tbl_produto
WHERE nome LIKE 'C__%'
ORDER BY nome DESC;

SELECT 
data_ped,
cod_prod
FROM tbl_pedido
INNER JOIN tbl_item_pedido
ORDER BY data_ped DESC;

########################################### DESAFIO ##############################################

SELECT 
tp.nome AS nome_prod,
tp.preco AS preco_prod,
tpe.data_ped AS data_ped
FROM tbl_item_pedido AS tip
INNER JOIN tbl_produto AS tp
ON tip.cod_prod = tp.cod_prod
INNER JOIN tbl_pedido AS tpe
ON tip.cod_ped = tpe.cod_ped;






