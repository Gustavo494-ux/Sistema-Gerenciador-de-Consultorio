using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Gerenciador_de_Consultorio;
using RegraNegocio;
using System.Net.Mime;

namespace Sistema_Gerenciador_de_Consultorio
{
    public partial class frmPrincipal : Form
    {
        string idUsuario, idNivel, loginUsuario, nomeNivel;
        public frmPrincipal(string idUsuario, string idNivel, string loginUsuario, string nomeNivel)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
        }
        void visibilidadePaineis()//altera a visibilidade dos paineis
        {
            //Painel cadastrar
            CadastrarPnl.Visible = false;

            //Painel pesquisar
            pesquisarPnl.Visible = false;
        }
        void DadosDeletados()
        {
            PermissoesUsuarioRegra pesquisar = new PermissoesUsuarioRegra();
            if (pesquisar.AcessarDadosDeletados(idNivel) == true) btnDadosDeletados.Visible = true;
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            DadosDeletados();

            //Altera a visibilidade dos paineis
            visibilidadePaineis();

            //posicionamento do painel de menu superior
            pnlMenuSuperior.Location = new Point(0, 0);


            //define a largura do painel de meu superior como a largura da tela em que ta sendo executada
            pnlMenuSuperior.Width = this.Width;
            btnDeslogar.Location = new Point(-(110 - this.Width), 2);
            btnUsuarios.Location = new Point(-(150 - this.Width), 2);

            pnlMenuSuperior.Visible = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Define que o painel cadastrar fica visivel e os demais invisiveis.
            visibilidadePaineis();
            CadastrarPnl.Visible = true;
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Define que o painel pesquisar fica visivel e os demais invisiveis.
            visibilidadePaineis();
            pesquisarPnl.Visible = true;
            //btnDeslogar.Width = this.Width;
            
        }
        private void btnRelatotorios_Click(object sender, EventArgs e)
        {
            frmRelatorio relatorios = new frmRelatorio(idUsuario, idNivel, loginUsuario, nomeNivel);
            relatorios.ShowDialog();
        }
        private void btncadastrarProfissional_Click(object sender, EventArgs e)
        {
            frmCadastrarProfissional novoProfissional = new frmCadastrarProfissional(idUsuario, idNivel, loginUsuario, nomeNivel);
            novoProfissional.ShowDialog();
        }
        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
            frmCadastrarPaciente novoPaciente = new frmCadastrarPaciente(idUsuario, idNivel, loginUsuario, nomeNivel);
            novoPaciente.ShowDialog();
        }
        private void btnPesquisarProfissional_Click(object sender, EventArgs e)
        {
            frmLocalizarProfissional pesquisarProfissional = new frmLocalizarProfissional(idUsuario, idNivel, loginUsuario, nomeNivel);
            pesquisarProfissional.ShowDialog();
        }
        private void btnPesquisarPaciente_Click(object sender, EventArgs e)
        {
            frmLocalizarPaciente pesquisarPaciente = new frmLocalizarPaciente(idUsuario, idNivel, loginUsuario, nomeNivel);
            pesquisarPaciente.ShowDialog();
        }
        private void btnPesquisarConsulta_Click(object sender, EventArgs e)
        {
            frmPesquisarConsulta pesquisarConsulta = new frmPesquisarConsulta(idUsuario, idNivel, loginUsuario, nomeNivel);
            pesquisarConsulta.ShowDialog();
        }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            frmAgendamento agendar = new frmAgendamento(idUsuario,idNivel,loginUsuario,nomeNivel);
            agendar.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlMenuSuperior.Width = this.Width;
            btnDeslogar.Location = new Point(-(60 - this.Width), 2);
            btnUsuarios.Location = new Point(-(100 - this.Width), 2);
        }
        private void btnDadosDeletados_Click(object sender, EventArgs e)
        {
            frmDadosDeletados dadosDeletados = new frmDadosDeletados(idUsuario,idNivel, loginUsuario, nomeNivel);
            dadosDeletados.ShowDialog();
        }
        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            frmLogin novoLogin = new frmLogin();
            novoLogin.Show();
            this.Dispose();
            this.Close();
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario novoUsuario = new frmUsuario(idUsuario, idNivel, loginUsuario, nomeNivel);
            novoUsuario.ShowDialog();
        }
        //Menu Strip
        private void profissionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarProfissional novoProfissional = new frmCadastrarProfissional(idUsuario, idNivel, loginUsuario, nomeNivel);
            novoProfissional.ShowDialog();
        }
        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarPaciente novoPaciente = new frmCadastrarPaciente(idUsuario, idNivel, loginUsuario, nomeNivel);
            novoPaciente.ShowDialog();
        }
        private void profissionalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLocalizarProfissional pesquisarProfissional = new frmLocalizarProfissional(idUsuario, idNivel, loginUsuario, nomeNivel);
            pesquisarProfissional.ShowDialog();
        }
        private void pacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLocalizarPaciente pesquisarPaciente = new frmLocalizarPaciente(idUsuario, idNivel, loginUsuario, nomeNivel);
            pesquisarPaciente.ShowDialog();
        }
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisarConsulta pesquisarConsulta = new frmPesquisarConsulta(idUsuario, idNivel, loginUsuario, nomeNivel);
            pesquisarConsulta.ShowDialog();
        }
        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgendamento agendar = new frmAgendamento(idUsuario, idNivel, loginUsuario, nomeNivel);
            agendar.ShowDialog();
        }
        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio relatorios = new frmRelatorio(idUsuario, idNivel, loginUsuario, nomeNivel);
            relatorios.ShowDialog();
        }
        private void dadosDeletatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDadosDeletados dadosDeletados = new frmDadosDeletados(idUsuario, idNivel, loginUsuario, nomeNivel);
            dadosDeletados.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario novoUsuario = new frmUsuario(idUsuario, idNivel, loginUsuario, nomeNivel);
            novoUsuario.ShowDialog();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin novoLogin = new frmLogin();
            novoLogin.Show();
            this.Dispose();
            this.Close();
        }
    }
}
