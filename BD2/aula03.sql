#SELECIONAR (HABILITAR/ATIVAR) O BANCO DE DADOS:
USE centro_cirurgico;
  
#DESCREVE A ESTRUTURA DE UMA TABELA:
DESCRIBE tbl_especialidade;
DESCRIBE tbl_medico;

#INSERÇÃO DE DADOS NA TABELA tbl_especialidade:
INSERT INTO tbl_especialidade (nome_especialidade)
VALUES ('CARDIOLOGIA');

#SELEÇÃO DE DADOS DA TABELA tbl_especialidade:
SELECT * FROM tbl_especialidade;

#INSERÇÃO DE DADOS NA TABELA tbl_medico:
INSERT INTO
tbl_medico (id_especialidade, nome_medico, email_medico, telefone_medico, celular_medico)
VALUES(1, 'ANA MARIA', 'ana_maria@gmail.com', '1112345678', '11912345678');

INSERT INTO
tbl_medico (id_especialidade, nome_medico, email_medico, telefone_medico, celular_medico)
VALUES(1, 'MARIA DA SILVA', 'maria_silva@gmail.com', '112345678', '11932456798');

#ATUALIZAÇÃO DE DADOS NA TABELA tbl_medico:
UPDATE tbl_medico SET
email_medico = 'm.silva@gmail.com',
telefone_medico = '113456782',
celular_medico = '11962348097'
WHERE id_medico = 3;

#SELEÇÃO DE DADOS DA TABELA tbl_especialidade:
SELECT * FROM tbl_medico;