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
    public class LocalizarAntecedentesGeraisAcesso
    {
        DataTable tableVazia = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public DataTable PesquisarAntecedentesGerais(string IDCONSULTA)
        {
            try
            {
                sql.Append("SELECT * FROM AntecedentesGerais ");
                sql.Append("WHERE idConsulta = IDCONSULTA AND deletar = false;");

                return acessoBanco.Pesquisar(sql.Replace("IDCONSULTA", IDCONSULTA).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Antecedentes Gerais(Classe LocalizarAntecedentesGerais, Método PesquisarAntecedentesGerais)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
