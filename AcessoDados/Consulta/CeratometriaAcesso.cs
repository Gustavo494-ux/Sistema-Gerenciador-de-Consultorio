using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AcessoDados
{
    public class CeratometriaAcesso
    {
        Banco acessoBanco = new Banco();
        StringBuilder sql = new StringBuilder();
        public bool CadastrarCeratometria(string IDCONSULTA,string OD, string OE,string TIPOCERATOMETRO, string OBSERVACAOCERATOMETRIA)
        {
            try
            {
                sql.Clear();
                sql.Append("INSERT INTO Ceratometria(idConsuta,od,oe,tipoCeratometro,observacaoCeratometria) VALUES (IDCONSULTA,OD,OE,TIPOCERATOMETRO,OBSERVACAOCERATOMETRIA) ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("OD", OD).Replace("OE", OE).Replace("TIPOCERATOMETRO", TIPOCERATOMETRO).Replace("OBSERVACAOCERATOMETRIA", OBSERVACAOCERATOMETRIA);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Ceratometria(Classe CeratometriaAcesso, Método CadastrarCeratometria)", "Erro de Cadastro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return false;
        }
        public bool AtualizarCeratometria(string IDCONSULTA, string OD, string OE, string TIPOCERATOMETRO, string OBSERVACAOCERATOMETRIA)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE Ceratometria SET od = \'OD\', oe = \'OE\',tipoCeratometro as \'Tipo Ceratometro\', observacaoCeratometria = \'Observação Ceratometria\' ");
                sql.Append("WHERE idConsulta = \'IDCONSULTA\' ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("OD", OD).Replace("OE", OE).Replace("TIPOCERATOMETRO", TIPOCERATOMETRO).Replace("OBSERVACAOCERATOMETRIA", OBSERVACAOCERATOMETRIA);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Ceratometria(Classe CeratometriaAcesso, Método AtualizarCeratometria)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable PesquisarCeratometria(string IDCONSULTA)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT idConsulta as \'Código Consulta\', od as \'OD\', oe as \'OE\',tipoCeratometro as \'Tipo Ceratometro\', observacaoCeratometria as \'Observação Ceratometria ");
                sql.Append("FROM Ceratometria WHERE idConsulta = \'IDCONSULTA\' ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA);

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Ceratometria(Classe Ceratometria, Método PesquisarCeratometria)", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
