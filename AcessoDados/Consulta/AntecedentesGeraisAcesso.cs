using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace AcessoDados
{
    public class AntecedentesGeraisAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        DataTable tableVazia = new DataTable();
        public bool CadastrarAntecentesGerais(string IDCONSULTA,string VASCULARES, string VASCULARESTRATAMENTO, string DIABETES, string DIABETESTRATAMENTO, string IMUNES, string IMUNESTRATAMENTO, string NEUROLOGICOS,
            string NEUROLOGICOSTRATAMENTO, string OUTROS, string OUTROSTRATAMENTO, string OBSERVACAOANTECEDENTESGERAIS)
        {
            try
            {
                sql.Append("INSERT INTO antecedentesGerais(idConsulta,vasculares,vascularTratamento,diabetes,diabetesTratamento,imunes,imunesTratamento,neurologicos,neurologicosTratamento,");
                sql.Append(" outros,outrosTratamento,observacaoAntecedentesGerais,deletar) values(\'IDCONSULTA\',\'VASCULARES\',\'VASCULTRATAMENTO\',\'DIABETES\',\'DIABETTRATAMENTO\', ");
                sql.Append("\'IMUNES\',\'IMUNTRATAMENTO\',\'NEUROLOGICOS\',\'NEUROLOGTRATAMENTO\',\'OUTROS\',\'OUTTRATAMENTO\',\'OBSERVACAOANTECEDENTESGERAIS\',false);");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("VASCULARES", VASCULARES).Replace("DIABETES", DIABETES).Replace("IMUNES", IMUNES);
                sql = sql.Replace("NEUROLOGICOS", NEUROLOGICOS).Replace("OUTROS", OUTROS);

                sql = sql.Replace("DIABETTRATAMENTO", DIABETESTRATAMENTO).Replace("IMUNTRATAMENTO", IMUNESTRATAMENTO).Replace("VASCULTRATAMENTO", VASCULARESTRATAMENTO);
                sql = sql.Replace("NEUROLOGTRATAMENTO", NEUROLOGICOSTRATAMENTO).Replace("OUTTRATAMENTO", OUTROSTRATAMENTO).Replace("OBSERVACAOANTECEDENTESGERAIS", OBSERVACAOANTECEDENTESGERAIS);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar os Antecedentes Gerais(Classe AntecedentesGeraisAcesso, Método CadastrarAntecentesGerais)",
                    "Erro de Cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }

        public bool EditarAntecedentesGerais(string IDCONSULTA, string VASCULARES, string VASCULARESTRATAMENTO, string DIABETES, string DIABETESTRATAMENTO, string IMUNES, string IMUNESTRATAMENTO, string NEUROLOGICOS,
           string NEUROLOGICOSTRATAMENTO, string OUTROS, string OUTROSTRATAMENTO, string OBSERVACAOANTECEDENTESGERAIS)
        {
            try
            {

                sql.Append("UPDATE antecedentesGerais SET vasculares = \'VASCULARES\', vascularTratamento = \'VASCULARESTRATAMENTO\', diabetes = \'DIABETES\', diabetesTratamento = \'DIABETESTRATAMENTO\', ");
                sql.Append("imunes = \'IMUNES\', imunesTratamento = \'IMUNESTRATAMENTO\',neurologicos = \'NEUROLOGICOS\', neurologicosTratamento = \'NEUROLOGICOSTRATAMENTO\', outros = \'OUTROS\', ");
                sql.Append("outrosTratamento = \'OUTROSTRATAMENTO\',observacaoAntecedentesGerais = \'OBSERVACAOANTECEDENTESGERAIS\' where idConsulta = \'IDCONSULTA\' ");

                sql = sql.Replace("VASCULARESTRATAMENTO", VASCULARESTRATAMENTO).Replace("DIABETESTRATAMENTO", DIABETESTRATAMENTO).Replace("IMUNESTRATAMENTO", IMUNESTRATAMENTO);
                sql = sql.Replace("NEUROLOGICOSTRATAMENTO", NEUROLOGICOSTRATAMENTO).Replace("OUTROSTRATAMENTO", OUTROSTRATAMENTO);
                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("VASCULARES", VASCULARES).Replace("DIABETES", DIABETES).Replace("IMUNES", IMUNES);
                sql = sql.Replace("NEUROLOGICOS", NEUROLOGICOS).Replace("OUTROS", OUTROS).Replace("OBSERVACAOANTECEDENTESGERAIS", OBSERVACAOANTECEDENTESGERAIS);


                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os Atecedentes Gerais(Classe AntecedentesGeraisAcesso, Método EditarAntecedentesGerais)",
                    "Erro de atualização/edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public DataTable PesquisarAntecedentesGerais(string IDCONSULTA)
        {
            try
            {
                sql.Append("SELECT * FROM AntecedentesGerais ");
                sql.Append("WHERE idConsulta = IDCONSULTA AND deletar = false;");

                return acessoBanco.Pesquisar(sql.Replace("IDCONSULTA", IDCONSULTA).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Antecedentes Gerais(Classe AntecedentesGeraisAcesso, Método PesquisarAntecedentesGerais)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
