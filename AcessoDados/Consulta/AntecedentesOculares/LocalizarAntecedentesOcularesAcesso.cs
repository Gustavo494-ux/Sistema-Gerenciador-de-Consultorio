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
  public  class LocalizarAntecedentesOcularesAcesso
    {
        DataTable tableVazia = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public DataTable PesquisarAntecedentesOculares(String IDCONSULTA)
        {
            try
            {
                sql.Append("SELECT * FROM AntecedentesOculares WHERE idConsulta = IDCONSULTA AND deletar = false;");

                return acessoBanco.Pesquisar(sql.Replace("IDCONSULTA", IDCONSULTA).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Antecedentes Oculares(Classe LocalizarAntecedentesOcularesAcesso, Método PesquisarAntecedentesOculares)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

    }
}
