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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        void CarregarCbNIvel()
        {
            DataTable dadosTabelaForm;

            LocalizarNivelRegra pesquisarNivel = new LocalizarNivelRegra();
            dadosTabelaForm = pesquisarNivel.TodosNiveis();

            cbNivelAcesso.DisplayMember = "nomeNivel";

            cbNivelAcesso.DataSource = dadosTabelaForm;
        }
        void CarregarUsuario()
        {
            DataTable dadosTabelaForm;
            LocalizarUsuariosRegra pesquisarUsuario = new LocalizarUsuariosRegra();
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
        }
        void salvar()
        {
            CadastrarUsuarioRegra novoUsuario = new CadastrarUsuarioRegra();
            novoUsuario.Cadastrar(cbIntermediario.Text, txtNomeUsuario.Text, txtLoginUsuario.Text, txtSenha.Text, txtConfirmacaoSenha.Text, txtObservacao.Text,cbStatusUsuario.Text);
            CarregarUsuario();
        }
        void Verificar()
        {
            CadastrarUsuarioRegra novoUsuario = new CadastrarUsuarioRegra();
            novoUsuario.verificar(cbIntermediario.Text, txtNomeUsuario.Text, txtLoginUsuario.Text, txtSenha.Text, txtConfirmacaoSenha.Text, txtObservacao.Text, cbStatusUsuario.Text);
        }
    
        void CarregarDTG(DataTable dados)
        {
            //Carrega os dados no dtg
            dtgUsuario.DataSource = dados;

            //Código Usuario
            dtgUsuario.Columns[0].HeaderText = "Código";
            dtgUsuario.Columns[0].Width = 80;

            //Código Nivel
            dtgUsuario.Columns[1].HeaderText = "Nivel";
            dtgUsuario.Columns[1].Width = 130 ;

            //Nome Usuario
            dtgUsuario.Columns[2].HeaderText = "Nome";
            dtgUsuario.Columns[2].Width = 300;

            //Login do Usuario
            dtgUsuario.Columns[3].HeaderText = "Login";
            dtgUsuario.Columns[3].Width = 160;

            //Data de Cadastro
            dtgUsuario.Columns[4].HeaderText = "Data de Cadastro";
            dtgUsuario.Columns[4].Width = 160;

            //Hora de Cadastro
            dtgUsuario.Columns[5].HeaderText = "Hora de Cadastro";
            dtgUsuario.Columns[5].Width = 160;

            //Observação
            dtgUsuario.Columns[6].HeaderText = "Observação";
            dtgUsuario.Columns[6].Width = 400;

            //Status do Usuario
            dtgUsuario.Columns[7].HeaderText = "Status";
            dtgUsuario.Columns[7].Width = 207;
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
        }
        void estilo()
        {
            #region Location 

            //posicionamento do painel de menu superior 
            pnlMenuSuperior.Location = new Point(0, 0);
            //Botão Salvar
            btnSalvar.Location = new Point(20, pnlMenuSuperior.Height/2-(btnSalvar.Height/2));
            //Botão Limpar
            btnLImpar.Location = new Point(110, pnlMenuSuperior.Height / 2 - (btnSalvar.Height / 2));
            //Botão Verificar
            btnVerificar.Location = new Point(200, pnlMenuSuperior.Height / 2 - (btnSalvar.Height / 2));
            //Botão Cancelar
            btnCancelar.Location = new Point(290, pnlMenuSuperior.Height / 2 - (btnSalvar.Height / 2));
            //Painel Pesquisa
            pnlPesquisar.Location = new Point(this.Width / 2 - (pnlPesquisar.Width / 2), this.Height / 2 - ((pnlPesquisar.Height*6)/2)) ;
            //Painel Cadastrar
            pnlCadastrar.Location = new Point(this.Width / 2 - (pnlCadastrar.Width / 2), this.Height/2 - (pnlCadastrar.Height /2));
            //dtgUsuario
            dtgUsuario.Location = new Point(this.Width /2 - (dtgUsuario.Width/2), this.Height /2 - (dtgUsuario.Height *2)/4);
            //rbCadastrar
            rbCadastrarUsuario.Location = new Point(380, pnlMenuSuperior.Height / 2 - (rbCadastrarUsuario.Height / 2));
            //rBpesquisar
            rbPesquisarUsuario.Location = new Point(480, pnlMenuSuperior.Height / 2 - (rbPesquisarUsuario.Height / 2));
            #endregion

            #region Tamanho

            //define a largura do painel de meu superior como a largura da tela em que ta sendo executada 
            pnlMenuSuperior.Width = this.Width;
            //Altura do painel
            pnlMenuSuperior.Height = 70;
            //dtgUsuario
            //dtgUsuario.Height = this.Height;
            #endregion

            #region Color

            //Menu superior
            pnlMenuSuperior.BackColor = Color.FromArgb(129, 105, 215);
            //formulario
            this.BackColor = Color.FromArgb(250,250,250);

            //Colorir linhas do dtg
            int linhas = dtgUsuario.Rows.Count;
            for (int i = 0; i < linhas; i++)
            {
                dtgUsuario.Rows[i].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                i++;


                dtgUsuario.Rows[i].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            }
            
            #endregion
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CarregarCbNIvel();
            estilo();
            rbCadastrarUsuario.Checked = true;
            CarregarUsuario();
            LimparCadastro();
            CarregarStatus();
          
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarUsuarioRegra novoUsuario = new CadastrarUsuarioRegra();
            novoUsuario.Cadastrar(cbNivelAcesso.ValueMember, txtNomeUsuario.Text, txtLoginUsuario.Text, txtSenha.Text, txtConfirmacaoSenha.Text, txtObservacao.Text, cbStatusUsuario.Text);
        }
        private void cbNivelAcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dadosTabelaForm;
            LocalizarNivelRegra localizarNivel = new LocalizarNivelRegra();
            dadosTabelaForm = localizarNivel.retornaridNivel(cbNivelAcesso.Text);
            cbIntermediario.DisplayMember = "idNIvelAcesso";
            cbIntermediario.DataSource = dadosTabelaForm; ;

        }
        private void rbCadastrarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            pnlPesquisar.Visible = false;
            dtgUsuario.Visible = false;
            pnlCadastrar.Visible = true;
        }
        private void rbPesquisarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            pnlPesquisar.Visible = true;
            dtgUsuario.Visible = true;
            pnlCadastrar.Visible = false;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Verificar();
        }
    }
}
