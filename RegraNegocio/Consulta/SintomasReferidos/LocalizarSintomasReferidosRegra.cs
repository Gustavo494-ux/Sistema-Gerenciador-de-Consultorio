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
    public class LocalizarSintomasReferidosRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable PesquisarSintomasReferidos(string idSintomasReferidos)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                LocalizarSintomasReferidosAcesso pesquisar = new LocalizarSintomasReferidosAcesso();
                if (Convert.ToInt32(idSintomasReferidos) > 0) dadosTabela = pesquisar.PesquisarSintomasReferidos(idSintomasReferidos);
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo Sintomas Referidos(Classe LocalizaSintomasReferidosRegra, Método PesquisaSintomasReferidos) ", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
