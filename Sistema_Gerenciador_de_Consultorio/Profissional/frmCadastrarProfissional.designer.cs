namespace Sistema_Gerenciador_de_Consultorio
{
    partial class frmCadastrarProfissional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarProfissional));
            this.dtgIntermediario = new System.Windows.Forms.DataGridView();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.atualizar = new System.Windows.Forms.Timer(this.components);
            this.painelExterno1 = new System.Windows.Forms.Panel();
            this.rbEndereco = new System.Windows.Forms.RadioButton();
            this.rbContato = new System.Windows.Forms.RadioButton();
            this.rbDadosPessoais = new System.Windows.Forms.RadioButton();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.mtxtCROO = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxRG = new System.Windows.Forms.MaskedTextBox();
            this.txtEspecialidade = new System.Windows.Forms.TextBox();
            this.txtNomeProfissional = new System.Windows.Forms.TextBox();
            this.txtObservacaoProfissional = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblCROO = new System.Windows.Forms.Label();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.lblObservacaoProfissional = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNomeProfissional = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lblObservacaoEndereco = new System.Windows.Forms.Label();
            this.lblPontoDeReferencia = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtObservacaoEndereco = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtPontoDeReferencia = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.mtxtTelefone3 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservacaoContato = new System.Windows.Forms.TextBox();
            this.txtOutro = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStripSuperior = new System.Windows.Forms.MenuStrip();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRodapeReceita = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).BeginInit();
            this.painelExterno1.SuspendLayout();
            this.gbDadosPessoais.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.menuStripSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgIntermediario
            // 
            this.dtgIntermediario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIntermediario.Location = new System.Drawing.Point(813, 103);
            this.dtgIntermediario.Name = "dtgIntermediario";
            this.dtgIntermediario.Size = new System.Drawing.Size(142, 18);
            this.dtgIntermediario.TabIndex = 0;
            this.dtgIntermediario.Visible = false;
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsuario.ForeColor = System.Drawing.Color.White;
            this.lblLoginUsuario.Location = new System.Drawing.Point(3, 512);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(127, 18);
            this.lblLoginUsuario.TabIndex = 0;
            this.lblLoginUsuario.Text = "Nome de usuario";
            // 
            // atualizar
            // 
            this.atualizar.Enabled = true;
            this.atualizar.Tick += new System.EventHandler(this.atualizar_Tick);
            // 
            // painelExterno1
            // 
            this.painelExterno1.AutoScroll = true;
            this.painelExterno1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.painelExterno1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelExterno1.Controls.Add(this.rbEndereco);
            this.painelExterno1.Controls.Add(this.dtgIntermediario);
            this.painelExterno1.Controls.Add(this.rbContato);
            this.painelExterno1.Controls.Add(this.lblLoginUsuario);
            this.painelExterno1.Controls.Add(this.rbDadosPessoais);
            this.painelExterno1.Controls.Add(this.gbDadosPessoais);
            this.painelExterno1.Controls.Add(this.gbEndereco);
            this.painelExterno1.Controls.Add(this.gbContato);
            this.painelExterno1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.painelExterno1.ForeColor = System.Drawing.Color.White;
            this.painelExterno1.Location = new System.Drawing.Point(0, 29);
            this.painelExterno1.MinimumSize = new System.Drawing.Size(1073, 383);
            this.painelExterno1.Name = "painelExterno1";
            this.painelExterno1.Size = new System.Drawing.Size(1160, 574);
            this.painelExterno1.TabIndex = 1;
            // 
            // rbEndereco
            // 
            this.rbEndereco.AutoSize = true;
            this.rbEndereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEndereco.Location = new System.Drawing.Point(243, 9);
            this.rbEndereco.Name = "rbEndereco";
            this.rbEndereco.Size = new System.Drawing.Size(94, 22);
            this.rbEndereco.TabIndex = 2;
            this.rbEndereco.TabStop = true;
            this.rbEndereco.Text = "Endereço";
            this.rbEndereco.UseVisualStyleBackColor = true;
            this.rbEndereco.CheckedChanged += new System.EventHandler(this.rbEndereco_CheckedChanged);
            // 
            // rbContato
            // 
            this.rbContato.AutoSize = true;
            this.rbContato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContato.Location = new System.Drawing.Point(156, 9);
            this.rbContato.Name = "rbContato";
            this.rbContato.Size = new System.Drawing.Size(81, 22);
            this.rbContato.TabIndex = 2;
            this.rbContato.TabStop = true;
            this.rbContato.Text = "Contato";
            this.rbContato.UseVisualStyleBackColor = true;
            this.rbContato.CheckedChanged += new System.EventHandler(this.rbContato_CheckedChanged);
            // 
            // rbDadosPessoais
            // 
            this.rbDadosPessoais.AutoSize = true;
            this.rbDadosPessoais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDadosPessoais.Location = new System.Drawing.Point(12, 9);
            this.rbDadosPessoais.Name = "rbDadosPessoais";
            this.rbDadosPessoais.Size = new System.Drawing.Size(143, 22);
            this.rbDadosPessoais.TabIndex = 2;
            this.rbDadosPessoais.TabStop = true;
            this.rbDadosPessoais.Text = "Dados Pessoais";
            this.rbDadosPessoais.UseVisualStyleBackColor = true;
            this.rbDadosPessoais.CheckedChanged += new System.EventHandler(this.rbDadosPessoais_CheckedChanged);
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.txtRodapeReceita);
            this.gbDadosPessoais.Controls.Add(this.label7);
            this.gbDadosPessoais.Controls.Add(this.dtpDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.cbSexo);
            this.gbDadosPessoais.Controls.Add(this.mtxtCROO);
            this.gbDadosPessoais.Controls.Add(this.mtxtCPF);
            this.gbDadosPessoais.Controls.Add(this.mtxRG);
            this.gbDadosPessoais.Controls.Add(this.txtEspecialidade);
            this.gbDadosPessoais.Controls.Add(this.txtNomeProfissional);
            this.gbDadosPessoais.Controls.Add(this.txtObservacaoProfissional);
            this.gbDadosPessoais.Controls.Add(this.lblCPF);
            this.gbDadosPessoais.Controls.Add(this.lblDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.lblCROO);
            this.gbDadosPessoais.Controls.Add(this.lblEspecialidade);
            this.gbDadosPessoais.Controls.Add(this.lblObservacaoProfissional);
            this.gbDadosPessoais.Controls.Add(this.lblRG);
            this.gbDadosPessoais.Controls.Add(this.lblSexo);
            this.gbDadosPessoais.Controls.Add(this.lblNomeProfissional);
            this.gbDadosPessoais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosPessoais.ForeColor = System.Drawing.Color.White;
            this.gbDadosPessoais.Location = new System.Drawing.Point(63, 127);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(1022, 284);
            this.gbDadosPessoais.TabIndex = 4;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(834, 98);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(147, 26);
            this.dtpDataNascimento.TabIndex = 23;
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Selecione o sexo",
            "M",
            "F",
            "O"});
            this.cbSexo.Location = new System.Drawing.Point(523, 98);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(144, 26);
            this.cbSexo.TabIndex = 22;
            // 
            // mtxtCROO
            // 
            this.mtxtCROO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCROO.Location = new System.Drawing.Point(368, 98);
            this.mtxtCROO.Name = "mtxtCROO";
            this.mtxtCROO.Size = new System.Drawing.Size(133, 26);
            this.mtxtCROO.TabIndex = 21;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCPF.Location = new System.Drawing.Point(197, 98);
            this.mtxtCPF.Mask = "000.000.000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(142, 26);
            this.mtxtCPF.TabIndex = 20;
            // 
            // mtxRG
            // 
            this.mtxRG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxRG.Location = new System.Drawing.Point(43, 98);
            this.mtxRG.Name = "mtxRG";
            this.mtxRG.Size = new System.Drawing.Size(125, 26);
            this.mtxRG.TabIndex = 19;
            // 
            // txtEspecialidade
            // 
            this.txtEspecialidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEspecialidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidade.Location = new System.Drawing.Point(523, 46);
            this.txtEspecialidade.Name = "txtEspecialidade";
            this.txtEspecialidade.Size = new System.Drawing.Size(458, 26);
            this.txtEspecialidade.TabIndex = 18;
            // 
            // txtNomeProfissional
            // 
            this.txtNomeProfissional.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeProfissional.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProfissional.Location = new System.Drawing.Point(43, 46);
            this.txtNomeProfissional.Name = "txtNomeProfissional";
            this.txtNomeProfissional.Size = new System.Drawing.Size(460, 26);
            this.txtNomeProfissional.TabIndex = 17;
            // 
            // txtObservacaoProfissional
            // 
            this.txtObservacaoProfissional.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacaoProfissional.Location = new System.Drawing.Point(43, 200);
            this.txtObservacaoProfissional.Multiline = true;
            this.txtObservacaoProfissional.Name = "txtObservacaoProfissional";
            this.txtObservacaoProfissional.Size = new System.Drawing.Size(938, 64);
            this.txtObservacaoProfissional.TabIndex = 24;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(208, 75);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(45, 18);
            this.lblCPF.TabIndex = 9;
            this.lblCPF.Text = "CPF:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.Color.White;
            this.lblDataNascimento.Location = new System.Drawing.Point(850, 75);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(104, 18);
            this.lblDataNascimento.TabIndex = 10;
            this.lblDataNascimento.Text = "Data de Nas.:";
            // 
            // lblCROO
            // 
            this.lblCROO.AutoSize = true;
            this.lblCROO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCROO.ForeColor = System.Drawing.Color.White;
            this.lblCROO.Location = new System.Drawing.Point(377, 75);
            this.lblCROO.Name = "lblCROO";
            this.lblCROO.Size = new System.Drawing.Size(59, 18);
            this.lblCROO.TabIndex = 11;
            this.lblCROO.Text = "CROO:";
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidade.ForeColor = System.Drawing.Color.White;
            this.lblEspecialidade.Location = new System.Drawing.Point(537, 23);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(113, 18);
            this.lblEspecialidade.TabIndex = 12;
            this.lblEspecialidade.Text = "Especialidade:";
            // 
            // lblObservacaoProfissional
            // 
            this.lblObservacaoProfissional.AutoSize = true;
            this.lblObservacaoProfissional.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacaoProfissional.Location = new System.Drawing.Point(41, 180);
            this.lblObservacaoProfissional.Name = "lblObservacaoProfissional";
            this.lblObservacaoProfissional.Size = new System.Drawing.Size(97, 18);
            this.lblObservacaoProfissional.TabIndex = 13;
            this.lblObservacaoProfissional.Text = "Observação:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.ForeColor = System.Drawing.Color.White;
            this.lblRG.Location = new System.Drawing.Point(57, 75);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(35, 18);
            this.lblRG.TabIndex = 14;
            this.lblRG.Text = "RG:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(537, 75);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(48, 18);
            this.lblSexo.TabIndex = 15;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNomeProfissional
            // 
            this.lblNomeProfissional.AutoSize = true;
            this.lblNomeProfissional.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfissional.ForeColor = System.Drawing.Color.White;
            this.lblNomeProfissional.Location = new System.Drawing.Point(59, 23);
            this.lblNomeProfissional.Name = "lblNomeProfissional";
            this.lblNomeProfissional.Size = new System.Drawing.Size(54, 18);
            this.lblNomeProfissional.TabIndex = 16;
            this.lblNomeProfissional.Text = "Nome:";
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.lblBairro);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.lblEstado);
            this.gbEndereco.Controls.Add(this.mtxtCEP);
            this.gbEndereco.Controls.Add(this.lblObservacaoEndereco);
            this.gbEndereco.Controls.Add(this.lblPontoDeReferencia);
            this.gbEndereco.Controls.Add(this.lblRua);
            this.gbEndereco.Controls.Add(this.lblCEP);
            this.gbEndereco.Controls.Add(this.lblCidade);
            this.gbEndereco.Controls.Add(this.txtObservacaoEndereco);
            this.gbEndereco.Controls.Add(this.txtBairro);
            this.gbEndereco.Controls.Add(this.txtPontoDeReferencia);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.txtEstado);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEndereco.ForeColor = System.Drawing.Color.White;
            this.gbEndereco.Location = new System.Drawing.Point(63, 127);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(1022, 260);
            this.gbEndereco.TabIndex = 4;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(776, 35);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 18);
            this.lblBairro.TabIndex = 9;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(640, 35);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(67, 18);
            this.lblNumero.TabIndex = 10;
            this.lblNumero.Text = "Número:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(40, 35);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 18);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado:";
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCEP.Location = new System.Drawing.Point(508, 58);
            this.mtxtCEP.Mask = "00,000-000";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(96, 26);
            this.mtxtCEP.TabIndex = 20;
            // 
            // lblObservacaoEndereco
            // 
            this.lblObservacaoEndereco.AutoSize = true;
            this.lblObservacaoEndereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacaoEndereco.Location = new System.Drawing.Point(46, 139);
            this.lblObservacaoEndereco.Name = "lblObservacaoEndereco";
            this.lblObservacaoEndereco.Size = new System.Drawing.Size(93, 18);
            this.lblObservacaoEndereco.TabIndex = 12;
            this.lblObservacaoEndereco.Text = "Observação";
            // 
            // lblPontoDeReferencia
            // 
            this.lblPontoDeReferencia.AutoSize = true;
            this.lblPontoDeReferencia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontoDeReferencia.Location = new System.Drawing.Point(529, 87);
            this.lblPontoDeReferencia.Name = "lblPontoDeReferencia";
            this.lblPontoDeReferencia.Size = new System.Drawing.Size(155, 18);
            this.lblPontoDeReferencia.TabIndex = 13;
            this.lblPontoDeReferencia.Text = "Ponto de Referência:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(46, 87);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(40, 18);
            this.lblRua.TabIndex = 14;
            this.lblRua.Text = "Rua:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(504, 35);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(46, 18);
            this.lblCEP.TabIndex = 15;
            this.lblCEP.Text = "CEP:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(282, 35);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(64, 18);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtObservacaoEndereco
            // 
            this.txtObservacaoEndereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacaoEndereco.Location = new System.Drawing.Point(44, 162);
            this.txtObservacaoEndereco.Multiline = true;
            this.txtObservacaoEndereco.Name = "txtObservacaoEndereco";
            this.txtObservacaoEndereco.Size = new System.Drawing.Size(938, 64);
            this.txtObservacaoEndereco.TabIndex = 24;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(780, 58);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(202, 26);
            this.txtBairro.TabIndex = 19;
            // 
            // txtPontoDeReferencia
            // 
            this.txtPontoDeReferencia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPontoDeReferencia.Location = new System.Drawing.Point(527, 110);
            this.txtPontoDeReferencia.Multiline = true;
            this.txtPontoDeReferencia.Name = "txtPontoDeReferencia";
            this.txtPontoDeReferencia.Size = new System.Drawing.Size(455, 26);
            this.txtPontoDeReferencia.TabIndex = 23;
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(44, 110);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(477, 26);
            this.txtRua.TabIndex = 22;
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(44, 58);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(202, 26);
            this.txtEstado.TabIndex = 17;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(286, 58);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(182, 26);
            this.txtCidade.TabIndex = 18;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(644, 58);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(96, 26);
            this.txtNumero.TabIndex = 21;
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.mtxtTelefone3);
            this.gbContato.Controls.Add(this.mtxtTelefone2);
            this.gbContato.Controls.Add(this.mtxtTelefone1);
            this.gbContato.Controls.Add(this.label1);
            this.gbContato.Controls.Add(this.label2);
            this.gbContato.Controls.Add(this.label3);
            this.gbContato.Controls.Add(this.label4);
            this.gbContato.Controls.Add(this.label5);
            this.gbContato.Controls.Add(this.label6);
            this.gbContato.Controls.Add(this.txtObservacaoContato);
            this.gbContato.Controls.Add(this.txtOutro);
            this.gbContato.Controls.Add(this.txtEmail);
            this.gbContato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContato.ForeColor = System.Drawing.Color.White;
            this.gbContato.Location = new System.Drawing.Point(63, 127);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(1022, 260);
            this.gbContato.TabIndex = 3;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // mtxtTelefone3
            // 
            this.mtxtTelefone3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone3.Location = new System.Drawing.Point(840, 58);
            this.mtxtTelefone3.Mask = "(00)0,0000-0000";
            this.mtxtTelefone3.Name = "mtxtTelefone3";
            this.mtxtTelefone3.Size = new System.Drawing.Size(140, 26);
            this.mtxtTelefone3.TabIndex = 16;
            // 
            // mtxtTelefone2
            // 
            this.mtxtTelefone2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone2.Location = new System.Drawing.Point(672, 58);
            this.mtxtTelefone2.Mask = "(00)0,0000-0000";
            this.mtxtTelefone2.Name = "mtxtTelefone2";
            this.mtxtTelefone2.Size = new System.Drawing.Size(140, 26);
            this.mtxtTelefone2.TabIndex = 15;
            // 
            // mtxtTelefone1
            // 
            this.mtxtTelefone1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone1.Location = new System.Drawing.Point(504, 58);
            this.mtxtTelefone1.Mask = "(00)0,0000-0000";
            this.mtxtTelefone1.Name = "mtxtTelefone1";
            this.mtxtTelefone1.Size = new System.Drawing.Size(140, 26);
            this.mtxtTelefone1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Observação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Outro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(843, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefone 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(671, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefone 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(506, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefone 1:";
            // 
            // txtObservacaoContato
            // 
            this.txtObservacaoContato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacaoContato.Location = new System.Drawing.Point(42, 162);
            this.txtObservacaoContato.Multiline = true;
            this.txtObservacaoContato.Name = "txtObservacaoContato";
            this.txtObservacaoContato.Size = new System.Drawing.Size(938, 64);
            this.txtObservacaoContato.TabIndex = 18;
            // 
            // txtOutro
            // 
            this.txtOutro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutro.Location = new System.Drawing.Point(42, 110);
            this.txtOutro.Name = "txtOutro";
            this.txtOutro.Size = new System.Drawing.Size(938, 26);
            this.txtOutro.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(42, 58);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(445, 26);
            this.txtEmail.TabIndex = 13;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // menuStripSuperior
            // 
            this.menuStripSuperior.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.atualizarToolStripMenuItem,
            this.limparToolStripMenuItem,
            this.voltarToolStripMenuItem});
            this.menuStripSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuStripSuperior.Name = "menuStripSuperior";
            this.menuStripSuperior.Size = new System.Drawing.Size(1160, 26);
            this.menuStripSuperior.TabIndex = 2;
            this.menuStripSuperior.Text = "menuStrip1";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
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
            // txtRodapeReceita
            // 
            this.txtRodapeReceita.Location = new System.Drawing.Point(44, 148);
            this.txtRodapeReceita.Name = "txtRodapeReceita";
            this.txtRodapeReceita.Size = new System.Drawing.Size(936, 26);
            this.txtRodapeReceita.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Rodapé da Receita:";
            // 
            // frmCadastrarProfissional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1160, 603);
            this.ControlBox = false;
            this.Controls.Add(this.painelExterno1);
            this.Controls.Add(this.menuStripSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripSuperior;
            this.MinimumSize = new System.Drawing.Size(1073, 383);
            this.Name = "frmCadastrarProfissional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro/Atualização de profissional";
            this.Load += new System.EventHandler(this.frmCadastrarProfissional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).EndInit();
            this.painelExterno1.ResumeLayout(false);
            this.painelExterno1.PerformLayout();
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.menuStripSuperior.ResumeLayout(false);
            this.menuStripSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer atualizar;
        private System.Windows.Forms.Panel painelExterno1;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.DataGridView dtgIntermediario;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.RadioButton rbEndereco;
        private System.Windows.Forms.RadioButton rbContato;
        private System.Windows.Forms.RadioButton rbDadosPessoais;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.MaskedTextBox mtxtCROO;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.MaskedTextBox mtxRG;
        private System.Windows.Forms.TextBox txtEspecialidade;
        private System.Windows.Forms.TextBox txtNomeProfissional;
        private System.Windows.Forms.TextBox txtObservacaoProfissional;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblCROO;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.Label lblObservacaoProfissional;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNomeProfissional;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.MaskedTextBox mtxtCEP;
        private System.Windows.Forms.Label lblObservacaoEndereco;
        private System.Windows.Forms.Label lblPontoDeReferencia;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtObservacaoEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtPontoDeReferencia;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone3;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone2;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservacaoContato;
        private System.Windows.Forms.TextBox txtOutro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MenuStrip menuStripSuperior;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtRodapeReceita;
        private System.Windows.Forms.Label label7;
    }
}