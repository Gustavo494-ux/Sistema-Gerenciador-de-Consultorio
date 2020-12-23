using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace AcessoDados
{
    public class LocalizarAnamneseAcesso
    {
        StringBuilder sql = new StringBuilder();
        DataTable tableVazia = new DataTable();
        Banco acessoBanco = new Banco();
        public DataTable PesquisarAnamnese(string IDCONSULTA)
        {
            try
            {
                sql.Append("SELECT * FROM Anamnese ");
                sql.Append("where idConsulta = IDCONSULTA AND deletar = false;");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA);
                return acessoBanco.Pesquisar(sql.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Anamnese(Classe LocalizarAnamneseAcesso, Método PesquisarAnamnese)", "Erro de pesquisa",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
