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
    public class AcessoBancoPostgreSql
    {
        DataTable dadosTabela = new DataTable();
        DataTable tableVazia = new DataTable();
        NpgsqlCommand comandoSql = new NpgsqlCommand();
        public DataTable Pesquisar(string sql)
        {
            try
            {
                dadosTabela.Rows.Clear();
                ConexaoAcessoPostegreSql.Conectar();

                comandoSql.Connection = ConexaoAcessoPostegreSql.connPostegreSql;
                comandoSql.CommandText = sql.ToString();
                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcessoPostegreSql.Desconectar();

                return dadosTabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a pesquisa na base de dados(Classe AcessoBancoPostgreSql, Método Pesquisar)\n\n" + ex, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool Executar(string sql)
        {
            try
            {
                ConexaoAcessoPostegreSql.Conectar();

                comandoSql.Connection = ConexaoAcessoPostegreSql.connPostegreSql;
                comandoSql.CommandText = sql.ToString();

                comandoSql.ExecuteNonQuery();

                ConexaoAcessoPostegreSql.Desconectar();

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao executar uma instrução na base de dados(Classe AcessoBancoPostgreSql, Método Executar)", "Erro de Executação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool ExecutarLista(string sql)
        {
            try
            {
                string[] ListaComandos = sql.Split('#');
                ConexaoAcessoPostegreSql.Conectar();

                comandoSql.Connection = ConexaoAcessoPostegreSql.connPostegreSql;
                foreach (var comando in ListaComandos)
                {
                    comandoSql.CommandText = comando.ToString();
                    comandoSql.ExecuteNonQuery();
                }
                ConexaoAcessoPostegreSql.Desconectar();

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao executar uma instrução na base de dados(Classe AcessoBancoPostgreSql, Método ExecutarLista)", "Erro de Executação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
