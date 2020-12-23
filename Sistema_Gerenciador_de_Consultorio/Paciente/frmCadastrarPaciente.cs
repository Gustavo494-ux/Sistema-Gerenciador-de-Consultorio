using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using RegraNegocio;

namespace Sistema_Gerenciador_de_Consultorio
{
    public partial class frmCadastrarPaciente : Form
    {
      

        string idUsuarioSistema, idNivel, loginUsuario, nomeNivel, loginUsuarioCadastro;

        string idPaciente="0",idContato,idEndereco,idUsuarioConsulta,nomePaciente,NomeResponsavel,
        rg,cpf,ocupacao,idade,sexo,dataNascimento,observacaoPaciente;     

        string email, telefone1, telefone2, telefone3, outro, observacaoContato;

        private void rbEndereco_CheckedChanged(object sender, EventArgs e)
        {
            gbDadosPessoais.Visible = false;
            gbContato.Visible = false;
            gbEndereco.Visible = true;
        }

        private void rbContato_CheckedChanged(object sender, EventArgs e)
        {
            gbDadosPessoais.Visible = false;
            gbContato.Visible = true;
            gbEndereco.Visible = false;
        }

        private void rbDadosPessoais_CheckedChanged(object sender, EventArgs e)
        {
            gbDadosPessoais.Visible = true;
            gbContato.Visible = false;
            gbEndereco.Visible = false;
        }

        ConstrutorPaciente construtorLocal;
        public frmCadastrarPaciente(string idUsuario, string idNivel, string loginUsuario, string nomeNivel)
        {
            InitializeComponent();
            this.idUsuarioSistema = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
        }
        public frmCadastrarPaciente(ConstrutorPaciente ConstrutorPaciente)

