using System.Security.Cryptography;
using System.Text;

namespace ConsoleAppFrk.Questions.Q273619
{
    /// <summary>
    /// Clase para la encriptación asimétrica, en este caso se debe encriptar y desencriptar en la misma máquina
    /// </summary>
    public class AsimetricaRSA
    {
        #region Variables y constantes
        private const string keyName = "LlaveTrabajoPCLocal";
        readonly private CspParameters cspp;
        readonly private RSACryptoServiceProvider rsa;
        #endregion

        #region Contructor
        public AsimetricaRSA()
        {
            cspp = new CspParameters();
            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
        }
        #endregion

        #region Métodos Públicos
        public string RecuperarClaveAsimetrica()
        {
            return cspp.KeyContainerName;
        }

        public string Encriptar(string texto)
        {
            UTF8Encoding ByteConverter = new UTF8Encoding();

            byte[] textoBytes = ByteConverter.GetBytes(texto);

            byte[] cifradoBytes = rsa.Encrypt(textoBytes, true);

            return Encriptacion.ByteArrayToStringHex(cifradoBytes);
        }

        public string Desencriptar(string texto)
        {
            UTF8Encoding ByteConverter = new UTF8Encoding();

            byte[] cifradoBytes = Encriptacion.StringHexToByteArray(texto);

            byte[] descifradoBytes = rsa.Decrypt(cifradoBytes, true);

            return ByteConverter.GetString(descifradoBytes);
        }
        #endregion
    }
}
