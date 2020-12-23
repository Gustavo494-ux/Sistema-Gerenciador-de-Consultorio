using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using AcessoDados;
using AcessoDados.Impressão;

namespace RegraNegocio
{
    public class ImpressaoProfissionalRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable ImpressaoCompleta(string idProfissional)
        {
            try
            {
                ImpressaoProfissionalAcesso pesquisar = new ImpressaoProfissionalAcesso();
                return pesquisar.ImpressaoCompleta(Convert.ToInt32(idProfissional));
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a impressão dos dados do profissional(Classe ImpressaoProfissionalRegra,Método ImpressaoCompleta)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
