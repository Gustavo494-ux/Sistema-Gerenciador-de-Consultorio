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
    public class AgendarConsultaRegra
    {
        //Paciente existente
        public bool AgendarConsulta(string idPaciente, string  idUsuario, string idStatusAgendamento, string dataConsulta, string observacaoAgendamento)
        {

            try
            {
                if (Convert.ToInt32(idPaciente) > 0)
                {
                    if (ValidarAgendamento(idPaciente, idUsuario, idStatusAgendamento, dataConsulta, observacaoAgendamento) == true)
                    {
                        AgendarConsultaAcesso agendarConsultaAcesso = new AgendarConsultaAcesso();

                        if (agendarConsultaAcesso.AgendarConsulta(Convert.ToInt32(idPaciente), Convert.ToInt32(idUsuario), Convert.ToInt32(idStatusAgendamento),
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
                MessageBox.Show("Ocorreu um erro ao agendar a consulta(Classe AgendarConsulta, Método RetornarDados)", "Erro de agendamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        //Paciente existente
        public bool ValidarAgendamento(string idPaciente, string idUsuario, string idStatusAgendamento, string dataConsulta, string observacaoAgendamento)
        {
            try
            {
                

                if (Convert.ToInt32(idPaciente)<1) return false;
       
                if (Convert.ToInt32(idUsuario)<1)return false;
              
                if (Convert.ToInt32(idStatusAgendamento)<1) return false;
                if (Convert.ToDateTime(dataConsulta) <Convert.ToDateTime(DateTime.Now.ToShortDateString())) return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao tentar validar os dados do agendamento(Classe AgendarConsulta, Método ValidarAgendamento)","Erro de validação",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return true;
        }

        //Paciente novo
        public bool ValidarAgendamentoNovo(string idStatus, string dataConsulta, string observacaoAgendamento, string idUsuario, string nomePaciente, string nomeResponsavel, string rg, string cpf,string idade, string dataNascimento,string observacaoPaciente,
            string email, string telefone1, string telefone2,string telefone3, string outro, string observacaoContato,
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
                if (nomePaciente.Trim().Length < 1 || nomePaciente.Length > 50)return false;

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

                if (telefone1.Replace("(", "").Replace(")", "").Replace(",", "").Replace(".", "").Replace("_", "").Replace("-", "").Trim().Length != 11) return false;

                if (outro.GetType() != typeof(string)) return false;

                if (observacaoContato.GetType() != typeof(string)) return false;
                #endregion
                #region Endereco Novo
                if (estado.Trim().Length < 4 || estado.Length > 30) return false;

                if (cidade.Length > 30) return false;

                if (bairro.Length > 30) return false;
         
                if (rua.Length > 50) return false; 

                if (numero.Trim().Length > 5) return false;
           
                if (cep.Replace("_", "").Replace(",", "").Replace(".", "").Replace("-", "").Trim().Length != 8) return false;
        
                if (pontoReferencia.GetType() != typeof(string)) return false;

                if (observacaoEndereco.GetType() != typeof(string)) return false;

                #endregion
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a validação dos dados do agendamento da consulta de um novo paciente(Classe AgendarConsultaRegra, Método ValidarAgendamentoNovo)",
                    "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        //Paciente novo
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
                    confirmarEndereco = endereco.Cadastrar("0", idUsuario, estado, cidade, bairro, rua, numero, cep, pontoReferencia, observacaoEndereco);

                    //Cadastro do Contato
                    ContatoAcesso contato = new ContatoAcesso();
                    confirmarContato = contato.cadastrar("0", idUsuario, email, telefone1, telefone2, telefone3, outro, observacaoContato);

                    //Cadastro do Paciente 
                    CadastrarPacienteAcesso paciente = new CadastrarPacienteAcesso();
                    confirmarPaciente = paciente.Cadastrar("0", "0", "0", idUsuario, nomePaciente, nomeResponsavel, rg, cpf, "", idade, "", dataNascimento, "", "", observacaoPaciente);

                    /*Agendamento da consulta*/
                    LocalizarPacienteAcesso localizarPaciente = new LocalizarPacienteAcesso();
                    int codPaciente = localizarPaciente.UltimoPaciente();

                    bool confirmarAgendamento = AgendarConsulta(Convert.ToString(codPaciente),idUsuario,idStatus,dataConsulta,observacaoAgendamento);



                    /*os espaços são incluidos apenas para completar a requisição do método e posteriormente serem alterados*/
                    if (confirmarContato == true && confirmarEndereco == true && confirmarPaciente == true && confirmarAgendamento == true)/*Se as 4 variaveis tiverem o valor true o agendamento foi bem sucedido!*/ return true; return false;
                }
                else return false;


            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar o agendamento de uma consulta de um novo paciente(Classe AgendarConsultaRegra, Método AgendarNovo)", "Erro de Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }

        //faz o insert da hora de chegada do paciente para que ele entre na lista de atendimento
        public bool ChegadaPaciente(string idAgendamento,DateTime DataConsulta)
        {
            try
            {
                if (Convert.ToInt32(idAgendamento) > 0)
                {
                    if (DataConsulta == Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    {
                        AgendarConsultaAcesso agendar = new AgendarConsultaAcesso();
                        if (agendar.ChegadaPaciente(Convert.ToInt32(idAgendamento)))return true;return false;
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
                MessageBox.Show("Ocorreu um erro ao incluir o paciente na ordem de atendimento(Classe AgendarConsultaRegra, Método ChegadaPaciente)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }

    }
}
