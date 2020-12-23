using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.CodeDom;
using System.ComponentModel;

namespace AcessoDados
{
    public class RelatorioBasicoConsultaAcesso
    {
        DataTable tableVazia = new DataTable();
        public DataTable TodasConsultas()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                sql.Append("select consulta.idConsulta, paciente.nomePaciente,consulta.dataConsulta,consulta.statusConsulta,usuario.loginUsuario from consulta inner join paciente on ");
                sql.Append("paciente.idPaciente = consulta.idPaciente inner join usuario on usuario.idUsuario = consulta.idUsuario inner join profissional on profissional.idProfissional = consulta.idProfissional ");
                sql.Append("where consulta.deletar = false and profissional.deletar = false and  paciente.deletar = false and usuario.deletar = false order by consulta.idConsulta asc");

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o relatório de consulta(Classe RelatorioBasicoConsultaAcesso, Método TodasConsultas)",
                    "Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return tableVazia;
        }

        public DataTable DataConsultaConsultas(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                sql.Append("select consulta.idConsulta, paciente.nomePaciente,consulta.dataConsulta,consulta.statusConsulta,usuario.loginUsuario from consulta inner join paciente on ");
                sql.Append("paciente.idPaciente = consulta.idPaciente inner join usuario on usuario.idUsuario = consulta.idUsuario inner join profissional on profissional.idProfissional = consulta.idProfissional ");
                sql.Append("where consulta.deletar = false and profissional.deletar = false and  paciente.deletar = false and usuario.deletar = false ");
                sql.Append("and consulta.dataConsulta BETWEEN @dataInicial and @dataFinal order by consulta.idConsulta asc");

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                comandoSql.Parameters.Add(new NpgsqlParameter("@dataInicial",dataInicial));
                comandoSql.Parameters.Add(new NpgsqlParameter("@dataFinal",dataFinal));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o relatório de consulta(Classe RelatorioBasicoConsultaAcesso, Método DataConsultaConsultas)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }



    }
}
