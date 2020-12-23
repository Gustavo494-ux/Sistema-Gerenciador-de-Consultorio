using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using AcessoDados;
using System.Drawing;

namespace RegraNegocio
{
    public class ImpressaoReceitaRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable impressaoCompleta(string idConsulta)
        {
            try
            {
                ImpressaoReceitaAcesso pesquisar = new ImpressaoReceitaAcesso();
                return pesquisar.impressaoCompleta(Convert.ToInt32(idConsulta));
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a impressão dos dados do receta(Classe ImpressaoReceitaRegra,Método ImpressaoCompleta)",
                       "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

    }
}
