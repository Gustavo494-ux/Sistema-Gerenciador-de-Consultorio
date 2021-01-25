namespace Sistema_Gerenciador_de_Consultorio
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LoginPainel = new System.Windows.Forms.Panel();
            this.btnLogar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.painelBranco = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.LoginPainel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(925, 430);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(828, 430);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(91, 32);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(824, 211);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(28, 13);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "hora";
            this.lblHora.Visible = false;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(812, 181);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(57, 13);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem-vindo";
            this.lblBemVindo.Visible = false;
            // 
            // hora
            // 
            this.hora.Enabled = true;
            this.hora.Interval = 10;
            this.hora.Tick += new System.EventHandler(this.hora_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(552, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(454, 72);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // LoginPainel
            // 
            this.LoginPainel.BackColor = System.Drawing.Color.White;
            this.LoginPainel.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.FMv4;
            this.LoginPainel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginPainel.Controls.Add(this.btnLogar);
            this.LoginPainel.Controls.Add(this.txtSenha);
            this.LoginPainel.Controls.Add(this.txtUsuario);
            this.LoginPainel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPainel.Location = new System.Drawing.Point(365, 147);
            this.LoginPainel.Name = "LoginPainel";
            this.LoginPainel.Size = new System.Drawing.Size(406, 406);
            this.LoginPainel.TabIndex = 0;
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogar.ForeColor = System.Drawing.Color.White;
            this.btnLogar.Location = new System.Drawing.Point(74, 297);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(254, 32);
            this.btnLogar.TabIndex = 3;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(113, 248);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(227, 22);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(113, 185);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(227, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(204, 214);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(196, 176);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Visible = false;
            // 
            // painelBranco
            // 
            this.painelBranco.Location = new System.Drawing.Point(378, 573);
            this.painelBranco.Name = "painelBranco";
            this.painelBranco.Size = new System.Drawing.Size(200, 100);
            this.painelBranco.TabIndex = 6;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 621);
            this.Controls.Add(this.painelBranco);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.LoginPainel);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.lblHora);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 660);
            this.MinimumSize = new System.Drawing.Size(1200, 660);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.LoginPainel.ResumeLayout(false);
            this.LoginPainel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LoginPainel;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Timer hora;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel painelBranco;
    }
}

