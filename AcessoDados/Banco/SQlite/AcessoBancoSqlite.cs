using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace AcessoDados
{
    public class AcessoBancoSqlite
    {
        DataTable dadosTabela = new DataTable();
        ConexaoAcessoSQlite bancoSqlite = new ConexaoAcessoSQlite();
        SQLiteDataAdapter SqlAdapter = null;
        SQLiteConnection Connection = null;
        public DataTable Pesquisar(string sql)
        {
            try
            {
                dadosTabela.Clear();

                using (SqlAdapter = new SQLiteDataAdapter(sql, bancoSqlite.GetStringConectSqlite()))//Executa a query.
                {
                    SqlAdapter.Fill(dadosTabela);//Preenche o dataTable(dadosTabela);
                }
                return dadosTabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a pesquisa na base de dados(Classe AcessoBancoSqlite, Método Pesquisar)\n\n" + ex, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public bool Executar(string sql)
        {
            try
            {
                Connection = new SQLiteConnection(bancoSqlite.GetStringConectSqlite());
                Connection.Open();//Abre a conexão com o banco de dados.
                using (var transacao = Connection.BeginTransaction())//Inicia a transação
                {
                    var comandoSql = Connection.CreateCommand();//Indica que será criado um comando sql.
                    comandoSql.CommandText = sql;//Cria o comando Sql.

                    comandoSql.ExecuteNonQuery();//Executa a transação

                    transacao.Commit();//Salva a transação.
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao executar uma instrução na base de dados(Classe AcessoBancoSqlite, Método Executar)", "Erro de Executação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool ExecutarLista(string sql)
        {
            try
            {
                Connection = new SQLiteConnection(bancoSqlite.GetStringConectSqlite());
                Connection.Open();//Abre a conexão com o banco de dados.

                using (var transacao = Connection.BeginTransaction())//Inicia a transação
                {
                    string[] ListaComandos = sql.Split('#');//Separa as query´s uma em cada linha do array.

                    foreach (var comando in ListaComandos)//Passa as query´s uma a uma para a variavel comando.
                    {
                        var comandoSql = Connection.CreateCommand();//Indica que será criado um comando sql.
                        comandoSql.CommandText = comando;//Cria o comando Sql.

                        comandoSql.ExecuteNonQuery();//Executa a transação
                    }
                    transacao.Commit();//Salva a transação.
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao executar uma instrução na base de dados(Classe AcessoBancoSqlite, Método ExecutarLista)", "Erro de Executação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}


