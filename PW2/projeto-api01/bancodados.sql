CREATE DATABASE sistemaCadastro;

USE sistemaCadastro;

CREATE TABLE tbl_usuario(
	nome varchar(50),
    email varchar(100),
    idade int
);

INSERT INTO tbl_usuario(nome, email, idade)
VALUES ('CRISTIANO', 'cristianocorrea3@gmail.com', 40);

INSERT INTO tbl_usuario(nome, email, idade)
VALUES ('ZEZINHO', 'zezinho@gmail.com', 28);

#########################################################################################

create database postagens;
use postagens;