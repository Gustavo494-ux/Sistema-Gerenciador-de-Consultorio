using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace AcessoDados
{
    public class AmslerAcesso
    {
        Banco acessoBanco = new Banco();
        StringBuilder sql = new StringBuilder();

        public bool CadastrarAmsler(string IDCONSULTA,string OD,string OE)
        {
            try
            {
                sql.Clear();
                sql.Append("INSERT INTO Amsler(idConsulta,Od,Oe) VALUES(\'IDCONSULTA\',\'OD\',\'OE\')");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("OD", OD).Replace("OE", OE);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Amsler(Classe AmslerAcesso, Método CadastrarAmsler)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool AtualizarAmsler(string IDCONSULTA, string OD, string OE)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE Amsler SET od = \'OD\',oe=\'OE\' WHERE idConsulta =\'IDCONSULTA\'");
                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("OD", OD).Replace("OE", OE);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Amsler(Classe AmslerAcesso,Método AtualizarAmsler)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable PesquisarAmsler(string IDCONSULTA)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT idConsulta as \"Código Consulta\",od as \"OD\",oe as \"OE\" FROM amsler WHERE idConsulta = \'IDCONSULTA\' ");
                sql = sql.Replace("IDCONSULTA", IDCONSULTA);

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Amsler(Classe AmslerAcesso,Método PesquisarAmsler)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
