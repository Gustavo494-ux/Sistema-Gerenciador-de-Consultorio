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
    public class CadastrarSintomasReferidosAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool CadastrarSintomasReferidos(string IDCONSULTA,string VISAOBORRADA, string CEFALEIA, string LACRIMEJAMENTO, string OLHOVERMELHO, string VISAODUPLA, string FOTOPSIAS_FOSFENOS, string MIODESOPSIAS, 
            string DORCABECA, string ASTENOPIA, string DOROCULAR, string ARDENCIA, string SECRECOES, string COCEIRA, string FOTOFOBIA, string HALOS, string ESTRABISMO, string OUTROS)
        {
            try
            {

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
                MessageBox.Show("Ocorreu um erro ao cadastrar os Sintomas Referidos(Classe CadastrarSintomasReferidosAcesso, Método CadastrarSintomasReferidos)", "Erro de Cadastro",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
