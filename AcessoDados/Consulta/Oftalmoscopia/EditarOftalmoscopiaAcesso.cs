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
    public class EditarOftalmoscopiaAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool EditarOftalmoscopia(string IDCONSULTA, string DISTANCIABRUCKNER, string PAPILAOD, string PAPILAOE, string ESCAVACAOOD, string ESCAVACAOOE, string MACULAOD, string MACULAOE, string FIXACAOOD, string FIXACAOOE,
            string RELACAOAVOD, string RELACAOAVOE, string COROD, string COROE, string LENTEOD, string LENTEOE, string OBSERVACAOOFTALMOSCOPIA)
        {
            try
            {
                sql.Append("UPDATE oftalmoscopia SET distanciaBruckner= \'DISTANCIABRUCKNER\',papilaOd= \'PAPILAOD\',papilaOe= \'PAPILAOE\',escavacaoOd= \'ESCAVACAOOD\',escavacaoOe= \'ESCAVACAOOE\', ");
                sql.Append("maculaOd= \'MACULAOD\',maculaOe = \'MACULAOE\',fixacaoOd= \'FIXACAOOD\',fixacaoOe= \'FIXACAOOE\',relacaoAVOd= \'RELACAOAVOD\',relacaoAVOe= \'RELACAOAVOE\',corOd= \'COROD\', "); 
                sql.Append("corOe= \'COROE\',lenteOd= \'LENTEOD\',lenteOe= \'LENTEOE\',observacaoOftalmoscopia = \'OBSERVACAOOFTALMOSCOPIA\' WHERE idConsulta = IDCONSULTA");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("DISTANCIABRUCKNER", DISTANCIABRUCKNER).Replace("PAPILAOD", PAPILAOD).Replace("PAPILAOE", PAPILAOE).Replace("ESCAVACAOOD", ESCAVACAOOD);
                sql = sql.Replace("ESCAVACAOOE", ESCAVACAOOE).Replace("MACULAOD", MACULAOD).Replace("MACULAOE", MACULAOE).Replace("FIXACAOOD", FIXACAOOD).Replace("FIXACAOOE", FIXACAOOE);
                sql = sql.Replace("RELACAOAVOD", RELACAOAVOD).Replace("RELACAOAVOE", RELACAOAVOE).Replace("COROD", COROD).Replace("COROE", COROE).Replace("LENTEOD", LENTEOD);
                sql = sql.Replace("LENTEOE", LENTEOE).Replace("OBSERVACAOOFTALMOSCOPIA", OBSERVACAOOFTALMOSCOPIA);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualiza a Oftalmoscopia(Classe EditarOftalmoscopiaAcesso, Método EditarOftalmoscopia)","Erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
