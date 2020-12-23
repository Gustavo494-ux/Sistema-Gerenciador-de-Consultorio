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
    public class EditarSintomasReferidosAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
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
                MessageBox.Show("Ocorreu um erro ao atualizar os sintomas Referidos(Classe EditarSintomasReferidosAcesso, Método EditarSintomasReferidos)", "Erro de atualização/edição",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
    }
}
