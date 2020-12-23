using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RegraNegocio
{
   public class Criptografar
    {
        private string senhaEncriptada, senhaVazia;
        public string EncriptarSenha(string senhaDigitada)//Criptografa a senha se forma permanente e irreversivel 
        {
            
			try
			{
                UnicodeEncoding encode = new UnicodeEncoding();
                byte[] hashBytes, _messageByte = encode.GetBytes(senhaDigitada);

                SHA512Managed sHA512Managed = new SHA512Managed();
                var stringHash = "";

                hashBytes = sHA512Managed.ComputeHash(_messageByte);
                foreach ( byte b in hashBytes)
                {
                    stringHash += string.Format("{0:x2}", b);
                }
                return senhaDigitada = stringHash;
			}
			catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Criptografar a senha, error: "+ex.Message+", Contate o Suporte!","Falha de Criptografia ");
			}
            return senhaVazia;
        }
    }
}
