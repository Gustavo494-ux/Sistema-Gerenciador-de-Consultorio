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
    public partial class frmPesquisarConsulta : Form
    {
        string idUsuario, idNivel, loginUsuario, nomeNivel, idProfissional;
        public frmPesquisarConsulta(string idUsuario, string idNivel, string loginUsuario, string nomeNivel)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
        }
        void estilizar()
        {
            #region PainelSuperior
            //Define a cor como um tipo de de azul escuro 
            pnlMenuSuperior.BackColor = Color.FromArgb(120, 120, 120);

            //posicionamento do lado esquerdo superior
            pnlMenuSuperior.Location = new Point(0, 0);

            //define a largura  como a largura da tela em que ta sendo executada 
            pnlMenuSuperior.Width = this.Width;
            #endregion

            #region Formulario
            //this.BackColor = Color.FromArgb(186,203,255);
            this.BackColor = Color.FromArgb(85, 86, 90);
            #endregion

            //painelExterno1.BackColor = Color.FromArgb(200, 200, 200);
            dtgConsulta.DefaultCellStyle.Font = new Font("Tahoma", 12);

            dtgConsulta.Location = new Point(this.Width / 2 - (dtgConsulta.Width / 2), this.Height / 2 - (dtgConsulta.Height / 2));
            dtgConsulta.Height = this.Height - (this.Height / 2);
            dtgConsulta.Width = this.Width;

            dtgConsulta.AutoResizeColumns();
            dtgConsulta.BackgroundColor = Color.FromArgb(85, 86, 90);
           
        }
        void RetornarIdProfissional(string idUsuario)
        {
            try
            {
                RetornarIdProfissionalRegra pesquisar = new RetornarIdProfissionalRegra();
                int id = pesquisar.idUsuario(idUsuario);
                idProfissional = Convert.ToString(id);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo idProfissional(Formulario frmPesquisarConsulta ,Método RetornarIdProfissional)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void formResponsivo()
        {
            pnlMenuSuperior.Width = this.Width;

            pnlPesquisar.Location = new Point(this.Width / 2 - (pnlPesquisar.Width / 2), 100);
        }
        void limpar()
        {
            txtPesquisar.Clear();
            rbCPF.Checked = false;
            rbIdCosulta.Checked = false;
            rbNomePaciente.Checked = false;
            rbRG.Checked = false;
        }
        void CarregarTodasConsultas()
        {
            DataTable dadosConsulta;
            try
            {
                LocalizarConsultaRegra localizarConsulta = new LocalizarConsultaRegra();
                dadosConsulta = localizarConsulta.TodasConsultas();
                esvaziarDtg();
                PreencherDtg(dadosConsulta);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método CarregarTodosProfissionais do formulario frmLocalizarProfissional, Erro:" + ex, "Erro de Pesquisa");
            }
        }
        void esvaziarDtg()
        {
            DataTable dados = new DataTable();
            dtgConsulta.Rows.Clear() ;
        }
        void PreencherDtg(DataTable dadosProfissional)
        {
            try
            {
               
                if (dtgIntermediario.Rows.Count > 0) dtgIntermediario.DataSource = null;
                dtgIntermediario.DataSource = dadosProfissional;
                if (dtgIntermediario.Rows.Count > 0)
                {
                  
                    for (int i = 0; i < dtgIntermediario.Rows.Count; i++)
                    {
                        string idConsulta = dtgIntermediario.Rows[i].Cells["idConsulta"].Value.ToString();
                        string paciente = dtgIntermediario.Rows[i].Cells["nomePaciente"].Value.ToString();
                        string profissional = dtgIntermediario.Rows[i].Cells["nomeProfissional"].Value.ToString();

                        string idProfissionalCadastro = dtgIntermediario.Rows[i].Cells["idProfissional"].Value.ToString();
                        string idUsuario = dtgIntermediario.Rows[i].Cells["idUsuario"].Value.ToString();
                        string usuarioCadastro = dtgIntermediario.Rows[i].Cells["loginUsuario"].Value.ToString();

                        string dataConsulta = dtgIntermediario.Rows[i].Cells["dataConsulta"].Value.ToString();
                        string horaConsulta = dtgIntermediario.Rows[i].Cells["horaConsulta"].Value.ToString();
                        string status = dtgIntermediario.Rows[i].Cells["statusConsulta"].Value.ToString();

                        string observacao = dtgIntermediario.Rows[i].Cells["observacaoConsulta"].Value.ToString();

                        dtgConsulta.Rows.Add(idConsulta,paciente, idProfissionalCadastro,profissional, idUsuario,usuarioCadastro,
                            dataConsulta.Substring(0, 8),horaConsulta,status,observacao);

                    }
                    int linhas = dtgConsulta.Rows.Count;
                    for (int i = 0; i < linhas; i++)
                    {
                        //dtgConsulta.Rows[i].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                        dtgConsulta.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        i++;

                    }
                    dtgConsulta.AutoResizeColumns();

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
                        CarregarTodasConsultas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método PreencherDtg do formulario frmLocalizarConsulta, Erro: " + ex.Message, "Erro de Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        void Pesquisar()
        {
            DataTable DadosConsulta;
            try
            {
                 LocalizarConsultaRegra localizarConsulta = new LocalizarConsultaRegra();
                if (rbTodos.Checked == true)
                {
                    CarregarTodasConsultas();
                }
                if (rbIdCosulta.Checked == true)
                {
                    DadosConsulta = localizarConsulta.CodigoConsulta(nudPesquisar.Text);
                    esvaziarDtg();
                    PreencherDtg(DadosConsulta);
                }
                if (rbNomePaciente.Checked == true)
                {
                    DadosConsulta = localizarConsulta.NomePaciente(txtPesquisar.Text);
                    esvaziarDtg();
                    PreencherDtg(DadosConsulta);
                }
                if (rbCPF.Checked == true)
                {
                    DadosConsulta = localizarConsulta.cpfPaciente(nudPesquisar.Text);
                    esvaziarDtg();
                    PreencherDtg(DadosConsulta);
                }
                if (rbRG.Checked == true)
                {
                    DadosConsulta = localizarConsulta.rgPaciente(nudPesquisar.Text);
                    esvaziarDtg();
                    PreencherDtg(DadosConsulta);
                }
                if (rbIdPaciente.Checked == true)
                {
                    DadosConsulta = localizarConsulta.CodigoPaciente(nudPesquisar.Text);
                    esvaziarDtg();
                    PreencherDtg(DadosConsulta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método Pesquisar do formulario FrmLocalizarPaciente, Erro:" + ex, "Erro de Pesquisa");
            }
        }
        private void atualizar_Tick(object sender, EventArgs e)
        {
            //estilizar();
            //formResponsivo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void frmPesquisarConsulta_Load(object sender, EventArgs e)
        {
            CarregarTodasConsultas();
            limpar();
            lblLoginUsuario.Text = "Usuario: " + loginUsuario + "\nNivel: " + nomeNivel;
        }

        private void dtgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string btn = dtgConsulta.Columns[e.ColumnIndex].Name;
            string idConsultaEditar = dtgConsulta.Rows[e.RowIndex].Cells["idConsulta"].Value.ToString();
            PermissoesUsuarioRegra autenticar = new PermissoesUsuarioRegra();
            switch (btn)
            {
                case "btnEditar":
                    RetornarIdProfissional(idUsuario);
                    if (autenticar.VisualizarEditarConsulta(idProfissional, dtgConsulta.Rows[e.RowIndex].Cells["idProfissionalCadastro"].Value.ToString()))
                    {
                        
                        frmCadastrarConsulta editar = new frmCadastrarConsulta(idUsuario, idNivel, loginUsuario, nomeNivel, idConsultaEditar);
                        editar.ShowDialog();
                    }
                    break;
                case "btnDeletar":
                    RetornarIdProfissional(idUsuario);
                    string idConsulta = dtgConsulta.Rows[e.RowIndex].Cells["idConsulta"].Value.ToString();
                    DialogResult confirmarDelecao = MessageBox.Show("Deseja realmente deletar está Consulta?", "Deletar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmarDelecao == DialogResult.Yes)
                    {
                        DeletarConsultaRegra deletar = new DeletarConsultaRegra();
                        deletar.DeletarConsultaIdConsulta(idUsuario, idConsulta);
                        if (MessageBox.Show("Dados Deletados Permanentemente com Sucesso!\nDeseja retorna ao formulario  principal?",
                            "Dados Deletados", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Dispose();
                        }
                        else
                        {
                            CarregarTodasConsultas();
                        }
                    }
                    break;
                case "btnImprimirReceita":
                    frmImpressao imprimirReceita = new frmImpressao("6",idConsultaEditar);
                    imprimirReceita.ShowDialog();
                    break;
                case "btnImprimirConsulta":
                    RetornarIdProfissional(idUsuario);
                    if (autenticar.VisualizarEditarConsulta(idProfissional, dtgConsulta.Rows[e.RowIndex].Cells["idProfissionalCadastro"].Value.ToString()))
                    {
                        frmImpressao imprimirConsulta = new frmImpressao("3", idConsultaEditar);
                        imprimirConsulta.ShowDialog();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            CarregarTodasConsultas();
        }

        private void filtros(object sender, EventArgs e)
        {

            nudPesquisar.Value = 0;
            txtPesquisar.Clear();
            if (rbIdCosulta.Checked == true)
            {
                nudPesquisar.Visible = true;
                txtPesquisar.Visible = false;
            }
            if (rbIdPaciente.Checked == true)
            {
                nudPesquisar.Visible = true;
                txtPesquisar.Visible = false;
            }
            if (rbNomePaciente.Checked == true)
            {
                nudPesquisar.Visible = false;
                txtPesquisar.Visible = true;
            }
            if (rbCPF.Checked == true)
            {
                nudPesquisar.Visible = true;
                txtPesquisar.Visible = false;
            }
            if (rbRG.Checked == true)
            {
                nudPesquisar.Visible = true;
                txtPesquisar.Visible = false;
            }
            if (rbTodos.Checked == true)
            {
                CarregarTodasConsultas();
 
            }
        }

        private void dtgConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}
