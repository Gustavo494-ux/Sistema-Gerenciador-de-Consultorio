using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AcessoDados
{
    public class VisaoCorAcesso
    {
        Banco acessoBanco = new Banco();
        StringBuilder sql = new StringBuilder();

        public bool CadastrarVisaoCor(string IDCONSULTA,string TESTE,string OD, string OE,string INTERPRETACAO)
        {
            try
            {
                sql.Clear();
                sql.Append("INSERT INTO VisaoCor(idConsulta,teste,Od,Oe,Interpretacao) VALUES(IDCONSULTA,TESTE,OD,OE,INTERPRETACAO) ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("TESTE", TESTE).Replace("OD", OD).Replace("OE", OE).Replace("INTERPRETACAO", INTERPRETACAO);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Visão de Cor(Classe CadastrarVisaoCor, Método CadastrarVisaoCor)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool AtualizarVisaoCor(string IDCONSULTA, string TESTE, string OD, string OE, string INTERPRETACAO)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE VisaoCor SET teste =\'TESTE\',od=\'OD\',oe=\'OE\' WHERE idConsulta =\'IDCONSULTA\' ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("TESTE", TESTE).Replace("OD", OD).Replace("OE", OE).Replace("INTERPRETACAO", INTERPRETACAO);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Visão de Cor(Classe VisaoCorAcesso, Método AtualizarVisaoCor)", "Erro de Atualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable PesquisarVisaoCor(string IDCONSULTA)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT idConsulta as \'Código Consulta\',teste as \'Teste\',od as \'OD\',oe as \'OE\', interpretacao as \'Interpretação\' FROM visaoCor ");
                sql.Append("WHERE idConsulta = \'IDCONSULTA\' ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Visão de Cor(Classe visaoCorAcesso,Método PesquisarVisaoCor)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
