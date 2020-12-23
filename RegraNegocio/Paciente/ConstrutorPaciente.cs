using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class ConstrutorPaciente
    {
        string idUsuario, idNivel, loginUsuario, nomeNivel;
        string idPaciente, idContato, idEndereco, idUsuarioCadastro, nomePaciente, nomeResponsavel,
        rg,cpf, ocupacao,idade, sexo, dataNascimento, dataCadastro, horaCadastro, observacaoPaciente;

        #region Propriedades
        /*Dados do usuario do sistema*/
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string IdNivel { get => idNivel; set => idNivel = value; }
        public string LoginUsuario { get => loginUsuario; set => loginUsuario = value; }
        public string NomeNivel { get => nomeNivel; set => nomeNivel = value; }

        /*Dados do paciente*/
        public string IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string IdContato { get => idContato; set => idContato = value; }
        public string IdEndereco { get => idEndereco; set => idEndereco = value; }
        public string IdUsuarioCadastro { get => idUsuarioCadastro; set => idUsuarioCadastro = value; }
        public string NomePaciente { get => nomePaciente; set => nomePaciente = value; }
        public string NomeResponsavel { get => nomeResponsavel; set => nomeResponsavel = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Ocupacao { get => ocupacao; set => ocupacao = value; }
        public string Idade { get => idade; set => idade = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string DataCadastro { get => dataCadastro; set => dataCadastro = value; }
        public string HoraCadastro { get => horaCadastro; set => horaCadastro = value; }
        public string ObservacaoPaciente { get => observacaoPaciente; set => observacaoPaciente = value; }
        #endregion
      
        /*Fornece as informações necessarias para efetuar uma nova consulta.*/
        public ConstrutorPaciente(string idUsuarioPassar, string idNivelPassarDados, string loginUsuarioPassarDados, string nomeNivelPassarDados, string idPacientePassarDados,string idContatoPassarDados,
         string idEnderecoPassarDados,string idUsuarioCadastro, string nomePacientePassarDados, string nomeResponsavelPassarDados, string rgPassarDados, string cpfPassarDados,string ocupacaoPassarDados, 
         string idadePassarDados, string sexoPassarDados,string dataNascimentoPassarDados, string dataCadastroPassarDados, string horaCadastroPassarDados, string observacaoPacientePassarDados)
        {
            //Dados do Usuario do Sistema
            this.IdUsuario = idUsuarioPassar;
            this.IdNivel = idNivelPassarDados;
            this.LoginUsuario = loginUsuarioPassarDados;
            this.NomeNivel = nomeNivelPassarDados;
            //Dados do paciente
            this.IdPaciente = idPacientePassarDados;
            this.IdContato = idContatoPassarDados;
            this.IdEndereco = idEnderecoPassarDados;
            this.IdUsuarioCadastro = idUsuarioCadastro;
            this.NomePaciente = nomePacientePassarDados;
            this.NomeResponsavel = nomeResponsavelPassarDados;
            this.Rg = rgPassarDados;
            this.Cpf = cpfPassarDados;
            this.Ocupacao = ocupacaoPassarDados;
            this.Idade = idadePassarDados;
            this.Sexo = sexoPassarDados;
            this.DataNascimento = dataNascimentoPassarDados;
            this.DataCadastro = dataCadastroPassarDados;
            this.HoraCadastro = horaCadastroPassarDados;
            this.ObservacaoPaciente = observacaoPacientePassarDados;
        }

        /*Fornece as informações nessecarias para que seja efetuada uma pesquisa dos dados do paciente incluindo seu endereco e contato
         obs:A pesquisa necessita apenas do código indentificador do paciente já que será utilizado o inner join*/
        public ConstrutorPaciente(string idUsuarioPassar, string idNivelPassarDados, string loginUsuarioPassarDados, string nomeNivelPassarDados, string idPacientePassarDados)
        {
            //Dados do Usuario do Sistema
            this.IdUsuario = idUsuarioPassar;
            this.IdNivel = idNivelPassarDados;
            this.LoginUsuario = loginUsuarioPassarDados;
            this.NomeNivel = nomeNivelPassarDados;
            //Dados do paciente
            this.IdPaciente = idPacientePassarDados;
        }

    }
}
