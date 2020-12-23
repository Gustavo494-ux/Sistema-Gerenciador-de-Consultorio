using AcessoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegraNegocio
{
    public class DeletarConsultaRegra
    {
		public bool DeletarConsultaIdPaciente(string idUsuarioSistema,string idPaciente)
		{
			try
			{
				if (Convert.ToInt32(idPaciente) > 0)
				{
					DeletarConsultaAcesso deletar = new DeletarConsultaAcesso();
					return deletar.DeletarConsultaIdPaciente(idUsuarioSistema,idPaciente);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe DeletarConsultaRegra, Método DeletarConsultaIdPaciente", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
		public bool DeletarConsultaIdConsulta(string idUsuarioSistema,string idConsulta)
		{
			try
			{
				if (Convert.ToInt32(idConsulta) > 0)
				{
					DeletarConsultaAcesso deletar = new DeletarConsultaAcesso();
					return deletar.DeletarConsultaidConsulta(idUsuarioSistema,idConsulta);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe DeletarConsultaRegra, Método DeletarConsultaIdConsulta", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
		public bool DeletarConsultaIdProfissional(string idUsuarioSistema,string idProfissional)
		{
			try
			{
				if (Convert.ToInt32(idProfissional) > 0)
				{
					DeletarConsultaAcesso deletar = new DeletarConsultaAcesso();
					return deletar.DeletarConsultaIdProfissional(idUsuarioSistema, idProfissional);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe DeletarConsultaRegra, Método DeletarConsultaIdProfissional", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}

		public bool DeletarConsultaIdUsuario(string idUsuarioSistema,string idUsuario)
		{
			try
			{
				if (Convert.ToInt32(idUsuario) > 0)
				{
					DeletarConsultaAcesso deletar = new DeletarConsultaAcesso();
					return deletar.DeletarConsultaIdUsuario(idUsuarioSistema,idUsuario);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe DeletarConsultaRegra, Método DeletarConsultaIdUsuario", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
	}
}
