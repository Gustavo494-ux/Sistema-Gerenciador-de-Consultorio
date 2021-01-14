using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace AcessoDados
{
    public class EstereopsiaAcesso
    {
        Banco acessoBanco = new Banco();
        StringBuilder sql = new StringBuilder();

        public bool CadastrarEstereopsia(string IDCONSULTA,string TESTE,string RESULTADO)
        {
            try
            {
                sql.Clear();
                sql.Append("INSERT INTO Estereopsia(idConsulta,teste,resultado) VALUES(IDCONSULTA,TESTE,RESULTADO)");

                sql = sql.Replace("IDCOSULTA", IDCONSULTA).Replace("TESTE", TESTE).Replace("RESULTATO", RESULTADO);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Estereopsia(Classe EstereopsiaAcesso, Método CadastrarEstereopsia)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool AtualizarEstereopsia(string IDCONSULTA, string TESTE, string RESULTADO)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE Estereopsia SET teste = \'Teste\',resultado = \'Resultado\' WHERE idConsulta = \'IDCONSULTA\' ");

                sql = sql.Replace("IDCOSULTA", IDCONSULTA).Replace("TESTE", TESTE).Replace("RESULTATO", RESULTADO);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Estereopsia(Classe EstereopsiaAcesso, Método AtualizarEstereopsia)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable PequisarEstereopsia(string IDCONSULTA)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT idConsulta as \'Código Consulta\',teste as \'Teste\',resultado as \'Resultado\' WHERE idConsula = \'IDCONSULTA\' "); ;

                sql = sql.Replace("IDCONSULTA", IDCONSULTA);

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Estereopsia(Classe EstereopsiaAcesso, Método PesquisarEstereopsia)", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

    }
}
