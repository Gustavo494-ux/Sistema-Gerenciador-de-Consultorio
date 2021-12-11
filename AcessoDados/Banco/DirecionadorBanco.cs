using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;
using System.Runtime.InteropServices;

namespace AcessoDados
{
    public class Banco
    {
        bool banco = false;// false para usar o banco sqlite e true para usar o banco postgresql

        DataTable tabelaVazia = new DataTable();
        AcessoBancoPostgreSql bancoPostgreSql = new AcessoBancoPostgreSql();
        AcessoBancoSqlite bancoSqlite = new AcessoBancoSqlite();
        public DataTable Pesquisar(string sql)
        {
            try
            {
                if (banco)//criar condição para decidir para qual banco as instruções serão direcionadas.
                {// Direcionado para o banco postgreSql
                    return bancoPostgreSql.Pesquisar(sql.ToString());
                }
                else
                {//Direcionado para o banco SQLite
                    return bancoSqlite.Pesquisar(sql.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a pesquisa na base de dados(Classe Banco, Método Pesquisar)\n\n" + ex, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabelaVazia;
        }
        public bool Executar(string sql)
        {
            try
            {
                if (banco)//criar condição para decidir para qual banco as instruções serão direcionadas.
                {// Direcionado para o banco postgreSql
                    return bancoPostgreSql.Executar(sql.ToString());
                }
                else
                {//Direcionado para o banco SQLite
                    return bancoSqlite.Executar(sql.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao executar uma instrução na base de dados(Classe Banco, Método Executar)", "Erro de Executação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool ExecutarLista(string sql)
        {
            try
            {
                if (banco)//criar condição para decidir para qual banco as instruções serão direcionadas.
                {// Direcionado para o banco postgreSql
                    return bancoPostgreSql.ExecutarLista(sql.ToString());
                }
                else
                {//Direcionado para o banco SQLite
                   return bancoSqlite.ExecutarLista(sql.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao executar uma instrução na base de dados(Classe Banco, Método ExecutarLista)", "Erro de Executação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
