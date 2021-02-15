namespace Sistema_Gerenciador_de_Consultorio
{
    partial class frmImpressao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpressao));
            this.profissionalCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receitaCompletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaCompletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpProfissional = new System.Windows.Forms.TabPage();
            this.rpProfissional1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpReceita = new System.Windows.Forms.TabPage();
            this.rpReceita = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpConsulta = new System.Windows.Forms.TabPage();
            this.rpConsulta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpPaciente = new System.Windows.Forms.TabPage();
            this.rpPaciente = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tpUsuario = new System.Windows.Forms.TabPage();
            this.rpUsuario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbImpressoes = new System.Windows.Forms.TabControl();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.profissionalCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaCompletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaCompletaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteCompletoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioCompletoBindingSource)).BeginInit();
            this.tpProfissional.SuspendLayout();
            this.tpReceita.SuspendLayout();
            this.tpConsulta.SuspendLayout();
            this.tpPaciente.SuspendLayout();
            this.tpUsuario.SuspendLayout();
            this.tbImpressoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // profissionalCompletoBindingSource
            // 
            this.profissionalCompletoBindingSource.DataMember = "ProfissionalCompleto";
            // 
            // receitaCompletaBindingSource
            // 
            this.receitaCompletaBindingSource.DataMember = "ReceitaCompleta";
            // 
            // consultaCompletaBindingSource
            // 
            this.consultaCompletaBindingSource.DataMember = "ConsultaCompleta";
            // 
            // pacienteCompletoBindingSource
            // 
            this.pacienteCompletoBindingSource.DataMember = "PacienteCompleto";
            // 
            // usuarioCompletoBindingSource
            // 
            this.usuarioCompletoBindingSource.DataMember = "UsuarioCompleto";
            // 
            // tpProfissional
            // 
            this.tpProfissional.Controls.Add(this.rpProfissional1);
            this.tpProfissional.Location = new System.Drawing.Point(4, 29);
            this.tpProfissional.Name = "tpProfissional";
            this.tpProfissional.Padding = new System.Windows.Forms.Padding(3);
            this.tpProfissional.Size = new System.Drawing.Size(1148, 566);
            this.tpProfissional.TabIndex = 1;
            this.tpProfissional.Text = "Profissional";
            this.tpProfissional.UseVisualStyleBackColor = true;
            // 
            // rpProfissional1
            // 
            this.rpProfissional1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProfissionalCompleto";
            reportDataSource1.Value = this.profissionalCompletoBindingSource;
            this.rpProfissional1.LocalReport.DataSources.Add(reportDataSource1);
            this.rpProfissional1.LocalReport.ReportEmbeddedResource = "Sistema_Gerenciador_de_Consultorio.Impressão.ImprimirProfissionalCompleto.rdlc";
            this.rpProfissional1.Location = new System.Drawing.Point(3, 3);
            this.rpProfissional1.Name = "rpProfissional1";
            this.rpProfissional1.Size = new System.Drawing.Size(1142, 560);
            this.rpProfissional1.TabIndex = 0;
            // 
            // tpReceita
            // 
            this.tpReceita.Controls.Add(this.rpReceita);
            this.tpReceita.Location = new System.Drawing.Point(4, 29);
            this.tpReceita.Name = "tpReceita";
            this.tpReceita.Padding = new System.Windows.Forms.Padding(3);
            this.tpReceita.Size = new System.Drawing.Size(1148, 566);
            this.tpReceita.TabIndex = 5;
            this.tpReceita.Text = "Receita";
            this.tpReceita.UseVisualStyleBackColor = true;
            // 
            // rpReceita
            // 
            this.rpReceita.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "ReceitaCompleto";
            reportDataSource2.Value = this.receitaCompletaBindingSource;
            this.rpReceita.LocalReport.DataSources.Add(reportDataSource2);
            this.rpReceita.LocalReport.ReportEmbeddedResource = "Sistema_Gerenciador_de_Consultorio.Impressão.ImprimirReceita.rdlc";
            this.rpReceita.Location = new System.Drawing.Point(3, 3);
            this.rpReceita.Name = "rpReceita";
            this.rpReceita.Size = new System.Drawing.Size(1142, 560);
            this.rpReceita.TabIndex = 0;
            this.rpReceita.Load += new System.EventHandler(this.rpReceita_Load);
            // 
            // tpConsulta
            // 
            this.tpConsulta.Controls.Add(this.rpConsulta);
            this.tpConsulta.Location = new System.Drawing.Point(4, 29);
            this.tpConsulta.Name = "tpConsulta";
            this.tpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsulta.Size = new System.Drawing.Size(1148, 566);
            this.tpConsulta.TabIndex = 3;
            this.tpConsulta.Text = "Consulta";
            this.tpConsulta.UseVisualStyleBackColor = true;
            // 
            // rpConsulta
            // 
            this.rpConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "ConsultaCompleta";
            reportDataSource3.Value = this.consultaCompletaBindingSource;
            this.rpConsulta.LocalReport.DataSources.Add(reportDataSource3);
            this.rpConsulta.LocalReport.ReportEmbeddedResource = "Sistema_Gerenciador_de_Consultorio.Impressão.ImprimirConsultaCompleta.rdlc";
            this.rpConsulta.Location = new System.Drawing.Point(3, 3);
            this.rpConsulta.Name = "rpConsulta";
            this.rpConsulta.Size = new System.Drawing.Size(1142, 560);
            this.rpConsulta.TabIndex = 0;
            // 
            // tpPaciente
            // 
            this.tpPaciente.Controls.Add(this.rpPaciente);
            this.tpPaciente.Location = new System.Drawing.Point(4, 29);
            this.tpPaciente.Name = "tpPaciente";
            this.tpPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tpPaciente.Size = new System.Drawing.Size(1148, 566);
            this.tpPaciente.TabIndex = 0;
            this.tpPaciente.Text = "Paciente";
            this.tpPaciente.UseVisualStyleBackColor = true;
            // 
            // rpPaciente
            // 
            this.rpPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "PacienteCompleto";
            reportDataSource4.Value = this.pacienteCompletoBindingSource;
            this.rpPaciente.LocalReport.DataSources.Add(reportDataSource4);
            this.rpPaciente.LocalReport.ReportEmbeddedResource = "Sistema_Gerenciador_de_Consultorio.Impressão.ImprimirPacienteCompleto.rdlc";
            this.rpPaciente.Location = new System.Drawing.Point(3, 3);
            this.rpPaciente.Name = "rpPaciente";
            this.rpPaciente.Size = new System.Drawing.Size(1142, 560);
            this.rpPaciente.TabIndex = 1;
            // 
            // tpUsuario
            // 
            this.tpUsuario.Controls.Add(this.rpUsuario);
            this.tpUsuario.Location = new System.Drawing.Point(4, 29);
            this.tpUsuario.Name = "tpUsuario";
            this.tpUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsuario.Size = new System.Drawing.Size(1148, 566);
            this.tpUsuario.TabIndex = 2;
            this.tpUsuario.Text = "Usuario";
            this.tpUsuario.UseVisualStyleBackColor = true;
            // 
            // rpUsuario
            // 
            this.rpUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "UsuarioCompleto";
            reportDataSource5.Value = this.usuarioCompletoBindingSource;
            this.rpUsuario.LocalReport.DataSources.Add(reportDataSource5);
            this.rpUsuario.LocalReport.ReportEmbeddedResource = "Sistema_Gerenciador_de_Consultorio.Impressão.ImprimirUsuarioCompleto.rdlc";
            this.rpUsuario.Location = new System.Drawing.Point(3, 3);
            this.rpUsuario.Name = "rpUsuario";
            this.rpUsuario.Size = new System.Drawing.Size(1142, 560);
            this.rpUsuario.TabIndex = 0;
            // 
            // tbImpressoes
            // 
            this.tbImpressoes.Controls.Add(this.tpConsulta);
            this.tbImpressoes.Controls.Add(this.tpUsuario);
            this.tbImpressoes.Controls.Add(this.tpReceita);
            this.tbImpressoes.Controls.Add(this.tpProfissional);
            this.tbImpressoes.Controls.Add(this.tpPaciente);
            this.tbImpressoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbImpressoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbImpressoes.Location = new System.Drawing.Point(0, 0);
            this.tbImpressoes.Name = "tbImpressoes";
            this.tbImpressoes.SelectedIndex = 0;
            this.tbImpressoes.Size = new System.Drawing.Size(1156, 599);
            this.tbImpressoes.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 599);
            this.Controls.Add(this.tbImpressoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1176, 642);
            this.Name = "frmImpressao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Formulário de Impressões";
            this.Load += new System.EventHandler(this.frmImpressao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profissionalCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaCompletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaCompletaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteCompletoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioCompletoBindingSource)).EndInit();
            this.tpProfissional.ResumeLayout(false);
            this.tpReceita.ResumeLayout(false);
            this.tpConsulta.ResumeLayout(false);
            this.tpPaciente.ResumeLayout(false);
            this.tpUsuario.ResumeLayout(false);
            this.tbImpressoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource profissionalCompletoBindingSource;
        private System.Windows.Forms.BindingSource pacienteCompletoBindingSource;

        private System.Windows.Forms.BindingSource usuarioCompletoBindingSource;

        private System.Windows.Forms.BindingSource receitaCompletaBindingSource;

        private System.Windows.Forms.BindingSource consultaCompletaBindingSource;

        private System.Windows.Forms.TabPage tpProfissional;
        private System.Windows.Forms.TabPage tpReceita;
        private Microsoft.Reporting.WinForms.ReportViewer rpReceita;
        private System.Windows.Forms.TabPage tpConsulta;
        private Microsoft.Reporting.WinForms.ReportViewer rpConsulta;
        private System.Windows.Forms.TabPage tpPaciente;
        private Microsoft.Reporting.WinForms.ReportViewer rpPaciente;
        private System.Windows.Forms.TabPage tpUsuario;
        private Microsoft.Reporting.WinForms.ReportViewer rpUsuario;
        private System.Windows.Forms.TabControl tbImpressoes;
        private Microsoft.Reporting.WinForms.ReportViewer rpProfissional;
        private System.Windows.Forms.BindingSource profissionalRelatorioBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer rpProfissional1;
    }
}