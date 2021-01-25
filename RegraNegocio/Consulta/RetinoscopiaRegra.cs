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
    public class RetinoscopiaRegra
    {
        RetinoscopiaAcesso retinoscopia = new RetinoscopiaAcesso();

        public bool CadastrarRetinoscopia(string IDCONSULTA, string ESTATICAOD, string ESTATICAOE, string DINAMICAOD, string DINAMICAOE, string SUBJETIVOOD, string SUBJETIVOOE,
            string AFINAMENTOOD, string AFINAMENTOOE, string ADICAONIVELOD, string ADICAONIVELOE)
        {
            try
            {
                if(ValidarRetinoscopia(IDCONSULTA,ESTATICAOD,ESTATICAOE,DINAMICAOD,DINAMICAOE,SUBJETIVOOD,SUBJETIVOOE,AFINAMENTOOD,AFINAMENTOOE,ADICAONIVELOD,ADICAONIVELOE))
                {
                    return retinoscopia.CadastrarRetinoscopia(IDCONSULTA, ESTATICAOD, ESTATICAOE, DINAMICAOD, DINAMICAOE, SUBJETIVOOD, SUBJETIVOOE, AFINAMENTOOD,
                        AFINAMENTOOE, ADICAONIVELOD, ADICAONIVELOE);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Retinoscopia(Classe RetinoscopiaRegra, Método CadastrarRetinoscopia)", "Erro de Cadastro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return false;
        }
        public bool AtualizarRetinoscopia(string IDCONSULTA, string ESTATICAOD, string ESTATICAOE, string DINAMICAOD, string DINAMICAOE, string SUBJETIVOOD, string SUBJETIVOOE,
           string AFINAMENTOOD, string AFINAMENTOOE, string ADICAONIVELOD, string ADICAONIVELOE)
        {
            try
            {
                if (ValidarRetinoscopia(IDCONSULTA, ESTATICAOD, ESTATICAOE, DINAMICAOD, DINAMICAOE, SUBJETIVOOD, SUBJETIVOOE, AFINAMENTOOD, AFINAMENTOOE, ADICAONIVELOD, ADICAONIVELOE))
                {
                    return retinoscopia.AtualizarRetinoscopia(IDCONSULTA, ESTATICAOD, ESTATICAOE, DINAMICAOD, DINAMICAOE, SUBJETIVOOD, SUBJETIVOOE, AFINAMENTOOD,
                        AFINAMENTOOE, ADICAONIVELOD, ADICAONIVELOE);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Retinoscopia(Classe RetinoscopiaRegra, Método AtualizarRetinoscopia)", "Erro de Atualização", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return false;
        }
        public bool ValidarRetinoscopia(string IDCONSULTA, string ESTATICAOD, string ESTATICAOE, string DINAMICAOD, string DINAMICAOE, string SUBJETIVOOD, string SUBJETIVOOE,
            string AFINAMENTOOD, string AFINAMENTOOE, string ADICAONIVELOD, string ADICAONIVELOE)
        {
            try
            {
                if (Convert.ToInt32(IDCONSULTA) <1) return false;

                if (ESTATICAOD.Length > 100) return false;
                if (ESTATICAOE.Length > 100) return false;

                if (DINAMICAOD.Length > 100) return false; 
                if (DINAMICAOE.Length > 100) return false;

                if (SUBJETIVOOD.Length > 100) return false;
                if (SUBJETIVOOE.Length > 100) return false;

                if (AFINAMENTOOD.Length > 100) return false;
                if (AFINAMENTOOE.Length > 100) return false;

                if (ADICAONIVELOD.Length > 100) return false;
                if (ADICAONIVELOE.Length > 100) return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar a Retinoscopia(Classe RetinoscopiaRegra, Método ValidarRetinoscopia)", "Erro de Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        public DataTable PesquisarRetinoscopia(string IDCONSULTA)
        {
            try
            {
                return retinoscopia.PesquisarRetinoscopia(IDCONSULTA);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Retinoscopia(Classe RetinoscopiaRegra, Método PesquisarRetinoscopia", "Erro de Pesquisa",
                    MessageBoxButtons.OK);
            }
            return null;
        }
    }
}
