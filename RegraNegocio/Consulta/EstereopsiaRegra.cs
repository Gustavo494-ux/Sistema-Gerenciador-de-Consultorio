using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class EstereopsiaRegra
    {
        EstereopsiaAcesso estereopsia = new EstereopsiaAcesso();
        
        public bool CadastrarEstereopsia(string IDCONSULTA, string TESTE, string RESULTADO)
        {
            try
            {
                if (ValidarEstereopsia(IDCONSULTA, TESTE, RESULTADO))
                {
                    return estereopsia.CadastrarEstereopsia(IDCONSULTA, TESTE, RESULTADO);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Estereopsia(Classe EstereopsiaRegra, Método CadastrarEstereopsia)", "Erro Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool AtualizarEstereopsia(string IDCONSULTA, string TESTE, string RESULTADO)
        {
            try
            {
                if (ValidarEstereopsia(IDCONSULTA, TESTE, RESULTADO))
                {
                    return estereopsia.AtualizarEstereopsia(IDCONSULTA, TESTE, RESULTADO);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Estereopsia(Classe EstereopsiaRegra, Método AtualizarEstereopsia)", "Erro Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool ValidarEstereopsia(string IDCONSULTA, string TESTE, string RESULTADO)
        {
            try
            {
                if (Convert.ToInt32(IDCONSULTA) <1) return false;
                if (TESTE.Length > 100) return false;
                if (RESULTADO.Length > 200) return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar a Estereopsia(Classe EstereopsiaRegra,Método ValidarEstereopsia)", "Erro de Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        public DataTable PesquisarEstereopsia(string IDCONSULTA)
        {
            try
            {
                return estereopsia.PequisarEstereopsia(IDCONSULTA);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar Estereopsia(Classe EstereopsiaRegra, Método PesquisarEstereopsia)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
