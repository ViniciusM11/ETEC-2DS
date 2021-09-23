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


