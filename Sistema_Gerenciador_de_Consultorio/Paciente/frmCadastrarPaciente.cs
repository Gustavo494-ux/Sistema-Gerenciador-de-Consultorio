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

        private void msMenuSuperior_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

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
        public frmCadastrarPaciente(string idUsuario, string idNivel, string loginUsuario, string nomeNivel,string idPacienteEditar)

        {
            InitializeComponent();
            this.idUsuarioSistema = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
            this.idPaciente = idPacienteEditar;
        }

        string estado, cidade, bairro, rua, numero, cep, pontoReferencia, observacaoEndereco;

        void PesquisareCompletar()
        {

            DataTable dadosTabela = new DataTable();
            PacienteRegra editarPaciente = new PacienteRegra();
            dadosTabela = editarPaciente.CodigoPaciente(Convert.ToInt32(idPaciente));

            if (dadosTabela.Rows.Count > 0)
            {
                    //informações do paciente
                    idPaciente = dadosTabela.Rows[0]["idpaciente"].ToString();
                    idContato = dadosTabela.Rows[0]["idcontato"].ToString();
                    idEndereco = dadosTabela.Rows[0]["idendereco"].ToString();
                    idUsuarioConsulta = dadosTabela.Rows[0]["idusuario"].ToString();

                    txtNomePaciente.Text = dadosTabela.Rows[0]["nomepaciente"].ToString();
                    txtNomeResponsavel.Text = dadosTabela.Rows[0]["nomeresponsavel"].ToString();
                    mtxRG.Text = dadosTabela.Rows[0]["rg"].ToString();
                    mtxtCPF.Text = dadosTabela.Rows[0]["cpf"].ToString();
                    txtocupacao.Text = dadosTabela.Rows[0]["ocupacao"].ToString();
                    txtIdade.Text = dadosTabela.Rows[0]["idade"].ToString();
                    cbSexo.Text = dadosTabela.Rows[0]["sexo"].ToString();
                    dtpDataNascimento.Text = dadosTabela.Rows[0]["datanascimento"].ToString();
                    txtObservacaoPaciente.Text = dadosTabela.Rows[0]["observacaopaciente"].ToString();
                    //informações do endereco
                    txtEstado.Text = dadosTabela.Rows[0]["estado"].ToString();
                    txtCidade.Text = dadosTabela.Rows[0]["cidade"].ToString();
                    txtBairro.Text = dadosTabela.Rows[0]["bairro"].ToString();
                    txtRua.Text = dadosTabela.Rows[0]["rua"].ToString();
                    txtNumero.Text = dadosTabela.Rows[0]["numero"].ToString();
                    mtxtCEP.Text = dadosTabela.Rows[0]["cep"].ToString();
                    txtPontoDeReferencia.Text = dadosTabela.Rows[0]["pontoreferencia"].ToString();
                    txtObservacaoEndereco.Text = dadosTabela.Rows[0]["observacaoendereco"].ToString();
                    //Informações de contato
                    txtEmail.Text = dadosTabela.Rows[0]["email"].ToString();
                    mtxtTelefone1.Text = dadosTabela.Rows[0]["telefone1"].ToString();
                    mtxtTelefone1.Text = dadosTabela.Rows[0]["telefone2"].ToString();
                    mtxtTelefone3.Text = dadosTabela.Rows[0]["telefone3"].ToString();
                    txtOutro.Text = dadosTabela.Rows[0]["outro"].ToString();
                    txtObservacaoContato.Text = dadosTabela.Rows[0]["observacaocontato"].ToString();
                    //Usuario que fez o cadastro
                    loginUsuarioCadastro = dadosTabela.Rows[0]["loginusuario"].ToString();
            }
        }
        void formResponsivo()
        {

            //gbDadosPessoais.Location = new Point(this.Width / 2 - (gbDadosPessoais.Width / 2), (painelExterno1.Height / 2) - (gbDadosPessoais.Height / 2));
            //gbContato.Location = new Point(this.Width / 2 - (gbContato.Width / 2), (painelExterno1.Height / 2) - (gbContato.Height / 2));
            //gbEndereco.Location = new Point(this.Width / 2 - (gbEndereco.Width / 2), (painelExterno1.Height / 2) - (gbEndereco.Height / 2));

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
            salvarMsMenuSuperior.Visible = true;
            atualizarMsMenuSuperior.Visible = false;
            formResponsivo();
            limpar();
            rbDadosPessoais.Checked = true;
            gbDadosPessoais.Visible = true;
            if (Convert.ToInt32(idPaciente) >0)
            {
                atualizarMsMenuSuperior.Visible = true;
                salvarMsMenuSuperior.Visible = false;
                PesquisareCompletar();
            }
        }
        private void atualizar_Tick(object sender, EventArgs e)
        {
             formResponsivo();
       
        }
        private void salvarMsMenuSuperior_Click(object sender, EventArgs e)
        {
            cadastrar();
        }
        private void atualizarMsMenuSuperior_Click(object sender, EventArgs e)
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
        private void limparMsMenuSuperior_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void voltarMsMenuSuperior_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
