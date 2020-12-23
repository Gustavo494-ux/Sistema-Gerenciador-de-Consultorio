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
    public class imprimirConsultaAcesso
    {
        DataTable tableVazia = new DataTable();
        public DataTable impressaoCompleta(int idConsulta)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("SELECT * FROM consulta ");
                sql.Append("INNER JOIN paciente ON paciente.idPaciente = consulta.idPaciente ");
                sql.Append("INNER JOIN profissional on profissional.idProfissional = consulta.idProfissional ");
                sql.Append("INNER JOIN anamnese ON anamnese.idAnamnese = consulta.idAnamnese ");
                sql.Append("INNER JOIN sintomasReferidos ON sintomasReferidos.idSintomasReferidos = consulta.idSintomasReferidos ");
                sql.Append("INNER JOIN antecedentesOculares ON antecedentesOculares.idAntecedentesOculares = consulta.idAntecedentesOculares ");
                sql.Append("INNER JOIN rxInicial ON rxInicial.idRxInicial = consulta.idRxInicial ");
                sql.Append("INNER JOIN rxFinal ON rxFinal.idRxFinal = consulta.idRxFinal ");
                sql.Append("INNER JOIN oftalmoscopia ON oftalmoscopia.idOftalmoscopia = consulta.idOftalmoscopia ");
                sql.Append("INNER JOIN acuidadeVisual ON acuidadeVisual.idAcuidadeVisual = consulta.idAcuidadeVisual ");
                sql.Append("INNER JOIN antecedentesGerais ON antecedentesGerais.idAntecedentesGerais = consulta.idAntecedentesGerais ");
                sql.Append("WHERE consulta.deletar = false AND paciente.deletar = false AND profissional.deletar = false ");
                sql.Append("AND consulta.idConsulta = @id ");



                comandoSql.Parameters.Add(new NpgsqlParameter("@id",idConsulta));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();
                return dadosTabela; 
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a impressão dos dados do consulta(Classe imprimirConsultaAcesso,Método ImpressaoCompleta)",
                       "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
