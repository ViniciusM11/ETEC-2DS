CREATE DATABASE escola;
USE escola;

##TABELA DE CURSO (cod_curso, nome_curso, descricao_curso, carga_horaria_curso)
CREATE TABLE tbl_curso(
	cod_curso INT UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
	nome_curso VARCHAR(250) NOT NULL, 
	descricao_curso TEXT NOT NULL, 
	carga_horaria_curso DECIMAL(10,2)
);

##TABELA DE CURSO (cod_disciplina, nome_disciplina, descricao_disciplina, carga_horaria_disciplina)
CREATE TABLE tbl_disciplina(
	cod_disciplina INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    cod_curso INT UNSIGNED NOT NULL, 
	nome_disciplina VARCHAR(250) NOT NULL, 
	descricao_disciplina TEXT NOT NULL, 
	carga_horaria_disciplina DECIMAL(10,2),
    CONSTRAINT fk_curso 
    FOREIGN KEY (cod_curso) 
    REFERENCES tbl_curso(cod_curso)
    ON UPDATE CASCADE
    ON DELETE CASCADE
);

INSERT INTO tbl_curso (nome_curso, descricao_curso, carga_horaria_curso)
VALUES 
('1DS','DESENVOLVIMENTO DE SISTEMAS','500'),
('2DS','DESENVOLVIMENTO DE SISTEMAS','500'),
('3DS','DESENVOLVIMENTO DE SISTEMAS','500');

INSERT INTO tbl_disciplina (cod_curso, nome_disciplina, descricao_disciplina, carga_horaria_disciplina)
VALUES 
(1, 'LTT', 'LINGUAGEM, TECNOLOGIA E TRABALHO', 40),
(1, 'PA', 'PROGRAMAÇÃO DE ALGORITMOS', 80),
(1, 'BD-1', 'BANCO DE DADOS 1', 40),
(1, 'PW-1', 'PROGRAMAÇÃO WEB 1', 80),
(1, 'FI', 'FUNDAMENTOS DA INFORMÁTICA', 40),
(1, 'APS', 'ANÁLISE DE PROJETOS E SISTEMA', 40),
(1, 'DD', 'DESIGN DIGITAL', 40),
(1, 'TP', 'TÉCNICAS DE PROGRAMAÇÃO', 40);

SELECT * FROM tbl_disciplina;

INSERT INTO tbl_disciplina (cod_curso, nome_disciplina, descricao_disciplina, carga_horaria_disciplina)
VALUES 
(2, 'PW-2', 'PROGRAMAÇÃO WEB 2', 100),
(2, 'BD-2', 'BANCO DE DADOS 2', 100),
(2, 'PAM-1', 'PROGRAMAÇÃO DE APLICATIVOS MOBILE 1', 100),
(2, 'IP', 'INTERNET E PROTOCOLO', 50),
(2, 'II', 'INGLÊS INSTRUMENTAL', 50),
(2, 'PTCC', 'PLANEJAMENTO DE TRABALHO DE CONCLUSÃO DE CURSO', 50),
(2, 'DS', 'DESENVOLVIMENTO DE SISTEMAS', 50);