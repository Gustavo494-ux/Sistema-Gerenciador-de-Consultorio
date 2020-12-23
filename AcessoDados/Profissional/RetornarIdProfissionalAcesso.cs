using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace AcessoDados
{
    public class RetornarIdProfissionalAcesso
    {
        public int idUsuario(int idUsuario)
        {
            string nomeUsuario="";
            int idProfissional=0;
            try
            {
                if (idProfissional ==0)
                {
                    #region Pesquisar nome do usuario
                    StringBuilder sql = new StringBuilder();
                    NpgsqlCommand comandoSql = new NpgsqlCommand();

                    ConexaoAcesso.Desconectar();
                    ConexaoAcesso.Conectar();

                    sql.Append("select * from usuario where idUsuario = @idUsuario and deletar = false");

                    comandoSql.Parameters.Add(new NpgsqlParameter("@idUsuario", idUsuario));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = ConexaoAcesso.conn;
                    var nome = comandoSql.ExecuteReader();

                    while (nome.Read())
                    {
                        nomeUsuario = nome["nomeUsuario"].ToString();
                    }
                    ConexaoAcesso.Desconectar();
                    #endregion 
                }
                if (idProfissional==0)
                {
                    #region Pesquisar idProfissional
                    StringBuilder sql = new StringBuilder();
                    NpgsqlCommand comandoSql = new NpgsqlCommand();
                    ConexaoAcesso.Desconectar();
                    ConexaoAcesso.Conectar();

                    sql.Append("select * from profissional where nomeProfissional like '%" + nomeUsuario.ToUpper() + "%' and deletar = false"); ;

                    comandoSql.Parameters.Add(new NpgsqlParameter("@nomeProfissional", nomeUsuario.ToUpper()));

                    comandoSql.CommandText = sql.ToString();
                    comandoSql.Connection = ConexaoAcesso.conn;
                    var id = comandoSql.ExecuteReader();

                    while (id.Read())
                    {
                        idProfissional = Convert.ToInt32(id["idProfissional"].ToString());
                    }
                    ConexaoAcesso.Desconectar();
                    return idProfissional;
                    #endregion 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar o idProfissional(ClasseRetornarIdProfissionalAcesso,Método idUsuario )", 
                    "Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return 0;
        }

    }
}
