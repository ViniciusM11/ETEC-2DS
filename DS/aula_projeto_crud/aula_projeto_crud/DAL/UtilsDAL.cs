﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace aula_projeto_crud.DAL
{
    class UtilsDAL
    {
        public static MySqlConnection GetConnection()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                // Database = "cad_usuarios",
                UserID = "root",
                Password = ""
            };



            MySqlConnection conexao = new MySqlConnection(builder.ConnectionString);
            conexao.Open();



            var sql = "CREATE DATABASE IF NOT EXISTS cad_usuarios; use cad_usuarios;";
            var comando = new MySqlCommand(sql, conexao);
            comando.ExecuteNonQuery();



            sql = "CREATE TABLE IF NOT EXISTS nivel ( " +
                            "id_nivel int(11) NOT NULL AUTO_INCREMENT, " +
                            "nome varchar(50) NOT NULL, " +
                            "PRIMARY KEY(id_nivel), " +
                            "UNIQUE KEY nome (nome)" +
                        ")";
            comando = new MySqlCommand(sql, conexao);
            comando.ExecuteNonQuery();



            sql = "INSERT IGNORE INTO nivel VALUES (1,'Administrador'),(3,'Desenvolvedor'),(2,'Usuário')";
            comando = new MySqlCommand(sql, conexao);
            comando.ExecuteNonQuery();



            sql = "CREATE TABLE IF NOT EXISTS usuarios ( " +
                      "id_usuario int(11) NOT NULL AUTO_INCREMENT, " +
                      "nome varchar(50) CHARACTER SET latin1 DEFAULT NULL, " +
                      "email varchar(50) CHARACTER SET latin1 DEFAULT NULL, " +
                      "senha varchar(25) CHARACTER SET latin1 DEFAULT NULL, " +
                      "nivel int(11) DEFAULT NULL," +
                      "data timestamp NULL DEFAULT CURRENT_TIMESTAMP, " +
                      "PRIMARY KEY(id_usuario), " +
                      "UNIQUE KEY email (email), " +
                      "KEY fk_nivel (nivel), " +
                      "CONSTRAINT fk_nivel FOREIGN KEY(nivel) REFERENCES nivel (id_nivel) )";
            comando = new MySqlCommand(sql, conexao);
            comando.ExecuteNonQuery();



            sql = "INSERT IGNORE INTO usuarios (nome, email, senha, nivel) VALUES ('admin', 'admin@admin.com','admin',1)";
            comando = new MySqlCommand(sql, conexao);
            comando.ExecuteNonQuery();




            return conexao;
        }




        // Metodo que recupera indice da tabela nível de usuário
        // Parâmetros:
        // conn - conexão com o banco de dados
        // nivel - campo texto retornando o valor nome do nível, ex: Administrador
        public static string GetItemNivelUsuario(MySqlConnection conn, String nivel)
        {
            var item = "";



            // verifica se conexão esta ok
            if (conn.State == ConnectionState.Open)
            {
                var sql = "SELECT id_nivel" +
                    " FROM nivel WHERE nome='" + nivel + "'";



                var retorno = new MySqlCommand(sql, conn);



                var reader = retorno.ExecuteReader();



                if (reader.Read())
                {
                    item = reader[0].ToString();
                    // MessageBox.Show(reader[0].ToString());
                    conn.Close();
                }
            }

            return item;
        }
    }
}
