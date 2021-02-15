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
    public partial class frmImprimirDados : Form
    {
        /*
        o TipoImpressao vai definir o que vai ser impresso. tipos
        1- Profissional 
        2- Paciente
        3- Consulta
        4- Usuario
        5- Agendamento
        6- Receita
        */
        string nomeFonte = "Arial", tamanhoFonte="12", estiloFonte = "Regular";
        string tipoImpressao, idCadastro;
        public frmImprimirDados(string TipoImpressao, string idCadastro)
        {
            InitializeComponent();
            this.tipoImpressao = TipoImpressao;
            this.idCadastro = idCadastro;
        }
        private void frmImprimirDados_Load(object sender, EventArgs e)
        {
            CarregarListaImpressoras();
            //CarregarListaFonte();
            TipoImpressao(tipoImpressao);
            pnlReceita.Visible = false;
        }
        //MenuStrip msMenuSuperior
        private void voltarMsMenuSuperior_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void selecionarFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarregarListaFonte();
        }
        private void imprimirDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewReceita.Document = PrintDocumentReceita;


            PrintPreviewReceita.Width = Screen.PrimaryScreen.Bounds.Width;
            PrintPreviewReceita.Height = Screen.PrimaryScreen.Bounds.Height;
            PrintPreviewReceita.ShowDialog();
        }

        //Funções
        private void CarregarListaImpressoras()
        {
            cbImpressoras.Items.Clear();
            cbImpressoras.Text = "Selecionar Impressora";
            foreach (var impressora in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbImpressoras.Items.Add(impressora);
            }
        }
        private void CarregarListaFonte()
        {
            FontDialog fonte = new FontDialog();
            fonte.ShowDialog();

            nomeFonte = fonte.Font.FontFamily.Name.ToString();
            tamanhoFonte = fonte.Font.Size.ToString();
            estiloFonte = fonte.Font.Style.ToString();

            txtNomeFont.Text = nomeFonte;
            txtTamanhoFont.Text = tamanhoFonte;
            txtEstiloFont.Text = estiloFonte;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlReceita.Location = new Point(this.Width / 2 - (pnlReceita.Width / 2), 90);

            lblNomeProfissional.Location = new Point(pnlReceita.Width / 2 - (lblNomeProfissional.Width / 2), 444);
            lblLinha.Location = new Point(pnlReceita.Width / 2 - (lblLinha.Width / 2), 414);
        }

        private void PrintDocumentReceita_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap receitaBitmap = new Bitmap(this.pnlReceita.Width, this.pnlReceita.Height);
            pnlReceita.DrawToBitmap(receitaBitmap, new Rectangle(0, 0, this.pnlReceita.Width, this.pnlReceita.Height));
            e.Graphics.DrawImage(receitaBitmap,40,10);
        }

        private void RetornarReceita(string idConsulta)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                ImpressaoReceitaRegra receita = new ImpressaoReceitaRegra();
                dadosTabela = receita.impressaoCompleta(idConsulta);

                if (dadosTabela.Rows.Count > 0)
                {
                    string[] olhoRxFinal = { "VL OD", "VL OE", "VP OD", "VP OE" };

                    string[,] MatrizRxFinal = new string[4, 6];

                    string[] dataConsulta = dadosTabela.Rows[0]["dataConsulta"].ToString().Split(' ') ;

                   lblCodigoPacienteConsultaDataConsulta.Text = "Código Paciente: "+ dadosTabela.Rows[0]["idPaciente"].ToString()+ 
                        "       Código Consulta: "+ dadosTabela.Rows[0]["idConsulta"].ToString() + "        Data Consulta: "
                        + dataConsulta[0]+"     Hora Consulta:  "+dadosTabela.Rows[0]["horaConsulta"];

                    lblNomePaciente.Text = "Paciente: "+dadosTabela.Rows[0]["nomePaciente"].ToString();

                    MatrizRxFinal[0, 0] = Convert.ToString(dadosTabela.Rows[0]["esferaVlOd"]);
                    MatrizRxFinal[1, 0] = Convert.ToString(dadosTabela.Rows[0]["esferaVlOe"]);
                    MatrizRxFinal[2, 0] = Convert.ToString(dadosTabela.Rows[0]["esferaVpOd"]);
                    MatrizRxFinal[3, 0] = Convert.ToString(dadosTabela.Rows[0]["esferaVpOe"]);


                    MatrizRxFinal[0, 1] = Convert.ToString(dadosTabela.Rows[0]["cilindroVlOd"]);
                    MatrizRxFinal[1, 1] = Convert.ToString(dadosTabela.Rows[0]["cilindroVlOe"]);
                    MatrizRxFinal[2, 1] = Convert.ToString(dadosTabela.Rows[0]["cilindroVpOd"]);
                    MatrizRxFinal[3, 1] = Convert.ToString(dadosTabela.Rows[0]["cilindroVpOe"]);

                    MatrizRxFinal[0, 2] = Convert.ToString(dadosTabela.Rows[0]["eixoVlOd"]);
                    MatrizRxFinal[1, 2] = Convert.ToString(dadosTabela.Rows[0]["eixoVlOe"]);
                    MatrizRxFinal[2, 2] = Convert.ToString(dadosTabela.Rows[0]["eixoVpOd"]);
                    MatrizRxFinal[3, 2] = Convert.ToString(dadosTabela.Rows[0]["eixoVpOe"]);

                    MatrizRxFinal[0, 3] = Convert.ToString(dadosTabela.Rows[0]["AvVlOd"]);
                    MatrizRxFinal[1, 3] = Convert.ToString(dadosTabela.Rows[0]["AvVlOe"]);
                    MatrizRxFinal[2, 3] = Convert.ToString(dadosTabela.Rows[0]["AvVpOd"]);
                    MatrizRxFinal[3, 3] = Convert.ToString(dadosTabela.Rows[0]["AvVpOe"]);

                    lblTranscricaoLentes.Text ="Transcrição Lentes: "+ dadosTabela.Rows[0]["transcricaoLentes"].ToString();
                    lblObservacaoReceita.Text = "Observação: "+ dadosTabela.Rows[0]["observacaoReceita"].ToString();

                    lblNomeProfissional.Text = dadosTabela.Rows[0]["nomeProfissional"].ToString();
                    lblConselhoClasse.Text = dadosTabela.Rows[0]["croo"].ToString();


                    dtgRxFinal.Rows.Clear();
                    for (int l = 0; l < 4; l++)//linha 
                    {
                        dtgRxFinal.Rows.Add(olhoRxFinal[l], MatrizRxFinal[l, 0], MatrizRxFinal[l, 1], MatrizRxFinal[l, 2], MatrizRxFinal[l, 3]);
                    }
                    for (int i = 0; i < dtgRxFinal.Rows.Count; i++)
                    {
                        dtgRxFinal.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        dtgRxFinal.ForeColor = Color.Black;
                        i++;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo RxFinal(Formulario frmImprimirDados, Método RetornarReceita)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EstilizacaoReceita()
        {
        }
        void TipoImpressao(string tipo)
        {
            pnlReceita.Visible = false;
            switch (tipo)
            {
                case "1"://Imprimir Profissional
                    //ImprimirProfissional();
                    //tbImpressoes.TabPages.Add(tpProfissional);
                    break;
                case "2"://Imprimir Paciente
                    //ImprimirPaciente();
                    //tbImpressoes.TabPages.Add(tpPaciente);
                    break;
                case "3"://ImprimirConsulta
                    //ImprimirConsulta();
                    //tbImpressoes.TabPages.Add(tpConsulta);
                    break;
                case "4"://Imprimir Usuário
                    //ImprimirUsuario();
                    //tbImpressoes.TabPages.Add(tpUsuario);
                    break;
                case "5"://Imprimir Agendamento
                    //ImprimirAgendamento();
                    break;
                case "6"://Imprimir Receita
                    pnlReceita.Visible = true;
                    RetornarReceita(idCadastro);
                    break;
                default:
                    MessageBox.Show("Código da impressão é inválido, Tente novamente e caso o problema persista entre em contato com o suporte",
                        "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
