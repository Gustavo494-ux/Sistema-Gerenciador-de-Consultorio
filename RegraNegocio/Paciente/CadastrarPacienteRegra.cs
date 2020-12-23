using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
   public class CadastrarPacienteRegra
    {
        public bool Cadastrar(string idPaciente, string idContato, string idEndereco ,string idUsuario, string nomePaciente, string nomeResponsavel, string rg, string cpf, string ocupacao, string idade,
            string sexo, string dataNascimento, string dataCadastro, string horaCadastro, string observacaoPaciente)
        {
            try
            {
                if (Validar(idPaciente,idContato,idEndereco, idUsuario,nomePaciente.ToUpper(), nomeResponsavel.ToUpper(), rg,cpf,ocupacao,idade, sexo,dataNascimento,dataCadastro,horaCadastro,observacaoPaciente) == true)
                {
                    CadastrarPacienteAcesso novoPaciente = new CadastrarPacienteAcesso();
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
                if (idPaciente !="0") return false;

                if (Convert.ToInt32(idUsuario) < 1) return false;

                if (nomePaciente.Length > 50 || nomePaciente.Length <1) return false;

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
   }
}
