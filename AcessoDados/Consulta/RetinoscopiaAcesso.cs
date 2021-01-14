using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AcessoDados
{
    public class RetinoscopiaAcesso
    {
        Banco acessoBanco = new Banco();
        StringBuilder sql = new StringBuilder();
        
        public bool CadastrarRetinoscopia(string IDCONSULTA,string ESTATICAOD, string ESTATICAOE, string DINAMICAOD, string DINAMICAOE,string SUBJETIVOOD, string SUBJETIVOOE,
            string AFINAMENTOOD, string AFINAMENTOOE, string ADICAONIVELOD, string ADICAONIVELOE)
        {
            try
            {
                sql.Clear();
                sql.Append("INSERT INTO Retinoscopia(idConsulta, estaticaOd, estaticaOe, dinamicaOd,dinamicaOe, subjetivoOd, subjetivoOe, afinamentoOd,afinamentoOe, adicaoNivelOd, adicaoNivelOe) ");
                sql.Append("VALUES (IDCONSULTA,ESTATICAOD,ESTATICAOE,DINAMICAOD,DINAMICAOE,SUBJETIVAOD,SUBJETIVOOE,AFINAMENTOOD,AFINAMENTOOE,ADICAONIVELOD,ADICAONIVELOE) ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("ESTATICAOD", ESTATICAOD).Replace("ESTATICAOE", ESTATICAOE).Replace("DINAMICAOD", DINAMICAOD).Replace("DINAMICAOE", DINAMICAOE);
                sql = sql.Replace("SUBJETIVAOD", SUBJETIVOOD).Replace("SUBJETIVOOE", SUBJETIVOOE).Replace("AFINAMENTOOD", AFINAMENTOOD).Replace("AFINAMENTOOE", AFINAMENTOOE);
                sql = sql.Replace("ADICAONIVELOD", ADICAONIVELOD).Replace("ADICAONIVELOE", ADICAONIVELOE);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Retinoscopia(Classe RetinoscopiaAcesso,Método CadastrarRetinoscopia)","Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool AtualizarRetinoscopia(string IDCONSULTA, string ESTATICAOD, string ESTATICAOE, string DINAMICAOD, string DINAMICAOE, string SUBJETIVOOD, string SUBJETIVOOE,
            string AFINAMENTOOD, string AFINAMENTOOE, string ADICAONIVELOD, string ADICAONIVELOE)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE Retinoscopia SET estaticaOd = \'ESTATICAOD\',estaticaOe = \'ESTATICAOE\',dinamicaOd = \'DINMAICAOD\',dinamicaOe = \'DINAMICAOE\',subjetivoOd = \'SUBJETIVOOD\', ");
                sql.Append("subjetivoOe = \'SUBJETIVOOE\', afinamentoOd = \'AFINAMENTOOD\', afinamentoOe = \'AFINAMENTOOE\',adicaoNivelOd = \'ADICAONIVELOD\',adicaoNivelOe = \'ADICAONIVELOE\' ");
                sql.Append("WHERE idConsulta = \'IDCONSULTA\' ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("ESTATICAOD", ESTATICAOD).Replace("ESTATICAOE", ESTATICAOE).Replace("DINAMICAOD", DINAMICAOD).Replace("DINAMICAOE", DINAMICAOE);
                sql = sql.Replace("SUBJETIVAOD", SUBJETIVOOD).Replace("SUBJETIVOOE", SUBJETIVOOE).Replace("AFINAMENTOOD", AFINAMENTOOD).Replace("AFINAMENTOOE", AFINAMENTOOE);
                sql = sql.Replace("ADICAONIVELOD", ADICAONIVELOD).Replace("ADICAONIVELOE", ADICAONIVELOE);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Retinoscopia(Classe RetinoscopiaAcesso, Método AtualizarRetinoscopia)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public DataTable PesquisarRetinoscopia(string IDCONSULTA)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT Retinoscopia idConsulta \'Código Consulta\', estaticaOd as \'Estática OD\', estaticaOe as \'Estática OE\',dinamicaOd as \'Dinâmica OD\', ");
                sql.Append("dinamicaOe as \'Dinâmica OE\', subjetivoOd as \'Subjetivo OD\', subjetivoOe as \'Subjetivo OE\', afinamentoOd as \'Afinamento OD\', afinamentoOe \'Afinamento OE\', ");
                sql.Append("adicaoNivelOd as \'Adição Nível OD\', adicaoNivelOe as \'Adicao Nível OE\' FROM Retinoscopia WHERE idConsulta = \'IDCONSULTA\' ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA);

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Retinoscopia(Classe RetinoscopiaRegra, Método PesquisarRetinoscopia)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
