using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class DeletarUsuarioRegra
    {
        public bool Deletar(string idUsuarioSistema ,string idUsuario)
        {
			try
			{
                DeletarUsuarioAcesso delUsuario = new DeletarUsuarioAcesso();
                if (Convert.ToInt32(idUsuario)>0)
                {
                    return delUsuario.DeletarUsuario(Convert.ToInt32(idUsuarioSistema),Convert.ToInt32(idUsuario));
                }
			}
			catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o usuario(Classe DeletarUsuarioAcesso,Método Deletar)","Erro ao excluir dados",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
            return false;
        }
    }
}
