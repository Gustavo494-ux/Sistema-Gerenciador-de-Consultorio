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
    public class LocalizarRxInicialRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable PesquisarRxInicial(string idRxInicial)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                LocalizarRxInicialAcesso pesquisar = new LocalizarRxInicialAcesso();
                if (Convert.ToInt32(idRxInicial) > 0) dadosTabela = pesquisar.PesquisarRxInicial(idRxInicial);
                return dadosTabela;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo RxInicial(Classe LocalizarRxInicialRegra, Método PesquisaRxInicial) ", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
