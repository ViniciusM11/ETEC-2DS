#INSERÇÃO DE DADOS NA TABELA tbl_especialidade:
INSERT INTO tbl_especialidade (nome_pessoa_especialidade)
VALUES ('NEUROLOGIA');

INSERT INTO tbl_especialidade (nome_pessoa_especialidade)
VALUES ('ORTOPEDIA');

#INSERÇÃO DE DADOS NA TABELA tbl_especialidade:
INSERT INTO tbl_especialidade (nome_pessoa_especialidade)
VALUES ('PODOLOGIA');

INSERT INTO tbl_especialidade (nome_pessoa_especialidade)
VALUES ('OFTAMOLOGIA');

SELECT * FROM tbl_especialidade;

CREATE DATABASE vacinacao;
USE vacinacao;

CREATE TABLE tbl_pessoas(
cod_pessoa INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
nome_pessoa VARCHAR(500) NOT NULL,
idade INT NOT NULL
);

SHOW TABLES;

DESCRIBE pessoas;

INSERT INTO tbl_pessoas(nome_pessoa, idade)
VALUES ('Ana', 30);
INSERT INTO tbl_pessoas(nome_pessoa, idade)
VALUES ('Ana', 35);
INSERT INTO tbl_pessoas(nome_pessoa, idade)
VALUES('Ana', 40);
INSERT INTO tbl_pessoas(nome_pessoa, idade)
VALUES('Ana', 45);
INSERT INTO tbl_pessoas(nome_pessoa, idade)
VALUES('Ana', 50);
INSERT INTO tbl_pessoas(nome_pessoa, idade)
VALUES('Ana', 70);
INSERT INTO tbl_pessoas(nome_pessoa, idade)
VALUES('Ana', 80);
INSERT INTO tbl_pessoas(nome_pessoa, idade)
VALUES('Ana', 79);
INSERT INTO tbl_pessoas(nome_pessoa, idade)
VALUES('Ana', 67);
INSERT INTO tbl_pessoas(nome_pessoa, idade)
VALUES('Ana', 78);
INSERT INTO tbl_pessoas(nome_pessoa, idade)
VALUES('Ana', 92);

SELECT * FROM tbl_pessoas;

SELECT * FROM tbl_pessoas
WHERE
idade >= 75 AND idade <= 89;













