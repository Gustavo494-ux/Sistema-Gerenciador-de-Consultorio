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
    public class LocalizarAcuidadeVisualRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable PesquisarAcuidadeVisual(string idAcuidadeVisual)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                LocalizarAcuidadeVisualAcesso pesquisar = new LocalizarAcuidadeVisualAcesso();

                if (Convert.ToInt32(idAcuidadeVisual)>0)dadosTabela = pesquisar.PesquisarAcuidade(idAcuidadeVisual);
                return dadosTabela;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Acuidade Visual(Classe LocalizarAcuidadeVisualRegra, Método PesquisarAcuidadeVisual)", "Erro de pesquisa",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
