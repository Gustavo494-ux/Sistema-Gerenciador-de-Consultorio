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
    public class CadastrarAntedecentesOcularesAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool CadastrarAntecedentesOculares(string IDCONSULTA,string TRAUMAOCULAR, string TRAUMAOCULARTRATAMENTO, string CORPOESTRANHO, string CORPOESTRANHOTRATAMENTO, string QUEIMADURAS, string QUEIMADURASTRATAMENTO,
            string CIRURGICOS, string CIRURGICOSTRATAMENTO, string INFLAMACOES, string INFLAMACOESTRATAMENTO, string CATARATA, string CATARATATRATAMENTO, string GLAUCOMA, string GLAUCOMATRATAMENTO,
            string CEGUEIRA, string CEGUEIRATRATAMENTO, string DESCOLAMENTORETINA, string DESCOLAMENTORETINATRATAMENTO, string TOXOPLASMOSE, string TOXOPLASMOSETRATAMENTO, string ESTRABISMO, string ESTRABISMOTRATAMENTO,
            string ALERGICOS, string ALERGICOSTRATAMENTO, string PTERIGIO, string PTERIGIOTRATAMENTO, string DEFEITOSREFRACAO, string DEFEITOSREFRACAOTRATAMENTO, string OUTRO, string OUTROTRATAMENTO)
        {
            try
            {
                sql.Append("insert into antecedentesOculares(idConsulta,traumaOcular,traumaOcularTratamento,corpoEstranho,corpoEstranhoTratamento,queimaduras,queimadurasTratamento,cirurgicos,cirurgicosTratamento,");
                sql.Append("inflamacoes,inflamacoesTratamento,catarata,catarataTratamento,glaucoma,glaucomaTratamento,cegueira,cegueiraTratamento,descolamentoRetina,descolamentoRetinaTratamento,");
                sql.Append("toxoplasmose,toxoplasmoseTratamento,estrabismo,estrabismoTratamento,alergicos,alergicosTratamento,pterigio,pterigioTratamento,defeitosRefracao,defeitosRefracaoTratamento,");
                sql.Append("outro,outroTratamento,deletar)");

                sql.Append("values (\'IDCONSULTA\',\'TRAUMAOCULAR\',\'TRAUMAOCULTRATAMENTO\',\'CORPOESTRANHO\',\'CORPOESTRATRATAMENTO\',\'QUEIMADURAS\',\'QUEIMADUTRATAMENTO\', \'CIRURGICOS\', ");
                sql.Append("\'CIRURGITRATAMENTO\',\'INFLAMACOES\',\'INFLAMACTRATAMENTO\',\'CATARATA\',\'CATARTRATAMENTO\',\'GLAUCOMA\',\'GLAUCTRATAMENTO\',\'CEGUEIRA\', ");
                sql.Append("\'CEGUETRATAMENTO\',\'DESCOLAMENTORETINA\',\'DESCOLAMENTORETTRATAMENTO\',\'TOXOPLASMOSE\',\'TOXOPLASMTRATAMENTO\',\'ESTRABISMO\',\'ESTRABITRATAMENTO\' ");
                sql.Append(",\'ALERGICOS\',\'ALERGITRATAMENTO\',\'PTERIGIO\',\'PTERITRATAMENTO\',\'DEFEITOSREFRACAO\',\'DEFEITOSREFRATRATAMENTO\',");
                sql.Append("\'OUTRO\',\'OUTRATAMENTO\',false)");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA);
                sql = sql.Replace("TRAUMAOCULTRATAMENTO", TRAUMAOCULARTRATAMENTO).Replace("CORPOESTRATRATAMENTO", CORPOESTRANHOTRATAMENTO).Replace("QUEIMADUTRATAMENTO", QUEIMADURASTRATAMENTO);
                sql = sql.Replace("CIRURGITRATAMENTO", CIRURGICOSTRATAMENTO).Replace("INFLAMACTRATAMENTO", INFLAMACOESTRATAMENTO).Replace("CATARTRATAMENTO", CATARATATRATAMENTO);
                sql = sql.Replace("GLAUCTRATAMENTO", GLAUCOMATRATAMENTO).Replace("CEGUETRATAMENTO", CEGUEIRATRATAMENTO).Replace("DESCOLAMENTORETTRATAMENTO", DESCOLAMENTORETINATRATAMENTO);
                sql = sql.Replace("TOXOPLASMTRATAMENTO", TOXOPLASMOSETRATAMENTO).Replace("ESTRABITRATAMENTO", ESTRABISMOTRATAMENTO).Replace("ALERGITRATAMENTO", ALERGICOSTRATAMENTO);
                sql = sql.Replace("PTERITRATAMENTO", PTERIGIOTRATAMENTO).Replace("DEFEITOSREFRATRATAMENTO", DEFEITOSREFRACAOTRATAMENTO).Replace("OUTRATAMENTO", OUTROTRATAMENTO);

                sql = sql.Replace("TRAUMAOCULAR", TRAUMAOCULAR).Replace("CORPOESTRANHO", CORPOESTRANHO).Replace("QUEIMADURAS", QUEIMADURAS).Replace("CIRURGICOS", CIRURGICOS);
                sql = sql.Replace("INFLAMACOES", INFLAMACOES).Replace("CATARATA", CATARATA).Replace("GLAUCOMA", GLAUCOMA).Replace("CEGUEIRA", CEGUEIRA).Replace("DESCOLAMENTORETINA", DESCOLAMENTORETINA);
                sql = sql.Replace("TOXOPLASMOSE", TOXOPLASMOSE).Replace("ESTRABISMO", ESTRABISMO).Replace("ALERGICOS", ALERGICOS).Replace("PTERIGIO", PTERIGIO);
                sql = sql.Replace("DEFEITOSREFRACAO", DEFEITOSREFRACAO).Replace("OUTRO", OUTRO);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar o cadastro dos antecedentesOculares(Classe CadastrarAntedecentesOcularesAcesso, Método CadastrarAntecedentesOculares)",
                    "Erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
