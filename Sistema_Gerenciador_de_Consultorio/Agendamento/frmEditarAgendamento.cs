using RegraNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gerenciador_de_Consultorio
{
    
    public partial class frmEditarAgendamento : Form
    {
        string idUsuario, idNivel, loginUsuario, nomeNivel, CodAgendamento = "0";
        public frmEditarAgendamento(string idUsuario, string idNivel, string loginUsuario, string nomeNivel)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
        }
        private void frmEditarAgendamento_Load(object sender, EventArgs e)
        {

            CarregarTodosAgendamentos();
            carregarStatusAgendamento();
            pesquisarAgendamentos();

            rbStatusAgendamento.Checked = true;
            cbStatusPesquisar.Visible = true;
            dtpDataInicialPesquisa.Enabled = false;
            dtpDataFinalPesquisa.Enabled = false;
            cbStatusPesquisar.Text = "Marcada";
        }
        void CarregarTodosAgendamentos()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
               AgendamentosRegra pesquisar = new AgendamentosRegra();
                dadosTabela = pesquisar.TodosAgendamentos();
                PreencherAgendamentos(dadosTabela);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar todas as consultas agendadas(formulario frmAgendamento, Método CarregarTodosAgendamentos)", "Erro de carragamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CarregarAgendamentosStatusMarcada()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                AgendamentosRegra pesquisar = new AgendamentosRegra();
                dadosTabela = null;
                dadosTabela = pesquisar.StatusAgendamento("Marcada");

                if (dadosTabela != null) PreencherAgendamentos(dadosTabela);//Verifica se o dataTable tem valor diferente de null, se tiver diferente quer dizer que tem registros
                if (dadosTabela == null)CarregarTodosAgendamentos();//Verifica se o dataTable tem valor null, se tiver quer dizer que não nenhum registro

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao carregar todas as consultas agendadas(formulario frmAgendamento, Método carregarTodosAgendamentos)", "Erro de carragamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void carregarcbStatusPesquisar()
        {
            DataTable dadosTabela = new DataTable();

            LocalizarStatusAgendamentoRegra status = new LocalizarStatusAgendamentoRegra();
            dadosTabela = status.TodosStatus();

            cbStatusPesquisar.DisplayMember = "nomeStatus";
            cbStatusPesquisar.ValueMember = "idStatusAgendamento";
            cbStatusPesquisar.DataSource = dadosTabela;

            cbStatusConsultaEditar.DisplayMember = "nomeStatus";
            cbStatusConsultaEditar.ValueMember = "idStatusAgendamento";
            cbStatusConsultaEditar.DataSource = dadosTabela;
        }
        void CarregarTodosAgendamento()
        {
            DataTable dadosTabela = new DataTable();
            AgendamentosRegra pesquisar = new AgendamentosRegra();

            dadosTabela = pesquisar.TodosAgendamentos();

            PreencherAgendamentos(dadosTabela);
        }
        void pesquisarAgendamentos()
        {
            DataTable dadosTabela = new DataTable();
            AgendamentosRegra PESQUISAR = new AgendamentosRegra();

            if (rbTodasConsultas.Checked == true)
            {
                carregarStatusAgendamento();
            }

            if (rbNomePaciente.Checked == true)
            {
                dadosTabela = PESQUISAR.NomePaciente(txtPesquisarAgendamento.Text);
                PreencherAgendamentos(dadosTabela);
            }

            if (rbRG.Checked == true)
            {
                dadosTabela = PESQUISAR.RG(txtPesquisarAgendamento.Text);
                PreencherAgendamentos(dadosTabela);
            }

            if (rbCpf.Checked == true)
            {
                dadosTabela = PESQUISAR.CPF(txtPesquisarAgendamento.Text);
                PreencherAgendamentos(dadosTabela);
            }

            if (rbDataNascimento.Checked == true)
            {
                dadosTabela = PESQUISAR.DataNascimento(dtpDataInicialPesquisa.Value, dtpDataFinalPesquisa.Value);
                PreencherAgendamentos(dadosTabela);
            }

            if (rbDataConsulta.Checked == true)
            {
                dadosTabela = PESQUISAR.DataConsulta(dtpDataInicialPesquisa.Value, dtpDataFinalPesquisa.Value);
                PreencherAgendamentos(dadosTabela);
            }

            if (rbStatusAgendamento.Checked == true)
            {
                dadosTabela = PESQUISAR.StatusAgendamento(cbStatusPesquisar.Text);
                PreencherAgendamentos(dadosTabela);
            }
        }

        void carregarStatusAgendamento()
        {
            carregarcbStatusPesquisar();
            //carregacbStatusConsultaEditar();
        }
        void PreencherAgendamentos(DataTable dados)
        {
            try
            {
                if (dtgIntermediario.Rows.Count > 0) dtgIntermediario.DataSource = null;

                if (dtgPesquisarConsultasAgendadas.Rows.Count > 0) dtgPesquisarConsultasAgendadas.Rows.Clear();
                dtgIntermediario.DataSource = dados;
                if (dtgIntermediario.Rows.Count > 0)
                {
                    dtgPesquisarConsultasAgendadas.DataSource = null;
                    for (int i = 0; i < dtgIntermediario.Rows.Count; i++)
                    {
                        string idAgendamento = dtgIntermediario.Rows[i].Cells["idagendamento"].Value.ToString();
                        string IDPACIENTE = dtgIntermediario.Rows[i].Cells["idpaciente"].Value.ToString();
                        string PACIENTE = dtgIntermediario.Rows[i].Cells["nomepaciente"].Value.ToString();
                        string RESPONSAVEL = dtgIntermediario.Rows[i].Cells["nomeresponsavel"].Value.ToString();

                        string RG = dtgIntermediario.Rows[i].Cells["rg"].Value.ToString();
                        string CPF = dtgIntermediario.Rows[i].Cells["cpf"].Value.ToString();
                        string NASCIMENTO = dtgIntermediario.Rows[i].Cells["datanascimento"].Value.ToString();

                        string dataConsulta = dtgIntermediario.Rows[i].Cells["dataconsulta"].Value.ToString();
                        string horaChegada = dtgIntermediario.Rows[i].Cells["horachegada"].Value.ToString();
                        string observacaoAgendamento = dtgIntermediario.Rows[i].Cells["observacaoagendamento"].Value.ToString();

                        string loginUsuario = dtgIntermediario.Rows[i].Cells["loginusuario"].Value.ToString();
                        string nomeStatus = dtgIntermediario.Rows[i].Cells["nomestatus"].Value.ToString();

                        CPF = CPF.Replace(".", "").Replace(",", "").Replace("-", "");
                        string CPF1 = CPF[0] + "" + CPF[1] + "" + CPF[2] + "." + CPF[3] + "" + CPF[4] + "" + CPF[5] + "." + CPF[6] + "" + CPF[7] + "" + CPF[8] + "-" + CPF[9] + "" + CPF[10];
                        CPF = CPF1.Trim();
                        string[] arrayNascimento = new string[2];
                        string[] arrayCadastro = new string[2];
                        if (NASCIMENTO.Length > 10)
                        {
                            arrayNascimento = NASCIMENTO.Split();
                            NASCIMENTO = arrayNascimento[0];
                        }
                        if (dataConsulta.Length > 10)
                        {
                            arrayCadastro = dataConsulta.Split();
                            dataConsulta = arrayCadastro[0];
                        }
                        dtgPesquisarConsultasAgendadas.Rows.Add(idAgendamento, IDPACIENTE, PACIENTE, RESPONSAVEL, RG, CPF, NASCIMENTO, dataConsulta, horaChegada, observacaoAgendamento, loginUsuario, nomeStatus);
                        dtgPesquisarConsultasAgendadas.AutoResizeColumns();
                       
                        if (horaChegada.Trim().Length == 8)
                        {
                            dtgPesquisarConsultasAgendadas.Rows[i].Cells["btnPacientePresente"].Style.BackColor = Color.LightGreen;
                            Image Naochegou = Image.FromFile(@"imagens\checkbox1.png");
                            dtgPesquisarConsultasAgendadas.Rows[i].Cells["btnPacientePresente"].Value = Properties.Resources.checkbox1;
                        }
                        else
                        {
                            dtgPesquisarConsultasAgendadas.Rows[i].Cells["btnPacientePresente"].Style.BackColor = Color.LightSalmon;
                            Image Naochegou = Image.FromFile(@"imagens\checkbox2.png");
                            dtgPesquisarConsultasAgendadas.Rows[i].Cells["btnPacientePresente"].Value = Properties.Resources.checkbox2;
                        }
                     
                    }
                    int linhas = dtgPesquisarConsultasAgendadas.Rows.Count;
                    for (int i = 0; i < linhas; i++)
                    {
                        dtgPesquisarConsultasAgendadas.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        i++;
                    }
                }
                else
                {
                    DialogResult confirm = MessageBox.Show("Registros não encontrados, Deseja realizar outra pesquisa? \n\n Caso seja preciso contate o suporte!", "Dados Ausentes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirm == DialogResult.No)
                    {
                        //frmPrincipal principal = new frmPrincipal(idUsuario, idNivel, loginUsuario, nomeNivel);
                        //principal.Show();
                        this.Dispose();
                    }
                    else
                    {
                        CarregarTodosAgendamento();
                    }
                    dtgPesquisarConsultasAgendadas.Enabled = false;
                    dtgPesquisarConsultasAgendadas.AutoResizeColumns();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método PreencherAgendamentos do frmAgendamento", "Erro");
            }
        }
        private void FiltrosAgendamento(object sender, EventArgs e)
        {
            if (rbTodasConsultas.Checked == true)
            {
                txtPesquisarAgendamento.Enabled = true;
                cbStatusPesquisar.Enabled = true;

                dtpDataInicialPesquisa.Enabled = false;
                dtpDataFinalPesquisa.Enabled = false;
                txtPesquisarAgendamento.Visible = true;
                cbStatusPesquisar.Visible = false;
                CarregarTodosAgendamento();
            }
            if (rbNomePaciente.Checked == true)
            {
                txtPesquisarAgendamento.Enabled = true;
                cbStatusPesquisar.Enabled = true;

                dtpDataInicialPesquisa.Enabled = false;
                dtpDataFinalPesquisa.Enabled = false;
                txtPesquisarAgendamento.Visible = true;
                cbStatusPesquisar.Visible = false;
                cbStatusPesquisar.Visible = false;
            }
            if (rbRG.Checked == true)
            {
                txtPesquisarAgendamento.Enabled = true;
                cbStatusPesquisar.Enabled = true;

                dtpDataInicialPesquisa.Enabled = false;
                dtpDataFinalPesquisa.Enabled = false;
                txtPesquisarAgendamento.Visible = true;
                cbStatusPesquisar.Visible = false;
                cbStatusPesquisar.Visible = false;
            }
            if (rbCpf.Checked == true)
            {
                txtPesquisarAgendamento.Enabled = true;
                cbStatusPesquisar.Enabled = true;

                dtpDataInicialPesquisa.Enabled = false;
                dtpDataFinalPesquisa.Enabled = false;
                txtPesquisarAgendamento.Visible = true;
                cbStatusPesquisar.Visible = false;
                cbStatusPesquisar.Visible = false;
            }
            if (rbDataNascimento.Checked == true || rbDataConsulta.Checked == true)
            {
                txtPesquisarAgendamento.Enabled = false;
                cbStatusPesquisar.Enabled = false;
                dtpDataInicialPesquisa.Enabled = false;
                dtpDataFinalPesquisa.Enabled = false;
                txtPesquisarAgendamento.Enabled = false;
                dtpDataInicialPesquisa.Enabled = true;
                dtpDataFinalPesquisa.Enabled = true;
            }
            if (rbStatusAgendamento.Checked == true)
            {
                txtPesquisarAgendamento.Enabled = true;
                cbStatusPesquisar.Enabled = true;

                txtPesquisarAgendamento.Visible = false;
                cbStatusPesquisar.Visible = true;
                dtpDataInicialPesquisa.Enabled = false;
                dtpDataFinalPesquisa.Enabled = false;
                cbStatusPesquisar.Text = "Marcada";
            }
        }

        private void gbEditar_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendamentosRegra atualizar = new AgendamentosRegra();
            if (atualizar.AtualizarAgendamentos(CodAgendamento, Convert.ToString(cbStatusConsultaEditar.SelectedIndex + 1), dtpDataConsultaEditar.Text, txtObservacaoAgendamentoEditar.Text) == true)
            {
                MessageBox.Show("Agendamento Atualizado com sucesso!", "Dados Atualizados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarAgendamentosStatusMarcada();
            }
            else
            {
                MessageBox.Show("Os dados não foram atualizados pois há dados incorrestos", "Dados Incorretos!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPesquisarAgendamento_Click(object sender, EventArgs e)
        {
            pesquisarAgendamentos();
            if (dtgPesquisarConsultasAgendadas.Rows.Count > 0)
            {
                dtgPesquisarConsultasAgendadas.Enabled = true;
                dtgPesquisarConsultasAgendadas.AutoResizeColumns();
            }
        }

        private void cbStatusPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStatusPesquisar.SelectedItem.ToString();
        }

        private void dtgPesquisarConsultasAgendadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dtgPesquisarConsultasAgendadas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                CodAgendamento = dtgPesquisarConsultasAgendadas.Rows[e.RowIndex].Cells["idAgendamento"].Value.ToString();
                dtpDataConsultaEditar.Text = dtgPesquisarConsultasAgendadas.Rows[e.RowIndex].Cells["dataconsulta"].Value.ToString();
                cbStatusConsultaEditar.Text = dtgPesquisarConsultasAgendadas.Rows[e.RowIndex].Cells["nomestatus"].Value.ToString();
                txtObservacaoAgendamentoEditar.Text = dtgPesquisarConsultasAgendadas.Rows[e.RowIndex].Cells["observacaoagendamento"].Value.ToString();
            }
            if (dtgPesquisarConsultasAgendadas.Columns[e.ColumnIndex].Name == "btnPacientePresente")
            {
                AgendamentosRegra ordenar = new AgendamentosRegra();
                string id = dtgPesquisarConsultasAgendadas.Rows[e.RowIndex].Cells["idAgendamento"].Value.ToString();
                string dataConsulta = dtgPesquisarConsultasAgendadas.Rows[e.RowIndex].Cells["dataConsulta"].Value.ToString();

                if (Convert.ToBoolean(dtgPesquisarConsultasAgendadas.Rows[e.RowIndex].Cells["btnPacientePresente"].Style.BackColor.Name == "LightSalmon"))
                {

                    if (ordenar.ChegadaPaciente(id, Convert.ToDateTime(dataConsulta)) == true)
                    {
                        MessageBox.Show("Paciente incluido na lista de espera com sucesso!", "Paciente em Espera!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarAgendamentosStatusMarcada();
                    }
                    else
                    {
                        MessageBox.Show("O Paciente não foi incluido na lista de espera pois pode não ser o dia de sua consulta!", "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarAgendamentosStatusMarcada();
                    }
                }
                else
                {
                    MessageBox.Show("Não é possivel incluir o paciente novamente na lista de espera", "Ação inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (dtgPesquisarConsultasAgendadas.Columns[e.ColumnIndex].Name == "btnConsultar")
            {
                PermissoesUsuarioRegra permissoesUsuario = new PermissoesUsuarioRegra();
                if (permissoesUsuario.NovaConsulta(idNivel) == true)
                {
                    DataTable dados = new DataTable();
                    if (dtgIntermediario.Rows.Count > 0) dtgIntermediario.DataSource = null;

                    string idPacientePassarDados, idContatoPassarDados, idEnderecoPassarDados, idUsuarioPassarDados, nomePacientePassarDados, NomeResponsavelPassarDados, rgPassarDados,
                     cpfPassarDados, ocupacaoPassarDados, idadePassarDados, sexoPassarDados, dataNascimentoPassarDados, dataCadastroPassarDados, horaCadastroPassarDados, observacaoPacientePassarDados;

                    idPacientePassarDados = dtgPesquisarConsultasAgendadas.Rows[e.RowIndex].Cells["codigoPaciente"].Value.ToString();

                    PacienteRegra pesquisar = new PacienteRegra();
                    dados = pesquisar.CodigoPaciente(Convert.ToInt32(idPacientePassarDados));

                    dtgIntermediario.DataSource = dados;

                    idContatoPassarDados = dtgIntermediario.Rows[0].Cells["idContato"].Value.ToString();
                    idEnderecoPassarDados = dtgIntermediario.Rows[0].Cells["idEndereco"].Value.ToString();

                    idUsuarioPassarDados = dtgIntermediario.Rows[0].Cells["idusuario"].Value.ToString();
                    nomePacientePassarDados = dtgIntermediario.Rows[0].Cells["nomepaciente"].Value.ToString();
                    NomeResponsavelPassarDados = dtgIntermediario.Rows[0].Cells["nomeresponsavel"].Value.ToString();

                    rgPassarDados = dtgIntermediario.Rows[0].Cells["rg"].Value.ToString();
                    cpfPassarDados = dtgIntermediario.Rows[0].Cells["cpf"].Value.ToString();
                    ocupacaoPassarDados = dtgIntermediario.Rows[0].Cells["ocupacao"].Value.ToString();

                    idadePassarDados = dtgIntermediario.Rows[0].Cells["idade"].Value.ToString();
                    sexoPassarDados = dtgIntermediario.Rows[0].Cells["sexo"].Value.ToString();
                    dataNascimentoPassarDados = dtgIntermediario.Rows[0].Cells["dataNascimento"].Value.ToString();

                    dataCadastroPassarDados = dtgIntermediario.Rows[0].Cells["dataCadastro"].Value.ToString();
                    horaCadastroPassarDados = dtgIntermediario.Rows[0].Cells["horaCadastro"].Value.ToString();
                    observacaoPacientePassarDados = dtgIntermediario.Rows[0].Cells["observacaoPaciente"].Value.ToString();

                    ConstrutorPaciente construtor = new ConstrutorPaciente(idUsuario, idNivel, loginUsuario, nomeNivel, idPacientePassarDados, idContatoPassarDados, idEnderecoPassarDados, idUsuarioPassarDados, nomePacientePassarDados, NomeResponsavelPassarDados, rgPassarDados,
                    cpfPassarDados, ocupacaoPassarDados, idadePassarDados, sexoPassarDados, dataNascimentoPassarDados, dataCadastroPassarDados, horaCadastroPassarDados, observacaoPacientePassarDados);
                    frmCadastrarConsulta novaConsulta = new frmCadastrarConsulta(construtor);
                    novaConsulta.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Para reailizar uma nova consulta é necessario ser um profissional ou administrador \n Usuario: " + loginUsuario + "Nivel de Acesso: " + nomeNivel, "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
           
        }
    }
}
