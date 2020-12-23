using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using System.Windows.Forms;

namespace RegraNegocio
{
    public class EditarConsultaRegra
    {
        public bool Atualizar(string idConsulta, string origem, string hobbies, string encaminhadoPOr, string ajudaOpticaPrescrita, DateTime dataUltimoExame,
            string transcricaoLentes,string observacaoReceita,string statusConsulta, string observacaoConsulta)
        {
            try
            {
                if (Convert.ToInt32(idConsulta)>0)
                {
                    EditarConsultaAcesso editar = new EditarConsultaAcesso();
                   bool confirm= editar.Atualizar(idConsulta,origem,hobbies,encaminhadoPOr,ajudaOpticaPrescrita, Convert.ToString(dataUltimoExame),transcricaoLentes,
                       observacaoReceita,statusConsulta,observacaoConsulta);
                    return confirm;
                }
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar uma consulta(Classe EditarConsultaRegra, Método Atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
