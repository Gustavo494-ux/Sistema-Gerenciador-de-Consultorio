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
    public class LocalizarAntecedentesGeraisRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable PesquisarAntecedentesGerais(string idAntecedentesGerais)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                LocalizarAntecedentesGeraisAcesso pesquisar = new LocalizarAntecedentesGeraisAcesso();

                if (Convert.ToInt32(idAntecedentesGerais) > 0) dadosTabela = pesquisar.PesquisarAntecedentesGerais(idAntecedentesGerais);
                return dadosTabela;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Antecedentes Gerais(Classe LocalizarAntecedentesGeraisRegra, Método PesquisarAntecedentesGerais)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
