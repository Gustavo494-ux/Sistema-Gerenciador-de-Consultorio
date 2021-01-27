using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegraNegocio;

namespace Sistema_Gerenciador_de_Consultorio
{
    public partial class frmCadastrarProfissional : Form
    {
        string idEndereco = "0", idContato = "0", dataCadastro, horaCadastro;
        string idUsuario, idNivel, loginUsuario, nomeNivel;
        string idProfissional;
        public frmCadastrarProfissional(string idUsuario, string idNivel, string loginUsuario, string nomeNivel)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
        }
        public frmCadastrarProfissional(string idUsuario, string idNivel, string loginUsuario, string nomeNivel, string idProfissional)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
            this.idProfissional = idProfissional;
        }
        void AutenticarPermisssoesUsuario(string idNivel)
        {
            try
            {
                PermissoesUsuarioRegra autenticar = new PermissoesUsuarioRegra();
                if (autenticar.CadastrarOuEditarProfissional(idNivel) == false)
                {
                    atualizarToolStripMenuItem.Enabled = false;
                    salvarToolStripMenuItem.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao Autenticar as permisssões do usuario(Formulario frmCadastrarProfissional, Método AutenticarPermisssoesUsuario)",
                    "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void formResponsivo()
        {
            gbDadosPessoais.Location = new Point(this.Width / 2 - (gbDadosPessoais.Width / 2), (painelExterno1.Height / 2) - (gbDadosPessoais.Height / 2));
            gbContato.Location = new Point(this.Width / 2 - (gbContato.Width / 2), (painelExterno1.Height / 2) - (gbContato.Height / 2));
            gbEndereco.Location = new Point(this.Width / 2 - (gbEndereco.Width / 2), (painelExterno1.Height / 2) - (gbEndereco.Height / 2));
        }
        void limpar()
        {
            txtNomeProfissional.Clear();
            txtEspecialidade.Clear();
            mtxtCPF.Clear();
            mtxtCROO.Clear();
            mtxRG.Clear();
            cbSexo.SelectedIndex = 0;
            dtpDataNascimento.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            txtObservacaoProfissional.Clear();

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
        void verificar()
        {

            try
            {
                ContatoRegra novaVerificacaoContato = new ContatoRegra();
                novaVerificacaoContato.Verificar(idContato, idUsuario, txtEmail.Text, mtxtTelefone1.Text, mtxtTelefone2.Text, mtxtTelefone3.Text, txtOutro.Text, txtObservacaoContato.Text);


                EnderecoRegra novaVerificacaoEndereco = new EnderecoRegra();
                novaVerificacaoEndereco.Validar(idEndereco, idUsuario, txtEstado.Text, txtCidade.Text, txtBairro.Text, txtRua.Text, txtNumero.Text, mtxtCEP.Text,
                    txtPontoDeReferencia.Text, txtObservacaoEndereco.Text);


                ProfissionalRegra novaVerificacaoProfissionaç = new ProfissionalRegra();
                novaVerificacaoProfissionaç.Verificar(idProfissional, idEndereco, idContato, idUsuario, txtNomeProfissional.Text, txtEspecialidade.Text,
                    mtxRG.Text, mtxtCPF.Text, cbSexo.Text, mtxtCROO.Text, dtpDataNascimento.Text, dataCadastro, horaCadastro, txtObservacaoProfissional.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no método verificar no formulario cadastrarProfissional, Error:  " + ex.Message + ". Caso o problema persista entre em contato com o suporte!",
                    "Erro no metodo verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CarregarProfissionalASerEditado()
        {
            try
            {
                ProfissionalRegra editarProfissional = new ProfissionalRegra();
                DataTable dadosTabela = new DataTable();

                dadosTabela = editarProfissional.RetornarDados(idProfissional);
                dtgIntermediario.DataSource = dadosTabela;

                if (Convert.ToInt32(idProfissional) > 0)
                {

                    for (int i = 0; i < dtgIntermediario.Rows.Count - 1; i++)
                    {
                        //Profissional
                        idProfissional = dtgIntermediario.Rows[i].Cells["idProfissional"].Value.ToString();
                        txtNomeProfissional.Text = dtgIntermediario.Rows[i].Cells["nomeProfissional"].Value.ToString();
                        txtEspecialidade.Text = dtgIntermediario.Rows[i].Cells["especialidade"].Value.ToString();
                        mtxRG.Text = dtgIntermediario.Rows[i].Cells["rg"].Value.ToString();
                        mtxtCPF.Text = dtgIntermediario.Rows[i].Cells["cpf"].Value.ToString();
                        cbSexo.Text = dtgIntermediario.Rows[i].Cells["sexo"].Value.ToString();
                        mtxtCROO.Text = dtgIntermediario.Rows[i].Cells["croo"].Value.ToString();
                        dtpDataNascimento.Text = dtgIntermediario.Rows[i].Cells["dataNascimento"].Value.ToString();
                        txtObservacaoProfissional.Text = dtgIntermediario.Rows[i].Cells["observacaoProfissional"].Value.ToString();

                        //Contato
                        idContato = dtgIntermediario.Rows[i].Cells["idContato"].Value.ToString();
                        txtEmail.Text = dtgIntermediario.Rows[i].Cells["email"].Value.ToString();
                        mtxtTelefone1.Text = dtgIntermediario.Rows[i].Cells["telefone1"].Value.ToString();
                        mtxtTelefone2.Text = dtgIntermediario.Rows[i].Cells["telefone2"].Value.ToString();
                        mtxtTelefone3.Text = dtgIntermediario.Rows[i].Cells["telefone3"].Value.ToString();
                        txtOutro.Text = dtgIntermediario.Rows[i].Cells["outro"].Value.ToString();
                        txtObservacaoContato.Text = dtgIntermediario.Rows[i].Cells["observacaoContato"].Value.ToString();

                        //Estado
                        idEndereco = dtgIntermediario.Rows[i].Cells["idEndereco"].Value.ToString();
                        txtEstado.Text = dtgIntermediario.Rows[i].Cells["estado"].Value.ToString();
                        txtCidade.Text = dtgIntermediario.Rows[i].Cells["cidade"].Value.ToString();
                        txtBairro.Text = dtgIntermediario.Rows[i].Cells["bairro"].Value.ToString();
                        txtRua.Text = dtgIntermediario.Rows[i].Cells["rua"].Value.ToString();
                        txtNumero.Text = dtgIntermediario.Rows[i].Cells["numero"].Value.ToString();
                        mtxtCEP.Text = dtgIntermediario.Rows[i].Cells["cep"].Value.ToString();
                        txtPontoDeReferencia.Text = dtgIntermediario.Rows[i].Cells["pontoReferencia"].Value.ToString();
                        txtObservacaoEndereco.Text = dtgIntermediario.Rows[i].Cells["observacaoEndereco"].Value.ToString();
                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa/Atualização do profissional(Formulario frmCadastrarProfissional, Método EditarProfissional)", "Erro de Pesquisa/Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void cadastrar()
        {
            bool[] confirm = new bool[3];
            dataCadastro = DateTime.Now.ToShortTimeString();
            horaCadastro = DateTime.Now.ToLongTimeString();
            //Insere os dados do Contato
            ContatoRegra novaVerificacaoContato = new ContatoRegra();
            confirm[0] = novaVerificacaoContato.cadastrar(idContato, idUsuario, txtEmail.Text, mtxtTelefone1.Text, mtxtTelefone2.Text, mtxtTelefone3.Text, txtOutro.Text, txtObservacaoContato.Text);

            //Insere os dados do endereco
            EnderecoRegra novaVerificacaoEndereco = new EnderecoRegra();
            confirm[1] = novaVerificacaoEndereco.Cadastrar(idEndereco, idUsuario, txtEstado.Text, txtCidade.Text, txtBairro.Text, txtRua.Text, txtNumero.Text, mtxtCEP.Text,
                txtPontoDeReferencia.Text, txtObservacaoEndereco.Text);

            //Insere os dados do profissional
            idProfissional = "0";
            ProfissionalRegra novoProfissional = new ProfissionalRegra();
            confirm[2] = novoProfissional.Cadastrar(idProfissional, idEndereco, idContato, idUsuario, txtNomeProfissional.Text, txtEspecialidade.Text, mtxRG.Text, mtxtCPF.Text,
            cbSexo.Text, mtxtCROO.Text, dtpDataNascimento.Text, dataCadastro, horaCadastro, txtObservacaoProfissional.Text);

            if (confirm[0] == true && confirm[1] == true && confirm[2] == true)
            {
                DialogResult confirmar = MessageBox.Show("Profissional cadastrado com sucesso!\nDeseja realizar outro cadastro?", "Cadastro Realizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirmar == DialogResult.No)
                {
                    frmPrincipal voltar = new frmPrincipal(idUsuario, idNivel, loginUsuario, nomeNivel);
                    this.Dispose();
                }
                limpar();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o profissional ou alguma das informações está incorreta", "Erro ou informações incorretas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbDadosPessoais_CheckedChanged(object sender, EventArgs e)
        {
            gbDadosPessoais.Visible = true;
            gbContato.Visible = false;
            gbEndereco.Visible = false;
        }

        private void rbContato_CheckedChanged(object sender, EventArgs e)
        {
            gbDadosPessoais.Visible = false;
            gbContato.Visible = true;
            gbEndereco.Visible = false;
        }

        private void rbEndereco_CheckedChanged(object sender, EventArgs e)
        {
            gbDadosPessoais.Visible = false;
            gbContato.Visible = false;
            gbEndereco.Visible = true;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idProfissional == string.Empty && idNivel != "2")
            {
                MessageBox.Show("É necessario o código indentificador de um profissional para realizar a consulta,Efetue a Autenticação de Profissional", "Infornações Incompletas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cadastrar();
            }
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dtgIntermediario.Rows[0].Cells["idProfissional"].Value.ToString()) > 0)
            {
                if (Convert.ToInt32(idProfissional) > 0 && Convert.ToInt32(idEndereco) > 0 && Convert.ToInt32(idContato) > 0)
                {
                    ProfissionalRegra editarProfissional = new ProfissionalRegra();
                    ContatoRegra editarContato = new ContatoRegra();
                    EnderecoRegra editarEndereco = new EnderecoRegra();

                    bool profissional = editarProfissional.Atualizar(idProfissional, txtNomeProfissional.Text, txtEspecialidade.Text, mtxRG.Text, mtxtCPF.Text, cbSexo.Text, mtxtCROO.Text, dtpDataNascimento.Text, txtObservacaoProfissional.Text);
                    bool endereco = editarEndereco.Atualizar(Convert.ToInt32(idEndereco), txtEstado.Text, txtCidade.Text, txtBairro.Text, txtRua.Text, txtNumero.Text, mtxtCEP.Text, txtPontoDeReferencia.Text, txtObservacaoEndereco.Text);
                    bool contato = editarContato.Atualizar(Convert.ToInt32(idContato), txtEmail.Text, mtxtTelefone1.Text, mtxtTelefone2.Text, mtxtTelefone3.Text, txtOutro.Text, txtObservacaoContato.Text);

                    if (profissional == true && endereco == true && contato == true)
                    {
                        MessageBox.Show("Dados atualizados com sucesso!", "Dados Atualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Algumas informações estão incorretas ou inválidas", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("O código indentificador do profissional, do endereço ou do seu contato é inválido", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void frmCadastrarProfissional_Load(object sender, EventArgs e)
        {
            rbDadosPessoais.Checked = true;
            gbDadosPessoais.Visible = true;
            formResponsivo();
            limpar();
            salvarToolStripMenuItem.Visible = true;
            atualizarToolStripMenuItem.Visible = false;
            if (Convert.ToInt32(idProfissional) > 0)
            {
                atualizarToolStripMenuItem.Visible = true;
                salvarToolStripMenuItem.Visible = false;
                CarregarProfissionalASerEditado();
            }
            lblLoginUsuario.Text = "Usuario: " + loginUsuario + "\nNivel: " + nomeNivel;
            AutenticarPermisssoesUsuario(idNivel);
        }
        private void atualizar_Tick(object sender, EventArgs e)
        {
            dataCadastro = DateTime.Now.ToShortDateString();
            dataCadastro = DateTime.Now.ToShortDateString();
            horaCadastro = DateTime.Now.ToLongTimeString();
        }

    }
}
