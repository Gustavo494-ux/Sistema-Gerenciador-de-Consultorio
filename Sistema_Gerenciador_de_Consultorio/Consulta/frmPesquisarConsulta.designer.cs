namespace Sistema_Gerenciador_de_Consultorio
{
    partial class frmPesquisarConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarConsulta));
            this.atualizar = new System.Windows.Forms.Timer(this.components);
            this.dtgConsulta = new System.Windows.Forms.DataGridView();
            this.pnlPesquisar = new System.Windows.Forms.Panel();
            this.rbIdPaciente = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbRG = new System.Windows.Forms.RadioButton();
            this.rbNomePaciente = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbIdCosulta = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.nudPesquisar = new System.Windows.Forms.NumericUpDown();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.msMenuSuperior = new System.Windows.Forms.MenuStrip();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgIntermediario = new System.Windows.Forms.DataGridView();
            this.idConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProfissionalCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProfissional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimirConsulta = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnImprimirReceita = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDeletar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).BeginInit();
            this.pnlPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesquisar)).BeginInit();
            this.msMenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).BeginInit();
            this.SuspendLayout();
            // 
            // atualizar
            // 
            this.atualizar.Enabled = true;
            this.atualizar.Tick += new System.EventHandler(this.atualizar_Tick);
            // 
            // dtgConsulta
            // 
            this.dtgConsulta.AllowUserToAddRows = false;
            this.dtgConsulta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.dtgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConsulta,
            this.nomePaciente,
            this.idProfissionalCadastro,
            this.nomeProfissional,
            this.idUsuarioCadastro,
            this.UsuarioCadastro,
            this.dataConsulta,
            this.horaConsulta,
            this.statusConsulta,
            this.observacaoConsulta,
            this.btnImprimirConsulta,
            this.btnImprimirReceita,
            this.btnEditar,
            this.btnDeletar});
            this.dtgConsulta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgConsulta.EnableHeadersVisualStyles = false;
            this.dtgConsulta.GridColor = System.Drawing.Color.Black;
            this.dtgConsulta.Location = new System.Drawing.Point(0, 174);
            this.dtgConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgConsulta.Name = "dtgConsulta";
            this.dtgConsulta.ReadOnly = true;
            this.dtgConsulta.RowHeadersVisible = false;
            this.dtgConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsulta.Size = new System.Drawing.Size(1160, 429);
            this.dtgConsulta.TabIndex = 2;
            this.dtgConsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConsulta_CellClick);
            this.dtgConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConsulta_CellContentClick);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.pnlPesquisar.Controls.Add(this.rbIdPaciente);
            this.pnlPesquisar.Controls.Add(this.rbTodos);
            this.pnlPesquisar.Controls.Add(this.rbRG);
            this.pnlPesquisar.Controls.Add(this.rbNomePaciente);
            this.pnlPesquisar.Controls.Add(this.rbCPF);
            this.pnlPesquisar.Controls.Add(this.rbIdCosulta);
            this.pnlPesquisar.Controls.Add(this.btnPesquisar);
            this.pnlPesquisar.Controls.Add(this.txtPesquisar);
            this.pnlPesquisar.Controls.Add(this.nudPesquisar);
            this.pnlPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.pnlPesquisar.Location = new System.Drawing.Point(381, 54);
            this.pnlPesquisar.Name = "pnlPesquisar";
            this.pnlPesquisar.Size = new System.Drawing.Size(421, 115);
            this.pnlPesquisar.TabIndex = 1;
            // 
            // rbIdPaciente
            // 
            this.rbIdPaciente.AutoSize = true;
            this.rbIdPaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIdPaciente.ForeColor = System.Drawing.Color.White;
            this.rbIdPaciente.Location = new System.Drawing.Point(14, 74);
            this.rbIdPaciente.Name = "rbIdPaciente";
            this.rbIdPaciente.Size = new System.Drawing.Size(144, 22);
            this.rbIdPaciente.TabIndex = 6;
            this.rbIdPaciente.TabStop = true;
            this.rbIdPaciente.Text = "Código Paciente";
            this.rbIdPaciente.UseVisualStyleBackColor = true;
            this.rbIdPaciente.Click += new System.EventHandler(this.filtros);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.Color.White;
            this.rbTodos.Location = new System.Drawing.Point(238, 46);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(68, 22);
            this.rbTodos.TabIndex = 5;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            this.rbTodos.Click += new System.EventHandler(this.filtros);
            // 
            // rbRG
            // 
            this.rbRG.AutoSize = true;
            this.rbRG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRG.ForeColor = System.Drawing.Color.White;
            this.rbRG.Location = new System.Drawing.Point(164, 74);
            this.rbRG.Name = "rbRG";
            this.rbRG.Size = new System.Drawing.Size(49, 22);
            this.rbRG.TabIndex = 5;
            this.rbRG.TabStop = true;
            this.rbRG.Text = "RG";
            this.rbRG.UseVisualStyleBackColor = true;
            this.rbRG.Click += new System.EventHandler(this.filtros);
            // 
            // rbNomePaciente
            // 
            this.rbNomePaciente.AutoSize = true;
            this.rbNomePaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNomePaciente.ForeColor = System.Drawing.Color.White;
            this.rbNomePaciente.Location = new System.Drawing.Point(164, 46);
            this.rbNomePaciente.Name = "rbNomePaciente";
            this.rbNomePaciente.Size = new System.Drawing.Size(68, 22);
            this.rbNomePaciente.TabIndex = 5;
            this.rbNomePaciente.TabStop = true;
            this.rbNomePaciente.Text = "Nome";
            this.rbNomePaciente.UseVisualStyleBackColor = true;
            this.rbNomePaciente.Click += new System.EventHandler(this.filtros);
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCPF.ForeColor = System.Drawing.Color.White;
            this.rbCPF.Location = new System.Drawing.Point(238, 74);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(59, 22);
            this.rbCPF.TabIndex = 5;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.Click += new System.EventHandler(this.filtros);
            // 
            // rbIdCosulta
            // 
            this.rbIdCosulta.AutoSize = true;
            this.rbIdCosulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIdCosulta.ForeColor = System.Drawing.Color.White;
            this.rbIdCosulta.Location = new System.Drawing.Point(14, 46);
            this.rbIdCosulta.Name = "rbIdCosulta";
            this.rbIdCosulta.Size = new System.Drawing.Size(143, 22);
            this.rbIdCosulta.TabIndex = 5;
            this.rbIdCosulta.TabStop = true;
            this.rbIdCosulta.Text = "Código Consulta";
            this.rbIdCosulta.UseVisualStyleBackColor = true;
            this.rbIdCosulta.Click += new System.EventHandler(this.filtros);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.pesquisar;
            this.btnPesquisar.Location = new System.Drawing.Point(314, 14);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 30);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(3, 14);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(305, 26);
            this.txtPesquisar.TabIndex = 2;
            this.txtPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudPesquisar
            // 
            this.nudPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPesquisar.Location = new System.Drawing.Point(3, 14);
            this.nudPesquisar.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nudPesquisar.Name = "nudPesquisar";
            this.nudPesquisar.Size = new System.Drawing.Size(305, 26);
            this.nudPesquisar.TabIndex = 10;
            this.nudPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPesquisar.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudPesquisar.Visible = false;
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsuario.ForeColor = System.Drawing.Color.White;
            this.lblLoginUsuario.Location = new System.Drawing.Point(5, 50);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(127, 18);
            this.lblLoginUsuario.TabIndex = 7;
            this.lblLoginUsuario.Text = "Nome de usuario";
            // 
            // msMenuSuperior
            // 
            this.msMenuSuperior.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparToolStripMenuItem,
            this.cancelarToolStripMenuItem});
            this.msMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.msMenuSuperior.Name = "msMenuSuperior";
            this.msMenuSuperior.Size = new System.Drawing.Size(1160, 26);
            this.msMenuSuperior.TabIndex = 8;
            this.msMenuSuperior.Text = "menuStrip1";
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.limparToolStripMenuItem.Text = "Limpar";
            this.limparToolStripMenuItem.Click += new System.EventHandler(this.limparToolStripMenuItem_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            this.cancelarToolStripMenuItem.Click += new System.EventHandler(this.cancelarToolStripMenuItem_Click);
            // 
            // dtgIntermediario
            // 
            this.dtgIntermediario.AllowUserToAddRows = false;
            this.dtgIntermediario.AllowUserToDeleteRows = false;
            this.dtgIntermediario.AllowUserToResizeColumns = false;
            this.dtgIntermediario.AllowUserToResizeRows = false;
            this.dtgIntermediario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIntermediario.Location = new System.Drawing.Point(823, 81);
            this.dtgIntermediario.MultiSelect = false;
            this.dtgIntermediario.Name = "dtgIntermediario";
            this.dtgIntermediario.RowHeadersVisible = false;
            this.dtgIntermediario.ShowCellToolTips = false;
            this.dtgIntermediario.Size = new System.Drawing.Size(89, 17);
            this.dtgIntermediario.TabIndex = 10;
            this.dtgIntermediario.Visible = false;
            // 
            // idConsulta
            // 
            this.idConsulta.HeaderText = "Código";
            this.idConsulta.Name = "idConsulta";
            this.idConsulta.ReadOnly = true;
            // 
            // nomePaciente
            // 
            this.nomePaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomePaciente.HeaderText = "Paciente";
            this.nomePaciente.Name = "nomePaciente";
            this.nomePaciente.ReadOnly = true;
            // 
            // idProfissionalCadastro
            // 
            this.idProfissionalCadastro.HeaderText = "idProfissionalCadastro";
            this.idProfissionalCadastro.Name = "idProfissionalCadastro";
            this.idProfissionalCadastro.ReadOnly = true;
            this.idProfissionalCadastro.Visible = false;
            // 
            // nomeProfissional
            // 
            this.nomeProfissional.HeaderText = "Profissional";
            this.nomeProfissional.Name = "nomeProfissional";
            this.nomeProfissional.ReadOnly = true;
            this.nomeProfissional.Visible = false;
            // 
            // idUsuarioCadastro
            // 
            this.idUsuarioCadastro.HeaderText = "idUsuario";
            this.idUsuarioCadastro.Name = "idUsuarioCadastro";
            this.idUsuarioCadastro.ReadOnly = true;
            this.idUsuarioCadastro.Visible = false;
            // 
            // UsuarioCadastro
            // 
            this.UsuarioCadastro.HeaderText = "Usuario";
            this.UsuarioCadastro.Name = "UsuarioCadastro";
            this.UsuarioCadastro.ReadOnly = true;
            // 
            // dataConsulta
            // 
            this.dataConsulta.HeaderText = "Data";
            this.dataConsulta.Name = "dataConsulta";
            this.dataConsulta.ReadOnly = true;
            // 
            // horaConsulta
            // 
            this.horaConsulta.HeaderText = "Hora";
            this.horaConsulta.Name = "horaConsulta";
            this.horaConsulta.ReadOnly = true;
            // 
            // statusConsulta
            // 
            this.statusConsulta.HeaderText = "Status";
            this.statusConsulta.Name = "statusConsulta";
            this.statusConsulta.ReadOnly = true;
            // 
            // observacaoConsulta
            // 
            this.observacaoConsulta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.observacaoConsulta.HeaderText = "Observação";
            this.observacaoConsulta.Name = "observacaoConsulta";
            this.observacaoConsulta.ReadOnly = true;
            this.observacaoConsulta.Visible = false;
            // 
            // btnImprimirConsulta
            // 
            this.btnImprimirConsulta.HeaderText = "Imprimir";
            this.btnImprimirConsulta.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.imprimirIcon__1_;
            this.btnImprimirConsulta.Name = "btnImprimirConsulta";
            this.btnImprimirConsulta.ReadOnly = true;
            this.btnImprimirConsulta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnImprimirConsulta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnImprimirConsulta.Visible = false;
            // 
            // btnImprimirReceita
            // 
            this.btnImprimirReceita.HeaderText = "Receita";
            this.btnImprimirReceita.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.receitaimprimiricon;
            this.btnImprimirReceita.Name = "btnImprimirReceita";
            this.btnImprimirReceita.ReadOnly = true;
            this.btnImprimirReceita.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnImprimirReceita.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // frmPesquisarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1160, 603);
            this.ControlBox = false;
            this.Controls.Add(this.dtgIntermediario);
            this.Controls.Add(this.lblLoginUsuario);
            this.Controls.Add(this.pnlPesquisar);
            this.Controls.Add(this.dtgConsulta);
            this.Controls.Add(this.msMenuSuperior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPesquisarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Consulta";
            this.Load += new System.EventHandler(this.frmPesquisarConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsulta)).EndInit();
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesquisar)).EndInit();
            this.msMenuSuperior.ResumeLayout(false);
            this.msMenuSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer atualizar;
        private System.Windows.Forms.DataGridView dtgConsulta;
        private System.Windows.Forms.Panel pnlPesquisar;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbRG;
        private System.Windows.Forms.RadioButton rbNomePaciente;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbIdCosulta;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.RadioButton rbIdPaciente;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.NumericUpDown nudPesquisar;
        private System.Windows.Forms.MenuStrip msMenuSuperior;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgIntermediario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfissionalCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProfissional;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoConsulta;
        private System.Windows.Forms.DataGridViewImageColumn btnImprimirConsulta;
        private System.Windows.Forms.DataGridViewImageColumn btnImprimirReceita;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnDeletar;
    }
}