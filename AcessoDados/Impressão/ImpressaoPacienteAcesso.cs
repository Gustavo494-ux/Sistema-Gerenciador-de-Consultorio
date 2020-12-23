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
    public class imprimirPacienteAcesso
    {
        DataTable tableVazia = new DataTable();
        public DataTable impressaoCompleta(int idPaciente)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("SELECT  * FROM paciente INNER JOIN endereco ON endereco.idEndereco = paciente.idEndereco INNER JOIN contato ON contato.idContato = paciente.idContato ");
                sql.Append("WHERE paciente.deletar = false AND contato.deletar = false AND  endereco.deletar = false and paciente.idPaciente = @id");

                comandoSql.Parameters.Add(new NpgsqlParameter("@id",idPaciente));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();

                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();

                return dadosTabela;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a impressão dos dados do paciente(Classe imprimirPacienteAcesso,Método impressaoCompleta)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return tableVazia;
        }
    }
}
