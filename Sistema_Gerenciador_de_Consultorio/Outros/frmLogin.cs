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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
           // posicionar();

        }
        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();//Exibe a hora no painel de login.
            //posicionar();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();//Fecha todo o programa.
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa os campos usuario e senha do painel de login.
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            loginRegra logar = new loginRegra();
            if (logar.Autenticar(txtUsuario.Text.ToUpper(), txtSenha.Text) == true)
            {
                dataGridView1.DataSource = logar.RetornarDados(txtUsuario.Text.ToUpper(), txtSenha.Text);
                string idusuario = dataGridView1.Rows[0].Cells["idUsuario"].Value.ToString();
                string idnivel = dataGridView1.Rows[0].Cells["idnivel"].Value.ToString();
                string loginusuario = dataGridView1.Rows[0].Cells["loginusuario"].Value.ToString();
                string nomenivel = dataGridView1.Rows[0].Cells["nomenivel"].Value.ToString();


                frmPrincipal novoLogin = new frmPrincipal(idusuario, idnivel, loginusuario, nomenivel);
                novoLogin.Show();
                this.Hide();
            }
        }
        private void hora_Tick(object sender, EventArgs e)
        {
            //Obetem e passa a hora atual para a lblHora no painel de login
            lblHora.Text = DateTime.Now.ToLongTimeString();

            painelBranco.Width = this.Width;
            painelBranco.Height = Convert.ToInt32((this.Height * 0.20));
            painelBranco.BackColor = Color.White;
            painelBranco.Location = new Point(0,Convert.ToInt32(this.Height*0.85));
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
