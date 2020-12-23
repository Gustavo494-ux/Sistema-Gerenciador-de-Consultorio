namespace Sistema_Gerenciador_de_Consultorio
{
    partial class frmCadastrarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarPaciente));
            this.painelExterno1 = new System.Windows.Forms.Panel();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxRG = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeResponsavel = new System.Windows.Forms.TextBox();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.txtObservacaoPaciente = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblOcupacao = new System.Windows.Forms.Label();
            this.lblNomeResponsavel = new System.Windows.Forms.Label();
            this.lblObservacaoPaciente = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtocupacao = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.rbEndereco = new System.Windows.Forms.RadioButton();
            this.rbContato = new System.Windows.Forms.RadioButton();
            this.rbDadosPessoais = new System.Windows.Forms.RadioButton();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.gbContato = new System.Windows.Forms.GroupBox();
            this.mtxtTelefone3 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.lblObservacaoContato = new System.Windows.Forms.Label();
            this.lblOutro = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone3 = new System.Windows.Forms.Label();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.txtObservacaoContato = new System.Windows.Forms.TextBox();
            this.txtOutro = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlMenuSuperior = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtgPaciente = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Timer(this.components);
            this.painelExterno1.SuspendLayout();
            this.gbDadosPessoais.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbContato.SuspendLayout();
            this.pnlMenuSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // painelExterno1
            // 
            this.painelExterno1.AutoScroll = true;
            this.painelExterno1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.painelExterno1.Controls.Add(this.gbDadosPessoais);
            this.painelExterno1.Controls.Add(this.rbEndereco);
            this.painelExterno1.Controls.Add(this.rbContato);
            this.painelExterno1.Controls.Add(this.rbDadosPessoais);
            this.painelExterno1.Controls.Add(this.lblNomeUsuario);
            this.painelExterno1.Controls.Add(this.gbEndereco);
            this.painelExterno1.Controls.Add(this.gbContato);
            this.painelExterno1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.painelExterno1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelExterno1.ForeColor = System.Drawing.Color.White;
            this.painelExterno1.Location = new System.Drawing.Point(0, 41);
            this.painelExterno1.Name = "painelExterno1";
            this.painelExterno1.Size = new System.Drawing.Size(1160, 562);
            this.painelExterno1.TabIndex = 0;
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.dtpDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.lblDataNascimento);
            this.gbDadosPessoais.Controls.Add(this.cbSexo);
            this.gbDadosPessoais.Controls.Add(this.mtxtCPF);
            this.gbDadosPessoais.Controls.Add(this.mtxRG);
            this.gbDadosPessoais.Controls.Add(this.txtNomeResponsavel);
            this.gbDadosPessoais.Controls.Add(this.txtNomePaciente);
            this.gbDadosPessoais.Controls.Add(this.txtObservacaoPaciente);
            this.gbDadosPessoais.Controls.Add(this.lblIdade);
            this.gbDadosPessoais.Controls.Add(this.lblCPF);
            this.gbDadosPessoais.Controls.Add(this.lblOcupacao);
            this.gbDadosPessoais.Controls.Add(this.lblNomeResponsavel);
            this.gbDadosPessoais.Controls.Add(this.lblObservacaoPaciente);
            this.gbDadosPessoais.Controls.Add(this.lblRG);
            this.gbDadosPessoais.Controls.Add(this.lblSexo);
            this.gbDadosPessoais.Controls.Add(this.lblNomePaciente);
            this.gbDadosPessoais.Controls.Add(this.txtocupacao);
            this.gbDadosPessoais.Controls.Add(this.txtIdade);
            this.gbDadosPessoais.ForeColor = System.Drawing.Color.White;
            this.gbDadosPessoais.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbDadosPessoais.Location = new System.Drawing.Point(63, 127);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(1022, 252);
            this.gbDadosPessoais.TabIndex = 1;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(762, 106);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(147, 26);
            this.dtpDataNascimento.TabIndex = 25;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.Color.White;
            this.lblDataNascimento.Location = new System.Drawing.Point(758, 83);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(104, 18);
            this.lblDataNascimento.TabIndex = 11;
            this.lblDataNascimento.Text = "Data de Nas.:";
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.ForeColor = System.Drawing.Color.Black;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Selecionar",
            "M",
            "F",
            "O"});
            this.cbSexo.Location = new System.Drawing.Point(627, 106);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(104, 26);
            this.cbSexo.TabIndex = 24;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCPF.Location = new System.Drawing.Point(209, 106);
            this.mtxtCPF.Mask = "000.000.000-00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(142, 26);
            this.mtxtCPF.TabIndex = 22;
            // 
            // mtxRG
            // 
            this.mtxRG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxRG.Location = new System.Drawing.Point(42, 106);
            this.mtxRG.Name = "mtxRG";
            this.mtxRG.Size = new System.Drawing.Size(136, 26);
            this.mtxRG.TabIndex = 21;
            // 
            // txtNomeResponsavel
            // 
            this.txtNomeResponsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeResponsavel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeResponsavel.Location = new System.Drawing.Point(522, 54);
            this.txtNomeResponsavel.Name = "txtNomeResponsavel";
            this.txtNomeResponsavel.Size = new System.Drawing.Size(458, 26);
            this.txtNomeResponsavel.TabIndex = 20;
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomePaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePaciente.Location = new System.Drawing.Point(42, 54);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(458, 26);
            this.txtNomePaciente.TabIndex = 19;
            // 
            // txtObservacaoPaciente
            // 
            this.txtObservacaoPaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacaoPaciente.Location = new System.Drawing.Point(42, 158);
            this.txtObservacaoPaciente.Multiline = true;
            this.txtObservacaoPaciente.Name = "txtObservacaoPaciente";
            this.txtObservacaoPaciente.Size = new System.Drawing.Size(938, 64);
            this.txtObservacaoPaciente.TabIndex = 27;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(910, 83);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(51, 18);
            this.lblIdade.TabIndex = 10;
            this.lblIdade.Text = "Idade:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(208, 83);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(45, 18);
            this.lblCPF.TabIndex = 13;
            this.lblCPF.Text = "CPF:";
            // 
            // lblOcupacao
            // 
            this.lblOcupacao.AutoSize = true;
            this.lblOcupacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupacao.ForeColor = System.Drawing.Color.White;
            this.lblOcupacao.Location = new System.Drawing.Point(384, 83);
            this.lblOcupacao.Name = "lblOcupacao";
            this.lblOcupacao.Size = new System.Drawing.Size(84, 18);
            this.lblOcupacao.TabIndex = 14;
            this.lblOcupacao.Text = "Ocupação:";
            // 
            // lblNomeResponsavel
            // 
            this.lblNomeResponsavel.AutoSize = true;
            this.lblNomeResponsavel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeResponsavel.ForeColor = System.Drawing.Color.White;
            this.lblNomeResponsavel.Location = new System.Drawing.Point(514, 31);
            this.lblNomeResponsavel.Name = "lblNomeResponsavel";
            this.lblNomeResponsavel.Size = new System.Drawing.Size(102, 18);
            this.lblNomeResponsavel.TabIndex = 15;
            this.lblNomeResponsavel.Text = "Responsável:";
            // 
            // lblObservacaoPaciente
            // 
            this.lblObservacaoPaciente.AutoSize = true;
            this.lblObservacaoPaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacaoPaciente.ForeColor = System.Drawing.Color.White;
            this.lblObservacaoPaciente.Location = new System.Drawing.Point(44, 135);
            this.lblObservacaoPaciente.Name = "lblObservacaoPaciente";
            this.lblObservacaoPaciente.Size = new System.Drawing.Size(97, 18);
            this.lblObservacaoPaciente.TabIndex = 16;
            this.lblObservacaoPaciente.Text = "Observação:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.ForeColor = System.Drawing.Color.White;
            this.lblRG.Location = new System.Drawing.Point(44, 83);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(35, 18);
            this.lblRG.TabIndex = 17;
            this.lblRG.Text = "RG:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.White;
            this.lblSexo.Location = new System.Drawing.Point(623, 83);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(48, 18);
            this.lblSexo.TabIndex = 18;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.ForeColor = System.Drawing.Color.White;
            this.lblNomePaciente.Location = new System.Drawing.Point(44, 31);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(54, 18);
            this.lblNomePaciente.TabIndex = 12;
            this.lblNomePaciente.Text = "Nome:";
            // 
            // txtocupacao
            // 
            this.txtocupacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtocupacao.Location = new System.Drawing.Point(382, 106);
            this.txtocupacao.Name = "txtocupacao";
            this.txtocupacao.Size = new System.Drawing.Size(214, 26);
            this.txtocupacao.TabIndex = 23;
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(914, 106);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(66, 26);
            this.txtIdade.TabIndex = 26;
            // 
            // rbEndereco
            // 
            this.rbEndereco.AutoSize = true;
            this.rbEndereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEndereco.Location = new System.Drawing.Point(234, 5);
            this.rbEndereco.Name = "rbEndereco";
            this.rbEndereco.Size = new System.Drawing.Size(94, 22);
            this.rbEndereco.TabIndex = 7;
            this.rbEndereco.TabStop = true;
            this.rbEndereco.Text = "Endereço";
            this.rbEndereco.UseVisualStyleBackColor = true;
            this.rbEndereco.CheckedChanged += new System.EventHandler(this.rbEndereco_CheckedChanged);
            // 
            // rbContato
            // 
            this.rbContato.AutoSize = true;
            this.rbContato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContato.Location = new System.Drawing.Point(147, 5);
            this.rbContato.Name = "rbContato";
            this.rbContato.Size = new System.Drawing.Size(81, 22);
            this.rbContato.TabIndex = 8;
            this.rbContato.TabStop = true;
            this.rbContato.Text = "Contato";
            this.rbContato.UseVisualStyleBackColor = true;
            this.rbContato.CheckedChanged += new System.EventHandler(this.rbContato_CheckedChanged);
            // 
            // rbDadosPessoais
            // 
            this.rbDadosPessoais.AutoSize = true;
            this.rbDadosPessoais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDadosPessoais.Location = new System.Drawing.Point(3, 5);
            this.rbDadosPessoais.Name = "rbDadosPessoais";
            this.rbDadosPessoais.Size = new System.Drawing.Size(143, 22);
            this.rbDadosPessoais.TabIndex = 9;
            this.rbDadosPessoais.TabStop = true;
            this.rbDadosPessoais.Text = "Dados Pessoais";
            this.rbDadosPessoais.UseVisualStyleBackColor = true;
            this.rbDadosPessoais.CheckedChanged += new System.EventHandler(this.rbDadosPessoais_CheckedChanged);
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(3, 512);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(127, 18);
            this.lblNomeUsuario.TabIndex = 0;
            this.lblNomeUsuario.Text = "Nome de usuario";
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
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.txtEstado);
            this.gbEndereco.Controls.Add(this.txtCidade);
            this.gbEndereco.ForeColor = System.Drawing.Color.White;
            this.gbEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbEndereco.Location = new System.Drawing.Point(63, 127);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(1022, 252);
            this.gbEndereco.TabIndex = 1;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Enderço";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.White;
            this.lblBairro.Location = new System.Drawing.Point(495, 34);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 18);
            this.lblBairro.TabIndex = 9;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(881, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(67, 18);
            this.lblNumero.TabIndex = 10;
            this.lblNumero.Text = "Número:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(44, 29);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 18);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado:";
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCEP.Location = new System.Drawing.Point(755, 55);
            this.mtxtCEP.Mask = "00,000-000";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(96, 26);
            this.mtxtCEP.TabIndex = 20;
            // 
            // lblObservacaoEndereco
            // 
            this.lblObservacaoEndereco.AutoSize = true;
            this.lblObservacaoEndereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacaoEndereco.ForeColor = System.Drawing.Color.White;
            this.lblObservacaoEndereco.Location = new System.Drawing.Point(44, 136);
            this.lblObservacaoEndereco.Name = "lblObservacaoEndereco";
            this.lblObservacaoEndereco.Size = new System.Drawing.Size(93, 18);
            this.lblObservacaoEndereco.TabIndex = 12;
            this.lblObservacaoEndereco.Text = "Observação";
            // 
            // lblPontoDeReferencia
            // 
            this.lblPontoDeReferencia.AutoSize = true;
            this.lblPontoDeReferencia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontoDeReferencia.ForeColor = System.Drawing.Color.White;
            this.lblPontoDeReferencia.Location = new System.Drawing.Point(540, 84);
            this.lblPontoDeReferencia.Name = "lblPontoDeReferencia";
            this.lblPontoDeReferencia.Size = new System.Drawing.Size(155, 18);
            this.lblPontoDeReferencia.TabIndex = 13;
            this.lblPontoDeReferencia.Text = "Ponto de Referência:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.ForeColor = System.Drawing.Color.White;
            this.lblRua.Location = new System.Drawing.Point(44, 84);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(40, 18);
            this.lblRua.TabIndex = 14;
            this.lblRua.Text = "Rua:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.ForeColor = System.Drawing.Color.White;
            this.lblCEP.Location = new System.Drawing.Point(752, 34);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(46, 18);
            this.lblCEP.TabIndex = 15;
            this.lblCEP.Text = "CEP:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.ForeColor = System.Drawing.Color.White;
            this.lblCidade.Location = new System.Drawing.Point(256, 32);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(64, 18);
            this.lblCidade.TabIndex = 16;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtObservacaoEndereco
            // 
            this.txtObservacaoEndereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacaoEndereco.Location = new System.Drawing.Point(42, 159);
            this.txtObservacaoEndereco.Multiline = true;
            this.txtObservacaoEndereco.Name = "txtObservacaoEndereco";
            this.txtObservacaoEndereco.Size = new System.Drawing.Size(938, 64);
            this.txtObservacaoEndereco.TabIndex = 24;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(499, 55);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(199, 26);
            this.txtBairro.TabIndex = 19;
            // 
            // txtPontoDeReferencia
            // 
            this.txtPontoDeReferencia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPontoDeReferencia.Location = new System.Drawing.Point(544, 107);
            this.txtPontoDeReferencia.Name = "txtPontoDeReferencia";
            this.txtPontoDeReferencia.Size = new System.Drawing.Size(436, 26);
            this.txtPontoDeReferencia.TabIndex = 23;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(882, 55);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(98, 26);
            this.txtNumero.TabIndex = 21;
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(42, 107);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(477, 26);
            this.txtRua.TabIndex = 22;
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(42, 55);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(161, 26);
            this.txtEstado.TabIndex = 17;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(260, 55);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(182, 26);
            this.txtCidade.TabIndex = 18;
            // 
            // gbContato
            // 
            this.gbContato.Controls.Add(this.mtxtTelefone3);
            this.gbContato.Controls.Add(this.mtxtTelefone2);
            this.gbContato.Controls.Add(this.mtxtTelefone1);
            this.gbContato.Controls.Add(this.lblObservacaoContato);
            this.gbContato.Controls.Add(this.lblOutro);
            this.gbContato.Controls.Add(this.lblEmail);
            this.gbContato.Controls.Add(this.lblTelefone3);
            this.gbContato.Controls.Add(this.lblTelefone2);
            this.gbContato.Controls.Add(this.lblTelefone1);
            this.gbContato.Controls.Add(this.txtObservacaoContato);
            this.gbContato.Controls.Add(this.txtOutro);
            this.gbContato.Controls.Add(this.txtEmail);
            this.gbContato.ForeColor = System.Drawing.Color.White;
            this.gbContato.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbContato.Location = new System.Drawing.Point(63, 127);
            this.gbContato.Name = "gbContato";
            this.gbContato.Size = new System.Drawing.Size(1022, 252);
            this.gbContato.TabIndex = 1;
            this.gbContato.TabStop = false;
            this.gbContato.Text = "Contato";
            // 
            // mtxtTelefone3
            // 
            this.mtxtTelefone3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone3.Location = new System.Drawing.Point(840, 54);
            this.mtxtTelefone3.Mask = "(00)0,0000-0000";
            this.mtxtTelefone3.Name = "mtxtTelefone3";
            this.mtxtTelefone3.Size = new System.Drawing.Size(140, 26);
            this.mtxtTelefone3.TabIndex = 16;
            // 
            // mtxtTelefone2
            // 
            this.mtxtTelefone2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone2.Location = new System.Drawing.Point(672, 54);
            this.mtxtTelefone2.Mask = "(00)0,0000-0000";
            this.mtxtTelefone2.Name = "mtxtTelefone2";
            this.mtxtTelefone2.Size = new System.Drawing.Size(140, 26);
            this.mtxtTelefone2.TabIndex = 15;
            // 
            // mtxtTelefone1
            // 
            this.mtxtTelefone1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTelefone1.Location = new System.Drawing.Point(504, 54);
            this.mtxtTelefone1.Mask = "(00)0,0000-0000";
            this.mtxtTelefone1.Name = "mtxtTelefone1";
            this.mtxtTelefone1.Size = new System.Drawing.Size(140, 26);
            this.mtxtTelefone1.TabIndex = 14;
            // 
            // lblObservacaoContato
            // 
            this.lblObservacaoContato.AutoSize = true;
            this.lblObservacaoContato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacaoContato.ForeColor = System.Drawing.Color.White;
            this.lblObservacaoContato.Location = new System.Drawing.Point(44, 135);
            this.lblObservacaoContato.Name = "lblObservacaoContato";
            this.lblObservacaoContato.Size = new System.Drawing.Size(93, 18);
            this.lblObservacaoContato.TabIndex = 7;
            this.lblObservacaoContato.Text = "Observação";
            // 
            // lblOutro
            // 
            this.lblOutro.AutoSize = true;
            this.lblOutro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutro.ForeColor = System.Drawing.Color.White;
            this.lblOutro.Location = new System.Drawing.Point(44, 83);
            this.lblOutro.Name = "lblOutro";
            this.lblOutro.Size = new System.Drawing.Size(50, 18);
            this.lblOutro.TabIndex = 8;
            this.lblOutro.Text = "Outro:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(44, 31);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 18);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefone3
            // 
            this.lblTelefone3.AutoSize = true;
            this.lblTelefone3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone3.ForeColor = System.Drawing.Color.White;
            this.lblTelefone3.Location = new System.Drawing.Point(843, 31);
            this.lblTelefone3.Name = "lblTelefone3";
            this.lblTelefone3.Size = new System.Drawing.Size(83, 18);
            this.lblTelefone3.TabIndex = 10;
            this.lblTelefone3.Text = "Telefone 3:";
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.ForeColor = System.Drawing.Color.White;
            this.lblTelefone2.Location = new System.Drawing.Point(671, 31);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(83, 18);
            this.lblTelefone2.TabIndex = 11;
            this.lblTelefone2.Text = "Telefone 2:";
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone1.ForeColor = System.Drawing.Color.White;
            this.lblTelefone1.Location = new System.Drawing.Point(506, 31);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(83, 18);
            this.lblTelefone1.TabIndex = 12;
            this.lblTelefone1.Text = "Telefone 1:";
            // 
            // txtObservacaoContato
            // 
            this.txtObservacaoContato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacaoContato.Location = new System.Drawing.Point(42, 158);
            this.txtObservacaoContato.Multiline = true;
            this.txtObservacaoContato.Name = "txtObservacaoContato";
            this.txtObservacaoContato.Size = new System.Drawing.Size(938, 64);
            this.txtObservacaoContato.TabIndex = 18;
            // 
            // txtOutro
            // 
            this.txtOutro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutro.Location = new System.Drawing.Point(42, 106);
            this.txtOutro.Name = "txtOutro";
            this.txtOutro.Size = new System.Drawing.Size(938, 26);
            this.txtOutro.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(42, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(431, 26);
            this.txtEmail.TabIndex = 13;
            // 
            // pnlMenuSuperior
            // 
            this.pnlMenuSuperior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenuSuperior.Controls.Add(this.btnCancelar);
            this.pnlMenuSuperior.Controls.Add(this.btnLimpar);
            this.pnlMenuSuperior.Controls.Add(this.btnSalvar);
            this.pnlMenuSuperior.Controls.Add(this.dtgPaciente);
            this.pnlMenuSuperior.Controls.Add(this.btnAlterar);
            this.pnlMenuSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuSuperior.Name = "pnlMenuSuperior";
            this.pnlMenuSuperior.Size = new System.Drawing.Size(1160, 40);
            this.pnlMenuSuperior.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(202, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 30);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.limpar;
            this.btnLimpar.Location = new System.Drawing.Point(105, 6);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(91, 30);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.Salvar;
            this.btnSalvar.Location = new System.Drawing.Point(8, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 30);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtgPaciente
            // 
            this.dtgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPaciente.Location = new System.Drawing.Point(1578, 26);
            this.dtgPaciente.Name = "dtgPaciente";
            this.dtgPaciente.Size = new System.Drawing.Size(140, 24);
            this.dtgPaciente.TabIndex = 4;
            this.dtgPaciente.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.Alterar;
            this.btnAlterar.Location = new System.Drawing.Point(8, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 30);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // atualizar
            // 
            this.atualizar.Enabled = true;
            this.atualizar.Tick += new System.EventHandler(this.atualizar_Tick);
            // 
            // frmCadastrarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 603);
            this.Controls.Add(this.painelExterno1);
            this.Controls.Add(this.pnlMenuSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastrarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar/Atualizar Paciente";
            this.Load += new System.EventHandler(this.frmCadastrarPaciente_Load);
            this.painelExterno1.ResumeLayout(false);
            this.painelExterno1.PerformLayout();
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbContato.ResumeLayout(false);
            this.gbContato.PerformLayout();
            this.pnlMenuSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel painelExterno1;
        private System.Windows.Forms.Panel pnlMenuSuperior;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Timer atualizar;
        private System.Windows.Forms.DataGridView dtgPaciente;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.RadioButton rbEndereco;
        private System.Windows.Forms.RadioButton rbContato;
        private System.Windows.Forms.RadioButton rbDadosPessoais;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.GroupBox gbContato;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.MaskedTextBox mtxRG;
        private System.Windows.Forms.TextBox txtNomeResponsavel;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.TextBox txtObservacaoPaciente;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblOcupacao;
        private System.Windows.Forms.Label lblNomeResponsavel;
        private System.Windows.Forms.Label lblObservacaoPaciente;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.TextBox txtocupacao;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone3;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone2;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone1;
        private System.Windows.Forms.Label lblObservacaoContato;
        private System.Windows.Forms.Label lblOutro;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone3;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.Label lblTelefone1;
        private System.Windows.Forms.TextBox txtObservacaoContato;
        private System.Windows.Forms.TextBox txtOutro;
        private System.Windows.Forms.TextBox txtEmail;
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
    }
}