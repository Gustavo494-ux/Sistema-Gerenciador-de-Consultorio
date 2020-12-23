namespace Sistema_Gerenciador_de_Consultorio
{
    partial class frmEditarAgendamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarAgendamento));
            this.pnlPesquisarEditar = new System.Windows.Forms.Panel();
            this.painelSuperior = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvarEdicao = new System.Windows.Forms.Button();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.dtgIntermediario = new System.Windows.Forms.DataGridView();
            this.cbStatusConsultaEditar = new System.Windows.Forms.ComboBox();
            this.lblObservacaoPacienteEditar = new System.Windows.Forms.Label();
            this.lblStatusConsultaEditar = new System.Windows.Forms.Label();
            this.txtObservacaoAgendamentoEditar = new System.Windows.Forms.TextBox();
            this.lblDataConsultaEditar = new System.Windows.Forms.Label();
            this.dtpDataConsultaEditar = new System.Windows.Forms.DateTimePicker();
            this.dtgPesquisarConsultasAgendadas = new System.Windows.Forms.DataGridView();
            this.idAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroGeral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPessoaFisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaChegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnPacientePresente = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbPesquisar = new System.Windows.Forms.GroupBox();
            this.btnPesquisarAgendamento = new System.Windows.Forms.Button();
            this.rbDataConsulta = new System.Windows.Forms.RadioButton();
            this.rbCpf = new System.Windows.Forms.RadioButton();
            this.rbNomePaciente = new System.Windows.Forms.RadioButton();
            this.rbDataNascimento = new System.Windows.Forms.RadioButton();
            this.rbStatusAgendamento = new System.Windows.Forms.RadioButton();
            this.rbRG = new System.Windows.Forms.RadioButton();
            this.rbTodasConsultas = new System.Windows.Forms.RadioButton();
            this.txtPesquisarAgendamento = new System.Windows.Forms.TextBox();
            this.cbStatusPesquisar = new System.Windows.Forms.ComboBox();
            this.dtpDataInicialPesquisa = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinalPesquisa = new System.Windows.Forms.DateTimePicker();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlPesquisarEditar.SuspendLayout();
            this.painelSuperior.SuspendLayout();
            this.gbEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisarConsultasAgendadas)).BeginInit();
            this.gbPesquisar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPesquisarEditar
            // 
            this.pnlPesquisarEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.pnlPesquisarEditar.Controls.Add(this.painelSuperior);
            this.pnlPesquisarEditar.Controls.Add(this.gbEditar);
            this.pnlPesquisarEditar.Controls.Add(this.dtgPesquisarConsultasAgendadas);
            this.pnlPesquisarEditar.Controls.Add(this.gbPesquisar);
            this.pnlPesquisarEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPesquisarEditar.Location = new System.Drawing.Point(0, 0);
            this.pnlPesquisarEditar.Name = "pnlPesquisarEditar";
            this.pnlPesquisarEditar.Size = new System.Drawing.Size(1160, 603);
            this.pnlPesquisarEditar.TabIndex = 2;
            // 
            // painelSuperior
            // 
            this.painelSuperior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.painelSuperior.Controls.Add(this.btnCancelar);
            this.painelSuperior.Controls.Add(this.btnSalvarEdicao);
            this.painelSuperior.Location = new System.Drawing.Point(0, 0);
            this.painelSuperior.Name = "painelSuperior";
            this.painelSuperior.Size = new System.Drawing.Size(1160, 40);
            this.painelSuperior.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(107, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvarEdicao
            // 
            this.btnSalvarEdicao.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.Alterar;
            this.btnSalvarEdicao.Location = new System.Drawing.Point(10, 3);
            this.btnSalvarEdicao.Name = "btnSalvarEdicao";
            this.btnSalvarEdicao.Size = new System.Drawing.Size(91, 30);
            this.btnSalvarEdicao.TabIndex = 0;
            this.btnSalvarEdicao.UseVisualStyleBackColor = true;
            this.btnSalvarEdicao.Click += new System.EventHandler(this.btnSalvarEdicao_Click);
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.dtgIntermediario);
            this.gbEditar.Controls.Add(this.cbStatusConsultaEditar);
            this.gbEditar.Controls.Add(this.lblObservacaoPacienteEditar);
            this.gbEditar.Controls.Add(this.lblStatusConsultaEditar);
            this.gbEditar.Controls.Add(this.txtObservacaoAgendamentoEditar);
            this.gbEditar.Controls.Add(this.lblDataConsultaEditar);
            this.gbEditar.Controls.Add(this.dtpDataConsultaEditar);
            this.gbEditar.Font = new System.Drawing.Font("Arial", 12F);
            this.gbEditar.ForeColor = System.Drawing.Color.White;
            this.gbEditar.Location = new System.Drawing.Point(10, 69);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(563, 176);
            this.gbEditar.TabIndex = 0;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "Editar";
            this.gbEditar.Enter += new System.EventHandler(this.gbEditar_Enter);
            // 
            // dtgIntermediario
            // 
            this.dtgIntermediario.AllowUserToAddRows = false;
            this.dtgIntermediario.AllowUserToDeleteRows = false;
            this.dtgIntermediario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIntermediario.Location = new System.Drawing.Point(223, 47);
            this.dtgIntermediario.Name = "dtgIntermediario";
            this.dtgIntermediario.ReadOnly = true;
            this.dtgIntermediario.Size = new System.Drawing.Size(74, 38);
            this.dtgIntermediario.TabIndex = 3;
            this.dtgIntermediario.Visible = false;
            // 
            // cbStatusConsultaEditar
            // 
            this.cbStatusConsultaEditar.FormattingEnabled = true;
            this.cbStatusConsultaEditar.Location = new System.Drawing.Point(319, 47);
            this.cbStatusConsultaEditar.Name = "cbStatusConsultaEditar";
            this.cbStatusConsultaEditar.Size = new System.Drawing.Size(226, 26);
            this.cbStatusConsultaEditar.TabIndex = 1;
            // 
            // lblObservacaoPacienteEditar
            // 
            this.lblObservacaoPacienteEditar.AutoSize = true;
            this.lblObservacaoPacienteEditar.Location = new System.Drawing.Point(13, 83);
            this.lblObservacaoPacienteEditar.Name = "lblObservacaoPacienteEditar";
            this.lblObservacaoPacienteEditar.Size = new System.Drawing.Size(97, 18);
            this.lblObservacaoPacienteEditar.TabIndex = 0;
            this.lblObservacaoPacienteEditar.Text = "Observação:";
            // 
            // lblStatusConsultaEditar
            // 
            this.lblStatusConsultaEditar.AutoSize = true;
            this.lblStatusConsultaEditar.Location = new System.Drawing.Point(320, 24);
            this.lblStatusConsultaEditar.Name = "lblStatusConsultaEditar";
            this.lblStatusConsultaEditar.Size = new System.Drawing.Size(56, 18);
            this.lblStatusConsultaEditar.TabIndex = 0;
            this.lblStatusConsultaEditar.Text = "Status:";
            // 
            // txtObservacaoAgendamentoEditar
            // 
            this.txtObservacaoAgendamentoEditar.Location = new System.Drawing.Point(13, 106);
            this.txtObservacaoAgendamentoEditar.Multiline = true;
            this.txtObservacaoAgendamentoEditar.Name = "txtObservacaoAgendamentoEditar";
            this.txtObservacaoAgendamentoEditar.Size = new System.Drawing.Size(532, 64);
            this.txtObservacaoAgendamentoEditar.TabIndex = 2;
            // 
            // lblDataConsultaEditar
            // 
            this.lblDataConsultaEditar.AutoSize = true;
            this.lblDataConsultaEditar.Location = new System.Drawing.Point(13, 24);
            this.lblDataConsultaEditar.Name = "lblDataConsultaEditar";
            this.lblDataConsultaEditar.Size = new System.Drawing.Size(46, 18);
            this.lblDataConsultaEditar.TabIndex = 0;
            this.lblDataConsultaEditar.Text = "Data:";
            // 
            // dtpDataConsultaEditar
            // 
            this.dtpDataConsultaEditar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataConsultaEditar.Location = new System.Drawing.Point(17, 47);
            this.dtpDataConsultaEditar.Name = "dtpDataConsultaEditar";
            this.dtpDataConsultaEditar.Size = new System.Drawing.Size(124, 26);
            this.dtpDataConsultaEditar.TabIndex = 0;
            // 
            // dtgPesquisarConsultasAgendadas
            // 
            this.dtgPesquisarConsultasAgendadas.AllowUserToAddRows = false;
            this.dtgPesquisarConsultasAgendadas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            this.dtgPesquisarConsultasAgendadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPesquisarConsultasAgendadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgPesquisarConsultasAgendadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.dtgPesquisarConsultasAgendadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisarConsultasAgendadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAgendamento,
            this.codigoPaciente,
            this.paciente,
            this.responsavel,
            this.registroGeral,
            this.CPessoaFisica,
            this.Nascimento,
            this.dataConsulta,
            this.horaChegada,
            this.observacaoAgendamento,
            this.login,
            this.nomeStatus,
            this.btnConsultar,
            this.btnEditar,
            this.btnPacientePresente});
            this.dtgPesquisarConsultasAgendadas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgPesquisarConsultasAgendadas.Location = new System.Drawing.Point(0, 280);
            this.dtgPesquisarConsultasAgendadas.Name = "dtgPesquisarConsultasAgendadas";
            this.dtgPesquisarConsultasAgendadas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtgPesquisarConsultasAgendadas.RowHeadersVisible = false;
            this.dtgPesquisarConsultasAgendadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPesquisarConsultasAgendadas.Size = new System.Drawing.Size(1160, 323);
            this.dtgPesquisarConsultasAgendadas.TabIndex = 2;
            this.dtgPesquisarConsultasAgendadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPesquisarConsultasAgendadas_CellContentClick);
            // 
            // idAgendamento
            // 
            this.idAgendamento.HeaderText = "Código";
            this.idAgendamento.Name = "idAgendamento";
            this.idAgendamento.Width = 84;
            // 
            // codigoPaciente
            // 
            this.codigoPaciente.HeaderText = "C. Paciente";
            this.codigoPaciente.Name = "codigoPaciente";
            this.codigoPaciente.Width = 115;
            // 
            // paciente
            // 
            this.paciente.HeaderText = "Paciente";
            this.paciente.Name = "paciente";
            this.paciente.Width = 96;
            // 
            // responsavel
            // 
            this.responsavel.HeaderText = "Responsável ";
            this.responsavel.Name = "responsavel";
            this.responsavel.Visible = false;
            this.responsavel.Width = 130;
            // 
            // registroGeral
            // 
            this.registroGeral.HeaderText = "RG";
            this.registroGeral.Name = "registroGeral";
            this.registroGeral.Visible = false;
            this.registroGeral.Width = 59;
            // 
            // CPessoaFisica
            // 
            this.CPessoaFisica.HeaderText = "CPF";
            this.CPessoaFisica.Name = "CPessoaFisica";
            this.CPessoaFisica.Width = 65;
            // 
            // Nascimento
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Nascimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nascimento.HeaderText = "D. Nascimento";
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.Width = 138;
            // 
            // dataConsulta
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataConsulta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataConsulta.HeaderText = "D. Consulta";
            this.dataConsulta.Name = "dataConsulta";
            this.dataConsulta.Width = 117;
            // 
            // horaChegada
            // 
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.horaChegada.DefaultCellStyle = dataGridViewCellStyle4;
            this.horaChegada.HeaderText = "H. Chegada";
            this.horaChegada.Name = "horaChegada";
            this.horaChegada.Width = 119;
            // 
            // observacaoAgendamento
            // 
            this.observacaoAgendamento.HeaderText = "Observação";
            this.observacaoAgendamento.Name = "observacaoAgendamento";
            this.observacaoAgendamento.Visible = false;
            this.observacaoAgendamento.Width = 119;
            // 
            // login
            // 
            this.login.HeaderText = "Usuário";
            this.login.Name = "login";
            this.login.Width = 89;
            // 
            // nomeStatus
            // 
            this.nomeStatus.HeaderText = "Status";
            this.nomeStatus.Name = "nomeStatus";
            this.nomeStatus.Width = 81;
            // 
            // btnConsultar
            // 
            this.btnConsultar.HeaderText = "Consultar";
            this.btnConsultar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.consultaicon;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Width = 83;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.EditarIcon__1_;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Width = 57;
            // 
            // btnPacientePresente
            // 
            this.btnPacientePresente.HeaderText = "Chegada";
            this.btnPacientePresente.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.checkbox2;
            this.btnPacientePresente.Name = "btnPacientePresente";
            this.btnPacientePresente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnPacientePresente.Width = 80;
            // 
            // gbPesquisar
            // 
            this.gbPesquisar.Controls.Add(this.btnPesquisarAgendamento);
            this.gbPesquisar.Controls.Add(this.rbDataConsulta);
            this.gbPesquisar.Controls.Add(this.rbCpf);
            this.gbPesquisar.Controls.Add(this.rbNomePaciente);
            this.gbPesquisar.Controls.Add(this.rbDataNascimento);
            this.gbPesquisar.Controls.Add(this.rbStatusAgendamento);
            this.gbPesquisar.Controls.Add(this.rbRG);
            this.gbPesquisar.Controls.Add(this.rbTodasConsultas);
            this.gbPesquisar.Controls.Add(this.txtPesquisarAgendamento);
            this.gbPesquisar.Controls.Add(this.cbStatusPesquisar);
            this.gbPesquisar.Controls.Add(this.dtpDataInicialPesquisa);
            this.gbPesquisar.Controls.Add(this.dtpDataFinalPesquisa);
            this.gbPesquisar.Controls.Add(this.lblDataFinal);
            this.gbPesquisar.Controls.Add(this.lblDataInicial);
            this.gbPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesquisar.ForeColor = System.Drawing.Color.White;
            this.gbPesquisar.Location = new System.Drawing.Point(679, 69);
            this.gbPesquisar.Name = "gbPesquisar";
            this.gbPesquisar.Size = new System.Drawing.Size(460, 176);
            this.gbPesquisar.TabIndex = 1;
            this.gbPesquisar.TabStop = false;
            this.gbPesquisar.Text = "Pesquisar";
            // 
            // btnPesquisarAgendamento
            // 
            this.btnPesquisarAgendamento.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.pesquisar;
            this.btnPesquisarAgendamento.Location = new System.Drawing.Point(361, 83);
            this.btnPesquisarAgendamento.Name = "btnPesquisarAgendamento";
            this.btnPesquisarAgendamento.Size = new System.Drawing.Size(91, 30);
            this.btnPesquisarAgendamento.TabIndex = 0;
            this.btnPesquisarAgendamento.UseVisualStyleBackColor = true;
            this.btnPesquisarAgendamento.Click += new System.EventHandler(this.btnPesquisarAgendamento_Click);
            // 
            // rbDataConsulta
            // 
            this.rbDataConsulta.AutoSize = true;
            this.rbDataConsulta.Location = new System.Drawing.Point(160, 148);
            this.rbDataConsulta.Name = "rbDataConsulta";
            this.rbDataConsulta.Size = new System.Drawing.Size(107, 22);
            this.rbDataConsulta.TabIndex = 0;
            this.rbDataConsulta.TabStop = true;
            this.rbDataConsulta.Text = "D. Consulta";
            this.rbDataConsulta.UseVisualStyleBackColor = true;
            this.rbDataConsulta.Click += new System.EventHandler(this.FiltrosAgendamento);
            // 
            // rbCpf
            // 
            this.rbCpf.AutoSize = true;
            this.rbCpf.Location = new System.Drawing.Point(97, 117);
            this.rbCpf.Name = "rbCpf";
            this.rbCpf.Size = new System.Drawing.Size(59, 22);
            this.rbCpf.TabIndex = 0;
            this.rbCpf.TabStop = true;
            this.rbCpf.Text = "CPF";
            this.rbCpf.UseVisualStyleBackColor = true;
            this.rbCpf.Click += new System.EventHandler(this.FiltrosAgendamento);
            // 
            // rbNomePaciente
            // 
            this.rbNomePaciente.AutoSize = true;
            this.rbNomePaciente.Location = new System.Drawing.Point(26, 146);
            this.rbNomePaciente.Name = "rbNomePaciente";
            this.rbNomePaciente.Size = new System.Drawing.Size(68, 22);
            this.rbNomePaciente.TabIndex = 0;
            this.rbNomePaciente.TabStop = true;
            this.rbNomePaciente.Text = "Nome";
            this.rbNomePaciente.UseVisualStyleBackColor = true;
            this.rbNomePaciente.Click += new System.EventHandler(this.FiltrosAgendamento);
            // 
            // rbDataNascimento
            // 
            this.rbDataNascimento.AutoSize = true;
            this.rbDataNascimento.Location = new System.Drawing.Point(159, 117);
            this.rbDataNascimento.Name = "rbDataNascimento";
            this.rbDataNascimento.Size = new System.Drawing.Size(129, 22);
            this.rbDataNascimento.TabIndex = 0;
            this.rbDataNascimento.TabStop = true;
            this.rbDataNascimento.Text = "D. Nascimento";
            this.rbDataNascimento.UseVisualStyleBackColor = true;
            this.rbDataNascimento.Click += new System.EventHandler(this.FiltrosAgendamento);
            // 
            // rbStatusAgendamento
            // 
            this.rbStatusAgendamento.AutoSize = true;
            this.rbStatusAgendamento.Location = new System.Drawing.Point(296, 117);
            this.rbStatusAgendamento.Name = "rbStatusAgendamento";
            this.rbStatusAgendamento.Size = new System.Drawing.Size(70, 22);
            this.rbStatusAgendamento.TabIndex = 0;
            this.rbStatusAgendamento.TabStop = true;
            this.rbStatusAgendamento.Text = "Status";
            this.rbStatusAgendamento.UseVisualStyleBackColor = true;
            this.rbStatusAgendamento.Click += new System.EventHandler(this.FiltrosAgendamento);
            // 
            // rbRG
            // 
            this.rbRG.AutoSize = true;
            this.rbRG.Location = new System.Drawing.Point(97, 148);
            this.rbRG.Name = "rbRG";
            this.rbRG.Size = new System.Drawing.Size(49, 22);
            this.rbRG.TabIndex = 0;
            this.rbRG.TabStop = true;
            this.rbRG.Text = "RG";
            this.rbRG.UseVisualStyleBackColor = true;
            this.rbRG.Click += new System.EventHandler(this.FiltrosAgendamento);
            // 
            // rbTodasConsultas
            // 
            this.rbTodasConsultas.AutoSize = true;
            this.rbTodasConsultas.Location = new System.Drawing.Point(26, 117);
            this.rbTodasConsultas.Name = "rbTodasConsultas";
            this.rbTodasConsultas.Size = new System.Drawing.Size(68, 22);
            this.rbTodasConsultas.TabIndex = 0;
            this.rbTodasConsultas.TabStop = true;
            this.rbTodasConsultas.Text = "Todos";
            this.rbTodasConsultas.UseVisualStyleBackColor = true;
            this.rbTodasConsultas.Click += new System.EventHandler(this.FiltrosAgendamento);
            // 
            // txtPesquisarAgendamento
            // 
            this.txtPesquisarAgendamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisarAgendamento.Location = new System.Drawing.Point(20, 85);
            this.txtPesquisarAgendamento.Name = "txtPesquisarAgendamento";
            this.txtPesquisarAgendamento.Size = new System.Drawing.Size(335, 26);
            this.txtPesquisarAgendamento.TabIndex = 0;
            this.txtPesquisarAgendamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisarAgendamento.Visible = false;
            // 
            // cbStatusPesquisar
            // 
            this.cbStatusPesquisar.FormattingEnabled = true;
            this.cbStatusPesquisar.Location = new System.Drawing.Point(20, 84);
            this.cbStatusPesquisar.Name = "cbStatusPesquisar";
            this.cbStatusPesquisar.Size = new System.Drawing.Size(335, 26);
            this.cbStatusPesquisar.TabIndex = 0;
            this.cbStatusPesquisar.Visible = false;
            this.cbStatusPesquisar.SelectedIndexChanged += new System.EventHandler(this.cbStatusPesquisar_SelectedIndexChanged);
            // 
            // dtpDataInicialPesquisa
            // 
            this.dtpDataInicialPesquisa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicialPesquisa.Location = new System.Drawing.Point(26, 47);
            this.dtpDataInicialPesquisa.Name = "dtpDataInicialPesquisa";
            this.dtpDataInicialPesquisa.Size = new System.Drawing.Size(124, 26);
            this.dtpDataInicialPesquisa.TabIndex = 0;
            // 
            // dtpDataFinalPesquisa
            // 
            this.dtpDataFinalPesquisa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinalPesquisa.Location = new System.Drawing.Point(202, 49);
            this.dtpDataFinalPesquisa.Name = "dtpDataFinalPesquisa";
            this.dtpDataFinalPesquisa.Size = new System.Drawing.Size(124, 26);
            this.dtpDataFinalPesquisa.TabIndex = 0;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(198, 24);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(84, 18);
            this.lblDataFinal.TabIndex = 0;
            this.lblDataFinal.Text = "Data Final:";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(22, 24);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(89, 18);
            this.lblDataInicial.TabIndex = 0;
            this.lblDataInicial.Text = "Data Inicial:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Consultar";
            this.dataGridViewImageColumn1.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.consultaicon;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 80;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.EditarIcon__1_;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 56;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Chegada";
            this.dataGridViewImageColumn3.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.deletarIcon__1_;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 79;
            // 
            // frmEditarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 603);
            this.Controls.Add(this.pnlPesquisarEditar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEditarAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Agendamento";
            this.Load += new System.EventHandler(this.frmEditarAgendamento_Load);
            this.pnlPesquisarEditar.ResumeLayout(false);
            this.painelSuperior.ResumeLayout(false);
            this.gbEditar.ResumeLayout(false);
            this.gbEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisarConsultasAgendadas)).EndInit();
            this.gbPesquisar.ResumeLayout(false);
            this.gbPesquisar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPesquisarEditar;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.ComboBox cbStatusConsultaEditar;
        private System.Windows.Forms.Button btnSalvarEdicao;
        private System.Windows.Forms.Label lblObservacaoPacienteEditar;
        private System.Windows.Forms.Label lblStatusConsultaEditar;
        private System.Windows.Forms.TextBox txtObservacaoAgendamentoEditar;
        private System.Windows.Forms.Label lblDataConsultaEditar;
        private System.Windows.Forms.DateTimePicker dtpDataConsultaEditar;
        private System.Windows.Forms.DataGridView dtgPesquisarConsultasAgendadas;
        private System.Windows.Forms.GroupBox gbPesquisar;
        private System.Windows.Forms.Button btnPesquisarAgendamento;
        private System.Windows.Forms.RadioButton rbDataConsulta;
        private System.Windows.Forms.RadioButton rbCpf;
        private System.Windows.Forms.RadioButton rbNomePaciente;
        private System.Windows.Forms.RadioButton rbDataNascimento;
        private System.Windows.Forms.RadioButton rbStatusAgendamento;
        private System.Windows.Forms.RadioButton rbRG;
        private System.Windows.Forms.RadioButton rbTodasConsultas;
        private System.Windows.Forms.TextBox txtPesquisarAgendamento;
        private System.Windows.Forms.ComboBox cbStatusPesquisar;
        private System.Windows.Forms.DateTimePicker dtpDataInicialPesquisa;
        private System.Windows.Forms.DateTimePicker dtpDataFinalPesquisa;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.DataGridView dtgIntermediario;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroGeral;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPessoaFisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaChegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoAgendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeStatus;
        private System.Windows.Forms.DataGridViewImageColumn btnConsultar;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnPacientePresente;
        private System.Windows.Forms.Panel painelSuperior;
        private System.Windows.Forms.Button btnCancelar;
    }
}