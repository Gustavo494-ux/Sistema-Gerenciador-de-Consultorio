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
using Npgsql;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Sistema_Gerenciador_de_Consultorio
{
    public partial class frmLocalizarProfissional : Form
    {
        string idUsuarioSistema, idNivel, loginUsuario, nomeNivel;
        public frmLocalizarProfissional(string idUsuario, string idNivel, string loginUsuario, string nomeNivel)
        {
            InitializeComponent();
            this.idUsuarioSistema = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
        }
        private void frmLocalizarProfissional_Load(object sender, EventArgs e)
        {
            pnlPesquisar.Location = new Point(this.Width / 2 - (pnlPesquisar.Width / 2), 50);
            limpar();
            lblLoginUsuario.Text = "Usuario: " + loginUsuario+"\nNivel: "+nomeNivel;
            rbSemFiltros.Checked = true;
        }
        #region Metodos
        void Pesquisar()
        {
            DataTable dadosProfissional;
            try
            {
                LocalizarProfissionalRegra PesquisaProfissional = new LocalizarProfissionalRegra();
                if (rbIdProfissional.Checked == true)
                {
                    int cod = Convert.ToInt32(nudPesquisar.Text);
                    dadosProfissional = PesquisaProfissional.CodigoProfissional(cod);
                    esvaziardtg();
                    PreencherDtg(dadosProfissional);
                }
                if (rbNome.Checked == true)
                {
                    dadosProfissional = PesquisaProfissional.NomeProfissional(txtPesquisar.Text);
                    esvaziardtg();
                    PreencherDtg(dadosProfissional);
                }
                if (rbCPF.Checked == true)
                {
                    dadosProfissional= PesquisaProfissional.CpfProfissional(nudPesquisar.Text);
                    esvaziardtg();
                    PreencherDtg(dadosProfissional);
                }
                if (rbCroo.Checked == true)
                {
                    dadosProfissional = PesquisaProfissional.CrooProfissional(nudPesquisar.Text);
                    esvaziardtg();
                    PreencherDtg(dadosProfissional);
                }
                if (rbRG.Checked == true)
                {
                    dadosProfissional = PesquisaProfissional.RgProfissional(nudPesquisar.Text);
                    esvaziardtg();
                    PreencherDtg(dadosProfissional);
                }
                if (rbEspecialidade.Checked == true)
                {
                    dadosProfissional = PesquisaProfissional.EspecialidadeProfissional(txtPesquisar.Text);
                    esvaziardtg();
                    PreencherDtg(dadosProfissional);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método Pesquisar do formulario frmLocalizarProfissional, Erro:" + ex, "Erro de Pesquisa");
            }
        }
        void limpar()
        {
            txtPesquisar.Clear();
            rbSemFiltros.Checked = true;
            nudPesquisar.Value = 0;
            CarregarTodosProfissionais();
        }
        void CarregarTodosProfissionais()
        {
            esvaziardtg();
            DataTable dadosProfissional;
            try
            {
                LocalizarProfissionalRegra PesquisaProfissional = new LocalizarProfissionalRegra();
                dadosProfissional = PesquisaProfissional.TodosProfissionais();

                PreencherDtg(dadosProfissional);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método CarregarTodosProfissionais do formulario frmLocalizarProfissional, Erro:" + ex, "Erro de Pesquisa");
            }
        }
        void esvaziardtg()
        {
            DataTable table = new DataTable();
            dtgProfissional.DataSource = table;
        }
        void PreencherDtg(DataTable dadosProfissional)
        {
            try
            {
                dtgProfissional.DataSource = null;

                dtgIntermediario.DataSource = dadosProfissional;
                string[] arrayNascimento = new string[2];
                string[] arrayCadastro = new string[2];
                if (dtgIntermediario.Rows.Count > 0)
                {
                    for (int i = 0; i < dtgIntermediario.Rows.Count; i++)
                    {
                        string idProfissional = dtgIntermediario.Rows[i].Cells["idProfissional"].Value.ToString();
                        string idEndereco = dtgIntermediario.Rows[i].Cells["idEndereco"].Value.ToString();
                        string idContato = dtgIntermediario.Rows[i].Cells["idContato"].Value.ToString();
                        string idUsuario = dtgIntermediario.Rows[i].Cells["idUsuario"].Value.ToString();

                        string nomeProfissional = dtgIntermediario.Rows[i].Cells["nomeProfissional"].Value.ToString();
                        string especilidade = dtgIntermediario.Rows[i].Cells["especialidade"].Value.ToString();
                        string rg = dtgIntermediario.Rows[i].Cells["rg"].Value.ToString();
                        string CPF = dtgIntermediario.Rows[i].Cells["cpf"].Value.ToString();
                        string sexo = dtgIntermediario.Rows[i].Cells["sexo"].Value.ToString();
                        string croo = dtgIntermediario.Rows[i].Cells["croo"].Value.ToString();
                        string dataNascimento = dtgIntermediario.Rows[i].Cells["dataNascimento"].Value.ToString();
                        string dataCadastro = dtgIntermediario.Rows[i].Cells["dataCadastro"].Value.ToString();
                        string horaCadastro = dtgIntermediario.Rows[i].Cells["horaCadastro"].Value.ToString();
                        string observacao = dtgIntermediario.Rows[i].Cells["observacaoProfissional"].Value.ToString();

                        string CPF1 = "";
                        if (CPF.Length == 11)
                        {
                            CPF1 = CPF[0] + "" + CPF[1] + "" + CPF[2] + "." + CPF[3] + "" + CPF[4] + "" + CPF[5] + "." + CPF[6] + "" + CPF[7] + "" + CPF[8] + "-" + CPF[9] + "" + CPF[10];
                        }
                        CPF = CPF1.Trim();
                        if (dataCadastro.Length>10)
                        {
                            arrayCadastro = dataCadastro.Split();
                            dataCadastro = arrayCadastro[0];
                        }
                        if (dataNascimento.Length>10)
                        {
                            arrayNascimento = dataNascimento.Split();
                            dataNascimento = arrayNascimento[0];
                        }
                        dtgProfissional.Rows.Add(idProfissional, idEndereco, idContato, idUsuario, nomeProfissional, especilidade, rg, CPF, sexo, croo,
                            dataNascimento/*.Substring(0,8)*/, dataCadastro/*.Substring(0, 8)*/, horaCadastro, observacao);
                        //dtgProfissional.Columns["dataCadastro"].Width = 110;
                    }
                    dtgProfissional.AutoResizeColumns();
                }
                else
                {
                    DialogResult confirm = MessageBox.Show("Registros não encontrados, Deseja realizar uma nova pesquisa? \n\n Caso seja preciso contate o suporte!", "Dados Ausentes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirm == DialogResult.No)
                    {
                        this.Dispose();
                    }
                    else
                    {
                        CarregarTodosProfissionais();
                    }
                }
                for (int i = 0; i < dtgProfissional.Rows.Count; i++)
                {
                    //dtgProfissional.Rows[i].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                    dtgProfissional.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método PreencherDtg do formulario frmLocalizarProfissional, Erro: " + ex.Message, "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void dtgIntermediario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //frmPrincipal voltar = new frmPrincipal(idUsuarioSistema, idNivel, loginUsuario, nomeNivel);
            //voltar.Show();
            this.Dispose();
        }

        private void filtros(object sender, EventArgs e)
        {
            nudPesquisar.Value = 0;
            txtPesquisar.Clear();
            if (rbIdProfissional.Checked == true)
            {
                nudPesquisar.Visible = true;
                txtPesquisar.Visible = false;
            }
            if (rbNome.Checked == true)
            {
                nudPesquisar.Visible = false;
                txtPesquisar.Visible = true;
            }
            if (rbCPF.Checked == true)
            {
                nudPesquisar.Visible = true;
                txtPesquisar.Visible = false;
            }
            if (rbCroo.Checked == true)
            {
                nudPesquisar.Visible = true;
                txtPesquisar.Visible = false;
            }
            if (rbRG.Checked == true)
            {
                nudPesquisar.Visible = true;
                txtPesquisar.Visible = false;
            }
            if (rbEspecialidade.Checked == true)
            {
                nudPesquisar.Visible = false;
                txtPesquisar.Visible = true;
            }
            if (rbSemFiltros.Checked == true)
            {
                if (rbSemFiltros.Checked == true)
                {
                    CarregarTodosProfissionais();
                }
            }
        }

        private void dtgProfissional_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dtgProfissional.Columns[e.ColumnIndex].Name == "btnImprimir")
            {
                frmImpressao imprimir = new frmImpressao("1", dtgProfissional.Rows[e.RowIndex].Cells["idProfissional"].Value.ToString());
                imprimir.ShowDialog();
            }
            if (dtgProfissional.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                string idProfissional = dtgIntermediario.Rows[e.RowIndex].Cells["idProfissional"].Value.ToString();
                frmCadastrarProfissional editar = new frmCadastrarProfissional(idUsuarioSistema, idNivel, loginUsuario, nomeNivel, idProfissional);
                editar.ShowDialog();
               
            }
            if (dtgProfissional.Columns[e.ColumnIndex].Name == "btnDeletar")
            {

                DialogResult confirmarDelecao = MessageBox.Show("Deseja realmente deletar o Endereço, Contato, Consulta e todos os dados relacionados a este Profissional ?", "Deletar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmarDelecao == DialogResult.Yes)//Profissional
                {
                    DeletarProfissionalRegra delProfissinal = new DeletarProfissionalRegra();
                    bool ProfissionalConfirm = delProfissinal.idProfissional(idUsuarioSistema, dtgProfissional.Rows[e.RowIndex].Cells["idProfissional"].Value.ToString());

                    //Consulta
                    DeletarConsultaRegra delConsulta = new DeletarConsultaRegra();
                    bool consultaConfirm = delConsulta.DeletarConsultaIdProfissional(idUsuarioSistema, dtgProfissional.Rows[e.RowIndex].Cells["idProfissional"].Value.ToString());


                    if (ProfissionalConfirm == true && consultaConfirm == true)
                    {
                        if (MessageBox.Show("Dados Deletados Permanentemente com Sucesso!\nDeseja retornar ao formulario principal?", "Dados Deletados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            frmPrincipal editar = new frmPrincipal(idUsuarioSistema, idNivel, loginUsuario, nomeNivel);
                            this.Dispose();
                        }
                        else
                        {
                            CarregarTodosProfissionais();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Os Dados não foram deletados corretamente!", "Dados não deletados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void rbSemFiltros_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSemFiltros.Checked == true)
            {
                CarregarTodosProfissionais();
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void rbSemFiltros_CheckedChanged_1(object sender, EventArgs e)
        {
            CarregarTodosProfissionais();
        }
    } 
}
