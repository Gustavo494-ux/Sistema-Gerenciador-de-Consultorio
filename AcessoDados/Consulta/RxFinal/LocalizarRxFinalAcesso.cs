using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados
{
    public class LocalizarRxFinalAcesso
    {
        DataTable tableVazia = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public DataTable PesquisarRxFinal(String IDCONSULTA)
        {
            try
            {
                sql.Append("SELECT * FROM RxFinal WHERE idConsulta = IDCONSULTA AND deletar = false;");

               return acessoBanco.Pesquisar(sql.Replace("IDCONSULTA", IDCONSULTA).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquiar pelo RxFinal(Classe LocalizarRxFinalAcesso, Método PesquisarRxFinal)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
