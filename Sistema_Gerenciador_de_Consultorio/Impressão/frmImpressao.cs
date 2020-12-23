using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegraNegocio;

namespace Sistema_Gerenciador_de_Consultorio
{
    public partial class frmImpressao : Form
    {
        /*o TipoImpressao vai definir o que vai ser impresso. tipos
        1- Profissional 
        2- Paciente
        3- Consulta
        4- Usuario
        5- Agendamento
        6- Receita
        */
        string tipoImpressaoLocal = "", idCadastroLocal = "";
        public frmImpressao(string TipoImpressao, string idCadastro)
        {
            InitializeComponent();
            this.tipoImpressaoLocal = TipoImpressao;
            this.idCadastroLocal = idCadastro;
        }
       void TipoImpressao(string tipo)
       {
            this.tpProfissional.Hide();
            tbImpressoes.TabPages.Remove(tpProfissional);
            tbImpressoes.TabPages.Remove(tpPaciente);
            tbImpressoes.TabPages.Remove(tpUsuario);
            tbImpressoes.TabPages.Remove(tpConsulta);
            tbImpressoes.TabPages.Remove(tpReceita);
            switch (tipo)
            {
                case "1":
                    ImprimirProfissional();
                    tbImpressoes.TabPages.Add(tpProfissional);
                    break;
                case "2":
                    ImprimirPaciente();
                    tbImpressoes.TabPages.Add(tpPaciente);
                    break;
                case "3":
                    ImprimirConsulta();
                    tbImpressoes.TabPages.Add(tpConsulta);
                    break;
                case "4":
                    ImprimirUsuario();
                    tbImpressoes.TabPages.Add(tpUsuario);
                    break;
                case "5":
                    ImprimirAgendamento();
                    break;
                case "6":
                    ImprimirReceita();
                    tbImpressoes.TabPages.Add(tpReceita);
                    break;
                default:
                    MessageBox.Show("Código da impressão é inválido, Tente novamente e caso o problema persista entre em contato com o suporte",
                        "Código Inválido",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    break;
            }
       }
        void ImprimirProfissional()
        {
            DataTable dadosTabela = new DataTable();
            ImpressaoProfissionalRegra pesquisar = new ImpressaoProfissionalRegra();
            dadosTabela = pesquisar.ImpressaoCompleta(idCadastroLocal);
            this.profissionalCompletoBindingSource.DataSource = dadosTabela;
            rpProfissional.RefreshReport();
            
        }
        void ImprimirPaciente()

        {
            DataTable dadosTabela = new DataTable();
            ImpressaoPacienteRegra pesquisar = new ImpressaoPacienteRegra();
            dadosTabela = pesquisar.impressaoCompleta(idCadastroLocal);
            this.pacienteCompletoBindingSource.DataSource = dadosTabela;
            this.rpPaciente.RefreshReport();
        }
        void ImprimirUsuario()
        {
            DataTable dadosTabela = new DataTable();
            ImpressaoUsuarioRegra pesquisar = new ImpressaoUsuarioRegra();
            dadosTabela = pesquisar.impressaoCompleta(idCadastroLocal);
            this.usuarioCompletoBindingSource.DataSource = dadosTabela;
            this.rpUsuario.RefreshReport();
        }
        void ImprimirConsulta()
        {

            DataTable dadosTabela = new DataTable();
            ImpressaoConsultaRegra pesquisar = new ImpressaoConsultaRegra();
            dadosTabela = pesquisar.impressaoCompleta(idCadastroLocal);
            this.consultaCompletaBindingSource.DataSource = dadosTabela;
            this.rpConsulta.RefreshReport();
        }
        void ImprimirAgendamento()
        {

        }
        void ImprimirReceita()
        {
            DataTable dadosTabela = new DataTable();
            ImpressaoReceitaRegra pesquisar = new ImpressaoReceitaRegra();
            dadosTabela = pesquisar.impressaoCompleta(idCadastroLocal);
            this.receitaCompletaBindingSource.DataSource = dadosTabela;
            this.rpReceita.RefreshReport();
        }

        private void tpProfissional_Click(object sender, EventArgs e)
        {

        }

        private void rpReceita_Load(object sender, EventArgs e)
        {
            /*
            System.Drawing.Printing.PageSettings paginaReceita = new System.Drawing.Printing.PageSettings();
            paginaReceita.Landscape = true;
            this.rpReceita.SetPageSettings(paginaReceita);
            rpReceita.RefreshReport();

            */
        }

        private void frmImpressao_Load(object sender, EventArgs e)
        {

            TipoImpressao(tipoImpressaoLocal);
        }
    }
}
