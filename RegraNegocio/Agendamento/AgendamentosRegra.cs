using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class AgendamentosRegra
    {

        //Função que realiza a validação dos dados do agendamento do paciente existente.
        public bool ValidarAgendamento(string idPaciente, string idUsuario, string idStatusAgendamento, string dataConsulta, string observacaoAgendamento)
        {
            try
            {
                if (Convert.ToInt32(idPaciente) < 1) return false;
                if (Convert.ToInt32(idUsuario) < 1) return false;
                if (Convert.ToInt32(idStatusAgendamento) < 1) return false;
                if (Convert.ToDateTime(dataConsulta) < Convert.ToDateTime(DateTime.Today.ToString())) return false;
                if (observacaoAgendamento.GetType() != typeof(string)) return false;
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar validar os dados do agendamento(Classe AgendamentosRegra, Método ValidarAgendamento)", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        //Função que realiza a validação dos dados do cadastro do paciente, endereço e contato do paciente e além do agendamento da consulta.
        public bool ValidarAgendamentoNovo(string idStatus, string dataConsulta, string observacaoAgendamento, string idUsuario, string nomePaciente, string nomeResponsavel,
            string rg, string cpf, string idade, string dataNascimento, string observacaoPaciente,
            string email, string telefone1, string telefone2, string telefone3, string outro, string observacaoContato,
            string estado, string cidade, string bairro, string rua, string numero, string cep, string pontoReferencia, string observacaoEndereco)
        {
            try
            {
                //idUsuario
                if (Convert.ToInt32(idUsuario) < 1)
                {
                    return false;
                }
                #region Agendamento
                if (Convert.ToInt32(idStatus) < 1) return false;
                if (Convert.ToDateTime(dataConsulta) < Convert.ToDateTime(DateTime.Now.ToShortDateString())) return false;
                if (observacaoAgendamento.GetType() != typeof(string)) return false;
                #endregion
                #region Paciente Novo
                if (nomePaciente.Trim().Length < 1 || nomePaciente.Length > 50) return false;
                if (nomeResponsavel.Length > 50) return false;
                if (rg.Trim().Length > 20) return false;
                if (cpf.Replace(",", "").Replace(".", "").Replace("-", "").Trim().Length != 11) return false;
                if (cpf.Replace(",", "").Replace(".", "").Replace("-", "").Trim().Length == 11)
                {
                    string campoCPF = cpf.Replace(",", "").Replace(".", "").Replace("-", "").Trim();
                    int NumerosVariaveis = 0;

                    int[] PrimeiroDigito = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                    int[] SegundoDigito = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                    int resultadoPrimeiroDigito = 0;
                    int resultadoSegundoDigito = 0;

                    for (int i = 0; i < PrimeiroDigito.Length; i++)
                    {
                        NumerosVariaveis = Int32.Parse(Convert.ToString(campoCPF[i]));//Convert o numero do cpf a ser utilizado para string e depois para int
                        resultadoPrimeiroDigito = resultadoPrimeiroDigito + (NumerosVariaveis * PrimeiroDigito[i]);//efetua o calculo de acordo com o algoritimo de validação
                    }
                    int digitoVerificador1 = Int32.Parse(Convert.ToString(campoCPF[9]));//
                    int PrimeiroVerificador = (resultadoPrimeiroDigito * 10) % 11;
                    if (PrimeiroVerificador == digitoVerificador1)
                    {
                        for (int i = 0; i < SegundoDigito.Length; i++)
                        {
                            NumerosVariaveis = Int32.Parse(Convert.ToString(campoCPF[i]));//Convert o numero do cpf a ser utilizado para string e depois para int
                            resultadoSegundoDigito = resultadoSegundoDigito + (NumerosVariaveis * SegundoDigito[i]);//efetua o calculo de acordo com o algoritimo de validação
                        }
                        int digitoVerificador2 = Int32.Parse(Convert.ToString(campoCPF[10]));//
                        int SegundoVerificador = (resultadoSegundoDigito * 10) % 11;
                        if (SegundoVerificador != digitoVerificador2) return false;
                    }
                    if (PrimeiroVerificador != digitoVerificador1) return false;
                }
                if (idade.Trim().Length > 3) return false;
                if (Convert.ToDateTime(dataNascimento) > Convert.ToDateTime(DateTime.Now.ToShortDateString())) return false;
                if (observacaoPaciente.GetType() != typeof(string)) return false;
                #endregion
                #region Contato Novo
                if (email.Trim().Length > 50) return false;
                if (telefone1.Replace("(", "").Replace(")", "").Replace(",", "").Replace(".", "").Replace("_", "").Replace("-", "").Trim().Length > 11) return false;
                if (outro.GetType() != typeof(string)) return false;
                if (observacaoContato.GetType() != typeof(string)) return false;
                #endregion
                #region Endereco Novo
                if ( estado.Length > 30) return false;
                if (cidade.Length > 30) return false;
                if (bairro.Length > 30) return false;
                if (rua.Length > 50) return false;
                if (numero.Trim().Length > 5) return false;
                if (cep.Replace("_", "").Replace(",", "").Replace(".", "").Replace("-", "").Trim().Length != 8 && cep.Replace("_", "").Replace(",", "").Replace(".", "").Replace("-", "").Trim().Length
                    != 0) return false;
                if (pontoReferencia.GetType() != typeof(string)) return false;
                if (observacaoEndereco.GetType() != typeof(string)) return false;
                #endregion
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a validação dos dados do agendamento da consulta de um novo paciente(Classe AgendamentosRegra, Método ValidarAgendamentoNovo)",
                    "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }


        public bool AgendarConsulta(string idPaciente, string  idUsuario, string idStatusAgendamento, string dataConsulta, string observacaoAgendamento)
        {

            try
            {
                if (Convert.ToInt32(idPaciente) > 0)
                {
                    if (ValidarAgendamento(idPaciente, idUsuario, idStatusAgendamento, dataConsulta, observacaoAgendamento) == true)
                    {
                        AgendamentosAcesso consulta = new AgendamentosAcesso();

                        if (consulta.AgendarConsulta(Convert.ToInt32(idPaciente),Convert.ToInt32(idUsuario),Convert.ToInt32(idStatusAgendamento),
                            Convert.ToDateTime(dataConsulta),observacaoAgendamento) == true)
                        {
                            return true;//Só é retornado caso o agendamento seja realizado com sucesso 
                        }
                        else
                        {
                            return false;//Se der algum erro no agendamento vai sern retornado um valor falso..
                        }
                    }
                    else
                    {
                        return false;//Se os dados não passarem pela validação vai retornar um valor falso.
                    }
                }
                else
                {
                    MessageBox.Show("Para proseguir com o agendamento da consulta selecione um paciente com códig Identificador Válido", "Dados incorretos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao agendar a consulta(Classe AgendamentosRegra, Método RetornarDados)", "Erro de agendamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        //Função que faz o cadastro do paciente,endereço, contato e posteriormente faz o agendamento da consulta.
        public bool AgendarNovo(string idStatus,string dataConsulta,string observacaoAgendamento,string idUsuario, string nomePaciente, string nomeResponsavel, string rg, string cpf, string idade, string dataNascimento, string observacaoPaciente,
           string email, string telefone1, string telefone2, string telefone3, string outro, string observacaoContato,
           string estado, string cidade, string bairro, string rua, string numero, string cep, string pontoReferencia, string observacaoEndereco)
        {
            try
            {
                bool confirmarEndereco, confirmarContato, confirmarPaciente;
                if (ValidarAgendamentoNovo(idStatus,dataConsulta,observacaoAgendamento,idUsuario, nomePaciente, nomeResponsavel, rg, cpf, idade, dataNascimento, observacaoPaciente, email, telefone1, telefone2, telefone3, outro, observacaoContato,
                    estado, cidade, bairro, rua, numero, cep, pontoReferencia, observacaoEndereco) == true)
                {
                    //Cadastro do Endereço
                    EnderecoAcesso endereco = new EnderecoAcesso();
                    confirmarEndereco = endereco.Cadastrar(idUsuario, estado, cidade, bairro, rua, numero, cep, pontoReferencia, observacaoEndereco);

                    //Cadastro do Contato
                    ContatoAcesso contato = new ContatoAcesso();
                    confirmarContato = contato.cadastrar("0", idUsuario, email, telefone1, telefone2, telefone3, outro, observacaoContato);

                    //Cadastro do Paciente 
                    PacienteAcesso paciente = new PacienteAcesso();
                    confirmarPaciente = paciente.Cadastrar("0", "0", "0", idUsuario, nomePaciente, nomeResponsavel, rg, cpf, "", idade, "", dataNascimento, "", "", observacaoPaciente);

                    /*Agendamento da consulta*/
                    PacienteAcesso localizarPaciente = new PacienteAcesso();
                    int codPaciente = localizarPaciente.UltimoPaciente();

                    bool confirmarAgendamento = AgendarConsulta(Convert.ToString(codPaciente),idUsuario,idStatus,dataConsulta,observacaoAgendamento);

                    /*os espaços são incluidos apenas para completar a requisição do método e posteriormente serem alterados*/
                    if (confirmarContato == true && confirmarEndereco == true && confirmarPaciente == true && confirmarAgendamento == true)/*Se as 4 variaveis tiverem o valor true o agendamento foi bem sucedido!*/ return true; return false;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar o agendamento de uma consulta de um novo paciente(Classe AgendamentosRegra, Método AgendarNovo)", "Erro de Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        //Função que marca a hora de chegada do paciente.
        public bool ChegadaPaciente(string idAgendamento,DateTime DataConsulta)
        {
            try
            {
                if (Convert.ToInt32(idAgendamento) > 0)
                {
                    if (DataConsulta == Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    {
                        AgendamentosAcesso agendamentos = new AgendamentosAcesso();
                        if (agendamentos.ChegadaPaciente(Convert.ToInt32(idAgendamento)))return true;return false;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao incluir o paciente na ordem de atendimento(Classe AgendamentosRegra, Método ChegadaPaciente)", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool AtualizarAgendamentos(string idAgendamento, string idStatus, string dataConsulta, string observacao)
        {
            try
            {
                if (Convert.ToInt32(idAgendamento) > 0 && Convert.ToInt32(idStatus) > 0 && observacao.GetType() == typeof(string))
                {
                    if (Convert.ToDateTime(dataConsulta) == Convert.ToDateTime(DateTime.Now.ToShortDateString()) || Convert.ToDateTime(dataConsulta) > Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    {
                        AgendamentosAcesso editar = new AgendamentosAcesso();
                        if (editar.AtualizarAgendamentos(Convert.ToInt32(idAgendamento), Convert.ToInt32(idStatus), Convert.ToDateTime(dataConsulta), observacao) == true) return true; return false;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os dados do agendamento(Classe AgendamentosRegra, Método AtualizarAgendamentos)",
                    "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        //Funções realizam a pesquisa dos agendamentos por diversos filtros.
        public DataTable TodosAgendamentos()
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            dadosTabela = null;
            try
            {
                AgendamentosAcesso pesquisarConsultaAgendada = new AgendamentosAcesso();
                dadosTabela = pesquisarConsultaAgendada.TodosAgendamentos();
                if (dadosTabela.Rows.Count > 0) return dadosTabela; return tableVazia;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por todas as consultas agendadas(Classe AgendamentosRegra ,Método TodosAgendamentos)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomePaciente(string nomePaciente)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            dadosTabela = null;
            try
            {
                AgendamentosAcesso pesquisarConsultaAgendada = new AgendamentosAcesso();
                dadosTabela = pesquisarConsultaAgendada.NomePaciente(nomePaciente);
                if (dadosTabela.Rows.Count > 0) return dadosTabela; return tableVazia;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do nome do paciente(Classe AgendamentosRegra ,Método NomePaciente)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable RG(string RG)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            dadosTabela = null;
            try
            {
                AgendamentosAcesso pesquisarConsultaAgendada = new AgendamentosAcesso();
                dadosTabela = pesquisarConsultaAgendada.RG(RG);
                if (dadosTabela.Rows.Count > 0) return dadosTabela; return tableVazia;
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do RG do paciente(Classe AgendamentosRegra ,Método RG)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CPF(string CPF)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            dadosTabela = null;
            try
            {
                AgendamentosAcesso pesquisarConsultaAgendada = new AgendamentosAcesso();
                dadosTabela = pesquisarConsultaAgendada.CPF(CPF);
                if (dadosTabela.Rows.Count > 0) return dadosTabela; return tableVazia;
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do CPF do paciente(Classe AgendamentosRegra ,Método CPF)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable DataNascimento(DateTime dataInicial, DateTime dataFinal)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            dadosTabela = null;
            try
            {
                AgendamentosAcesso pesquisarConsultaAgendada = new AgendamentosAcesso();
                dadosTabela = pesquisarConsultaAgendada.DataNascimento(dataInicial, dataFinal);
                if (dadosTabela.Rows.Count > 0) return dadosTabela; return tableVazia;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves de um intervalo de datas de " +
                    "nascimento dos pacientes(Classe AgendamentosRegra ,Método DataNascimento)","Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable DataConsulta(DateTime dataInicial, DateTime dataFinal)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            dadosTabela = null;
            try
            {
                AgendamentosAcesso pesquisarConsultaAgendada = new AgendamentosAcesso();
                dadosTabela = pesquisarConsultaAgendada.DataConsulta(dataInicial, dataFinal);
                if (dadosTabela.Rows.Count > 0) return dadosTabela; return tableVazia;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves de um intervalo de datas de consultas(Classe AgendamentosRegra ,Método DataConsulta)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable StatusAgendamento(string status)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            tableVazia = null;
            try
            {
                AgendamentosAcesso pesquisarConsultaAgendada = new AgendamentosAcesso();
                dadosTabela = pesquisarConsultaAgendada.StatusAgendamento(status);
                if (dadosTabela.Rows.Count > 0) return dadosTabela; return tableVazia;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do status do agendamento(Classe AgendamentosRegra ,Método StatusAgendamento)",
                    "Erro de pesquisa",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

        //Função para Consultar um paciente agendado, assim alterando o status do agendamento para o 3.
        public bool ConsultarPacienteAgendado(string id)
        {
            try
            {
                AgendamentosAcesso consultar = new AgendamentosAcesso();

                if (Convert.ToInt32(id) > 0)
                {
                    if (consultar.ConsultarPacienteAgendado(Convert.ToInt32(id)) == true) return true; return false;
                }
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao consultar um paciente agendado(Classe AgendamentosRegra, Método ConsultarPacienteAgendado)", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        //Função para finalizar a consulta agendada, assim alterando o status do agendamento para o 4.
        public bool FinalizarConsultaAgendada(int id)
        {
            try
            {
                AgendamentosAcesso finalizar = new AgendamentosAcesso();
                if (Convert.ToInt32(id) > 0)
                {
                    if (finalizar.FinalizarConsultaAgendada(id)) return true; return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao finalizar uma consulta de um paciente agendado(Classe AgendamentosRegra, Método FinalizarConsultaAgendada)", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

    }
}
