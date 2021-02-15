using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace AcessoDados
{
    public class loginAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        DataTable dados = new DataTable();
        public bool Autenticar(string usuario, string senha)
        {

            string usuarioBanco = null, senhaBanco = null, statusBanco = null;
            try
            {
                dados.Rows.Clear();
                sql.Clear();
                sql.Append("SELECT loginusuario, senhausuario,statusUsuario FROM usuario where loginusuario = \'LOGIN\' and deletar = false");
                sql = sql.Replace("LOGIN", usuario);//.Replace("SENHA", senha);

                dados = acessoBanco.Pesquisar(sql.ToString());

                usuarioBanco = Convert.ToString(dados.Rows[0]["loginUsuario"]);
                senhaBanco = Convert.ToString(dados.Rows[0]["senhaUsuario"]);
                statusBanco = Convert.ToString(dados.Rows[0]["statusUsuario"]);

                if (usuario == usuarioBanco)
                {
                    if (senha == senhaBanco)
                    {
                        if (statusBanco == "Ativo")
                        {
                            MessageBox.Show("Bem vindo " + usuarioBanco, "Acesso Liberado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;//Usuario e senha digitados são identicos aos do banco. E o status do usuario está como ativo

                        }
                        else
                        {
                            MessageBox.Show("Olá " + usuarioBanco + ",\nO seu acesso ao sistema foi negado.Entre em contato com o administrador do " +
                                "sistema ou com seu superior para mais detalhes!", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta", "Informações Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario não encontrado", "Informações Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao logar(Classe loginAcesso, Método Autenticar)"
                    + "\n Erro: \n" + ex
                    , "Erro bde login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public DataTable RetornarDados(string usuario)
        {
            DataTable vazio = new DataTable();
            try
            {
                sql.Clear();
                sql.Append("select usuario.idUsuario,usuario.idNivel,usuario.loginUsuario,nivelAcesso.nomeNivel from usuario INNER JOIN  nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel ");
                sql.Append("and usuario.loginUsuario = \'USUARIO\'  and usuario.deletar = false");

                sql = sql.Replace("USUARIO", usuario);

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao retornar os dados do usuario(Classe loginAcesso, Método RetornarDados)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return vazio;
        }
        //public bool Autenticar(string usuario, string senha)
        //{

        //    string usuarioBanco = null, senhaBanco = null, statusBanco = null;
        //    try
        //    {
        //        ConexaoAcesso.Desconectar();
        //        ConexaoAcesso.Conectar();
        //        sql.Append("SELECT loginusuario, senhausuario,statusUsuario FROM usuario where loginusuario = @loginUsuario and deletar = false");
        //        comandoSql.Parameters.Add(new NpgsqlParameter("@loginUsuario", usuario));

        //        comandoSql.CommandText = sql.ToString();
        //        comandoSql.Connection = ConexaoAcesso.conn;
        //        var readerData = comandoSql.ExecuteReader();


        //        while (readerData.Read())
        //        {
        //            usuarioBanco = readerData["loginUsuario"].ToString();
        //            senhaBanco = readerData["senhaUsuario"].ToString();
        //            statusBanco = readerData["statusUsuario"].ToString();
        //            if (usuario == usuarioBanco)
        //            {
        //                if (senha == senhaBanco)
        //                {
        //                    if (statusBanco == "Ativo")
        //                    {
        //                        MessageBox.Show("Bem vindo " + usuarioBanco, "Acesso Liberado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        return true;//Usuario e senha digitados são identicos aos do banco. E o status do usuario está como ativo

        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Olá " + usuarioBanco + ",\nO seu acesso ao sistema foi negado.Entre em contato com o administrador do " +
        //                            "sistema ou com seu superior para mais detalhes!", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                        return false;
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Senha incorreta", "Informações Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    return false;
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Usuario não encontrado", "Informações Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                return false;
        //            }

        //        }
        //        ConexaoAcesso.Desconectar();
        //        MessageBox.Show("Usuario não encontrado", "Informações Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ocorreu um erro ao logar(Classe loginAcesso, Método Autenticar)"
        //            + "\n Erro: \n" + ex
        //            , "Erro bde login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    return false;
        //}

    }
}
