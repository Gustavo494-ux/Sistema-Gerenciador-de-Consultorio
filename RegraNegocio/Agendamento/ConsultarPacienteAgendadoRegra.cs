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
    public class ConsultarPacienteAgendadoRegra
    {
        public bool ConsultarPacienteAgendado(string id)
        {
			try
			{
				ConsultarPacienteAgendadoAcesso consultar = new ConsultarPacienteAgendadoAcesso();
				
				if (Convert.ToInt32(id)>0)
				{
					if (consultar.ConsultarPacienteAgendado(Convert.ToInt32(id)) == true) return true;return false;
				}
				return false;
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao consultar um paciente agendado(Classe ConsultarPacienteAgendadoRegra, Método ConsultarPacienteAgendado)", "Erro",
					   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return false;
        }
		public bool FinalizarConsultaAgendada(int id)
		{
			try
			{
				ConsultarPacienteAgendadoAcesso finalizar = new ConsultarPacienteAgendadoAcesso();
				if (Convert.ToInt32(id)>0)
				{
					if (finalizar.FinalizarConsultaAgendada(id))return true; return false;
				}
				else
				{
					return false;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao finalizar uma consulta de um paciente agendado(Classe ConsultarPacienteAgendadoRegra, Método FinalizarConsultaAgendada)", "Erro",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return false;
		}
	}
}
