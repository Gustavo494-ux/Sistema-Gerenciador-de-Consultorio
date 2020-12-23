using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using AcessoDados;
namespace RegraNegocio
{
   public  class ConsultaRegraNegocio
   {
        public bool Cadastrar(string idPaciente,string idProfissional,string idUsuario,string origem,string hobbies,string encaminhadoPor,string ajudaOpticaPrescrita,
            DateTime dataUltimoExame, string transcricaoLentes,string observacaoReceita,string statusConsulta, string observacaoConsulta)
        {
            try
            {
                if (Validar(Convert.ToInt32(idPaciente),Convert.ToInt32(idProfissional),Convert.ToInt32(idUsuario),origem,hobbies,encaminhadoPor,ajudaOpticaPrescrita,
                    dataUltimoExame,  transcricaoLentes,  observacaoReceita, statusConsulta,  observacaoConsulta) == true)
                {
                    ConsultaAcesso novaConsulta = new ConsultaAcesso();
                    //if (origem.Length == 0) origem = "Não informado";
                    //if (hobbies.Length == 0) hobbies = "Não informado";
                    //if (encaminhadoPor.Length == 0) encaminhadoPor = "Não informado";
                    //if (ajudaOpticaPrescrita.Length == 0) ajudaOpticaPrescrita = "Não informado";
                    //if (transcricaoLentes.Length == 0) transcricaoLentes = "Não informado";
                    //if (observacaoReceita.Length == 0) observacaoReceita = "Não informado";
                    if (statusConsulta.Length == 0) statusConsulta = "Consulta Finalizada";
                    //if (observacaoConsulta.Length == 0) observacaoConsulta = "Não informado";

                    return novaConsulta.Cadastrar(idPaciente, idProfissional, idUsuario, origem, hobbies, encaminhadoPor,
                        ajudaOpticaPrescrita, Convert.ToString(dataUltimoExame), transcricaoLentes, observacaoReceita, statusConsulta, observacaoConsulta);

                    
                }
                else
                {
                    MessageBox.Show("Algumas informações da consulta são inválidas,Tente novamente com informações diferentes, Caso o problema persista entre em contato com o suporte!",
                        "Informações inválidas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no método de cadastro das informações da consulta(Classe Consulta, método Cadastrar). Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool Validar(int idPaciente, int idProfissional, int idUsuario,string origem, string hobbies, string encaminhadoPor, string ajudaOpticaPrescrita,
            DateTime dataUltimoExame,string transcricaoLentes,string observacaoReceita, string statusConsulta,string observacaoConsulta)
        { 
            /*Método responsável por efetuar as validações de dados antes de seguirem para o banco de dados.*/
            try
            {
                //Códigos Identificadores
                if (idPaciente <= 0) return false;

                if (idProfissional == 0) return false;

                if (Convert.ToInt32(idUsuario) <= 0) return false;

                //Demais campos
                if(origem.GetType() != typeof(string))return false;

                if(hobbies.GetType() != typeof(string)) return false;

                if(encaminhadoPor.GetType() != typeof(string)) return false;

                if(ajudaOpticaPrescrita.GetType() != typeof(string)) return false;

                if (dataUltimoExame.Date > Convert.ToDateTime(DateTime.Now.ToShortDateString())) return false;

                if (transcricaoLentes.GetType() != typeof(string)) return false;

                if (observacaoReceita.GetType() != typeof(string)) return false;

                if (statusConsulta.GetType() != typeof(string)) return false;

                if (observacaoConsulta.GetType() != typeof(string)) return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no método de validação das informações de cadastro da Consulta. Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
   }
}
