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
    public partial class frmRelatorio : Form
    {
        string idUsuario, idNivel, loginUsuario, nomeNivel;
        public frmRelatorio(string idUsuario, string idNivel, string loginUsuario, string nomeNivel)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
        }

        void CarregarStatusUsuarioNivelAcessoUsuario()
        {
            DataTable status = new DataTable();
            DataTable nivel = new DataTable();
            status = null;
            nivel = null;
            LocalizarStatusUsuarioRegra pesquisarStatus = new LocalizarStatusUsuarioRegra();
            LocalizarNivelRegra pesquisarNivel = new LocalizarNivelRegra();

            status = pesquisarStatus.TodosStatus();
            nivel = pesquisarNivel.TodosNiveis();

            cbStatusUsuario.DataSource = status;
            cbStatusUsuario.DisplayMember = "nomeStatus";

            CbNivelAcessoUsuario.DataSource = nivel;
            CbNivelAcessoUsuario.DisplayMember = "nomeNivel";
            
        
        }

        void centralizar()
        {
           
            gbProfissional.Location = new Point(this.Width / 2 - (gbProfissional.Width / 2), 32);
            gbPaciente.Location = new Point(this.Width / 2 - (gbPaciente.Width / 2), 32);
            gbUsuario.Location = new Point(this.Width / 2 - (gbUsuario.Width / 2), 32);
            gbConsulta.Location = new Point(this.Width / 2 - (gbConsulta.Width / 2), 32);

            tabControl1.Height = this.Height - 215;
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
         

            //rbProfissional.Checked = true;
            gbProfissional.Visible = true;
            tabControl1.SelectedIndex = 0;
        }

        private void btnPesquisarProfissional_Click(object sender, EventArgs e)
        {
            pesquisarProfissional();
            tabControl1.SelectedIndex = 0;
        }
        void pesquisarPaciente()
        {
            DataTable dadosTabela = new DataTable();
            RelatoriosPacienteRegra pesquisar = new RelatoriosPacienteRegra();
            if (rbTodosPaciente.Checked == true)
            {
                dadosTabela = pesquisar.TodosPacientesCadastroSimples();
                this.PacienteRelatorioBindingSource.DataSource = dadosTabela;
                this.rpPaciente.RefreshReport();
            }
            if (rbDataNascimentoPaciente.Checked == true)
            {
                dadosTabela = pesquisar.DataNascimentoPacientesCadastroSimple(dtpInicioPaciente.Value, dtpFinalPaciente.Value);
                this.PacienteRelatorioBindingSource.DataSource = dadosTabela;
                this.rpPaciente.RefreshReport();
            }
            if (rbDataCadastroPaciente.Checked == true)
            {
                dadosTabela = pesquisar.DataCadastroPacientesCadastroSimples(dtpInicioPaciente.Value, dtpFinalPaciente.Value);
                this.PacienteRelatorioBindingSource.DataSource = dadosTabela;
                this.rpPaciente.RefreshReport();
            }
        }
        private void FiltrosPaciente(object sender, EventArgs e)
        {

            dtpFinalPaciente.Visible = false;
            dtpInicioPaciente.Visible = false;
            if (rbTodosPaciente.Checked == true)
            {
                dtpInicioPaciente.Visible = true;
                dtpFinalPaciente.Visible = true;
            }
            if (rbDataNascimentoPaciente.Checked == true)
            {
                dtpInicioPaciente.Visible = true;
                dtpFinalPaciente.Visible = true;
            }
            if (rbDataCadastroPaciente.Checked == true)
            {
                dtpInicioPaciente.Visible = true;
                dtpFinalPaciente.Visible = true;
            }
        }
        void pesquisarUsuario()
        {
            DataTable dadosTabela = new DataTable();
            RelatorioBasicoUsuarioRegra pesquisarUsuario = new RelatorioBasicoUsuarioRegra();
            if (rbStatusUsuario.Checked == true)
            {
                dadosTabela = pesquisarUsuario.StatusUsuario(cbStatusUsuario.Text);
                this.RelatorioUsuarioBindingSource.DataSource = dadosTabela;
                this.rpUsuario.RefreshReport();
            }
            if (rbNivelAcessoUsuario.Checked == true)
            {
                dadosTabela = pesquisarUsuario.TodosNivelAcessoUsuarioUsuarios(CbNivelAcessoUsuario.SelectedIndex.ToString());
                this.RelatorioUsuarioBindingSource.DataSource = dadosTabela;
                this.rpUsuario.RefreshReport();
            }
            if (rbTodosUsuarios.Checked == true)
            {
                dadosTabela = pesquisarUsuario.TodosUsuarios();
                this.RelatorioUsuarioBindingSource.DataSource = dadosTabela;
                this.rpUsuario.RefreshReport();
            }
        }
        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            pesquisarUsuario();
            tabControl1.SelectedIndex = 2;
        }

        private void FiltrosUsuario(object sender, EventArgs e)
        {
            cbStatusUsuario.Visible = false;
            CbNivelAcessoUsuario.Visible = false;
            CbNivelAcessoUsuario.Enabled = true;
            cbStatusUsuario.Enabled = true;
            if (rbStatusUsuario.Checked == true)
            {
                cbStatusUsuario.Visible = true;
            }
            if (rbNivelAcessoUsuario.Checked == true)
            {
                CbNivelAcessoUsuario.Visible = true;
            }
            if (rbTodosUsuarios.Checked == true)
            {
                cbStatusUsuario.Visible = true;
                CbNivelAcessoUsuario.Enabled = false;
                cbStatusUsuario.Enabled = false;
            }
        }
        void PesquisarConsulta()
        {
            DataTable dadosTabela = new DataTable();
            RelatorioBasicoConsultaRegra pesquisar = new RelatorioBasicoConsultaRegra();
            if (rbTodosConsulta.Checked == true)
            {
                dadosTabela = pesquisar.TodasConsultas();
                this.RelatorioConsultaBindingSource.DataSource = dadosTabela;
                this.rpConsulta.RefreshReport();
            }
            if (rbDataConsulta.Checked == true)
            {
                dadosTabela = pesquisar.DataConsultaConsultas(dtpInicialConsulta.Value, dtpFinalConsulta.Value);
                this.RelatorioConsultaBindingSource.DataSource = dadosTabela;
                this.rpConsulta.RefreshReport();
            }
        }
        private void btnPesquisarPaciente_Click(object sender, EventArgs e)
        {
            pesquisarPaciente();
            tabControl1.SelectedIndex = 1;
        }

        private void btnPesquisarConsulta_Click(object sender, EventArgs e)
        {
            PesquisarConsulta();
            tabControl1.SelectedIndex = 3;
        }

        private void FiltrosConsulta(object sender, EventArgs e)
        {
            dtpInicialConsulta.Enabled = false;
            dtpFinalConsulta.Enabled = false;
            if (rbTodosConsulta.Checked == true)
            {
                dtpInicialConsulta.Enabled = false;
                dtpFinalConsulta.Enabled = false;
            }
            if (rbDataConsulta.Checked == true)
            {
                dtpInicialConsulta.Enabled = true;
                dtpFinalConsulta.Enabled = true;
            }
        }
        private void rbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            gbProfissional.Visible = false;
            gbPaciente.Visible = false;
            gbUsuario.Visible = true;
            gbConsulta.Visible = false;
            CarregarStatusUsuarioNivelAcessoUsuario();

            rbTodosUsuarios.Checked = true;
            
        }

        private void rbProfissional_CheckedChanged(object sender, EventArgs e)
        {
            gbProfissional.Visible = true;
            gbPaciente.Visible = false;
            gbUsuario.Visible = false;
            gbConsulta.Visible = false;

            rbTodosProfissional.Checked = true;
           
        }

        private void rbPaciente_CheckedChanged(object sender, EventArgs e)
        {
            gbProfissional.Visible = false;
            gbPaciente.Visible = true;
            gbUsuario.Visible = false;
            gbConsulta.Visible = false;

            rbTodosPaciente.Checked = true;
         

        }

        private void rbConsulta_CheckedChanged(object sender, EventArgs e)
        {
            gbProfissional.Visible = false;
            gbPaciente.Visible = false;
            gbUsuario.Visible = false;
            gbConsulta.Visible = true;

            rbTodosConsulta.Checked = true;
        }

        private void rbTodosProfissional_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dadosTabela = new DataTable();

            RelatorioProfissionalBasicoRegra pesquisarProfissional = new RelatorioProfissionalBasicoRegra();

            dadosTabela = pesquisarProfissional.TodosProfissionais();
            this.profissionalRelatorioBindingSource.DataSource = dadosTabela;
            this.rpProfissional.RefreshReport();

            tabControl1.SelectedIndex = 0;
        }

        private void rbTodosPaciente_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dadosTabela = new DataTable();

            RelatoriosPacienteRegra pesquisarPaciente = new RelatoriosPacienteRegra();

            dadosTabela = pesquisarPaciente.TodosPacientesCadastroSimples();
            this.PacienteRelatorioBindingSource.DataSource = dadosTabela;
            this.rpPaciente.RefreshReport();

            tabControl1.SelectedIndex = 1;
        }

        private void rbTodosUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dadosTabela = new DataTable();

            RelatorioBasicoUsuarioRegra pesquisarUsuario = new RelatorioBasicoUsuarioRegra();
            dadosTabela = pesquisarUsuario.TodosUsuarios();
            this.RelatorioUsuarioBindingSource.DataSource = dadosTabela;
            this.rpUsuario.RefreshReport();

            tabControl1.SelectedIndex = 2;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            centralizar();
        }

        private void rbTodosConsulta_CheckedChanged(object sender, EventArgs e)
        {

            DataTable dadosTabela = new DataTable();
            RelatorioBasicoConsultaRegra pesquisarConsulta = new RelatorioBasicoConsultaRegra();
            dadosTabela = pesquisarConsulta.TodasConsultas();
            this.RelatorioConsultaBindingSource.DataSource = dadosTabela;
            this.rpConsulta.RefreshReport();

            tabControl1.SelectedIndex = 3;
        }
        void pesquisarProfissional()
        {
            DataTable dadosTabela = new DataTable();
            RelatorioProfissionalBasicoRegra pesquisar = new RelatorioProfissionalBasicoRegra();
            if (rbTodosProfissional.Checked == true)
            {
                dadosTabela = pesquisar.TodosProfissionais();
                this.profissionalRelatorioBindingSource.DataSource = dadosTabela;
                this.rpProfissional.RefreshReport();
            }
            if (rbDataNascimentoProfissional.Checked == true)
            {
                dadosTabela = pesquisar.DataNascimentoProfissional(dtpInicialProfissional.Value, dtpFinalProfissional.Value);
                this.profissionalRelatorioBindingSource.DataSource = dadosTabela;
                this.rpProfissional.RefreshReport();
            }
            if (rbDataCadastroProfissional.Checked == true)
            {
                dadosTabela = pesquisar.DataCadastroProfissional(dtpInicialProfissional.Value, dtpFinalProfissional.Value);
                this.profissionalRelatorioBindingSource.DataSource = dadosTabela;
                this.rpProfissional.RefreshReport();
            }
        }
        private void FiltrosProfissional(object sender, EventArgs e)
        {
            dtpInicialProfissional.Enabled = false;
            dtpFinalProfissional.Enabled = false;
            if (rbTodosProfissional.Checked == true)
            {
                dtpFinalProfissional.Enabled = true;
                dtpInicialProfissional.Enabled = true;
            }
            if (rbDataNascimentoProfissional.Checked == true)
            {
                dtpFinalProfissional.Enabled = true;
                dtpInicialProfissional.Enabled = true;
            }
            if (rbDataCadastroProfissional.Checked == true)
            {

                dtpFinalProfissional.Enabled = true;
                dtpInicialProfissional.Enabled = true;
            }
        }
    }
}
