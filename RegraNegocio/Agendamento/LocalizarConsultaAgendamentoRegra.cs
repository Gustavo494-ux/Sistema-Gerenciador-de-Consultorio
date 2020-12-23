using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using System.Windows.Forms;
using System.Data;

namespace RegraNegocio
{
    public class LocalizarConsultaAgendamentoRegra
    {
        public DataTable TodosAgendamentos()
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            dadosTabela = null;
            try
            {
                LocalizarConsultaAgendadaAcesso pesquisarConsultaAgendada = new LocalizarConsultaAgendadaAcesso();
                dadosTabela = pesquisarConsultaAgendada.TodosAgendamentos();
                if (dadosTabela.Rows.Count > 0) return dadosTabela; return tableVazia;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por todas as consultas agendadas(Classe LocalizarConsultaAgendadaRegra ,Método TodosAgendamentos)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
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
                LocalizarConsultaAgendadaAcesso pesquisarConsultaAgendada = new LocalizarConsultaAgendadaAcesso();
                dadosTabela = pesquisarConsultaAgendada.NomePaciente(nomePaciente);
                if (dadosTabela.Rows.Count > 0) return dadosTabela; return tableVazia;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do nome do paciente(Classe LocalizarConsultaAgendadaRegra ,Método NomePaciente)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
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
                LocalizarConsultaAgendadaAcesso pesquisarConsultaAgendada = new LocalizarConsultaAgendadaAcesso();
                dadosTabela = pesquisarConsultaAgendada.RG(RG);
                if (dadosTabela.Rows.Count > 0) return dadosTabela; return tableVazia;
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do RG do paciente(Classe LocalizarConsultaAgendadaRegra ,Método RG)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
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
                LocalizarConsultaAgendadaAcesso pesquisarConsultaAgendada = new LocalizarConsultaAgendadaAcesso();
                dadosTabela = pesquisarConsultaAgendada.CPF(CPF);
                if (dadosTabela.Rows.Count > 0) return dadosTabela; return tableVazia;
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do CPF do paciente(Classe LocalizarConsultaAgendadaRegra ,Método CPF)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
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
                LocalizarConsultaAgendadaAcesso pesquisarConsultaAgendada = new LocalizarConsultaAgendadaAcesso();
                dadosTabela = pesquisarConsultaAgendada.DataNascimento(dataInicial,dataFinal);
                if (dadosTabela.Rows.Count > 0) return dadosTabela; return tableVazia;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves de um intervalo de datas de nascimento dos pacientes(Classe LocalizarConsultaAgendadaRegra ,Método DataNascimento)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
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
                LocalizarConsultaAgendadaAcesso pesquisarConsultaAgendada = new LocalizarConsultaAgendadaAcesso();
                dadosTabela = pesquisarConsultaAgendada.DataConsulta(dataInicial,dataFinal);
                if (dadosTabela.Rows.Count > 0) return dadosTabela; return tableVazia;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves de um intervalo de datas de consultas(Classe LocalizarConsultaAgendadaRegra ,Método DataConsulta)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
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
                LocalizarConsultaAgendadaAcesso pesquisarConsultaAgendada = new LocalizarConsultaAgendadaAcesso();
                dadosTabela = pesquisarConsultaAgendada.StatusAgendamento(status);
                if (dadosTabela.Rows.Count > 0) return dadosTabela; return tableVazia;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do status do agendamento(Classe LocalizarConsultaAgendadaRegra ,Método StatusAgendamento)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
            }
            return tableVazia;
        }
    }
}
