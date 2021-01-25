using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using AcessoDados;

namespace RegraNegocio
{
    public class CeratometriaRegra
    {
        CeratometriaAcesso ceratometria = new CeratometriaAcesso();

        public bool CadastrarCeratometria(string IDCONSULTA, string OD, string OE, string TIPOCERATOMETRO, string OBSERVACAOCERATOMETRIA)
        {
            try
            {
                if(ValidarCeratometria(IDCONSULTA,OD,OE,TIPOCERATOMETRO,OBSERVACAOCERATOMETRIA))
                {
                    return ceratometria.CadastrarCeratometria(IDCONSULTA, OD, OE, TIPOCERATOMETRO, OBSERVACAOCERATOMETRIA);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Ceratometria(Classe CeratometriaRegra, Método CadastrarCeratometria)", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool AtualizarCeratometria(string IDCONSULTA, string OD, string OE, string TIPOCERATOMETRO, string OBSERVACAOCERATOMETRIA)
        {
            try
            {
                if (ValidarCeratometria(IDCONSULTA, OD, OE, TIPOCERATOMETRO, OBSERVACAOCERATOMETRIA))
                {
                    return ceratometria.AtualizarCeratometria(IDCONSULTA, OD, OE, TIPOCERATOMETRO, OBSERVACAOCERATOMETRIA);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Ceratometria(Classe CeratometriaRegra, Método AtualizarCeratometria)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool ValidarCeratometria(string IDCONSULTA, string OD, string OE, string TIPOCERATOMETRO, string OBSERVACAOCERATOMETRIA)
        {
            try
            {
                if (Convert.ToInt32(IDCONSULTA) < 1) return false;
                if (OD.Length > 100) return false;
                if (OE.Length > 100) return false;
                if (TIPOCERATOMETRO.Length > 100) return false;
                if (OBSERVACAOCERATOMETRIA.GetType() != typeof(string)) return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar a Ceratometria(Classe CeratometriaRegra, Método ValidarCeratometria)", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        public DataTable PesquisarCeratometria(string IDCONSULTA)
        {
            try
            {
                return ceratometria.PesquisarCeratometria(IDCONSULTA);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Ceratometria(Formulario frmCadastrarConsulta, Método PesquisarCeratometria)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
