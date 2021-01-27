namespace Sistema_Gerenciador_de_Consultorio
{
    partial class frmLocalizarProfissional
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalizarProfissional));
            this.atualizar = new System.Windows.Forms.Timer(this.components);
            this.dtgIntermediario = new System.Windows.Forms.DataGridView();
            this.pnlPesquisar = new System.Windows.Forms.Panel();
            this.nudPesquisar = new System.Windows.Forms.NumericUpDown();
            this.rbCroo = new System.Windows.Forms.RadioButton();
            this.rbEspecialidade = new System.Windows.Forms.RadioButton();
            this.rbRG = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.rbSemFiltros = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.rbIdProfissional = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.dtgProfissional = new System.Windows.Forms.DataGridView();
            this.idProfissional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProfissional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.croo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDeCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoProfissional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDeletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.msMenuSuperior = new System.Windows.Forms.MenuStrip();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).BeginInit();
            this.pnlPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfissional)).BeginInit();
            this.msMenuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgIntermediario
            // 
            this.dtgIntermediario.AllowUserToAddRows = false;
            this.dtgIntermediario.AllowUserToDeleteRows = false;
            this.dtgIntermediario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIntermediario.Location = new System.Drawing.Point(204, 279);
            this.dtgIntermediario.Name = "dtgIntermediario";
            this.dtgIntermediario.ReadOnly = true;
            this.dtgIntermediario.Size = new System.Drawing.Size(228, 121);
            this.dtgIntermediario.TabIndex = 0;
            this.dtgIntermediario.Visible = false;
            this.dtgIntermediario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgIntermediario_CellContentClick);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.pnlPesquisar.Controls.Add(this.nudPesquisar);
            this.pnlPesquisar.Controls.Add(this.rbCroo);
            this.pnlPesquisar.Controls.Add(this.rbEspecialidade);
            this.pnlPesquisar.Controls.Add(this.rbRG);
            this.pnlPesquisar.Controls.Add(this.rbNome);
            this.pnlPesquisar.Controls.Add(this.txtPesquisar);
            this.pnlPesquisar.Controls.Add(this.rbSemFiltros);
            this.pnlPesquisar.Controls.Add(this.rbCPF);
            this.pnlPesquisar.Controls.Add(this.rbIdProfissional);
            this.pnlPesquisar.Controls.Add(this.btnPesquisar);
            this.pnlPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPesquisar.Location = new System.Drawing.Point(414, 50);
            this.pnlPesquisar.Name = "pnlPesquisar";
            this.pnlPesquisar.Size = new System.Drawing.Size(425, 118);
            this.pnlPesquisar.TabIndex = 1;
            // 
            // nudPesquisar
            // 
            this.nudPesquisar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPesquisar.Location = new System.Drawing.Point(3, 7);
            this.nudPesquisar.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.nudPesquisar.Name = "nudPesquisar";
            this.nudPesquisar.Size = new System.Drawing.Size(305, 29);
            this.nudPesquisar.TabIndex = 9;
            this.nudPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPesquisar.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudPesquisar.Visible = false;
            // 
            // rbCroo
            // 
            this.rbCroo.AutoSize = true;
            this.rbCroo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCroo.ForeColor = System.Drawing.Color.White;
            this.rbCroo.Location = new System.Drawing.Point(105, 72);
            this.rbCroo.Name = "rbCroo";
            this.rbCroo.Size = new System.Drawing.Size(73, 22);
            this.rbCroo.TabIndex = 6;
            this.rbCroo.TabStop = true;
            this.rbCroo.Text = "CROO";
            this.rbCroo.UseVisualStyleBackColor = true;
            this.rbCroo.Click += new System.EventHandler(this.filtros);
            // 
            // rbEspecialidade
            // 
            this.rbEspecialidade.AutoSize = true;
            this.rbEspecialidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEspecialidade.ForeColor = System.Drawing.Color.White;
            this.rbEspecialidade.Location = new System.Drawing.Point(184, 70);
            this.rbEspecialidade.Name = "rbEspecialidade";
            this.rbEspecialidade.Size = new System.Drawing.Size(127, 22);
            this.rbEspecialidade.TabIndex = 7;
            this.rbEspecialidade.TabStop = true;
            this.rbEspecialidade.Text = "Especialidade";
            this.rbEspecialidade.UseVisualStyleBackColor = true;
            this.rbEspecialidade.Click += new System.EventHandler(this.filtros);
            // 
            // rbRG
            // 
            this.rbRG.AutoSize = true;
            this.rbRG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRG.ForeColor = System.Drawing.Color.White;
            this.rbRG.Location = new System.Drawing.Point(21, 70);
            this.rbRG.Name = "rbRG";
            this.rbRG.Size = new System.Drawing.Size(49, 22);
            this.rbRG.TabIndex = 5;
            this.rbRG.TabStop = true;
            this.rbRG.Text = "RG";
            this.rbRG.UseVisualStyleBackColor = true;
            this.rbRG.Click += new System.EventHandler(this.filtros);
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(105, 42);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(68, 22);
            this.rbNome.TabIndex = 2;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.Click += new System.EventHandler(this.filtros);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(3, 7);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(305, 29);
            this.txtPesquisar.TabIndex = 9;
            this.txtPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbSemFiltros
            // 
            this.rbSemFiltros.AutoSize = true;
            this.rbSemFiltros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSemFiltros.ForeColor = System.Drawing.Color.White;
            this.rbSemFiltros.Location = new System.Drawing.Point(249, 42);
            this.rbSemFiltros.Name = "rbSemFiltros";
            this.rbSemFiltros.Size = new System.Drawing.Size(68, 22);
            this.rbSemFiltros.TabIndex = 4;
            this.rbSemFiltros.TabStop = true;
            this.rbSemFiltros.Text = "Todos";
            this.rbSemFiltros.UseVisualStyleBackColor = true;
            this.rbSemFiltros.CheckedChanged += new System.EventHandler(this.rbSemFiltros_CheckedChanged);
            this.rbSemFiltros.Click += new System.EventHandler(this.filtros);
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCPF.ForeColor = System.Drawing.Color.White;
            this.rbCPF.Location = new System.Drawing.Point(184, 42);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(59, 22);
            this.rbCPF.TabIndex = 3;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.Click += new System.EventHandler(this.filtros);
            // 
            // rbIdProfissional
            // 
            this.rbIdProfissional.AutoSize = true;
            this.rbIdProfissional.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIdProfissional.ForeColor = System.Drawing.Color.White;
            this.rbIdProfissional.Location = new System.Drawing.Point(21, 42);
            this.rbIdProfissional.Name = "rbIdProfissional";
            this.rbIdProfissional.Size = new System.Drawing.Size(78, 22);
            this.rbIdProfissional.TabIndex = 1;
            this.rbIdProfissional.TabStop = true;
            this.rbIdProfissional.Text = "Código";
            this.rbIdProfissional.Click += new System.EventHandler(this.filtros);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.pesquisar1;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisar.Location = new System.Drawing.Point(314, 7);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 30);
            this.btnPesquisar.TabIndex = 8;
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
            this.lblLoginUsuario.TabIndex = 0;
            this.lblLoginUsuario.Text = "Nome de usuario";
            // 
            // dtgProfissional
            // 
            this.dtgProfissional.AllowUserToAddRows = false;
            this.dtgProfissional.AllowUserToDeleteRows = false;
            this.dtgProfissional.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.dtgProfissional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProfissional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProfissional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProfissional,
            this.idEndereco,
            this.idContato,
            this.codigoUsuario,
            this.nomeProfissional,
            this.especialidade,
            this.rg,
            this.cpf,
            this.sexo,
            this.croo,
            this.dataNascimento,
            this.dataDeCadastro,
            this.horaDeCadastro,
            this.observacaoProfissional,
            this.btnImprimir,
            this.btnEditar,
            this.btnDeletar});
            this.dtgProfissional.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProfissional.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProfissional.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgProfissional.GridColor = System.Drawing.Color.Black;
            this.dtgProfissional.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.dtgProfissional.Location = new System.Drawing.Point(0, 204);
            this.dtgProfissional.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgProfissional.MultiSelect = false;
            this.dtgProfissional.Name = "dtgProfissional";
            this.dtgProfissional.ReadOnly = true;
            this.dtgProfissional.RowHeadersVisible = false;
            dataGridViewCellStyle5.Format = "g";
            dataGridViewCellStyle5.NullValue = null;
            this.dtgProfissional.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgProfissional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProfissional.Size = new System.Drawing.Size(1160, 399);
            this.dtgProfissional.TabIndex = 3;
            this.dtgProfissional.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProfissional_CellClick);
            // 
            // idProfissional
            // 
            this.idProfissional.Frozen = true;
            this.idProfissional.HeaderText = "Código";
            this.idProfissional.Name = "idProfissional";
            this.idProfissional.ReadOnly = true;
            this.idProfissional.Width = 168;
            // 
            // idEndereco
            // 
            this.idEndereco.HeaderText = "Código Endereço";
            this.idEndereco.Name = "idEndereco";
            this.idEndereco.ReadOnly = true;
            this.idEndereco.Visible = false;
            // 
            // idContato
            // 
            this.idContato.HeaderText = "Código Contato";
            this.idContato.Name = "idContato";
            this.idContato.ReadOnly = true;
            this.idContato.Visible = false;
            // 
            // codigoUsuario
            // 
            this.codigoUsuario.HeaderText = "Código Usuario";
            this.codigoUsuario.Name = "codigoUsuario";
            this.codigoUsuario.ReadOnly = true;
            this.codigoUsuario.Visible = false;
            // 
            // nomeProfissional
            // 
            this.nomeProfissional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeProfissional.HeaderText = "Nome";
            this.nomeProfissional.Name = "nomeProfissional";
            this.nomeProfissional.ReadOnly = true;
            // 
            // especialidade
            // 
            this.especialidade.HeaderText = "Especilidade";
            this.especialidade.Name = "especialidade";
            this.especialidade.ReadOnly = true;
            this.especialidade.Width = 190;
            // 
            // rg
            // 
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            this.rg.Visible = false;
            this.rg.Width = 168;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Visible = false;
            this.cpf.Width = 168;
            // 
            // sexo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sexo.DefaultCellStyle = dataGridViewCellStyle1;
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sexo.Visible = false;
            this.sexo.Width = 168;
            // 
            // croo
            // 
            this.croo.HeaderText = "CROO";
            this.croo.Name = "croo";
            this.croo.ReadOnly = true;
            this.croo.Visible = false;
            this.croo.Width = 168;
            // 
            // dataNascimento
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "dd/mm/yyyy";
            this.dataNascimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataNascimento.HeaderText = "Data Nasc.";
            this.dataNascimento.MaxInputLength = 10;
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.ReadOnly = true;
            this.dataNascimento.Visible = false;
            this.dataNascimento.Width = 168;
            // 
            // dataDeCadastro
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataDeCadastro.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataDeCadastro.HeaderText = "D. Cadastro";
            this.dataDeCadastro.Name = "dataDeCadastro";
            this.dataDeCadastro.ReadOnly = true;
            this.dataDeCadastro.Width = 120;
            // 
            // horaDeCadastro
            // 
            this.horaDeCadastro.HeaderText = "H. Cadastro";
            this.horaDeCadastro.Name = "horaDeCadastro";
            this.horaDeCadastro.ReadOnly = true;
            this.horaDeCadastro.Visible = false;
            // 
            // observacaoProfissional
            // 
            this.observacaoProfissional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.observacaoProfissional.HeaderText = "Observação";
            this.observacaoProfissional.Name = "observacaoProfissional";
            this.observacaoProfissional.ReadOnly = true;
            this.observacaoProfissional.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.HeaderText = "Imprimir";
            this.btnImprimir.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.imprimirIcon__1_;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ReadOnly = true;
            this.btnImprimir.Width = 40;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.EditarIcon__1_;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Width = 40;
            // 
            // btnDeletar
            // 
            this.btnDeletar.HeaderText = "Deletar";
            this.btnDeletar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.deletarIcon__1_;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.ReadOnly = true;
            this.btnDeletar.Width = 40;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Imprimir";
            this.dataGridViewImageColumn1.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.imprimirIcon;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.EditarIcon;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 40;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Deletar";
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 40;
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
            this.msMenuSuperior.TabIndex = 4;
            this.msMenuSuperior.Text = "menuStrip1";
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 603);
            this.panel1.TabIndex = 5;
            // 
            // frmLocalizarProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1160, 603);
            this.ControlBox = false;
            this.Controls.Add(this.lblLoginUsuario);
            this.Controls.Add(this.dtgIntermediario);
            this.Controls.Add(this.pnlPesquisar);
            this.Controls.Add(this.dtgProfissional);
            this.Controls.Add(this.msMenuSuperior);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLocalizarProfissional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Profissional";
            this.Load += new System.EventHandler(this.frmLocalizarProfissional_Load);
            this.Click += new System.EventHandler(this.filtros);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).EndInit();
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfissional)).EndInit();
            this.msMenuSuperior.ResumeLayout(false);
            this.msMenuSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer atualizar;
        private System.Windows.Forms.Panel pnlPesquisar;
        private System.Windows.Forms.NumericUpDown nudPesquisar;
        private System.Windows.Forms.RadioButton rbCroo;
        private System.Windows.Forms.RadioButton rbEspecialidade;
        private System.Windows.Forms.RadioButton rbRG;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.RadioButton rbSemFiltros;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.RadioButton rbIdProfissional;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dtgIntermediario;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.DataGridView dtgProfissional;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfissional;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContato;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProfissional;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn croo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDeCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoProfissional;
        private System.Windows.Forms.DataGridViewImageColumn btnImprimir;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnDeletar;
        private System.Windows.Forms.MenuStrip msMenuSuperior;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}