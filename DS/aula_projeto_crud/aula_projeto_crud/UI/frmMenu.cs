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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void smiAjuda_Click(object sender, EventArgs e)
        {
            // carregar o frm ajuda
            frmAjuda fAjuda = new frmAjuda();
            fAjuda.Show();

            // ocultar o frm menu
            this.Hide();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
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
                    if (form_aberto is frmLogin)
                    {
                        form_aberto.Dispose();
                        break;
                    }
                }
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chamar o form Cadastrar Usuário
            frmCadastrarUsuario fCadastrarUsuario = new frmCadastrarUsuario();

            fCadastrarUsuario.Show();

            this.Hide();
        }

        private void smiPrincipal_Click(object sender, EventArgs e)
        {

        }
    }
}
