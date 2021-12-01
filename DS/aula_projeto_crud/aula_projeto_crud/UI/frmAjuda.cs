using aula_projeto_crud.UI;
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
    public partial class frmAjuda : Form
    {
        public frmAjuda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAjuda_FormClosed(object sender, FormClosedEventArgs e)
        {
            // verificar se existem form abertos
            if(Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form form_aberto in Application.OpenForms)
                {
                    if(form_aberto is frmMenu)
                    {
                        form_aberto.Show();
                        break;
                    }
                }
            }
        }

        private void frmAjuda_Load(object sender, EventArgs e)
        {

        }
    }
}
