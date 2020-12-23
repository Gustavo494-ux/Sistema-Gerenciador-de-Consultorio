using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using System.Windows.Forms;

namespace RegraNegocio
{
    public class DeletarPacienteRegra
    {
        public bool excluirLogicamenteIdPaciente(string idUsuarioSistema,string idPaciente)
        {
			try
			{
				if (Convert.ToInt32(idPaciente) >0)
				{
					DeletarPacienteAcesso deletarPaciente = new DeletarPacienteAcesso();
					return deletarPaciente.exclusaoLogicaIdPaciente(idUsuarioSistema,idPaciente);
				}
			}
			catch (Exception)
			{
                MessageBox.Show("Ocorreu um erro ao deletar o paciente(Classe DeletarPacienteRegra, Método DeletarPaciente","Erro de Exclusão",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			return false;
		}
		public bool excluirLogicamenteIdUsuario(string idUsuarioSistema,string idUsuarioCadastro)
		{
			try
			{
				if (Convert.ToInt32(idUsuarioCadastro) > 0)
				{
					DeletarPacienteAcesso deletarPaciente = new DeletarPacienteAcesso();
					return deletarPaciente.exclusaoLogicaIdUsuario(idUsuarioSistema,idUsuarioCadastro);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao deletar o paciente(Classe DeletarPacienteRegra, Método idUsuario", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
	}
}
