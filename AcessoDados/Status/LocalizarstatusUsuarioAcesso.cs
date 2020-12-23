using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace AcessoDados
{
    public class LocalizarstatusUsuarioAcesso
    {
        DataTable dadosTabelaAcesso = new DataTable();
        DataTable tableVazia = new DataTable();
        public DataTable TodosStatus()
        {
			try
			{
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();
                sql.Append("SELECT * from statusUsuario where deletar = false  order by idStatusUsuario asc");
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
			}
			catch (Exception ex)
			{
                MessageBox.Show("Ocorreu um erro("+ex.Message+") ao pesquisar os status de usuario(Classe LocalizarStatusUsuarioAcesso, Método TodosStatus)","Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
            return tableVazia;
        }
    }
}
