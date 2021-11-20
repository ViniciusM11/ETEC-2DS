CREATE DATABASE vacina;
USE vacina;

INSERT INTO tbl_pessoas(nome_pessoa, idade)
VALUES 
('Ana Da Silva','30'),
('Carlos Alberto','35'),
('Betina Cardoso','26'),
('Maria Joana','40'),
('Reinaldo Tadeu','22'),
('Milton Leite','44'),
('Maria Carla','50'),
('Josenildo Martins','60'),
('Beatriz Soares','20'),
('Carlos Fontana','33'),
('Marinildo Amaral','70'),
('Marcos Vitor','19'),
('Josiane Marlene','47'),
('José Santos','61'),
('José Santos','80'),
('José Silva','86');

DESCRIBE tbl_pessoas;

SELECT * FROM tbl_pessoas;

SELECT * FROM tbl_pessoas
WHERE
idade >= 30 AND idade <= 40;

SELECT * FROM tbl_pessoas
WHERE 
idade BETWEEN 30 AND 40;

SELECT * FROM tbl_pessoas
WHERE 
idade BETWEEN 40 AND 50
ORDER BY idade ASC;

SELECT * FROM tbl_pessoas
WHERE 
idade BETWEEN 40 AND 50
ORDER BY idade DESC;

SELECT * FROM tbl_pessoas
WHERE idade LIKE '_0';

SELECT * FROM tbl_pessoas
WHERE idade LIKE '7_';

SELECT * FROM tbl_pessoas
WHERE nome_pessoa LIKE 'Maria%';

SELECT * FROM tbl_pessoas
WHERE nome_pessoa LIKE '%Silva%';

SELECT * FROM tbl_pessoas
WHERE nome_pessoa NOT LIKE '%Silva%'
ORDER BY nome_pessoa ASC;




