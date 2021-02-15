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
using System.Threading;
namespace Sistema_Gerenciador_de_Consultorio
{
    public partial class frmUsuario : Form
    {
        string idUsuario, idNivel, loginUsuario, nomeNivel;
        string idUsuarioEditar;
        public frmUsuario(string idUsuario, string idNivel, string loginUsuario, string nomeNivel)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
        }
        void centralizar()
        {
            pnlCadastrar.Location = new Point(this.Width / 2 - (pnlCadastrar.Width / 2), this.Height / 2 - (pnlCadastrar.Height / 2));
            pnlPesquisar.Location = new Point(this.Width / 2 - (pnlPesquisar.Width / 2), 50);

        }
        void CarregarCbNIvel()
        {
            DataTable dadosTabelaForm;

            LocalizarNivelRegra pesquisarNivel = new LocalizarNivelRegra();
            dadosTabelaForm = pesquisarNivel.TodosNiveis();

            cbNivelAcesso.DisplayMember = "nomeNivel";
            cbNivelAcesso.DataSource = dadosTabelaForm;
            cbNivelAcesso.Text = "Selecionar";

            cbNivelAcessoPesquisa.DisplayMember = "nomeNivel";
            cbNivelAcessoPesquisa.DataSource = dadosTabelaForm;
            cbNivelAcessoPesquisa.Text = "Selecionar";
        }
        void permissoes()
        {
            PermissoesUsuarioRegra autenticar = new PermissoesUsuarioRegra();
            //testa se o usuario que logou tem permissão para o controle total, se tiver nenhum código zerá executado. mas se não tiver alguns componentes seram desativados
            if (autenticar.ControleTotalUsuario(idNivel) == false)
            {
                cbNivelAcesso.Enabled = false;
                cbStatusUsuario.Enabled = false;
                txtObservacao.Enabled = false;
                txtNomeUsuario.Enabled = false;
                //pnlCadastrar.Visible = false;
                //pnlPesquisar.Visible = true; 
            }
        }
        void CarregarUsuario()
        {
            DataTable dadosTabelaForm;
            UsuarioRegra pesquisarUsuario = new UsuarioRegra();
            dadosTabelaForm = pesquisarUsuario.Todos();

            CarregarDTG(dadosTabelaForm);
        }
        void CarregarStatus()
        {
            DataTable dadosTabelaForm;
            LocalizarStatusUsuarioRegra pesquisarStatusUsuario = new LocalizarStatusUsuarioRegra();
            dadosTabelaForm = pesquisarStatusUsuario.TodosStatus();
            cbStatusUsuario.DisplayMember = "nomeStatus";
            cbStatusUsuario.DataSource = dadosTabelaForm;
            cbStatusUsuario.Text = "Selecionar";

            cbStatusUsuarioPesquisa.DisplayMember = "nomeStatus";
            cbStatusUsuarioPesquisa.DataSource = dadosTabelaForm;
            cbStatusUsuarioPesquisa.Text = "Selecionar";
        }
        void salvar()
        {
            UsuarioRegra novoUsuario = new UsuarioRegra();
            if (novoUsuario.Cadastrar(Convert.ToString(cbNivelAcesso.SelectedIndex + 1), txtNomeUsuario.Text, txtLoginUsuario.Text, txtSenha.Text, txtConfirmacaoSenha.Text, txtObservacao.Text, cbStatusUsuario.Text) == true)
            {
                DialogResult confirm = MessageBox.Show("Usuario Cadastrado com sucesso!\nDeseja retornar Formulário anterior?", "Cadastro Realizado!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirm == DialogResult.Yes)
                {
                    this.Dispose();
                }
                else
                {
                    CarregarUsuario();
                    LimparCadastro();
                }
            }
            else
            {
                MessageBox.Show("Usuario não foi cadastrado pois nem todas as informações são validas", "Dados Inálidos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        void CarregarDTG(DataTable dados)
        {
            try
            {
                if (dados.Rows.Count > 0)
                {
                    dtgUsuario.DataSource = dados;
                    //Código
                    dtgUsuario.Columns["Código"].Width = 65;//Largura da coluna
                    dtgUsuario.Columns["Código"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//Linhas      

                    //Nome
                    dtgUsuario.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//Preenche o restante do espaço.

                    //Login
                    dtgUsuario.Columns["Login"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    //Nível de Acesso 
                    dtgUsuario.Columns["Nível de Acesso"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtgUsuario.Columns["Nível de Acesso"].HeaderText = "Nível de A.";

                    //Status
                    dtgUsuario.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    //Data Cadastro
                    dtgUsuario.Columns["Data Cadastro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtgUsuario.Columns["Data Cadastro"].HeaderText = "Data C.";
                    //Hora Cadastro
                    dtgUsuario.Columns["Hora Cadastro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtgUsuario.Columns["Hora Cadastro"].HeaderText = "Hora C.";
                    dtgUsuario.Columns["Hora Cadastro"].Visible = false;
                    //Observação
                    dtgUsuario.Columns["Observação"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dtgUsuario.Columns["Observação"].Visible = false;

                    dtgUsuario.Columns["btnImprimir"].DisplayIndex = dtgUsuario.Columns.Count - 1;//Posição dentro do dtg
                    dtgUsuario.Columns["btnEditar"].DisplayIndex = dtgUsuario.Columns.Count - 1;//Posição dentro do dtg
                    dtgUsuario.Columns["btnDeletar"].DisplayIndex = dtgUsuario.Columns.Count - 1;//Posição dentro do dtg
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Registros não encontrados,o registro que está sendo consultado não existe ou foi deletado\nDeseja voltar formulario anterior", "Dados não encontrados ou deletados", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resultado == DialogResult.Yes)
                    {
                        this.Dispose();
                    }
                    else
                    {
                        CarregarUsuario();
                    }
                }
                int linhas = dtgUsuario.Rows.Count;
                for (int i = 0; i < linhas; i++)
                {
                    dtgUsuario.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelos usuarios do sistema(Formulario frmUsuario, Método CarregarDTG)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dtgUsuario.AutoResizeColumns();
        }
        void LimparCadastro()
        {
            txtNomeUsuario.Clear();
            txtLoginUsuario.Clear();
            txtSenha.Clear();
            txtConfirmacaoSenha.Clear();
            txtObservacao.Clear();
            cbNivelAcesso.Text = "Selecionar";
            cbStatusUsuario.Text = "Selecionar";

            idUsuarioEditar = "0";
        }
        void estilo()
        {

            #region Color
            //Colorir linhas do dtg
            int linhas = dtgUsuario.Rows.Count;
            for (int i = 0; i < linhas; i++)
            {
                dtgUsuario.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                i++;
            }

            #endregion
        }
        void pesquisar()
        {
            DataTable dadosTabelaForm;
            UsuarioRegra pesquisarUsuario = new UsuarioRegra();
            if (rbTodos.Checked == true)
            {
                CarregarUsuario();
            }
            if (rbNivelAcesso.Checked == true)
            {
                dadosTabelaForm = pesquisarUsuario.Nivel(cbNivelAcessoPesquisa.Text);
                CarregarDTG(dadosTabelaForm);
            }
            if (rbLoginUsuario.Checked == true)
            {
                dadosTabelaForm = pesquisarUsuario.Login(txtPesquisar.Text);
                CarregarDTG(dadosTabelaForm);
            }
            if (rbNomeUsuario.Checked == true)
            {
                dadosTabelaForm = pesquisarUsuario.Nome(txtPesquisar.Text);
                CarregarDTG(dadosTabelaForm);
            }
            if (rbStatusUsuario.Checked == true)
            {
                dadosTabelaForm = pesquisarUsuario.Status(cbStatusUsuarioPesquisa.Text);
                CarregarDTG(dadosTabelaForm);
            }

        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CarregarCbNIvel();
            CarregarStatus();
            CarregarUsuario();
            LimparCadastro();
            cbNivelAcessoPesquisa.Text = "Selecionar";
            cbStatusUsuarioPesquisa.Text = "Selecionar";
            lblUsuario.Text = "Usuário: " + loginUsuario + "\n Nivel: " + nomeNivel;
            rbTodos.Checked = true;
            txtPesquisar.Visible = true;
            estilo();
            permissoes();
            dtgUsuario.AutoResizeColumns();
            pnlPesquisar.Visible = true;
            rbPesquisarUsuario.Checked = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuarioRegra novoUsuario = new UsuarioRegra();
            novoUsuario.Cadastrar(cbNivelAcesso.ValueMember, txtNomeUsuario.Text, txtLoginUsuario.Text, txtSenha.Text, txtConfirmacaoSenha.Text, txtObservacao.Text, cbStatusUsuario.Text);
        }
        private void cbNivelAcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dadosTabelaForm;
            LocalizarNivelRegra localizarNivel = new LocalizarNivelRegra();
            dadosTabelaForm = localizarNivel.retornaridNivel(cbNivelAcesso.Text);
            // cbIntermediario.DisplayMember = "idNIvelAcesso";
            //cbIntermediario.DataSource = dadosTabelaForm; ;
        }
        private void rbCadastrarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            pnlPesquisar.Visible = false;
            dtgUsuario.Visible = false;
            pnlCadastrar.Visible = true;
        }
        private void rbPesquisarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            cbNivelAcessoPesquisa.Text = "Selecionar";
            cbStatusUsuarioPesquisa.Text = "Selecionar";
            pnlPesquisar.Visible = true;
            dtgUsuario.Visible = true;
            pnlCadastrar.Visible = false;
        }
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {

            salvar();
        }
        private void filtros(object sender, EventArgs e)
        {
            if (rbNivelAcesso.Checked == true)
            {
                cbNivelAcessoPesquisa.Visible = true;
                cbStatusUsuarioPesquisa.Visible = false;
                txtPesquisar.Visible = false;
                cbNivelAcessoPesquisa.Focus();
            }
            if (rbStatusUsuario.Checked == true)
            {
                cbNivelAcessoPesquisa.Visible = false;
                cbStatusUsuarioPesquisa.Visible = true;
                txtPesquisar.Visible = false;
                cbStatusUsuarioPesquisa.Focus();
            }
            if (rbLoginUsuario.Checked == true)
            {
                cbNivelAcessoPesquisa.Visible = false;
                cbStatusUsuarioPesquisa.Visible = false;
                txtPesquisar.Visible = true;
                txtPesquisar.Focus();
            }
            if (rbNomeUsuario.Checked == true)
            {
                cbNivelAcessoPesquisa.Visible = false;
                cbStatusUsuarioPesquisa.Visible = false;
                txtPesquisar.Visible = true;
                txtPesquisar.Focus();
            }
            if (rbTodos.Checked == true)
            {

                cbNivelAcessoPesquisa.Visible = false;
                cbStatusUsuarioPesquisa.Visible = false;
                txtPesquisar.Visible = true;
                CarregarUsuario();
            }
        }
        private void limparTxtPesquisar(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
        }
        private void btnLImpar_Click(object sender, EventArgs e)
        {
            LimparCadastro();
        }
        void PassarUsuarioParaEdicao(string idUsuario)
        {
            try
            {
                DataTable dadosform = new DataTable();
                UsuarioRegra editarUsuario = new UsuarioRegra();

                dadosform = editarUsuario.RetornarDados(idUsuario);
                dtgIntermediario.DataSource = null;
                dtgIntermediario.DataSource = dadosform;
                salvarToolStripMenuItem.Visible = false;
                atualizarToolStripMenuItem.Visible = true;
                for (int i = 0; i < dadosform.Rows.Count; i++)
                {
                    idUsuarioEditar = dtgIntermediario.Rows[i].Cells["idusuario"].Value.ToString();
                    txtNomeUsuario.Text = dtgIntermediario.Rows[i].Cells["nomeusuario"].Value.ToString();
                    txtLoginUsuario.Text = dtgIntermediario.Rows[i].Cells["loginUsuario"].Value.ToString();
                    txtSenha.Text = dtgIntermediario.Rows[i].Cells["senhausuario"].Value.ToString();
                    txtConfirmacaoSenha.Text = dtgIntermediario.Rows[i].Cells["senhausuario"].Value.ToString();
                    cbNivelAcesso.Text = dtgIntermediario.Rows[i].Cells["nomenivel"].Value.ToString();
                    cbStatusUsuario.Text = dtgIntermediario.Rows[i].Cells["statususuario"].Value.ToString();
                    txtObservacao.Text = dtgIntermediario.Rows[i].Cells["observacaousuario"].Value.ToString();
                }
                rbPesquisarUsuario.Checked = false;
                rbCadastrarUsuario.Checked = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao passar os dados do usuario para os campos de atualizaçãao(Formulario frmUsuario, MétodoPassarUsuarioParaEdicao)",
                    "Erro de transferência", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtgUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PermissoesUsuarioRegra autenticarEdicao = new PermissoesUsuarioRegra();
                ImpressaoUsuarioRegra pesquisar = new ImpressaoUsuarioRegra();
                string acao = dtgUsuario.Columns[e.ColumnIndex].Name;
                switch (acao)
                {
                    case "btnEditar":
                        if (autenticarEdicao.ControleTotalUsuario(idNivel) == true)
                        {
                            PassarUsuarioParaEdicao(dtgUsuario.Rows[e.RowIndex].Cells["Código"].Value.ToString());
                        }
                        else
                        {
                            if (autenticarEdicao.EditarProprioUsuario(idUsuario, dtgUsuario.Rows[e.RowIndex].Cells["id"].Value.ToString()) == true)
                            {
                                PassarUsuarioParaEdicao(dtgUsuario.Rows[e.RowIndex].Cells["id"].Value.ToString());
                            }
                        }
                        break;
                    case "btnDeletar":
                        DialogResult delConfirm = MessageBox.Show("Deseja realmente deletar este usuario, isto irá deletar todos os registros relacionados ao usuario",
                            "Deseja deletar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (delConfirm == DialogResult.Yes)
                        {

                            UsuarioRegra delUsuario = new UsuarioRegra();
                            bool deletarUsuario = delUsuario.Deletar(idUsuario, dtgUsuario.Rows[e.RowIndex].Cells["Código"].Value.ToString());

                            ConsultaRegra delConsulta = new ConsultaRegra();
                            bool deletarConsulta = delConsulta.DeletarConsultaIdUsuario(idUsuario, dtgUsuario.Rows[e.RowIndex].Cells["Código"].Value.ToString());

                            ProfissionalRegra delProfissional = new ProfissionalRegra();
                            bool deletarProfissional = delProfissional.idUsuario(idUsuario, dtgUsuario.Rows[e.RowIndex].Cells["Código"].Value.ToString());

                            PacienteRegra delPaciente = new PacienteRegra();
                            bool deletarPaciente = delPaciente.excluirLogicamenteIdUsuario(idUsuario, dtgUsuario.Rows[e.RowIndex].Cells["Código"].Value.ToString());

                            if (deletarUsuario == true && deletarConsulta == true && deletarProfissional == true && deletarPaciente == true)
                            {
                                if (MessageBox.Show("Dados deletados permanentemente\nDeseja retornar ao formulario anterior?", "Dados deletados", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    this.Dispose();
                                }
                                else
                                {
                                    CarregarUsuario();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ocorreu um erro ao deletar o usuário e todos os registros relacionados a ele", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                    case "btnImprimir":
                        DataTable dadosTabela = new DataTable();
                        string codUsuario = dtgUsuario.Rows[e.RowIndex].Cells["id"].Value.ToString();
                        dadosTabela = pesquisar.impressaoCompleta(codUsuario);
                        frmImpressao imprimir = new frmImpressao("4", codUsuario);
                        imprimir.ShowDialog();
                        break;
                    default:
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex + ") ao utilizar o DataGridView dtgUsuario(Formulario frmUsuario, Método dtgUsuario_CellClick)", "Erro no DataGrid",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
        private void repetir_Tick(object sender, EventArgs e)
        {
            centralizar();
            salvarToolStripMenuItem.Visible = false;
            atualizarToolStripMenuItem.Visible = false;
            if (rbPesquisarUsuario.Checked == true)
            {
                limparToolStripMenuItem.Visible = false;
            }
            else
            {
                if (Convert.ToInt32(idUsuarioEditar) > 0) { atualizarToolStripMenuItem.Visible = true; } else { salvarToolStripMenuItem.Visible = true; }
                limparToolStripMenuItem.Visible = true;
            }
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(idUsuarioEditar) > 0)
            {
                UsuarioRegra editar = new UsuarioRegra();


                if (editar.Atualizar(Convert.ToInt32(idUsuarioEditar), Convert.ToInt32(cbNivelAcesso.SelectedIndex), txtNomeUsuario.Text, txtLoginUsuario.Text,
                    txtSenha.Text, txtConfirmacaoSenha.Text, txtObservacao.Text, cbStatusUsuario.Text) == true)
                //if(editar.Atualizar(Convert.ToInt32(idUsuarioEditar),Convert.ToInt32(cbIntermediario.Text), txtNomeUsuario.Text,txtLoginUsuario.Text,
                //    txtSenha.Text, txtConfirmacaoSenha.Text, txtObservacao.Text, cbStatusUsuario.Text) == true)
                {
                    if (MessageBox.Show("Dados Alterados com sucesso!\nDeseja retornar ao formulario anterior?", "Dados Alterados",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.Dispose();
                    }
                    else
                    {
                        frmUsuario carregar = new frmUsuario(idUsuario, idNivel, loginUsuario, nomeNivel);
                        this.Hide();
                        carregar.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("A atualização dos dados não foi finalizada corretamente devido dados incorretos ou inválidos", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Para proseguir com a atualização dos dados é necessario selecionar um usúario valido", "Usuário Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimparCadastro();
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void senha(object sender, EventArgs e)
        {
            if (atualizarToolStripMenuItem.Visible == true)
            {
                txtSenha.Clear();
                txtConfirmacaoSenha.Clear();
            }
        }
        private void rbNivelAcesso_CheckedChanged(object sender, EventArgs e)
        {
            cbNivelAcessoPesquisa.Visible = true;
            txtPesquisar.Visible = false;
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }
    }
}
