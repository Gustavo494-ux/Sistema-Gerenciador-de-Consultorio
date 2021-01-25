 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace AcessoDados
{
    public class MotilidadeOcularAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();

        public bool CadastrarMotilidadeOcular(string IDCONSULTA,string KAPPAOD, string KAPPAOE, string HIRSCHBERG, string DUCAOOD, string DUCAOOE,string VERSAOOD, string VERSAOOE,
            string OBSERVACAOMOTILIDADE,string FOTOMOTOROD,string FOTOMOTOROE,string CONSENSUALOD,string CONSENSUALOE,string ACOMODATIVOOD, string ACOMODATIVOOE, string BALANCO)
        {
            try
            {
                sql.Clear();
                sql.Append("INSERT INTO motilidadeOcular(idconsulta, kappaOd,kappaOe,hirschberg, ducaoOd, ducaoOe,versaoOd,versaoOe, observacaoMotilidade, fotomotorOd, fotomotorOe, consensualOd,");
                sql.Append("consensualOe, acomodativoOd, acomodativoOe, balanco) VALUES(\'IDCONSULTA\',\'KAPPAOD\',\'KAPPAOE\',\'HIRSCHBERG\',\'DUCAOOD\',\'DUCAOOE\',\'VERSAOOD\',\'VERSAOOE\', ");
                sql.Append("\'OBSERVACAOMOTILIDADE\',\'FOTOMOTOROD\',\'FOTOMOTOROE\',\'CONSENSUALOD\',\'CONSENSUALOE\',\'ACOMODATIVOOD\',\'ACOMODATIVOOE\',\'BALANCO\')");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("KAPPAOD", KAPPAOD).Replace("KAPPAOE", KAPPAOE).Replace("HIRSCHBERG", HIRSCHBERG).Replace("DUCAOOD", DUCAOOD);
                sql = sql.Replace("DUCAOOE", DUCAOOE).Replace("VERSAOOD", VERSAOOD).Replace("VERSAOOE", VERSAOOE).Replace("OBSERVACAOMOTILIDADE", OBSERVACAOMOTILIDADE);
                sql = sql.Replace("FOTOMOTOROD", FOTOMOTOROD).Replace("FOTOMOTOROE", FOTOMOTOROE).Replace("CONSENSUALOD", CONSENSUALOD).Replace("CONSENSUALOE", CONSENSUALOE);
                sql = sql.Replace("ACOMODATIVOOD", ACOMODATIVOOD).Replace("ACOMODATIVOOE", ACOMODATIVOOE).Replace("BALANCO", BALANCO);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Motilidade Ocular(Classe MotilidadeOcular, Método CadastrarMotilidade)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool AtualizarMotilidadeOcular(string IDCONSULTA, string KAPPAOD, string KAPPAOE, string HIRSCHBERG, string DUCAOOD, string DUCAOOE, string VERSAOOD, string VERSAOOE,
            string OBSERVACAOMOTILIDADE, string FOTOMOTOROD, string FOTOMOTOROE, string CONSENSUALOD, string CONSENSUALOE, string ACOMODATIVOOD, string ACOMODATIVOOE, string BALANCO)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE motilidadeOcular SET kappaOd = \'KAPPAOD\',kappaOe = \'KAPPAOE\', hirschberg = \'HIRSCHBERG\', ducaoOd = \'DUCAOOD\', ducaoOe = \'DUCAOOE\', ");
                sql.Append("versaoOd = \'VERSAOOD\',versaoOe = \'VERSAOOE\',observacaoMotilidade = \'OBSERVACAOMOTILIDADE\', fotomotorOd = \'FOTOMOTOROD\', fotomotorOe = \'FOTOMOTOROE\', consensualOd = \'CONSENSUALOD\', ");
                sql.Append("consensualOe = \'CONSENSUALOE\', acomodativoOd = \'ACOMODATIVOOD\', acomodativoOe = \'ACOMODATIVOOE\', balanco = \'BALANCO\' ");
                sql.Append("WHERE idConsulta = \'IDCONSULTA\' ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("KAPPAOD", KAPPAOD).Replace("KAPPAOE", KAPPAOE).Replace("HIRSCHBERG", HIRSCHBERG).Replace("DUCAOOD", DUCAOOD);
                sql = sql.Replace("DUCAOOE", DUCAOOE).Replace("VERSAOOD", VERSAOOD).Replace("VERSAOOE", VERSAOOE).Replace("OBSERVACAOMOTILIDADE", OBSERVACAOMOTILIDADE);
                sql = sql.Replace("FOTOMOTOROD", FOTOMOTOROD).Replace("FOTOMOTOROE", FOTOMOTOROE).Replace("CONSENSUALOD", CONSENSUALOD).Replace("CONSENSUALOE", CONSENSUALOE);
                sql = sql.Replace("ACOMODATIVOOD", ACOMODATIVOOD).Replace("ACOMODATIVOOE", ACOMODATIVOOE).Replace("BALANCO", BALANCO);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um ao atualizar os dados da Motilidade Ocular(Classe MotilidadeOcularAcesso, Método AtualizarMotilidadeOcular", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public DataTable PesquisarMotilidadeOcular(string IDCONSULTA)
        {
            try
            {
                sql.Clear();
                sql.Append("select idConsulta as \"Código Consulta\",kappaOd as \"Kappa OD\",kappaOe as \"Kappa OE\",hirschberg as \"Hirschberg\",ducaoOd as \"Dução OD\", ");
                sql.Append("ducaoOe as \"Dução OE\",versaoOd as \"Versão OD\",versaoOe as \"Versão OE\",observacaoMotilidade as \"Observação Motilidade Ocular\", ");
                sql.Append("fotomotorOd as \"Fotomotor OD\",fotomotorOe as \"Fotomotor OE\",consensualOd as \"Consensual OD\",consensualOe as \"Consensual OE\", ");
                sql.Append("acomodativoOd as \"Acomodativo OD\",acomodativoOe as \"Acomodativo OE\",balanco as \"Balanço\" FROM MotilidadeOcular WHERE idConsulta = \'IDCONSULTA\' ");

                sql = sql.Replace("IDCONSULTA",IDCONSULTA);

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Motilidade Ocular(Classe MotilidadeOcularAcesso, Método PesquisarMotilidadeOcular)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
