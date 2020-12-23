namespace Sistema_Gerenciador_de_Consultorio
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pesquisarPnl = new System.Windows.Forms.Panel();
            this.CadastrarPnl = new System.Windows.Forms.Panel();
            this.pnlMenuSuperior = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPesquisarConsulta = new System.Windows.Forms.Button();
            this.btnPesquisarPaciente = new System.Windows.Forms.Button();
            this.btnPesquisarProfissional = new System.Windows.Forms.Button();
            this.btnCadastrarPaciente = new System.Windows.Forms.Button();
            this.btncadastrarProfissional = new System.Windows.Forms.Button();
            this.btnDadosDeletados = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.btnRelatotorios = new System.Windows.Forms.Button();
            this.pesquisarPnl.SuspendLayout();
            this.CadastrarPnl.SuspendLayout();
            this.pnlMenuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pesquisarPnl
            // 
            this.pesquisarPnl.BackColor = System.Drawing.Color.Transparent;
            this.pesquisarPnl.Controls.Add(this.btnPesquisarConsulta);
            this.pesquisarPnl.Controls.Add(this.btnPesquisarPaciente);
            this.pesquisarPnl.Controls.Add(this.btnPesquisarProfissional);
            this.pesquisarPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.pesquisarPnl.Location = new System.Drawing.Point(96, 36);
            this.pesquisarPnl.Name = "pesquisarPnl";
            this.pesquisarPnl.Size = new System.Drawing.Size(125, 127);
            this.pesquisarPnl.TabIndex = 2;
            this.pesquisarPnl.Visible = false;
            // 
            // CadastrarPnl
            // 
            this.CadastrarPnl.BackColor = System.Drawing.Color.Transparent;
            this.CadastrarPnl.Controls.Add(this.btnCadastrarPaciente);
            this.CadastrarPnl.Controls.Add(this.btncadastrarProfissional);
            this.CadastrarPnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.CadastrarPnl.Location = new System.Drawing.Point(0, 34);
            this.CadastrarPnl.Name = "CadastrarPnl";
            this.CadastrarPnl.Size = new System.Drawing.Size(125, 99);
            this.CadastrarPnl.TabIndex = 1;
            this.CadastrarPnl.Visible = false;
            // 
            // pnlMenuSuperior
            // 
            this.pnlMenuSuperior.BackColor = System.Drawing.Color.White;
            this.pnlMenuSuperior.Controls.Add(this.btnDadosDeletados);
            this.pnlMenuSuperior.Controls.Add(this.btnCadastrar);
            this.pnlMenuSuperior.Controls.Add(this.btnUsuarios);
            this.pnlMenuSuperior.Controls.Add(this.btnPesquisar);
            this.pnlMenuSuperior.Controls.Add(this.btnAgendar);
            this.pnlMenuSuperior.Controls.Add(this.btnDeslogar);
            this.pnlMenuSuperior.Controls.Add(this.btnRelatotorios);
            this.pnlMenuSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMenuSuperior.Location = new System.Drawing.Point(0, 1);
            this.pnlMenuSuperior.Name = "pnlMenuSuperior";
            this.pnlMenuSuperior.Size = new System.Drawing.Size(1268, 35);
            this.pnlMenuSuperior.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPesquisarConsulta
            // 
            this.btnPesquisarConsulta.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.Consulta;
            this.btnPesquisarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarConsulta.Location = new System.Drawing.Point(14, 86);
            this.btnPesquisarConsulta.Name = "btnPesquisarConsulta";
            this.btnPesquisarConsulta.Size = new System.Drawing.Size(91, 30);
            this.btnPesquisarConsulta.TabIndex = 2;
            this.btnPesquisarConsulta.UseVisualStyleBackColor = true;
            this.btnPesquisarConsulta.Click += new System.EventHandler(this.btnPesquisarConsulta_Click);
            // 
            // btnPesquisarPaciente
            // 
            this.btnPesquisarPaciente.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.paciente;
            this.btnPesquisarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarPaciente.Location = new System.Drawing.Point(14, 47);
            this.btnPesquisarPaciente.Name = "btnPesquisarPaciente";
            this.btnPesquisarPaciente.Size = new System.Drawing.Size(91, 30);
            this.btnPesquisarPaciente.TabIndex = 1;
            this.btnPesquisarPaciente.UseVisualStyleBackColor = true;
            this.btnPesquisarPaciente.Click += new System.EventHandler(this.btnPesquisarPaciente_Click);
            // 
            // btnPesquisarProfissional
            // 
            this.btnPesquisarProfissional.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.profissional1;
            this.btnPesquisarProfissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProfissional.Location = new System.Drawing.Point(14, 8);
            this.btnPesquisarProfissional.Name = "btnPesquisarProfissional";
            this.btnPesquisarProfissional.Size = new System.Drawing.Size(91, 30);
            this.btnPesquisarProfissional.TabIndex = 0;
            this.btnPesquisarProfissional.UseVisualStyleBackColor = true;
            this.btnPesquisarProfissional.Click += new System.EventHandler(this.btnPesquisarProfissional_Click);
            // 
            // btnCadastrarPaciente
            // 
            this.btnCadastrarPaciente.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.paciente;
            this.btnCadastrarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPaciente.Location = new System.Drawing.Point(13, 47);
            this.btnCadastrarPaciente.Name = "btnCadastrarPaciente";
            this.btnCadastrarPaciente.Size = new System.Drawing.Size(91, 30);
            this.btnCadastrarPaciente.TabIndex = 1;
            this.btnCadastrarPaciente.UseVisualStyleBackColor = true;
            this.btnCadastrarPaciente.Click += new System.EventHandler(this.btnCadastrarPaciente_Click);
            // 
            // btncadastrarProfissional
            // 
            this.btncadastrarProfissional.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.profissional;
            this.btncadastrarProfissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrarProfissional.Location = new System.Drawing.Point(13, 9);
            this.btncadastrarProfissional.Name = "btncadastrarProfissional";
            this.btncadastrarProfissional.Size = new System.Drawing.Size(91, 30);
            this.btncadastrarProfissional.TabIndex = 0;
            this.btncadastrarProfissional.UseVisualStyleBackColor = true;
            this.btncadastrarProfissional.Click += new System.EventHandler(this.btncadastrarProfissional_Click);
            // 
            // btnDadosDeletados
            // 
            this.btnDadosDeletados.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.Dados_Deletados1;
            this.btnDadosDeletados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDadosDeletados.Location = new System.Drawing.Point(391, 3);
            this.btnDadosDeletados.Name = "btnDadosDeletados";
            this.btnDadosDeletados.Size = new System.Drawing.Size(150, 30);
            this.btnDadosDeletados.TabIndex = 3;
            this.btnDadosDeletados.UseVisualStyleBackColor = true;
            this.btnDadosDeletados.Visible = false;
            this.btnDadosDeletados.Click += new System.EventHandler(this.btnDadosDeletados_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.cadastrar;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(91, 30);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.loginicon;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(1180, 2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUsuarios.Size = new System.Drawing.Size(35, 30);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.pesquisar;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(100, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 30);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.agendar_;
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.Location = new System.Drawing.Point(197, 3);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(91, 30);
            this.btnAgendar.TabIndex = 0;
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.sairicon;
            this.btnDeslogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeslogar.Location = new System.Drawing.Point(1221, 3);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(35, 30);
            this.btnDeslogar.TabIndex = 0;
            this.btnDeslogar.UseVisualStyleBackColor = true;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // btnRelatotorios
            // 
            this.btnRelatotorios.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.relatorios;
            this.btnRelatotorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatotorios.Location = new System.Drawing.Point(294, 3);
            this.btnRelatotorios.Name = "btnRelatotorios";
            this.btnRelatotorios.Size = new System.Drawing.Size(91, 30);
            this.btnRelatotorios.TabIndex = 0;
            this.btnRelatotorios.UseVisualStyleBackColor = true;
            this.btnRelatotorios.Click += new System.EventHandler(this.btnRelatotorios_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 785);
            this.Controls.Add(this.pesquisarPnl);
            this.Controls.Add(this.CadastrarPnl);
            this.Controls.Add(this.pnlMenuSuperior);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pesquisarPnl.ResumeLayout(false);
            this.CadastrarPnl.ResumeLayout(false);
            this.pnlMenuSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pesquisarPnl;
        private System.Windows.Forms.Button btnPesquisarConsulta;
        private System.Windows.Forms.Button btnPesquisarPaciente;
        private System.Windows.Forms.Button btnPesquisarProfissional;
        private System.Windows.Forms.Panel CadastrarPnl;
        private System.Windows.Forms.Button btnCadastrarPaciente;
        private System.Windows.Forms.Button btncadastrarProfissional;
        private System.Windows.Forms.Panel pnlMenuSuperior;
        private System.Windows.Forms.Button btnDeslogar;
        private System.Windows.Forms.Button btnRelatotorios;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDadosDeletados;
    }
}