using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class loginRegra
    {
        string senhaEncriptada;
        public bool Autenticar(string usuario, string senha)
        {
            try
            {
                if (Verificar(usuario, senha) == true)
                {
                    loginAcesso logar = new loginAcesso();
                    if (logar.Autenticar(usuario, senhaEncriptada) == true) return true;
                    else return false;
                }
                else
                {
                    MessageBox.Show("Usuario ou senha é pequeno ou grande demais","Dados Inválidos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro("+ex.Message+") ao logar(Classe loginRegra, Método Auntenticar)","Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool Verificar(string usuario, string senha)
        {
            string conteudo = "Informações muito longas ou muito curtas", titulo = "Informações inválidas";
            try
            {
                if (usuario.Length> 20) return false;
                if (senha.Length > 5)
                {
                    Criptografar encriptar = new Criptografar();
                    senhaEncriptada = encriptar.EncriptarSenha(senha);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro("+ex.Message+") ao logar(Classe loginRegra, Método Verificar)","Erro de login");
            }
            return false;
        }
        public  DataTable RetornarDados(string usuario, string senha)
        {
            DataTable dadosRegra = new DataTable();
            DataTable vazio = new DataTable();
            try
            {
                loginAcesso retornar = new loginAcesso();
                dadosRegra = retornar.RetornarDados(usuario);
                if (dadosRegra.Rows.Count > 0) return dadosRegra; return vazio;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro("+ex.Message+") ao retornar os dados do usuario(Classe loginRegra, Método RetornarDados)","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return vazio;
        }
    }
}