        {
            InitializeComponent();
            this.construtorLocal = ConstrutorPaciente;
            this.idUsuarioSistema = ConstrutorPaciente.IdUsuario;
            this.idNivel = ConstrutorPaciente.IdNivel;
            this.loginUsuario = ConstrutorPaciente.LoginUsuario;
            this.nomeNivel = ConstrutorPaciente.NomeNivel;

            this.idPaciente = ConstrutorPaciente.IdPaciente;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            EditarPacienteRegra editarPaciente = new EditarPacienteRegra();
            EditarEnderecoRegra editarEndereco = new EditarEnderecoRegra();
            EditarContatoRegra editarContato = new EditarContatoRegra();
            if (Convert.ToInt32(idPaciente) > 0)
            {
                if (Convert.ToInt32(idEndereco) > 0)
                {
                    if (Convert.ToInt32(idContato) > 0)
                    {

                        bool um = editarPaciente.Atualizar(Convert.ToInt32(idPaciente), txtNomePaciente.Text, txtNomeResponsavel.Text, mtxRG.Text, mtxtCPF.Text, txtocupacao.Text,
                         txtIdade.Text, cbSexo.Text, dtpDataNascimento.Text, txtObservacaoPaciente.Text);

                        bool dois = editarContato.Atualizar(Convert.ToInt32(idContato), txtEmail.Text, mtxtTelefone1.Text, mtxtTelefone2.Text, mtxtTelefone3.Text, txtOutro.Text, txtObservacaoContato.Text);

                        bool tres = editarEndereco.Atualizar(Convert.ToInt32(idEndereco), txtEstado.Text, txtCidade.Text, txtBairro.Text, txtRua.Text, txtNumero.Text, mtxtCEP.Text.Replace("-", "").Replace(".", ""),
                        txtPontoDeReferencia.Text, txtObservacaoEndereco.Text);

                        if (um == true && dois == true && tres == true)
                        {
                           MessageBox.Show("Dados Atualizados com sucesso!", "Atualização Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Código Indentificador do Contato inválido", "Dados Inválidos");
                    }
                }
                else
                {
                    MessageBox.Show("Código Indentificador do Endereço inválido", "Dados Inválidos");
                }
            }
            else
            {
                MessageBox.Show("Código Indentificador do Paciente inválido", "Dados Inválidos");
            }
        }

        string estado, cidade, bairro, rua, numero, cep, pontoReferencia, observacaoEndereco;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cadastrar();
        }
        void PesquisareCompletar()
        {

            DataTable dadosTabela = new DataTable();
            EditarPacienteRegra editarPaciente = new EditarPacienteRegra();
            dadosTabela = editarPaciente.RetornarDados(idPaciente);
            dtgPaciente.DataSource = dadosTabela;

            if (dtgPaciente.Rows.Count > 0)
            {
                for (int i = 0; i < dtgPaciente.Rows.Count - 1; i++)
                {
                    // Desenvolver algoritimos para efetuar a atualização de dados do paciente junto com o endereco e contato
                    //informações do paciente
                    idPaciente = dtgPaciente.Rows[i].Cells["idpaciente"].Value.ToString();
                    idContato = dtgPaciente.Rows[i].Cells["idcontato"].Value.ToString();
                    idEndereco = dtgPaciente.Rows[i].Cells["idendereco"].Value.ToString();
                    idUsuarioConsulta = dtgPaciente.Rows[i].Cells["idusuario"].Value.ToString();
                    nomePaciente = dtgPaciente.Rows[i].Cells["nomepaciente"].Value.ToString();
                    NomeResponsavel = dtgPaciente.Rows[i].Cells["nomeresponsavel"].Value.ToString();
                    rg = dtgPaciente.Rows[i].Cells["rg"].Value.ToString();
                    cpf = dtgPaciente.Rows[i].Cells["cpf"].Value.ToString();
                    ocupacao = dtgPaciente.Rows[i].Cells["ocupacao"].Value.ToString();
                    idade = dtgPaciente.Rows[i].Cells["idade"].Value.ToString();
                    sexo = dtgPaciente.Rows[i].Cells["sexo"].Value.ToString();
                    dataNascimento = dtgPaciente.Rows[i].Cells["datanascimento"].Value.ToString();
                    observacaoPaciente = dtgPaciente.Rows[i].Cells["observacaopaciente"].Value.ToString();
                    //informações do endereco
                    estado = dtgPaciente.Rows[i].Cells["estado"].Value.ToString();
                    cidade = dtgPaciente.Rows[i].Cells["cidade"].Value.ToString();
                    bairro = dtgPaciente.Rows[i].Cells["bairro"].Value.ToString();
                    rua = dtgPaciente.Rows[i].Cells["rua"].Value.ToString();
                    numero = dtgPaciente.Rows[i].Cells["numero"].Value.ToString();
                    cep = dtgPaciente.Rows[i].Cells["cep"].Value.ToString();
                    pontoReferencia = dtgPaciente.Rows[i].Cells["pontoreferencia"].Value.ToString();
                    observacaoEndereco = dtgPaciente.Rows[i].Cells["observacaoendereco"].Value.ToString();
                    //Informações de contato
                    email = dtgPaciente.Rows[i].Cells["email"].Value.ToString();
                    telefone1 = dtgPaciente.Rows[i].Cells["telefone1"].Value.ToString();
                    telefone2 = dtgPaciente.Rows[i].Cells["telefone2"].Value.ToString();
                    telefone3 = dtgPaciente.Rows[i].Cells["telefone3"].Value.ToString();
                    outro = dtgPaciente.Rows[i].Cells["outro"].Value.ToString();
                    observacaoContato = dtgPaciente.Rows[i].Cells["observacaocontato"].Value.ToString();
                    //Usuario que fez o cadastro
                    loginUsuarioCadastro = dtgPaciente.Rows[i].Cells["loginusuario"].Value.ToString();
                }

            }
            txtNomePaciente.Text = nomePaciente;
            txtNomeResponsavel.Text = NomeResponsavel;
            txtocupacao.Text = ocupacao;
            mtxRG.Text = rg;
            mtxtCPF.Text = cpf;
            txtIdade.Text = idade;
            cbSexo.Text = sexo;
            dtpDataNascimento.Text = dataNascimento;
            txtObservacaoPaciente.Text = observacaoPaciente;

            txtEstado.Text = estado;
            txtCidade.Text = cidade;
            txtBairro.Text = bairro;
            txtRua.Text = rua;
            txtNumero.Text = numero;
            mtxtCEP.Text = cep;
            txtPontoDeReferencia.Text = pontoReferencia;
            txtObservacaoEndereco.Text = observacaoEndereco;

            txtEmail.Text = email;
            mtxtTelefone1.Text = telefone1;
            mtxtTelefone2.Text = telefone2;
            mtxtTelefone3.Text = telefone3;
            txtOutro.Text = outro;
            txtObservacaoContato.Text = observacaoContato;
        }
        void estilizar()
        {
            #region PainelSuperior
            //posicionamento do lado esquerdo superior
            pnlMenuSuperior.Location = new Point(0, 0);

            //define a largura  como a largura da tela em que ta sendo executada 
            pnlMenuSuperior.Width = this.Width;
            #endregion

        }
        void formResponsivo()
        {

            gbDadosPessoais.Location = new Point(this.Width / 2 - (gbDadosPessoais.Width / 2), (painelExterno1.Height / 2) - (gbDadosPessoais.Height / 2));
            gbContato.Location = new Point(this.Width / 2 - (gbContato.Width / 2), (painelExterno1.Height / 2) - (gbContato.Height / 2));
            gbEndereco.Location = new Point(this.Width / 2 - (gbEndereco.Width / 2), (painelExterno1.Height / 2) - (gbEndereco.Height / 2));

        }
        void limpar()
        {
            txtNomePaciente.Clear();
            txtNomeResponsavel.Clear();
            mtxtCPF.Clear();
            txtIdade.Clear();
            mtxRG.Clear();
            cbSexo.SelectedIndex = 0;
            dtpDataNascimento.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            txtObservacaoPaciente.Clear();
            txtocupacao.Clear();

            txtEstado.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtRua.Clear();
            mtxtCEP.Clear();
            txtNumero.Clear();
            txtPontoDeReferencia.Clear();
            txtObservacaoEndereco.Clear();

            txtEmail.Clear();
            mtxtTelefone1.Clear();
            mtxtTelefone2.Clear();
            mtxtTelefone3.Clear();
            txtOutro.Clear();
            txtPontoDeReferencia.Clear();
            txtObservacaoContato.Clear();
        }
        void cadastrar()
        {
            bool[] confirm = new bool[6];
            string idEndereco = "0", idContato = "0", dataCadastro = DateTime.Now.ToShortDateString(), horaCadastro = DateTime.Now.ToLongTimeString();
            //Insere os dados do Contato
            ContatoRegraNegocio novaVerificacaoContato = new ContatoRegraNegocio();
           confirm[0]= novaVerificacaoContato.cadastrar(idContato, idUsuarioSistema, txtEmail.Text, mtxtTelefone1.Text, mtxtTelefone2.Text, mtxtTelefone3.Text, txtOutro.Text, txtObservacaoContato.Text);

            //Insere os dados do endereco
            EnderecoRegraNegocio novaVerificacaoEndereco = new EnderecoRegraNegocio();
           confirm[1]= novaVerificacaoEndereco.Cadastrar(idEndereco, idUsuarioSistema, txtEstado.Text, txtCidade.Text, txtBairro.Text, txtRua.Text, txtNumero.Text, mtxtCEP.Text,
                txtPontoDeReferencia.Text, txtObservacaoEndereco.Text);

            //Insere os dados do Paciente 
            RegraNegocio.CadastrarPacienteRegra novaVerificacaoPaciente = new RegraNegocio.CadastrarPacienteRegra();
            confirm[2]=novaVerificacaoPaciente.Cadastrar(idPaciente, idContato, idEndereco, idUsuarioSistema, txtNomePaciente.Text, txtNomeResponsavel.Text, mtxRG.Text, mtxtCPF.Text, txtocupacao.Text,
                txtIdade.Text, cbSexo.Text, dtpDataNascimento.Text, dataCadastro, horaCadastro, txtObservacaoPaciente.Text);

            if (confirm[0]==true&& confirm[1] == true && confirm[2] == true)
            {
                DialogResult confirma= MessageBox.Show("Paciente cadastrado com sucesso!\nDeseja realizar outro cadastro?", "Cadastro Realizado",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (confirma == DialogResult.No)
                {
                    this.Dispose();
                } 
                else
                {
                    limpar();
                }
            }
        }
    
        private void frmCadastrarPaciente_Load(object sender, EventArgs e)
        {

            lblNomeUsuario.Text = "Usuario: " + loginUsuario + "\nNivel: " + nomeNivel;
            btnSalvar.Visible = true;
            btnAlterar.Visible = false;
            formResponsivo();
            estilizar();
            limpar();
            rbDadosPessoais.Checked = true;
            gbDadosPessoais.Visible = true;
            if (Convert.ToInt32(idPaciente) >0)
            {
                btnAlterar.Visible = true;
                btnSalvar.Visible = false;
                PesquisareCompletar();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //frmPrincipal voltar = new frmPrincipal(idUsuarioSistema, idNivel, loginUsuario, nomeNivel);
            //voltar.Show();
            this.Dispose();
        }
        private void atualizar_Tick(object sender, EventArgs e)
        {
             formResponsivo();
       
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void btnVerificarInformacoes_Click(object sender, EventArgs e)
        {

        }


    }
}
