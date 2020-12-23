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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            EditarConsultas(idConsulta);
        }
        public frmCadastrarConsulta(string idUsuario, string idNivel, string loginUsuario, string nomeNivel)
        {
            InitializeComponent();
            this.idUsuarioSistema = idUsuario;
            this.idNivel = idNivel;
            this.loginUsuario = loginUsuario;
            this.nomeNivel = nomeNivel;
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
                EditarAcuidadeVisualRegra editarAcuidade = new EditarAcuidadeVisualRegra();

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
                EditarAnamneseRegra editarAnamnese = new EditarAnamneseRegra();
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
                EditarAntecedentesGeraisRegra editarAntecedentesGerais = new EditarAntecedentesGeraisRegra();
                string vasculares = "", vascularesTratamento = "";
                string diabetes = "", diabetesTratamento = "";
                string imunes = "", imunesTratamento = "";
                string neurologicos = "", neurologicosTratamento = "";
                string outros = "", outrosTratamento = "";

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
                        outros = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["patologiaAntecedentesGerais"].Value);
                        outrosTratamento = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["tipoTratamentoAntecedentesGerais"].Value);
                    }
                }
                return editarAntecedentesGerais.Editar(Convert.ToInt32(idConsulta), vasculares, vascularesTratamento, diabetes, diabetesTratamento, imunes, imunesTratamento, neurologicos,
                    neurologicosTratamento, outros, outrosTratamento, txtObservacaoAntecedentesGerais.Text);
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
                EditarAntecedentesOcularesRegra antecedentesOcularesRegra = new EditarAntecedentesOcularesRegra();
                bool[] possuir = new bool[15];
                string[] tratamento = new string[15];
                string outros = "";
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
                        tratamento[i] = Convert.ToString(dtgAntecedentesOculares.Rows[i].Cells["TipoTratamentoAntecedentesOculares"].Value);
                    }
                }
                bool antecedentesOculares = antecedentesOcularesRegra.Editar(Convert.ToInt32(idConsulta), possuir[0], tratamento[0], possuir[1], tratamento[1], possuir[2], tratamento[2], possuir[3], tratamento[3], possuir[4], tratamento[4],
                    possuir[5], tratamento[5], possuir[6], tratamento[6], possuir[7], tratamento[7], possuir[8], tratamento[8], possuir[9], tratamento[9], possuir[10], tratamento[10],
                    possuir[11], tratamento[11], possuir[12], tratamento[12], possuir[13], tratamento[13], outros, tratamento[14]);
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
                EditarOftalmoscopiaRegra editarOftalmoscopoia = new EditarOftalmoscopiaRegra();
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
                EditarRxFinalRegra editarRxFinal = new EditarRxFinalRegra();
                string[,] ArrayRxFinal = new string[4, 6];
                string[] colunas = { "EsferaRxFinal", "cilindroRxFinal", "eixoRxFinal", "adicaoRxFinal", "prismaRxFinal", "baseRxFinal" };
                for (int l = 0; l < 4; l++)//linha 
                {
                    for (int c = 0; c < 6; c++)//coluna
                    {
                        ArrayRxFinal[l, c] = Convert.ToString(dtgRxFinal.Rows[l].Cells[colunas[c]].Value);
                    }
                }

                bool rxFinal = editarRxFinal.Editar(Convert.ToInt32(idConsulta),
                    ArrayRxFinal[0, 0], ArrayRxFinal[1, 0], ArrayRxFinal[2, 0], ArrayRxFinal[3, 0], /*esfera*/
                    ArrayRxFinal[0, 1], ArrayRxFinal[1, 1], ArrayRxFinal[2, 1], ArrayRxFinal[3, 1],/*Cilindro*/
                    ArrayRxFinal[0, 2], ArrayRxFinal[1, 2], ArrayRxFinal[2, 2], ArrayRxFinal[3, 2],/*Eixo*/

                    ArrayRxFinal[0, 3], ArrayRxFinal[1, 3], ArrayRxFinal[2, 3], ArrayRxFinal[3, 3],/*adicao*/
                    ArrayRxFinal[0, 4], ArrayRxFinal[1, 4], ArrayRxFinal[2, 4], ArrayRxFinal[3, 4],/*prisma*/
                    ArrayRxFinal[0, 5], ArrayRxFinal[1, 5], ArrayRxFinal[2, 5], ArrayRxFinal[3, 5],/*base*/
                    txtTipoLenteRxFinal.Text, txtTipoMaterialRxFinal.Text, txtCorRxFinal.Text, txtEstadoRxFinal.Text, txtObservacaoRxFinal.Text);
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
                EditarRxInicialRegra editarRxInicial = new EditarRxInicialRegra();
                string[,] ArrayRxInicial = new string[4, 6];
                string[] colunas = { "EsferaRxInicial", "cilindroRxInicial", "eixoRxInicial", "adicaoRxInicial", "prismaRxInicial", "baseRxInicial" };
                for (int l = 0; l < 4; l++)//linha 
                {
                    for (int c = 0; c < 6; c++)//coluna
                    {
                        ArrayRxInicial[l, c] = Convert.ToString(dtgRxInicial.Rows[l].Cells[colunas[c]].Value);
                    }
                }

                bool RxInicial = editarRxInicial.Editar(Convert.ToInt32(idConsulta), 
                    ArrayRxInicial[0, 0], ArrayRxInicial[1, 0], ArrayRxInicial[2, 0], ArrayRxInicial[3, 0], /*esfera*/
                    ArrayRxInicial[0, 1], ArrayRxInicial[1, 1], ArrayRxInicial[2, 1], ArrayRxInicial[3, 1],/*Cilindro*/
                    ArrayRxInicial[0, 2], ArrayRxInicial[1, 2], ArrayRxInicial[2, 2], ArrayRxInicial[3, 2],/*Eixo*/

                    ArrayRxInicial[0, 3], ArrayRxInicial[1, 3], ArrayRxInicial[2, 3], ArrayRxInicial[3, 3],/*adicao*/
                    ArrayRxInicial[0, 4], ArrayRxInicial[1, 4], ArrayRxInicial[2, 4], ArrayRxInicial[3, 4],/*prisma*/
                    ArrayRxInicial[0, 5], ArrayRxInicial[1, 5], ArrayRxInicial[2, 5], ArrayRxInicial[3, 5],/*base*/
                    txtTipoLenteRxInicial.Text, txtTipoMaterialRxInicial.Text, txtCorRxInicial.Text, txtEstadoRxInicial.Text, txtObservacaoRxInicial.Text);
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
                EditarSintomasReferidosRegra editarSintomas = new EditarSintomasReferidosRegra();

                bool[] sintomas = new bool[17];
                string outros = "";
                string Sintoma = "";
                for (int i = 0; i < dtgSintomasReferidos.Rows.Count ; i++)
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
                bool sintomasReferidos = editarSintomas.Editar(Convert.ToInt32(idConsulta), sintomas[0], sintomas[1], sintomas[2], sintomas[3], sintomas[4], sintomas[5], sintomas[6], sintomas[7], sintomas[8], sintomas[9], sintomas[10],
                      sintomas[11], sintomas[12], sintomas[13], sintomas[14], sintomas[15], outros);
                return sintomasReferidos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os Sintomas Referidos(Formulario frmCadastrarConsulta, Método EditarSintomasReferidos)",
                    "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        void EditarConsultas(string idConsulta)
        {
            try
            {
                if (Convert.ToInt32(idConsulta) > 0)
                {
                    bool[] arrayconfirm = new bool[10];
                    arrayconfirm[0] = EditarAcuidadeVisual(idConsulta);
                    arrayconfirm[1] = EditaAnamnese(idConsulta);
                    arrayconfirm[2] = EditarAntecedentesGerais(idConsulta);
                    arrayconfirm[3] = EditarAntecedentesOculares(idConsulta);
                    arrayconfirm[4] = EditarOftalmoscopia(idConsulta);
                    arrayconfirm[5] = EditarRxFinal(idConsulta);
                    arrayconfirm[6] = EditarRxInicial(idConsulta);
                    arrayconfirm[7] = EditarSintomasReferidos(idConsulta);

                    EditarConsultaRegra editarConsulta = new EditarConsultaRegra();
                    bool confirmAtualizacao = editarConsulta.Atualizar(idConsulta, txtOrigem.Text, txtHobbies.Text, txtEncaminhadoPor.Text,
                        txtAjudaOpticaPrescrita.Text, dtpDataUltimoExame.Value, txtTrascricaoLentes.Text, txtObservacaoReceita.Text, cbStatusConsulta.Text, txtObservacaoConsulta.Text);

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
                LocalizarConsultaRegra pesquisarChaves = new LocalizarConsultaRegra();
                if (Convert.ToInt32(IDCONSULTA) >0)
                {
                    //dadosTabela = pesquisarChaves.u(idConsulta);
                    if (dtgIntermediario.Rows.Count-1>0)
                    {
                        dtgIntermediario.Rows.Clear();
                    }
                   dtgIntermediario.DataSource = dadosTabela;
                    RetornarConsulta(IDCONSULTA);
                    RetornarPaciente(IDCONSULTA);
                    RetornarAnamnese(IDCONSULTA);
                    RetornarSintomasReferidos(IDCONSULTA);
                    RetornarAntecedentesGerais(IDCONSULTA);
                    RetornarAntecedentesOculares(IDCONSULTA);
                    RetornarRxInicial(IDCONSULTA);
                    RetornarRxFinal(IDCONSULTA);
                    RetornarAcuidadeVisual(IDCONSULTA);
                    RetornarOftalmoscopia(IDCONSULTA);
                }
                else
                {
                    MessageBox.Show("O Código da consulta a ser pesquisada não é valido pois é menor ou igual a 0","Dados Inválidos",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                LocalizarConsultaRegra pesquisarConsulta = new LocalizarConsultaRegra();
                if (Convert.ToInt32(idConsulta)>0)
                {
                    dadosTabela = pesquisarConsulta.CodigoConsulta(idConsulta);
                    dtgIntermediario.DataSource = dadosTabela;
                    int linhasDataTable = dtgIntermediario.Rows.Count;
                    if (linhasDataTable > 0)
                    {
                        txtOrigem.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["origem"].Value);
                        txtHobbies.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["hobbies"].Value);
                        txtEncaminhadoPor.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["encaminhadoPor"].Value);
                        txtAjudaOpticaPrescrita.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["ajudaOpticaPrescrita"].Value);
                        dtpDataUltimoExame.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["dataUltimoExame"].Value);
                        cbStatusConsulta.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["statusConsulta"].Value);
                        txtObservacaoConsulta.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["observacaoConsulta"].Value);
                        txtTrascricaoLentes.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["transcricaoLentes"].Value);
                        txtObservacaoReceita.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["observacaoReceita"].Value);
                    }
                    else
                    {
                        MessageBox.Show("A pesquisa da consulta por seu código identificador não retornou nenhum resultado","Dados Ausentes",
                            MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    "Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void RetornarPaciente(string idPaciente)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                LocalizarPacienteRegra pesquisarPaciente = new LocalizarPacienteRegra();
                if (Convert.ToInt32(idPaciente)>0)
                {
                    dadosTabela = pesquisarPaciente.CodigoPaciente(Convert.ToInt32(idPaciente));
                    if (dtgIntermediario.Rows.Count - 1 > 0) dtgIntermediario.Rows.Clear();
                    dtgIntermediario.DataSource = dadosTabela;

                    string nomePaciente = Convert.ToString(dtgIntermediario.Rows[0].Cells["nomePaciente"].Value);
                    string nomeResponsavel = Convert.ToString(dtgIntermediario.Rows[0].Cells["nomeResponsavel"].Value);
                    string rg = Convert.ToString(dtgIntermediario.Rows[0].Cells["rg"].Value);
                    string cpf = Convert.ToString(dtgIntermediario.Rows[0].Cells["cpf"].Value);
                    string ocupacao = Convert.ToString(dtgIntermediario.Rows[0].Cells["ocupacao"].Value);
                    string idade = Convert.ToString(dtgIntermediario.Rows[0].Cells["idade"].Value);
                    string sexo = Convert.ToString(dtgIntermediario.Rows[0].Cells["sexo"].Value);
                    string dataNascimento = Convert.ToString(dtgIntermediario.Rows[0].Cells["dataNascimento"].Value);
                    string dataCadastro = Convert.ToString(dtgIntermediario.Rows[0].Cells["dataCadastro"].Value);
                    string horaCadastro = Convert.ToString(dtgIntermediario.Rows[0].Cells["horaCadastro"].Value);
                    string observacaoPaciente = Convert.ToString(dtgIntermediario.Rows[0].Cells["observacaoPaciente"].Value);

                    dtgPaciente.Rows.Add(idPaciente,nomePaciente,nomeResponsavel,rg,cpf,ocupacao,idade,sexo,dataNascimento.Substring(0,8),observacaoPaciente);
                    dtgPaciente.AutoResizeColumns();
                }
                else
                {
                    MessageBox.Show("O Código do paciente a ser pesquisado não é valido pois é menor ou igual a 0", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo paciente(Formulario frmCadastrarAcesso,Método RetornarPaciente)",
                    "Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void RetornarAnamnese(string idAnamnese)
        {
            try
            {
                LocalizarAnamneseRegra pesquisarAnamnese = new LocalizarAnamneseRegra();
                if (Convert.ToInt32(idAnamnese)>0)
                {
                    dtgIntermediario.DataSource = pesquisarAnamnese.PesquisarAnamnese(idAnamnese);
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
                    "Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void RetornarSintomasReferidos(string idSintomasReferidos)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                LocalizarSintomasReferidosRegra pesquisarSintomas = new LocalizarSintomasReferidosRegra();
                if (Convert.ToInt32(idSintomasReferidos) > 0)
                {
                    dadosTabela = pesquisarSintomas.PesquisarSintomasReferidos(idSintomasReferidos);
                    if (dtgIntermediario.Rows.Count - 1 > 0) dtgIntermediario.Rows.Clear();
                    dtgIntermediario.DataSource = dadosTabela;


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
                    dtgSintomasReferidos.Rows.Add(outros,sintomas[sintomas.Length-1]);

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
                    "Erro de pesquisa", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void RetornarAntecedentesGerais(string idAntecedentesGerais)
        {
            try
            {
                LocalizarAntecedentesGeraisRegra pesquisarGerais = new LocalizarAntecedentesGeraisRegra();
                if (Convert.ToInt32(idAntecedentesGerais) > 0)
                {
                    dtgIntermediario.DataSource = pesquisarGerais.PesquisarAntecedentesGerais(idAntecedentesGerais);
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
                            if (outros == "PF") dtgAntecedentesGerais.Rows.Add(outros, true, true, outrosTratamento);
                            if (outros == "FF") dtgAntecedentesGerais.Rows.Add(outros, false, false, outrosTratamento);
                            if (outros == "P") dtgAntecedentesGerais.Rows.Add(outros, true, false, outrosTratamento);
                            if (outros == "F") dtgAntecedentesGerais.Rows.Add(outros, false, true, outrosTratamento);
                            if (outros != "PF" && outros != "FF" && outros != "P" && outros != "f") dtgAntecedentesGerais.Rows.Add(outros, false, false, outrosTratamento);
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
                    "Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void RetornarAntecedentesOculares(string idAntecedentesOculares)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                LocalizarAntecedentesOcularesRegra pesquisarOculares = new LocalizarAntecedentesOcularesRegra();
                if (Convert.ToInt32(idAntecedentesOculares)>0)
                {
                    dadosTabela = pesquisarOculares.PesquisarAntecedentesOculares(idAntecedentesOculares);

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
                    string outros = "",outrosTratamento = "";
                    for (int i = 0; i <camposBancoBool.Length; i++)//passa os dados para as variaveis
                    {
                        string campo = camposBancoBool[i], tratamento;
                        bool teste = false;

                        teste = Convert.ToBoolean(dtgIntermediario.Rows[0].Cells[campo].Value);
                        tratamento = Convert.ToString(dtgIntermediario.Rows[0].Cells[camposBancoString[i]].Value);

                        tratamentoSintomas[i] = tratamento;
                        confirmacaoSintomas[i] = teste;
                    }
                    outros = Convert.ToString(dtgIntermediario.Rows[0].Cells["outro"].Value);
                    outrosTratamento = Convert.ToString(dtgIntermediario.Rows[0].Cells["outroTratamento"].Value);
                    dtgAntecedentesOculares.Rows.Clear();
                    for (int i = 0; i < confirmacaoSintomas.Length-1; i++)//passa os dados para o dtg
                    {
                        string campo = camposDtg[i], tratamento = tratamentoSintomas[i] ;
                        bool teste = confirmacaoSintomas[i];
                      dtgAntecedentesOculares.Rows.Add(campo, teste, tratamento);
                        
                        if (confirmacaoSintomas.Length-2== i)
                        {
                            dtgAntecedentesOculares.Rows.Add(outros, teste, outrosTratamento);
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
                    "Erro de Pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void RetornarRxInicial(string idRxInicial)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                LocalizarRxInicialRegra pesquisarRx = new LocalizarRxInicialRegra();
                if (Convert.ToInt32(idRxInicial)>0)
                {
                    dadosTabela = pesquisarRx.PesquisarRxInicial(idRxInicial);

                    dtgIntermediario.DataSource = dadosTabela;
                    string[] olhoRxincial = { "VL OD", "VL OE", "VP OD", "VP OE" };
                   
                    string[,] MatrizRxInicial = new string[4, 6];

                    MatrizRxInicial[0,0] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdEsfera"].Value);
                    MatrizRxInicial[1,0] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOeEsfera"].Value);
                    MatrizRxInicial[2,0] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdEsfera"].Value);
                    MatrizRxInicial[3,0] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOeEsfera"].Value);


                    MatrizRxInicial[0,1] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdCilindro"].Value);
                    MatrizRxInicial[1,1] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOeCilindro"].Value);
                    MatrizRxInicial[2,1] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdCilindro"].Value);
                    MatrizRxInicial[3,1] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOeCilindro"].Value);

                    MatrizRxInicial[0,2] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdEixo"].Value);
                    MatrizRxInicial[1,2] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOeEixo"].Value);
                    MatrizRxInicial[2,2] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdEixo"].Value);
                    MatrizRxInicial[3,2] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOeEixo"].Value);

                    MatrizRxInicial[0,3] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdAdicao"].Value);
                    MatrizRxInicial[1,3] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOeAdicao"].Value);
                    MatrizRxInicial[2,3] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdAdicao"].Value);
                    MatrizRxInicial[3,3] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOeAdicao"].Value);

                    MatrizRxInicial[0,4] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdPrisma"].Value);
                    MatrizRxInicial[1,4] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOePrisma"].Value);
                    MatrizRxInicial[2,4] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdPrisma"].Value);
                    MatrizRxInicial[3,4] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOePrisma"].Value);

                    MatrizRxInicial[0,5] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdBase"].Value);
                    MatrizRxInicial[1,5] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOeBase"].Value);
                    MatrizRxInicial[2,5] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdBase"].Value);
                    MatrizRxInicial[3,5] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOeBase"].Value);

                    txtTipoLenteRxInicial.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["tipoLente"].Value);
                    txtTipoMaterialRxInicial.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["material"].Value);
                    txtCorRxInicial.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["cor"].Value);
                    txtEstadoRxInicial.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["estado"].Value);
                    txtObservacaoRxInicial.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["observacaoRxInicial"].Value);

                    dtgRxInicial.Rows.Clear();
                    for (int l = 0; l < 4; l++)//linha 
                    {
                        dtgRxInicial.Rows.Add(olhoRxincial[l], MatrizRxInicial[l,0], MatrizRxInicial[l,1], MatrizRxInicial[l,2], MatrizRxInicial[l,3], MatrizRxInicial[l,4], MatrizRxInicial[l,5]);
                    }
                    for (int i = 0; i < dtgRxInicial.Rows.Count; i++)
                    {
                        dtgRxInicial.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        dtgRxInicial.ForeColor = Color.Black;
                        i++;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo RxInicial(Formulario frmCadastrarConsulta, Método RetornarRxInicial)",
                    "Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void RetornarRxFinal(string idRxFinal)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                LocalizarRxFinalRegra pesquisarRx = new LocalizarRxFinalRegra();
                if (Convert.ToInt32(idRxFinal) > 0)
                {
                    dadosTabela = pesquisarRx.PesquisarRxFinal(idRxFinal);
                    if (dtgIntermediario.Rows.Count - 1 > 0) dtgIntermediario.Rows.Clear();
                    dtgIntermediario.DataSource = dadosTabela;
                    string[] olhoRxFinal = { "VL OD", "VL OE", "VP OD", "VP OE" };

                    string[,] MatrizRxFinal = new string[4, 6];

                    MatrizRxFinal[0, 0] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdEsfera"].Value);
                    MatrizRxFinal[1, 0] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOeEsfera"].Value);
                    MatrizRxFinal[2, 0] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdEsfera"].Value);
                    MatrizRxFinal[3, 0] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOeEsfera"].Value);


                    MatrizRxFinal[0, 1] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdCilindro"].Value);
                    MatrizRxFinal[1, 1] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOeCilindro"].Value);
                    MatrizRxFinal[2, 1] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdCilindro"].Value);
                    MatrizRxFinal[3, 1] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOeCilindro"].Value);

                    MatrizRxFinal[0, 2] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdEixo"].Value);
                    MatrizRxFinal[1, 2] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOeEixo"].Value);
                    MatrizRxFinal[2, 2] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdEixo"].Value);
                    MatrizRxFinal[3, 2] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOeEixo"].Value);

                    MatrizRxFinal[0, 3] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdAdicao"].Value);
                    MatrizRxFinal[1, 3] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOeAdicao"].Value);
                    MatrizRxFinal[2, 3] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdAdicao"].Value);
                    MatrizRxFinal[3, 3] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOeAdicao"].Value);

                    MatrizRxFinal[0, 4] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdPrisma"].Value);
                    MatrizRxFinal[1, 4] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOePrisma"].Value);
                    MatrizRxFinal[2, 4] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdPrisma"].Value);
                    MatrizRxFinal[3, 4] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOePrisma"].Value);

                    MatrizRxFinal[0, 5] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdBase"].Value);
                    MatrizRxFinal[1, 5] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOeBase"].Value);
                    MatrizRxFinal[2, 5] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdBase"].Value);
                    MatrizRxFinal[3, 5] = Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOeBase"].Value);

                    txtTipoLenteRxFinal.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["tipoLente"].Value);
                    txtTipoMaterialRxFinal.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["material"].Value);
                    txtCorRxFinal.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["cor"].Value);
                    txtEstadoRxFinal.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["estado"].Value);
                    txtObservacaoRxFinal.Text = Convert.ToString(dtgIntermediario.Rows[0].Cells["observacaoRxFinal"].Value);


                    dtgRxFinal.Rows.Clear();
                    for (int l = 0; l < 4; l++)//linha 
                    {
                        dtgRxFinal.Rows.Add(olhoRxFinal[l],MatrizRxFinal[l, 0],MatrizRxFinal[l, 1],MatrizRxFinal[l, 2],MatrizRxFinal[l, 3],MatrizRxFinal[l, 4],MatrizRxFinal[l, 5]);
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
        void RetornarAcuidadeVisual(string idAcuidadeVisual)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                LocalizarAcuidadeVisualRegra pesquisarAcuidade = new LocalizarAcuidadeVisualRegra();
                if (Convert.ToInt32(idAcuidadeVisual)>0)
                {
                    dadosTabela = pesquisarAcuidade.PesquisarAcuidadeVisual(idAcuidadeVisual);
                    if (dtgIntermediario.Rows.Count - 1 > 0) dtgIntermediario.Rows.Clear();
                    dtgIntermediario.DataSource = dadosTabela;

                    string[] OlhoAcuidadeVisual = { "OD", "OE", "AO" };
                    string[] camposBanco = {"vlOdSg","vlOeSg","vlAoSg","vlPh","vlOdCc","vlOeCc","vlAoCc","vpOdSc","vpOeSc","vpAoSc","vpOdCc",
                    "vpOeCc","vpAoCc","tipoOptotipo"};
                    string tipoOptotipo = "";
                    string[,] matrizAcuidade = new string[3, 5];

                    matrizAcuidade[0,0]= Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdSg"].Value);
                    // matrizAcuidade[0,1]= Convert.ToString(dtgIntermediario.Rows[0].Cells[""].Value); vlph linha 0
                    matrizAcuidade[0,2]= Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOdCc"].Value);
                    matrizAcuidade[0,3]= Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdSc"].Value);
                    matrizAcuidade[0,4]= Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOdCc"].Value);

                    matrizAcuidade[1,0]= Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOeSg"].Value);
                    matrizAcuidade[1,1]= Convert.ToString(dtgIntermediario.Rows[0].Cells["vlPh"].Value);
                    matrizAcuidade[1,2]= Convert.ToString(dtgIntermediario.Rows[0].Cells["vlOeCc"].Value);
                    matrizAcuidade[1,3]= Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOeSc"].Value);
                    matrizAcuidade[1,4]= Convert.ToString(dtgIntermediario.Rows[0].Cells["vpOeCc"].Value);

                    matrizAcuidade[2,0]= Convert.ToString(dtgIntermediario.Rows[0].Cells["vlAoSg"].Value);
                    //matrizAcuidade[2,1]= Convert.ToString(dtgIntermediario.Rows[0].Cells[""].Value); vlph linha 2
                    matrizAcuidade[2,2]= Convert.ToString(dtgIntermediario.Rows[0].Cells["vlAoCc"].Value);
                    matrizAcuidade[2,3]= Convert.ToString(dtgIntermediario.Rows[0].Cells["vpAoSc"].Value);
                    matrizAcuidade[2,4]= Convert.ToString(dtgIntermediario.Rows[0].Cells["vpAoCc"].Value);

                    tipoOptotipo = Convert.ToString(dtgIntermediario.Rows[0].Cells["tipoOptotipo"].Value);

                    dtgAcuidadeVisual.Rows.Clear();
                    for (int l = 0; l < 3; l++)//linha 
                    {
                        if (l != 1)
                        {
                            dtgAcuidadeVisual.Rows.Add(OlhoAcuidadeVisual[l], matrizAcuidade[l, 0],"", matrizAcuidade[l, 2], OlhoAcuidadeVisual[l], matrizAcuidade[l, 3], matrizAcuidade[l, 4]);
                        }
                        if (l==1)
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
        void RetornarOftalmoscopia(string idOftalmoscopia)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                localizarOftalmoscopiaRegra pesquisarOftalmoscopia = new localizarOftalmoscopiaRegra();
                if (Convert.ToInt32(idOftalmoscopia)>0)
                {
                    dadosTabela = pesquisarOftalmoscopia.LocalizarOftalmoscopia(idOftalmoscopia);
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
        bool RetornarIdProfissional(string idUsuario)
        {
            try
            {
                RetornarIdProfissionalRegra pesquisar = new RetornarIdProfissionalRegra();
                int id = pesquisar.idUsuario(idUsuario);
                idProfissional = Convert.ToString(id);
                if (id > 0) return true; return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo idProfissional(Formulario frmCadastrarConsulta,Método RetornarIdProfissional)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        void CarregarPaciente(string idPaciente, string idContato, string idEndereco, string idUsuario, string paciente, string responsavel, string rg, string cpf, string ocupacao, string idade, string sexo,
            string dataNascimento, string dataCadastro, string horaCadastro, string observacao)
        {
            dtgPaciente.DataSource = esvaziar;
            if (dtgPaciente.Rows.Count < 1)
            {
                dtgPaciente.Rows.Add(idPaciente, nomePaciente, nomeResponsavel, RG, CPF, OCUPACAO, IDADE, SEXO, dataNascimento, dataCadastro, horaCadastro, observacao);
                dtgPaciente.AutoResizeColumns();
            }
        }

        private void tbConsulta_CheckedChanged(object sender, EventArgs e)
        {
            gbReceita.Visible = false;
            gbConsulta.Visible = true;
        }
        private void rbReceita_CheckedChanged(object sender, EventArgs e)
        {
            gbReceita.Visible = true;
            gbConsulta.Visible = false;
        }
        private void repetir_Tick(object sender, EventArgs e)
        {
            dtgPaciente.AutoResizeColumns();
        }

        private void rbAntecedentesGerais_CheckedChanged(object sender, EventArgs e)
        {
            gbAntecedentesGerais.Visible = true;
            gbAntecedentesOculares.Visible = false;
        }

        private void rbAntecedentesOculares_CheckedChanged(object sender, EventArgs e)
        {
            gbAntecedentesGerais.Visible = false;
            gbAntecedentesOculares.Visible = true;
        }

        private void rbRxInicial_CheckedChanged(object sender, EventArgs e)
        {
            gbRxInicial.Visible = true;
            gbRxFinal.Visible = false; 
        }

        private void rbRxFinal_CheckedChanged(object sender, EventArgs e)
        {
            gbRxInicial.Visible = false;
            gbRxFinal.Visible = true;
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


                CadastrarAcuidadeVisualRegra AcuidadeRegra = new CadastrarAcuidadeVisualRegra();
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
                CadastrarAnamneseRegra AnamneseRegra = new CadastrarAnamneseRegra();
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
                string outros = "", outrosTratamento = "";

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
                        outros = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["patologiaAntecedentesGerais"].Value);
                        outrosTratamento = Convert.ToString(dtgAntecedentesGerais.Rows[i].Cells["tipoTratamentoAntecedentesGerais"].Value);
                    }
                }
                CadastrarAntecedentesGeraisRegra antecedentesGeraisRegra = new CadastrarAntecedentesGeraisRegra();
                bool antecedentesGerais = antecedentesGeraisRegra.Cadastrar(IDCONSULTA, vasculares,vascularesTratamento,diabetes,diabetesTratamento,imunes,imunesTratamento,neurologicos,
                    neurologicosTratamento,outros,outrosTratamento,txtObservacaoAntecedentesGerais.Text);
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
              
                string outros="";

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
                         outros =Convert.ToString(dtgAntecedentesOculares.Rows[i].Cells["patologiaAntecedentesOculares"].Value);
                    }
                    tratamento[i] = Convert.ToString(dtgAntecedentesOculares.Rows[i].Cells["TipoTratamentoAntecedentesOculares"].Value);
                }

                CadastrarAntecedentesOcularesRegra antecedentesOcularesRegra = new CadastrarAntecedentesOcularesRegra();
                bool antecedentesOculares = antecedentesOcularesRegra.Cadastrar(IDCONSULTA, possuir[0], tratamento[0], possuir[1], tratamento[1], possuir[2], tratamento[2], possuir[3], tratamento[3], possuir[4], tratamento[4], 
                    possuir[5], tratamento[5], possuir[6], tratamento[6], possuir[7], tratamento[7], possuir[8], tratamento[8], possuir[9], tratamento[9], possuir[10], tratamento[10],
                    possuir[11], tratamento[11], possuir[12], tratamento[12], possuir[13], tratamento[13], outros, tratamento[14]);
                return antecedentesOculares;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar os Antecedentes Oculares(Formulario frmCadastrarConsulta, MétodoCadastrarAntecedentesOculares)",
                    "erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
        bool CadastrarOftalmoscopia(string IDCONSULTA)
        {
            try
            {
                CadastrarOftalmoscopiaRegra oftalmoscopiaRegra = new CadastrarOftalmoscopiaRegra();
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
                string[,] ArrayRxFinal = new string[4,6];
                string[] colunas = {"EsferaRxFinal", "cilindroRxFinal","eixoRxFinal","adicaoRxFinal","prismaRxFinal","baseRxFinal" };
                for (int l = 0; l < 4; l++)//linha 
                {
                    for (int c = 0; c < 6; c++)//coluna
                    {
                        ArrayRxFinal[l, c] = Convert.ToString( dtgRxFinal.Rows[l].Cells[colunas[c]].Value);
                    }
                }

                CadastrarRxFinalRegra rxFinalRegra = new CadastrarRxFinalRegra();

                bool rxFinal = rxFinalRegra.Cadastrar(IDCONSULTA, ArrayRxFinal[0,0], ArrayRxFinal[0,1], ArrayRxFinal[0,2], ArrayRxFinal[0,3], ArrayRxFinal[0,4], ArrayRxFinal[0,5],
                    ArrayRxFinal[1,0], ArrayRxFinal[1,1], ArrayRxFinal[1,2], ArrayRxFinal[1,3], ArrayRxFinal[1,4], ArrayRxFinal[1,5], ArrayRxFinal[2,0], ArrayRxFinal[2,1], ArrayRxFinal[2,2],
                    ArrayRxFinal[2,3], ArrayRxFinal[2,4], ArrayRxFinal[2,5], ArrayRxFinal[3,0], ArrayRxFinal[3,1], ArrayRxFinal[3,2], ArrayRxFinal[3,3], ArrayRxFinal[3,4], ArrayRxFinal[3,5], 
                    txtTipoLenteRxFinal.Text, txtTipoLenteRxFinal.Text, txtCorRxFinal.Text, txtEstadoRxFinal.Text, txtObservacaoRxFinal.Text);
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
                string[,] ArrayRxInicial = new string[4, 6];
                string[] colunas = { "EsferaRxInicial", "cilindroRxInicial", "eixoRxInicial", "adicaoRxInicial", "prismaRxInicial", "baseRxInicial" };
                for (int l = 0; l < 4; l++)//linha 
                {
                    for (int c = 0; c < 6; c++)//coluna
                    {
                        ArrayRxInicial[l, c] = Convert.ToString(dtgRxInicial.Rows[l].Cells[colunas[c]].Value);
                    }
                }

                CadastrarRxInicialRegra RxInicialRegra = new CadastrarRxInicialRegra();

                bool RxInicial = RxInicialRegra.Cadastrar(IDCONSULTA,
                    ArrayRxInicial[0,0], ArrayRxInicial[1,0], ArrayRxInicial[2,0], ArrayRxInicial[3,0], /*esfera*/
                    ArrayRxInicial[0,1], ArrayRxInicial[1,1], ArrayRxInicial[2,1], ArrayRxInicial[3,1],/*Cilindro*/
                    ArrayRxInicial[0,2], ArrayRxInicial[1,2], ArrayRxInicial[2,2], ArrayRxInicial[3,2],/*Eixo*/

                    ArrayRxInicial[0,3], ArrayRxInicial[1,3], ArrayRxInicial[2,3], ArrayRxInicial[3,3],/*adicao*/
                    ArrayRxInicial[0,4], ArrayRxInicial[1,4], ArrayRxInicial[2,4], ArrayRxInicial[3,4],/*prisma*/
                    ArrayRxInicial[0,5], ArrayRxInicial[1,5], ArrayRxInicial[2,5], ArrayRxInicial[3,5],/*base*/
                    txtTipoLenteRxInicial.Text, txtTipoMaterialRxInicial.Text, txtCorRxInicial.Text, txtEstadoRxInicial.Text, txtObservacaoRxInicial.Text);
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
                bool[] sintomas = new bool[17];
                string outros="";
                for (int i = 0; i < dtgSintomasReferidos.Rows.Count ; i++)
                {
                    if (Convert.ToString(dtgSintomasReferidos.Rows[i].Cells["confirmacaoSintomasReferidos"].Value) == "V")
                    {
                        sintomas[i] = true;
                    } 
                    else
                    {
                        sintomas[i] = false;
                    }
                
                    
                }
                outros = dtgSintomasReferidos.Rows[dtgSintomasReferidos.Rows.Count -1 ].Cells["sintomaSintomasReferidos"].Value.ToString();
                CadastrarSintomasReferidosRegra sintomasReferidosRegra = new CadastrarSintomasReferidosRegra();
              bool sintomasReferidos =  sintomasReferidosRegra.Cadastrar(IDCONSULTA, sintomas[0], sintomas[1], sintomas[2], sintomas[3], sintomas[4], sintomas[5], sintomas[6], sintomas[7], sintomas[8], sintomas[9], sintomas[10],
                    sintomas[11], sintomas[12], sintomas[13], sintomas[14], sintomas[15], outros);
                return sintomasReferidos;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar os Sintomas Referidos(Formulario frmCadastrarConsulta, Método CadastrarSintomasReferidos)", "Erro de cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        void Cadastrar()
        {
            bool confirmGeral = true, confirmConsulta = false;
            bool[] confirmacao = new bool[8];

            ConsultaRegraNegocio consultaRegra = new ConsultaRegraNegocio();
            LocalizarConsultaRegra pesquisarConsulta = new LocalizarConsultaRegra();

            confirmConsulta = consultaRegra.Cadastrar(idPaciente, idProfissional, idUsuarioSistema, txtOrigem.Text, txtHobbies.Text, txtEncaminhadoPor.Text,
                txtAjudaOpticaPrescrita.Text, dtpDataUltimoExame.Value, txtTrascricaoLentes.Text, txtObservacaoReceita.Text, cbStatusConsulta.Text, txtObservacaoConsulta.Text);

            dtgIntermediario.DataSource = pesquisarConsulta.PesquisarUltimoId();
            string idUlitmaConsulta = dtgIntermediario.Rows[0].Cells["idConsulta"].Value.ToString();

            confirmacao[0] = CadastrarAcuidadeVisual(idUlitmaConsulta);
            confirmacao[1] = CadastrarAnamnese(idUlitmaConsulta);
            confirmacao[2] = CadastrarAntecedentesGerais(idUlitmaConsulta);
            confirmacao[3] = CadastrarAntecedentesOculares(idUlitmaConsulta);
            confirmacao[4] = CadastrarOftalmoscopia(idUlitmaConsulta);
            confirmacao[5] = CadastrarRxFinal(idUlitmaConsulta);
            confirmacao[6] = CadastrarRxInicial(idUlitmaConsulta);
            confirmacao[7] = CadastrarSintomasReferidos(idUlitmaConsulta);

            for (int i = 0; i < confirmacao.Length; i++)
            {
                if (confirmacao[i] == false)
                {
                    MessageBox.Show("Ocorreu um erro no cadastro de alguma das tabelas", "Erro de cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    confirmGeral = false;
                    break;
                }
            }

            ConsultarPacienteAgendadoRegra finalizar = new ConsultarPacienteAgendadoRegra();
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
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (aunteUsuario.NovaConsulta(idNivel) == true)
            {
                if (RetornarIdProfissional(idUsuarioSistema) == true)
                {
                    if (dtgPaciente.Rows.Count > 0)
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
            pnlMenuSuperior.Width = this.Width;

            //Consulta
            {
                rbConsulta.Checked = true;
                gbConsulta.Visible = true;
                gbConsulta.Location = new Point(tpConsulta.Width / 2 - (gbConsulta.Width / 2), Convert.ToInt32(tpConsulta.Height / 2 - (gbConsulta.Height / 2)));
                gbReceita.Location = new Point(tpConsulta.Width / 2 - (gbReceita.Width / 2), Convert.ToInt32(tpConsulta.Height / 2 - (gbReceita.Height / 2)));
            }
            //Anamnese
            {
                gbAnamnese.Location = new Point(tpAnamnese.Width / 2 - (gbAnamnese.Width / 2), tpAnamnese.Height / 2 - (gbAnamnese.Height / 2));
            }
            //Antecedentes
            {
                rbAntecedentesGerais.Checked = true;
                gbAntecedentesGerais.Visible = true;
                gbAntecedentesGerais.Location = new Point(tpAntecedentes.Width / 2 - (gbAntecedentesGerais.Width / 2), tpAntecedentes.Height / 2 - (gbAntecedentesGerais.Height / 2));
                gbAntecedentesOculares.Location = new Point(tpAntecedentes.Width / 2 - (gbAntecedentesOculares.Width / 2), tpAntecedentes.Height / 2 - (gbAntecedentesOculares.Height / 2));
            }
            //Sintomas Referidos
            {
                gbSintomasReferidos.Location = new Point(tpSintomasReferidos.Width / 2 - (gbSintomasReferidos.Width / 2), Convert.ToInt32(tpSintomasReferidos.Height / 2 - (tpSintomasReferidos.Width / 5)));
            }
            //Oftalmoscopia
            {
                gbOftalmoscopia.Location = new Point(tpOftalmoscopia.Width / 2 - (gbOftalmoscopia.Width / 2), tpOftalmoscopia.Height / 2 - (gbOftalmoscopia.Height / 2));
            }
            //rx
            {
                rbRxInicial.Checked = true;
                gbRxInicial.Visible = true;
                gbRxInicial.Location = new Point(tpRx.Width / 2 - (gbRxInicial.Width / 2), tpRx.Height / 2 - (gbRxInicial.Height / 2));
                gbRxFinal.Location = new Point(tpRx.Width / 2 - (gbRxFinal.Width / 2), tpRx.Height / 2 - (gbRxFinal.Height / 2));
            }
            //Acuidade Visual
            {
                gbAcuidadeVisual.Location = new Point(tpAcuidadeVisual.Width / 2 - (gbAcuidadeVisual.Width / 2), tpAcuidadeVisual.Height / 2 - (gbAcuidadeVisual.Height / 2));
            }
            //Deixar as colunas do dtgPaciente com largura automatica
            dtgPaciente.AutoResizeColumns();
        }
        private void frmCadastrarConsulta_Load(object sender, EventArgs e)
        {
            lblLoginUsuario.Text = "Usuário: " + loginUsuario + "   Nivel: " + nomeNivel;
            CarregarDadosEstaticosDosDtg();
           CentralizarComponentes();
             btnSalvar.Visible = true;
            btnAlterar.Visible = false; 
           
            limpar();
            if (Convert.ToInt32(idPaciente)>0)
            {
                CarregarPaciente(idPaciente, idContato, idEndereco, idUsuarioCadastro, nomePaciente, nomeResponsavel,
                    RG, CPF, OCUPACAO, IDADE, SEXO, dataNascimento, dataCadastro, horaCadastro, observacaoPaciente); 
            }
            if (Convert.ToInt32(idConsulta) >0)
            {
                btnSalvar.Visible = false;
                btnAlterar.Visible = true;
                RetornarChaves(idConsulta);
            }
            dtgPaciente.Rows[0].DefaultCellStyle.BackColor = Color.LightGray;
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
    }
}
