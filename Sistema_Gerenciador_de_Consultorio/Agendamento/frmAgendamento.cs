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
    public partial class frmAgendamento : Form
    {
        string idUsuario, idNivel, loginUsuario, nomeNivel, CodAgendamento = "0";
        public frmAgendamento(string idUsuario, string idNivel, string loginUsuario, string nomeNivel)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
        }
        private void frmAgendamento_Load(object sender, EventArgs e)
        {
            lblUsuarioSistema.Text = "Usuário: " + loginUsuario + "     Nivel de Acesso: " + nomeNivel;
            rbSemFiltros.Checked = true;
            txtPesquisar.Visible = true;
            rbDadosPessoais.Checked = true;
            gbDadosPessoais.Visible = true;
            carregarStatusAgendamento();
            CarregarTodosPacientes();
            limpar();
        }
       
         void centralizarGbs()
         {
            gbDadosPessoais.Location = new Point(tpPacienteNovo.Width / 2 - (gbDadosPessoais.Width / 2), tpPacienteNovo.Height / 2 - (gbDadosPessoais.Height / 2));
            gbContato.Location = new Point(tpPacienteNovo.Width / 2 - (gbContato.Width / 2), tpPacienteNovo.Height / 2 - (gbContato.Height / 2));

            gbEndereco.Location = new Point(tpPacienteNovo.Width / 2 - (gbEndereco.Width / 2), tpPacienteNovo.Height / 2 - (gbEndereco.Height / 2));
            gbDadosAgendamento.Location = new Point(tpPacienteNovo.Width / 2 - (gbDadosAgendamento.Width / 2), tpPacienteNovo.Height / 2 - (gbDadosAgendamento.Height / 2));
        }
        void esvaziardtg()
        {
            DataTable table = new DataTable();
            dtgPaciente.DataSource = table;
        }
        void carregarStatusAgendamento()
        {
            carregarcbStatusConsultaPacienteExistente();
            carregarcbStatusConsultaNovo();
        }
      
        void  carregarcbStatusConsultaNovo()
        {
            DataTable dadosTabela = new DataTable();

            LocalizarStatusAgendamentoRegra status = new LocalizarStatusAgendamentoRegra();
            dadosTabela = status.TodosStatus();

            cbStatusConsultaNovo.DisplayMember = "nomeStatus";
            cbStatusConsultaNovo.ValueMember = "idStatusAgendamento";
            cbStatusConsultaNovo.DataSource = dadosTabela;
        }
     
        void carregarcbStatusConsultaPacienteExistente()
        {
            DataTable dadosTabela = new DataTable();

            LocalizarStatusAgendamentoRegra status = new LocalizarStatusAgendamentoRegra();
            dadosTabela = status.TodosStatus();

            cbStatusConsultaPacienteExistente.DisplayMember = "nomeStatus";
            cbStatusConsultaPacienteExistente.ValueMember = "idStatusAgendamento";
            cbStatusConsultaPacienteExistente.DataSource = dadosTabela;

        }
       
       
        void limpar()
        {
            //Limpa os campos responsáveis por agendar a consulta do paciente existente.
            dtpDataConsultaPacienteExistente.Text = DateTime.Now.ToShortDateString();
            carregarStatusAgendamento();
            txtObservacaoPacienteExistente.Clear();

            //Paciente novo
            txtNomePacienteNovo.Clear();
            txtNomeResponsavelNovo.Clear();
            txtObservacaoPacienteNovo.Clear();
            mtxtRGNovo.Clear();
            mtxtCPFNovo.Clear();
            dtpNascimento.Text = DateTime.Now.ToShortDateString();
            txtIdadeNovo.Clear();

            //Contato novo
            txtEmail.Clear();
            txtOutro.Clear();
            txtObservacaoContatoNovo.Clear();
            mtxtTelefone1Novo.Clear();
            mtxtTelefone2Novo.Clear();
            mtxtTelefone3.Clear();


            //Estado novo
            txtEstadoNovo.Clear();
            txtCidadeNovo.Clear();
            txtBairro.Clear();
            txtRuaNovo.Clear();
            nudNumeroNovo.Value = 0;
            mtxtCEPNovo.Clear();
            txtPontoReferenciaNovo.Clear();
            txtObservacaoEnderecoNovo.Clear();

            //Agendamento de novo paciente
            txtObservacaoAgendamentoNovo.Clear();
            dtpDataConsultaNovo.Text= DateTime.Now.ToShortDateString();
            //editar agendamento
            //txtObservacaoAgendamentoEditar.Clear();
            //dtpDataConsultaEditar.Text = DateTime.Now.ToShortDateString();
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
                PreencherPaciente(DadosPaciente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método CarregarTodosPacientes do formulario frmAgendamento, Erro:" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void PreencherPaciente(DataTable dados)
        {
            try
            {
                dtgIntermediario.DataSource = dados;
                if (dtgIntermediario.Rows.Count > 0)
                {
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
                        string[] arrayNascimento = new string[2];
                        string[] arrayCadastro = new string[2];
                        if (NASCIMENTO.Length > 10)
                        {
                            arrayNascimento = NASCIMENTO.Split();
                            NASCIMENTO = arrayNascimento[0];
                        }
                        if (CADASTRO.Length > 10)
                        {
                            arrayCadastro = CADASTRO.Split();
                            CADASTRO = arrayCadastro[0];
                        }
                        string CPF1="";
                        if (CPF.Length == 11 || CPF.Length == 14)
                        {
                            CPF = CPF.Replace(".", "").Replace(",", "").Replace("-", "");
                            CPF1 = CPF[0] + "" + CPF[1] + "" + CPF[2] + "." + CPF[3] + "" + CPF[4] + "" + CPF[5] + "." + CPF[6] + "" + CPF[7] + "" + CPF[8] + "-" + CPF[9] + "" + CPF[10];
                        }
                        CPF = CPF1.Trim();
                        dtgPaciente.Rows.Add(IDPACIENTE, IDCONTATO, IDENDERECO, IDUSUARIO, PACIENTE, RESPONSAVEL, RG, CPF, OCUPACAO, IDADE, SEXO, NASCIMENTO, CADASTRO, HORA, OBSERVACAO);

                    }
                    int linhas = dtgPaciente.Rows.Count;
                    for (int i = 0; i < linhas; i++)
                    {
                        dtgPaciente.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        i++;
                    }
                    dtgPaciente.AutoResizeColumns();
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
                        CarregarTodosPacientes();
                    }
                    dtgPaciente.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método PreencherPaciente do frmAgendamento", "Erro");
            }
        }  
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //frmPrincipal formPrincipal = new frmPrincipal(idUsuario, idNivel, loginUsuario, nomeNivel);
            //formPrincipal.Show();
            this.Dispose();
        }
        private void btnCadastrarEAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                AgendamentosRegra agendarConsultaNovo = new AgendamentosRegra();
                bool paciente = agendarConsultaNovo.AgendarNovo(Convert.ToString(cbStatusConsultaNovo.SelectedIndex+1),dtpDataConsultaNovo.Text, txtObservacaoAgendamentoNovo.Text,idUsuario,
                    txtNomePacienteNovo.Text.ToUpper(), txtNomeResponsavelNovo.Text.ToUpper(), mtxtRGNovo.Text, mtxtCPFNovo.Text, txtIdadeNovo.Text, dtpNascimento.Text,
                    txtObservacaoPacienteNovo.Text,txtEmail.Text, mtxtTelefone1Novo.Text, mtxtTelefone2Novo.Text, mtxtTelefone3.Text, txtOutro.Text, txtObservacaoContatoNovo.Text,
                    txtEstadoNovo.Text, txtCidadeNovo.Text, txtBairro.Text, txtRuaNovo.Text, nudNumeroNovo.Value.ToString(), mtxtCEPNovo.Text, txtPontoReferenciaNovo.Text, 
                    txtObservacaoEnderecoNovo.Text);

                    //bool agendamento = agendarConsultaNovo.AgendarConsulta();
                if (paciente == true)
                {
                    MessageBox.Show("Paciente cadastrado e consulta marcada com sucesso!\n\n Assim que possível complete os dados do paciente pois os dados cadastrados neste momento são apenas os necessarios para " +
                        "o agendamento da consulta mas ainda são insulficientes para o cadastro do paciente", "Consulta Agendada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                    CarregarTodosPacientes();
                   // CarregarAgendamentosStatusMarcada();
                }
                else
                {
                    MessageBox.Show("Paciente não foi cadastrado nem agendado devido a alguma informação está incompleta ou inválida", "Informações Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex + ") ao tentar cadastrar um novo paciente(Formulario frmAgendamento, Evento btnCadastrarEAgendar_click)", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        void PesquisarPaciente()
        {
            DataTable dadosProfissional = new DataTable();
            try
            {
                PacienteRegra localizarPaciente = new PacienteRegra();
                if (rbIdPaciente.Checked == true)
                {
                    int cod = Convert.ToInt32(txtPesquisar.Text);
                    dadosProfissional = localizarPaciente.CodigoPaciente(cod);
                }
                if (rbNome.Checked == true)
                {
                    dadosProfissional = localizarPaciente.NomePaciente(txtPesquisar.Text);
                }
                if (rbCpf.Checked == true)
                {
                    dadosProfissional = localizarPaciente.CpfPaciente(txtPesquisar.Text);
                }

                if (rbRG.Checked == true)
                {
                    dadosProfissional = localizarPaciente.RgPaciente(txtPesquisar.Text);
                }
                if(rbSemFiltros.Checked == true)
                {
                    dadosProfissional = localizarPaciente.TodosPacientes();
                }
                esvaziardtg();
                PreencherPaciente(dadosProfissional);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método PesquisarPaciente do formulario frmAgendamento, Erro:" + ex, "Erro de Pesquisa");
            }
        }
        private void filtrosPaciente(object sender, EventArgs e)
        {
            txtPesquisar.Clear();
            nudPesquisar.Value = 0;
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
            if (rbCpf.Checked == true)
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

        private void btnPesquisarPaciente_Click(object sender, EventArgs e)
        {
            PesquisarPaciente();
        }
        private void btnEditarAgendamento_Click(object sender, EventArgs e)
        {
            frmEditarAgendamento editarAgendamento = new frmEditarAgendamento(idUsuario, idNivel, loginUsuario, nomeNivel);
            editarAgendamento.ShowDialog();
        }

        private void visibilidadeBtnCadastrarEAgendar(object sender, EventArgs e)
        {
            if (btnCadastrarEAgendar.Visible == false)
            {
                btnCadastrarEAgendar.Visible = true;
            }
            else
            {
                btnCadastrarEAgendar.Visible = false;
            }
        }
        private void rbDadosPessoais_CheckedChanged(object sender, EventArgs e)
        {
            gbDadosPessoais.Visible = true;
            gbContato.Visible = false;
            gbEndereco.Visible = false;
            gbDadosAgendamento.Visible = false;
        }
        private void rbContato_CheckedChanged(object sender, EventArgs e)
        {
            gbDadosPessoais.Visible = false;
            gbContato.Visible = true;
            gbEndereco.Visible = false;
            gbDadosAgendamento.Visible = false;
        }
        private void rbEndereco_CheckedChanged(object sender, EventArgs e)
        {
            gbDadosPessoais.Visible = false;
            gbContato.Visible = false;
            gbEndereco.Visible = true;
            gbDadosAgendamento.Visible = false;
        }
        private void rbDadosAgendamento_CheckedChanged(object sender, EventArgs e)
        {
            gbDadosPessoais.Visible = false;
            gbContato.Visible = false;
            gbEndereco.Visible = false;
            gbDadosAgendamento.Visible = true;
        }

        private void dtgPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgPaciente.Columns[e.ColumnIndex].Name == "btnAgendar")
            {
                int idStatus = Convert.ToInt32(cbStatusConsultaPacienteExistente.SelectedIndex.ToString());
                idStatus = idStatus + 1;
                string[] arrayNascimento = new string[2];
                string[] arrayCadastro = new string[2];

                AgendamentosRegra agendarConsultaPacienteExistente = new AgendamentosRegra();

                string IDPACIENTE = dtgPaciente.Rows[e.RowIndex].Cells["CodPaciente"].Value.ToString();
                string IDCONTATO = dtgPaciente.Rows[e.RowIndex].Cells["idcontato"].Value.ToString();
                string IDENDERECO = dtgPaciente.Rows[e.RowIndex].Cells["idendereco"].Value.ToString();

                string IDUSUARIO = dtgPaciente.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
                string PACIENTE = dtgPaciente.Rows[e.RowIndex].Cells["nomepaciente"].Value.ToString();
                string RESPONSAVEL = dtgPaciente.Rows[e.RowIndex].Cells["nomeresponsavel"].Value.ToString();

                string RG = dtgPaciente.Rows[e.RowIndex].Cells["rg"].Value.ToString();
                string CPF = dtgPaciente.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                string OCUPACAO = dtgPaciente.Rows[e.RowIndex].Cells["ocupacao"].Value.ToString();

                string IDADE = dtgPaciente.Rows[e.RowIndex].Cells["idade"].Value.ToString();
                string SEXO = dtgPaciente.Rows[e.RowIndex].Cells["sexo"].Value.ToString();
                string NASCIMENTO = dtgPaciente.Rows[e.RowIndex].Cells["datanascimento"].Value.ToString();

                string CADASTRO = dtgPaciente.Rows[e.RowIndex].Cells["datacadastro"].Value.ToString();
                string HORA = dtgPaciente.Rows[e.RowIndex].Cells["horacadastro"].Value.ToString();
                string OBSERVACAO = dtgPaciente.Rows[e.RowIndex].Cells["observacaopaciente"].Value.ToString();

                if (NASCIMENTO.Length > 10)
                {
                    arrayNascimento = NASCIMENTO.Split();
                    NASCIMENTO = arrayNascimento[0];
                }
                if (CADASTRO.Length > 10)
                {
                    arrayCadastro = CADASTRO.Split();
                    CADASTRO = arrayCadastro[0];
                }
                if (agendarConsultaPacienteExistente.AgendarConsulta(IDPACIENTE, idUsuario, Convert.ToString(idStatus), dtpDataConsultaPacienteExistente.Text,
                    txtObservacaoPacienteExistente.Text) == true)
                {
                    MessageBox.Show("Consulta foi agendada com sucesso!", "Consulta Agendada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                    CarregarTodosPacientes();
                    // CarregarAgendamentosStatusMarcada();
                }
                else
                {
                    MessageBox.Show("Algumas informações são inválidas, para proseguir com o agendamento forneça informações válidas", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            centralizarGbs();
            dtgPaciente.AutoResizeColumns();
            //dtgPesquisarConsultasAgendadas.AutoResizeColumns();
            //pnlPesquisarEditar.Refresh();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void rbSemFiltros_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Visible = true;
            nudPesquisar.Visible = false;
            dtgPaciente.DataSource = null;
            CarregarTodosPacientes();
        }
        private void btnAdicionarPaciente_Click(object sender, EventArgs e)
        {
            frmLocalizarPaciente agendarPaciente = new frmLocalizarPaciente(idUsuario,idNivel,loginUsuario,nomeNivel);
            agendarPaciente.ShowDialog();
            this.Hide();
        }
    }
}
