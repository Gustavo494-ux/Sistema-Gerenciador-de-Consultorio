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
    public class AmslerRegra
    {
        AmslerAcesso amsler = new AmslerAcesso();

        public bool CadastrarAmsler(string IDCONSULTA, string OD, string OE)
        {
            try
            {
                if (ValidarAmsler(IDCONSULTA, OD, OE))
                {
                    return amsler.CadastrarAmsler(IDCONSULTA, OD, OE);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Amsler(Classe AmslerRegra, Método CadastrarAmsler)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool AtualizarAmsler(string IDCONSULTA, string OD, string OE)
        {
            try
            {
                if (ValidarAmsler(IDCONSULTA, OD, OE))
                {
                    return amsler.AtualizarAmsler(IDCONSULTA, OD, OE);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Amsler(Classe AmslerRegra, Método AtualizarAmsler)", "Erro de Atualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool ValidarAmsler(string IDCONSULTA, string OD, string OE)
        {
            try
            {
                if (Convert.ToInt32(IDCONSULTA) > 0) return false;
                if (OD.Length > 100) return false;
                if (OE.Length > 100) return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar a Amsler(Classe AmslerRegra,Método ValidarAmsler)", "Erro de Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        public DataTable PesquisarAmsler(string IDCONSULTA, string OD, string OE)
        {
            try
            {
                return amsler.PesquisarAmsler(IDCONSULTA);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar Amsler(Classe AmslerRegra,Método PesquisarAmsler)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
