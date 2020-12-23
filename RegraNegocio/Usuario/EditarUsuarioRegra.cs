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
    public class EditarUsuarioRegra
    {
        public DataTable RetornarDados(string idusuario)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            EditarUsuarioAcesso editar = new EditarUsuarioAcesso();

			try
			{
                if (Convert.ToInt32(idusuario)>0)
                {
                    dadosTabela = editar.retornarDados(Convert.ToInt32(idusuario));
                    if (dadosTabela.Rows.Count >0) return dadosTabela;
                }
			}
			catch (Exception)
			{
                MessageBox.Show("Ocorreu um erro ao retornar os dados a serem editados(Classe EditarUsuarioRegra, Método RetornarDados)","Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
            return tableVazia;
        }
        public bool Atualizar(int idUsuario,int idNivel, string nomeUsuario, string loginUsuario, string senhaUsuario, string confirmacaoSenha, string observacaoUsuario, string statusUsuario)
        {
            try
            {
                CadastrarUsuarioRegra verificar = new CadastrarUsuarioRegra();
                EditarUsuarioAcesso editar = new EditarUsuarioAcesso();
                Criptografar encriptar = new Criptografar();
                string senhaEncriptada;
                if (idUsuario > 0)
                {
                    if (verificar.verificar(Convert.ToString(idNivel), nomeUsuario, loginUsuario, senhaUsuario, confirmacaoSenha, observacaoUsuario, statusUsuario) == true)
                    {
                        /*Se o tamanho da senha for igual a 128 caracteres a mesma já esta criptografada e não é necessario ela passar pela criptografia novamente*/
                        if (senhaUsuario.Length == 128)
                        {
                           bool confirm= editar.Atualizar(idUsuario, nomeUsuario, loginUsuario, senhaUsuario, idNivel, statusUsuario, observacaoUsuario);
                            return confirm;
                            
                        }
                        else
                        {
                            senhaEncriptada = encriptar.EncriptarSenha(senhaUsuario);
                            bool confirm = editar.Atualizar(idUsuario, nomeUsuario, loginUsuario, senhaEncriptada, idNivel, statusUsuario, observacaoUsuario);
                            return confirm;
                        }
                    }

                }
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os dados do usuario(Classe EditarUsuarioRegra, Método Atualizar)","Erro de atualização",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
