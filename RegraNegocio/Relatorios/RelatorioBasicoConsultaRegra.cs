using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using AcessoDados;
using System.Net;

namespace RegraNegocio
{
    public class RelatorioBasicoConsultaRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable TodasConsultas()
        {
            try
            {
                RelatorioBasicoConsultaAcesso pesquisar = new RelatorioBasicoConsultaAcesso();
                pesquisar.TodasConsultas();
                return pesquisar.TodasConsultas();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o relatório de consulta(Classe RelatorioBasicoConsultaRegra, Método DataConsultaConsultas)",
                   "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

        public DataTable DataConsultaConsultas(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                RelatorioBasicoConsultaAcesso pesquisar = new RelatorioBasicoConsultaAcesso();
                return pesquisar.DataConsultaConsultas(dataInicial,dataFinal);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o relatório de consulta(Classe RelatorioBasicoConsultaRegra, Método DataConsultaConsultas)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

    }
}

