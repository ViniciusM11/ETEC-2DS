#COMENTÁRIO DE LINHA
/*COMENTÁRIO DE BLOCO*/

#CRIAÇÃO DO BANCO DE DADOS
CREATE DATABASE centro_cirurgico;

#SELECIONAR (HABILITAR/ATIVAR) O BANCO DE DADOS:
USE centro_cirurgico;

#LISTAR TODAS AS TABELAS:
SHOW TABLES;

#CRIAR UMA TABELA:
CREATE TABLE tbl_especialidade (
    id_especialidade INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    nome_especialidade VARCHAR(100) NOT NULL
);

#DESCREVER UMA TABELA
DESCRIBE tbl_especialidade; 


#CRIAÇÃO DA TABELA tbl_especialidade
CREATE TABLE tbl_paciente(
	id_paciente INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    nome_paciente VARCHAR(500) NOT NULL,
    telefone_paciente VARCHAR(10) NOT NULL,
    celular_paciente VARCHAR(11) NOT NULL,
    email_paciente VARCHAR(100) NOT NULL,
    nome_responsavel VARCHAR(500) NULL,
	telefone_responsavel VARCHAR(10) NULL
);



#CRIAÇÃO DA TABELA tbl_medico:
CREATE TABLE tbl_medico(
    id_medico INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    id_especialidade INT UNSIGNED NOT NULL,
    nome_medico VARCHAR(500) NOT NULL,
    email_medico VARCHAR(100) NOT NULL,
    telefone_medico VARCHAR(10) NOT NULL,
    celular_medico VARCHAR(11) NOT NULL
 
);


#CRIAÇÃO DA TABELA tbl_insumos:
CREATE TABLE tbl_insumos(
	id_insumos INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
	id_paciente INT UNSIGNED NOT NULL,
	nome_insumo VARCHAR(100) NOT NULL,
	quantidade_insumo DECIMAL(10,2)
);


#CRIAÇÃO DA TABELA tbl_sala:
CREATE TABLE tbl_sala (
	id_sala INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    nro_sala VARCHAR(10) NOT NULL,	
    id_especialidade INT UNSIGNED NOT NULL
);

#CRIAÇÃO DA TABELA tbl_agenda:
CREATE TABLE tbl_agenda(
	id_agenda INT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
	id_sala INT UNSIGNED NOT NULL,
	id_medico INT UNSIGNED NOT NULL,
	id_paciente INT UNSIGNED NOT NULL,
	data_cirurgia VARCHAR(10),
	status_cirurgia ENUM('AGENDADO', 'CONCLUÍDO', 'CANCELADO')
);

#ALTERANDO A TABELA tbl_sala PARA A CRIAÇÃO
#DA CHAVE ESTRANGEIRA
ALTER TABLE tbl_sala ADD CONSTRAINT FK_ESPECIALIDADE
FOREIGN KEY (id_especialidade)
REFERENCES tbl_especialidade (id_especialidade);
 
#CRIAÇÃO DA CHAVE ESTRANGEIRA NA TABELA
#tbl_insumos.
ALTER TABLE tbl_insumos ADD CONSTRAINT FK_PACIENTE
FOREIGN KEY (id_paciente)
REFERENCES tbl_paciente(id_paciente);
 
#CRIAÇÃO DA CHAVE ESTRANGEIRA NA TABELA
#tbl_medico.
ALTER TABLE tbl_medico ADD CONSTRAINT FK_MEDICO_ESPECIALIDADE
FOREIGN KEY (id_especialidade)
REFERENCES tbl_especialidade (id_especialidade);

#FK_SALA_AGENDA
ALTER TABLE tbl_agenda ADD CONSTRAINT FK_SALA_AGENDA
FOREIGN KEY (id_sala)
REFERENCES tbl_sala (id_sala);
 
#FK_MEDICO_AGENDA
ALTER TABLE tbl_agenda ADD CONSTRAINT FK_MEDICO_AGENDA
FOREIGN KEY (id_medico)
REFERENCES tbl_medico (id_medico);
 
#FK_PACIENTE_AGENDA
ALTER TABLE tbl_agenda ADD CONSTRAINT FK_PACIENTE_AGENDA
FOREIGN KEY (id_paciente)
REFERENCES tbl_paciente (id_paciente);
