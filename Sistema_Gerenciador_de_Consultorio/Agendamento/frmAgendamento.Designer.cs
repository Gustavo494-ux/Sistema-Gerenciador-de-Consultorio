namespace Sistema_Gerenciador_de_Consultorio
{
    partial class frmAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendamento));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.lblUsuarioSistema = new System.Windows.Forms.Label();
            this.dtgIntermediario = new System.Windows.Forms.DataGridView();
            this.pnlMenuSuperior = new System.Windows.Forms.Panel();
            this.btnEditarAgendamento = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.AgendamentoTabControl = new System.Windows.Forms.TabControl();
            this.tpPacienteExistente = new System.Windows.Forms.TabPage();
            this.pnlPacienteExistente = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRG = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.rbSemFiltros = new System.Windows.Forms.RadioButton();
            this.rbIdPaciente = new System.Windows.Forms.RadioButton();
            this.btnPesquisarPaciente = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.nudPesquisar = new System.Windows.Forms.NumericUpDown();
            this.cbStatusConsultaPacienteExistente = new System.Windows.Forms.ComboBox();
            this.txtObservacaoPacienteExistente = new System.Windows.Forms.TextBox();
            this.dtpDataConsultaPacienteExistente = new System.Windows.Forms.DateTimePicker();
            this.dtgPaciente = new System.Windows.Forms.DataGridView();
            this.CodPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnAgendar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblDataConsulta = new System.Windows.Forms.Label();
            this.lblStatusConsultaPacienteExistente = new System.Windows.Forms.Label();
            this.lblObservacaoConsultaPacienteExistente = new System.Windows.Forms.Label();
            this.tpPacienteNovo = new System.Windows.Forms.TabPage();
            this.btnCadastrarEAgendar = new System.Windows.Forms.Button();
            this.rbDadosAgendamento = new System.Windows.Forms.RadioButton();
            this.rbEndereco = new System.Windows.Forms.RadioButton();
            this.rbContato = new System.Windows.Forms.RadioButton();
            this.rbDadosPessoais = new System.Windows.Forms.RadioButton();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.mtxtCPFNovo = new System.Windows.Forms.MaskedTextBox();
            this.mtxtRGNovo = new System.Windows.Forms.TextBox();
            this.lblCPFNovo = new System.Windows.Forms.Label();
            this.lblRGNovo = new System.Windows.Forms.Label();
            this.lblIdadeNovo = new System.Windows.Forms.Label();
            this.txtIdadeNovo = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblObservacaoNovo = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtObservacaoPacienteNovo = new System.Windows.Forms.TextBox();
            this.lblNomeResponsavelNovo = new System.Windows.Forms.Label();
            this.txtNomeResponsavelNovo = new System.Windows.Forms.TextBox();
            this.lblNomePacienteNovo = new System.Windows.Forms.Label();
            this.txtNomePacienteNovo = new System.Windows.Forms.TextBox();
            this.gbDadosAgendamento = new System.Windows.Forms.GroupBox();
            this.cbStatusConsultaNovo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservacaoAgendamentoNovo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataConsultaNovo = new System.Windows.Forms.DateTimePicker();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.txtObservacaoEnderecoNovo = new System.Windows.Forms.TextBox();
            this.lblObsercacaoEnderecoNovo = new System.Windows.Forms.Label();
            this.txtPontoReferenciaNovo = new System.Windows.Forms.TextBox();
            this.txtRuaNovo = new System.Windows.Forms.TextBox();
            this.lblPontoReferenciaNovo = new System.Windows.Forms.Label();
            this.lblRuaNovo = new System.Windows.Forms.Label();
            this.nudNumeroNovo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblbairroNovo = new System.Windows.Forms.Label();
            this.txtCidadeNovo = new System.Windows.Forms.TextBox();
            this.txtEstadoNovo = new System.Windows.Forms.TextBox();
            this.lblNumeroNovo = new System.Windows.Forms.Label();
            this.lblCidadeNovo = new System.Windows.Forms.Label();
            this.lblEstadoNovo = new System.Windows.Forms.Label();
            this.mtxtCEPNovo = new System.Windows.Forms.MaskedTextBox();
            this.lblCepNovo = new System.Windows.Forms.Label();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.mtxtTelefone3 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone2Novo = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone1Novo = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone3Novo = new System.Windows.Forms.Label();
            this.lblTelefone2Novo = new System.Windows.Forms.Label();
            this.lblTelefone1Novo = new System.Windows.Forms.Label();
            this.lblObservacaoContatoNovo = new System.Windows.Forms.Label();
            this.txtObservacaoContatoNovo = new System.Windows.Forms.TextBox();
            this.lblOutro = new System.Windows.Forms.Label();
            this.txtOutro = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).BeginInit();
            this.pnlMenuSuperior.SuspendLayout();
            this.AgendamentoTabControl.SuspendLayout();
            this.tpPacienteExistente.SuspendLayout();
            this.pnlPacienteExistente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaciente)).BeginInit();
            this.tpPacienteNovo.SuspendLayout();
            this.gbDadosPessoais.SuspendLayout();
            this.gbDadosAgendamento.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroNovo)).BeginInit();
            this.gbContato.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblUsuarioSistema
            // 
            this.lblUsuarioSistema.AutoSize = true;
            this.lblUsuarioSistema.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUsuarioSistema.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioSistema.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioSistema.Location = new System.Drawing.Point(4, 44);
            this.lblUsuarioSistema.Name = "lblUsuarioSistema";
            this.lblUsuarioSistema.Size = new System.Drawing.Size(120, 18);
            this.lblUsuarioSistema.TabIndex = 1;
            this.lblUsuarioSistema.Text = "UsuarioSistema";
            // 
            // dtgIntermediario
            // 
            this.dtgIntermediario.AllowUserToAddRows = false;
            this.dtgIntermediario.AllowUserToDeleteRows = false;
            this.dtgIntermediario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIntermediario.Location = new System.Drawing.Point(1004, 4);
            this.dtgIntermediario.Margin = new System.Windows.Forms.Padding(4);
            this.dtgIntermediario.Name = "dtgIntermediario";
            this.dtgIntermediario.Size = new System.Drawing.Size(85, 20);
            this.dtgIntermediario.TabIndex = 0;
            this.dtgIntermediario.Visible = false;
            // 
            // pnlMenuSuperior
            // 
            this.pnlMenuSuperior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenuSuperior.Controls.Add(this.btnEditarAgendamento);
            this.pnlMenuSuperior.Controls.Add(this.dtgIntermediario);
            this.pnlMenuSuperior.Controls.Add(this.btnCancelar);
            this.pnlMenuSuperior.Controls.Add(this.btnLimpar);
            this.pnlMenuSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuSuperior.Name = "pnlMenuSuperior";
            this.pnlMenuSuperior.Size = new System.Drawing.Size(1160, 40);
            this.pnlMenuSuperior.TabIndex = 2;
            // 
            // btnEditarAgendamento
            // 
            this.btnEditarAgendamento.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.agendamentos;
            this.btnEditarAgendamento.Location = new System.Drawing.Point(4, 6);
            this.btnEditarAgendamento.Name = "btnEditarAgendamento";
            this.btnEditarAgendamento.Size = new System.Drawing.Size(130, 30);
            this.btnEditarAgendamento.TabIndex = 2;
            this.btnEditarAgendamento.UseVisualStyleBackColor = true;
            this.btnEditarAgendamento.Click += new System.EventHandler(this.btnEditarAgendamento_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(236, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 30);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.limpar;
            this.btnLimpar.Location = new System.Drawing.Point(139, 6);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(91, 30);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // AgendamentoTabControl
            // 
            this.AgendamentoTabControl.Controls.Add(this.tpPacienteExistente);
            this.AgendamentoTabControl.Controls.Add(this.tpPacienteNovo);
            this.AgendamentoTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AgendamentoTabControl.Location = new System.Drawing.Point(0, 65);
            this.AgendamentoTabControl.Name = "AgendamentoTabControl";
            this.AgendamentoTabControl.SelectedIndex = 0;
            this.AgendamentoTabControl.Size = new System.Drawing.Size(1160, 538);
            this.AgendamentoTabControl.TabIndex = 11;
            // 
            // tpPacienteExistente
            // 
            this.tpPacienteExistente.Controls.Add(this.pnlPacienteExistente);
            this.tpPacienteExistente.Location = new System.Drawing.Point(4, 29);
            this.tpPacienteExistente.Name = "tpPacienteExistente";
            this.tpPacienteExistente.Padding = new System.Windows.Forms.Padding(3);
            this.tpPacienteExistente.Size = new System.Drawing.Size(1152, 505);
            this.tpPacienteExistente.TabIndex = 1;
            this.tpPacienteExistente.Text = "Paciente Existente";
            this.tpPacienteExistente.UseVisualStyleBackColor = true;
            // 
            // pnlPacienteExistente
            // 
            this.pnlPacienteExistente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.pnlPacienteExistente.Controls.Add(this.groupBox1);
            this.pnlPacienteExistente.Controls.Add(this.cbStatusConsultaPacienteExistente);
            this.pnlPacienteExistente.Controls.Add(this.txtObservacaoPacienteExistente);
            this.pnlPacienteExistente.Controls.Add(this.dtpDataConsultaPacienteExistente);
            this.pnlPacienteExistente.Controls.Add(this.dtgPaciente);
            this.pnlPacienteExistente.Controls.Add(this.lblDataConsulta);
            this.pnlPacienteExistente.Controls.Add(this.lblStatusConsultaPacienteExistente);
            this.pnlPacienteExistente.Controls.Add(this.lblObservacaoConsultaPacienteExistente);
            this.pnlPacienteExistente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPacienteExistente.Location = new System.Drawing.Point(3, 3);
            this.pnlPacienteExistente.Name = "pnlPacienteExistente";
            this.pnlPacienteExistente.Size = new System.Drawing.Size(1146, 499);
            this.pnlPacienteExistente.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRG);
            this.groupBox1.Controls.Add(this.rbNome);
            this.groupBox1.Controls.Add(this.rbCpf);
            this.groupBox1.Controls.Add(this.rbSemFiltros);
            this.groupBox1.Controls.Add(this.rbIdPaciente);
            this.groupBox1.Controls.Add(this.btnPesquisarPaciente);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.nudPesquisar);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(630, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 154);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // rbRG
            // 
            this.rbRG.AutoSize = true;
            this.rbRG.ForeColor = System.Drawing.Color.White;
            this.rbRG.Location = new System.Drawing.Point(322, 66);
            this.rbRG.Name = "rbRG";
            this.rbRG.Size = new System.Drawing.Size(49, 22);
            this.rbRG.TabIndex = 22;
            this.rbRG.TabStop = true;
            this.rbRG.Text = "RG";
            this.rbRG.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(183, 66);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(68, 22);
            this.rbNome.TabIndex = 23;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.ForeColor = System.Drawing.Color.White;
            this.rbCpf.Location = new System.Drawing.Point(258, 66);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(59, 22);
            this.rbCpf.TabIndex = 24;
            this.rbCpf.TabStop = true;
            this.rbCpf.Text = "CPF";
            this.rbCpf.UseVisualStyleBackColor = true;
            // 
            // rbSemFiltros
            // 
            this.rbSemFiltros.AutoSize = true;
            this.rbSemFiltros.ForeColor = System.Drawing.Color.White;
            this.rbSemFiltros.Location = new System.Drawing.Point(25, 66);
            this.rbSemFiltros.Name = "rbSemFiltros";
            this.rbSemFiltros.Size = new System.Drawing.Size(68, 22);
            this.rbSemFiltros.TabIndex = 25;
            this.rbSemFiltros.TabStop = true;
            this.rbSemFiltros.Text = "Todos";
            this.rbSemFiltros.UseVisualStyleBackColor = true;
            // 
            // rbIdPaciente
            // 
            this.rbIdPaciente.AutoSize = true;
            this.rbIdPaciente.ForeColor = System.Drawing.Color.White;
            this.rbIdPaciente.Location = new System.Drawing.Point(100, 66);
            this.rbIdPaciente.Name = "rbIdPaciente";
            this.rbIdPaciente.Size = new System.Drawing.Size(78, 22);
            this.rbIdPaciente.TabIndex = 26;
            this.rbIdPaciente.TabStop = true;
            this.rbIdPaciente.Text = "Código";
            this.rbIdPaciente.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarPaciente
            // 
            this.btnPesquisarPaciente.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.pesquisar;
            this.btnPesquisarPaciente.Font = new System.Drawing.Font("Arial", 12F);
            this.btnPesquisarPaciente.Location = new System.Drawing.Point(337, 31);
            this.btnPesquisarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarPaciente.Name = "btnPesquisarPaciente";
            this.btnPesquisarPaciente.Size = new System.Drawing.Size(91, 30);
            this.btnPesquisarPaciente.TabIndex = 18;
            this.btnPesquisarPaciente.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Location = new System.Drawing.Point(25, 34);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(305, 26);
            this.txtPesquisar.TabIndex = 19;
            this.txtPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisar.Visible = false;
            // 
            // nudPesquisar
            // 
            this.nudPesquisar.Location = new System.Drawing.Point(25, 34);
            this.nudPesquisar.Maximum = new decimal(new int[] {
            -559939585,
            902409669,
            54,
            0});
            this.nudPesquisar.Name = "nudPesquisar";
            this.nudPesquisar.Size = new System.Drawing.Size(305, 26);
            this.nudPesquisar.TabIndex = 21;
            this.nudPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPesquisar.Visible = false;
            // 
            // cbStatusConsultaPacienteExistente
            // 
            this.cbStatusConsultaPacienteExistente.Font = new System.Drawing.Font("Arial", 12F);
            this.cbStatusConsultaPacienteExistente.FormattingEnabled = true;
            this.cbStatusConsultaPacienteExistente.Location = new System.Drawing.Point(192, 41);
            this.cbStatusConsultaPacienteExistente.Name = "cbStatusConsultaPacienteExistente";
            this.cbStatusConsultaPacienteExistente.Size = new System.Drawing.Size(263, 26);
            this.cbStatusConsultaPacienteExistente.TabIndex = 0;
            // 
            // txtObservacaoPacienteExistente
            // 
            this.txtObservacaoPacienteExistente.Font = new System.Drawing.Font("Arial", 12F);
            this.txtObservacaoPacienteExistente.Location = new System.Drawing.Point(30, 91);
            this.txtObservacaoPacienteExistente.Multiline = true;
            this.txtObservacaoPacienteExistente.Name = "txtObservacaoPacienteExistente";
            this.txtObservacaoPacienteExistente.Size = new System.Drawing.Size(425, 77);
            this.txtObservacaoPacienteExistente.TabIndex = 0;
            // 
            // dtpDataConsultaPacienteExistente
            // 
            this.dtpDataConsultaPacienteExistente.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpDataConsultaPacienteExistente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataConsultaPacienteExistente.Location = new System.Drawing.Point(30, 39);
            this.dtpDataConsultaPacienteExistente.Name = "dtpDataConsultaPacienteExistente";
            this.dtpDataConsultaPacienteExistente.Size = new System.Drawing.Size(120, 26);
            this.dtpDataConsultaPacienteExistente.TabIndex = 0;
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
            this.CodPaciente,
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
            this.btnAgendar});
            this.dtgPaciente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgPaciente.Location = new System.Drawing.Point(0, 193);
            this.dtgPaciente.Name = "dtgPaciente";
            this.dtgPaciente.ReadOnly = true;
            this.dtgPaciente.RowHeadersVisible = false;
            this.dtgPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPaciente.Size = new System.Drawing.Size(1146, 306);
            this.dtgPaciente.TabIndex = 0;
            this.dtgPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPaciente_CellClick);
            // 
            // CodPaciente
            // 
            this.CodPaciente.HeaderText = "Código";
            this.CodPaciente.Name = "CodPaciente";
            this.CodPaciente.ReadOnly = true;
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
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
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
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // dataNascimento
            // 
            this.dataNascimento.FillWeight = 160F;
            this.dataNascimento.HeaderText = "Data Nasc.";
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.ReadOnly = true;
            this.dataNascimento.Width = 150;
            // 
            // dataCadastro
            // 
            this.dataCadastro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
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
            // 
            // btnAgendar
            // 
            this.btnAgendar.HeaderText = "Agendar";
            this.btnAgendar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.agendaricon;
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.ReadOnly = true;
            this.btnAgendar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lblDataConsulta
            // 
            this.lblDataConsulta.AutoSize = true;
            this.lblDataConsulta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDataConsulta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataConsulta.ForeColor = System.Drawing.Color.White;
            this.lblDataConsulta.Location = new System.Drawing.Point(32, 14);
            this.lblDataConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataConsulta.Name = "lblDataConsulta";
            this.lblDataConsulta.Size = new System.Drawing.Size(46, 18);
            this.lblDataConsulta.TabIndex = 0;
            this.lblDataConsulta.Text = "Data:";
            // 
            // lblStatusConsultaPacienteExistente
            // 
            this.lblStatusConsultaPacienteExistente.AutoSize = true;
            this.lblStatusConsultaPacienteExistente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblStatusConsultaPacienteExistente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusConsultaPacienteExistente.ForeColor = System.Drawing.Color.White;
            this.lblStatusConsultaPacienteExistente.Location = new System.Drawing.Point(188, 16);
            this.lblStatusConsultaPacienteExistente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusConsultaPacienteExistente.Name = "lblStatusConsultaPacienteExistente";
            this.lblStatusConsultaPacienteExistente.Size = new System.Drawing.Size(56, 18);
            this.lblStatusConsultaPacienteExistente.TabIndex = 0;
            this.lblStatusConsultaPacienteExistente.Text = "Status:";
            // 
            // lblObservacaoConsultaPacienteExistente
            // 
            this.lblObservacaoConsultaPacienteExistente.AutoSize = true;
            this.lblObservacaoConsultaPacienteExistente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblObservacaoConsultaPacienteExistente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacaoConsultaPacienteExistente.ForeColor = System.Drawing.Color.White;
            this.lblObservacaoConsultaPacienteExistente.Location = new System.Drawing.Point(26, 68);
            this.lblObservacaoConsultaPacienteExistente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacaoConsultaPacienteExistente.Name = "lblObservacaoConsultaPacienteExistente";
            this.lblObservacaoConsultaPacienteExistente.Size = new System.Drawing.Size(97, 18);
            this.lblObservacaoConsultaPacienteExistente.TabIndex = 0;
            this.lblObservacaoConsultaPacienteExistente.Text = "Observação:";
            // 
            // tpPacienteNovo
            // 
            this.tpPacienteNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.tpPacienteNovo.Controls.Add(this.gbDadosPessoais);
            this.tpPacienteNovo.Controls.Add(this.gbEndereco);
            this.tpPacienteNovo.Controls.Add(this.btnCadastrarEAgendar);
            this.tpPacienteNovo.Controls.Add(this.rbDadosAgendamento);
            this.tpPacienteNovo.Controls.Add(this.rbEndereco);
            this.tpPacienteNovo.Controls.Add(this.rbContato);
            this.tpPacienteNovo.Controls.Add(this.rbDadosPessoais);
            this.tpPacienteNovo.Controls.Add(this.gbDadosAgendamento);
            this.tpPacienteNovo.Controls.Add(this.gbContato);
            this.tpPacienteNovo.Location = new System.Drawing.Point(4, 29);
            this.tpPacienteNovo.Name = "tpPacienteNovo";
            this.tpPacienteNovo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPacienteNovo.Size = new System.Drawing.Size(1152, 505);
            this.tpPacienteNovo.TabIndex = 2;
            this.tpPacienteNovo.Text = "Paciente novo";
            // 
            // btnCadastrarEAgendar
            // 
            this.btnCadastrarEAgendar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.cadastraresagendar;
            this.btnCadastrarEAgendar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCadastrarEAgendar.Location = new System.Drawing.Point(979, 6);
            this.btnCadastrarEAgendar.Name = "btnCadastrarEAgendar";
            this.btnCadastrarEAgendar.Size = new System.Drawing.Size(165, 30);
            this.btnCadastrarEAgendar.TabIndex = 10;
            this.btnCadastrarEAgendar.UseVisualStyleBackColor = true;
            this.btnCadastrarEAgendar.Click += new System.EventHandler(this.btnCadastrarEAgendar_Click);
            // 
            // rbDadosAgendamento
            // 
            this.rbDadosAgendamento.AutoSize = true;
            this.rbDadosAgendamento.Checked = true;
            this.rbDadosAgendamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDadosAgendamento.ForeColor = System.Drawing.Color.White;
            this.rbDadosAgendamento.Location = new System.Drawing.Point(351, 4);
            this.rbDadosAgendamento.Name = "rbDadosAgendamento";
            this.rbDadosAgendamento.Size = new System.Drawing.Size(174, 22);
            this.rbDadosAgendamento.TabIndex = 5;
            this.rbDadosAgendamento.TabStop = true;
            this.rbDadosAgendamento.Text = "Dados Agendamento";
            this.rbDadosAgendamento.UseVisualStyleBackColor = true;
            this.rbDadosAgendamento.CheckedChanged += new System.EventHandler(this.rbDadosAgendamento_CheckedChanged);
            // 
            // rbEndereco
            // 
            this.rbEndereco.AutoSize = true;
            this.rbEndereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEndereco.ForeColor = System.Drawing.Color.White;
            this.rbEndereco.Location = new System.Drawing.Point(248, 4);
            this.rbEndereco.Name = "rbEndereco";
            this.rbEndereco.Size = new System.Drawing.Size(98, 22);
            this.rbEndereco.TabIndex = 5;
            this.rbEndereco.Text = "Endereço ";
            this.rbEndereco.UseVisualStyleBackColor = true;
            this.rbEndereco.CheckedChanged += new System.EventHandler(this.rbEndereco_CheckedChanged);
            // 
            // rbContato
            // 
            this.rbContato.AutoSize = true;
            this.rbContato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContato.ForeColor = System.Drawing.Color.White;
            this.rbContato.Location = new System.Drawing.Point(158, 4);
            this.rbContato.Name = "rbContato";
            this.rbContato.Size = new System.Drawing.Size(81, 22);
            this.rbContato.TabIndex = 5;
            this.rbContato.Text = "Contato";
            this.rbContato.UseVisualStyleBackColor = true;
            this.rbContato.CheckedChanged += new System.EventHandler(this.rbContato_CheckedChanged);
            // 
            // rbDadosPessoais
            // 
            this.rbDadosPessoais.AutoSize = true;
            this.rbDadosPessoais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDadosPessoais.ForeColor = System.Drawing.Color.White;
            this.rbDadosPessoais.Location = new System.Drawing.Point(9, 4);
            this.rbDadosPessoais.Name = "rbDadosPessoais";
            this.rbDadosPessoais.Size = new System.Drawing.Size(143, 22);
            this.rbDadosPessoais.TabIndex = 5;
            this.rbDadosPessoais.Text = "Dados Pessoais";
            this.rbDadosPessoais.UseVisualStyleBackColor = true;
            this.rbDadosPessoais.CheckedChanged += new System.EventHandler(this.rbDadosPessoais_CheckedChanged);
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.mtxtCPFNovo);
            this.gbDadosPessoais.Controls.Add(this.mtxtRGNovo);
            this.gbDadosPessoais.Controls.Add(this.lblCPFNovo);
            this.gbDadosPessoais.Controls.Add(this.lblRGNovo);
            this.gbDadosPessoais.Controls.Add(this.lblIdadeNovo);
            this.gbDadosPessoais.Controls.Add(this.txtIdadeNovo);
            this.gbDadosPessoais.Controls.Add(this.lblDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.lblObservacaoNovo);
            this.gbDadosPessoais.Controls.Add(this.dtpNascimento);
            this.gbDadosPessoais.Controls.Add(this.txtObservacaoPacienteNovo);
            this.gbDadosPessoais.Controls.Add(this.lblNomeResponsavelNovo);
            this.gbDadosPessoais.Controls.Add(this.txtNomeResponsavelNovo);
            this.gbDadosPessoais.Controls.Add(this.lblNomePacienteNovo);
            this.gbDadosPessoais.Controls.Add(this.txtNomePacienteNovo);
            this.gbDadosPessoais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosPessoais.ForeColor = System.Drawing.Color.White;
            this.gbDadosPessoais.Location = new System.Drawing.Point(157, 63);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(832, 264);
            this.gbDadosPessoais.TabIndex = 1;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            this.gbDadosPessoais.Visible = false;
            // 
            // mtxtCPFNovo
            // 
            this.mtxtCPFNovo.Location = new System.Drawing.Point(654, 63);
            this.mtxtCPFNovo.Mask = "000,000,000-00";
            this.mtxtCPFNovo.Name = "mtxtCPFNovo";
            this.mtxtCPFNovo.Size = new System.Drawing.Size(148, 26);
            this.mtxtCPFNovo.TabIndex = 53;
            this.mtxtCPFNovo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtRGNovo
            // 
            this.mtxtRGNovo.Location = new System.Drawing.Point(464, 63);
            this.mtxtRGNovo.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtRGNovo.Name = "mtxtRGNovo";
            this.mtxtRGNovo.Size = new System.Drawing.Size(148, 26);
            this.mtxtRGNovo.TabIndex = 52;
            // 
            // lblCPFNovo
            // 
            this.lblCPFNovo.AutoSize = true;
            this.lblCPFNovo.Location = new System.Drawing.Point(650, 39);
            this.lblCPFNovo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPFNovo.Name = "lblCPFNovo";
            this.lblCPFNovo.Size = new System.Drawing.Size(45, 18);
            this.lblCPFNovo.TabIndex = 51;
            this.lblCPFNovo.Text = "CPF:";
            // 
            // lblRGNovo
            // 
            this.lblRGNovo.AutoSize = true;
            this.lblRGNovo.Location = new System.Drawing.Point(460, 39);
            this.lblRGNovo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRGNovo.Name = "lblRGNovo";
            this.lblRGNovo.Size = new System.Drawing.Size(35, 18);
            this.lblRGNovo.TabIndex = 41;
            this.lblRGNovo.Text = "RG:";
            // 
            // lblIdadeNovo
            // 
            this.lblIdadeNovo.AutoSize = true;
            this.lblIdadeNovo.Location = new System.Drawing.Point(650, 95);
            this.lblIdadeNovo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdadeNovo.Name = "lblIdadeNovo";
            this.lblIdadeNovo.Size = new System.Drawing.Size(51, 18);
            this.lblIdadeNovo.TabIndex = 49;
            this.lblIdadeNovo.Text = "Idade:";
            // 
            // txtIdadeNovo
            // 
            this.txtIdadeNovo.Location = new System.Drawing.Point(654, 120);
            this.txtIdadeNovo.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdadeNovo.Name = "txtIdadeNovo";
            this.txtIdadeNovo.Size = new System.Drawing.Size(148, 26);
            this.txtIdadeNovo.TabIndex = 48;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(460, 95);
            this.lblDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(115, 18);
            this.lblDataNascimento.TabIndex = 47;
            this.lblDataNascimento.Text = "D. Nascimento:";
            // 
            // lblObservacaoNovo
            // 
            this.lblObservacaoNovo.AutoSize = true;
            this.lblObservacaoNovo.Location = new System.Drawing.Point(25, 153);
            this.lblObservacaoNovo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacaoNovo.Name = "lblObservacaoNovo";
            this.lblObservacaoNovo.Size = new System.Drawing.Size(97, 18);
            this.lblObservacaoNovo.TabIndex = 46;
            this.lblObservacaoNovo.Text = "Observação:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(464, 120);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(133, 26);
            this.dtpNascimento.TabIndex = 45;
            // 
            // txtObservacaoPacienteNovo
            // 
            this.txtObservacaoPacienteNovo.Location = new System.Drawing.Point(29, 178);
            this.txtObservacaoPacienteNovo.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacaoPacienteNovo.Multiline = true;
            this.txtObservacaoPacienteNovo.Name = "txtObservacaoPacienteNovo";
            this.txtObservacaoPacienteNovo.Size = new System.Drawing.Size(399, 61);
            this.txtObservacaoPacienteNovo.TabIndex = 44;
            // 
            // lblNomeResponsavelNovo
            // 
            this.lblNomeResponsavelNovo.AutoSize = true;
            this.lblNomeResponsavelNovo.Location = new System.Drawing.Point(25, 95);
            this.lblNomeResponsavelNovo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeResponsavelNovo.Name = "lblNomeResponsavelNovo";
            this.lblNomeResponsavelNovo.Size = new System.Drawing.Size(102, 18);
            this.lblNomeResponsavelNovo.TabIndex = 43;
            this.lblNomeResponsavelNovo.Text = "Responsável:";
            // 
            // txtNomeResponsavelNovo
            // 
            this.txtNomeResponsavelNovo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeResponsavelNovo.Location = new System.Drawing.Point(29, 120);
            this.txtNomeResponsavelNovo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeResponsavelNovo.Name = "txtNomeResponsavelNovo";
            this.txtNomeResponsavelNovo.Size = new System.Drawing.Size(399, 26);
            this.txtNomeResponsavelNovo.TabIndex = 42;
            // 
            // lblNomePacienteNovo
            // 
            this.lblNomePacienteNovo.AutoSize = true;
            this.lblNomePacienteNovo.Location = new System.Drawing.Point(25, 39);
            this.lblNomePacienteNovo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePacienteNovo.Name = "lblNomePacienteNovo";
            this.lblNomePacienteNovo.Size = new System.Drawing.Size(74, 18);
            this.lblNomePacienteNovo.TabIndex = 54;
            this.lblNomePacienteNovo.Text = "Paciente:";
            // 
            // txtNomePacienteNovo
            // 
            this.txtNomePacienteNovo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomePacienteNovo.Location = new System.Drawing.Point(29, 63);
            this.txtNomePacienteNovo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomePacienteNovo.Name = "txtNomePacienteNovo";
            this.txtNomePacienteNovo.Size = new System.Drawing.Size(399, 26);
            this.txtNomePacienteNovo.TabIndex = 50;
            // 
            // gbDadosAgendamento
            // 
            this.gbDadosAgendamento.Controls.Add(this.cbStatusConsultaNovo);
            this.gbDadosAgendamento.Controls.Add(this.label2);
            this.gbDadosAgendamento.Controls.Add(this.label3);
            this.gbDadosAgendamento.Controls.Add(this.txtObservacaoAgendamentoNovo);
            this.gbDadosAgendamento.Controls.Add(this.label4);
            this.gbDadosAgendamento.Controls.Add(this.dtpDataConsultaNovo);
            this.gbDadosAgendamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosAgendamento.ForeColor = System.Drawing.Color.White;
            this.gbDadosAgendamento.Location = new System.Drawing.Point(56, 87);
            this.gbDadosAgendamento.Name = "gbDadosAgendamento";
            this.gbDadosAgendamento.Size = new System.Drawing.Size(582, 215);
            this.gbDadosAgendamento.TabIndex = 4;
            this.gbDadosAgendamento.TabStop = false;
            this.gbDadosAgendamento.Text = "Dados Agendamento";
            this.gbDadosAgendamento.Visible = false;
            // 
            // cbStatusConsultaNovo
            // 
            this.cbStatusConsultaNovo.FormattingEnabled = true;
            this.cbStatusConsultaNovo.Location = new System.Drawing.Point(328, 55);
            this.cbStatusConsultaNovo.Name = "cbStatusConsultaNovo";
            this.cbStatusConsultaNovo.Size = new System.Drawing.Size(226, 26);
            this.cbStatusConsultaNovo.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Observação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Status:";
            // 
            // txtObservacaoAgendamentoNovo
            // 
            this.txtObservacaoAgendamentoNovo.Location = new System.Drawing.Point(22, 114);
            this.txtObservacaoAgendamentoNovo.Multiline = true;
            this.txtObservacaoAgendamentoNovo.Name = "txtObservacaoAgendamentoNovo";
            this.txtObservacaoAgendamentoNovo.Size = new System.Drawing.Size(532, 64);
            this.txtObservacaoAgendamentoNovo.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Data:";
            // 
            // dtpDataConsultaNovo
            // 
            this.dtpDataConsultaNovo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataConsultaNovo.Location = new System.Drawing.Point(26, 55);
            this.dtpDataConsultaNovo.Name = "dtpDataConsultaNovo";
            this.dtpDataConsultaNovo.Size = new System.Drawing.Size(124, 26);
            this.dtpDataConsultaNovo.TabIndex = 52;
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.txtObservacaoEnderecoNovo);
            this.gbEndereco.Controls.Add(this.lblObsercacaoEnderecoNovo);
            this.gbEndereco.Controls.Add(this.txtPontoReferenciaNovo);
            this.gbEndereco.Controls.Add(this.txtRuaNovo);
            this.gbEndereco.Controls.Add(this.lblPontoReferenciaNovo);
            this.gbEndereco.Controls.Add(this.lblRuaNovo);
            this.gbEndereco.Controls.Add(this.nudNumeroNovo);
            this.gbEndereco.Controls.Add(this.label1);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.lblbairroNovo);
            this.gbEndereco.Controls.Add(this.txtCidadeNovo);
            this.gbEndereco.Controls.Add(this.txtEstadoNovo);
            this.gbEndereco.Controls.Add(this.lblNumeroNovo);
            this.gbEndereco.Controls.Add(this.lblCidadeNovo);
            this.gbEndereco.Controls.Add(this.lblEstadoNovo);
            this.gbEndereco.Controls.Add(this.mtxtCEPNovo);
            this.gbEndereco.Controls.Add(this.lblCepNovo);
            this.gbEndereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEndereco.ForeColor = System.Drawing.Color.White;
            this.gbEndereco.Location = new System.Drawing.Point(107, 47);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(786, 341);
            this.gbEndereco.TabIndex = 3;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            this.gbEndereco.Visible = false;
            // 
            // txtObservacaoEnderecoNovo
            // 
            this.txtObservacaoEnderecoNovo.Location = new System.Drawing.Point(29, 239);
            this.txtObservacaoEnderecoNovo.Multiline = true;
            this.txtObservacaoEnderecoNovo.Name = "txtObservacaoEnderecoNovo";
            this.txtObservacaoEnderecoNovo.Size = new System.Drawing.Size(733, 80);
            this.txtObservacaoEnderecoNovo.TabIndex = 17;
            // 
            // lblObsercacaoEnderecoNovo
            // 
            this.lblObsercacaoEnderecoNovo.AutoSize = true;
            this.lblObsercacaoEnderecoNovo.Location = new System.Drawing.Point(26, 215);
            this.lblObsercacaoEnderecoNovo.Name = "lblObsercacaoEnderecoNovo";
            this.lblObsercacaoEnderecoNovo.Size = new System.Drawing.Size(97, 18);
            this.lblObsercacaoEnderecoNovo.TabIndex = 18;
            this.lblObsercacaoEnderecoNovo.Text = "Observação:";
            // 
            // txtPontoReferenciaNovo
            // 
            this.txtPontoReferenciaNovo.Location = new System.Drawing.Point(29, 170);
            this.txtPontoReferenciaNovo.Multiline = true;
            this.txtPontoReferenciaNovo.Name = "txtPontoReferenciaNovo";
            this.txtPontoReferenciaNovo.ShortcutsEnabled = false;
            this.txtPontoReferenciaNovo.Size = new System.Drawing.Size(733, 39);
            this.txtPontoReferenciaNovo.TabIndex = 13;
            // 
            // txtRuaNovo
            // 
            this.txtRuaNovo.Location = new System.Drawing.Point(29, 115);
            this.txtRuaNovo.Name = "txtRuaNovo";
            this.txtRuaNovo.Size = new System.Drawing.Size(733, 26);
            this.txtRuaNovo.TabIndex = 14;
            // 
            // lblPontoReferenciaNovo
            // 
            this.lblPontoReferenciaNovo.AutoSize = true;
            this.lblPontoReferenciaNovo.Location = new System.Drawing.Point(26, 146);
            this.lblPontoReferenciaNovo.Name = "lblPontoReferenciaNovo";
            this.lblPontoReferenciaNovo.Size = new System.Drawing.Size(127, 18);
            this.lblPontoReferenciaNovo.TabIndex = 15;
            this.lblPontoReferenciaNovo.Text = "P. de Referência:";
            // 
            // lblRuaNovo
            // 
            this.lblRuaNovo.AutoSize = true;
            this.lblRuaNovo.Location = new System.Drawing.Point(26, 91);
            this.lblRuaNovo.Name = "lblRuaNovo";
            this.lblRuaNovo.Size = new System.Drawing.Size(40, 18);
            this.lblRuaNovo.TabIndex = 16;
            this.lblRuaNovo.Text = "Rua:";
            // 
            // nudNumeroNovo
            // 
            this.nudNumeroNovo.Location = new System.Drawing.Point(503, 54);
            this.nudNumeroNovo.Name = "nudNumeroNovo";
            this.nudNumeroNovo.Size = new System.Drawing.Size(120, 26);
            this.nudNumeroNovo.TabIndex = 11;
            this.nudNumeroNovo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Número:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(313, 54);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(184, 26);
            this.txtBairro.TabIndex = 9;
            // 
            // lblbairroNovo
            // 
            this.lblbairroNovo.AutoSize = true;
            this.lblbairroNovo.Location = new System.Drawing.Point(310, 31);
            this.lblbairroNovo.Name = "lblbairroNovo";
            this.lblbairroNovo.Size = new System.Drawing.Size(55, 18);
            this.lblbairroNovo.TabIndex = 10;
            this.lblbairroNovo.Text = "Bairro:";
            // 
            // txtCidadeNovo
            // 
            this.txtCidadeNovo.Location = new System.Drawing.Point(174, 54);
            this.txtCidadeNovo.Name = "txtCidadeNovo";
            this.txtCidadeNovo.Size = new System.Drawing.Size(133, 26);
            this.txtCidadeNovo.TabIndex = 2;
            // 
            // txtEstadoNovo
            // 
            this.txtEstadoNovo.Location = new System.Drawing.Point(29, 54);
            this.txtEstadoNovo.Name = "txtEstadoNovo";
            this.txtEstadoNovo.Size = new System.Drawing.Size(139, 26);
            this.txtEstadoNovo.TabIndex = 3;
            // 
            // lblNumeroNovo
            // 
            this.lblNumeroNovo.AutoSize = true;
            this.lblNumeroNovo.Location = new System.Drawing.Point(313, 58);
            this.lblNumeroNovo.Name = "lblNumeroNovo";
            this.lblNumeroNovo.Size = new System.Drawing.Size(67, 18);
            this.lblNumeroNovo.TabIndex = 4;
            this.lblNumeroNovo.Text = "Número:";
            // 
            // lblCidadeNovo
            // 
            this.lblCidadeNovo.AutoSize = true;
            this.lblCidadeNovo.Location = new System.Drawing.Point(171, 31);
            this.lblCidadeNovo.Name = "lblCidadeNovo";
            this.lblCidadeNovo.Size = new System.Drawing.Size(64, 18);
            this.lblCidadeNovo.TabIndex = 5;
            this.lblCidadeNovo.Text = "Cidade:";
            // 
            // lblEstadoNovo
            // 
            this.lblEstadoNovo.AutoSize = true;
            this.lblEstadoNovo.Location = new System.Drawing.Point(26, 31);
            this.lblEstadoNovo.Name = "lblEstadoNovo";
            this.lblEstadoNovo.Size = new System.Drawing.Size(62, 18);
            this.lblEstadoNovo.TabIndex = 6;
            this.lblEstadoNovo.Text = "Estado:";
            // 
            // mtxtCEPNovo
            // 
            this.mtxtCEPNovo.Location = new System.Drawing.Point(629, 54);
            this.mtxtCEPNovo.Mask = "00,000-000";
            this.mtxtCEPNovo.Name = "mtxtCEPNovo";
            this.mtxtCEPNovo.Size = new System.Drawing.Size(133, 26);
            this.mtxtCEPNovo.TabIndex = 7;
            this.mtxtCEPNovo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCepNovo
            // 
            this.lblCepNovo.AutoSize = true;
            this.lblCepNovo.Location = new System.Drawing.Point(629, 31);
            this.lblCepNovo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCepNovo.Name = "lblCepNovo";
            this.lblCepNovo.Size = new System.Drawing.Size(46, 18);
            this.lblCepNovo.TabIndex = 8;
            this.lblCepNovo.Text = "CEP:";
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.mtxtTelefone3);
            this.gbContato.Controls.Add(this.mtxtTelefone2Novo);
            this.gbContato.Controls.Add(this.mtxtTelefone1Novo);
            this.gbContato.Controls.Add(this.lblTelefone3Novo);
            this.gbContato.Controls.Add(this.lblTelefone2Novo);
            this.gbContato.Controls.Add(this.lblTelefone1Novo);
            this.gbContato.Controls.Add(this.lblObservacaoContatoNovo);
            this.gbContato.Controls.Add(this.txtObservacaoContatoNovo);
            this.gbContato.Controls.Add(this.lblOutro);
            this.gbContato.Controls.Add(this.txtOutro);
            this.gbContato.Controls.Add(this.lblEmail);
            this.gbContato.Controls.Add(this.txtEmail);
            this.gbContato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContato.ForeColor = System.Drawing.Color.White;
            this.gbContato.Location = new System.Drawing.Point(135, 88);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(517, 339);
            this.gbContato.TabIndex = 2;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            this.gbContato.Visible = false;
            // 
            // mtxtTelefone3
            // 
            this.mtxtTelefone3.Location = new System.Drawing.Point(340, 107);
            this.mtxtTelefone3.Mask = "(00)0,0000-0000";
            this.mtxtTelefone3.Name = "mtxtTelefone3";
            this.mtxtTelefone3.Size = new System.Drawing.Size(148, 26);
            this.mtxtTelefone3.TabIndex = 13;
            this.mtxtTelefone3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtTelefone2Novo
            // 
            this.mtxtTelefone2Novo.Location = new System.Drawing.Point(186, 107);
            this.mtxtTelefone2Novo.Mask = "(00)0,0000-0000";
            this.mtxtTelefone2Novo.Name = "mtxtTelefone2Novo";
            this.mtxtTelefone2Novo.Size = new System.Drawing.Size(148, 26);
            this.mtxtTelefone2Novo.TabIndex = 14;
            this.mtxtTelefone2Novo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtTelefone1Novo
            // 
            this.mtxtTelefone1Novo.Location = new System.Drawing.Point(32, 107);
            this.mtxtTelefone1Novo.Mask = "(00)0,0000-0000";
            this.mtxtTelefone1Novo.Name = "mtxtTelefone1Novo";
            this.mtxtTelefone1Novo.Size = new System.Drawing.Size(148, 26);
            this.mtxtTelefone1Novo.TabIndex = 15;
            this.mtxtTelefone1Novo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTelefone3Novo
            // 
            this.lblTelefone3Novo.AutoSize = true;
            this.lblTelefone3Novo.Location = new System.Drawing.Point(336, 83);
            this.lblTelefone3Novo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone3Novo.Name = "lblTelefone3Novo";
            this.lblTelefone3Novo.Size = new System.Drawing.Size(83, 18);
            this.lblTelefone3Novo.TabIndex = 16;
            this.lblTelefone3Novo.Text = "Telefone 3:";
            // 
            // lblTelefone2Novo
            // 
            this.lblTelefone2Novo.AutoSize = true;
            this.lblTelefone2Novo.Location = new System.Drawing.Point(182, 83);
            this.lblTelefone2Novo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone2Novo.Name = "lblTelefone2Novo";
            this.lblTelefone2Novo.Size = new System.Drawing.Size(83, 18);
            this.lblTelefone2Novo.TabIndex = 17;
            this.lblTelefone2Novo.Text = "Telefone 2:";
            // 
            // lblTelefone1Novo
            // 
            this.lblTelefone1Novo.AutoSize = true;
            this.lblTelefone1Novo.Location = new System.Drawing.Point(28, 83);
            this.lblTelefone1Novo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone1Novo.Name = "lblTelefone1Novo";
            this.lblTelefone1Novo.Size = new System.Drawing.Size(83, 18);
            this.lblTelefone1Novo.TabIndex = 18;
            this.lblTelefone1Novo.Text = "Telefone 1:";
            // 
            // lblObservacaoContatoNovo
            // 
            this.lblObservacaoContatoNovo.AutoSize = true;
            this.lblObservacaoContatoNovo.Location = new System.Drawing.Point(25, 221);
            this.lblObservacaoContatoNovo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacaoContatoNovo.Name = "lblObservacaoContatoNovo";
            this.lblObservacaoContatoNovo.Size = new System.Drawing.Size(97, 18);
            this.lblObservacaoContatoNovo.TabIndex = 7;
            this.lblObservacaoContatoNovo.Text = "Observação:";
            // 
            // txtObservacaoContatoNovo
            // 
            this.txtObservacaoContatoNovo.Location = new System.Drawing.Point(29, 246);
            this.txtObservacaoContatoNovo.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacaoContatoNovo.Multiline = true;
            this.txtObservacaoContatoNovo.Name = "txtObservacaoContatoNovo";
            this.txtObservacaoContatoNovo.Size = new System.Drawing.Size(458, 61);
            this.txtObservacaoContatoNovo.TabIndex = 8;
            // 
            // lblOutro
            // 
            this.lblOutro.AutoSize = true;
            this.lblOutro.Location = new System.Drawing.Point(27, 139);
            this.lblOutro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutro.Name = "lblOutro";
            this.lblOutro.Size = new System.Drawing.Size(152, 18);
            this.lblOutro.TabIndex = 9;
            this.lblOutro.Text = "Outro/Complemento:";
            // 
            // txtOutro
            // 
            this.txtOutro.Location = new System.Drawing.Point(31, 164);
            this.txtOutro.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutro.Multiline = true;
            this.txtOutro.Name = "txtOutro";
            this.txtOutro.Size = new System.Drawing.Size(456, 52);
            this.txtOutro.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(26, 28);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 18);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(30, 52);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(458, 26);
            this.txtEmail.TabIndex = 12;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Agendar";
            this.dataGridViewImageColumn1.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.agendaricon;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1160, 603);
            this.ControlBox = false;
            this.Controls.Add(this.lblUsuarioSistema);
            this.Controls.Add(this.AgendamentoTabControl);
            this.Controls.Add(this.pnlMenuSuperior);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1110, 593);
            this.Name = "frmAgendamento";
            this.RightToLeftLayout = true;
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamentos";
            this.Load += new System.EventHandler(this.frmAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).EndInit();
            this.pnlMenuSuperior.ResumeLayout(false);
            this.AgendamentoTabControl.ResumeLayout(false);
            this.tpPacienteExistente.ResumeLayout(false);
            this.pnlPacienteExistente.ResumeLayout(false);
            this.pnlPacienteExistente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaciente)).EndInit();
            this.tpPacienteNovo.ResumeLayout(false);
            this.tpPacienteNovo.PerformLayout();
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbDadosAgendamento.ResumeLayout(false);
            this.gbDadosAgendamento.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroNovo)).EndInit();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnEditarAgendamento;
        private System.Windows.Forms.Label lblUsuarioSistema;
        private System.Windows.Forms.DataGridView dtgIntermediario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel pnlMenuSuperior;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnCadastrarEAgendar;
        private System.Windows.Forms.TabControl AgendamentoTabControl;
        private System.Windows.Forms.TabPage tpPacienteExistente;
        private System.Windows.Forms.Panel pnlPacienteExistente;
        private System.Windows.Forms.ComboBox cbStatusConsultaPacienteExistente;
        private System.Windows.Forms.TextBox txtObservacaoPacienteExistente;
        private System.Windows.Forms.DateTimePicker dtpDataConsultaPacienteExistente;
        private System.Windows.Forms.DataGridView dtgPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPaciente;
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
        private System.Windows.Forms.DataGridViewImageColumn btnAgendar;
        private System.Windows.Forms.Label lblDataConsulta;
        private System.Windows.Forms.Label lblStatusConsultaPacienteExistente;
        private System.Windows.Forms.Label lblObservacaoConsultaPacienteExistente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRG;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.RadioButton rbSemFiltros;
        private System.Windows.Forms.RadioButton rbIdPaciente;
        private System.Windows.Forms.Button btnPesquisarPaciente;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.NumericUpDown nudPesquisar;
        private System.Windows.Forms.TabPage tpPacienteNovo;
        private System.Windows.Forms.GroupBox gbDadosAgendamento;
        private System.Windows.Forms.ComboBox cbStatusConsultaNovo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservacaoAgendamentoNovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataConsultaNovo;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.TextBox txtObservacaoEnderecoNovo;
        private System.Windows.Forms.Label lblObsercacaoEnderecoNovo;
        private System.Windows.Forms.TextBox txtPontoReferenciaNovo;
        private System.Windows.Forms.TextBox txtRuaNovo;
        private System.Windows.Forms.Label lblPontoReferenciaNovo;
        private System.Windows.Forms.Label lblRuaNovo;
        private System.Windows.Forms.NumericUpDown nudNumeroNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblbairroNovo;
        private System.Windows.Forms.TextBox txtCidadeNovo;
        private System.Windows.Forms.TextBox txtEstadoNovo;
        private System.Windows.Forms.Label lblNumeroNovo;
        private System.Windows.Forms.Label lblCidadeNovo;
        private System.Windows.Forms.Label lblEstadoNovo;
        private System.Windows.Forms.MaskedTextBox mtxtCEPNovo;
        private System.Windows.Forms.Label lblCepNovo;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone3;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone2Novo;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone1Novo;
        private System.Windows.Forms.Label lblTelefone3Novo;
        private System.Windows.Forms.Label lblTelefone2Novo;
        private System.Windows.Forms.Label lblTelefone1Novo;
        private System.Windows.Forms.Label lblObservacaoContatoNovo;
        private System.Windows.Forms.TextBox txtObservacaoContatoNovo;
        private System.Windows.Forms.Label lblOutro;
        private System.Windows.Forms.TextBox txtOutro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.MaskedTextBox mtxtCPFNovo;
        private System.Windows.Forms.TextBox mtxtRGNovo;
        private System.Windows.Forms.Label lblCPFNovo;
        private System.Windows.Forms.Label lblRGNovo;
        private System.Windows.Forms.Label lblIdadeNovo;
        private System.Windows.Forms.TextBox txtIdadeNovo;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblObservacaoNovo;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.TextBox txtObservacaoPacienteNovo;
        private System.Windows.Forms.Label lblNomeResponsavelNovo;
        private System.Windows.Forms.TextBox txtNomeResponsavelNovo;
        private System.Windows.Forms.Label lblNomePacienteNovo;
        private System.Windows.Forms.TextBox txtNomePacienteNovo;
        private System.Windows.Forms.RadioButton rbDadosPessoais;
        private System.Windows.Forms.RadioButton rbContato;
        private System.Windows.Forms.RadioButton rbEndereco;
        private System.Windows.Forms.RadioButton rbDadosAgendamento;
    }
}