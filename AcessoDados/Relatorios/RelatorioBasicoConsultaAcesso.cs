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
        DataTable dadosTabela = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public DataTable TodasConsultas()
        {
            try
            {
                sql.Clear();
                sql.Append("select consulta.idConsulta, paciente.nomePaciente,consulta.dataConsulta,consulta.statusConsulta,usuario.loginUsuario from consulta inner join paciente on ");
                sql.Append("paciente.idPaciente = consulta.idPaciente inner join usuario on usuario.idUsuario = consulta.idUsuario inner join profissional on profissional.idProfissional = consulta.idProfissional ");
                sql.Append("where consulta.deletar = false and profissional.deletar = false and  paciente.deletar = false and usuario.deletar = false order by consulta.idConsulta asc");

                return acessoBanco.Pesquisar(sql.ToString());
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
                sql.Clear();
                sql.Append("select consulta.idConsulta, paciente.nomePaciente,consulta.dataConsulta,consulta.statusConsulta,usuario.loginUsuario from consulta inner join paciente on ");
                sql.Append("paciente.idPaciente = consulta.idPaciente inner join usuario on usuario.idUsuario = consulta.idUsuario inner join profissional on profissional.idProfissional = consulta.idProfissional ");
                sql.Append("where consulta.deletar = false and profissional.deletar = false and  paciente.deletar = false and usuario.deletar = false ");
                sql.Append("and consulta.dataConsulta BETWEEN \'DATAINICIAL\' and \'DATAFINAL\' order by consulta.idConsulta asc");

                sql = sql.Replace("DATAINICIAL",dataInicial.ToString()).Replace("DATAFINAL",dataFinal.ToString());

                return acessoBanco.Pesquisar(sql.ToString());
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
