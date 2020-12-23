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
        DataTable dadosTabela = new DataTable();
        DataTable tableVazia = new DataTable();

        NpgsqlCommand comandoSql = new NpgsqlCommand();
        public DataTable Pesquisar(string sql)
        {
            try
            {
                ConexaoAcesso.Conectar();

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();

                return dadosTabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a pesquisa na base de dados(Classe Banco, Método Pesquisar)\n\n" + ex, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool Executar(string sql)
        {
            try
            {
                ConexaoAcesso.Conectar();

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                
                comandoSql.ExecuteNonQuery();

                ConexaoAcesso.Desconectar();

                return true;
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
                string[] ListaComandos = sql.Split('#');
                ConexaoAcesso.Conectar();

                comandoSql.Connection = ConexaoAcesso.conn;
                foreach (var comando in ListaComandos)
                {
                    comandoSql.CommandText = comando.ToString();
                    comandoSql.ExecuteNonQuery();
                }
                ConexaoAcesso.Desconectar();

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao executar uma instrução na base de dados(Classe Banco, Método ExecutarLista)", "Erro de Executação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
