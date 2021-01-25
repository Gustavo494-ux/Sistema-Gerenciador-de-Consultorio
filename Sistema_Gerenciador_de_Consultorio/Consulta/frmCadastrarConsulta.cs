using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegraNegocio;

namespace Sistema_Gerenciador_de_Consultorio
{
    public partial class frmCadastrarConsulta : Form
    {
        PermissoesUsuarioRegra aunteUsuario = new PermissoesUsuarioRegra();
        DataTable esvaziar = null;
        //Variaveis do formulario
        string idConsulta = "0",idProfissional ="0";
        //Dados usuario do sistema
        string idUsuarioSistema, idNivel, loginUsuario, nomeNivel;
        //Dados Paciente
        string idPaciente, idContato, idEndereco, idUsuarioCadastro, nomePaciente, nomeResponsavel,
        RG, CPF, OCUPACAO, IDADE, SEXO, dataNascimento, dataCadastro, horaCadastro, observacaoPaciente;
        DataTable tableVazia = new DataTable();

        public frmCadastrarConsulta(string idUsuario, string idNivel, string loginUsuario, string nomeNivel,int idPaciente)
        {
            InitializeComponent();
            this.idUsuarioSistema = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
            this.idPaciente = idPaciente.ToString();
        }
        public frmCadastrarConsulta(string idUsuario, string idNivel, string loginUsuario, string nomeNivel, string idConsulta)
        {
            InitializeComponent();
            this.idUsuarioSistema = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
            this.idConsulta = idConsulta;
        }
        public frmCadastrarConsulta(ConstrutorPaciente construtor)
        {
            //Dados do Usuario do Sistema
            this.idUsuarioSistema = construtor.IdUsuario;
            this.idNivel = construtor.IdNivel ;
            this.loginUsuario = construtor.LoginUsuario;
            this.nomeNivel = construtor.NomeNivel;
            //Dados do Paciente
            this.idPaciente = construtor.IdPaciente;
            this.idContato = construtor.IdContato;
            this.idEndereco = construtor.IdEndereco;
            this.idUsuarioCadastro = construtor.IdUsuarioCadastro;
            this.nomePaciente = construtor.NomePaciente;
            this.nomeResponsavel = construtor.NomeResponsavel;
            this.RG = construtor.Rg;
            this.CPF =construtor.Cpf;
            this.OCUPACAO = construtor.Ocupacao;
            this.IDADE = construtor.Idade;
            this.SEXO = construtor.Sexo;
            this.dataNascimento = construtor.DataNascimento;
            this.dataCadastro = construtor.DataCadastro;
            this.horaCadastro = construtor.HoraCadastro;
            this.observacaoPaciente = construtor.ObservacaoPaciente;
            InitializeComponent();
        }
        #region Métodos de edição
        bool EditarAcuidadeVisual(string idConsulta)
        {
            try
            {
                AcuidadeVisualRegra editarAcuidade = new AcuidadeVisualRegra();

                //visão de longe
                string vlOdSg = Convert.ToString(dtgAcuidadeVisual.Rows[0].Cells["sgVlAcuidadeVisual"].Value);
                string vlOeSg = Convert.ToString(dtgAcuidadeVisual.Rows[1].Cells["sgVlAcuidadeVisual"].Value);
                string vlAoSg = Convert.ToString(dtgAcuidadeVisual.Rows[2].Cells["sgVlAcuidadeVisual"].Value);

                string vlPh = Convert.ToString(dtgAcuidadeVisual.Rows[1].Cells["phVlAcuidadeVisual"].Value);

                string vlOdCc = Convert.ToString(dtgAcuidadeVisual.Rows[0].Cells["ccVlAcuidadeVisual"].Value);
                string vlOeCc = Convert.ToString(dtgAcuidadeVisual.Rows[1].Cells["ccVlAcuidadeVisual"].Value);
                string vlAoCc = Convert.ToString(dtgAcuidadeVisual.Rows[2].Cells["ccVlAcuidadeVisual"].Value);

                //Visão de perto 
                string vpOdSc = Convert.ToString(dtgAcuidadeVisual.Rows[0].Cells["scVpAcuidadeVisual"].Value);
                string vpOeSc = Convert.ToString(dtgAcuidadeVisual.Rows[1].Cells["scVpAcuidadeVisual"].Value);
                string vpAoSc = Convert.ToString(dtgAcuidadeVisual.Rows[2].Cells["scVpAcuidadeVisual"].Value);

                string vpOdCc = Convert.ToString(dtgAcuidadeVisual.Rows[0].Cells["ccVpAcuidadeVisual"].Value);
                string vpOeCc = Convert.ToString(dtgAcuidadeVisual.Rows[1].Cells["ccVpAcuidadeVisual"].Value);
                string vpAoCc = Convert.ToString(dtgAcuidadeVisual.Rows[2].Cells["ccVpAcuidadeVisual"].Value);

                bool confirm = editarAcuidade.Editar(Convert.ToInt32(idConsulta), vlOdSg, vlOeSg, vlAoSg, vlPh, vlOdCc, vlOeCc, vlAoCc,
                    vpOdSc, vpOeSc, vpAoSc, vpOdCc, vpOeCc, vpAoCc, txtTipoOptotipo.Text);
                return confirm;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao editar os dados da Acuidade Visual(Formulario frmCadastrarConsulta, Método EditarAcuidadeVisual)",
                    "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditaAnamnese(string idConsulta)
        {
            try
            {
                AnamneseRegra editarAnamnese = new AnamneseRegra();
                bool confirm = editarAnamnese.Editar(Convert.ToInt32(idConsulta), txtMotivoConsulta.Text, txtTempoQueixa.Text, txtObservacaoAnamnese.Text);
                return confirm;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao Editar a Anamnese(Formulario frmCadastrarConsulta, Método EditarAnamnese)",
                    "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarAntecedentesGerais(string idConsulta)
        {
            try
            {
                AntecedentesGeraisRegra editarAntecedentesGerais = new AntecedentesGeraisRegra();
                string vasculares = "", vascularesTratamento = "";
                string diabetes = "", diabetesTratamento = "";
                string imunes = "", imunesTratamento = "";
                string neurologicos = "", neurologicosTratamento = "";
                string outros = "", outrosConfirm = "", outrosTratamento = "";

                bool Pessoal;
                Pessoal = false;
                bool Familiar;
                Familiar = false;
                int linhas = dtgAntecedentesGerais.Rows.Count;
                for (int i = 0; i < 5; i++)
                {
                    Familiar = Convert.ToBoolean(dtgAntecedentesGerais.Rows[i].Cells["familiarAntecedentesGerais"].Value);
                    Pessoal = Convert.ToBoolean(dtgAntecedentesGerais.Rows[i].Cells["pessoalAntecedentesGerais"].Value);
                    //Vasculares
                    if (i == 0)
                    {
                        if (Pessoal == true && Familiar == true)
                        {
                            vasculares = "PF";
                            vascularesTratamento = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["tipoTratamentoAntecedentesGerais"].Value);
                        }
                        else
                        {
                            if (Pessoal == true) vasculares = "P";
                            if (Familiar == true) vasculares = "F";
                            if (Pessoal == false && Familiar == false) vasculares = "FF";
                        }
                        vascularesTratamento = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["tipoTratamentoAntecedentesGerais"].Value);
                    }
                    //Diabeyes
                    if (i == 1)
                    {
                        if (Pessoal == true && Familiar == true) diabetes = "PF";
                        else
                        {
                            if (Pessoal == true) diabetes = "P";
                            if (Familiar == true) diabetes = "F";
                            if (Pessoal == false && Familiar == false) diabetes = "FF";
                        }
                        diabetesTratamento = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["tipoTratamentoAntecedentesGerais"].Value);
                    }
                    //imunes
                    if (i == 2)
                    {
                        if (Pessoal == true && Familiar == true) imunes = "PF";
                        else
                        {
                            if (Pessoal == true) imunes = "P";
                            if (Familiar == true) imunes = "F";
                            if (Pessoal == false && Familiar == false) imunes = "FF";
                        }
                        imunesTratamento = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["tipoTratamentoAntecedentesGerais"].Value);
                    }
                    //neurologicos
                    if (i == 3)
                    {
                        if (Pessoal == true && Familiar == true) neurologicos = "PF";
                        else
                        {
                            if (Pessoal == true) neurologicos = "P";
                            if (Familiar == true) neurologicos = "F";
                            if (Pessoal == false && Familiar == false) neurologicos = "FF";
                        }
                        neurologicosTratamento = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["tipoTratamentoAntecedentesGerais"].Value);
                    }
                    //outros
                    if (i == 4)
                    {
                        if (Pessoal == true) outrosConfirm = "P";
                        if (Familiar == true) outrosConfirm = "F";
                        if (Pessoal == false && Familiar == false) outrosConfirm = "FF";

                        outros = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["patologiaAntecedentesGerais"].Value);
                        outrosTratamento = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["tipoTratamentoAntecedentesGerais"].Value);
                    }
                }
                return editarAntecedentesGerais.Editar(Convert.ToInt32(idConsulta), vasculares, vascularesTratamento, diabetes, diabetesTratamento, imunes, imunesTratamento, neurologicos,
                    neurologicosTratamento, outros, outrosConfirm, outrosTratamento, txtObservacaoAntecedentesGerais.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao editar os Antecedentes Gerais(Formulario frmCadastrarConsulta, Método EditarAntecedentesGerais)",
                    "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarAntecedentesOculares(string idConsulta)
        {
            try
            {
                AntecedentesOcularesRegra antecedentesOcularesRegra = new AntecedentesOcularesRegra();
                bool[] possuir = new bool[15];
                string[] tratamento = new string[15];
                string outros = "", outrosConfirm ="";
                int linhas = dtgAntecedentesOculares.Rows.Count;

                for (int i = 0; i < possuir.Length; i++)
                {
                    possuir[i] = false;
                    tratamento[i] = "";
                }
                //confirmacaoPatologiaAntecedentesOculares
                //patologiaAntecedentesOculares
                //TipoTratamentoAntecedentesOculares
                for (int i = 0; i < linhas; i++)
                {
                    if (i < linhas)
                    {
                        bool teste = false;
                        teste = Convert.ToBoolean(dtgAntecedentesOculares.Rows[i].Cells["confirmacaoPatologiaAntecedentesOculares"].Value);
                        possuir[i] = teste;
                        tratamento[i] = Convert.ToString(dtgAntecedentesOculares.Rows[i].Cells["TipoTratamentoAntecedentesOculares"].Value);
                    }
                    if (i == linhas - 1)
                    {
                        outros = Convert.ToString(dtgAntecedentesOculares.Rows[i].Cells["patologiaAntecedentesOculares"].Value);
                        outrosConfirm = Convert.ToString(dtgAntecedentesOculares.Rows[i].Cells["confirmacaoPatologiaAntecedentesOculares"].Value);
                    }
                }
                bool antecedentesOculares = antecedentesOcularesRegra.Editar(Convert.ToInt32(idConsulta), possuir[0], tratamento[0], possuir[1], tratamento[1], possuir[2], tratamento[2], possuir[3], tratamento[3], possuir[4], tratamento[4],
                    possuir[5], tratamento[5], possuir[6], tratamento[6], possuir[7], tratamento[7], possuir[8], tratamento[8], possuir[9], tratamento[9], possuir[10], tratamento[10],
                    possuir[11], tratamento[11], possuir[12], tratamento[12], possuir[13], tratamento[13], outros, outrosConfirm, tratamento[14]);
                return antecedentesOculares;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os Antecedentes Oculares(Formulario frmCadastrarConsulta, Método EditarAntecedentesOculares)",
                    "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarOftalmoscopia(string idConsulta)
        {
            try
            {
                OftalmoscopiaRegra editarOftalmoscopoia = new OftalmoscopiaRegra();
                bool oftalmoscopia = editarOftalmoscopoia.Editar(Convert.ToInt32(idConsulta), txtDistanciaBrucknerOftalmoscopia.Text, txtPapilaOdOftalmoscopia.Text, txtPapilaOeOftalmoscopia.Text, txtEscavacaoOdOftalmoscopia.Text,
                    txtEscavacaoOeOftalmoscopia.Text, txtMaculaOdOftalmoscopia.Text, txtMaculaOeOftalmoscopia.Text, txtFixacaoOdOftalmoscopia.Text, txtFixacaoOeOftalmoscopia.Text,
                    txtRelacaoAVOdOftalmoscopia.Text, txtRelacaoAVOeOftalmoscopia.Text, txtCorOdOftalmoscopia.Text, txtCorOeOftalmoscopia.Text, txtLenteOdOftalmoscopia.Text,
                    txtLenteOeOftalmoscopia.Text, txtObservacaoOftalmoscopia.Text);
                return oftalmoscopia;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Oftalmoscopia(Formulario frmCadastrarConsulta, Método editarOftalmoscopia)",
                    "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarRxFinal(string idConsulta)
        {
            try
            {
                RxFinalRegra editarRxFinal = new RxFinalRegra();
                string[,] ArrayRxFinal = new string[4, 4];
                string[] colunas = { "EsferaRxFinal", "cilindroRxFinal", "eixoRxFinal", "AvRxFinal" };
                for (int l = 0; l < 4; l++)//linha 
                {
                    for (int c = 0; c < 4; c++)//coluna
                    {
                        ArrayRxFinal[l, c] = Convert.ToString(dtgRxFinal.Rows[l].Cells[colunas[c]].Value);
                    }
                }

                bool rxFinal = editarRxFinal.Editar(idConsulta,
                    ArrayRxFinal[0, 0], ArrayRxFinal[1, 0], ArrayRxFinal[2, 0], ArrayRxFinal[3, 0],//Esfera
                    ArrayRxFinal[0, 1], ArrayRxFinal[1, 1], ArrayRxFinal[2, 1], ArrayRxFinal[3, 1],//Cilindro
                    ArrayRxFinal[0, 2], ArrayRxFinal[1, 2], ArrayRxFinal[2, 2], ArrayRxFinal[3, 2],//Eixo

                    ArrayRxFinal[0, 3], ArrayRxFinal[1, 3], ArrayRxFinal[2, 3], ArrayRxFinal[3, 3],//Adicao
                   txtAdicaoRxFinal.Text, txtDpRxFinal.Text, txtTipoMaterialRxFinal.Text, txtCorRxFinal.Text,
                  txtUsoRxFinal.Text, txtTipoLenteRxFinal.Text, txtObservacaoRxFinal.Text);
                return rxFinal;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o RxFinal(Formulario frmCadastrarConsula, método EditarRxFinal)",
                    "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarRxInicial(string idConsulta)
        {
            try
            {
                RxInicialRegra editarRxInicial = new RxInicialRegra();
                string[,] ArrayRxInicial = new string[4, 4];
                string[] colunas = { "EsferaRxInicial", "cilindroRxInicial", "eixoRxInicial", "AvRxInicial" };
                for (int l = 0; l < 4; l++)//linha 
                {
                    for (int c = 0; c < 4; c++)//coluna
                    {
                        ArrayRxInicial[l, c] = Convert.ToString(dtgRxInicial.Rows[l].Cells[colunas[c]].Value);
                    }
                }

                bool RxInicial = editarRxInicial.Editar(idConsulta,
                    ArrayRxInicial[0, 0], ArrayRxInicial[1, 0], ArrayRxInicial[2, 0], ArrayRxInicial[3, 0],//Esfera
                    ArrayRxInicial[0, 1], ArrayRxInicial[1, 1], ArrayRxInicial[2, 1], ArrayRxInicial[3, 1],//Cilindro
                    ArrayRxInicial[0, 2], ArrayRxInicial[1, 2], ArrayRxInicial[2, 2], ArrayRxInicial[3, 2],//Eixo

                    ArrayRxInicial[0, 3], ArrayRxInicial[1, 3], ArrayRxInicial[2, 3], ArrayRxInicial[3, 3],//Av
                    txtAdicaoRxInicial.Text, txtDpRxInicial.Text, txtTipoMaterialRxInicial.Text, txtCorRxInicial.Text,
                  txtUsoRxInicial.Text, txtTipoLenteRxInicial.Text, txtObservacaoRxInicial.Text);
                return RxInicial;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o RxInicial(Formulario frmCadastrarConsulta,Método EditarRxInicial)",
                    "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarSintomasReferidos(string idConsulta)
        {
            try
            {
                SintomasReferidosRegra editarSintomas = new SintomasReferidosRegra();

                bool[] sintomas = new bool[17];
                string outros = "";
                bool outrosConfirm = false;
                string Sintoma = "";
                for (int i = 0; i < dtgSintomasReferidos.Rows.Count; i++)
                {
                    Sintoma = dtgSintomasReferidos.Rows[i].Cells["confirmacaoSintomasReferidos"].Value.ToString();
                    if (Sintoma == "V" || Sintoma == "True")
                    {
                        sintomas[i] = true;
                    }
                    else
                    {
                        sintomas[i] = false;
                    }
                }
                outros = Convert.ToString(dtgSintomasReferidos.Rows[dtgSintomasReferidos.Rows.Count - 1].Cells["sintomaSintomasReferidos"].Value);
                outrosConfirm = Convert.ToBoolean(dtgSintomasReferidos.Rows[dtgSintomasReferidos.Rows.Count - 1].Cells["confirmacaoSintomasReferidos"].Value);
                bool sintomasReferidos = editarSintomas.Editar(Convert.ToInt32(idConsulta), sintomas[0], sintomas[1], sintomas[2], sintomas[3], sintomas[4], sintomas[5], 
                    sintomas[6], sintomas[7], sintomas[8], sintomas[9], sintomas[10],sintomas[11], sintomas[12], sintomas[13], sintomas[14], sintomas[15], outros,outrosConfirm);
                return sintomasReferidos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os Sintomas Referidos(Formulario frmCadastrarConsulta, Método EditarSintomasReferidos)",
                    "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarLensometria(string idConsulta)
        {
            try
            {
                LensometriaRegra lensometria = new LensometriaRegra();
                string[,] ArrayLensometria = new string[4, 6];
                string[] colunas = { "EsferaLensometria", "cilindroLensometria", "eixoLensometria", "AdicaoLensometria","prismaLensometria","BaseLensometria" };
                for (int l = 0; l < 4; l++)//linha 
                {
                    for (int c = 0; c < 6; c++)//coluna
                    {
                        ArrayLensometria[l, c] = Convert.ToString(dtgLensometria.Rows[l].Cells[colunas[c]].Value);
                    }
                }

                return lensometria.AtualizarLensometria(idConsulta,
                    ArrayLensometria[0, 0], ArrayLensometria[1, 0], ArrayLensometria[2, 0], ArrayLensometria[3, 0],//Esfera
                    ArrayLensometria[0, 1], ArrayLensometria[1, 1], ArrayLensometria[2, 1], ArrayLensometria[3, 1],//Cilindro
                    ArrayLensometria[0, 2], ArrayLensometria[1, 2], ArrayLensometria[2, 2], ArrayLensometria[3, 2],//Eixo

                     ArrayLensometria[0, 3], ArrayLensometria[1, 3], ArrayLensometria[2, 3], ArrayLensometria[3, 4],//Adição
                     ArrayLensometria[0, 4], ArrayLensometria[1, 4], ArrayLensometria[2, 4], ArrayLensometria[3, 4],//Prisma
                     ArrayLensometria[0, 5], ArrayLensometria[1, 5], ArrayLensometria[2, 5], ArrayLensometria[3, 5],//Base

                    txtTipoLenteLensometria.Text,txtTipoMaterialLensometria.Text,txtCorLensometria.Text,txtEstadoLensometria.Text,txtObservacaoLensometria.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Lensometria(Formulario frmCadastrarConsulta, Método EditarLensometria", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarMotilidade(string idConsulta)
        {
            try
            {
                MotilidadeOcularRegra motilidade = new MotilidadeOcularRegra();
                return motilidade.AtualizarMotilidadeOcular(idConsulta,txtKappaOd.Text,txtKappaOe.Text,txtHirsChberg.Text,txtDucaoOd.Text,txtDucaoOe.Text,
                    motilidade.ConcatenarVersoes(txtVersaoOd1.Text,txtVersaoOd2.Text,txtVersaoOd3.Text,txtVersaoOd4.Text,txtVersaoOd5.Text,txtVersaoOd6.Text),
                    motilidade.ConcatenarVersoes(txtVersaoOe1.Text,txtVersaoOe2.Text,txtVersaoOe3.Text,txtVersaoOe4.Text,txtVersaoOe5.Text,txtVersaoOe6.Text),
                    txtObservacaoMotilidade.Text,txtFotomotorOd.Text,txtFotomotorOe.Text,txtConsensualOd.Text,txtConsensualOe.Text,txtAcomodativoOd.Text,txtAcomodativoOe.Text,
                    txtBalancoMotilidade.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Motilidade Ocular(Formulario frmCadastrarConsulta, Método EditarMotilidade)", "Erro de Atualização",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarBiomicroscopia(string idconsulta)
        {
            try
            {
                BiomicroscopiaRegra biomicroscopia = new BiomicroscopiaRegra();
                return biomicroscopia.AtualizarBiomicroscopia(idconsulta, txtSobrancelhaOd.Text, txtSobrancelhaOe.Text, txtCiliosOd.Text, txtCiliosOe.Text, txtPalpebrasOd.Text,
                    txtPalpebrasOe.Text, txtConjuntivasOd.Text, txtConjuntivasOe.Text, txtEscleroticasOd.Text, txtEscleroticasOe.Text, txtCorneasOd.Text, txtCorneasOe.Text,
                    txtIrisOd.Text, txtIrisOe.Text, txtCristalinoOd.Text, txtCristalinoOe.Text, txtCamaraAnteriorOd.Text, txtCamaraAnteriorOe.Text, txtObservacaoBiomicroscopia.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Biomicroscopia(Formulario frmCadastrarConsulta, Método EditarBiomicroscopia)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarCeratometria(string idConsulta)
        {
            try
            {
                CeratometriaRegra ceratometria = new CeratometriaRegra();
                return ceratometria.AtualizarCeratometria(idConsulta, txtOlhoDireitoCeratometria.Text, txtOlhoEsquerdoCeratometria.Text,
                    txtTipoCeratometro.Text, txtObservacaoCeratometria.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Ceratometria(Formulario frmCadastrarConsulta, Método EditarCeratometria)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarRetinoscopia(string IDCONSULTA)
        {
            try
            {
                RetinoscopiaRegra retinoscopia = new RetinoscopiaRegra();
                return retinoscopia.AtualizarRetinoscopia(IDCONSULTA, txtEstaticaOd.Text, txtEstaticaOe.Text, txtDinamicaOd.Text, txtDinamicaOe.Text,
                    txtSubjetivoOd.Text, txtSubjetivoOe.Text, txtAfinamentoOd.Text, txtAfinamentoOe.Text, txtAdicaoNivelOd.Text, txtAdicaoNivelOe.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Retinocospia(Formulario frmCadastrarConsulta, Método EditarRetinoscopia)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarForometria(string IDCONSULTA)
        {
            try
            {
                ForometriaRegra forometria = new ForometriaRegra();
                string correcao = "";

                if (rbComCorrecao.Checked == true)correcao = "True"; 
                if(rbSemCorrecao.Checked == true) correcao = "False";

                return forometria.AtualizarForometria(IDCONSULTA, txtTesteUtilizado.Text, correcao, txtVlOd.Text, txtVlOe.Text, txt40CmOd.Text, txt40CmOe.Text, txt20CmOd.Text, txt20CmOe.Text,
                    txtPpcOr.Text, txtPpcLuz.Text, txtPpcFiltro.Text, txtPfpVl.Text, txtPfpVp.Text, txtRfnVl.Text, txtRfnVp.Text, txtAaOd.Text, txtAaOe.Text, txtFlexibilidadeOd.Text,
                    txtFlexibilidadeOe.Text, txtMetodoForometria.Text, txtNivelVisualForometria.Text, txtDtForometria.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Retinoscopia(Formulario frmCadastrarConsulta, Método EditarForometria)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarViaoCor(string IDCONSULTA)
        {
            try
            {
                VisaoCorRegra visaoCor = new VisaoCorRegra();
                return visaoCor.AtualizarVisaoCor(IDCONSULTA, txtTesteVisaoCor.Text, txtVisaoCorOd.Text, txtVisaoCorOe.Text, txtInterpretacaoVisaoCor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Visão de Cor(Formulario frmCadastrarConsulta, Método EditarViaoCor)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarAmsler(string IDCONSULTA)
        {
            try
            {
                AmslerRegra amsler = new AmslerRegra();
                return amsler.AtualizarAmsler(IDCONSULTA, txtAmslerOd.Text, txtAmslerOe.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Amsler(Formulario frmCadastrarConsulta, Método EditarAmsler)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool EditarEsteopsia(string IDCONSULTA)
        {
            try
            {
                EstereopsiaRegra estereopsia = new EstereopsiaRegra();
                return estereopsia.AtualizarEstereopsia(IDCONSULTA, txtTesteEstereopsia.Text, txtResultadoEstereopsia.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Estereopsia(Formulario frmCadastrarConsulta, Método EditarEsteopsia)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        void EditarConsultas(string idConsulta)
        {
            try
            {
                if (Convert.ToInt32(idConsulta) > 0)
                {
                    bool[] arrayconfirm = new bool[17];
                    arrayconfirm[0] = EditarAcuidadeVisual(idConsulta);
                    arrayconfirm[1] = EditaAnamnese(idConsulta);
                    arrayconfirm[2] = EditarAntecedentesGerais(idConsulta);
                    arrayconfirm[3] = EditarAntecedentesOculares(idConsulta);
                    arrayconfirm[4] = EditarOftalmoscopia(idConsulta);
                    arrayconfirm[5] = EditarRxFinal(idConsulta);
                    arrayconfirm[6] = EditarRxInicial(idConsulta);
                    arrayconfirm[7] = EditarSintomasReferidos(idConsulta);
                    arrayconfirm[8] = EditarLensometria(idConsulta);
                    arrayconfirm[9] = EditarMotilidade(idConsulta);
                    arrayconfirm[10] = EditarBiomicroscopia(idConsulta);
                    arrayconfirm[11] = EditarCeratometria(idConsulta);
                    arrayconfirm[12] = EditarRetinoscopia(idConsulta);
                    arrayconfirm[13] = EditarForometria(idConsulta);
                    arrayconfirm[14] = EditarViaoCor(idConsulta);
                    arrayconfirm[15] = EditarAmsler(idConsulta);
                    arrayconfirm[16] = EditarEsteopsia(idConsulta);


                    ConsultaRegra editarConsulta = new ConsultaRegra();
                    bool confirmAtualizacao = editarConsulta.Atualizar(idConsulta, txtOrigem.Text, txtHobbies.Text, txtEncaminhadoPor.Text,
                        txtAjudaOpticaPrescrita.Text, dtpUltimaConsulta.Value, txtTranscricaoLentes.Text, txtObservacaoReceita.Text, "Atendimento Finalizado", txtObservacaoConsulta.Text);

                    if (confirmAtualizacao == true)
                    {
                        if (MessageBox.Show("Dados Atualizados com sucesso!Deseja retornar a tela anterior?", "Dados Atualizados!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            this.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel atualizar os dados pois alguns estão incorretos ou inválidos", "Dados Inválidos", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("O Código da consulta a ser editada não é valido pois é menor ou igual a 0", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa/Atualização da consulta(Formulario frmCadastrarProfissional, Método EditarConsultas)", "Erro de Pesquisa/Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Métodos de Pesquisa
        void RetornarChaves(string IDCONSULTA)
        {
            DataTable dadosTabela = new DataTable();
            try
            {
                ConsultaRegra pesquisarChaves = new ConsultaRegra();
                if (Convert.ToInt32(IDCONSULTA) > 0)
                {
                    //dadosTabela = pesquisarChaves.u(idConsulta);
                    if (dtgIntermediario.Rows.Count - 1 > 0)
                    {
                        dtgIntermediario.Rows.Clear();
                    }
                    dtgIntermediario.DataSource = dadosTabela;
                    
                    RetornarPaciente(IDCONSULTA);
                    RetornarAnamnese(IDCONSULTA);
                    RetornarSintomasReferidos(IDCONSULTA);
                    RetornarAntecedentesGerais(IDCONSULTA);
                    RetornarAntecedentesOculares(IDCONSULTA);
                    RetornarRxInicial(IDCONSULTA);
                    RetornarRxFinal(IDCONSULTA);
                    RetornarAcuidadeVisual(IDCONSULTA);
                    RetornarOftalmoscopia(IDCONSULTA);
                    RetornarConsulta(IDCONSULTA);
                    RetornarLensometria(IDCONSULTA);
                    RetornarMotilidadeOcular(IDCONSULTA);
                    RetornarBiomicroscopia(IDCONSULTA);
                    RetornarCeratometria(IDCONSULTA);
                    RetornarRetinoscopia(IDCONSULTA);
                    RetornarForometria(IDCONSULTA);
                    RetornarVisaoCor(IDCONSULTA);
                    RetornarAmsler(IDCONSULTA);
                    RetornarEstereopsia(IDCONSULTA);
                }
                else
                {
                    MessageBox.Show("O Código da consulta a ser pesquisada não é valido pois é menor ou igual a 0", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar todos os dados da consulta(Formulario frmCadastrarConsulta, Método RetornarChaves)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarConsulta(string idConsulta)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                ConsultaRegra pesquisarConsulta = new ConsultaRegra();
                if (Convert.ToInt32(idConsulta) > 0)
                {
                    dadosTabela = pesquisarConsulta.CodigoConsulta(idConsulta);
                    dtgIntermediario.DataSource = dadosTabela;
                    if (dadosTabela.Rows.Count > 0)
                    {
                        txtOrigem.Text = Convert.ToString(dadosTabela.Rows[0]["origem"]);
                        txtHobbies.Text = Convert.ToString(dadosTabela.Rows[0]["hobbies"]);
                        txtEncaminhadoPor.Text = Convert.ToString(dadosTabela.Rows[0]["encaminhadoPor"]);
                        txtAjudaOpticaPrescrita.Text = Convert.ToString(dadosTabela.Rows[0]["ajudaOpticaPrescrita"]);
                        dtpUltimaConsulta.Text = Convert.ToString(dadosTabela.Rows[0]["dataUltimoExame"]);
                        // cbStatusConsulta.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["statusConsulta"].Value);
                        txtObservacaoConsulta.Text = Convert.ToString(dadosTabela.Rows[0]["observacaoConsulta"]);
                        txtTranscricaoLentes.Text = Convert.ToString(dadosTabela.Rows[0]["transcricaoLentes"]);
                        txtObservacaoReceita.Text = Convert.ToString(dadosTabela.Rows[0]["observacaoReceita"]);
                    }
                    else
                    {
                        MessageBox.Show("A pesquisa da consulta por seu código identificador não retornou nenhum resultado", "Dados Ausentes",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O Código da consulta a ser pesquisada não é valido pois é menor ou igual a 0", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela consulta(Formulario frmCadastrarConsulta, Método RetornarConsultas)",
                "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool RetornarIdProfissional(string idConsulta)
        {
            try
            {
                DataTable dadosProfissional = new DataTable();

                ProfissionalRegra pesquisar = new ProfissionalRegra();
                dadosProfissional = pesquisar.CodigoProfissional(Convert.ToInt32(idConsulta));
                if (dadosProfissional.Rows.Count > 0) idProfissional = dadosProfissional.Rows[0]["idProfissional"].ToString();
                if (Convert.ToInt32(idProfissional) > 0) return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo idProfissional(Formulario frmCadastrarConsulta,Método RetornarIdProfissional)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        void RetornarPaciente(string idConsulta)
        {
            try
            {
                PacienteRegra paciente = new PacienteRegra();
                DataTable dadosPaciente = new DataTable();

                dadosPaciente = paciente.RetornarDadosConsulta(idConsulta);

                if (dadosPaciente.Rows.Count > 0)
                {
                    txtNomePaciente.Text = dadosPaciente.Rows[0]["nomePaciente"].ToString();
                    txtNomeResponsavel.Text = dadosPaciente.Rows[0]["nomeResponsavel"].ToString();
                    txtRg.Text = dadosPaciente.Rows[0]["rg"].ToString();
                    txtCpf.Text = dadosPaciente.Rows[0]["cpf"].ToString();
                    txtOcupacaoPaciente.Text = dadosPaciente.Rows[0]["ocupacao"].ToString();
                    dtpDataNascimento.Text = dadosPaciente.Rows[0]["dataNascimento"].ToString();
                    txtObservacaoPaciente.Text = dadosPaciente.Rows[0]["observacaoPaciente"].ToString();

                    txtOrigem.Text = dadosPaciente.Rows[0]["origem"].ToString();
                    txtHobbies.Text = dadosPaciente.Rows[0]["hobbies"].ToString();
                    dtpUltimaConsulta.Text = dadosPaciente.Rows[0]["dataUltimoExame"].ToString();
                    txtEncaminhadoPor.Text = dadosPaciente.Rows[0]["encaminhadoPor"].ToString();
                    txtAjudaOpticaPrescrita.Text = dadosPaciente.Rows[0]["ajudaOpticaPrescrita"].ToString();


                    txtTranscricaoLentes.Text = dadosPaciente.Rows[0]["transcricaoLentes"].ToString();
                    txtObservacaoReceita.Text = dadosPaciente.Rows[0]["observacaoReceita"].ToString();

                    txtObservacaoConsulta.Text = dadosPaciente.Rows[0]["observacaoConsulta"].ToString(); 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo paciente(Formulario frmCadastrarAcesso,Método RetornarPaciente)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void CarregarPaciente(string idPaciente)
        {
            try
            {
                PacienteRegra paciente = new PacienteRegra();
                DataTable dadosPaciente = new DataTable();

                dadosPaciente = paciente.CodigoPaciente(Convert.ToInt32(idPaciente));
                if (dadosPaciente.Rows.Count > 0)
                {
                    txtNomePaciente.Text = dadosPaciente.Rows[0]["nomePaciente"].ToString();
                    txtNomeResponsavel.Text = dadosPaciente.Rows[0]["nomeResponsavel"].ToString();
                    txtRg.Text = dadosPaciente.Rows[0]["rg"].ToString();
                    txtCpf.Text = dadosPaciente.Rows[0]["cpf"].ToString();
                    txtOcupacaoPaciente.Text = dadosPaciente.Rows[0]["ocupacao"].ToString();
                    dtpDataNascimento.Text = dadosPaciente.Rows[0]["dataNascimento"].ToString();
                    txtObservacaoPaciente.Text = dadosPaciente.Rows[0]["observacaoPaciente"].ToString();
                }
                else
                {
                    MessageBox.Show("Paciente não encontrado(Formulario frmCadastrarConsulta,Método CarregarPaciente)", "Paciente não Encontrado", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo paciente(Formulario frmCadastrarAcesso,Método CarregarPaciente)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarAnamnese(string idConsulta)
        {
            try
            {
                AnamneseRegra pesquisarAnamnese = new AnamneseRegra();
                if (Convert.ToInt32(idConsulta) > 0)
                {
                    dtgIntermediario.DataSource = pesquisarAnamnese.PesquisarAnamnese(idConsulta);
                    if (dtgIntermediario.Rows.Count > 0)
                    {
                        txtMotivoConsulta.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["motivoConsulta"].Value);
                        txtTempoQueixa.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["tempoQueixa"].Value);
                        txtObservacaoAnamnese.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["observacaoAnamnese"].Value);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Anamnese(Formulario frmCadastrarConsulta, Método RetornarAnamnese)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarSintomasReferidos(string idConsulta)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                SintomasReferidosRegra pesquisarSintomas = new SintomasReferidosRegra();
                dadosTabela = pesquisarSintomas.PesquisarSintomasReferidos(idConsulta);
                if (dadosTabela.Rows.Count > 0)
                {
                    dtgIntermediario.DataSource = dadosTabela;
                    bool outrosConfirm = false;
                    bool[] sintomas = new bool[17];
                    string[] colunas = {"visaoBorrada","cefaleia","lacrimejamento","olhoVermelho","visaoDupla","fotopsias_fosfenos","miodesopsias",
                    "dorCabeca","astenopia","dorOcular","ardencia","secrecoes","coceira","fotofobia","halos","estrabismo","outros"};
                    string[] sintomasReferidos ={"Visão Borrada", "Cefaléia", "Lacrimejamento", "Olho Vermelho", "Visão Dupla","Fotopsias-Fosfenos","Miodesopsias", "Dor de Cabeça","Astenopia","Dor Ocular","Ardência","Secreções",
                    "Coceira","Fotofobia","Halos","Estrabismos"};
                    string outros = "";
                    int linhas = dtgSintomasReferidos.Rows.Count;
                    for (int i = 0; i < sintomas.Length; i++)//carrega os valores no array sintomas
                    {
                        bool BOOL = false;
                        if (colunas[i] == "outros")
                        {
                            outros = Convert.ToString(dtgIntermediario.Rows[0].Cells[colunas[i]].Value);
                            outrosConfirm = Convert.ToBoolean(dtgIntermediario.Rows[0].Cells["outrosConfirm"].Value);
                        }
                        else
                        {
                            BOOL = Convert.ToBoolean(dtgIntermediario.Rows[0].Cells[colunas[i]].Value);
                        }
                        if (BOOL == true)
                        {
                            sintomas[i] = true;
                        }
                        else
                        {
                            sintomas[i] = false;
                        }
                    }
                    dtgSintomasReferidos.Rows.Clear();
                    for (int i = 0; i < sintomasReferidos.Length; i++)//carrega os valores no dtg
                    {
                        dtgSintomasReferidos.Rows.Add(sintomasReferidos[i], sintomas[i]);
                    }
                    dtgSintomasReferidos.Rows.Add(outros, outrosConfirm);

                    for (int i = 0; i < dtgSintomasReferidos.Rows.Count; i++)
                    {
                        dtgSintomasReferidos.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        dtgSintomasReferidos.ForeColor = Color.Black;
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao pesquisar pelos Sintomas Referidos(Formulario frmCadastrarConsulta, Método RetornarSintomasReferidos)",
                        "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelos Sintomas Referidos(Formulario frmCadastrarConsulta, Método RetornarSintomasReferidos)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarAntecedentesGerais(string idConsulta)
        {
            try
            {
                AntecedentesGeraisRegra pesquisarGerais = new AntecedentesGeraisRegra();
                if (Convert.ToInt32(idConsulta) > 0)
                {
                    dtgIntermediario.DataSource = pesquisarGerais.PesquisarAntecedentesGerais(idConsulta);
                    if (dtgIntermediario.Rows.Count > 0)
                    {
                        string vasculares = Convert.ToString(dtgIntermediario.Rows[0].Cells["vasculares"].Value);
                        string vascularTratamento = Convert.ToString(dtgIntermediario.Rows[0].Cells["vascularTratamento"].Value);

                        string diabetes = Convert.ToString(dtgIntermediario.Rows[0].Cells["diabetes"].Value);
                        string diabetesTratamento = Convert.ToString(dtgIntermediario.Rows[0].Cells["diabetesTratamento"].Value);

                        string imunes = Convert.ToString(dtgIntermediario.Rows[0].Cells["imunes"].Value);
                        string imunesTratamento = Convert.ToString(dtgIntermediario.Rows[0].Cells["imunesTratamento"].Value);

                        string neurologicos = Convert.ToString(dtgIntermediario.Rows[0].Cells["neurologicos"].Value);
                        string neurologicosTratamento = Convert.ToString(dtgIntermediario.Rows[0].Cells["neurologicosTratamento"].Value);

                        string outros = Convert.ToString(dtgIntermediario.Rows[0].Cells["outros"].Value);
                        string outrosConfirm = Convert.ToString(dtgIntermediario.Rows[0].Cells["outrosConfirm"].Value);
                        string outrosTratamento = Convert.ToString(dtgIntermediario.Rows[0].Cells["outrosTratamento"].Value);

                        string observacaoAntecedentesGerais = Convert.ToString(dtgIntermediario.Rows[0].Cells["observacaoAntecedentesGerais"].Value);

                        string[] patologiaAntecedentesGerais = { "Vasculasres", "Diabetes", "Imunes", "Neurológicos", "" };

                        dtgAntecedentesGerais.Rows.Clear();
                        /*PF- o Paciente e pelo menos 1 familiar possue a patologia
                         FF=- Nem o paciente nem nenhum familiar possuem a patologia
                         P -apenas o paciente possue a patologia
                         f pelo menos um familiar possue a patologia mas o paciente não*/
                        if (vasculares != "")
                        {
                            if (vasculares == "PF") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[0], true, true, vascularTratamento);
                            if (vasculares == "FF") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[0], false, false, vascularTratamento);
                            if (vasculares == "P") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[0], true, false, vascularTratamento);
                            if (vasculares == "F") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[0], false, true, vascularTratamento);
                        }
                        else MessageBox.Show("Não foi possivel exibir os dados dos antecedentes gerais com total confiabilidade pois a variavel vasculares está vazia", "Variavel vazia");

                        if (diabetes != "")
                        {
                            if (diabetes == "PF") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[1], true, true, diabetesTratamento);
                            if (diabetes == "FF") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[1], false, false, diabetesTratamento);
                            if (diabetes == "P") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[1], true, false, diabetesTratamento);
                            if (diabetes == "F") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[1], false, true, diabetesTratamento);
                        }
                        else MessageBox.Show("Não foi possivel exibir os dados dos antecedentes gerais com total confiabilidade pois a variavel diabetes está vazia", "Variavel vazia");

                        if (imunes != "")
                        {
                            if (imunes == "PF") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[2], true, true, imunesTratamento);
                            if (imunes == "FF") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[2], false, false, imunesTratamento);
                            if (imunes == "P") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[2], true, false, imunesTratamento);
                            if (imunes == "F") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[2], false, true, imunesTratamento);
                        }
                        else MessageBox.Show("Não foi possivel exibir os dados dos antecedentes gerais com total confiabilidade pois a variavel imunes está vazia", "Variavel vazia");

                        if (neurologicos != "")
                        {
                            if (neurologicos == "PF") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[3], true, true, neurologicosTratamento);
                            if (neurologicos == "FF") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[3], false, false, neurologicosTratamento);
                            if (neurologicos == "P") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[3], true, false, neurologicosTratamento);
                            if (neurologicos == "F") dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[3], false, true, neurologicosTratamento);
                        }
                        else MessageBox.Show("Não foi possivel exibir os dados dos antecedentes gerais com total confiabilidade pois a variavel neurologicos está vazia", "Variavel vazia");

                        if (outros != null)
                        {
                            if (outrosConfirm == "PF") dtgAntecedentesGerais.Rows.Add(outros, true, true, outrosTratamento);
                            if (outrosConfirm == "FF") dtgAntecedentesGerais.Rows.Add(outros, false, false, outrosTratamento);
                            if (outrosConfirm == "P") dtgAntecedentesGerais.Rows.Add(outros, true, false, outrosTratamento);
                            if (outrosConfirm == "F") dtgAntecedentesGerais.Rows.Add(outros, false, true, outrosTratamento);
                        }
                        else
                        {
                            dtgAntecedentesGerais.Rows.Add(patologiaAntecedentesGerais[4], false, false, outrosTratamento);
                            MessageBox.Show("Não foi possivel exibir os dados dos antecedentes gerais com total confiabilidade pois a variavel outros está vazia", "Variavel vazia");
                        }
                        txtObservacaoAntecedentesGerais.Text = observacaoAntecedentesGerais;
                        for (int i = 0; i < dtgAntecedentesGerais.Rows.Count; i++)
                        {
                            dtgAntecedentesGerais.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                            dtgAntecedentesGerais.ForeColor = Color.Black;
                            i++;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar os Antecedentes Gerais(Formulario frmCadastrarConsulta, Método RetornarAntecedentesGerais)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarAntecedentesOculares(string idConsulta)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                AntecedentesOcularesRegra pesquisarOculares = new AntecedentesOcularesRegra();
                dadosTabela = pesquisarOculares.PesquisarAntecedentesOculares(idConsulta);
                if (dadosTabela.Rows.Count > 0)
                {
                    dtgIntermediario.DataSource = dadosTabela;
                    bool[] confirmacaoSintomas = new bool[15];
                    string[] tratamentoSintomas = new string[15];

                    string[] camposBancoBool = { "traumaOcular", "corpoEstranho","queimaduras","cirurgicos","inflamacoes","catarata","glaucoma","cegueira",
                    "descolamentoRetina","toxoplasmose","estrabismo","alergicos","pterigio","defeitosRefracao"};

                    string[] camposBancoString = { "traumaOcularTratamento", "corpoEstranhoTratamento", "queimadurasTratamento","cirurgicosTratamento",
                    "inflamacoesTratamento","catarataTratamento","glaucomaTratamento","cegueiraTratamento","descolamentoRetinaTratamento","toxoplasmoseTratamento","estrabismoTratamento",
                    "alergicosTratamento","pterigioTratamento","defeitosRefracaoTratamento"};

                    string[] camposDtg = {"TraumaOcular","Corpo Estranho","Queimaduras","Cirúrgicos","Inflamações","Catarata","Glaucoma","Cegueira","Descolamento da Retina","Toxoplasmose",
                    "Estrabismo","Alérgicos","Pterígio","Defeitos de Refração"};
                    string outros = "", outrosTratamento = "";
                    for (int i = 0; i < camposBancoBool.Length; i++)//passa os dados para as variaveis
                    {
                        string campo = camposBancoBool[i], tratamento;
                        bool teste = false;

                        teste = Convert.ToBoolean(dtgIntermediario.Rows[0].Cells[campo].Value);
                        tratamento = Convert.ToString(dtgIntermediario.Rows[0].Cells[camposBancoString[i]].Value);

                        tratamentoSintomas[i] = tratamento;
                        confirmacaoSintomas[i] = teste;
                    }
                    outros = Convert.ToString(dtgIntermediario.Rows[0].Cells["outro"].Value);
                    bool outrosConfirm = Convert.ToBoolean(dtgIntermediario.Rows[0].Cells["outrosConfirm"].Value);
                    outrosTratamento = Convert.ToString(dtgIntermediario.Rows[0].Cells["outroTratamento"].Value);
                    dtgAntecedentesOculares.Rows.Clear();
                    for (int i = 0; i < confirmacaoSintomas.Length - 1; i++)//passa os dados para o dtg
                    {
                        string campo = camposDtg[i], tratamento = tratamentoSintomas[i];
                        bool teste = confirmacaoSintomas[i];
                        dtgAntecedentesOculares.Rows.Add(campo, teste, tratamento);

                        if (confirmacaoSintomas.Length - 2 == i)
                        {
                            dtgAntecedentesOculares.Rows.Add(outros, outrosConfirm, outrosTratamento);
                        }
                    }

                    for (int i = 0; i < dtgAntecedentesOculares.Rows.Count; i++)
                    {
                        dtgAntecedentesOculares.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        dtgAntecedentesOculares.ForeColor = Color.Black;
                        i++;
                    }
                    dtgAntecedentesOculares.AutoResizeColumns();
                }
                dtgAntecedentesOculares.AutoResizeColumns();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelos Antecedentes Oculares(Formulario frmCadastrarConsulta, Método RetornarAntecedentesOculares)",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarRxInicial(string idConsulta)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                RxInicialRegra pesquisarRx = new RxInicialRegra();
                if (Convert.ToInt32(idConsulta) > 0)
                {
                    dadosTabela = pesquisarRx.PesquisarRxInicial(idConsulta);

                    string[] olhoRxincial = { "VL OD", "VL OE", "VP OD", "VP OE" };

                    string[,] MatrizRxInicial = new string[4, 6];

                    if (dadosTabela.Rows.Count > 0)
                    {

                        MatrizRxInicial[0, 0] = Convert.ToString(dadosTabela.Rows[0]["esferaVlOd"]);
                        MatrizRxInicial[1, 0] = Convert.ToString(dadosTabela.Rows[0]["esferaVlOe"]);
                        MatrizRxInicial[2, 0] = Convert.ToString(dadosTabela.Rows[0]["esferaVpOd"]);
                        MatrizRxInicial[3, 0] = Convert.ToString(dadosTabela.Rows[0]["esferaVpOe"]);


                        MatrizRxInicial[0, 1] = Convert.ToString(dadosTabela.Rows[0]["cilindroVlOd"]);
                        MatrizRxInicial[1, 1] = Convert.ToString(dadosTabela.Rows[0]["cilindroVlOe"]);
                        MatrizRxInicial[2, 1] = Convert.ToString(dadosTabela.Rows[0]["cilindroVpOd"]);
                        MatrizRxInicial[3, 1] = Convert.ToString(dadosTabela.Rows[0]["cilindroVpOe"]);

                        MatrizRxInicial[0, 2] = Convert.ToString(dadosTabela.Rows[0]["eixoVlOd"]);
                        MatrizRxInicial[1, 2] = Convert.ToString(dadosTabela.Rows[0]["eixoVlOe"]);
                        MatrizRxInicial[2, 2] = Convert.ToString(dadosTabela.Rows[0]["eixoVpOd"]);
                        MatrizRxInicial[3, 2] = Convert.ToString(dadosTabela.Rows[0]["eixoVpOe"]);

                        MatrizRxInicial[0, 3] = Convert.ToString(dadosTabela.Rows[0]["AvVlOd"]);
                        MatrizRxInicial[1, 3] = Convert.ToString(dadosTabela.Rows[0]["AvVlOe"]);
                        MatrizRxInicial[2, 3] = Convert.ToString(dadosTabela.Rows[0]["AvVpOd"]);
                        MatrizRxInicial[3, 3] = Convert.ToString(dadosTabela.Rows[0]["AvVpOe"]);

                        txtAdicaoRxInicial.Text = Convert.ToString(dadosTabela.Rows[0]["adicao"]);
                        txtDpRxInicial.Text = Convert.ToString(dadosTabela.Rows[0]["dp"]);

                        txtTipoMaterialRxInicial.Text = Convert.ToString(dadosTabela.Rows[0]["Tipomaterial"]);
                        txtCorRxInicial.Text = Convert.ToString(dadosTabela.Rows[0]["cor"]);

                        txtUsoRxInicial.Text = Convert.ToString(dadosTabela.Rows[0]["uso"]);
                        txtTipoLenteRxInicial.Text = Convert.ToString(dadosTabela.Rows[0]["tipoLente"]);

                        txtObservacaoRxInicial.Text = Convert.ToString(dadosTabela.Rows[0]["observacaoRxInicial"]);

                        dtgRxInicial.Rows.Clear();
                        for (int l = 0; l < 4; l++)//linha 
                        {
                            dtgRxInicial.Rows.Add(olhoRxincial[l], MatrizRxInicial[l, 0], MatrizRxInicial[l, 1], MatrizRxInicial[l, 2], MatrizRxInicial[l, 3]);
                        }
                        for (int i = 0; i < dtgRxInicial.Rows.Count; i++)
                        {
                            dtgRxInicial.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                            dtgRxInicial.ForeColor = Color.Black;
                            i++;
                        }
                    } 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo RxInicial(Formulario frmCadastrarConsulta, Método RetornarRxInicial)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarRxFinal(string idConsulta)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                RxFinalRegra pesquisarRx = new RxFinalRegra();
                dadosTabela = pesquisarRx.PesquisarRxFinal(idConsulta);
                if (dadosTabela.Rows.Count > 0)
                {
                    dtgIntermediario.DataSource = dadosTabela;
                    string[] olhoRxFinal = { "VL OD", "VL OE", "VP OD", "VP OE" };

                    string[,] MatrizRxFinal = new string[4, 6];

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

                    txtAdicaoRxFinal.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["adicao"].Value);
                    txtDpRxFinal.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["dp"].Value);

                    txtTipoMaterialRxFinal.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["tipomaterial"].Value);
                    txtCorRxFinal.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["cor"].Value);

                    txtUsoRxFinal.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["uso"].Value);
                    txtTipoLenteRxFinal.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["tipoLente"].Value);

                    txtObservacaoRxFinal.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["observacaoRxFinal"].Value);

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
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo RxFinal(Formulario frmCadastrarConsulta, Método RetornarRxFinal)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarAcuidadeVisual(string idConsulta)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                AcuidadeVisualRegra pesquisarAcuidade = new AcuidadeVisualRegra();
                dadosTabela = pesquisarAcuidade.PesquisarAcuidadeVisual(idConsulta);
                if (dadosTabela.Rows.Count > 0)
                {
                    dtgIntermediario.DataSource = dadosTabela;

                    string[] OlhoAcuidadeVisual = { "OD", "OE", "AO" };
                    string[] camposBanco = {"vlOdSg","vlOeSg","vlAoSg","vlPh","vlOdCc","vlOeCc","vlAoCc","vpOdSc","vpOeSc","vpAoSc","vpOdCc",
                    "vpOeCc","vpAoCc","tipoOptotipo"};
                    string tipoOptotipo = "";
                    string[,] matrizAcuidade = new string[3, 5];

                    matrizAcuidade[0, 0] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdSg"].Value);
                    // matrizAcuidade[0,1]= Convert.ToString(dtgIntermediario.Rows[0].Cells[""].Value); vlph linha 0
                    matrizAcuidade[0, 2] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdCc"].Value);
                    matrizAcuidade[0, 3] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdSc"].Value);
                    matrizAcuidade[0, 4] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdCc"].Value);

                    matrizAcuidade[1, 0] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOeSg"].Value);
                    matrizAcuidade[1, 1] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlPh"].Value);
                    matrizAcuidade[1, 2] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOeCc"].Value);
                    matrizAcuidade[1, 3] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOeSc"].Value);
                    matrizAcuidade[1, 4] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOeCc"].Value);

                    matrizAcuidade[2, 0] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlAoSg"].Value);
                    //matrizAcuidade[2,1]= Convert.ToString(dtgIntermediario.Rows[0].Cells[""].Value); vlph linha 2
                    matrizAcuidade[2, 2] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlAoCc"].Value);
                    matrizAcuidade[2, 3] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpAoSc"].Value);
                    matrizAcuidade[2, 4] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpAoCc"].Value);

                    tipoOptotipo = Convert.ToString(dtgIntermediario.Rows[0].Cells["tipoOptotipo"].Value);

                    dtgAcuidadeVisual.Rows.Clear();
                    for (int l = 0; l < 3; l++)//linha 
                    {
                        if (l != 1)
                        {
                            dtgAcuidadeVisual.Rows.Add(OlhoAcuidadeVisual[l], matrizAcuidade[l, 0], "", matrizAcuidade[l, 2], OlhoAcuidadeVisual[l], matrizAcuidade[l, 3], matrizAcuidade[l, 4]);
                        }
                        if (l == 1)
                        {
                            dtgAcuidadeVisual.Rows.Add(OlhoAcuidadeVisual[l], matrizAcuidade[l, 0], matrizAcuidade[1, 1], matrizAcuidade[l, 2], OlhoAcuidadeVisual[l], matrizAcuidade[l, 3], matrizAcuidade[l, 4]);
                        }
                    }
                    txtTipoOptotipo.Text = tipoOptotipo;
                    for (int i = 0; i < dtgAcuidadeVisual.Rows.Count; i++)
                    {
                        dtgAcuidadeVisual.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        dtgAcuidadeVisual.ForeColor = Color.Black;
                        i++;
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Acuidade Visual(Formulario frmCadastrar, Método RetornarAcuidadeVisual)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarOftalmoscopia(string idConsulta)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                OftalmoscopiaRegra pesquisarOftalmoscopia = new OftalmoscopiaRegra();
                if (Convert.ToInt32(idConsulta) > 0)
                {
                    dadosTabela = pesquisarOftalmoscopia.LocalizarOftalmoscopia(idConsulta);
                    dtgIntermediario.DataSource = dadosTabela;

                    txtDistanciaBrucknerOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["distanciaBruckner"].Value);

                    txtPapilaOdOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["papilaOd"].Value);
                    txtPapilaOeOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["papilaOe"].Value);

                    txtEscavacaoOdOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["escavacaoOd"].Value);
                    txtEscavacaoOeOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["escavacaoOe"].Value);

                    txtMaculaOdOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["maculaOd"].Value);
                    txtMaculaOeOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["maculaOe"].Value);

                    txtFixacaoOdOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["fixacaoOd"].Value);
                    txtFixacaoOeOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["fixacaoOe"].Value);

                    txtRelacaoAVOdOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["relacaoAVOd"].Value);
                    txtRelacaoAVOeOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["relacaoAVOe"].Value);

                    txtCorOdOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["corOd"].Value);
                    txtCorOeOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["corOe"].Value);

                    txtLenteOdOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["lenteOd"].Value);
                    txtLenteOeOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["lenteOe"].Value);

                    txtObservacaoOftalmoscopia.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["observacaoOftalmoscopia"].Value);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Oftalmoscopia(Formulario frmCadastrarConsulta, Método RetornarOftalmoscopia)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarMotilidadeOcular(string idconsulta)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                MotilidadeOcularRegra motilidade = new MotilidadeOcularRegra();

                dadosTabela = motilidade.PesquisarMotilidadeOcular(idconsulta);

                if(dadosTabela.Rows.Count > 0)
                {
                    txtKappaOd.Text = dadosTabela.Rows[0]["Kappa OD"].ToString();
                    txtKappaOe.Text = dadosTabela.Rows[0]["Kappa OE"].ToString();
                    txtHirsChberg.Text = dadosTabela.Rows[0]["Hirschberg"].ToString();
                    txtDucaoOd.Text = dadosTabela.Rows[0]["Dução OD"].ToString();
                    txtDucaoOe.Text = dadosTabela.Rows[0]["Dução OE"].ToString();

                    string[] arrayVersaoOd = motilidade.DesconcetenarVersoes(dadosTabela.Rows[0]["Versão OD"].ToString());
                    txtVersaoOd1.Text = arrayVersaoOd[0];
                    txtVersaoOd2.Text = arrayVersaoOd[1];
                    txtVersaoOd3.Text = arrayVersaoOd[2];
                    txtVersaoOd4.Text = arrayVersaoOd[3];
                    txtVersaoOd5.Text = arrayVersaoOd[4];
                    txtVersaoOd6.Text = arrayVersaoOd[5];

                    string[] arrayVersaoOe = motilidade.DesconcetenarVersoes(dadosTabela.Rows[0]["Versão OE"].ToString());
                    txtVersaoOe1.Text = arrayVersaoOe[0];
                    txtVersaoOe2.Text = arrayVersaoOe[1];
                    txtVersaoOe3.Text = arrayVersaoOe[2];
                    txtVersaoOe4.Text = arrayVersaoOe[3];
                    txtVersaoOe5.Text = arrayVersaoOe[4];
                    txtVersaoOe6.Text = arrayVersaoOe[5];

                    txtObservacaoMotilidade.Text = dadosTabela.Rows[0]["Observação Motilidade Ocular"].ToString();
                    txtFotomotorOd.Text = dadosTabela.Rows[0]["Fotomotor OD"].ToString();
                    txtFotomotorOe.Text = dadosTabela.Rows[0]["Fotomotor OE"].ToString();
                    txtConsensualOd.Text = dadosTabela.Rows[0]["Consensual OD"].ToString();
                    txtConsensualOe.Text = dadosTabela.Rows[0]["Consensual OE"].ToString();
                    txtAcomodativoOd.Text = dadosTabela.Rows[0]["Acomodativo OD"].ToString();
                    txtAcomodativoOe.Text = dadosTabela.Rows[0]["Acomodativo OE"].ToString();
                    txtBalancoMotilidade.Text = dadosTabela.Rows[0]["Balanço"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar Motilidade Ocular(Formulario frmCadastrarConsulta, Método RetornarMotilidadeOcular)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarLensometria(string idConslta)
        {
            try
            {
                LensometriaRegra lensometriaRegra = new LensometriaRegra();
                DataTable dadosTabela = new DataTable();

                dadosTabela = lensometriaRegra.PesquisarLensometria(idConsulta);
                if (dadosTabela.Rows.Count > 0)
                {
                    string[] olhoLensometria = { "VL OD", "VL OE", "VP OD", "VP OE" };

                    string[,] MatrizLensometria = new string[4, 6];

                    MatrizLensometria[0, 0] = Convert.ToString(dadosTabela.Rows[0]["VlOdesfera"]);
                    MatrizLensometria[1, 0] = Convert.ToString(dadosTabela.Rows[0]["VlOeesfera"]);
                    MatrizLensometria[2, 0] = Convert.ToString(dadosTabela.Rows[0]["VpOdesfera"]);
                    MatrizLensometria[3, 0] = Convert.ToString(dadosTabela.Rows[0]["VpOeesfera"]);


                    MatrizLensometria[0, 1] = Convert.ToString(dadosTabela.Rows[0]["VlOdcilindro"]);
                    MatrizLensometria[1, 1] = Convert.ToString(dadosTabela.Rows[0]["VlOecilindro"]);
                    MatrizLensometria[2, 1] = Convert.ToString(dadosTabela.Rows[0]["VpOdcilindro"]);
                    MatrizLensometria[3, 1] = Convert.ToString(dadosTabela.Rows[0]["VpOecilindro"]);

                    MatrizLensometria[0, 2] = Convert.ToString(dadosTabela.Rows[0]["VlOdeixo"]);
                    MatrizLensometria[1, 2] = Convert.ToString(dadosTabela.Rows[0]["VlOeeixo"]);
                    MatrizLensometria[2, 2] = Convert.ToString(dadosTabela.Rows[0]["VpOdeixo"]);
                    MatrizLensometria[3, 2] = Convert.ToString(dadosTabela.Rows[0]["VpOeeixo"]);

                    MatrizLensometria[0, 3] = Convert.ToString(dadosTabela.Rows[0]["VlOdadicao"]);
                    MatrizLensometria[1, 3] = Convert.ToString(dadosTabela.Rows[0]["VlOeadicao"]);
                    MatrizLensometria[2, 3] = Convert.ToString(dadosTabela.Rows[0]["VpOdadicao"]);
                    MatrizLensometria[3, 3] = Convert.ToString(dadosTabela.Rows[0]["VpOeadicao"]);

                    MatrizLensometria[0, 4] = Convert.ToString(dadosTabela.Rows[0]["VlOdprisma"]);
                    MatrizLensometria[1, 4] = Convert.ToString(dadosTabela.Rows[0]["VlOeprisma"]);
                    MatrizLensometria[2, 4] = Convert.ToString(dadosTabela.Rows[0]["VpOdprisma"]);
                    MatrizLensometria[3, 4] = Convert.ToString(dadosTabela.Rows[0]["VpOeprisma"]);

                    MatrizLensometria[0, 5] = Convert.ToString(dadosTabela.Rows[0]["VlOdbase"]);
                    MatrizLensometria[1, 5] = Convert.ToString(dadosTabela.Rows[0]["VlOebase"]);
                    MatrizLensometria[2, 5] = Convert.ToString(dadosTabela.Rows[0]["VpOdbase"]);
                    MatrizLensometria[3, 5] = Convert.ToString(dadosTabela.Rows[0]["VpOebase"]);

                    txtTipoLenteLensometria.Text = Convert.ToString(dadosTabela.Rows[0]["tipoLente"]);
                    txtTipoMaterialLensometria.Text = Convert.ToString(dadosTabela.Rows[0]["material"]);
                    txtCorLensometria.Text = Convert.ToString(dadosTabela.Rows[0]["cor"]);
                    txtEstadoLensometria.Text = Convert.ToString(dadosTabela.Rows[0]["estado"]);
                    txtObservacaoLensometria.Text = Convert.ToString(dadosTabela.Rows[0]["observacaoLensometria"]);

                    dtgLensometria.Rows.Clear();
                    for (int l = 0; l < 4; l++)//linha 
                    {
                        dtgLensometria.Rows.Add(olhoLensometria[l], MatrizLensometria[l, 0], MatrizLensometria[l, 1], MatrizLensometria[l, 2], MatrizLensometria[l, 3],
                            MatrizLensometria[l,4], MatrizLensometria[l,5]);
                    }
                    for (int i = 0; i < dtgLensometria.Rows.Count; i++)
                    {
                        dtgLensometria.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        dtgLensometria.ForeColor = Color.Black;
                        i++;
                    }
        
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Lensometria(Formulario frmCadastrarConsulta, Método RetornarLensometria)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarBiomicroscopia(string idconsulta)
        {
            try
            {
                DataTable dados = new DataTable();
                BiomicroscopiaRegra biomicroscopia = new BiomicroscopiaRegra();
                dados = biomicroscopia.PesquisarBiomicroscopia(idconsulta);
                if(dados.Rows.Count > 0)
                {
                    txtSobrancelhaOd.Text = dados.Rows[0]["Sobrancelha OD"].ToString();
                    txtSobrancelhaOe.Text = dados.Rows[0]["Sobrancelha OE"].ToString();

                    txtCiliosOd.Text = dados.Rows[0]["Cílio OD"].ToString();
                    txtCiliosOe.Text = dados.Rows[0]["Cílio Oe"].ToString(); 

                    txtPalpebrasOd.Text = dados.Rows[0]["Pálpebra OD"].ToString();
                    txtPalpebrasOe.Text = dados.Rows[0]["Pálpebra OE"].ToString();

                    txtConjuntivasOd.Text = dados.Rows[0]["Conjuntiva OD"].ToString();
                    txtConjuntivasOe.Text = dados.Rows[0]["Conjuntiva OE"].ToString();

                    txtEscleroticasOd.Text = dados.Rows[0]["Esclerotica OD"].ToString();
                    txtEscleroticasOe.Text = dados.Rows[0]["Esclerotica OE"].ToString();

                    txtCorneasOd.Text = dados.Rows[0]["Córnea OD"].ToString();
                    txtCorneasOe.Text = dados.Rows[0]["Córnea OE"].ToString();

                    txtIrisOd.Text = dados.Rows[0]["Íris OD"].ToString();
                    txtIrisOe.Text = dados.Rows[0]["Íris OE"].ToString();

                    txtCristalinoOd.Text = dados.Rows[0]["Cristalino OD"].ToString();
                    txtCristalinoOe.Text = dados.Rows[0]["Cristalino OE"].ToString();

                    txtCamaraAnteriorOd.Text = dados.Rows[0]["Câmara Anterior OD"].ToString();
                    txtCamaraAnteriorOe.Text = dados.Rows[0]["Câmara Anterior OE"].ToString();

                    txtObservacaoBiomicroscopia.Text = dados.Rows[0]["Observação Bimicroscopia"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Biomicroscopia(Formulario frmCadastrarConsulta, Método RetornarBiomicroscopia)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarCeratometria(string idConsulta)
        {
            try
            {
                DataTable dados = new DataTable();
                CeratometriaRegra ceratometria = new CeratometriaRegra();
                dados = ceratometria.PesquisarCeratometria(idConsulta);

                if(dados.Rows.Count > 0)
                {
                    txtOlhoDireitoCeratometria.Text = dados.Rows[0]["OD"].ToString();
                    txtOlhoEsquerdoCeratometria.Text = dados.Rows[0]["OE"].ToString();
                    txtTipoCeratometro.Text = dados.Rows[0]["Tipo Ceratometro"].ToString();
                    txtObservacaoCeratometria.Text = dados.Rows[0]["Observação Ceratometria"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Ceratometria(Formulario frmCadastrarConsulta, Método RetornarCeratometria)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarRetinoscopia(string idConsulta)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                RetinoscopiaRegra retinoscopia = new RetinoscopiaRegra();

                dadosTabela = retinoscopia.PesquisarRetinoscopia(idConsulta);

                if(dadosTabela.Rows.Count > 0)
                {
                    txtEstaticaOd.Text = dadosTabela.Rows[0]["Estática OD"].ToString();
                    txtEstaticaOe.Text = dadosTabela.Rows[0]["Estática OE"].ToString();

                    txtDinamicaOd.Text = dadosTabela.Rows[0]["Dinâmica OD"].ToString();
                    txtDinamicaOe.Text = dadosTabela.Rows[0]["Dinâmica OE"].ToString();

                    txtSubjetivoOd.Text = dadosTabela.Rows[0]["Subjetivo OD"].ToString();
                    txtSubjetivoOe.Text = dadosTabela.Rows[0]["Subjetivo OE"].ToString();

                    txtAfinamentoOd.Text = dadosTabela.Rows[0]["Afinamento OD"].ToString();
                    txtAfinamentoOe.Text = dadosTabela.Rows[0]["Afinamento OE"].ToString();

                    txtAdicaoNivelOd.Text = dadosTabela.Rows[0]["Adição Nível OD"].ToString();
                    txtAdicaoNivelOe.Text = dadosTabela.Rows[0]["Adição Nível OE"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Restinoscopia(Formulario frmCadastrarConsulta, Método RetornarRetinoscopia)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarForometria(string idConsulta)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                ForometriaRegra forometria = new ForometriaRegra();

                dadosTabela = forometria.PesquisarForometria(idConsulta);
                if(dadosTabela.Rows.Count > 0)
                {
                    
                    if (dadosTabela.Rows[0]["Correção"].ToString() == "True") rbComCorrecao.Checked = true;
                    if(dadosTabela.Rows[0]["Correção"].ToString() == "False")rbSemCorrecao.Checked = true;

                    txtTesteUtilizado.Text = dadosTabela.Rows[0]["Teste Utilizado"].ToString();

                    txtVlOd.Text = dadosTabela.Rows[0]["VL OD"].ToString();
                    txtVlOe.Text = dadosTabela.Rows[0]["VL OE"].ToString();

                    txt40CmOd.Text = dadosTabela.Rows[0]["40 Cm OD"].ToString();
                    txt40CmOe.Text = dadosTabela.Rows[0]["40 Cm OE"].ToString();

                    txt20CmOd.Text = dadosTabela.Rows[0]["20 Cm OD"].ToString();
                    txt20CmOe.Text = dadosTabela.Rows[0]["20 Cm OE"].ToString();

                    txtPpcOr.Text = dadosTabela.Rows[0]["PPC OR"].ToString();
                    txtPpcLuz.Text = dadosTabela.Rows[0]["PPC LUZ"].ToString();
                    txtPpcFiltro.Text = dadosTabela.Rows[0]["PPC FILTRO"].ToString();

                    txtPfpVl.Text = dadosTabela.Rows[0]["PFP VL"].ToString();
                    txtPfpVp.Text = dadosTabela.Rows[0]["PFP VP"].ToString();

                    txtRfnVl.Text = dadosTabela.Rows[0]["RFN VL"].ToString();
                    txtRfnVp.Text = dadosTabela.Rows[0]["RFN VP"].ToString();

                    txtAaOd.Text = dadosTabela.Rows[0]["AA OD"].ToString();
                    txtAaOe.Text = dadosTabela.Rows[0]["AA OE"].ToString();

                    txtFlexibilidadeOd.Text = dadosTabela.Rows[0]["Flexibilidade OD"].ToString();
                    txtFlexibilidadeOe.Text = dadosTabela.Rows[0]["Flexibilidade OE"].ToString();

                    txtMetodoForometria.Text = dadosTabela.Rows[0]["Método"].ToString();
                    txtNivelVisualForometria.Text = dadosTabela.Rows[0]["Nível Visual"].ToString();
                    txtDtForometria.Text = dadosTabela.Rows[0]["DT"].ToString();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Forometria(Formulario frmCadastrarConsulta, Método retornarForometria)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarVisaoCor(string idConsulta)
        {
            try
            {
                DataTable dados = new DataTable();
                VisaoCorRegra visao = new VisaoCorRegra();
                dados = visao.PesquisarVisaoCor(idConsulta);

                if(dados.Rows.Count > 0)
                {
                    txtTesteVisaoCor.Text = dados.Rows[0]["Teste"].ToString();
                    txtVisaoCorOd.Text = dados.Rows[0]["OD"].ToString();
                    txtVisaoCorOe.Text = dados.Rows[0]["OE"].ToString();
                    txtInterpretacaoVisaoCor.Text = dados.Rows[0]["Interpretação"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Visão de Cor(Formulario frmCadastrarConsulta,Método RetornarVisaoCor)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarAmsler(string idConsulta)
        {
            try
            {
                AmslerRegra amsler = new AmslerRegra();
                DataTable dados = new DataTable();

                dados = amsler.PesquisarAmsler(idConsulta);
                if (dados.Rows.Count > 0)
                {
                    txtAmslerOd.Text = dados.Rows[0]["OD"].ToString();
                    txtAmslerOe.Text = dados.Rows[0]["OE"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Amsler(Formulario frmCadastrarConsulta, Método RetornarAmsler)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void RetornarEstereopsia(string idConsulta)
        {
            try
            {
                EstereopsiaRegra estereopsia = new EstereopsiaRegra();
                DataTable dados = new DataTable();

                dados = estereopsia.PesquisarEstereopsia(idConsulta);
                if(dados.Rows.Count > 0)
                {
                    txtTesteEstereopsia.Text = dados.Rows[0]["Teste"].ToString();
                    txtResultadoEstereopsia.Text = dados.Rows[0]["Resultado"].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Estereopsia(Formulario frmCadastraConsulta, Método RetornarEstereopsia)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Métodos de cadastro
        bool CadastrarAcuidadeVisual(string IDCONSULTA)
        {
            try
            {
                //visão de longe
                string vlOdSg = Convert.ToString(dtgAcuidadeVisual.Rows[0].Cells["sgVlAcuidadeVisual"].Value);
                string vlOeSg = Convert.ToString(dtgAcuidadeVisual.Rows[1].Cells["sgVlAcuidadeVisual"].Value);
                string vlAoSg = Convert.ToString(dtgAcuidadeVisual.Rows[2].Cells["sgVlAcuidadeVisual"].Value);

                string vlPh = Convert.ToString(dtgAcuidadeVisual.Rows[1].Cells["phVlAcuidadeVisual"].Value);

                string vlOdCc = Convert.ToString(dtgAcuidadeVisual.Rows[0].Cells["ccVlAcuidadeVisual"].Value);
                string vlOeCc = Convert.ToString(dtgAcuidadeVisual.Rows[1].Cells["ccVlAcuidadeVisual"].Value);
                string vlAoCc = Convert.ToString(dtgAcuidadeVisual.Rows[2].Cells["ccVlAcuidadeVisual"].Value);

                //Visão de perto 
                string vpOdSc = Convert.ToString(dtgAcuidadeVisual.Rows[0].Cells["scVpAcuidadeVisual"].Value);
                string vpOeSc = Convert.ToString(dtgAcuidadeVisual.Rows[1].Cells["scVpAcuidadeVisual"].Value);
                string vpAoSc = Convert.ToString(dtgAcuidadeVisual.Rows[2].Cells["scVpAcuidadeVisual"].Value);

                string vpOdCc = Convert.ToString(dtgAcuidadeVisual.Rows[0].Cells["ccVpAcuidadeVisual"].Value);
                string vpOeCc = Convert.ToString(dtgAcuidadeVisual.Rows[1].Cells["ccVpAcuidadeVisual"].Value);
                string vpAoCc = Convert.ToString(dtgAcuidadeVisual.Rows[2].Cells["ccVpAcuidadeVisual"].Value);


                AcuidadeVisualRegra AcuidadeRegra = new AcuidadeVisualRegra();
                bool acuidade = AcuidadeRegra.Cadastrar(IDCONSULTA,vlOdSg, vlOeSg, vlAoSg, vlPh, vlOdCc, vlOeCc, vlAoCc, vpOdSc, vpOeSc, vpAoSc, vpOdCc, vpOeCc, vpAoCc, txtTipoOptotipo.Text);
                return acuidade;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Acuidade Visual(Formulario frmCadastrarConsulta, Método CadastrarAcuidadeVisual)", "Erro de cadastro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarAnamnese(string IDCONSULTA)
        {
            try
            {
                AnamneseRegra AnamneseRegra = new AnamneseRegra();
                bool Anamnese = AnamneseRegra.Cadastrar(IDCONSULTA, txtMotivoConsulta.Text,txtTempoQueixa.Text,txtObservacaoAnamnese.Text);
                return Anamnese;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Anamnese(Formulario frmCadastrarConsulta, Método CadastrarAnamnese)","Erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarAntecedentesGerais(string IDCONSULTA)
        {
            try
            {
                string vasculares = "", vascularesTratamento = "";
                string diabetes = "", diabetesTratamento = "";
                string imunes = "", imunesTratamento = "";
                string neurologicos = "", neurologicosTratamento = "";
                string outros = "",outrosConfirm="", outrosTratamento = "";

                bool Pessoal;
                Pessoal= false;
                bool Familiar;
                Familiar= false;
                int linhas = dtgAntecedentesGerais.Rows.Count;
                for (int i = 0; i < 5; i++)
                {
                    Familiar = Convert.ToBoolean(dtgAntecedentesGerais.Rows[i].Cells["familiarAntecedentesGerais"].Value);
                    Pessoal = Convert.ToBoolean(dtgAntecedentesGerais.Rows[i].Cells["pessoalAntecedentesGerais"].Value);
                    //Vasculares
                    if (i == 0)
                    {
                        if (Pessoal == true && Familiar == true)
                        {
                            vasculares = "PF";
                            vascularesTratamento = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["tipoTratamentoAntecedentesGerais"].Value);
                        }
                        else
                        {
                            if (Pessoal == true) vasculares = "P";
                            if (Familiar == true)vasculares = "F";
                            if (Pessoal == false && Familiar == false) vasculares = "FF";
                        }
                        vascularesTratamento = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["tipoTratamentoAntecedentesGerais"].Value);
                    }
                    //Diabeyes
                    if (i == 1)
                    {
                        if (Pessoal == true && Familiar == true)diabetes = "PF";
                        else
                        {
                            if (Pessoal == true)diabetes = "P";
                            if (Familiar == true)diabetes = "F";
                            if (Pessoal == false && Familiar == false) diabetes = "FF";
                        }
                        diabetesTratamento = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["tipoTratamentoAntecedentesGerais"].Value);
                    }
                    //imunes
                    if (i == 2)
                    {
                        if (Pessoal == true && Familiar == true)imunes = "PF";
                        else
                        {
                            if (Pessoal == true)imunes = "P";
                            if (Familiar == true)imunes = "F";
                            if (Pessoal == false && Familiar == false) imunes = "FF";
                        }
                        imunesTratamento = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["tipoTratamentoAntecedentesGerais"].Value);
                    }
                    //neurologicos
                    if (i == 3)
                    {
                        if (Pessoal == true && Familiar == true)neurologicos = "PF";
                        else
                        {
                            if (Pessoal == true) neurologicos = "P";
                            if (Familiar == true) neurologicos = "F";
                            if (Pessoal== false && Familiar ==false) neurologicos = "FF";
                        }
                        neurologicosTratamento = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["tipoTratamentoAntecedentesGerais"].Value);  
                    }
                    //outros
                    if (i == 4)
                    {
                        if (Pessoal == true && Familiar == true) outrosConfirm = "PF";
                        else
                        {
                            if (Pessoal == true) outrosConfirm = "P";
                            if (Familiar == true) outrosConfirm = "F";
                            if (Pessoal == false && Familiar == false) outrosConfirm = "FF";
                        }
                        outros = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["patologiaAntecedentesGerais"].Value);
                        outrosTratamento = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["tipoTratamentoAntecedentesGerais"].Value);
                    }
                }
                AntecedentesGeraisRegra antecedentesGeraisRegra = new AntecedentesGeraisRegra();
                bool antecedentesGerais = antecedentesGeraisRegra.Cadastrar(IDCONSULTA, vasculares,vascularesTratamento,diabetes,diabetesTratamento,imunes,imunesTratamento,neurologicos,
                    neurologicosTratamento,outros, outrosConfirm, outrosTratamento,txtObservacaoAntecedentesGerais.Text);
                return antecedentesGerais;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar os Antecedentes Gerais(Formulario frmCadastrarConsulta, Método CadastrarAntecedentesGerais)",
                    "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarAntecedentesOculares(string IDCONSULTA)
        {
            try
            {
                bool[] possuir = new bool[15];
                string[] tratamento = new string[15];
                for (int i = 0; i < possuir.Length; i++)
                {
                    possuir[i] = false;
                }
                for (int i = 0; i < tratamento.Length; i++)
                {
                    tratamento[i] = "";
                }

                string outros = "";
                bool outrosConfirm = false;

                int linhas = dtgAntecedentesOculares.Rows.Count;
                for (int i = 0; i < linhas; i++)
                {
                    if (i<14)
                    {
                        bool teste = false;
                       teste = Convert.ToBoolean(dtgAntecedentesOculares.Rows[i].Cells["confirmacaoPatologiaAntecedentesOculares"].Value);
                        possuir[i] = teste;
                    }
                    else
                    {
                        outros = Convert.ToString(dtgAntecedentesOculares.Rows[i].Cells["patologiaAntecedentesOculares"].Value);
                        outrosConfirm = Convert.ToBoolean(dtgAntecedentesOculares.Rows[i].Cells["confirmacaoPatologiaAntecedentesOculares"].Value);
                    }
                    tratamento[i] = Convert.ToString(dtgAntecedentesOculares.Rows[i].Cells["TipoTratamentoAntecedentesOculares"].Value);
                }

               AntecedentesOcularesRegra antecedentesOcularesRegra = new AntecedentesOcularesRegra();
                bool antecedentesOculares = antecedentesOcularesRegra.Cadastrar(IDCONSULTA, possuir[0], tratamento[0], possuir[1], tratamento[1], possuir[2], tratamento[2], possuir[3], tratamento[3], possuir[4], tratamento[4], 
                    possuir[5], tratamento[5], possuir[6], tratamento[6], possuir[7], tratamento[7], possuir[8], tratamento[8], possuir[9], tratamento[9], possuir[10], tratamento[10],
                    possuir[11], tratamento[11], possuir[12], tratamento[12], possuir[13], tratamento[13], outros,Convert.ToString( outrosConfirm), tratamento[14]);
                return antecedentesOculares;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar os Antecedentes Oculares(Formulario frmCadastrarConsulta, MétodoCadastrarAntecedentesOculares)",
                    "erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarLensometria(string IDCONSULTA)
        {
            try
            {
                LensometriaRegra lensometria = new LensometriaRegra();

                string[,] ArrayLensometria = new string[4, 6];
                string[] colunas = { "EsferaLensometria", "cilindroLensometria", "eixoLensometria", "adicaoLensometria", "prismaLensometria", "baseLensometria" };
                for (int l = 0; l < 4; l++)//linha 
                {
                    for (int c = 0; c < 6; c++)//coluna
                    {
                        ArrayLensometria[l, c] = Convert.ToString(dtgLensometria.Rows[l].Cells[colunas[c]].Value);
                    }
                }

                return  lensometria.CadastrarLensometria(IDCONSULTA,
                    ArrayLensometria[0, 0], ArrayLensometria[1, 0], ArrayLensometria[2, 0], ArrayLensometria[3, 0],//Esfera
                    ArrayLensometria[0, 1], ArrayLensometria[1, 1], ArrayLensometria[2, 1], ArrayLensometria[3, 1],//Cilindro
                    ArrayLensometria[0, 2], ArrayLensometria[1, 2], ArrayLensometria[2, 2], ArrayLensometria[3, 2],//Eixo

                    ArrayLensometria[0, 3], ArrayLensometria[1, 3], ArrayLensometria[2, 3], ArrayLensometria[3, 3],//Adicao
                    ArrayLensometria[0, 4], ArrayLensometria[1, 4], ArrayLensometria[2, 4], ArrayLensometria[3, 4],//Prima
                    ArrayLensometria[0, 5], ArrayLensometria[1, 5], ArrayLensometria[2, 5], ArrayLensometria[3, 5],//Base
                    txtTipoLenteLensometria.Text, txtTipoMaterialLensometria.Text, txtCorLensometria.Text, txtEstadoLensometria.Text, txtObservacaoLensometria.Text);;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Lensometria(Formulario frmCadastrarConsulta, Método CadastrarLensometria)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarOftalmoscopia(string IDCONSULTA)
        {
            try
            {
                OftalmoscopiaRegra oftalmoscopiaRegra = new OftalmoscopiaRegra();
                bool oftalmoscopia =oftalmoscopiaRegra.Cadastrar(IDCONSULTA, txtDistanciaBrucknerOftalmoscopia.Text, txtPapilaOdOftalmoscopia.Text, txtPapilaOeOftalmoscopia.Text, txtEscavacaoOdOftalmoscopia.Text,
                    txtEscavacaoOeOftalmoscopia.Text, txtMaculaOdOftalmoscopia.Text, txtMaculaOeOftalmoscopia.Text, txtFixacaoOdOftalmoscopia.Text,txtFixacaoOeOftalmoscopia.Text,
                    txtRelacaoAVOdOftalmoscopia.Text,txtRelacaoAVOeOftalmoscopia.Text,txtCorOdOftalmoscopia.Text,txtCorOeOftalmoscopia.Text,txtLenteOdOftalmoscopia.Text,
                    txtLenteOeOftalmoscopia.Text,txtObservacaoOftalmoscopia.Text);
                return oftalmoscopia;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Oftalmoscopia(Formulario frmCadastrarConsulta, Método CadastrarOftalmoscopia)","Erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarRxFinal(string IDCONSULTA)
        {
            try
            {
                string[,] ArrayRxFinal = new string[4,4];
                string[] colunas = {"EsferaRxFinal", "cilindroRxFinal","eixoRxFinal","avRxFinal" };
                for (int l = 0; l < 4; l++)//linha 
                {
                    for (int c = 0; c < 4; c++)//coluna
                    {
                        ArrayRxFinal[l, c] = Convert.ToString( dtgRxFinal.Rows[l].Cells[colunas[c]].Value);
                    }
                }

                RxFinalRegra rxFinalRegra = new RxFinalRegra();

                bool rxFinal = rxFinalRegra.Cadastrar(IDCONSULTA,
                    ArrayRxFinal[0, 0], ArrayRxFinal[1, 0], ArrayRxFinal[2, 0], ArrayRxFinal[3, 0],//Esfera
                    ArrayRxFinal[0, 1], ArrayRxFinal[1, 1], ArrayRxFinal[2, 1], ArrayRxFinal[3, 1],//Cilindro
                    ArrayRxFinal[0, 2], ArrayRxFinal[1, 2], ArrayRxFinal[2, 2], ArrayRxFinal[3, 2],//Eixo
                    ArrayRxFinal[0, 3], ArrayRxFinal[1, 3], ArrayRxFinal[2, 3], ArrayRxFinal[3, 3],//Av
                   txtAdicaoRxFinal.Text, txtDpRxFinal.Text, txtTipoMaterialRxFinal.Text, txtCorRxFinal.Text,
                  txtUsoRxFinal.Text, txtTipoLenteRxFinal.Text, txtObservacaoRxFinal.Text);
                return rxFinal;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o RxFinal(Formulario frmCadastrarConsulta, Método CadastrarRxFinal)","erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarRxInicial(string IDCONSULTA)
        {
            try
            {
                string[,] ArrayRxInicial = new string[4, 4];
                string[] colunas = { "EsferaRxInicial", "cilindroRxInicial", "eixoRxInicial", "avRxInicial" };
                for (int l = 0; l < 4; l++)//linha 
                {
                    for (int c = 0; c < 4; c++)//coluna
                    {
                        ArrayRxInicial[l, c] = Convert.ToString(dtgRxInicial.Rows[l].Cells[colunas[c]].Value);
                    }
                }

                RxInicialRegra RxInicialRegra = new RxInicialRegra();

                bool RxInicial = RxInicialRegra.Cadastrar(IDCONSULTA,
                    ArrayRxInicial[0,0], ArrayRxInicial[1,0], ArrayRxInicial[2,0], ArrayRxInicial[3,0], //Esfera
                    ArrayRxInicial[0,1], ArrayRxInicial[1,1], ArrayRxInicial[2,1], ArrayRxInicial[3,1],//Cilindro

                    ArrayRxInicial[0,2], ArrayRxInicial[1,2], ArrayRxInicial[2,2], ArrayRxInicial[3,2],//Eixo
                    ArrayRxInicial[0,3], ArrayRxInicial[1,3], ArrayRxInicial[2,3], ArrayRxInicial[3,3],//Av
                  txtAdicaoRxInicial.Text,txtDpRxInicial.Text,txtTipoMaterialRxInicial.Text, txtCorRxInicial.Text,
                  txtUsoRxInicial.Text, txtTipoLenteRxInicial.Text, txtObservacaoRxInicial.Text);
                return RxInicial;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o RxInicial(Formulario frmCadastrarConsulta, Método CadastrarRxInicial)", "erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarSintomasReferidos(string IDCONSULTA)
        {
            try
            {
                bool[] sintomas = new bool[dtgSintomasReferidos.Rows.Count];
                string outros = "";
                bool outrosConfirm =false;
                for (int i = 0; i < dtgSintomasReferidos.Rows.Count ; i++)
                {
                    if (Convert.ToString(dtgSintomasReferidos.Rows[i].Cells["confirmacaoSintomasReferidos"].Value) == "true")
                    {
                        sintomas[i] = true;
                    } 
                    else
                    {
                        sintomas[i] = false;
                    }
                    if (dtgSintomasReferidos.Rows.Count - 1 == i)
                    {
                        outros = Convert.ToString(dtgSintomasReferidos.Rows[i].Cells["sintomaSintomasReferidos"].Value);
                        //if (Convert.ToString(dtgSintomasReferidos.Rows[i].Cells["confirmacaoSintomasReferidos"].Value) == "true") outrosConfirm = true;
                        //if (Convert.ToString(dtgSintomasReferidos.Rows[i].Cells["confirmacaoSintomasReferidos"].Value) != "true") outrosConfirm = false;
                    }
                }
                SintomasReferidosRegra sintomasReferidosRegra = new SintomasReferidosRegra();
              bool sintomasReferidos =  sintomasReferidosRegra.Cadastrar(IDCONSULTA, sintomas[0], sintomas[1], sintomas[2], sintomas[3], sintomas[4], sintomas[5], sintomas[6], sintomas[7], sintomas[8], sintomas[9], sintomas[10],
                    sintomas[11], sintomas[12], sintomas[13], sintomas[14], sintomas[15], outros,sintomas[16]);
                return sintomasReferidos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar os Sintomas Referidos(Formulario frmCadastrarConsulta, Método CadastrarSintomasReferidos)", "Erro de cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarMotilidadeOcular(string IDCONSULTA)
        {
            try
            {
                MotilidadeOcularRegra motilidade = new MotilidadeOcularRegra();
                return motilidade.CadastrarMotilidadeOcular(IDCONSULTA, txtKappaOd.Text, txtKappaOe.Text, txtHirsChberg.Text, txtDucaoOd.Text, txtDucaoOe.Text,
                    motilidade.ConcatenarVersoes(txtVersaoOd1.Text,txtVersaoOd2.Text,txtVersaoOd3.Text,txtVersaoOd4.Text,txtVersaoOd5.Text,txtVersaoOd6.Text),
                    motilidade.ConcatenarVersoes(txtVersaoOe1.Text,txtVersaoOe2.Text,txtVersaoOe3.Text,txtVersaoOe4.Text,txtVersaoOe5.Text,txtVersaoOe6.Text),
                    txtObservacaoMotilidade.Text,txtFotomotorOd.Text,txtFotomotorOe.Text,txtConsensualOd.Text,txtConsensualOe.Text,txtAcomodativoOd.Text,
                    txtAcomodativoOe.Text,txtBalancoMotilidade.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar Motilidade Ocular(Formulario frmCadastrarConsulta, Método CadastrarMotilidadeOcular)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarBiomicroscopia(string IDCONSULTA)
        {
            try
            {
                BiomicroscopiaRegra biomicroscopia = new BiomicroscopiaRegra();

                return biomicroscopia.CadastrarBiomicroscopia(IDCONSULTA, txtSobrancelhaOd.Text, txtSobrancelhaOe.Text, txtCiliosOd.Text, txtCiliosOe.Text, txtPalpebrasOd.Text,
                    txtPalpebrasOe.Text, txtConjuntivasOd.Text, txtConjuntivasOe.Text, txtEscleroticasOd.Text, txtEscleroticasOe.Text, txtCorneasOd.Text, txtCorneasOe.Text,
                    txtIrisOd.Text, txtIrisOe.Text, txtCristalinoOd.Text, txtCristalinoOe.Text, txtCamaraAnteriorOd.Text, txtCamaraAnteriorOe.Text, txtObservacaoBiomicroscopia.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a biomicroscopia(Formulario frmCadastrarConsulta, Método CadastrarBiomicroscopia)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarCeratometria(string IDCONSULTA)
        {
            try
            {
                CeratometriaRegra ceratometria = new CeratometriaRegra();
                return ceratometria.CadastrarCeratometria(IDCONSULTA, txtOlhoDireitoCeratometria.Text, txtOlhoEsquerdoCeratometria.Text,
                    txtTipoCeratometro.Text,txtObservacaoCeratometria.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro cadastrar Ceratometria(Formulario frmCadastrarConsulta, Método CadastrarCeratometria)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastarRetinoscopia(string IDCONSULTA)
        {
            try
            {
                RetinoscopiaRegra retinoscopia = new RetinoscopiaRegra();
                return retinoscopia.CadastrarRetinoscopia(IDCONSULTA, txtEstaticaOd.Text,txtEstaticaOe.Text,txtDinamicaOd.Text,txtDinamicaOe.Text,
                    txtSubjetivoOd.Text,txtSubjetivoOe.Text,txtAfinamentoOd.Text,txtAfinamentoOe.Text,txtAdicaoNivelOd.Text,txtAdicaoNivelOe.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Retinocospia(Formulario frmCadastrarConsulta, Método CadastrarRetinoscopia)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarForometria(string IDCONSULTA)
        {
            try
            {
                ForometriaRegra forometria = new ForometriaRegra();
                string correcao = "";

                if (rbComCorrecao.Checked == true)correcao = "True";
                if(rbSemCorrecao.Checked == true) correcao = "False";

                return forometria.CadastrarForometria(IDCONSULTA, txtTesteUtilizado.Text, correcao, txtVlOd.Text, txtVlOe.Text, txt40CmOd.Text, txt40CmOe.Text, txt20CmOd.Text, txt20CmOe.Text,
                    txtPpcOr.Text, txtPpcLuz.Text, txtPpcFiltro.Text, txtPfpVl.Text,txtPfpVp.Text,txtRfnVl.Text, txtRfnVp.Text, txtAaOd.Text, txtAaOe.Text, txtFlexibilidadeOd.Text, 
                    txtFlexibilidadeOe.Text,txtMetodoForometria.Text,txtNivelVisualForometria.Text,txtDtForometria.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Retinoscopia(Formulario frmCadastrarConsulta, Método CadastrarForometria)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarVisaoCor(string IDCONSULTA)
        {
            try
            {
                VisaoCorRegra visaoCor = new VisaoCorRegra();
                return visaoCor.CadastrarVisaoCor(IDCONSULTA, txtTesteVisaoCor.Text, txtVisaoCorOd.Text, txtVisaoCorOe.Text, txtInterpretacaoVisaoCor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Visão de Cor(Formulario frmCadastrarConsulta, Método CadastrarVisaoCor)", "Erro de Consulta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarAmsler(string IDCONSULTA)
        {
            try
            {
                AmslerRegra amsler = new AmslerRegra();
                return amsler.CadastrarAmsler(IDCONSULTA, txtAmslerOd.Text, txtAmslerOe.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Amsler(Formulario frmCadastrarConsulta, Método CadastrarAmsler)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarEsteopsia(string IDCONSULTA)
        {
            try
            {
                EstereopsiaRegra estereopsia = new EstereopsiaRegra();
                return estereopsia.CadastrarEstereopsia(IDCONSULTA, txtTesteEstereopsia.Text, txtResultadoEstereopsia.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Estereopsia(Formulario frmCadastrarConsulta, Método CadastraEstereopsia)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        void Cadastrar()
        {
            bool confirmGeral = true, confirmConsulta = false;
            bool[] confirmacao = new bool[17];

            ConsultaRegra consultaRegra = new ConsultaRegra();

            confirmConsulta = consultaRegra.Cadastrar(idPaciente, idProfissional, idUsuarioSistema, txtOrigem.Text, txtHobbies.Text, txtEncaminhadoPor.Text,
                txtAjudaOpticaPrescrita.Text, dtpUltimaConsulta.Value, txtTranscricaoLentes.Text, txtObservacaoReceita.Text, "Atendimento Finalizado", txtObservacaoConsulta.Text);

            DataTable dados = new DataTable();
            dados = consultaRegra.PesquisarUltimoId();
            string idUlitmaConsulta = dados.Rows[0]["idConsulta"].ToString();

            confirmacao[0] = CadastrarAcuidadeVisual(idUlitmaConsulta);
            confirmacao[1] = CadastrarAnamnese(idUlitmaConsulta);
            confirmacao[2] = CadastrarAntecedentesGerais(idUlitmaConsulta);
            confirmacao[3] = CadastrarAntecedentesOculares(idUlitmaConsulta);
            confirmacao[4] = CadastrarOftalmoscopia(idUlitmaConsulta);
            confirmacao[5] = CadastrarRxFinal(idUlitmaConsulta);
            confirmacao[6] = CadastrarRxInicial(idUlitmaConsulta);
            confirmacao[7] = CadastrarSintomasReferidos(idUlitmaConsulta);
            confirmacao[8] = CadastrarLensometria(idUlitmaConsulta);
            confirmacao[9] = CadastrarMotilidadeOcular(idUlitmaConsulta);
            confirmacao[10] = CadastrarBiomicroscopia(idUlitmaConsulta);
            confirmacao[11] = CadastrarCeratometria(idUlitmaConsulta);
            confirmacao[12] = CadastarRetinoscopia(idUlitmaConsulta);
            confirmacao[13] = CadastrarForometria(idUlitmaConsulta);
            confirmacao[14] = CadastrarVisaoCor(idUlitmaConsulta);
            confirmacao[15] = CadastrarAmsler(idUlitmaConsulta);
            confirmacao[16] = CadastrarEsteopsia(idUlitmaConsulta);


            for (int i = 0; i < confirmacao.Length; i++)
            {
                if (confirmacao[i] == false)
                {
                    MessageBox.Show("Ocorreu um erro no cadastro de alguma das tabelas", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    confirmGeral = false;
                    break;
                }
            }

           AgendamentosRegra finalizar = new AgendamentosRegra();
            bool finalizarConsulta = finalizar.FinalizarConsultaAgendada(Convert.ToInt32(idPaciente));

            if (finalizarConsulta == true && confirmGeral == true && confirmConsulta == true)
            {
                if (MessageBox.Show("Consulta cadastrada com sucesso!\nDeseja retornar ao formulario principal?",
                     "Cadastro Realizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //frmPrincipal voltar = new frmPrincipal(idUsuarioSistema, idNivel, loginUsuario, nomeNivel);
                    //voltar.Show();
                    this.Dispose();
                }
                else limpar();
            }
        }
        #endregion
        private void AtualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarConsultas(idConsulta);
        }
        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aunteUsuario.NovaConsulta(idNivel) == true)//Verifica se o usuário do sistema tem autorização para realizar consultas.
            {
                if (RetornarIdProfissional(idUsuarioSistema) == true)//Verifica se o id do profissional é válido(Acima de 0).
                {
                    if (Convert.ToInt32(idPaciente) > 0)//ver
                    {
                        Cadastrar();
                    }
                    else
                    {
                        MessageBox.Show("Para Proseguir com a consulta Adicione um Paciente", "Falta Paciente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (MessageBox.Show("Cadastro profissional não encontrado!\nDeseja retornar ao formulario principal?", "Acesso Negado!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Para Salvar uma nova consulta é necessario ser um profissional ou administrador \n Usuario: " + loginUsuario + " Nivel de Acesso: " + nomeNivel, "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void limpar()
        {

        }
        void CarregarDadosEstaticosDosDtg()
        {
            /*Método responsável por incluir em tempo de execução dados dados estaticos em multiplos dataGridView cada um com suas informações estaticas que não necessitam ser alteradas*/
            #region dtgSintomasReferidos
            string[] sintomasReferidos ={"Visão Borrada", "Cefaléia", "Lacrimejamento", "Olho Vermelho", "Visão Dupla","Fotopsias-Fosfenos","Miodesopsias", "Dor de Cabeça","Astenopia","Dor Ocular","Ardência","Secreções",
               "Coceira","Fotofobia","Halos","Estrabismos",""};
            foreach (var i in sintomasReferidos)
            {
                dtgSintomasReferidos.Rows.Add(i);
            }
            for (int i = 0; i < dtgSintomasReferidos.Rows.Count; i++)
            {
                dtgSintomasReferidos.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                dtgSintomasReferidos.ForeColor = Color.Black;
                i++;
            }
            dtgSintomasReferidos.AutoResizeColumns();
            #endregion

            #region RxInicial
            string[] olhoRxincial = { "VL OD", "VL OE", "VP OD", "VP OE" };
            foreach (var item in olhoRxincial)
            {
                dtgRxInicial.Rows.Add(item);
            }
            for (int i = 0; i < dtgRxInicial.Rows.Count; i++)
            {
                dtgRxInicial.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                dtgRxInicial.ForeColor = Color.Black;
                i++;
            }
            #endregion

            #region RxFinal
            string[] olhoRxFinal = { "VL OD", "VL OE", "VP OD", "VP OE" };
            foreach (var item in olhoRxFinal)
            {
               dtgRxFinal.Rows.Add(item);
            }
            for (int i = 0; i < dtgRxInicial.Rows.Count; i++)
            {
                dtgRxFinal.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                dtgRxFinal.ForeColor = Color.Black;
                i++;
            }
            #endregion

            #region Lensometria
            string[] Lensometria = { "VL OD", "VL OE", "VP OD", "VP OE" };
            foreach (var item in Lensometria)
            {
                dtgLensometria.Rows.Add(item);
            }
            for (int i = 0; i < dtgLensometria.Rows.Count; i++)
            {
                dtgLensometria.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                dtgLensometria.ForeColor = Color.Black;
                i++;
            } 
            #endregion

            #region AntecedentesGerais
            string[] patologiaAntecedentesGerais = { "Vasculasres", "Diabetes", "Imunes", "Neurológicos", "" };
            foreach (var item in patologiaAntecedentesGerais)
            {
                dtgAntecedentesGerais.Rows.Add(item);
            }
            for (int i = 0; i < dtgAntecedentesGerais.Rows.Count; i++)
            {
                dtgAntecedentesGerais.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                dtgAntecedentesGerais.ForeColor = Color.Black;
                i++;
            }
            dtgAntecedentesGerais.AutoResizeColumn(0);
            #endregion

            #region Antecedentes Oculares
            string[] patologiaAntecedentesOculares = {"Trauma Ocular","Corpo Estranho","Queimaduras","Cirúrgicos","Inflamações","Catarata","Glaucoma","Cegueira","Descolamento da Retina","Toxoplasmose",
            "Estrabismo","Alérgicos","Pterígio","Defeitos de Refração",""};
            foreach (var item in patologiaAntecedentesOculares)
            {
                dtgAntecedentesOculares.Rows.Add(item);
            }
            for (int i = 0; i < dtgAntecedentesOculares.Rows.Count; i++)
            {
                dtgAntecedentesOculares.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                dtgAntecedentesOculares.ForeColor = Color.Black;

                i++;
            }
            dtgAntecedentesOculares.AutoResizeColumn(0);
            #endregion

            #region Acuidade Visual
            string[] OlhoAcuidadeVisual = { "OD", "OE", "AO" };
            foreach (var item in OlhoAcuidadeVisual)
            {
                dtgAcuidadeVisual.Rows.Add(item, "", "", "", item);
            }
            for (int i = 0; i < dtgAcuidadeVisual.Rows.Count; i++)
            {
                dtgAcuidadeVisual.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                dtgAcuidadeVisual.ForeColor = Color.Black;
                i++;
            } 
            #endregion
        }
        void CentralizarComponentes()
        {
            //pnlMenuSuperior.Width = this.Width;

            ////Consulta
            //{
            //    rbConsulta.Checked = true;
            //    gbConsulta.Visible = true;
            //    gbConsulta.Location = new Point(tpConsulta.Width / 2 - (gbConsulta.Width / 2), Convert.ToInt32(tpConsulta.Height / 2 - (gbConsulta.Height / 2)));
            //    gbReceita.Location = new Point(tpConsulta.Width / 2 - (gbReceita.Width / 2), Convert.ToInt32(tpConsulta.Height / 2 - (gbReceita.Height / 2)));
            //}
            ////Anamnese
            //{
            //    gbAnamnese.Location = new Point(tpAnamnese.Width / 2 - (gbAnamnese.Width / 2), tpAnamnese.Height / 2 - (gbAnamnese.Height / 2));
            //}
            ////Antecedentes
            //{
            //    rbAntecedentesGerais.Checked = true;
            //    gbAntecedentesGerais.Visible = true;
            //    gbAntecedentesGerais.Location = new Point(tpAntecedentes.Width / 2 - (gbAntecedentesGerais.Width / 2), tpAntecedentes.Height / 2 - (gbAntecedentesGerais.Height / 2));
            //    gbAntecedentesOculares.Location = new Point(tpAntecedentes.Width / 2 - (gbAntecedentesOculares.Width / 2), tpAntecedentes.Height / 2 - (gbAntecedentesOculares.Height / 2));
            //}
            ////Sintomas Referidos
            //{
            //    gbSintomasReferidos.Location = new Point(tpSintomasReferidos.Width / 2 - (gbSintomasReferidos.Width / 2), Convert.ToInt32(tpSintomasReferidos.Height / 2 - (tpSintomasReferidos.Width / 5)));
            //}
            ////Oftalmoscopia
            //{
            //    gbOftalmoscopia.Location = new Point(tpOftalmoscopia.Width / 2 - (gbOftalmoscopia.Width / 2), tpOftalmoscopia.Height / 2 - (gbOftalmoscopia.Height / 2));
            //}
            ////rx
            //{
            //    rbRxInicial.Checked = true;
            //    gbRxInicial.Visible = true;
            //    gbRxInicial.Location = new Point(tpRx.Width / 2 - (gbRxInicial.Width / 2), tpRx.Height / 2 - (gbRxInicial.Height / 2));
            //    gbRxFinal.Location = new Point(tpRx.Width / 2 - (gbRxFinal.Width / 2), tpRx.Height / 2 - (gbRxFinal.Height / 2));
            //}
            ////Acuidade Visual
            //{
            //    gbAcuidadeVisual.Location = new Point(tpAcuidadeVisual.Width / 2 - (gbAcuidadeVisual.Width / 2), tpAcuidadeVisual.Height / 2 - (gbAcuidadeVisual.Height / 2));
            //}
            ////Deixar as colunas do dtgPaciente com largura automatica
            //dtgPaciente.AutoResizeColumns();
        }
        private void frmCadastrarConsulta_Load(object sender, EventArgs e)
        {
            lblLoginUsuario.Text = "Usuário: " + loginUsuario + "   Nivel: " + nomeNivel;
            CarregarDadosEstaticosDosDtg();
            CentralizarComponentes();

            salvarToolStripMenuItem.Visible = true;
            AtualizarToolStripMenuItem.Visible = false; 
           
            limpar();
            if (Convert.ToInt32(idPaciente) > 0)
            {
                CarregarPaciente(idPaciente);
            }
            if (Convert.ToInt32(idConsulta) > 0)
            {
                salvarToolStripMenuItem.Visible = false;
                AtualizarToolStripMenuItem.Visible = true;
                RetornarChaves(idConsulta);
            }
        }
        private void ComponentesPaciente(object sender, MouseEventArgs e)
        {
            MessageBox.Show("As Informações do paciente não podem ser alteradas neste formulario. Para realizar tal ação acesse o formulario de pesquisa de pacientes e clique em editar!",
                "Ação inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //frmPrincipal formularioPrincipal = new frmPrincipal(idUsuarioSistema, idNivel, loginUsuario, nomeNivel);
            //formularioPrincipal.Show();
            this.Dispose();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void btnAdicionarPaciente_Click(object sender, EventArgs e)
        {
            frmLocalizarPaciente pesquisarPaciente = new frmLocalizarPaciente(idUsuarioSistema, idNivel, loginUsuario, nomeNivel);
            pesquisarPaciente.ShowDialog();
            this.Hide();
        }
        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
