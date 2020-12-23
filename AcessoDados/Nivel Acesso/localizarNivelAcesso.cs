using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace AcessoDados
{
    public class localizarNivelAcesso
    {
       
        public DataTable TodosNiveis()
        {
            DataTable dadosTabelaAcesso = new DataTable();
            DataTable tableVazia = new DataTable();
            try
            {

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                sql.Append("SELECT * FROM nivelAcesso where deletar = false order by idNivelAcesso asc");
                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
                
            }
			catch (Exception ex)
			{
                MessageBox.Show("Ocorreu um erro("+ex.Message+")ao pesquisar os niveis de acesso, Erro aconteceu na classe localizarNivelAcesso método TodosNiveis, Caso o problema persista entre em contato com suporte!",
                    "Erro de pesquisa",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
            return tableVazia;
        }
        public DataTable retornaridNivel(string nomeNivel)
        {
            DataTable dadosTabelaAcesso = new DataTable();
            DataTable tableVazia = new DataTable();
            
            try
            {
                string nivel = null;
                ConexaoAcesso.Conectar();
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                sql.Append("SELECT idNivelAcesso from nivelAcesso where nomeNivel = @nome and deletar = false");
                comandoSql.Parameters.Add(new NpgsqlParameter("@nome",nomeNivel));
                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro("+ex.Message+ ") ao retornar o idNivel do nivelAcesso(Classe LocalizarNivelAcesso, Método retornaridNivel)", "Erro ao pesquisar nivel",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
