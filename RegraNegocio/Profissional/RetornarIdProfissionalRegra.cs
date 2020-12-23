using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class RetornarIdProfissionalRegra
    {
        public int idUsuario(string idUsuario)
        {
            try
            {
                RetornarIdProfissionalAcesso retornarAcesso = new RetornarIdProfissionalAcesso();
                if (Convert.ToInt32(idUsuario)>0)
                {
                    int id = retornarAcesso.idUsuario(Convert.ToInt32(idUsuario));
                    if (id >0)
                    {
                        return id;
                    }
                    else
                    {
                       //MessageBox.Show("Você não tem autorização para efetuar o cadastro de uma consulta pois não foi encontrado seu cadastro profissional no sistema","Cadastro Negado",
                       //     MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Não foi possivel procurar pelo idProfissional pois o idUsuario fornecido é inválido","Dados Inválidos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo idprofissional(Classe RetornarIdProfissional, Método idUsuario)",
                    "Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return 0;
        }
    }
}
