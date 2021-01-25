using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AcessoDados
{
    public class ForometriaAcesso
    {
        Banco acessoBanco = new Banco();
        StringBuilder sql = new StringBuilder();

        public bool CadastrarForometria(string IDCONSULTA,string TESTEUTILIZADO,string CORRECAO,string VLOD,string VLOE,string QUARENTACMOD,string QUARENTACMOE, string VINTECMOD, string VINTECMOE, 
            string PPCOR, string PPCLUZ, string PPCFILTRO, string PFPVL, string PFPVP,string RFNVL,string RFNVP,string AAOD,string AAOE,string FLEXIBILIDADEOD,string FLEXIBILIDADEOE,string METODO, 
            string NIVELVISUAL, string DT)
        {
            try
            {
                sql.Clear();
                sql.Append("INSERT INTO Forometria(idConsulta,testeUtilizado,correcao,vlOd,vlOe,quarentaCmOd,quarentaCmOe,vinteCmOd,vinteCmOe,ppcOr,ppcLuz,ppcFiltro,pfpVl,pfpVp, ");
                sql.Append("rfnVl,rfnVp,aaOd,aaOe,flexibilidadeOd,flexibilidadeOe,metodo,nivelVisual,dt) VALUES (\'IDCONSULTA\',\'TESTEUTILIZADO\',\'CORRECAO\',\'VLOD\',\'VLOE\',\'QUARENTACMOD\', ");
                sql.Append("\'QUARENTACMOE\',\'VINTECMOD\',\'VINTECMOE\',\'PPCOR\',\'PPCLUZ\',\'PPCFILTRO\',\'PFPVL\',\'PFPVP\',\'RFNVL\',\'RFNVP\',\'AAOD\',\'AAOE\',\'FLEXIBILIDADEOD\', ");
                sql.Append("\'FLEXIBILIDADEOE\',\'METODO\',\'NIVELVISUAL\',\'DT\') ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("TESTEUTILIZADO", TESTEUTILIZADO).Replace("CORRECAO", CORRECAO).Replace("VLOD", VLOD).Replace("VLOE", VLOE);
                sql = sql.Replace("QUARENTACMOD", QUARENTACMOD).Replace("QUARENTACMOE", QUARENTACMOE).Replace("VINTECMOD", VINTECMOD).Replace("VINTECMOE", VINTECMOE).Replace("PPCOR", PPCOR);
                sql = sql.Replace("PPCLUZ", PPCLUZ).Replace("PPCFILTRO", PPCFILTRO).Replace("PFPVL", PFPVL).Replace("PFPVP", PFPVP).Replace("RFNVL", RFNVL).Replace("RFNVP", RFNVP).Replace("AAOD", AAOD);
                sql = sql.Replace("AAOE", AAOE).Replace("FLEXIBILIDADEOD", FLEXIBILIDADEOD).Replace("FLEXIBILIDADEOE", FLEXIBILIDADEOE).Replace("METODO", METODO).Replace("NIVELVISUAL", NIVELVISUAL);
                sql = sql.Replace("DT", DT);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Forometria(Classe ForometriaAcesso,Método CadastrarForometria)", "Erro de Cadastro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return false;
        }
        
        public bool AtualizarForometria(string IDCONSULTA, string TESTEUTILIZADO, string CORRECAO, string VLOD, string VLOE, string QUARENTACMOD, string QUARENTACMOE, string VINTECMOD, 
            string VINTECMOE,string PPCOR, string PPCLUZ, string PPCFILTRO, string PFPVL, string PFPVP, string RFNVL, string RFNVP, string AAOD, string AAOE, string FLEXIBILIDADEOD, 
            string FLEXIBILIDADEOE, string METODO,string NIVELVISUAL, string DT)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE Forometria SET testeUtilizado =\'TESTEUTILIZADO\',correcao =\'CORRECAO\',vlOd =\'VLOD\',vlOe =\'VLOE\',quarentaCmOd =\'QUARENTACMOD\', ");
                sql.Append("quarentaCmOe = \'QUARENTACMOE\',vinteCmOd = \'VINTECMOD\',vinteCmOe = \'VINTECMOE\',ppcOr = \'PPCOR\',ppcLuz = \'PPCLUZ\',ppcFiltro = \'PPCFILTRO\',pfpVl = \'PFPVL\', ");
                sql.Append("pfpVp = \'PFPVP\',rfnVl = \'RFNVL\',rfnVp = \'RFNVP\',aaOd = \'AAOD\',aaOe =\'AAOE\',flexibilidadeOd=\'FLEXIBILIDADEOD\',flexibilidadeOe=\'FLEXIBILIDADEOE\', ");
                sql.Append("metodo =\'METODO\',nivelVisual=\'NIVELVISUAL\',dt =\'DT\' WHERE idConsulta = \'IDCONSULTA\' ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("TESTEUTILIZADO", TESTEUTILIZADO).Replace("CORRECAO", CORRECAO).Replace("VLOD", VLOD).Replace("VLOE", VLOE);
                sql = sql.Replace("QUARENTACMOD", QUARENTACMOD).Replace("QUARENTACMOE", QUARENTACMOE).Replace("VINTECMOD", VINTECMOD).Replace("VINTECMOE", VINTECMOE).Replace("PPCOR", PPCOR);
                sql = sql.Replace("PPCLUZ", PPCLUZ).Replace("PPCFILTRO", PPCFILTRO).Replace("PFPVL", PFPVL).Replace("PFPVP", PFPVP).Replace("RFNVL", RFNVL).Replace("RFNVP", RFNVP).Replace("AAOD", AAOD);
                sql = sql.Replace("AAOE", AAOE).Replace("FLEXIBILIDADEOD", FLEXIBILIDADEOD).Replace("FLEXIBILIDADEOE", FLEXIBILIDADEOE).Replace("METODO", METODO).Replace("NIVELVISUAL", NIVELVISUAL);
                sql = sql.Replace("DT", DT);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Forometria(Classe ForometriaAcesso, Método AtualizarForometria)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public DataTable PesquisarForometria(string IDCONSULTA)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT testeUtilizado as \"Teste Utilizado\",correcao as \"Correção\",vlOd as \"VL OD\",vlOe as \"VL OE\",quarentaCmod as \"40 Cm OD\",quarentaCmOe as \"40 Cm OE\", ");
                sql.Append("vinteCmOd as \"20 Cm OD\",vinteCmOe as \"20 Cm OE\",ppcOr as \"PPC OR\",ppcLuz as \"PPC LUZ\",ppcFiltro as \"PPC FILTRO\",pfpVl as \"PFP VL\",pfpVp as \"PFP VP\", ");
                sql.Append("rfnVl as \"RFN VL\", rfnVp as \"RFN VP\",aaOd as \"AA OD\",aaOe as \"AA OE\",flexibilidadeOd as \"Flexibilidade OD\",flexibilidadeOe as \"Flexibilidade OE\", ");
                sql.Append("metodo as \"Método\",nivelVisual as \"Nível Visual\",dt as \"DT\" FROM Forometria WHERE idConsulta =\'IDCONSULTA\' ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA);

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Forometria(Classe ForometriaAcesso, Método PesquisarForometria)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
