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
    public class LocalizarAntecedentesOcularesRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable PesquisarAntecedentesOculares(string idAntecedentesOculares)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                LocalizarAntecedentesOcularesAcesso pesquisar = new LocalizarAntecedentesOcularesAcesso();

                if (Convert.ToInt32(idAntecedentesOculares) > 0) dadosTabela = pesquisar.PesquisarAntecedentesOculares(idAntecedentesOculares);
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Antecedentes Oculares(Classe LocalizarAntecedentesOcularesRegra, Método PesquisarAntecedentesOculares)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
