using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class DeletarProfissionalRegra
    {
        public bool idProfissional(string idUsuarioSistema,string idProfissional)
        {
			try
			{
                if (Convert.ToInt32(idProfissional)>0)
                {
                    DeletarProfissionalAcesso deletar = new DeletarProfissionalAcesso();
                   return deletar.idProfissional(Convert.ToInt32(idUsuarioSistema),Convert.ToInt32(idProfissional)); 
                }
			}
			catch (Exception)
			{
                MessageBox.Show("Ocorreu um erro ao deletar o profissional(classe DeletarProfissionalRegra, Método idProfissional)", "Erro de Exclusão",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
            return false;
        }
        public bool idUsuario(string idUsuarioSistema, string idUsuario)
        {
            try
            {
                if (Convert.ToInt32(idUsuario) > 0)
                {
                    DeletarProfissionalAcesso deletar = new DeletarProfissionalAcesso();
                    return deletar.idUsuario(Convert.ToInt32(idUsuarioSistema),Convert.ToInt32(idUsuario));
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o profissional(classe DeletarProfissionalRegra, Método idUsuario)", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


    }
}
