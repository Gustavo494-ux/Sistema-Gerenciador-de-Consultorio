using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class ImpressaoConsultaRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable impressaoCompleta(string idConsulta)
        {
            try
            { 
                DataTable dadosTabela = new DataTable();
                imprimirConsultaAcesso pesquisar = new imprimirConsultaAcesso();
                dadosTabela = pesquisar.impressaoCompleta(Convert.ToInt32(idConsulta));
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a impressão dos dados do consulta(Classe ImpressaoConsultaRegra,Método ImpressaoCompleta)",
                "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
