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
    public class VisaoCorRegra
    {
        VisaoCorAcesso visaoCor = new VisaoCorAcesso();

        public bool CadastrarVisaoCor(string IDCONSULTA, string TESTE, string OD, string OE, string INTERPRETACAO)
        {
            try
            {
                if (ValidarVisaoCor(IDCONSULTA,TESTE,OD,OE,INTERPRETACAO))
                {
                    return visaoCor.CadastrarVisaoCor(IDCONSULTA, TESTE, OD, OE, INTERPRETACAO);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Visão de Cor(Classse VisaoCorRegra,Método CadastrarVisaoCor)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool AtualizarVisaoCor(string IDCONSULTA, string TESTE, string OD, string OE, string INTERPRETACAO)
        {
            try
            {
                if (ValidarVisaoCor(IDCONSULTA, TESTE, OD, OE, INTERPRETACAO))
                {
                    return visaoCor.AtualizarVisaoCor(IDCONSULTA, TESTE, OD, OE, INTERPRETACAO);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Visão de Cor(Classse VisaoCorRegra,Método AtualizarVisaoCor)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool ValidarVisaoCor(string IDCONSULTA, string TESTE, string OD, string OE, string INTERPRETACAO)
        {
            try
            {
                if (Convert.ToInt32(IDCONSULTA) > 0) return false;
                if (TESTE.Length > 100) return false;
                if (OD.Length > 100) return false;
                if (OE.Length > 100) return false;
                if (INTERPRETACAO.GetType() != typeof(string)) return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao Cadastrar a Visão de Cor(Classe VisaoCorRegra, Método ValidarVisaoCor)", "Erro de Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        public DataTable PesquisarVisaoCor(string IDCONSULTA)
        {
            try
            {
                return visaoCor.PesquisarVisaoCor(IDCONSULTA);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Visão de Cor(Classe VisaoCorRegra, Método PesquisarVisaoCor)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
