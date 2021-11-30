using aula_projeto_crud.BLL;
using aula_projeto_crud.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_projeto_crud
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Ação de click do botão
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Instanciar um obj a partir de DTO
            LoginDTO loginDTO = new LoginDTO();

            // Receber os dados do form 
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;

            // Encaminhar os dados do form para controle
            LoginBLL loginBLL = new LoginBLL();

            var login = loginBLL.Login(loginDTO);

            if (login)
            {
                MessageBox.Show("Deu Bom !!!");
            }
            else
            {
                MessageBox.Show("Deu ruim !!!");
            }
        }
    }
}


