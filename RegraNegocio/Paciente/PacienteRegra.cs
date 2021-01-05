using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
   public class PacienteRegra
    {
        PacienteAcesso localizarPaciente = new PacienteAcesso();
        DataTable tableVazia = new DataTable();
        public bool Cadastrar(string idPaciente, string idContato, string idEndereco ,string idUsuario, string nomePaciente, string nomeResponsavel, string rg, string cpf, string ocupacao, string idade,
            string sexo, string dataNascimento, string dataCadastro, string horaCadastro, string observacaoPaciente)
        {
            try
            {
                if (Validar(idPaciente,idContato,idEndereco, idUsuario,nomePaciente.ToUpper(), nomeResponsavel.ToUpper(), rg,cpf,ocupacao,idade, sexo,dataNascimento,dataCadastro,horaCadastro,observacaoPaciente) == true)
                {
                    PacienteAcesso novoPaciente = new PacienteAcesso();
                   return novoPaciente.Cadastrar(idPaciente, idContato, idEndereco, idUsuario, nomePaciente, nomeResponsavel, rg, cpf, ocupacao, idade, sexo, dataNascimento, dataCadastro, horaCadastro, observacaoPaciente);
                }
                else
                {
                    MessageBox.Show("Algumas informações do Paciente são inválidas,Tente novamente com informações diferentes, Caso o problema persista entre em contato com o suporte!",
                          "Informações inválidas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no método de validação das informações de cadastro do Paciente. Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool Validar(string idPaciente, string idContato, string idEndereco ,string idUsuario, string nomePaciente, string nomeResponsavel, string rg, string cpf, string ocupacao, string idade, 
            string sexo, string dataNascimento, string dataCadastro, string horaCadastro, string observacaoPaciente)
        {
            try
            {
                //if (Convert.ToInt32(idPaciente) < 1) return false;
                //if (Convert.ToInt32(idContato) < 1) return false;
                //if (Convert.ToInt32(idEndereco) < 1) return false;
                //if (Convert.ToInt32(idUsuario) < 1) return false;
                if (nomePaciente.Length > 50 || nomePaciente.Length < 1) return false;
                if (nomeResponsavel.Length > 50) return false;
                if (rg.Trim().Length > 20) return false;
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
                else
                {
                    return false;
                }
                if (ocupacao.Length > 30) return false;
                if (idade.Trim().Length > 3) return false;
                if (sexo != "F" && sexo != "O" && sexo != "M") return false;
                if (Convert.ToDateTime(dataNascimento) > Convert.ToDateTime(DateTime.Now.ToShortDateString())) return false;
                if (observacaoPaciente.GetType() != typeof(string)) return false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no método de validação das informações de cadastro do Paciente. Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        public DataTable RetornarDados(string codigo)
        {
            try
            {
                if (Convert.ToInt32(codigo) > 0)
                {
                    PacienteAcesso retornar = new PacienteAcesso();
                    return retornar.RetornarDados(Convert.ToInt32(codigo));
                }
                else
                {
                    MessageBox.Show("O Código Indentificador do paciente é inválido", "Código Inválido");
                    return tableVazia;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realzar uma pesquisa completa do paciente(Classe EditarPacienteRegra, Método RetornarDados)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool Atualizar(int codigo, string paciente, string responsavel, string rg, string cpf, string ocupacao, string idade, string sexo, string nascimento, string observacao)
        {
            try
            {
                if (codigo > 0)
                {
                    /*O que foi passado na de forma manual sempre vai passar pela validação, já que não são dados que podem ser manupulados pelo usuario uma vez no banco não podem ser alterados*/
                    if (Validar("0", "0", "0", "1", paciente, responsavel, rg, cpf, ocupacao, idade, sexo, nascimento, "", "", observacao) == true)
                    {
                        PacienteAcesso update = new PacienteAcesso();
                        return update.Atualizar(codigo, paciente, responsavel, rg, cpf.Replace(",", "").Replace(".", "").Replace("-", ""), ocupacao, idade, sexo, nascimento, observacao);
                    }
                    else
                    {
                        MessageBox.Show("Alguns dados não são válidos, para efetuar a atualização insira dados válidos", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("O código indentificador do Paciente é inválido, o mesmo não pode ser inferior a 1", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização de dados do paciente(Classe PacienteRegra, Método Atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        //Funções para pesquisas de paciente com diversos filtros.
        public DataTable TodosPacientes()
        {
            try
            { 
              return localizarPaciente.TodosPacientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarPacientesRegra, Método TodosPacientes) do Paciente , " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoPaciente(int codigo)
        {
            try
            {
                if (codigo > 0)
                {
                    return localizarPaciente.CodigoPaciente(codigo);
                }
                else
                {
                    MessageBox.Show("Código Indentificador é inválido, para proseguir com a pesquisa insira um código valido.", "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe PacienteRegra, Método CodigoPaciente) do Paciente atráves do Código Indentificador, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomePaciente(string nome)
        {
            try
            {
                if (nome.Length > 0)
                {
                    return localizarPaciente.NomePaciente(nome);
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe PacienteRegra, Método NomePaciente) do Paciente atráves do nome, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CpfPaciente(string cpf)
        {
            try
            {
                if (cpf.Length > 0)
                {
                    return localizarPaciente.CpfPaciente(cpf);

                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe PacienteRegra, Método CpfPaciente) do Paciente atráves do CPF, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable RgPaciente(string rg)
        {
            try
            {
                if (rg.Length > 0)
                {
                    return localizarPaciente.RgPaciente(rg);
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe PacienteRegra, Método RgPacinete) do Paciente atráves do RG, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

        //Funções para deletar lógicamente o paciente
        public bool excluirLogicamenteIdPaciente(string idUsuarioSistema, string idPaciente)
        {
            try
            {
                if (Convert.ToInt32(idPaciente) > 0)
                {
                    PacienteAcesso deletarPaciente = new PacienteAcesso();
                    return deletarPaciente.exclusaoLogicaIdPaciente(idUsuarioSistema, idPaciente);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o paciente(Classe PacienteRegra, Método excluirLogicamenteIdPaciente", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool excluirLogicamenteIdUsuario(string idUsuarioSistema, string idUsuarioCadastro)
        {
            try
            {
                if (Convert.ToInt32(idUsuarioCadastro) > 0)
                {
                    PacienteAcesso deletarPaciente = new PacienteAcesso();
                    return deletarPaciente.exclusaoLogicaIdUsuario(idUsuarioSistema, idUsuarioCadastro);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o paciente(Classe PacienteRegra, Método excluirLogicamenteIdUsuario", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
