using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados
{
    public class ConsultaAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool Cadastrar(string IDPACIENTE, string IDPROFISSIONAL, string IDUSUARIO, string ORIGEM, string HOBBIES, string ENCAMINHADOPOR, string AJUDAOPTICAPRESCRITA, string DATAULTIMOEXAME,
            string TRANSCRICAOLENTES, string OBSERVACAORECEITA, string STATUSCONSULTA,
            string OBSERVACAOCONSULTA)
        {
            try
            {
               string DATACONSULTA, HORACONSULTA;
                DATACONSULTA =  DateTime.Now.ToShortDateString();
                HORACONSULTA =  DateTime.Now.ToLongTimeString();

                //Comando sql responsavel por inserir os dados
                sql.Append("INSERT INTO consulta(idPaciente,idProfissional,idUsuario,origem,hobbies,encaminhadoPor,ajudaOpticaPrescrita,dataUltimoExame,transcricaoLentes, ");
                sql.Append("observacaoReceita,dataConsulta,horaConsulta,statusConsulta,observacaoConsulta,deletar)");

                sql.Append("VALUES(\'IDPACIENTE\',\'IDPROFISSIONAL\',\'IDUSUARIO\',\'ORIGEM\',\'HOBBIES\',\'ENCAMINHADOPOR\',\'AJUDAOPTICAPRESCRITA\',\'DATAULTIMOEXAME\',\'TRANSCRICAOLENTES\',\'OBSERVACAORECEITA\', ");
                sql.Append("\'DATACONSULTA\',\'HORACONSULTA\',\'STATUSCONSULTA\',\'OBSERVACAOCONSULTA\',false) ");

                //Relaciona cada valor com seu respectivo parametro.
                sql = sql.Replace("IDPACIENTE", IDPACIENTE).Replace("IDPROFISSIONAL", IDPROFISSIONAL).Replace("IDUSUARIO", IDUSUARIO).Replace("ORIGEM", ORIGEM);
                sql = sql.Replace("HOBBIES", HOBBIES).Replace("ENCAMINHADOPOR", ENCAMINHADOPOR).Replace("AJUDAOPTICAPRESCRITA", AJUDAOPTICAPRESCRITA);
                sql = sql.Replace("DATAULTIMOEXAME", DATAULTIMOEXAME).Replace("TRANSCRICAOLENTES", TRANSCRICAOLENTES).Replace("OBSERVACAORECEITA", OBSERVACAORECEITA);
                sql = sql.Replace("DATACONSULTA", DATACONSULTA).Replace("HORACONSULTA", HORACONSULTA).Replace("STATUSCONSULTA", STATUSCONSULTA).Replace("OBSERVACAOCONSULTA", OBSERVACAOCONSULTA);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar inserir os dados da consulta. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
