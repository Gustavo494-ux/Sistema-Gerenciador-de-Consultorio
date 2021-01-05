using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using AcessoDados;
namespace RegraNegocio
{
   public  class ConsultaRegra
   {
        DataTable tableVazia = new DataTable();
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
                MessageBox.Show("Erro no método de cadastro das informações da consulta(Classe ConsultaRegraNegocio, método Cadastrar). Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
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
                MessageBox.Show("Erro no método de validação das informações de cadastro da Consulta. Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!",
                    "Erro na validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        public bool Atualizar(string idConsulta, string origem, string hobbies, string encaminhadoPOr, string ajudaOpticaPrescrita, DateTime dataUltimoExame,
            string transcricaoLentes, string observacaoReceita, string statusConsulta, string observacaoConsulta)
        {
            try
            {
                if (Convert.ToInt32(idConsulta) > 0)
                {
                    ConsultaAcesso editar = new ConsultaAcesso();
                    bool confirm = editar.Atualizar(idConsulta, origem, hobbies, encaminhadoPOr, ajudaOpticaPrescrita, Convert.ToString(dataUltimoExame), transcricaoLentes,
                        observacaoReceita, statusConsulta, observacaoConsulta);
                    return confirm;
                }
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar uma consulta(Classe ConsultaRegraNegocio, Método Atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        //Funções para pesquisas de consulta com diferentes filtros.
        public DataTable PesquisarUltimoId()
        {
            try
            {
                ConsultaAcesso pesquisarConsulta = new ConsultaAcesso();
                return pesquisarConsulta.PesquisarUltimoId();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelas chaves Estrangeiras da consulta(Classe ConsultaRegraNegocio, Método PesquisarChavesEstrangeiras)",
                   "erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable TodasConsultas()
        {
            try
            {
                ConsultaAcesso localizarConsulta = new ConsultaAcesso();
                return localizarConsulta.TodasConsultas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultaRegraNegocio, Método TodasConsultas) do Consulta , " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomePaciente(string nome)
        {
            try
            {
                ConsultaAcesso localizarConsulta = new ConsultaAcesso();
                return localizarConsulta.NomePaciente(nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultaRegraNegocio, Método Nome) do Consulta ,Tente Novamente com uma informação diferente," +
                    " Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoConsulta(string CodigoConsulta)
        {
            try
            {
                ConsultaAcesso localizarConsulta = new ConsultaAcesso();
                return localizarConsulta.CodigoConsulta(CodigoConsulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultaRegraNegocio, Método CodigoConsulta) do Consulta ,Tente Novamente com uma informação diferente," +
                    " Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoPaciente(string CodigoPaciente)
        {
            try
            {
                ConsultaAcesso localizarConsulta = new ConsultaAcesso();
                return localizarConsulta.CodigoPaciente(CodigoPaciente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultaRegraNegocio, Método CodigoPaciente) do Consulta ,Tente Novamente com uma informação diferente," +
                    " Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable cpfPaciente(string cpfPaciente)
        {
            try
            {
                ConsultaAcesso localizarConsulta = new ConsultaAcesso();
               return localizarConsulta.cpfPaciente(cpfPaciente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultaRegraNegocio, Método cpfPaciente) do Consulta ,Tente Novamente com uma informação diferente," +
                    " Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable rgPaciente(string rgPaciente)
        {
            try
            {
               ConsultaAcesso localizarConsulta = new ConsultaAcesso();
                return localizarConsulta.rgPaciente(rgPaciente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ConsultaRegraNegocio, Método rgPaciente) do Consulta ,Tente Novamente com uma informação diferente," +
                    " Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

        //Funções para deletar lógicamente as consultas.
        public bool DeletarConsultaIdPaciente(string idUsuarioSistema, string idPaciente)
        {
            try
            {
                if (Convert.ToInt32(idPaciente) > 0)
                {
                    ConsultaAcesso deletar = new ConsultaAcesso();
                    return deletar.DeletarConsultaIdPaciente(idUsuarioSistema, idPaciente);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe ConsultaRegraNegocio, Método DeletarConsultaIdPaciente", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool DeletarConsultaIdConsulta(string idUsuarioSistema, string idConsulta)
        {
            try
            {
                if (Convert.ToInt32(idConsulta) > 0)
                {
                    ConsultaAcesso deletar = new ConsultaAcesso();
                    return deletar.DeletarConsultaidConsulta(idUsuarioSistema, idConsulta);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe ConsultaRegraNegocio, Método DeletarConsultaIdConsulta", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool DeletarConsultaIdProfissional(string idUsuarioSistema, string idProfissional)
        {
            try
            {
                if (Convert.ToInt32(idProfissional) > 0)
                {
                    ConsultaAcesso deletar = new ConsultaAcesso();
                    return deletar.DeletarConsultaIdProfissional(idUsuarioSistema, idProfissional);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe ConsultaRegraNegocio, Método DeletarConsultaIdProfissional", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool DeletarConsultaIdUsuario(string idUsuarioSistema, string idUsuario)
        {
            try
            {
                if (Convert.ToInt32(idUsuario) > 0)
                {
                    ConsultaAcesso deletar = new ConsultaAcesso();
                    return deletar.DeletarConsultaIdUsuario(idUsuarioSistema, idUsuario);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe ConsultaRegraNegocio, Método DeletarConsultaIdUsuario", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
