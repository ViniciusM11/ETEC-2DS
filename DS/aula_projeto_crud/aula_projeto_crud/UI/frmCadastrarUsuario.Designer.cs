
namespace aula_projeto_crud.UI
{
    partial class frmCadastrarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.nivelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_usuariosDados = new aula_projeto_crud.cad_usuariosDados();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.nivelTableAdapter = new aula_projeto_crud.cad_usuariosDadosTableAdapters.nivelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nivelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_usuariosDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCadastrar.Location = new System.Drawing.Point(331, 335);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(239, 38);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(124, 80);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(175, 26);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome Completo:";
            // 
            // cmbNivel
            // 
            this.cmbNivel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nivelBindingSource, "id_nivel", true));
            this.cmbNivel.DataSource = this.nivelBindingSource;
            this.cmbNivel.DisplayMember = "nome";
            this.cmbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Location = new System.Drawing.Point(331, 245);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(239, 28);
            this.cmbNivel.TabIndex = 2;
            this.cmbNivel.ValueMember = "id_nivel";
            // 
            // nivelBindingSource
            // 
            this.nivelBindingSource.DataMember = "nivel";
            this.nivelBindingSource.DataSource = this.cad_usuariosDados;
            // 
            // cad_usuariosDados
            // 
            this.cad_usuariosDados.DataSetName = "cad_usuariosDados";
            this.cad_usuariosDados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNome.Location = new System.Drawing.Point(331, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(327, 27);
            this.txtNome.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(226, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 26);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(220, 191);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSenha.Size = new System.Drawing.Size(79, 26);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(231, 245);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(68, 26);
            this.lblNivel.TabIndex = 6;
            this.lblNivel.Text = "Nível:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtSenha.Location = new System.Drawing.Point(331, 191);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(327, 27);
            this.txtSenha.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtEmail.Location = new System.Drawing.Point(331, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(327, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // nivelTableAdapter
            // 
            this.nivelTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCadastrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarUsuario_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nivelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_usuariosDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private cad_usuariosDados cad_usuariosDados;
        private System.Windows.Forms.BindingSource nivelBindingSource;
        private cad_usuariosDadosTableAdapters.nivelTableAdapter nivelTableAdapter;
    }
}