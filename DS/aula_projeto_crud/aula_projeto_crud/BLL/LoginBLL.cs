using aula_projeto_crud.DAL;
using aula_projeto_crud.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_projeto_crud.BLL
{
    class LoginBLL
    {
        // Método de login 
        //  retorna para UI true se OK e false se Deu ruim

        public bool Login(LoginDTO loginDTO)
        {
            // Validar se os campos foram preenchidos
            if (loginDTO.Email != "" || loginDTO.Senha != "")
            {
                // 
                return true;

            }

            // Encaminhar para a DAL
            LoginDAL loginDAL = new LoginDAL();

            var login = loginDAL.GetDadosLogin(loginDTO);

            // Percorrer a lista 
            /*foreach (var item in login)
            {
                if (loginDTO.Email == item.Email && loginDTO.Senha == item.Senha)
                {
                    return true;
                }
            }*/

            if (login)
            {
                return true;
            }

            return false;
        }
    }
}
