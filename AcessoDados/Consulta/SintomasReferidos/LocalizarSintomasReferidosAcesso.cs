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
    public class LocalizarSintomasReferidosAcesso
    {
        DataTable tableVazia = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public DataTable PesquisarSintomasReferidos(string IDCONSULTA)
        {
            try
            {
                sql.Append("SELECT * FROM SintomasReferidos ");
                sql.Append("WHERE idConsulta = IDCONSULTA AND deletar = false;");

               return acessoBanco.Pesquisar(sql.Replace("IDCONSULTA", IDCONSULTA).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelos Sintomas Referidos(Classe LocalizarSintomasReferidosAcesso, Método PesquisarSintomasReferidos)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}

