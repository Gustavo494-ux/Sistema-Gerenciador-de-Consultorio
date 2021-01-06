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
    public partial class frmLocalizarPaciente : Form
    {
        string idUsuario, idNivel, loginUsuario, nomeNivel;
        public frmLocalizarPaciente(string idUsuario, string idNivel, string loginUsuario, string nomeNivel)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
        }

        void estilizar()
        {
            int linhas = dtgPaciente.Rows.Count;
            for (int i = 0; i < linhas; i++)
            {
                //dtgPaciente.Rows[i].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                dtgPaciente.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;

                i++;
            }
        }
        void esvaziardtg()
        {
            DataTable table = new DataTable();
            dtgPaciente.DataSource = table;
        }
        void limpar()
        {
            txtPesquisar.Clear();
            rbSemFiltros.Checked = true;
            nudPesquisar.Value = 0;
            CarregarTodosPacientes();
        }
        void CarregarTodosPacientes()
        {
            DataTable DadosPaciente = new DataTable();
            esvaziardtg();
            try
            {
               PacienteRegra PesquisarRegra = new PacienteRegra();
                DadosPaciente = PesquisarRegra.TodosPacientes();
                dtgPaciente.DataSource = null;
                PreencherDtg(DadosPaciente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método CarregarTodosPacientes do formulario FrmLocalizarPaciente, Erro:" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void Pesquisar()
        {
            DataTable dadosProfissional;
            try
            {
                PacienteRegra localizarPaciente = new PacienteRegra();
                if (rbIdPaciente.Checked == true)
                {
                    int cod = Convert.ToInt32(nudPesquisar.Text);
                    dadosProfissional = localizarPaciente.CodigoPaciente(cod);
                    esvaziardtg();
                    PreencherDtg(dadosProfissional);
                }
                if (rbNome.Checked == true)
                {
                    dadosProfissional = localizarPaciente.NomePaciente(txtPesquisar.Text);
                    esvaziardtg();
                    PreencherDtg(dadosProfissional);
                }
                if (rbCPF.Checked == true)
                {
                    dadosProfissional = localizarPaciente.CpfPaciente(nudPesquisar.Text);
                    esvaziardtg();
                    PreencherDtg(dadosProfissional);
                }

                if (rbRG.Checked == true)
                {
                    dadosProfissional = localizarPaciente.RgPaciente(nudPesquisar.Text);
                    esvaziardtg();
                    PreencherDtg(dadosProfissional);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método Pesquisar do formulario FrmLocalizarPaciente, Erro:" + ex, "Erro de Pesquisa");
            }
        }
        void PreencherDtg(DataTable dados)
        {
            try
            {
                dtgIntermediario.DataSource = dados;
                if (dtgIntermediario.Rows.Count >0)
                {
                    string[] arrayNascimento = new string[2];
                    string[] arrayCadastro = new string[2];
                    dtgPaciente.DataSource = null;
                    for (int i = 0; i < dtgIntermediario.Rows.Count; i++)
                    {
                        string IDPACIENTE = dtgIntermediario.Rows[i].Cells["idpaciente"].Value.ToString();
                        string IDCONTATO = dtgIntermediario.Rows[i].Cells["idcontato"].Value.ToString();
                        string IDENDERECO = dtgIntermediario.Rows[i].Cells["idendereco"].Value.ToString();

                        string IDUSUARIO = dtgIntermediario.Rows[i].Cells["idusuario"].Value.ToString();
                        string PACIENTE = dtgIntermediario.Rows[i].Cells["nomepaciente"].Value.ToString();
                        string RESPONSAVEL = dtgIntermediario.Rows[i].Cells["nomeresponsavel"].Value.ToString();

                        string RG = dtgIntermediario.Rows[i].Cells["rg"].Value.ToString();
                        string CPF = dtgIntermediario.Rows[i].Cells["cpf"].Value.ToString();
                        string OCUPACAO = dtgIntermediario.Rows[i].Cells["ocupacao"].Value.ToString();

                        string IDADE = dtgIntermediario.Rows[i].Cells["idade"].Value.ToString();
                        string SEXO = dtgIntermediario.Rows[i].Cells["sexo"].Value.ToString();
                        string NASCIMENTO = dtgIntermediario.Rows[i].Cells["datanascimento"].Value.ToString();

                        string CADASTRO = dtgIntermediario.Rows[i].Cells["datacadastro"].Value.ToString();
                        string HORA = dtgIntermediario.Rows[i].Cells["horacadastro"].Value.ToString();
                        string OBSERVACAO = dtgIntermediario.Rows[i].Cells["observacaopaciente"].Value.ToString();

                        string CPF1 = "";
                        if (CPF.Length == 11)
                        {
                            CPF1 = CPF[0] + "" + CPF[1] + "" + CPF[2] + "." + CPF[3] + "" + CPF[4] + "" + CPF[5] + "." + CPF[6] + "" + CPF[7] + "" + CPF[8] + "-" + CPF[9] + "" + CPF[10];
                        }
                        CPF = CPF1.Trim();
                        if (NASCIMENTO.Length>10)
                        {
                            arrayNascimento = NASCIMENTO.Split();
                            NASCIMENTO = arrayNascimento[0];
                        }
                        if (CADASTRO.Length >10)
                        {
                            arrayCadastro = CADASTRO.Split();
                            CADASTRO = arrayCadastro[0];
                        }
                        dtgPaciente.Rows.Add(IDPACIENTE, IDCONTATO, IDENDERECO, IDUSUARIO, PACIENTE, RESPONSAVEL, RG, CPF, OCUPACAO, IDADE, SEXO, NASCIMENTO/*.Substring(0, 8)*/, CADASTRO/*.Substring(0, 8)*/, HORA, OBSERVACAO);

                    }
                    dtgPaciente.AutoResizeColumns();
                }
                else
                {
                    DialogResult confirm = MessageBox.Show("Registros não encontrados, Deseja realizar outra pesquisa? \n\n Caso seja preciso contate o suporte!", "Dados Ausentes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirm == DialogResult.No)
                    {
                        this.Dispose();
                    }
                    else
                    {
                        CarregarTodosPacientes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método PreencherDtg do frmLocalizarPaciente", "Erro");
            }
        }
        private void atualizar_Tick(object sender, EventArgs e)
        {
            estilizar();
        }
        private void frmLocalizarPaciente_Load(object sender, EventArgs e)
        {
            pnlPesquisar.Location = new Point(this.Width / 2 - (pnlPesquisar.Width / 2), 50);
            CarregarTodosPacientes();
            limpar();
            txtPesquisar.Focus();
            rbSemFiltros.Checked = true;
            lblLoginUsuario.Text = "Usuario: " + loginUsuario + "\nNivel: " + nomeNivel ;
            txtPesquisar.Visible = true;
            if (dtgIntermediario.Rows.Count <1)
            {
                if (MessageBox.Show("O Paciente não Existente, Realize o Cadastro de uma novo Paciente. \n\n Caso seja preciso contate o suporte!",
                    "Dados Ausentes", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //frmPrincipal principal = new frmPrincipal(idUsuario, idNivel, loginUsuario, nomeNivel);
                    //principal.Show();
                    this.Dispose();
                }
                else
                {
                    CarregarTodosPacientes();
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //frmPrincipal voltar = new frmPrincipal(idUsuario, idNivel, loginUsuario, nomeNivel);
            //voltar.Show();
            this.Dispose();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void filtros(object sender, EventArgs e)
        {
            nudPesquisar.Value = 0;
            txtPesquisar.Clear();
            if (rbIdPaciente.Checked == true)
            {
                txtPesquisar.Visible = false;
                nudPesquisar.Visible = true;
            }
            if (rbNome.Checked == true)
            {

                txtPesquisar.Visible = true;
                nudPesquisar.Visible = false;
            }
            if (rbCPF.Checked == true)
            {
                txtPesquisar.Visible = false;
                nudPesquisar.Visible = true;
            }
            if (rbRG.Checked == true)
            {
                txtPesquisar.Visible = false;
                nudPesquisar.Visible = true;
            }
            if (rbSemFiltros.Checked == true)
            {
                txtPesquisar.Visible = true;
                nudPesquisar.Visible = false;
                dtgPaciente.DataSource = null;
                CarregarTodosPacientes();
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void rbSemFiltros_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Visible = true;
            nudPesquisar.Visible = false;
            dtgPaciente.DataSource = null;
            CarregarTodosPacientes();

        }
        private void dtgPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idPacientePassarDados, idContatoPassarDados, idEnderecoPassarDados, idUsuarioPassarDados, nomePacientePassarDados, NomeResponsavelPassarDados, rgPassarDados,
                cpfPassarDados, ocupacaoPassarDados, idadePassarDados, sexoPassarDados, dataNascimentoPassarDados, dataCadastroPassarDados, horaCadastroPassarDados, observacaoPacientePassarDados;

                if (dtgPaciente.Columns[e.ColumnIndex].Name == "btnImprimir")
                {
                    frmImpressao imprimir = new frmImpressao("2",dtgPaciente.Rows[e.RowIndex].Cells["idPaciente"].Value.ToString());
                    imprimir.ShowDialog();

                }
                if (dtgPaciente.Columns[e.ColumnIndex].Name == "btnConsultar")
                {
                     idPacientePassarDados = dtgPaciente.Rows[e.RowIndex].Cells["idPaciente"].Value.ToString();
                     idContatoPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["idContato"].Value.ToString();
                     idEnderecoPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["idEndereco"].Value.ToString();

                     idUsuarioPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
                     nomePacientePassarDados = dtgPaciente.Rows[e.RowIndex].Cells["nomePaciente"].Value.ToString();
                     NomeResponsavelPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["nomeResponsavel"].Value.ToString();

                     rgPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["rg"].Value.ToString();
                     cpfPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                     ocupacaoPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["ocupacao"].Value.ToString();

                     idadePassarDados = dtgPaciente.Rows[e.RowIndex].Cells["idade"].Value.ToString();
                     sexoPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["sexo"].Value.ToString();
                     dataNascimentoPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["dataNascimento"].Value.ToString();

                     dataCadastroPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["dataCadastro"].Value.ToString();
                     horaCadastroPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["horaCadastro"].Value.ToString();
                     observacaoPacientePassarDados = dtgPaciente.Rows[e.RowIndex].Cells["observacaoPaciente"].Value.ToString();

                    ConstrutorPaciente construtor = new ConstrutorPaciente(idUsuario,idNivel, loginUsuario, nomeNivel, idPacientePassarDados, idContatoPassarDados, idEnderecoPassarDados, idUsuarioPassarDados, nomePacientePassarDados, NomeResponsavelPassarDados, rgPassarDados,
                    cpfPassarDados, ocupacaoPassarDados, idadePassarDados, sexoPassarDados, dataNascimentoPassarDados, dataCadastroPassarDados, horaCadastroPassarDados, observacaoPacientePassarDados);
                    frmCadastrarConsulta novaConsulta = new frmCadastrarConsulta(construtor);
                    novaConsulta.ShowDialog();
                }
                if (dtgPaciente.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    idPacientePassarDados = dtgPaciente.Rows[e.RowIndex].Cells["idPaciente"].Value.ToString();
                    idContatoPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["idContato"].Value.ToString();
                    idEnderecoPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["idEndereco"].Value.ToString();

                    idUsuarioPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
                    nomePacientePassarDados = dtgPaciente.Rows[e.RowIndex].Cells["nomePaciente"].Value.ToString();
                    NomeResponsavelPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["nomeResponsavel"].Value.ToString();

                    rgPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["rg"].Value.ToString();
                    cpfPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                    ocupacaoPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["ocupacao"].Value.ToString();

                    idadePassarDados = dtgPaciente.Rows[e.RowIndex].Cells["idade"].Value.ToString();
                    sexoPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["sexo"].Value.ToString();
                    dataNascimentoPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["dataNascimento"].Value.ToString();

                    dataCadastroPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["dataCadastro"].Value.ToString();
                    horaCadastroPassarDados = dtgPaciente.Rows[e.RowIndex].Cells["horaCadastro"].Value.ToString();
                    observacaoPacientePassarDados = dtgPaciente.Rows[e.RowIndex].Cells["observacaoPaciente"].Value.ToString();

                    ConstrutorPaciente construtor = new ConstrutorPaciente(idUsuario,idNivel, loginUsuario, nomeNivel, idPacientePassarDados, idContatoPassarDados, idEnderecoPassarDados, idUsuarioPassarDados, nomePacientePassarDados, NomeResponsavelPassarDados, rgPassarDados,
                    cpfPassarDados, ocupacaoPassarDados, idadePassarDados, sexoPassarDados, dataNascimentoPassarDados, dataCadastroPassarDados, horaCadastroPassarDados, observacaoPacientePassarDados);

                    frmCadastrarPaciente editar = new frmCadastrarPaciente(construtor);
                    editar.ShowDialog();
                }
                if (dtgPaciente.Columns[e.ColumnIndex].Name == "btnDeletar")
                {
                    DialogResult confirmarDelecao =  MessageBox.Show("Deseja realmente deletar o Endereço, Contato, Consulta e todos os dados relacionados a este Paciente ?","Deletar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmarDelecao == DialogResult.Yes)
                    {
                        //Paciente
                        PacienteRegra delPaciente = new PacienteRegra();
                        bool pacienteConfirm =delPaciente.excluirLogicamenteIdPaciente(idUsuario,dtgPaciente.Rows[e.RowIndex].Cells["idPaciente"].Value.ToString());

                        //Consulta
                        ConsultaRegra delConsulta = new ConsultaRegra();
                        bool consultaConfirm= delConsulta.DeletarConsultaIdPaciente(idUsuario,dtgPaciente.Rows[e.RowIndex].Cells["idPaciente"].Value.ToString());

                        if(pacienteConfirm == true && consultaConfirm == true)
                        {
                            if (MessageBox.Show("Dados Deletados Permanentemente com Sucesso!\nDeseja retornar ao formulario principal?",
                            "Dados Deletados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                CarregarTodosPacientes();
                                this.Dispose();
                            }
                            else
                            {
                                CarregarTodosPacientes();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Os Dados não foram deletados corretamente!", "Dados não deletados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                if (dtgPaciente.Rows.Count < 1)
                {
                    dtgPaciente.DataSource = null;
                    CarregarTodosPacientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao transferir os dados do DataGridView(dtgPaciente) para o Array responsável por enviar ao dados ao formulario de cadastro da consulta. Error:"+ex.Message,
                    "Erro de transferencia de dados");
            }
        }
    }
}
