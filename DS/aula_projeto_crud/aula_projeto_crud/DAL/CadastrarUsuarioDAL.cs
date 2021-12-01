using aula_projeto_crud.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_projeto_crud.DAL
{
    class CadastrarUsuarioDAL
    {
        public bool GetDadosCadastro(CadastrarUsuarioDTO cadastrarUsuarioDTO)
        {
            try // tenta executar 
            {
                // conecta com o banco
                var conn = UtilsDAL.GetConnection();

                // verifica se conexão esta ok
                if (conn.State == ConnectionState.Open)
                {
                    var sql = "INSERT INTO CLIENTE (nome, email, senha, nivel) " +
                        "VALUES ('" + cadastrarUsuarioDTO.Nome + "', '" + cadastrarUsuarioDTO.Email + "', '" +
                        cadastrarUsuarioDTO.Senha + "', '" + cadastrarUsuarioDTO.Nivel + "')";

                    var retorno = new MySqlCommand(sql, conn);
                    // Envia o CommandText para o Connection e cria um SqlDataReader.
                    var reader = retorno.ExecuteReader();
                    if (reader.Read())
                    {
                        return true;
                        // fecha a conexão com o banaco de dados
                        conn.Close();
                    }
                }
            }
            catch (System.Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            //return usuariosLogin;
            return false;
        }
    }
}
