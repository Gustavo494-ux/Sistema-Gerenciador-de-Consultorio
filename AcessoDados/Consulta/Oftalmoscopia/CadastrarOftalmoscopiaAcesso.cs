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
    public class CadastrarOftalmoscopiaAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();

        public bool CadastrarOftalmoscopia(string IDCONSULTA, string DISTANCIABRUCKNER, string PAPILAOD, string PAPILAOE, string ESCAVACAOOD, string ESCAVACAOOE, string MACULAOD, string MACULAOE, string FIXACAOOD, string FIXACAOOE,
            string RELACAOAVOD, string RELACAOAVOE, string COROD, string COROE, string LENTEOD, string LENTEOE, string OBSERVACAOOFTALMOSCOPIA)
        {
            try
            {
                sql.Append("insert into oftalmoscopia(idConsulta,distanciaBruckner, papilaOd, papilaOe, escavacaoOd, escavacaoOe, maculaOd, maculaOe, fixacaoOd, fixacaoOe, relacaoAVOd, ");
                sql.Append("relacaoAVOe, corOd, corOe, lenteOd, lenteOe, observacaoOftalmoscopia,deletar) values(\'IDCONSULTA\',\'DISTANCIABRUCKNER\',\'PAPILAOD\',\'PAPILAOE\',\'ESCAVACAOOD\' ");
                sql.Append(",\'ESCAVACAOOE\',\'MACULAOD\',\'MACULAOE\',\'FIXACAOOD\',\'FIXACAOOE\',\'RELACAOAVOD\',\'RELACAOAVOE\',\'COROD\',\'COROE\',\'LENTEOD\',\'LENTEOE\', ");
                sql.Append("\'OBSERVACAOOFTALMOSCOPIA\',false)");


                sql = sql.Replace("IDCONSULTA",IDCONSULTA).Replace("DISTANCIABRUCKNER", DISTANCIABRUCKNER).Replace("PAPILAOD", PAPILAOD).Replace("PAPILAOE", PAPILAOE).Replace("ESCAVACAOOD", ESCAVACAOOD);
                sql = sql.Replace("ESCAVACAOOE", ESCAVACAOOE).Replace("MACULAOD", MACULAOD).Replace("MACULAOE", MACULAOE).Replace("FIXACAOOD", FIXACAOOD).Replace("FIXACAOOE", FIXACAOOE);
                sql = sql.Replace("RELACAOAVOD", RELACAOAVOD).Replace("RELACAOAVOE", RELACAOAVOE).Replace("COROD", COROD).Replace("COROE", COROE).Replace("LENTEOD", LENTEOD);
                sql = sql.Replace("LENTEOE", LENTEOE).Replace("OBSERVACAOOFTALMOSCOPIA", OBSERVACAOOFTALMOSCOPIA);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Oftalmoscopia(Classe CadastrarOftalmoscopiaAcesso, Método CadastrarOftalmoscopia", "Erro de Cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
    }
}
