
namespace Sistema_Gerenciador_de_Consultorio
{
    partial class frmImprimirDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImprimirDados));
            this.msMenuSuperior = new System.Windows.Forms.MenuStrip();
            this.voltarMsMenuSuperior = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecionarFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbImpressoras = new System.Windows.Forms.ToolStripComboBox();
            this.cbImpressora = new System.Windows.Forms.ComboBox();
            this.txtNomeFont = new System.Windows.Forms.TextBox();
            this.txtTamanhoFont = new System.Windows.Forms.TextBox();
            this.txtEstiloFont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlReceita = new System.Windows.Forms.Panel();
            this.lblConselhoClasse = new System.Windows.Forms.Label();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.lblLinha = new System.Windows.Forms.Label();
            this.lblNomeProfissional = new System.Windows.Forms.Label();
            this.lblObservacaoReceita = new System.Windows.Forms.Label();
            this.lblTranscricaoLentes = new System.Windows.Forms.Label();
            this.dtgRxFinal = new System.Windows.Forms.DataGridView();
            this.OlhoRxFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsferaRxFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CilindroRxFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EixoRxFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvRxFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.lblCodigoPacienteConsultaDataConsulta = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PrintDocumentReceita = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewReceita = new System.Windows.Forms.PrintPreviewDialog();
            this.msMenuSuperior.SuspendLayout();
            this.pnlReceita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRxFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenuSuperior
            // 
            this.msMenuSuperior.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarMsMenuSuperior,
            this.imprimirDocumentoToolStripMenuItem,
            this.selecionarFonteToolStripMenuItem,
            this.cbImpressoras});
            this.msMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.msMenuSuperior.Name = "msMenuSuperior";
            this.msMenuSuperior.Size = new System.Drawing.Size(1124, 30);
            this.msMenuSuperior.TabIndex = 0;
            this.msMenuSuperior.Text = "menuStrip1";
            // 
            // voltarMsMenuSuperior
            // 
            this.voltarMsMenuSuperior.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.voltarMsMenuSuperior.Name = "voltarMsMenuSuperior";
            this.voltarMsMenuSuperior.Size = new System.Drawing.Size(60, 26);
            this.voltarMsMenuSuperior.Text = "Voltar";
            this.voltarMsMenuSuperior.Click += new System.EventHandler(this.voltarMsMenuSuperior_Click);
            // 
            // imprimirDocumentoToolStripMenuItem
            // 
            this.imprimirDocumentoToolStripMenuItem.Name = "imprimirDocumentoToolStripMenuItem";
            this.imprimirDocumentoToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.imprimirDocumentoToolStripMenuItem.Text = "Imprimir";
            this.imprimirDocumentoToolStripMenuItem.Click += new System.EventHandler(this.imprimirDocumentoToolStripMenuItem_Click);
            // 
            // selecionarFonteToolStripMenuItem
            // 
            this.selecionarFonteToolStripMenuItem.Name = "selecionarFonteToolStripMenuItem";
            this.selecionarFonteToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.selecionarFonteToolStripMenuItem.Text = "Fonte";
            this.selecionarFonteToolStripMenuItem.Click += new System.EventHandler(this.selecionarFonteToolStripMenuItem_Click);
            // 
            // cbImpressoras
            // 
            this.cbImpressoras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbImpressoras.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.cbImpressoras.Name = "cbImpressoras";
            this.cbImpressoras.Size = new System.Drawing.Size(300, 26);
            this.cbImpressoras.Text = "Impressora";
            // 
            // cbImpressora
            // 
            this.cbImpressora.FormattingEnabled = true;
            this.cbImpressora.Location = new System.Drawing.Point(0, 57);
            this.cbImpressora.Name = "cbImpressora";
            this.cbImpressora.Size = new System.Drawing.Size(248, 26);
            this.cbImpressora.TabIndex = 1;
            this.cbImpressora.Visible = false;
            // 
            // txtNomeFont
            // 
            this.txtNomeFont.Location = new System.Drawing.Point(254, 57);
            this.txtNomeFont.Name = "txtNomeFont";
            this.txtNomeFont.Size = new System.Drawing.Size(129, 26);
            this.txtNomeFont.TabIndex = 2;
            this.txtNomeFont.Text = "Arial";
            this.txtNomeFont.Visible = false;
            // 
            // txtTamanhoFont
            // 
            this.txtTamanhoFont.Location = new System.Drawing.Point(389, 57);
            this.txtTamanhoFont.Name = "txtTamanhoFont";
            this.txtTamanhoFont.Size = new System.Drawing.Size(94, 26);
            this.txtTamanhoFont.TabIndex = 2;
            this.txtTamanhoFont.Text = "12";
            this.txtTamanhoFont.Visible = false;
            // 
            // txtEstiloFont
            // 
            this.txtEstiloFont.Location = new System.Drawing.Point(489, 57);
            this.txtEstiloFont.Name = "txtEstiloFont";
            this.txtEstiloFont.Size = new System.Drawing.Size(129, 26);
            this.txtEstiloFont.TabIndex = 2;
            this.txtEstiloFont.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Impressora:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fonte:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tamanho:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estilo:";
            this.label4.Visible = false;
            // 
            // pnlReceita
            // 
            this.pnlReceita.AutoScroll = true;
            this.pnlReceita.BackColor = System.Drawing.Color.White;
            this.pnlReceita.Controls.Add(this.lblConselhoClasse);
            this.pnlReceita.Controls.Add(this.lblLegenda);
            this.pnlReceita.Controls.Add(this.lblLinha);
            this.pnlReceita.Controls.Add(this.lblNomeProfissional);
            this.pnlReceita.Controls.Add(this.lblObservacaoReceita);
            this.pnlReceita.Controls.Add(this.lblTranscricaoLentes);
            this.pnlReceita.Controls.Add(this.dtgRxFinal);
            this.pnlReceita.Controls.Add(this.lblNomePaciente);
            this.pnlReceita.Controls.Add(this.lblCodigoPacienteConsultaDataConsulta);
            this.pnlReceita.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReceita.ForeColor = System.Drawing.Color.Black;
            this.pnlReceita.Location = new System.Drawing.Point(21, 89);
            this.pnlReceita.Name = "pnlReceita";
            this.pnlReceita.Size = new System.Drawing.Size(597, 794);
            this.pnlReceita.TabIndex = 4;
            this.pnlReceita.Visible = false;
            // 
            // lblConselhoClasse
            // 
            this.lblConselhoClasse.AutoSize = true;
            this.lblConselhoClasse.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConselhoClasse.Location = new System.Drawing.Point(194, 463);
            this.lblConselhoClasse.Name = "lblConselhoClasse";
            this.lblConselhoClasse.Size = new System.Drawing.Size(140, 17);
            this.lblConselhoClasse.TabIndex = 8;
            this.lblConselhoClasse.Text = "Conselho de Classe";
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.Location = new System.Drawing.Point(51, 273);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(434, 15);
            this.lblLegenda.TabIndex = 7;
            this.lblLegenda.Text = "VL- Visão de Longe    VP-Visão de Perto  OD- Olho Direito   OE-Olho Esquerdo";
            // 
            // lblLinha
            // 
            this.lblLinha.AutoSize = true;
            this.lblLinha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinha.Location = new System.Drawing.Point(64, 418);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(376, 17);
            this.lblLinha.TabIndex = 6;
            this.lblLinha.Text = "______________________________________________";
            // 
            // lblNomeProfissional
            // 
            this.lblNomeProfissional.AutoSize = true;
            this.lblNomeProfissional.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfissional.Location = new System.Drawing.Point(194, 445);
            this.lblNomeProfissional.Name = "lblNomeProfissional";
            this.lblNomeProfissional.Size = new System.Drawing.Size(88, 17);
            this.lblNomeProfissional.TabIndex = 5;
            this.lblNomeProfissional.Text = "Profissional:";
            // 
            // lblObservacaoReceita
            // 
            this.lblObservacaoReceita.AutoSize = true;
            this.lblObservacaoReceita.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacaoReceita.ForeColor = System.Drawing.Color.Black;
            this.lblObservacaoReceita.Location = new System.Drawing.Point(51, 347);
            this.lblObservacaoReceita.Name = "lblObservacaoReceita";
            this.lblObservacaoReceita.Size = new System.Drawing.Size(142, 17);
            this.lblObservacaoReceita.TabIndex = 3;
            this.lblObservacaoReceita.Text = "Observação Receita";
            // 
            // lblTranscricaoLentes
            // 
            this.lblTranscricaoLentes.AutoSize = true;
            this.lblTranscricaoLentes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranscricaoLentes.ForeColor = System.Drawing.Color.Black;
            this.lblTranscricaoLentes.Location = new System.Drawing.Point(51, 311);
            this.lblTranscricaoLentes.Name = "lblTranscricaoLentes";
            this.lblTranscricaoLentes.Size = new System.Drawing.Size(133, 17);
            this.lblTranscricaoLentes.TabIndex = 3;
            this.lblTranscricaoLentes.Text = "Transcrição Lentes";
            // 
            // dtgRxFinal
            // 
            this.dtgRxFinal.AllowUserToAddRows = false;
            this.dtgRxFinal.AllowUserToDeleteRows = false;
            this.dtgRxFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRxFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OlhoRxFinal,
            this.EsferaRxFinal,
            this.CilindroRxFinal,
            this.EixoRxFinal,
            this.AvRxFinal});
            this.dtgRxFinal.Location = new System.Drawing.Point(54, 152);
            this.dtgRxFinal.Name = "dtgRxFinal";
            this.dtgRxFinal.ReadOnly = true;
            this.dtgRxFinal.RowHeadersVisible = false;
            this.dtgRxFinal.Size = new System.Drawing.Size(395, 118);
            this.dtgRxFinal.TabIndex = 2;
            // 
            // OlhoRxFinal
            // 
            this.OlhoRxFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OlhoRxFinal.HeaderText = "Olho";
            this.OlhoRxFinal.Name = "OlhoRxFinal";
            this.OlhoRxFinal.ReadOnly = true;
            // 
            // EsferaRxFinal
            // 
            this.EsferaRxFinal.HeaderText = "Esfera";
            this.EsferaRxFinal.Name = "EsferaRxFinal";
            this.EsferaRxFinal.ReadOnly = true;
            this.EsferaRxFinal.Width = 80;
            // 
            // CilindroRxFinal
            // 
            this.CilindroRxFinal.HeaderText = "Cilindro";
            this.CilindroRxFinal.Name = "CilindroRxFinal";
            this.CilindroRxFinal.ReadOnly = true;
            this.CilindroRxFinal.Width = 80;
            // 
            // EixoRxFinal
            // 
            this.EixoRxFinal.HeaderText = "Eixo";
            this.EixoRxFinal.Name = "EixoRxFinal";
            this.EixoRxFinal.ReadOnly = true;
            this.EixoRxFinal.Width = 80;
            // 
            // AvRxFinal
            // 
            this.AvRxFinal.HeaderText = "Av";
            this.AvRxFinal.Name = "AvRxFinal";
            this.AvRxFinal.ReadOnly = true;
            this.AvRxFinal.Width = 80;
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.ForeColor = System.Drawing.Color.Black;
            this.lblNomePaciente.Location = new System.Drawing.Point(51, 107);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(104, 17);
            this.lblNomePaciente.TabIndex = 1;
            this.lblNomePaciente.Text = "NomePaciente";
            // 
            // lblCodigoPacienteConsultaDataConsulta
            // 
            this.lblCodigoPacienteConsultaDataConsulta.AutoSize = true;
            this.lblCodigoPacienteConsultaDataConsulta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPacienteConsultaDataConsulta.ForeColor = System.Drawing.Color.Black;
            this.lblCodigoPacienteConsultaDataConsulta.Location = new System.Drawing.Point(51, 75);
            this.lblCodigoPacienteConsultaDataConsulta.Name = "lblCodigoPacienteConsultaDataConsulta";
            this.lblCodigoPacienteConsultaDataConsulta.Size = new System.Drawing.Size(408, 17);
            this.lblCodigoPacienteConsultaDataConsulta.TabIndex = 0;
            this.lblCodigoPacienteConsultaDataConsulta.Text = "Código Paciente:        Código Consulta:       Data da Consulta:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PrintDocumentReceita
            // 
            this.PrintDocumentReceita.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocumentReceita_PrintPage);
            // 
            // PrintPreviewReceita
            // 
            this.PrintPreviewReceita.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewReceita.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewReceita.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewReceita.Enabled = true;
            this.PrintPreviewReceita.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewReceita.Icon")));
            this.PrintPreviewReceita.Name = "PrintPreviewReceita";
            this.PrintPreviewReceita.Visible = false;
            // 
            // frmImprimirDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1124, 567);
            this.ControlBox = false;
            this.Controls.Add(this.pnlReceita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstiloFont);
            this.Controls.Add(this.txtTamanhoFont);
            this.Controls.Add(this.txtNomeFont);
            this.Controls.Add(this.cbImpressora);
            this.Controls.Add(this.msMenuSuperior);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1148, 614);
            this.Name = "frmImprimirDados";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Impressão";
            this.Load += new System.EventHandler(this.frmImprimirDados_Load);
            this.msMenuSuperior.ResumeLayout(false);
            this.msMenuSuperior.PerformLayout();
            this.pnlReceita.ResumeLayout(false);
            this.pnlReceita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRxFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuSuperior;
        private System.Windows.Forms.ToolStripMenuItem voltarMsMenuSuperior;
        private System.Windows.Forms.ComboBox cbImpressora;
        private System.Windows.Forms.ToolStripMenuItem selecionarFonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirDocumentoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNomeFont;
        private System.Windows.Forms.TextBox txtTamanhoFont;
        private System.Windows.Forms.TextBox txtEstiloFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlReceita;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Label lblCodigoPacienteConsultaDataConsulta;
        private System.Windows.Forms.Label lblTranscricaoLentes;
        private System.Windows.Forms.Label lblObservacaoReceita;
        private System.Windows.Forms.DataGridView dtgRxFinal;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.Label lblNomeProfissional;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.ToolStripComboBox cbImpressoras;
        private System.Drawing.Printing.PrintDocument PrintDocumentReceita;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewReceita;
        private System.Windows.Forms.Label lblConselhoClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn OlhoRxFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsferaRxFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CilindroRxFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn EixoRxFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvRxFinal;
    }
}