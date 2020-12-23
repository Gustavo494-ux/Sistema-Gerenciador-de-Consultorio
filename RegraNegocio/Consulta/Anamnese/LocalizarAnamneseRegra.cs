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
    public class LocalizarAnamneseRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable PesquisarAnamnese(string idAnamnese)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                LocalizarAnamneseAcesso pesquisar = new LocalizarAnamneseAcesso();

                if (Convert.ToInt32(idAnamnese) > 0) dadosTabela = pesquisar.PesquisarAnamnese(idAnamnese);
                return dadosTabela;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Anamnese(Classe LocalizarAnamneseRegra, Método PesquisarAnamnese)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
