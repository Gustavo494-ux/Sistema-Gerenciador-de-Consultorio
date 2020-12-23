namespace Sistema_Gerenciador_de_Consultorio
{
    partial class frmUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLImpar = new System.Windows.Forms.Button();
            this.pnlMenuSuperior = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.rbPesquisarUsuario = new System.Windows.Forms.RadioButton();
            this.rbCadastrarUsuario = new System.Windows.Forms.RadioButton();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.repetir = new System.Windows.Forms.Timer(this.components);
            this.pnlPesquisar = new System.Windows.Forms.Panel();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbNomeUsuario = new System.Windows.Forms.RadioButton();
            this.rbStatusUsuario = new System.Windows.Forms.RadioButton();
            this.rbLoginUsuario = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.rbNivelAcesso = new System.Windows.Forms.RadioButton();
            this.cbStatusUsuarioPesquisa = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbNivelAcessoPesquisa = new System.Windows.Forms.ComboBox();
            this.dtgIntermediario = new System.Windows.Forms.DataGridView();
            this.dataSetImpressao = new Sistema_Gerenciador_de_Consultorio.DataSet.DataSetImpressao();
            this.usuarioCompletoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioCompletoTableAdapter = new Sistema_Gerenciador_de_Consultorio.DataSet.DataSetImpressaoTableAdapters.UsuarioCompletoTableAdapter();
            this.pnlCadastrar = new System.Windows.Forms.Panel();
            this.lblStatusUsuario = new System.Windows.Forms.Label();
            this.lblNivelAcesso = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblObservacaoUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.cbStatusUsuario = new System.Windows.Forms.ComboBox();
            this.cbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.btnDeletar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnImprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgUsuario = new System.Windows.Forms.DataGridView();
            this.pnlMenuSuperior.SuspendLayout();
            this.pnlPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetImpressao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioCompletoBindingSource)).BeginInit();
            this.pnlCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.Salvar;
            this.btnSalvar.Location = new System.Drawing.Point(4, 4);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 27);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(198, 4);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 27);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLImpar
            // 
            this.btnLImpar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.limpar;
            this.btnLImpar.Location = new System.Drawing.Point(101, 4);
            this.btnLImpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLImpar.Name = "btnLImpar";
            this.btnLImpar.Size = new System.Drawing.Size(91, 27);
            this.btnLImpar.TabIndex = 0;
            this.btnLImpar.UseVisualStyleBackColor = true;
            this.btnLImpar.Click += new System.EventHandler(this.btnLImpar_Click);
            // 
            // pnlMenuSuperior
            // 
            this.pnlMenuSuperior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenuSuperior.Controls.Add(this.btnAlterar);
            this.pnlMenuSuperior.Controls.Add(this.btnSalvar);
            this.pnlMenuSuperior.Controls.Add(this.btnCancelar);
            this.pnlMenuSuperior.Controls.Add(this.btnLImpar);
            this.pnlMenuSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuSuperior.Name = "pnlMenuSuperior";
            this.pnlMenuSuperior.Size = new System.Drawing.Size(1160, 36);
            this.pnlMenuSuperior.TabIndex = 0;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.Alterar;
            this.btnAlterar.Location = new System.Drawing.Point(4, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(91, 27);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // rbPesquisarUsuario
            // 
            this.rbPesquisarUsuario.AutoSize = true;
            this.rbPesquisarUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPesquisarUsuario.ForeColor = System.Drawing.Color.White;
            this.rbPesquisarUsuario.Location = new System.Drawing.Point(949, 45);
            this.rbPesquisarUsuario.Name = "rbPesquisarUsuario";
            this.rbPesquisarUsuario.Size = new System.Drawing.Size(97, 22);
            this.rbPesquisarUsuario.TabIndex = 0;
            this.rbPesquisarUsuario.TabStop = true;
            this.rbPesquisarUsuario.Text = "Pesquisar";
            this.rbPesquisarUsuario.UseVisualStyleBackColor = true;
            this.rbPesquisarUsuario.CheckedChanged += new System.EventHandler(this.rbPesquisarUsuario_CheckedChanged);
            // 
            // rbCadastrarUsuario
            // 
            this.rbCadastrarUsuario.AutoSize = true;
            this.rbCadastrarUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCadastrarUsuario.ForeColor = System.Drawing.Color.White;
            this.rbCadastrarUsuario.Location = new System.Drawing.Point(1052, 45);
            this.rbCadastrarUsuario.Name = "rbCadastrarUsuario";
            this.rbCadastrarUsuario.Size = new System.Drawing.Size(96, 22);
            this.rbCadastrarUsuario.TabIndex = 0;
            this.rbCadastrarUsuario.TabStop = true;
            this.rbCadastrarUsuario.Text = "Cadastrar";
            this.rbCadastrarUsuario.UseVisualStyleBackColor = true;
            this.rbCadastrarUsuario.CheckedChanged += new System.EventHandler(this.rbCadastrarUsuario_CheckedChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(5, 45);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(127, 18);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Nome de usuario";
            // 
            // repetir
            // 
            this.repetir.Enabled = true;
            this.repetir.Tick += new System.EventHandler(this.repetir_Tick);
            // 
            // pnlPesquisar
            // 
            this.pnlPesquisar.Controls.Add(this.rbTodos);
            this.pnlPesquisar.Controls.Add(this.rbNomeUsuario);
            this.pnlPesquisar.Controls.Add(this.rbStatusUsuario);
            this.pnlPesquisar.Controls.Add(this.rbLoginUsuario);
            this.pnlPesquisar.Controls.Add(this.txtPesquisar);
            this.pnlPesquisar.Controls.Add(this.rbNivelAcesso);
            this.pnlPesquisar.Controls.Add(this.cbStatusUsuarioPesquisa);
            this.pnlPesquisar.Controls.Add(this.btnPesquisar);
            this.pnlPesquisar.Controls.Add(this.cbNivelAcessoPesquisa);
            this.pnlPesquisar.Location = new System.Drawing.Point(114, 45);
            this.pnlPesquisar.Name = "pnlPesquisar";
            this.pnlPesquisar.Size = new System.Drawing.Size(416, 98);
            this.pnlPesquisar.TabIndex = 5;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.Color.White;
            this.rbTodos.Location = new System.Drawing.Point(202, 40);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(68, 22);
            this.rbTodos.TabIndex = 2;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.Click += new System.EventHandler(this.filtros);
            // 
            // rbNomeUsuario
            // 
            this.rbNomeUsuario.AutoSize = true;
            this.rbNomeUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.rbNomeUsuario.Location = new System.Drawing.Point(131, 65);
            this.rbNomeUsuario.Name = "rbNomeUsuario";
            this.rbNomeUsuario.Size = new System.Drawing.Size(68, 22);
            this.rbNomeUsuario.TabIndex = 4;
            this.rbNomeUsuario.TabStop = true;
            this.rbNomeUsuario.Text = "Nome";
            this.rbNomeUsuario.UseVisualStyleBackColor = true;
            this.rbNomeUsuario.Click += new System.EventHandler(this.filtros);
            // 
            // rbStatusUsuario
            // 
            this.rbStatusUsuario.AutoSize = true;
            this.rbStatusUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStatusUsuario.ForeColor = System.Drawing.Color.White;
            this.rbStatusUsuario.Location = new System.Drawing.Point(9, 65);
            this.rbStatusUsuario.Name = "rbStatusUsuario";
            this.rbStatusUsuario.Size = new System.Drawing.Size(70, 22);
            this.rbStatusUsuario.TabIndex = 3;
            this.rbStatusUsuario.TabStop = true;
            this.rbStatusUsuario.Text = "Status";
            this.rbStatusUsuario.UseVisualStyleBackColor = true;
            this.rbStatusUsuario.Click += new System.EventHandler(this.filtros);
            // 
            // rbLoginUsuario
            // 
            this.rbLoginUsuario.AutoSize = true;
            this.rbLoginUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLoginUsuario.ForeColor = System.Drawing.Color.White;
            this.rbLoginUsuario.Location = new System.Drawing.Point(131, 40);
            this.rbLoginUsuario.Name = "rbLoginUsuario";
            this.rbLoginUsuario.Size = new System.Drawing.Size(65, 22);
            this.rbLoginUsuario.TabIndex = 1;
            this.rbLoginUsuario.TabStop = true;
            this.rbLoginUsuario.Text = "Login";
            this.rbLoginUsuario.UseVisualStyleBackColor = true;
            this.rbLoginUsuario.Click += new System.EventHandler(this.filtros);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(9, 11);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(305, 26);
            this.txtPesquisar.TabIndex = 7;
            this.txtPesquisar.Visible = false;
            // 
            // rbNivelAcesso
            // 
            this.rbNivelAcesso.AutoSize = true;
            this.rbNivelAcesso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNivelAcesso.ForeColor = System.Drawing.Color.White;
            this.rbNivelAcesso.Location = new System.Drawing.Point(9, 40);
            this.rbNivelAcesso.Name = "rbNivelAcesso";
            this.rbNivelAcesso.Size = new System.Drawing.Size(116, 22);
            this.rbNivelAcesso.TabIndex = 0;
            this.rbNivelAcesso.TabStop = true;
            this.rbNivelAcesso.Text = "Nivel Acesso";
            this.rbNivelAcesso.UseVisualStyleBackColor = true;
            this.rbNivelAcesso.Click += new System.EventHandler(this.filtros);
            // 
            // cbStatusUsuarioPesquisa
            // 
            this.cbStatusUsuarioPesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusUsuarioPesquisa.FormattingEnabled = true;
            this.cbStatusUsuarioPesquisa.Location = new System.Drawing.Point(9, 11);
            this.cbStatusUsuarioPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStatusUsuarioPesquisa.Name = "cbStatusUsuarioPesquisa";
            this.cbStatusUsuarioPesquisa.Size = new System.Drawing.Size(305, 26);
            this.cbStatusUsuarioPesquisa.TabIndex = 6;
            this.cbStatusUsuarioPesquisa.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.pesquisar;
            this.btnPesquisar.Location = new System.Drawing.Point(320, 7);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 27);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // cbNivelAcessoPesquisa
            // 
            this.cbNivelAcessoPesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivelAcessoPesquisa.FormattingEnabled = true;
            this.cbNivelAcessoPesquisa.Location = new System.Drawing.Point(9, 11);
            this.cbNivelAcessoPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNivelAcessoPesquisa.Name = "cbNivelAcessoPesquisa";
            this.cbNivelAcessoPesquisa.Size = new System.Drawing.Size(305, 26);
            this.cbNivelAcessoPesquisa.TabIndex = 8;
            this.cbNivelAcessoPesquisa.Visible = false;
            // 
            // dtgIntermediario
            // 
            this.dtgIntermediario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIntermediario.Location = new System.Drawing.Point(4, 286);
            this.dtgIntermediario.Name = "dtgIntermediario";
            this.dtgIntermediario.Size = new System.Drawing.Size(94, 71);
            this.dtgIntermediario.TabIndex = 7;
            this.dtgIntermediario.Visible = false;
            // 
            // dataSetImpressao
            // 
            this.dataSetImpressao.DataSetName = "DataSetImpressao";
            this.dataSetImpressao.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioCompletoBindingSource
            // 
            this.usuarioCompletoBindingSource.DataMember = "UsuarioCompleto";
            this.usuarioCompletoBindingSource.DataSource = this.dataSetImpressao;
            // 
            // usuarioCompletoTableAdapter
            // 
            this.usuarioCompletoTableAdapter.ClearBeforeFill = true;
            // 
            // pnlCadastrar
            // 
            this.pnlCadastrar.Controls.Add(this.lblStatusUsuario);
            this.pnlCadastrar.Controls.Add(this.lblNivelAcesso);
            this.pnlCadastrar.Controls.Add(this.lblNomeUsuario);
            this.pnlCadastrar.Controls.Add(this.lblObservacaoUsuario);
            this.pnlCadastrar.Controls.Add(this.lblSenha);
            this.pnlCadastrar.Controls.Add(this.lblConfirmarSenha);
            this.pnlCadastrar.Controls.Add(this.txtObservacao);
            this.pnlCadastrar.Controls.Add(this.txtSenha);
            this.pnlCadastrar.Controls.Add(this.txtConfirmacaoSenha);
            this.pnlCadastrar.Controls.Add(this.txtLoginUsuario);
            this.pnlCadastrar.Controls.Add(this.txtNomeUsuario);
            this.pnlCadastrar.Controls.Add(this.lblLoginUsuario);
            this.pnlCadastrar.Controls.Add(this.cbStatusUsuario);
            this.pnlCadastrar.Controls.Add(this.cbNivelAcesso);
            this.pnlCadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCadastrar.Location = new System.Drawing.Point(572, 130);
            this.pnlCadastrar.Name = "pnlCadastrar";
            this.pnlCadastrar.Size = new System.Drawing.Size(538, 327);
            this.pnlCadastrar.TabIndex = 8;
            // 
            // lblStatusUsuario
            // 
            this.lblStatusUsuario.AutoSize = true;
            this.lblStatusUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusUsuario.ForeColor = System.Drawing.Color.White;
            this.lblStatusUsuario.Location = new System.Drawing.Point(305, 170);
            this.lblStatusUsuario.Name = "lblStatusUsuario";
            this.lblStatusUsuario.Size = new System.Drawing.Size(114, 18);
            this.lblStatusUsuario.TabIndex = 0;
            this.lblStatusUsuario.Text = "Status Usuario:";
            // 
            // lblNivelAcesso
            // 
            this.lblNivelAcesso.AutoSize = true;
            this.lblNivelAcesso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelAcesso.ForeColor = System.Drawing.Color.White;
            this.lblNivelAcesso.Location = new System.Drawing.Point(27, 170);
            this.lblNivelAcesso.Name = "lblNivelAcesso";
            this.lblNivelAcesso.Size = new System.Drawing.Size(124, 18);
            this.lblNivelAcesso.TabIndex = 0;
            this.lblNivelAcesso.Text = "Nivel de Acesso:";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNomeUsuario.Location = new System.Drawing.Point(27, 25);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(54, 18);
            this.lblNomeUsuario.TabIndex = 0;
            this.lblNomeUsuario.Text = "Nome:";
            // 
            // lblObservacaoUsuario
            // 
            this.lblObservacaoUsuario.AutoSize = true;
            this.lblObservacaoUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacaoUsuario.ForeColor = System.Drawing.Color.White;
            this.lblObservacaoUsuario.Location = new System.Drawing.Point(27, 221);
            this.lblObservacaoUsuario.Name = "lblObservacaoUsuario";
            this.lblObservacaoUsuario.Size = new System.Drawing.Size(97, 18);
            this.lblObservacaoUsuario.TabIndex = 0;
            this.lblObservacaoUsuario.Text = "Observação:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(27, 121);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 18);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha:";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(305, 121);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(130, 18);
            this.lblConfirmarSenha.TabIndex = 0;
            this.lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(31, 242);
            this.txtObservacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(464, 56);
            this.txtObservacao.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(31, 144);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(188, 26);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Click += new System.EventHandler(this.senha);
            // 
            // txtConfirmacaoSenha
            // 
            this.txtConfirmacaoSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacaoSenha.Location = new System.Drawing.Point(307, 144);
            this.txtConfirmacaoSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            this.txtConfirmacaoSenha.PasswordChar = '*';
            this.txtConfirmacaoSenha.Size = new System.Drawing.Size(188, 26);
            this.txtConfirmacaoSenha.TabIndex = 4;
            this.txtConfirmacaoSenha.Click += new System.EventHandler(this.senha);
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLoginUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsuario.Location = new System.Drawing.Point(31, 95);
            this.txtLoginUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(464, 26);
            this.txtLoginUsuario.TabIndex = 2;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(31, 47);
            this.txtNomeUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(464, 26);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsuario.ForeColor = System.Drawing.Color.White;
            this.lblLoginUsuario.Location = new System.Drawing.Point(27, 74);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(66, 18);
            this.lblLoginUsuario.TabIndex = 0;
            this.lblLoginUsuario.Text = "Usuario:";
            // 
            // cbStatusUsuario
            // 
            this.cbStatusUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatusUsuario.FormattingEnabled = true;
            this.cbStatusUsuario.Location = new System.Drawing.Point(307, 193);
            this.cbStatusUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStatusUsuario.Name = "cbStatusUsuario";
            this.cbStatusUsuario.Size = new System.Drawing.Size(188, 26);
            this.cbStatusUsuario.TabIndex = 6;
            // 
            // cbNivelAcesso
            // 
            this.cbNivelAcesso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivelAcesso.FormattingEnabled = true;
            this.cbNivelAcesso.Location = new System.Drawing.Point(31, 193);
            this.cbNivelAcesso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNivelAcesso.Name = "cbNivelAcesso";
            this.cbNivelAcesso.Size = new System.Drawing.Size(188, 26);
            this.cbNivelAcesso.TabIndex = 5;
            // 
            // btnDeletar
            // 
            this.btnDeletar.HeaderText = "Deletar";
            this.btnDeletar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.deletarIcon__1_;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.EditarIcon__1_;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.HeaderText = "Imprimir";
            this.btnImprimir.Image = global::Sistema_Gerenciador_de_Consultorio.Properties.Resources.imprimirIcon__1_;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ReadOnly = true;
            // 
            // dtgUsuario
            // 
            this.dtgUsuario.AllowUserToAddRows = false;
            this.dtgUsuario.AllowUserToDeleteRows = false;
            this.dtgUsuario.AllowUserToResizeColumns = false;
            this.dtgUsuario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.dtgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnImprimir,
            this.btnEditar,
            this.btnDeletar});
            this.dtgUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgUsuario.GridColor = System.Drawing.Color.Black;
            this.dtgUsuario.Location = new System.Drawing.Point(0, 231);
            this.dtgUsuario.Name = "dtgUsuario";
            this.dtgUsuario.ReadOnly = true;
            this.dtgUsuario.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgUsuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuario.ShowRowErrors = false;
            this.dtgUsuario.Size = new System.Drawing.Size(1160, 372);
            this.dtgUsuario.TabIndex = 3;
            this.dtgUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuario_CellClick);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(88)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(1160, 603);
            this.Controls.Add(this.pnlCadastrar);
            this.Controls.Add(this.dtgIntermediario);
            this.Controls.Add(this.dtgUsuario);
            this.Controls.Add(this.pnlPesquisar);
            this.Controls.Add(this.rbPesquisarUsuario);
            this.Controls.Add(this.rbCadastrarUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pnlMenuSuperior);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.Click += new System.EventHandler(this.senha);
            this.pnlMenuSuperior.ResumeLayout(false);
            this.pnlPesquisar.ResumeLayout(false);
            this.pnlPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIntermediario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetImpressao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioCompletoBindingSource)).EndInit();
            this.pnlCadastrar.ResumeLayout(false);
            this.pnlCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLImpar;
        private System.Windows.Forms.Panel pnlMenuSuperior;
        private System.Windows.Forms.RadioButton rbPesquisarUsuario;
        private System.Windows.Forms.RadioButton rbCadastrarUsuario;
        private System.Windows.Forms.Timer repetir;
        private System.Windows.Forms.Label lblUsuario;
        private DataSet.DataSetImpressao dataSetImpressao;
        private System.Windows.Forms.BindingSource usuarioCompletoBindingSource;
        private DataSet.DataSetImpressaoTableAdapters.UsuarioCompletoTableAdapter usuarioCompletoTableAdapter;
        private System.Windows.Forms.Panel pnlPesquisar;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbNomeUsuario;
        private System.Windows.Forms.RadioButton rbStatusUsuario;
        private System.Windows.Forms.ComboBox cbNivelAcessoPesquisa;
        private System.Windows.Forms.RadioButton rbLoginUsuario;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.RadioButton rbNivelAcesso;
        private System.Windows.Forms.ComboBox cbStatusUsuarioPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dtgIntermediario;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel pnlCadastrar;
        private System.Windows.Forms.Label lblStatusUsuario;
        private System.Windows.Forms.Label lblNivelAcesso;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Label lblObservacaoUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmacaoSenha;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.ComboBox cbStatusUsuario;
        private System.Windows.Forms.ComboBox cbNivelAcesso;
        private System.Windows.Forms.DataGridViewImageColumn btnDeletar;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnImprimir;
        private System.Windows.Forms.DataGridView dtgUsuario;
    }
}