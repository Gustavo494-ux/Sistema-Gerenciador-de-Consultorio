using AcessoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegraNegocio
{
   public class LocalizarPacienteRegra
    {

        DataTable tableVazia;
        DataTable dadosTabelaRegra;

        public DataTable TodosPacientes()
        {
            try
            {
                LocalizarPacienteAcesso localizarPaciente = new LocalizarPacienteAcesso();
                dadosTabelaRegra = localizarPaciente.TodosPacientes();
                if (dadosTabelaRegra.Rows.Count >0) return dadosTabelaRegra; return tableVazia;
  
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
                    LocalizarPacienteAcesso localizarPaciente = new LocalizarPacienteAcesso();
                    dadosTabelaRegra = localizarPaciente.CodigoPaciente(codigo);
                    return dadosTabelaRegra;
                }
                else
                {
                    MessageBox.Show("Código Indentificador é inválido, para proseguir com a pesquisa insira um código valido.", "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarPacienteRegra, Método CodigoPaciente) do Paciente atráves do Código Indentificador, " +
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
                    LocalizarPacienteAcesso localizarPaciente = new LocalizarPacienteAcesso();
                    dadosTabelaRegra = localizarPaciente.NomePaciente(nome);
                    return dadosTabelaRegra;
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarPacienteRegra, Método NomePaciente) do Paciente atráves do nome, " +
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
                    LocalizarPacienteAcesso localizarPaciente = new LocalizarPacienteAcesso();
                    dadosTabelaRegra = localizarPaciente.CpfPaciente(cpf);
                    return dadosTabelaRegra;
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarPacienteRegra, Método CpfPaciente) do Paciente atráves do CPF, " +
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
                    LocalizarPacienteAcesso localizarPaciente = new LocalizarPacienteAcesso();
                    dadosTabelaRegra = localizarPaciente.RgPaciente(rg);
                    return dadosTabelaRegra;
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarPacienteRegra, Método RgPacinete) do Paciente atráves do RG, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
