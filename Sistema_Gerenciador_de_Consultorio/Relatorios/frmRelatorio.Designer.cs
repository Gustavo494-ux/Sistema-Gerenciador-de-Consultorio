namespace Sistema_Gerenciador_de_Consultorio
{
    partial class frmRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorio));
            this.profissionalRelatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PacienteRelatorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelatorioUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelatorioConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConsultaCadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpProfissional = new System.Windows.Forms.TabPage();
            this.rpProfissional = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpPaciente = new System.Windows.Forms.TabPage();
            this.rpPaciente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpUsuario = new System.Windows.Forms.TabPage();
            this.rpUsuario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpConsulta = new System.Windows.Forms.TabPage();
            this.rpConsulta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFinalPaciente = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioPaciente = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisarPaciente = new System.Windows.Forms.Button();
            this.rbDataCadastroPaciente = new System.Windows.Forms.RadioButton();
            this.rbDataNascimentoPaciente = new System.Windows.Forms.RadioButton();
            this.rbTodosPaciente = new System.Windows.Forms.RadioButton();
            this.cbStatusUsuario = new System.Windows.Forms.ComboBox();
            this.CbNivelAcessoUsuario = new System.Windows.Forms.ComboBox();
            this.btnPesquisarUsuario = new System.Windows.Forms.Button();
            this.rbNivelAcessoUsuario = new System.Windows.Forms.RadioButton();
            this.rbStatusUsuario = new System.Windows.Forms.RadioButton();
            this.rbTodosUsuarios = new System.Windows.Forms.RadioButton();
            this.dtpInicialConsulta = new System.Windows.Forms.DateTimePicker();
            this.dtpFinalConsulta = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisarConsulta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbDataConsulta = new System.Windows.Forms.RadioButton();
            this.rbTodosConsulta = new System.Windows.Forms.RadioButton();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.rbConsulta = new System.Windows.Forms.RadioButton();
            this.rbProfissional = new System.Windows.Forms.RadioButton();
            this.rbPaciente = new System.Windows.Forms.RadioButton();
            this.gbPaciente = new System.Windows.Forms.GroupBox();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.rbDataCadastroProfissional = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFinalProfissional = new System.Windows.Forms.DateTimePicker();
            this.dtpInicialProfissional = new System.Windows.Forms.DateTimePicker();
            this.rbTodosProfissional = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisarProfissional = new System.Windows.Forms.Button();
            this.rbDataNascimentoProfissional = new System.Windows.Forms.RadioButton();
            this.gbProfissional = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.profissionalRelatorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacienteRelatorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioConsultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaCadastroBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpProfissional.SuspendLayout();
            this.tpPaciente.SuspendLayout();
            this.tpUsuario.SuspendLayout();
            this.tpConsulta.SuspendLayout();
            this.gbPaciente.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            this.gbConsulta.SuspendLayout();
            this.gbProfissional.SuspendLayout();
            this.SuspendLayout();
            // 
            // profissionalRelatorioBindingSource
            // 
            this.profissionalRelatorioBindingSource.DataMember = "ProfissionalRelatorio";
            // 
            // relatoriosDataSet
            // 
            // 
            // PacienteRelatorioBindingSource
            // 
            this.PacienteRelatorioBindingSource.DataMember = "PacienteRelatorio";
            // 
            // RelatorioUsuarioBindingSource
            // 
            this.RelatorioUsuarioBindingSource.DataMember = "RelatorioUsuario";
            // 
            // RelatorioConsultaBindingSource
            // 
            this.RelatorioConsultaBindingSource.DataMember = "RelatorioConsulta";
            // 
            // ConsultaCadastroBindingSource
            // 
            this.ConsultaCadastroBindingSource.DataMember = "ConsultaCadastro";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpProfissional);
            this.tabControl1.Controls.Add(this.tpPaciente);
            this.tabControl1.Controls.Add(this.tpUsuario);
            this.tabControl1.Controls.Add(this.tpConsulta);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 211);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1160, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tpProfissional
            // 
            this.tpProfissional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.tpProfissional.Controls.Add(this.rpProfissional);
            this.tpProfissional.Location = new System.Drawing.Point(4, 27);
            this.tpProfissional.Margin = new System.Windows.Forms.Padding(4);
            this.tpProfissional.Name = "tpProfissional";
            this.tpProfissional.Padding = new System.Windows.Forms.Padding(4);
            this.tpProfissional.Size = new System.Drawing.Size(1152, 361);
            this.tpProfissional.TabIndex = 0;
            this.tpProfissional.Text = "Profissional";
            // 
            // rpProfissional
            // 
            this.rpProfissional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.rpProfissional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpProfissional.DocumentMapWidth = 46;
            this.rpProfissional.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpProfissional.ForeColor = System.Drawing.Color.White;
            reportDataSource1.Name = "ProfissionalCadastroSimples";
            reportDataSource1.Value = this.profissionalRelatorioBindingSource;
            this.rpProfissional.LocalReport.DataSources.Add(reportDataSource1);
            this.rpProfissional.LocalReport.ReportEmbeddedResource = "Sistema_Gerenciador_de_Consultorio.Relatorios.RelatorioProfissionalBasico.rdlc";
            this.rpProfissional.Location = new System.Drawing.Point(4, 4);
            this.rpProfissional.Margin = new System.Windows.Forms.Padding(4);
            this.rpProfissional.Name = "rpProfissional";
            this.rpProfissional.Size = new System.Drawing.Size(1144, 353);
            this.rpProfissional.TabIndex = 1;
            // 
            // tpPaciente
            // 
            this.tpPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.tpPaciente.Controls.Add(this.rpPaciente);
            this.tpPaciente.Location = new System.Drawing.Point(4, 27);
            this.tpPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.tpPaciente.Name = "tpPaciente";
            this.tpPaciente.Padding = new System.Windows.Forms.Padding(4);
            this.tpPaciente.Size = new System.Drawing.Size(1152, 361);
            this.tpPaciente.TabIndex = 1;
            this.tpPaciente.Text = "Paciente";
            // 
            // rpPaciente
            // 
            this.rpPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.rpPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "PacienteCadastroSimples";
            reportDataSource2.Value = this.PacienteRelatorioBindingSource;
            this.rpPaciente.LocalReport.DataSources.Add(reportDataSource2);
            this.rpPaciente.LocalReport.ReportEmbeddedResource = "Sistema_Gerenciador_de_Consultorio.Relatorios.RelatorioPacienteBasico.rdlc";
            this.rpPaciente.Location = new System.Drawing.Point(4, 4);
            this.rpPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.rpPaciente.Name = "rpPaciente";
            this.rpPaciente.Size = new System.Drawing.Size(1144, 353);
            this.rpPaciente.TabIndex = 0;
            // 
            // tpUsuario
            // 
            this.tpUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.tpUsuario.Controls.Add(this.rpUsuario);
            this.tpUsuario.Location = new System.Drawing.Point(4, 27);
            this.tpUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tpUsuario.Name = "tpUsuario";
            this.tpUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.tpUsuario.Size = new System.Drawing.Size(1152, 361);
            this.tpUsuario.TabIndex = 2;
            this.tpUsuario.Text = "Usuario";
            // 
            // rpUsuario
            // 
            this.rpUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.rpUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "UsuarioCadastro";
            reportDataSource3.Value = this.RelatorioUsuarioBindingSource;
            this.rpUsuario.LocalReport.DataSources.Add(reportDataSource3);
            this.rpUsuario.LocalReport.ReportEmbeddedResource = "Sistema_Gerenciador_de_Consultorio.Relatorios.RelatorioBasicoUsuario.rdlc";
            this.rpUsuario.Location = new System.Drawing.Point(4, 4);
            this.rpUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.rpUsuario.Name = "rpUsuario";
            this.rpUsuario.Size = new System.Drawing.Size(1144, 353);
            this.rpUsuario.TabIndex = 0;
            // 
            // tpConsulta
            // 
            this.tpConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.tpConsulta.Controls.Add(this.rpConsulta);
            this.tpConsulta.Location = new System.Drawing.Point(4, 27);
            this.tpConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.tpConsulta.Name = "tpConsulta";
            this.tpConsulta.Padding = new System.Windows.Forms.Padding(4);
            this.tpConsulta.Size = new System.Drawing.Size(1152, 361);
            this.tpConsulta.TabIndex = 3;
            this.tpConsulta.Text = "Consulta";
            // 
            // rpConsulta
            // 
            this.rpConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.rpConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "ConsultaCadastro";
            reportDataSource4.Value = this.RelatorioConsultaBindingSource;
            this.rpConsulta.LocalReport.DataSources.Add(reportDataSource4);
            this.rpConsulta.LocalReport.ReportEmbeddedResource = "Sistema_Gerenciador_de_Consultorio.Relatorios.RelatorioBasicoConsulta.rdlc";
            this.rpConsulta.Location = new System.Drawing.Point(4, 4);
            this.rpConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.rpConsulta.Name = "rpConsulta";
            this.rpConsulta.Size = new System.Drawing.Size(1144, 353);
            this.rpConsulta.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Final";
            // 
            // dtpFinalPaciente
            // 
            this.dtpFinalPaciente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinalPaciente.Location = new System.Drawing.Point(157, 78);
            this.dtpFinalPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFinalPaciente.Name = "dtpFinalPaciente";
            this.dtpFinalPaciente.Size = new System.Drawing.Size(117, 26);
            this.dtpFinalPaciente.TabIndex = 3;
            // 
            // dtpInicioPaciente
            // 
            this.dtpInicioPaciente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioPaciente.Location = new System.Drawing.Point(32, 78);
            this.dtpInicioPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInicioPaciente.Name = "dtpInicioPaciente";
            this.dtpInicioPaciente.Size = new System.Drawing.Size(117, 26);
            this.dtpInicioPaciente.TabIndex = 3;
            // 
            // btnPesquisarPaciente
            // 
            this.btnPesquisarPaciente.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.pesquisar;
            this.btnPesquisarPaciente.Location = new System.Drawing.Point(282, 76);
            this.btnPesquisarPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarPaciente.Name = "btnPesquisarPaciente";
            this.btnPesquisarPaciente.Size = new System.Drawing.Size(91, 30);
            this.btnPesquisarPaciente.TabIndex = 2;
            this.btnPesquisarPaciente.UseVisualStyleBackColor = true;
            this.btnPesquisarPaciente.Click += new System.EventHandler(this.btnPesquisarPaciente_Click);
            // 
            // rbDataCadastroPaciente
            // 
            this.rbDataCadastroPaciente.AutoSize = true;
            this.rbDataCadastroPaciente.Location = new System.Drawing.Point(258, 31);
            this.rbDataCadastroPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.rbDataCadastroPaciente.Name = "rbDataCadastroPaciente";
            this.rbDataCadastroPaciente.Size = new System.Drawing.Size(129, 22);
            this.rbDataCadastroPaciente.TabIndex = 1;
            this.rbDataCadastroPaciente.Text = "Data Cadastro";
            this.rbDataCadastroPaciente.UseVisualStyleBackColor = true;
            this.rbDataCadastroPaciente.Click += new System.EventHandler(this.FiltrosPaciente);
            // 
            // rbDataNascimentoPaciente
            // 
            this.rbDataNascimentoPaciente.AutoSize = true;
            this.rbDataNascimentoPaciente.Location = new System.Drawing.Point(103, 31);
            this.rbDataNascimentoPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.rbDataNascimentoPaciente.Name = "rbDataNascimentoPaciente";
            this.rbDataNascimentoPaciente.Size = new System.Drawing.Size(147, 22);
            this.rbDataNascimentoPaciente.TabIndex = 1;
            this.rbDataNascimentoPaciente.Text = "Data Nascimento";
            this.rbDataNascimentoPaciente.UseVisualStyleBackColor = true;
            this.rbDataNascimentoPaciente.Click += new System.EventHandler(this.FiltrosPaciente);
            // 
            // rbTodosPaciente
            // 
            this.rbTodosPaciente.AutoSize = true;
            this.rbTodosPaciente.Checked = true;
            this.rbTodosPaciente.Location = new System.Drawing.Point(27, 31);
            this.rbTodosPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.rbTodosPaciente.Name = "rbTodosPaciente";
            this.rbTodosPaciente.Size = new System.Drawing.Size(68, 22);
            this.rbTodosPaciente.TabIndex = 1;
            this.rbTodosPaciente.TabStop = true;
            this.rbTodosPaciente.Text = "Todos";
            this.rbTodosPaciente.UseVisualStyleBackColor = true;
            this.rbTodosPaciente.CheckedChanged += new System.EventHandler(this.rbTodosPaciente_CheckedChanged);
            this.rbTodosPaciente.Click += new System.EventHandler(this.FiltrosPaciente);
            // 
            // cbStatusUsuario
            // 
            this.cbStatusUsuario.FormattingEnabled = true;
            this.cbStatusUsuario.Location = new System.Drawing.Point(56, 72);
            this.cbStatusUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatusUsuario.Name = "cbStatusUsuario";
            this.cbStatusUsuario.Size = new System.Drawing.Size(196, 26);
            this.cbStatusUsuario.TabIndex = 4;
            // 
            // CbNivelAcessoUsuario
            // 
            this.CbNivelAcessoUsuario.FormattingEnabled = true;
            this.CbNivelAcessoUsuario.Location = new System.Drawing.Point(56, 72);
            this.CbNivelAcessoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.CbNivelAcessoUsuario.Name = "CbNivelAcessoUsuario";
            this.CbNivelAcessoUsuario.Size = new System.Drawing.Size(196, 26);
            this.CbNivelAcessoUsuario.TabIndex = 4;
            // 
            // btnPesquisarUsuario
            // 
            this.btnPesquisarUsuario.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.pesquisar;
            this.btnPesquisarUsuario.Location = new System.Drawing.Point(260, 70);
            this.btnPesquisarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarUsuario.Name = "btnPesquisarUsuario";
            this.btnPesquisarUsuario.Size = new System.Drawing.Size(91, 30);
            this.btnPesquisarUsuario.TabIndex = 2;
            this.btnPesquisarUsuario.UseVisualStyleBackColor = true;
            this.btnPesquisarUsuario.Click += new System.EventHandler(this.btnPesquisarUsuario_Click);
            // 
            // rbNivelAcessoUsuario
            // 
            this.rbNivelAcessoUsuario.AutoSize = true;
            this.rbNivelAcessoUsuario.Location = new System.Drawing.Point(210, 35);
            this.rbNivelAcessoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.rbNivelAcessoUsuario.Name = "rbNivelAcessoUsuario";
            this.rbNivelAcessoUsuario.Size = new System.Drawing.Size(116, 22);
            this.rbNivelAcessoUsuario.TabIndex = 1;
            this.rbNivelAcessoUsuario.Text = "Nivel Acesso";
            this.rbNivelAcessoUsuario.UseVisualStyleBackColor = true;
            this.rbNivelAcessoUsuario.Click += new System.EventHandler(this.FiltrosUsuario);
            // 
            // rbStatusUsuario
            // 
            this.rbStatusUsuario.AutoSize = true;
            this.rbStatusUsuario.Location = new System.Drawing.Point(132, 35);
            this.rbStatusUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.rbStatusUsuario.Name = "rbStatusUsuario";
            this.rbStatusUsuario.Size = new System.Drawing.Size(70, 22);
            this.rbStatusUsuario.TabIndex = 1;
            this.rbStatusUsuario.Text = "Status";
            this.rbStatusUsuario.UseVisualStyleBackColor = true;
            this.rbStatusUsuario.Click += new System.EventHandler(this.FiltrosUsuario);
            // 
            // rbTodosUsuarios
            // 
            this.rbTodosUsuarios.AutoSize = true;
            this.rbTodosUsuarios.Checked = true;
            this.rbTodosUsuarios.Location = new System.Drawing.Point(56, 35);
            this.rbTodosUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.rbTodosUsuarios.Name = "rbTodosUsuarios";
            this.rbTodosUsuarios.Size = new System.Drawing.Size(68, 22);
            this.rbTodosUsuarios.TabIndex = 1;
            this.rbTodosUsuarios.TabStop = true;
            this.rbTodosUsuarios.Text = "Todos";
            this.rbTodosUsuarios.UseVisualStyleBackColor = true;
            this.rbTodosUsuarios.CheckedChanged += new System.EventHandler(this.rbTodosUsuarios_CheckedChanged);
            this.rbTodosUsuarios.Click += new System.EventHandler(this.FiltrosUsuario);
            // 
            // dtpInicialConsulta
            // 
            this.dtpInicialConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicialConsulta.Location = new System.Drawing.Point(38, 80);
            this.dtpInicialConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInicialConsulta.Name = "dtpInicialConsulta";
            this.dtpInicialConsulta.Size = new System.Drawing.Size(117, 26);
            this.dtpInicialConsulta.TabIndex = 4;
            // 
            // dtpFinalConsulta
            // 
            this.dtpFinalConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinalConsulta.Location = new System.Drawing.Point(163, 80);
            this.dtpFinalConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFinalConsulta.Name = "dtpFinalConsulta";
            this.dtpFinalConsulta.Size = new System.Drawing.Size(117, 26);
            this.dtpFinalConsulta.TabIndex = 4;
            // 
            // btnPesquisarConsulta
            // 
            this.btnPesquisarConsulta.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.pesquisar;
            this.btnPesquisarConsulta.Location = new System.Drawing.Point(288, 78);
            this.btnPesquisarConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarConsulta.Name = "btnPesquisarConsulta";
            this.btnPesquisarConsulta.Size = new System.Drawing.Size(91, 30);
            this.btnPesquisarConsulta.TabIndex = 3;
            this.btnPesquisarConsulta.UseVisualStyleBackColor = true;
            this.btnPesquisarConsulta.Click += new System.EventHandler(this.btnPesquisarConsulta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Inicial";
            // 
            // rbDataConsulta
            // 
            this.rbDataConsulta.AutoSize = true;
            this.rbDataConsulta.Location = new System.Drawing.Point(118, 32);
            this.rbDataConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.rbDataConsulta.Name = "rbDataConsulta";
            this.rbDataConsulta.Size = new System.Drawing.Size(125, 22);
            this.rbDataConsulta.TabIndex = 1;
            this.rbDataConsulta.Text = "Data Consulta";
            this.rbDataConsulta.UseVisualStyleBackColor = true;
            this.rbDataConsulta.Click += new System.EventHandler(this.FiltrosConsulta);
            // 
            // rbTodosConsulta
            // 
            this.rbTodosConsulta.AutoSize = true;
            this.rbTodosConsulta.Checked = true;
            this.rbTodosConsulta.Location = new System.Drawing.Point(38, 32);
            this.rbTodosConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.rbTodosConsulta.Name = "rbTodosConsulta";
            this.rbTodosConsulta.Size = new System.Drawing.Size(68, 22);
            this.rbTodosConsulta.TabIndex = 1;
            this.rbTodosConsulta.TabStop = true;
            this.rbTodosConsulta.Text = "Todos";
            this.rbTodosConsulta.UseVisualStyleBackColor = true;
            this.rbTodosConsulta.CheckedChanged += new System.EventHandler(this.rbTodosConsulta_CheckedChanged);
            this.rbTodosConsulta.Click += new System.EventHandler(this.FiltrosConsulta);
            // 
            // profissionalRelatorioTableAdapter
            // 
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.rbUsuario.ForeColor = System.Drawing.Color.White;
            this.rbUsuario.Location = new System.Drawing.Point(216, 3);
            this.rbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(80, 22);
            this.rbUsuario.TabIndex = 1;
            this.rbUsuario.Text = "Usuário";
            this.rbUsuario.UseVisualStyleBackColor = false;
            this.rbUsuario.CheckedChanged += new System.EventHandler(this.rbUsuario_CheckedChanged);
            // 
            // rbConsulta
            // 
            this.rbConsulta.AutoSize = true;
            this.rbConsulta.BackColor = System.Drawing.Color.Transparent;
            this.rbConsulta.ForeColor = System.Drawing.Color.White;
            this.rbConsulta.Location = new System.Drawing.Point(304, 3);
            this.rbConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.rbConsulta.Name = "rbConsulta";
            this.rbConsulta.Size = new System.Drawing.Size(87, 22);
            this.rbConsulta.TabIndex = 1;
            this.rbConsulta.Text = "Consulta";
            this.rbConsulta.UseVisualStyleBackColor = false;
            this.rbConsulta.CheckedChanged += new System.EventHandler(this.rbConsulta_CheckedChanged);
            // 
            // rbProfissional
            // 
            this.rbProfissional.AutoSize = true;
            this.rbProfissional.BackColor = System.Drawing.Color.Transparent;
            this.rbProfissional.Checked = true;
            this.rbProfissional.ForeColor = System.Drawing.Color.White;
            this.rbProfissional.Location = new System.Drawing.Point(4, 3);
            this.rbProfissional.Margin = new System.Windows.Forms.Padding(4);
            this.rbProfissional.Name = "rbProfissional";
            this.rbProfissional.Size = new System.Drawing.Size(108, 22);
            this.rbProfissional.TabIndex = 1;
            this.rbProfissional.TabStop = true;
            this.rbProfissional.Text = "Profissional";
            this.rbProfissional.UseVisualStyleBackColor = false;
            this.rbProfissional.CheckedChanged += new System.EventHandler(this.rbProfissional_CheckedChanged);
            // 
            // rbPaciente
            // 
            this.rbPaciente.AutoSize = true;
            this.rbPaciente.BackColor = System.Drawing.Color.Transparent;
            this.rbPaciente.ForeColor = System.Drawing.Color.White;
            this.rbPaciente.Location = new System.Drawing.Point(120, 3);
            this.rbPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.rbPaciente.Name = "rbPaciente";
            this.rbPaciente.Size = new System.Drawing.Size(88, 22);
            this.rbPaciente.TabIndex = 1;
            this.rbPaciente.Text = "Paciente";
            this.rbPaciente.UseVisualStyleBackColor = false;
            this.rbPaciente.CheckedChanged += new System.EventHandler(this.rbPaciente_CheckedChanged);
            // 
            // gbPaciente
            // 
            this.gbPaciente.Controls.Add(this.btnPesquisarPaciente);
            this.gbPaciente.Controls.Add(this.label3);
            this.gbPaciente.Controls.Add(this.dtpFinalPaciente);
            this.gbPaciente.Controls.Add(this.label4);
            this.gbPaciente.Controls.Add(this.rbTodosPaciente);
            this.gbPaciente.Controls.Add(this.dtpInicioPaciente);
            this.gbPaciente.Controls.Add(this.rbDataNascimentoPaciente);
            this.gbPaciente.Controls.Add(this.rbDataCadastroPaciente);
            this.gbPaciente.ForeColor = System.Drawing.Color.White;
            this.gbPaciente.Location = new System.Drawing.Point(419, 164);
            this.gbPaciente.Name = "gbPaciente";
            this.gbPaciente.Size = new System.Drawing.Size(426, 147);
            this.gbPaciente.TabIndex = 2;
            this.gbPaciente.TabStop = false;
            this.gbPaciente.Text = "Paciente";
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.btnPesquisarUsuario);
            this.gbUsuario.Controls.Add(this.cbStatusUsuario);
            this.gbUsuario.Controls.Add(this.CbNivelAcessoUsuario);
            this.gbUsuario.Controls.Add(this.rbTodosUsuarios);
            this.gbUsuario.Controls.Add(this.rbStatusUsuario);
            this.gbUsuario.Controls.Add(this.rbNivelAcessoUsuario);
            this.gbUsuario.ForeColor = System.Drawing.Color.White;
            this.gbUsuario.Location = new System.Drawing.Point(558, 55);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(426, 147);
            this.gbUsuario.TabIndex = 2;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Usuário";
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.btnPesquisarConsulta);
            this.gbConsulta.Controls.Add(this.dtpFinalConsulta);
            this.gbConsulta.Controls.Add(this.dtpInicialConsulta);
            this.gbConsulta.Controls.Add(this.rbDataConsulta);
            this.gbConsulta.Controls.Add(this.rbTodosConsulta);
            this.gbConsulta.Controls.Add(this.label5);
            this.gbConsulta.Controls.Add(this.label6);
            this.gbConsulta.ForeColor = System.Drawing.Color.White;
            this.gbConsulta.Location = new System.Drawing.Point(818, 12);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(426, 147);
            this.gbConsulta.TabIndex = 2;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta";
            // 
            // rbDataCadastroProfissional
            // 
            this.rbDataCadastroProfissional.AutoSize = true;
            this.rbDataCadastroProfissional.Location = new System.Drawing.Point(259, 28);
            this.rbDataCadastroProfissional.Margin = new System.Windows.Forms.Padding(4);
            this.rbDataCadastroProfissional.Name = "rbDataCadastroProfissional";
            this.rbDataCadastroProfissional.Size = new System.Drawing.Size(129, 22);
            this.rbDataCadastroProfissional.TabIndex = 3;
            this.rbDataCadastroProfissional.Text = "Data Cadastro";
            this.rbDataCadastroProfissional.UseVisualStyleBackColor = true;
            this.rbDataCadastroProfissional.Click += new System.EventHandler(this.FiltrosProfissional);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inicial";
            // 
            // dtpFinalProfissional
            // 
            this.dtpFinalProfissional.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinalProfissional.Location = new System.Drawing.Point(158, 78);
            this.dtpFinalProfissional.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFinalProfissional.Name = "dtpFinalProfissional";
            this.dtpFinalProfissional.Size = new System.Drawing.Size(117, 26);
            this.dtpFinalProfissional.TabIndex = 5;
            // 
            // dtpInicialProfissional
            // 
            this.dtpInicialProfissional.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicialProfissional.Location = new System.Drawing.Point(33, 78);
            this.dtpInicialProfissional.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInicialProfissional.Name = "dtpInicialProfissional";
            this.dtpInicialProfissional.Size = new System.Drawing.Size(117, 26);
            this.dtpInicialProfissional.TabIndex = 5;
            // 
            // rbTodosProfissional
            // 
            this.rbTodosProfissional.AutoSize = true;
            this.rbTodosProfissional.Checked = true;
            this.rbTodosProfissional.Location = new System.Drawing.Point(28, 28);
            this.rbTodosProfissional.Margin = new System.Windows.Forms.Padding(4);
            this.rbTodosProfissional.Name = "rbTodosProfissional";
            this.rbTodosProfissional.Size = new System.Drawing.Size(68, 22);
            this.rbTodosProfissional.TabIndex = 2;
            this.rbTodosProfissional.TabStop = true;
            this.rbTodosProfissional.Text = "Todos";
            this.rbTodosProfissional.UseVisualStyleBackColor = true;
            this.rbTodosProfissional.CheckedChanged += new System.EventHandler(this.rbTodosProfissional_CheckedChanged);
            this.rbTodosProfissional.Click += new System.EventHandler(this.FiltrosProfissional);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Final";
            // 
            // btnPesquisarProfissional
            // 
            this.btnPesquisarProfissional.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.pesquisar;
            this.btnPesquisarProfissional.Location = new System.Drawing.Point(283, 76);
            this.btnPesquisarProfissional.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarProfissional.Name = "btnPesquisarProfissional";
            this.btnPesquisarProfissional.Size = new System.Drawing.Size(91, 30);
            this.btnPesquisarProfissional.TabIndex = 4;
            this.btnPesquisarProfissional.UseVisualStyleBackColor = true;
            this.btnPesquisarProfissional.Click += new System.EventHandler(this.btnPesquisarProfissional_Click);
            // 
            // rbDataNascimentoProfissional
            // 
            this.rbDataNascimentoProfissional.AutoSize = true;
            this.rbDataNascimentoProfissional.Location = new System.Drawing.Point(104, 28);
            this.rbDataNascimentoProfissional.Margin = new System.Windows.Forms.Padding(4);
            this.rbDataNascimentoProfissional.Name = "rbDataNascimentoProfissional";
            this.rbDataNascimentoProfissional.Size = new System.Drawing.Size(147, 22);
            this.rbDataNascimentoProfissional.TabIndex = 2;
            this.rbDataNascimentoProfissional.Text = "Data Nascimento";
            this.rbDataNascimentoProfissional.UseVisualStyleBackColor = true;
            this.rbDataNascimentoProfissional.Click += new System.EventHandler(this.FiltrosProfissional);
            // 
            // gbProfissional
            // 
            this.gbProfissional.Controls.Add(this.rbDataNascimentoProfissional);
            this.gbProfissional.Controls.Add(this.btnPesquisarProfissional);
            this.gbProfissional.Controls.Add(this.label2);
            this.gbProfissional.Controls.Add(this.rbTodosProfissional);
            this.gbProfissional.Controls.Add(this.dtpInicialProfissional);
            this.gbProfissional.Controls.Add(this.dtpFinalProfissional);
            this.gbProfissional.Controls.Add(this.label1);
            this.gbProfissional.Controls.Add(this.rbDataCadastroProfissional);
            this.gbProfissional.ForeColor = System.Drawing.Color.White;
            this.gbProfissional.Location = new System.Drawing.Point(88, 62);
            this.gbProfissional.Name = "gbProfissional";
            this.gbProfissional.Size = new System.Drawing.Size(426, 147);
            this.gbProfissional.TabIndex = 2;
            this.gbProfissional.TabStop = false;
            this.gbProfissional.Text = "Profissional";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataSetImpressao
            // 
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1160, 603);
            this.Controls.Add(this.gbProfissional);
            this.Controls.Add(this.gbPaciente);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.gbConsulta);
            this.Controls.Add(this.rbPaciente);
            this.Controls.Add(this.rbProfissional);
            this.Controls.Add(this.rbConsulta);
            this.Controls.Add(this.rbUsuario);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profissionalRelatorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacienteRelatorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelatorioConsultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaCadastroBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpProfissional.ResumeLayout(false);
            this.tpPaciente.ResumeLayout(false);
            this.tpUsuario.ResumeLayout(false);
            this.tpConsulta.ResumeLayout(false);
            this.gbPaciente.ResumeLayout(false);
            this.gbPaciente.PerformLayout();
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            this.gbProfissional.ResumeLayout(false);
            this.gbProfissional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource ConsultaCadastroBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpProfissional;
        private Microsoft.Reporting.WinForms.ReportViewer rpProfissional;
        private System.Windows.Forms.TabPage tpPaciente;
        private System.Windows.Forms.BindingSource profissionalRelatorioBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rpPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFinalPaciente;
        private System.Windows.Forms.DateTimePicker dtpInicioPaciente;
        private System.Windows.Forms.Button btnPesquisarPaciente;
        private System.Windows.Forms.RadioButton rbDataCadastroPaciente;
        private System.Windows.Forms.RadioButton rbDataNascimentoPaciente;
        private System.Windows.Forms.RadioButton rbTodosPaciente;
        private System.Windows.Forms.BindingSource PacienteRelatorioBindingSource;
        private System.Windows.Forms.TabPage tpUsuario;
        private System.Windows.Forms.TabPage tpConsulta;
        private Microsoft.Reporting.WinForms.ReportViewer rpUsuario;
        private System.Windows.Forms.Button btnPesquisarUsuario;
        private System.Windows.Forms.RadioButton rbNivelAcessoUsuario;
        private System.Windows.Forms.RadioButton rbStatusUsuario;
        private System.Windows.Forms.RadioButton rbTodosUsuarios;
        private System.Windows.Forms.ComboBox cbStatusUsuario;
        private System.Windows.Forms.ComboBox CbNivelAcessoUsuario;
        private System.Windows.Forms.BindingSource RelatorioUsuarioBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rpConsulta;
        private System.Windows.Forms.DateTimePicker dtpFinalConsulta;
        private System.Windows.Forms.Button btnPesquisarConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbDataConsulta;
        private System.Windows.Forms.RadioButton rbTodosConsulta;
        private System.Windows.Forms.DateTimePicker dtpInicialConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource RelatorioConsultaBindingSource;
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.RadioButton rbConsulta;
        private System.Windows.Forms.RadioButton rbProfissional;
        private System.Windows.Forms.RadioButton rbPaciente;
        private System.Windows.Forms.GroupBox gbPaciente;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.RadioButton rbDataCadastroProfissional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFinalProfissional;
        private System.Windows.Forms.DateTimePicker dtpInicialProfissional;
        private System.Windows.Forms.RadioButton rbTodosProfissional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisarProfissional;
        private System.Windows.Forms.RadioButton rbDataNascimentoProfissional;
        private System.Windows.Forms.GroupBox gbProfissional;
        private System.Windows.Forms.Timer timer1;
    }
}