using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;

namespace AcessoDados.Impressão
{
    public class ImpressaoProfissionalAcesso
    {
        DataTable tableVazia = new DataTable();

        public DataTable ImpressaoCompleta(int idProfissional)
        {
            try
            {
                DataTable dadosTabela = new DataTable();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                sql.Append("SELECT * FROM profissional INNER JOIN usuario ON usuario.idUsuario = profissional.idUsuario INNER JOIN contato ON contato.idContato = profissional.idContato ");
                sql.Append("INNER JOIN endereco ON endereco.idEndereco = profissional.idEndereco WHERE profissional.deletar = false AND usuario.deletar = false AND contato.deletar = false AND ");
                sql.Append("endereco.deletar = false  AND idProfissional = @id");

                comandoSql.Parameters.Add(new NpgsqlParameter("@id",idProfissional));

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a impressão dos dados do profissional(Classe ImpressaoProfissionalAcesso,Método ImpressaoCompleta)", 
                    "Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
