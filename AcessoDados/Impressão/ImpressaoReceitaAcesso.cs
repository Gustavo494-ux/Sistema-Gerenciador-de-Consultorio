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
    public class ImpressaoReceitaAcesso
    {
        DataTable tableVazia = new DataTable();
        public DataTable  impressaoCompleta(int idConsulta)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("SELECT * FROM consulta INNER JOIN rxFinal ON rxFinal.idRxFinal = consulta.idRxFinal INNER JOIN paciente ON ");
                sql.Append("paciente.idPaciente = consulta.idPaciente INNER JOIN profissional ON profissional.idProfissional = consulta.idProfissional ");
                sql.Append("WHERE consulta.deletar = false  AND rxFinal.deletar = false AND paciente.deletar = false AND profissional.deletar = false AND ");
                sql.Append("consulta.idConsulta = @id ");

                comandoSql.Parameters.Add(new NpgsqlParameter("@id",idConsulta));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a impressão dos dados do receta(Classe ImpressaoReceitaAcesso,Método ImpressaoCompleta)",
                         "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
