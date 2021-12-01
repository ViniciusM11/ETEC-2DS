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

namespace aula_projeto_crud.UI
{
    public partial class frmCadastrarUsuario : Form
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Instanciar um obj a partir de DTO
            CadastrarUsuarioDTO cadastrarUsuarioDTO = new CadastrarUsuarioDTO();

            // Receber os dados do form 
            cadastrarUsuarioDTO.Nome = txtNome.Text;
            cadastrarUsuarioDTO.Email = txtEmail.Text;
            cadastrarUsuarioDTO.Senha = txtSenha.Text;
            cadastrarUsuarioDTO.Nivel = cmbNivel.Text;

            // Encaminhar os dados do form para controle
            CadastrarUsuarioBLL cadastrarUsuarioBLL = new CadastrarUsuarioBLL();

            var cadastro = cadastrarUsuarioBLL.Cadastro(cadastrarUsuarioDTO);

            if (cadastro)
            {
                MessageBox.Show("Deu Bom !!!");
            }
            else
            {
                MessageBox.Show("Deu ruim !!!");
            }
        }

        private void frmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cad_usuariosDados.nivel'. Você pode movê-la ou removê-la conforme necessário.
            this.nivelTableAdapter.Fill(this.cad_usuariosDados.nivel);


        }

        private void frmCadastrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            // verificar se existem form abertos
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form form_aberto in Application.OpenForms)
                {
                    if (form_aberto is frmMenu)
                    {
                        form_aberto.Show();
                        break;
                    }
                }
            }
        }
    
    }
    
}
