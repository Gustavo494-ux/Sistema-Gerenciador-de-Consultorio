namespace Sistema_Gerenciador_de_Consultorio
{
    partial class frmUsuario
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
            this.cbIntermediario = new System.Windows.Forms.ComboBox();
            this.lblStatusUsuario = new System.Windows.Forms.Label();
            this.lblNivelAcesso = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblObservacaoUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.cbStatusUsuario = new System.Windows.Forms.ComboBox();
            this.cbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnLImpar = new System.Windows.Forms.Button();
            this.pnlMenuSuperior = new System.Windows.Forms.Panel();
            this.rbPesquisarUsuario = new System.Windows.Forms.RadioButton();
            this.rbCadastrarUsuario = new System.Windows.Forms.RadioButton();
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.rbIdNivel = new System.Windows.Forms.RadioButton();
            this.rbNomeUsuario = new System.Windows.Forms.RadioButton();
            this.rbLoginUsuario = new System.Windows.Forms.RadioButton();
            this.rbStatusUsuario = new System.Windows.Forms.RadioButton();
            this.pnlPesquisar = new System.Windows.Forms.Panel();
            this.pnlCadastrar = new System.Windows.Forms.Panel();
            this.pnlMenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.pnlPesquisar.SuspendLayout();
            this.pnlCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbIntermediario
            // 
            this.cbIntermediario.FormattingEnabled = true;
            this.cbIntermediario.Location = new System.Drawing.Point(239, 25);
            this.cbIntermediario.Name = "cbIntermediario";
            this.cbIntermediario.Size = new System.Drawing.Size(158, 28);
            this.cbIntermediario.TabIndex = 24;
            // 
            // lblStatusUsuario
            // 
            this.lblStatusUsuario.AutoSize = true;
            this.lblStatusUsuario.Location = new System.Drawing.Point(305, 189);
            this.lblStatusUsuario.Name = "lblStatusUsuario";
            this.lblStatusUsuario.Size = new System.Drawing.Size(119, 20);
            this.lblStatusUsuario.TabIndex = 23;
            this.lblStatusUsuario.Text = "Status Usuario:";
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.AutoSize = true;
            this.lblNivelAcesso.Location = new System.Drawing.Point(27, 189);
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(125, 20);
            this.lblNivelAcesso.TabIndex = 22;
            this.lblNivelAcesso.Text = "Nivel de Acesso:";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(27, 28);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(55, 20);
            this.lblNomeUsuario.TabIndex = 20;
            this.lblNomeUsuario.Text = "Nome:";
            // 
            // lblObservacaoUsuario
            // 
            this.lblObservacaoUsuario.AutoSize = true;
            this.lblObservacaoUsuario.Location = new System.Drawing.Point(27, 246);
            this.lblObservacaoUsuario.Name = "lblObservacaoUsuario";
            this.lblObservacaoUsuario.Size = new System.Drawing.Size(98, 20);
            this.lblObservacaoUsuario.TabIndex = 19;
            this.lblObservacaoUsuario.Text = "Observação:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(27, 135);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 20);
            this.lblSenha.TabIndex = 18;
            this.lblSenha.Text = "Senha:";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(305, 135);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(133, 20);
            this.lblConfirmarSenha.TabIndex = 17;
            this.lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(31, 269);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(464, 62);
            this.txtObservacao.TabIndex = 14;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(31, 160);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(188, 26);
            this.txtSenha.TabIndex = 12;
            this.txtSenha.Text = "\'";
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtConfirmacaoSenha
            // 
            this.txtConfirmacaoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacaoSenha.Location = new System.Drawing.Point(307, 160);
            this.txtConfirmacaoSenha.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            this.txtConfirmacaoSenha.Size = new System.Drawing.Size(188, 26);
            this.txtConfirmacaoSenha.TabIndex = 13;
            this.txtConfirmacaoSenha.Text = " ";
            this.txtConfirmacaoSenha.UseSystemPasswordChar = true;
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsuario.Location = new System.Drawing.Point(31, 106);
            this.txtLoginUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(464, 26);
            this.txtLoginUsuario.TabIndex = 11;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(31, 52);
            this.txtNomeUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(464, 26);
            this.txtNomeUsuario.TabIndex = 10;
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Location = new System.Drawing.Point(27, 82);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblLoginUsuario.TabIndex = 21;
            this.lblLoginUsuario.Text = "Usuario:";
            // 
            // cbStatusUsuario
            // 
            this.cbStatusUsuario.FormattingEnabled = true;
            this.cbStatusUsuario.Location = new System.Drawing.Point(307, 214);
            this.cbStatusUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbStatusUsuario.Name = "cbStatusUsuario";
            this.cbStatusUsuario.Size = new System.Drawing.Size(188, 28);
            this.cbStatusUsuario.TabIndex = 15;
            // 
            // cbNivelAcesso
            // 
            this.cbNivelAcesso.FormattingEnabled = true;
            this.cbNivelAcesso.Location = new System.Drawing.Point(31, 214);
            this.cbNivelAcesso.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbNivelAcesso.Name = "cbNivelAcesso";
            this.cbNivelAcesso.Size = new System.Drawing.Size(188, 28);
            this.cbNivelAcesso.TabIndex = 16;
            this.cbNivelAcesso.SelectedIndexChanged += new System.EventHandler(this.cbNivelAcesso_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(10, 5);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 29);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(284, 5);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 29);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(194, 5);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(84, 29);
            this.btnVerificar.TabIndex = 9;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnLImpar
            // 
            this.btnLImpar.Location = new System.Drawing.Point(102, 5);
            this.btnLImpar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLImpar.Name = "btnLImpar";
            this.btnLImpar.Size = new System.Drawing.Size(84, 29);
            this.btnLImpar.TabIndex = 6;
            this.btnLImpar.Text = "Limpar";
            this.btnLImpar.UseVisualStyleBackColor = true;
            // 
            // pnlMenuSuperior
            // 
            this.pnlMenuSuperior.Controls.Add(this.rbPesquisarUsuario);
            this.pnlMenuSuperior.Controls.Add(this.btnCancelar);
            this.pnlMenuSuperior.Controls.Add(this.btnLImpar);
            this.pnlMenuSuperior.Controls.Add(this.btnVerificar);
            this.pnlMenuSuperior.Controls.Add(this.btnSalvar);
            this.pnlMenuSuperior.Controls.Add(this.rbCadastrarUsuario);
            this.pnlMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuSuperior.Name = "pnlMenuSuperior";
            this.pnlMenuSuperior.Size = new System.Drawing.Size(1130, 69);
            this.pnlMenuSuperior.TabIndex = 25;
            // 
            // rbPesquisarUsuario
            // 
            this.rbPesquisarUsuario.AutoSize = true;
            this.rbPesquisarUsuario.Location = new System.Drawing.Point(504, 6);
            this.rbPesquisarUsuario.Name = "rbPesquisarUsuario";
            this.rbPesquisarUsuario.Size = new System.Drawing.Size(97, 24);
            this.rbPesquisarUsuario.TabIndex = 30;
            this.rbPesquisarUsuario.TabStop = true;
            this.rbPesquisarUsuario.Text = "Pesquisar";
            this.rbPesquisarUsuario.UseVisualStyleBackColor = true;
            this.rbPesquisarUsuario.CheckedChanged += new System.EventHandler(this.rbPesquisarUsuario_CheckedChanged);
            // 
            // rbCadastrarUsuario
            // 
            this.rbCadastrarUsuario.AutoSize = true;
            this.rbCadastrarUsuario.Location = new System.Drawing.Point(384, 6);
            this.rbCadastrarUsuario.Name = "rbCadastrarUsuario";
            this.rbCadastrarUsuario.Size = new System.Drawing.Size(97, 24);
            this.rbCadastrarUsuario.TabIndex = 30;
            this.rbCadastrarUsuario.TabStop = true;
            this.rbCadastrarUsuario.Text = "Cadastrar";
            this.rbCadastrarUsuario.UseVisualStyleBackColor = true;
            this.rbCadastrarUsuario.CheckedChanged += new System.EventHandler(this.rbCadastrarUsuario_CheckedChanged);
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.AllowUserToAddRows = false;
            this.dtgUsuario.AllowUserToDeleteRows = false;
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Location = new System.Drawing.Point(-32, 530);
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.ReadOnly = true;
            this.dtgUsuario.RowHeadersVisible = false;
            this.dtgUsuario.Size = new System.Drawing.Size(1600, 465);
            this.dtgUsuario.TabIndex = 26;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(302, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(98, 26);
            this.btnPesquisar.TabIndex = 27;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(26, 12);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(253, 26);
            this.txtPesquisar.TabIndex = 29;
            // 
            // rbIdNivel
            // 
            this.rbIdNivel.AutoSize = true;
            this.rbIdNivel.Location = new System.Drawing.Point(86, 54);
            this.rbIdNivel.Name = "rbIdNivel";
            this.rbIdNivel.Size = new System.Drawing.Size(114, 24);
            this.rbIdNivel.TabIndex = 30;
            this.rbIdNivel.TabStop = true;
            this.rbIdNivel.Text = "Código Nivel";
            this.rbIdNivel.UseVisualStyleBackColor = true;
            // 
            // rbNomeUsuario
            // 
            this.rbNomeUsuario.AutoSize = true;
            this.rbNomeUsuario.Location = new System.Drawing.Point(212, 54);
            this.rbNomeUsuario.Name = "rbNomeUsuario";
            this.rbNomeUsuario.Size = new System.Drawing.Size(128, 24);
            this.rbNomeUsuario.TabIndex = 30;
            this.rbNomeUsuario.TabStop = true;
            this.rbNomeUsuario.Text = "Nome Usuario";
            this.rbNomeUsuario.UseVisualStyleBackColor = true;
            // 
            // rbLoginUsuario
            // 
            this.rbLoginUsuario.AutoSize = true;
            this.rbLoginUsuario.Location = new System.Drawing.Point(87, 85);
            this.rbLoginUsuario.Name = "rbLoginUsuario";
            this.rbLoginUsuario.Size = new System.Drawing.Size(66, 24);
            this.rbLoginUsuario.TabIndex = 30;
            this.rbLoginUsuario.TabStop = true;
            this.rbLoginUsuario.Text = "Login";
            this.rbLoginUsuario.UseVisualStyleBackColor = true;
            // 
            // rbStatusUsuario
            // 
            this.rbStatusUsuario.AutoSize = true;
            this.rbStatusUsuario.Location = new System.Drawing.Point(206, 85);
            this.rbStatusUsuario.Name = "rbStatusUsuario";
            this.rbStatusUsuario.Size = new System.Drawing.Size(133, 24);
            this.rbStatusUsuario.TabIndex = 30;
            this.rbStatusUsuario.TabStop = true;
            this.rbStatusUsuario.Text = "Status Usuario";
            this.rbStatusUsuario.UseVisualStyleBackColor = true;
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Controls.Add(this.rbStatusUsuario);
            this.pnlPesquisar.Controls.Add(this.rbNomeUsuario);
            this.pnlPesquisar.Controls.Add(this.rbLoginUsuario);
            this.pnlPesquisar.Controls.Add(this.rbIdNivel);
            this.pnlPesquisar.Controls.Add(this.txtPesquisar);
            this.pnlPesquisar.Controls.Add(this.btnPesquisar);
            this.pnlPesquisar.Location = new System.Drawing.Point(415, 584);
            this.pnlPesquisar.Name = "pnlPesquisar";
            this.pnlPesquisar.Size = new System.Drawing.Size(416, 129);
            this.pnlPesquisar.TabIndex = 31;
            // 
            // pnlCadastrar
            // 
            this.pnlCadastrar.Controls.Add(this.cbIntermediario);
            this.pnlCadastrar.Controls.Add(this.lblStatusUsuario);
            this.pnlCadastrar.Controls.Add(this.lblNivelAcesso);
            this.pnlCadastrar.Controls.Add(this.lblNomeUsuario);
            this.pnlCadastrar.Controls.Add(this.lblObservacaoUsuario);
            this.pnlCadastrar.Controls.Add(this.lblSenha);
            this.pnlCadastrar.Controls.Add(this.lblConfirmarSenha);
            this.pnlCadastrar.Controls.Add(this.txtObservacao);
            this.pnlCadastrar.Controls.Add(this.txtSenha);
            this.pnlCadastrar.Controls.Add(this.txtConfirmacaoSenha);
            this.pnlCadastrar.Controls.Add(this.txtLoginUsuario);
            this.pnlCadastrar.Controls.Add(this.txtNomeUsuario);
            this.pnlCadastrar.Controls.Add(this.lblLoginUsuario);
            this.pnlCadastrar.Controls.Add(this.cbStatusUsuario);
            this.pnlCadastrar.Controls.Add(this.cbNivelAcesso);
            this.pnlCadastrar.Location = new System.Drawing.Point(384, 75);
            this.pnlCadastrar.Name = "pnlCadastrar";
            this.pnlCadastrar.Size = new System.Drawing.Size(538, 464);
            this.pnlCadastrar.TabIndex = 32;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1042);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCadastrar);
            this.Controls.Add(this.pnlPesquisar);
            this.Controls.Add(this.dtgUsuario);
            this.Controls.Add(this.pnlMenuSuperior);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\'";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.pnlMenuSuperior.ResumeLayout(false);
            this.pnlMenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            this.pnlCadastrar.ResumeLayout(false);
            this.pnlCadastrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbIntermediario;
        private System.Windows.Forms.Label lblStatusUsuario;
        private System.Windows.Forms.Label lblNivelAcesso;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblObservacaoUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmacaoSenha;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.ComboBox cbStatusUsuario;
        private System.Windows.Forms.ComboBox cbNivelAcesso;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnLImpar;
        private System.Windows.Forms.Panel pnlMenuSuperior;
        private System.Windows.Forms.DataGridView dtgUsuario;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.RadioButton rbIdNivel;
        private System.Windows.Forms.RadioButton rbNomeUsuario;
        private System.Windows.Forms.RadioButton rbLoginUsuario;
        private System.Windows.Forms.RadioButton rbStatusUsuario;
        private System.Windows.Forms.Panel pnlPesquisar;
        private System.Windows.Forms.Panel pnlCadastrar;
        private System.Windows.Forms.RadioButton rbPesquisarUsuario;
        private System.Windows.Forms.RadioButton rbCadastrarUsuario;
    }
}