namespace Sistema_Gerenciador_de_Consultorio
{
    partial class frmLocalizarPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalizarPaciente));
            this.atualizar = new System.Windows.Forms.Timer(this.components);
            this.dtgIntermediario = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgPaciente = new System.Windows.Forms.DataGridView();
            this.idPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnConsultar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDeletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.rbIdPaciente = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbRG = new System.Windows.Forms.RadioButton();
            this.rbSemFiltros = new System.Windows.Forms.RadioButton();
            this.nudPesquisar = new System.Windows.Forms.NumericUpDown();
            this.pnlPesquisar = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.msMenuSuperior = new System.Windows.Forms.MenuStrip();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesquisar)).BeginInit();
            this.pnlPesquisar.SuspendLayout();
            this.msMenuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // atualizar
            // 
            this.atualizar.Enabled = true;
            this.atualizar.Tick += new System.EventHandler(this.atualizar_Tick);
            // 
            // dtgIntermediario
            // 
            this.dtgIntermediario.AllowUserToAddRows = false;
            this.dtgIntermediario.AllowUserToDeleteRows = false;
            this.dtgIntermediario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIntermediario.Location = new System.Drawing.Point(1242, 573);
            this.dtgIntermediario.Margin = new System.Windows.Forms.Padding(4);
            this.dtgIntermediario.Name = "dtgIntermediario";
            this.dtgIntermediario.ReadOnly = true;
            this.dtgIntermediario.Size = new System.Drawing.Size(85, 20);
            this.dtgIntermediario.TabIndex = 48;
            this.dtgIntermediario.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Consultar";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dtgPaciente
            // 
            this.dtgPaciente.AllowUserToAddRows = false;
            this.dtgPaciente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgPaciente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPaciente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.dtgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaciente,
            this.idContato,
            this.idEndereco,
            this.usuario,
            this.nomePaciente,
            this.nomeResponsavel,
            this.rg,
            this.cpf,
            this.ocupacao,
            this.idade,
            this.sexo,
            this.dataNascimento,
            this.dataCadastro,
            this.horaCadastro,
            this.observacaoPaciente,
            this.btnImprimir,
            this.btnConsultar,
            this.btnEditar,
            this.btnDeletar});
            this.dtgPaciente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgPaciente.GridColor = System.Drawing.Color.Black;
            this.dtgPaciente.Location = new System.Drawing.Point(0, 204);
            this.dtgPaciente.Name = "dtgPaciente";
            this.dtgPaciente.ReadOnly = true;
            this.dtgPaciente.RowHeadersVisible = false;
            this.dtgPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPaciente.Size = new System.Drawing.Size(1160, 399);
            this.dtgPaciente.TabIndex = 2;
            this.dtgPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPaciente_CellClick);
            // 
            // idPaciente
            // 
            this.idPaciente.HeaderText = "Código";
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.ReadOnly = true;
            // 
            // idContato
            // 
            this.idContato.HeaderText = "Código Contato";
            this.idContato.Name = "idContato";
            this.idContato.ReadOnly = true;
            this.idContato.Visible = false;
            // 
            // idEndereco
            // 
            this.idEndereco.HeaderText = "Código Endereço";
            this.idEndereco.Name = "idEndereco";
            this.idEndereco.ReadOnly = true;
            this.idEndereco.Visible = false;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Código Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            // 
            // nomePaciente
            // 
            this.nomePaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomePaciente.HeaderText = "Paciente";
            this.nomePaciente.Name = "nomePaciente";
            this.nomePaciente.ReadOnly = true;
            // 
            // nomeResponsavel
            // 
            this.nomeResponsavel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeResponsavel.HeaderText = "Responsável";
            this.nomeResponsavel.Name = "nomeResponsavel";
            this.nomeResponsavel.ReadOnly = true;
            this.nomeResponsavel.Visible = false;
            // 
            // rg
            // 
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            this.rg.Visible = false;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Visible = false;
            // 
            // ocupacao
            // 
            this.ocupacao.HeaderText = "Ocupação";
            this.ocupacao.Name = "ocupacao";
            this.ocupacao.ReadOnly = true;
            this.ocupacao.Visible = false;
            // 
            // idade
            // 
            this.idade.HeaderText = "Idade";
            this.idade.Name = "idade";
            this.idade.ReadOnly = true;
            this.idade.Visible = false;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // dataNascimento
            // 
            this.dataNascimento.HeaderText = "D. Nascimento";
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.ReadOnly = true;
            this.dataNascimento.Width = 140;
            // 
            // dataCadastro
            // 
            this.dataCadastro.HeaderText = "D. Cadastro";
            this.dataCadastro.Name = "dataCadastro";
            this.dataCadastro.ReadOnly = true;
            this.dataCadastro.Visible = false;
            // 
            // horaCadastro
            // 
            this.horaCadastro.HeaderText = "Hora de Cadastro";
            this.horaCadastro.Name = "horaCadastro";
            this.horaCadastro.ReadOnly = true;
            this.horaCadastro.Visible = false;
            // 
            // observacaoPaciente
            // 
            this.observacaoPaciente.HeaderText = "Observação";
            this.observacaoPaciente.Name = "observacaoPaciente";
            this.observacaoPaciente.ReadOnly = true;
            this.observacaoPaciente.Visible = false;
            this.observacaoPaciente.Width = 182;
            // 
            // btnImprimir
            // 
            this.btnImprimir.HeaderText = "Imprimir";
            this.btnImprimir.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.imprimirIcon__1_;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ReadOnly = true;
            this.btnImprimir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnConsultar
            // 
            this.btnConsultar.HeaderText = "Consultar";
            this.btnConsultar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.consultaicon;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.EditarIcon__1_;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.HeaderText = "Deletar";
            this.btnDeletar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.deletarIcon__1_;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.ReadOnly = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(9, 16);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(305, 26);
            this.txtPesquisar.TabIndex = 6;
            this.txtPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisar.Visible = false;
            // 
            // rbIdPaciente
            // 
            this.rbIdPaciente.AutoSize = true;
            this.rbIdPaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIdPaciente.ForeColor = System.Drawing.Color.White;
            this.rbIdPaciente.Location = new System.Drawing.Point(9, 52);
            this.rbIdPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.rbIdPaciente.Name = "rbIdPaciente";
            this.rbIdPaciente.Size = new System.Drawing.Size(78, 22);
            this.rbIdPaciente.TabIndex = 0;
            this.rbIdPaciente.TabStop = true;
            this.rbIdPaciente.Text = "Código";
            this.rbIdPaciente.UseVisualStyleBackColor = true;
            this.rbIdPaciente.Click += new System.EventHandler(this.filtros);
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCPF.ForeColor = System.Drawing.Color.White;
            this.rbCPF.Location = new System.Drawing.Point(94, 52);
            this.rbCPF.Margin = new System.Windows.Forms.Padding(4);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(59, 22);
            this.rbCPF.TabIndex = 2;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.Click += new System.EventHandler(this.filtros);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(9, 86);
            this.rbNome.Margin = new System.Windows.Forms.Padding(4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(68, 22);
            this.rbNome.TabIndex = 1;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.Click += new System.EventHandler(this.filtros);
            // 
            // rbRG
            // 
            this.rbRG.AutoSize = true;
            this.rbRG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRG.ForeColor = System.Drawing.Color.White;
            this.rbRG.Location = new System.Drawing.Point(94, 86);
            this.rbRG.Margin = new System.Windows.Forms.Padding(4);
            this.rbRG.Name = "rbRG";
            this.rbRG.Size = new System.Drawing.Size(49, 22);
            this.rbRG.TabIndex = 3;
            this.rbRG.TabStop = true;
            this.rbRG.Text = "RG";
            this.rbRG.UseVisualStyleBackColor = true;
            this.rbRG.Click += new System.EventHandler(this.filtros);
            // 
            // rbSemFiltros
            // 
            this.rbSemFiltros.AutoSize = true;
            this.rbSemFiltros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSemFiltros.ForeColor = System.Drawing.Color.White;
            this.rbSemFiltros.Location = new System.Drawing.Point(160, 52);
            this.rbSemFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.rbSemFiltros.Name = "rbSemFiltros";
            this.rbSemFiltros.Size = new System.Drawing.Size(120, 22);
            this.rbSemFiltros.TabIndex = 4;
            this.rbSemFiltros.TabStop = true;
            this.rbSemFiltros.Text = "Retirar Filtros";
            this.rbSemFiltros.UseVisualStyleBackColor = true;
            this.rbSemFiltros.CheckedChanged += new System.EventHandler(this.rbSemFiltros_CheckedChanged);
            this.rbSemFiltros.Click += new System.EventHandler(this.filtros);
            // 
            // nudPesquisar
            // 
            this.nudPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPesquisar.Location = new System.Drawing.Point(9, 16);
            this.nudPesquisar.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.nudPesquisar.Name = "nudPesquisar";
            this.nudPesquisar.Size = new System.Drawing.Size(305, 26);
            this.nudPesquisar.TabIndex = 7;
            this.nudPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPesquisar.Visible = false;
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.pnlPesquisar.Controls.Add(this.rbSemFiltros);
            this.pnlPesquisar.Controls.Add(this.rbRG);
            this.pnlPesquisar.Controls.Add(this.rbNome);
            this.pnlPesquisar.Controls.Add(this.rbCPF);
            this.pnlPesquisar.Controls.Add(this.rbIdPaciente);
            this.pnlPesquisar.Controls.Add(this.btnPesquisar);
            this.pnlPesquisar.Controls.Add(this.txtPesquisar);
            this.pnlPesquisar.Controls.Add(this.nudPesquisar);
            this.pnlPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.pnlPesquisar.Location = new System.Drawing.Point(334, 50);
            this.pnlPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPesquisar.Name = "pnlPesquisar";
            this.pnlPesquisar.Size = new System.Drawing.Size(418, 131);
            this.pnlPesquisar.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.pesquisar;
            this.btnPesquisar.Location = new System.Drawing.Point(322, 13);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 30);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsuario.ForeColor = System.Drawing.Color.White;
            this.lblLoginUsuario.Location = new System.Drawing.Point(5, 50);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(127, 18);
            this.lblLoginUsuario.TabIndex = 49;
            this.lblLoginUsuario.Text = "Nome de usuario";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Consultar";
            this.dataGridViewImageColumn2.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.consultaicon;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // msMenuSuperior
            // 
            this.msMenuSuperior.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparToolStripMenuItem,
            this.voltarToolStripMenuItem});
            this.msMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.msMenuSuperior.Name = "msMenuSuperior";
            this.msMenuSuperior.Size = new System.Drawing.Size(1160, 26);
            this.msMenuSuperior.TabIndex = 50;
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.limparToolStripMenuItem.Text = "Limpar";
            this.limparToolStripMenuItem.Click += new System.EventHandler(this.limparToolStripMenuItem_Click);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // frmLocalizarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1160, 603);
            this.ControlBox = false;
            this.Controls.Add(this.lblLoginUsuario);
            this.Controls.Add(this.dtgPaciente);
            this.Controls.Add(this.dtgIntermediario);
            this.Controls.Add(this.pnlPesquisar);
            this.Controls.Add(this.msMenuSuperior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenuSuperior;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLocalizarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Paciente";
            this.Load += new System.EventHandler(this.frmLocalizarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesquisar)).EndInit();
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            this.msMenuSuperior.ResumeLayout(false);
            this.msMenuSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer atualizar;
        private System.Windows.Forms.DataGridView dtgIntermediario;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dtgPaciente;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton rbIdPaciente;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbRG;
        private System.Windows.Forms.RadioButton rbSemFiltros;
        private System.Windows.Forms.NumericUpDown nudPesquisar;
        private System.Windows.Forms.Panel pnlPesquisar;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContato;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeResponsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoPaciente;
        private System.Windows.Forms.DataGridViewImageColumn btnImprimir;
        private System.Windows.Forms.DataGridViewImageColumn btnConsultar;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnDeletar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.MenuStrip msMenuSuperior;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
    }
}