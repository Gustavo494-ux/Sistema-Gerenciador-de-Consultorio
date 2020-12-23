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
    public class LocalizarConsultaRegra
    {
        DataTable dadosConsultaAcesso, tableVazia;

        public DataTable PesquisarUltimoId()
        {
            try
            {
                LocalizarConsultaAcesso pesquisarConsulta = new LocalizarConsultaAcesso();
                return dadosConsultaAcesso = pesquisarConsulta.PesquisarUltimoId();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelas chaves Estrangeiras da consulta(Classe LocalizarConsultaRegra, Método PesquisarChavesEstrangeiras)",
                   "erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable TodasConsultas()
        {
            try
            {
                LocalizarConsultaAcesso localizarConsulta = new LocalizarConsultaAcesso();
                dadosConsultaAcesso = localizarConsulta.TodasConsultas();
                if (dadosConsultaAcesso.Rows.Count < 1) return tableVazia; return dadosConsultaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarConsultaRegra, Método TodasConsultas) do Consulta , " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomePaciente(string nome)
        {
            try
            {
                LocalizarConsultaAcesso localizarConsulta = new LocalizarConsultaAcesso();
                dadosConsultaAcesso = localizarConsulta.NomePaciente(nome);
                if (dadosConsultaAcesso.Rows.Count < 1) return tableVazia; return dadosConsultaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarConsultaRegra, Método Nome) do Consulta ,Tente Novamente com uma informação diferente," +
                    " Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoConsulta(string CodigoConsulta)
        {
            try
            {
                LocalizarConsultaAcesso localizarConsulta = new LocalizarConsultaAcesso();
                dadosConsultaAcesso = localizarConsulta.CodigoConsulta(CodigoConsulta);
                if (dadosConsultaAcesso.Rows.Count < 1) return tableVazia; return dadosConsultaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarConsultaRegra, Método CodigoConsulta) do Consulta ,Tente Novamente com uma informação diferente," +
                    " Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoPaciente(string CodigoPaciente)
        {
            try
            {
                LocalizarConsultaAcesso localizarConsulta = new LocalizarConsultaAcesso();
                dadosConsultaAcesso = localizarConsulta.CodigoPaciente(CodigoPaciente);
                if (dadosConsultaAcesso.Rows.Count < 1) return tableVazia; return dadosConsultaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarConsultaRegra, Método CodigoPaciente) do Consulta ,Tente Novamente com uma informação diferente," +
                    " Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable cpfPaciente(string cpfPaciente)
        {
            try
            {
                LocalizarConsultaAcesso localizarConsulta = new LocalizarConsultaAcesso();
                dadosConsultaAcesso = localizarConsulta.cpfPaciente(cpfPaciente);
                if (dadosConsultaAcesso.Rows.Count < 1) return tableVazia; return dadosConsultaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarConsultaRegra, Método cpfPaciente) do Consulta ,Tente Novamente com uma informação diferente," +
                    " Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable rgPaciente(string rgPaciente)
        {
            try
            {
                LocalizarConsultaAcesso localizarConsulta = new LocalizarConsultaAcesso();
                dadosConsultaAcesso = localizarConsulta.rgPaciente(rgPaciente);
                if (dadosConsultaAcesso.Rows.Count < 1) return tableVazia; return dadosConsultaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarConsultaRegra, Método rgPaciente) do Consulta ,Tente Novamente com uma informação diferente," +
                    " Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
