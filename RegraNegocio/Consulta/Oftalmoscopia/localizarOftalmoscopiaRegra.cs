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
    public class localizarOftalmoscopiaRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable LocalizarOftalmoscopia(string idOftalmoscopia)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                LocalizarOftalmoscopiaAcesso pesquisar = new LocalizarOftalmoscopiaAcesso();
                if (Convert.ToInt32(idOftalmoscopia) > 0) dadosTabela = pesquisar.PesquisarOftalmoscopia(idOftalmoscopia);
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Oftalmoscopia(Classe localizarOftalmoscopiaRegra, Método LocalizarOftalmoscopia)", "Erro de pesquisa",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
