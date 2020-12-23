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
    public class EditarAgendamentoRegra
    {
        public bool AtualizarAgendamentos(string idAgendamento, string idStatus, string dataConsulta, string observacao)
        {
            try
            {
                if (Convert.ToInt32(idAgendamento)>0 && Convert.ToInt32(idStatus) >0 && observacao.GetType() == typeof(string))
                {
                    if (Convert.ToDateTime(dataConsulta) == Convert.ToDateTime(DateTime.Now.ToShortDateString()) || Convert.ToDateTime(dataConsulta) > Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                    {
                        EditarAgendamentoAcesso editar = new EditarAgendamentoAcesso();
                        if (editar.AtualizarAgendamentos(Convert.ToInt32(idAgendamento), Convert.ToInt32(idStatus), Convert.ToDateTime(dataConsulta), observacao) == true) return true; return false;  
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os dados do agendamento(Classe EditarAgendamentoRegra, Método AtualizarAgendamentos)",
                    "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
    }
}
