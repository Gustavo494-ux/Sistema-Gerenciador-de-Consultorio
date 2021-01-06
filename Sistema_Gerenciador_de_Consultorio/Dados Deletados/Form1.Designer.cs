
namespace Sistema_Gerenciador_de_Consultorio.Dados_Deletados
{
    partial class Form1
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
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.rbConsulta = new System.Windows.Forms.RadioButton();
            this.estilizarDtg = new System.Windows.Forms.Timer(this.components);
            this.rbProfissional = new System.Windows.Forms.RadioButton();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.rbPaciente = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtgIntermediario = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbUsuario
            // 
            this.rbUsuario.AutoSize = true;
            this.rbUsuario.Location = new System.Drawing.Point(457, 128);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(61, 17);
            this.rbUsuario.TabIndex = 7;
            this.rbUsuario.Text = "Usuário";
            this.rbUsuario.UseVisualStyleBackColor = true;
            // 
            // rbConsulta
            // 
            this.rbConsulta.AutoSize = true;
            this.rbConsulta.Location = new System.Drawing.Point(364, 128);
            this.rbConsulta.Name = "rbConsulta";
            this.rbConsulta.Size = new System.Drawing.Size(66, 17);
            this.rbConsulta.TabIndex = 8;
            this.rbConsulta.Text = "Consulta";
            this.rbConsulta.UseVisualStyleBackColor = true;
            // 
            // estilizarDtg
            // 
            this.estilizarDtg.Enabled = true;
            this.estilizarDtg.Interval = 1;
            // 
            // rbProfissional
            // 
            this.rbProfissional.AutoSize = true;
            this.rbProfissional.Location = new System.Drawing.Point(253, 128);
            this.rbProfissional.Name = "rbProfissional";
            this.rbProfissional.Size = new System.Drawing.Size(78, 17);
            this.rbProfissional.TabIndex = 9;
            this.rbProfissional.Text = "Profissional";
            this.rbProfissional.UseVisualStyleBackColor = true;
            // 
            // gbUsuario
            // 
            this.gbUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbUsuario.Location = new System.Drawing.Point(156, 156);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(1136, 517);
            this.gbUsuario.TabIndex = 14;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Usuário";
            this.gbUsuario.Visible = false;
            // 
            // rbPaciente
            // 
            this.rbPaciente.AutoSize = true;
            this.rbPaciente.Checked = true;
            this.rbPaciente.Location = new System.Drawing.Point(159, 128);
            this.rbPaciente.Name = "rbPaciente";
            this.rbPaciente.Size = new System.Drawing.Size(67, 17);
            this.rbPaciente.TabIndex = 10;
            this.rbPaciente.TabStop = true;
            this.rbPaciente.Text = "Paciente";
            this.rbPaciente.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(168, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtgIntermediario
            // 
            this.dtgIntermediario.AllowUserToAddRows = false;
            this.dtgIntermediario.AllowUserToDeleteRows = false;
            this.dtgIntermediario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIntermediario.EnableHeadersVisualStyles = false;
            this.dtgIntermediario.Location = new System.Drawing.Point(315, 14);
            this.dtgIntermediario.Name = "dtgIntermediario";
            this.dtgIntermediario.ReadOnly = true;
            this.dtgIntermediario.Size = new System.Drawing.Size(47, 19);
            this.dtgIntermediario.TabIndex = 2;
            this.dtgIntermediario.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dtgIntermediario);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(144, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 40);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 802);
            this.Controls.Add(this.rbConsulta);
            this.Controls.Add(this.rbProfissional);
            this.Controls.Add(this.rbPaciente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.rbUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.RadioButton rbConsulta;
        private System.Windows.Forms.Timer estilizarDtg;
        private System.Windows.Forms.RadioButton rbProfissional;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.RadioButton rbPaciente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dtgIntermediario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}