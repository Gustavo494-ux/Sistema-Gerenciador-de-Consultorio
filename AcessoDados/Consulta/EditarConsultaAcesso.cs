using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace AcessoDados
{
    public class EditarConsultaAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool Atualizar(string IDCONSULTA,string ORIGEM, string HOBBIES, string ENCAMINHADOPOR, string AJUDAOPTICAPRESCRITA, string DATAULTIMOEXAME,
            string TRANSCRICAOLENTES, string OBSERVACAORECEITA, string STATUSCONSULTA,
            string OBSERVACAOCONSULTA)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE consulta SET origem = \'ORIGEM\',hobbies = \'HOBBIES\',encaminhadoPOr= \'ENCAMINHADOPOR\',ajudaOpticaPrescrita= \'AJUDAOPTICAPRESCRITA\', ");
                sql.Append("dataUltimoExame= \'DATAULTIMOEXAME\', transcricaoLentes = \'TRANSCRICAOLENTES\', observacaoReceita = \'OBSERVACAORECEITA\', ");
                sql.Append("statusConsulta=\'STATUSCONSULTA\',observacaoConsulta = \'OBSERVACAOCONSULTA\' WHERE idConsulta = \'IDCONSULTA\'");

                //Relaciona cada valor com seu respectivo parametro.
                sql = sql.Replace("ORIGEM", ORIGEM).Replace("HOBBIES", HOBBIES).Replace("ENCAMINHADOPOR", ENCAMINHADOPOR).Replace("AJUDAOPTICAPRESCRITA", AJUDAOPTICAPRESCRITA);
                sql = sql.Replace("DATAULTIMOEXAME", DATAULTIMOEXAME).Replace("TRANSCRICAOLENTES", TRANSCRICAOLENTES).Replace("OBSERVACAORECEITA", OBSERVACAORECEITA);
                sql = sql.Replace("STATUSCONSULTA", STATUSCONSULTA).Replace("OBSERVACAOCONSULTA", OBSERVACAOCONSULTA).Replace("IDCONSULTA", IDCONSULTA);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar uma consulta(Classe EditarConsultaAcesso, Método Atualizar)","Erro de Atualização",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
