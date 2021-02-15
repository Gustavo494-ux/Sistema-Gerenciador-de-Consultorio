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
        StringBuilder sql = new StringBuilder();
        DataTable tableVazia = new DataTable();
        Banco acessoBanco = new Banco();
        public DataTable  impressaoCompleta(int idConsulta)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT * FROM consulta INNER JOIN rxFinal ON rxFinal.idConsulta = consulta.idConsulta INNER JOIN paciente ON ");
                sql.Append("paciente.idPaciente = consulta.idPaciente INNER JOIN profissional ON profissional.idProfissional = consulta.idProfissional ");
                sql.Append("WHERE consulta.deletar = false AND paciente.deletar = false AND profissional.deletar = false AND ");
                sql.Append("consulta.idConsulta = \'CODCONSULTA\' ");

                sql = sql.Replace("CODCONSULTA",Convert.ToString(idConsulta));

                return acessoBanco.Pesquisar(sql.ToString());
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
