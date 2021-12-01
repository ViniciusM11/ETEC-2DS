use cad_usuarios;

select * from cad_usuarios;

CREATE DATABASE IF NOT EXISTS cad_usuarios; 
use cad_usuarios;

CREATE TABLE IF NOT EXISTS nivel (
	id_nivel int(11) NOT NULL AUTO_INCREMENT,
	nome varchar(50) NOT NULL,
	PRIMARY KEY(id_nivel),
	UNIQUE KEY nome (nome)
);

INSERT IGNORE INTO nivel VALUES (1,'Administrador'),(3,'Desenvolvedor'),(2,'Usuário');

SELECT * FROM nivel;

CREATE TABLE IF NOT EXISTS usuarios (
	id_usuario int(11) NOT NULL AUTO_INCREMENT,
	nome varchar(50) CHARACTER SET latin1 DEFAULT NULL, 
	email varchar(50) CHARACTER SET latin1 DEFAULT NULL, 
	senha varchar(25) CHARACTER SET latin1 DEFAULT NULL,
	nivel int(11) DEFAULT NULL,
	data timestamp NULL DEFAULT CURRENT_TIMESTAMP, 
	PRIMARY KEY(id_usuario),
	UNIQUE KEY email (email),
	KEY fk_nivel (nivel), 
	CONSTRAINT fk_nivel FOREIGN KEY(nivel) REFERENCES nivel (id_nivel) );
                      
INSERT IGNORE INTO usuarios (nome, email, senha, nivel) VALUES ('admin', 'admin@admin.com','admin',1);

SELECT * FROM usuarios;


