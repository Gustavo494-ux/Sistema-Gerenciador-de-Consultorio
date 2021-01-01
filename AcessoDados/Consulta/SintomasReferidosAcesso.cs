using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;
using System.Security.AccessControl;

namespace AcessoDados
{
    public class SintomasReferidosAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        DataTable tableVazia = new DataTable();
        public bool CadastrarSintomasReferidos(string IDCONSULTA,string VISAOBORRADA, string CEFALEIA, string LACRIMEJAMENTO, string OLHOVERMELHO, string VISAODUPLA, string FOTOPSIAS_FOSFENOS, string MIODESOPSIAS, 
            string DORCABECA, string ASTENOPIA, string DOROCULAR, string ARDENCIA, string SECRECOES, string COCEIRA, string FOTOFOBIA, string HALOS, string ESTRABISMO, string OUTROS)
        {
            try
            {
                sql.Clear();
                sql.Append("insert into sintomasReferidos(idConsulta,visaoBorrada,cefaleia,lacrimejamento,olhoVermelho,visaoDupla,fotopsias_fosfenos,miodesopsias,dorCabeca, ");
                sql.Append("astenopia,dorOcular,ardencia,secrecoes,coceira,fotofobia,halos,estrabismo,outros,deletar) values(\'IDCONSULTA\',\'VISAOBORRADA\',\'CEFALEIA\',\'LACRIMEJAMENTO\', ");
                sql.Append("\'OLHOVERMELHO\',\'VISAODUPLA\',\'FOTOPSIAS_FOSFENOS\',\'MIODESOPSIAS\',\'DORCABECA\',\'ASTENOPIA\',\'DOROCULAR\',\'ARDENCIA\',\'SECRECOES\',\'COCEIRA\',\'FOTOFOBIA\',\'HALOS\', ");
                sql.Append("\'ESTRABISMO\',\'OUTROS\',false);");

                sql = sql.Replace("IDCONSULTA",IDCONSULTA).Replace("VISAOBORRADA", VISAOBORRADA).Replace("CEFALEIA", CEFALEIA).Replace("LACRIMEJAMENTO", LACRIMEJAMENTO).Replace("OLHOVERMELHO", OLHOVERMELHO);
                sql = sql.Replace("VISAODUPLA", VISAODUPLA).Replace("FOTOPSIAS_FOSFENOS", FOTOPSIAS_FOSFENOS).Replace("MIODESOPSIAS", MIODESOPSIAS).Replace("DORCABECA", DORCABECA).Replace("ASTENOPIA", ASTENOPIA);
                sql = sql.Replace("DOROCULAR", DOROCULAR).Replace("ARDENCIA", ARDENCIA).Replace("SECRECOES", SECRECOES).Replace("COCEIRA", COCEIRA).Replace("FOTOFOBIA", FOTOFOBIA);
                sql = sql.Replace("HALOS", HALOS).Replace("ESTRABISMO", ESTRABISMO).Replace("OUTROS", OUTROS);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar os Sintomas Referidos(Classe SintomasReferidosAcesso, Método CadastrarSintomasReferidos)", "Erro de Cadastro",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }

        public bool EditarSintomasReferidos(string IDCONSULTA, string VISAOBORRADA, string CEFALEIA, string LACRIMEJAMENTO, string OLHOVERMELHO, string VISAODUPLA, string FOTOPSIAS_FOSFENOS, string MIODESOPSIAS,
           string DORCABECA, string ASTENOPIA, string DOROCULAR, string ARDENCIA, string SECRECOES, string COCEIRA, string FOTOFOBIA, string HALOS, string ESTRABISMO, string OUTROS)
        {
            try
            {

                sql.Append("UPDATE sintomasReferidos SET visaoBorrada = \'VISAOBORRADA\', cefaleia = \'CEFALEIA\', lacrimejamento = \'LACRIMEJAMENTO\', olhoVermelho = \'OLHOVERMELHO\', ");
                sql.Append(" visaoDupla = \'VISAODUPLA\', fotopsias_fosfenos = \'FOTOPSIAS_FOSFENOS\', miodesopsias = \'MIODESOPSIAS\', dorCabeca = \'DORCABECA\', ");
                sql.Append(" astenopia = \'ASTENOPIA\', dorOcular = \'DOROCULAR\', ardencia = \'ARDENCIA\', secrecoes = \'SECRECOES\', coceira = \'COCEIRA\', fotofobia = \'FOTOFOBIA\', ");
                sql.Append(" halos = \'HALOS\' , estrabismo = \'HALOS\', outros = \'OUTROS\' ");
                sql.Append(" WHERE idConsulta = \'IDCONSULTA\' AND deletar = false");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("VISAOBORRADA", VISAOBORRADA).Replace("CEFALEIA", CEFALEIA).Replace("LACRIMEJAMENTO", LACRIMEJAMENTO).Replace("OLHOVERMELHO", OLHOVERMELHO);
                sql = sql.Replace("VISAODUPLA", VISAODUPLA).Replace("FOTOPSIAS_FOSFENOS", FOTOPSIAS_FOSFENOS).Replace("MIODESOPSIAS", MIODESOPSIAS).Replace("DORCABECA", DORCABECA);
                sql = sql.Replace("ASTENOPIA", ASTENOPIA).Replace("DOROCULAR", DOROCULAR).Replace("ARDENCIA", ARDENCIA).Replace("SECRECOES", SECRECOES).Replace("COCEIRA", COCEIRA).Replace("FOTOFOBIA", FOTOFOBIA);
                sql = sql.Replace("HALOS", HALOS).Replace("ESTRABISMOESTRABISMO", ESTRABISMO).Replace("OUTROS", OUTROS);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os sintomas Referidos(Classe SintomasReferidosAcesso, Método EditarSintomasReferidos)", "Erro de atualização/edição",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable PesquisarSintomasReferidos(string IDCONSULTA)
        {
            try
            {
                sql.Append("SELECT * FROM SintomasReferidos ");
                sql.Append("WHERE idConsulta = IDCONSULTA AND deletar = false;");

                return acessoBanco.Pesquisar(sql.Replace("IDCONSULTA", IDCONSULTA).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelos Sintomas Referidos(Classe SintomasReferidosAcesso, Método PesquisarSintomasReferidos)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
