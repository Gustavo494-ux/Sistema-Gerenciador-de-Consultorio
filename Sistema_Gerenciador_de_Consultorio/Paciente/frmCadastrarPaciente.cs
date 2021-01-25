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
           PacienteRegra editarPaciente = new PacienteRegra();
            EnderecoRegra editarEndereco = new EnderecoRegra();
            ContatoRegra editarContato = new ContatoRegra();
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
            PacienteRegra editarPaciente = new PacienteRegra();
            dadosTabela = editarPaciente.CodigoPaciente(Convert.ToInt32(idPaciente));
            dtgPaciente.DataSource = dadosTabela;

            if (dtgPaciente.Rows.Count > 0)
            {
                for (int i = 0; i < dtgPaciente.Rows.Count - 1; i++)
                {
                    //informações do paciente
                    idPaciente = dadosTabela.Rows[i]["idpaciente"].ToString();
                    idContato = dadosTabela.Rows[i]["idcontato"].ToString();
                    idEndereco = dadosTabela.Rows[i]["idendereco"].ToString();
                    idUsuarioConsulta = dadosTabela.Rows[i]["idusuario"].ToString();

                    txtNomePaciente.Text = dadosTabela.Rows[i]["nomepaciente"].ToString();
                    txtNomeResponsavel.Text = dadosTabela.Rows[i]["nomeresponsavel"].ToString();
                    mtxRG.Text = dadosTabela.Rows[i]["rg"].ToString();
                    mtxtCPF.Text = dadosTabela.Rows[i]["cpf"].ToString();
                    txtocupacao.Text = dadosTabela.Rows[i]["ocupacao"].ToString();
                    txtIdade.Text = dadosTabela.Rows[i]["idade"].ToString();
                    cbSexo.Text = dadosTabela.Rows[i]["sexo"].ToString();
                    dtpDataNascimento.Text = dadosTabela.Rows[i]["datanascimento"].ToString();
                    txtObservacaoPaciente.Text = dadosTabela.Rows[i]["observacaopaciente"].ToString();
                    //informações do endereco
                    txtEstado.Text = dadosTabela.Rows[i]["estado"].ToString();
                    txtCidade.Text = dadosTabela.Rows[i]["cidade"].ToString();
                    txtBairro.Text = dadosTabela.Rows[i]["bairro"].ToString();
                    txtRua.Text = dadosTabela.Rows[i]["rua"].ToString();
                    txtNumero.Text = dadosTabela.Rows[i]["numero"].ToString();
                    mtxtCEP.Text = dadosTabela.Rows[i]["cep"].ToString();
                    txtPontoDeReferencia.Text = dadosTabela.Rows[i]["pontoreferencia"].ToString();
                    txtObservacaoEndereco.Text = dadosTabela.Rows[i]["observacaoendereco"].ToString();
                    //Informações de contato
                    txtEmail.Text = dadosTabela.Rows[i]["email"].ToString();
                    mtxtTelefone1.Text = dadosTabela.Rows[i]["telefone1"].ToString();
                    mtxtTelefone1.Text = dadosTabela.Rows[i]["telefone2"].ToString();
                    mtxtTelefone3.Text = dadosTabela.Rows[i]["telefone3"].ToString();
                    txtOutro.Text = dadosTabela.Rows[i]["outro"].ToString();
                    txtObservacaoContato.Text = dadosTabela.Rows[i]["observacaocontato"].ToString();
                    //Usuario que fez o cadastro
                    loginUsuarioCadastro = dadosTabela.Rows[i]["loginusuario"].ToString();
                }
            }
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
            ContatoRegra novaVerificacaoContato = new ContatoRegra();
           confirm[0]= novaVerificacaoContato.cadastrar(idContato, idUsuarioSistema, txtEmail.Text, mtxtTelefone1.Text, mtxtTelefone2.Text, mtxtTelefone3.Text, txtOutro.Text, txtObservacaoContato.Text);

            //Insere os dados do endereco
            EnderecoRegra novaVerificacaoEndereco = new EnderecoRegra();
           confirm[1]= novaVerificacaoEndereco.Cadastrar(idEndereco, idUsuarioSistema, txtEstado.Text, txtCidade.Text, txtBairro.Text, txtRua.Text, txtNumero.Text, mtxtCEP.Text,
                txtPontoDeReferencia.Text, txtObservacaoEndereco.Text);

            //Insere os dados do Paciente 
            PacienteRegra novaVerificacaoPaciente = new PacienteRegra();
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
