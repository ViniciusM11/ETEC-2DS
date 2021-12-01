using aula_projeto_crud.DAL;
using aula_projeto_crud.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_projeto_crud.BLL
{
    class CadastrarUsuarioBLL
    {
        // Método de cadastro
        //  retorna para UI true se OK e false se Deu ruim

        public bool Cadastro(CadastrarUsuarioDTO cadastrarUsuarioDTO)
        {
            // Validar se os campos foram preenchidos
            if (cadastrarUsuarioDTO.Nome != "" && cadastrarUsuarioDTO.Email != "" && cadastrarUsuarioDTO.Senha != "" && cadastrarUsuarioDTO.Nivel != "")
            {
                // 
                return true;

            }

            // Encaminhar para a DAL
            CadastrarUsuarioDAL cadastrarUsuarioDAL = new CadastrarUsuarioDAL();

            var cadastro = cadastrarUsuarioDAL.GetDadosCadastro(cadastrarUsuarioDTO);

            // Percorrer a lista 
            /*foreach (var item in login)
            {
                if (loginDTO.Email == item.Email && loginDTO.Senha == item.Senha)
                {
                    return true;
                }
            }*/

            if (cadastro)
            {
                return true;
            }

            return false;
        }
    }
}
