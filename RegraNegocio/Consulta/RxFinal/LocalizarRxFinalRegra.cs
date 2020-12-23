
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
    public class LocalizarRxFinalRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable PesquisarRxFinal(string idRxFinal)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                LocalizarRxFinalAcesso pesquisar = new LocalizarRxFinalAcesso();
                if (Convert.ToInt32(idRxFinal) > 0) dadosTabela = pesquisar.PesquisarRxFinal(idRxFinal);
                return dadosTabela;
 
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo RxFinal(Classe LocalizarRxFinalRegra, Método PesquisarRxFinal) ", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
