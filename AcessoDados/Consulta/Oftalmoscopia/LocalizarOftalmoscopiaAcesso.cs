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
    public class LocalizarOftalmoscopiaAcesso
    {
        DataTable tableVazia = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public DataTable PesquisarOftalmoscopia(string IDCONSULTA)
        {
            try
            {
                sql.Append("SELECT * FROM Oftalmoscopia ");
                sql.Append("WHERE idConsulta = IDCONSULTA AND deletar = false;");

                return acessoBanco.Pesquisar(sql.Replace("IDCONSULTA", IDCONSULTA).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Oftalmoscopia(Classe LocalizarOftalmoscopiaAcesso, Método PesquisarOftalmoscopia)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

    }
}
