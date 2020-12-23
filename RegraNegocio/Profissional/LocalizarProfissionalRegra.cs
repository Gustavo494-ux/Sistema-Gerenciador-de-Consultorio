using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using AcessoDados;

namespace RegraNegocio
{
    public class LocalizarProfissionalRegra
    {
        DataTable tableVazia;
        DataTable dadosTabelaRegra;

        public DataTable TodosProfissionais()
        {
            try
            {
                LocalizarProfissionalAcesso LocalizarProfissional = new LocalizarProfissionalAcesso();
                dadosTabelaRegra = LocalizarProfissional.TodosProfissionais();
                if (dadosTabelaRegra.Rows.Count >0)return dadosTabelaRegra;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarProfissionalRegra, Método TodosProfissionais) do profissional , " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoProfissional(int codigo)
        {
            try
            {
                if (codigo >0)
                {
                    LocalizarProfissionalAcesso LocalizarProfissional = new LocalizarProfissionalAcesso();
                    dadosTabelaRegra = LocalizarProfissional.CodigoProfissional(codigo);

                    if (dadosTabelaRegra.Rows.Count >0)return dadosTabelaRegra;
                }
                else
                {
                    MessageBox.Show("Código Indentificador é inválido, para proseguir com a pesquisa insira um código valido.", "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarProfissionalRegra, Método CodigoProfissional) do profissional atráves do Código Indentificador, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomeProfissional(string nome)
        {
            try
            {
                if (nome.Length > 0)
                {
                    LocalizarProfissionalAcesso LocalizarProfissional = new LocalizarProfissionalAcesso();
                    dadosTabelaRegra = LocalizarProfissional.NomeProfissional(nome);

                    if (dadosTabelaRegra.Rows.Count >0)return dadosTabelaRegra;
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarProfissionalRegra, Método NomeProfissional) do profissional atráves do nome, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CpfProfissional(string cpf)
        {
            try
            {
                if (cpf.Length > 0)
                {
                    LocalizarProfissionalAcesso LocalizarProfissional = new LocalizarProfissionalAcesso();
                    dadosTabelaRegra = LocalizarProfissional.CPFProfissional(cpf);

                    if (dadosTabelaRegra.Rows.Count >0)return dadosTabelaRegra;
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarProfissionalRegra, Método CpfProfissional) do profissional atráves do CPF, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable RgProfissional(string rg)
        {
            try
            {
                if (rg.Length > 0)
                {
                    LocalizarProfissionalAcesso LocalizarProfissional = new LocalizarProfissionalAcesso();
                    dadosTabelaRegra = LocalizarProfissional.RgProfissional(rg);

                    if (dadosTabelaRegra.Rows.Count >0) return dadosTabelaRegra;
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarProfissionalRegra, Método RgProfissional) do profissional atráves do RG, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CrooProfissional(string croo)
        {
            try
            {
                if (croo.Length > 0)
                {
                    LocalizarProfissionalAcesso LocalizarProfissional = new LocalizarProfissionalAcesso();
                    dadosTabelaRegra = LocalizarProfissional.CrooProfissional(croo);

                    if (dadosTabelaRegra.Rows.Count >0)return dadosTabelaRegra;
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarProfissionalRegra, Método CrooProfissional) do profissional atráves do CROO, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable EspecialidadeProfissional(string especialidade)
        {
            try
            {
                if (especialidade.Length > 0)
                {
                    LocalizarProfissionalAcesso LocalizarProfissional = new LocalizarProfissionalAcesso();
                    dadosTabelaRegra = LocalizarProfissional.EspecialidadeProfissional(especialidade);

                    if (dadosTabelaRegra.Rows.Count >0) return dadosTabelaRegra;
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarProfissionalRegra, Método EspecialidadeProfissional) do profissional atráves da Especialidade, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
