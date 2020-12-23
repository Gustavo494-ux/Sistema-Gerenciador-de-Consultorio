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
    public class RelatoriosPacienteRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable TodosPacientesCadastroSimples()
        {
			try
			{
                RelatoriosPacienteAcesso pesquisar = new RelatoriosPacienteAcesso();
                return pesquisar.TodosPacientesCadastroSimples();
			}
			catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar dados para eleboração do relatorio(Classe RelatoriosPacienteRegra, Método TodosPacientesCadastroSimples)"
                    , "Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
            return tableVazia;
        }
        public DataTable DataNascimentoPacientesCadastroSimple(DateTime dataInicial,DateTime dataFinal)
        {
            try
            {
                RelatoriosPacienteAcesso pesquisar = new RelatoriosPacienteAcesso();
                return pesquisar.DataNascimentoPacientesCadastroSimples(dataInicial,dataFinal);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar dados para eleboração do relatorio(Classe RelatoriosPacienteRegra, Método DataNascimentoPacientesCadastroSimples)"
                    , "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable DataCadastroPacientesCadastroSimples(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                RelatoriosPacienteAcesso pesquisar = new RelatoriosPacienteAcesso();
                return pesquisar.DataCadastroPacientesCadastroSimples(dataInicial, dataFinal);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar dados para eleboração do relatorio(Classe RelatoriosPacienteRegra, Método DataCadastroPacientesCadastroSimples)"
                    , "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable IdadePacientesCadastroSimples(string idadeInicial, string idadeFinal)
        {
            try
            {
                RelatoriosPacienteAcesso pesquisar = new RelatoriosPacienteAcesso();
                return pesquisar.IdadePacientesCadastroSimples(idadeInicial, idadeFinal);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar dados para eleboração do relatorio(Classe RelatoriosPacienteRegra, Método IdadePacientesCadastroSimples)"
                    , "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
