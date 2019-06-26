using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FirmaAsimetricaWin
{
    // Obtenido de:
    // https://stackoverflow.com/questions/27578694/how-to-encrypt-with-private-key-and-decrypt-with-public-key-in-c-sharp-rsa
    // https://docs.microsoft.com/es-es/dotnet/api/system.security.cryptography.rsacryptoserviceprovider.signdata?f1url=https%3A%2F%2Fmsdn.microsoft.com%2Fquery%2Fdev15.query%3FappId%3DDev15IDEF1%26l%3DES-ES%26k%3Dk(System.Security.Cryptography.RSACryptoServiceProvider.SignData);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.7.2);k(DevLang-csharp)%26rd%3Dtrue&view=netframework-4.8
    // Información adicional sobre cómo funciona HTTPS
    // https://www.genbeta.com/web/https-asi-funciona
    public class FirmaAsimetrica
    {
        public void CrearClavesXml()
        {
            var rsaProvider = new RSACryptoServiceProvider(2048);

            //var priKey = rsaProvider.ExportParameters(true);
            //var pubKey = rsaProvider.ExportParameters(false);

            //var sw = new StringWriter();
            //var xs = new XmlSerializer(typeof(RSAParameters));

            //// Crea el fichero XML con la clave pública
            //xs.Serialize(sw, pubKey);
            //File.WriteAllText(Path.Combine(Application.StartupPath, "clavePublica.xml"), sw.ToString());

            //// Crea el fichero XML con la clave privada
            //xs.Serialize(sw, priKey);
            //File.WriteAllText(Path.Combine(Application.StartupPath, "clavePrivada.xml"), sw.ToString());

            File.WriteAllText(Path.Combine(Application.StartupPath, "clavePrivada.xml"), rsaProvider.ToXmlString(true));
            File.WriteAllText(Path.Combine(Application.StartupPath, "clavePublica.xml"), rsaProvider.ToXmlString(false));
        }

        public string Cifrar(string rutaXml, string textoCifrar)
        {
            if (File.Exists(rutaXml))
            {
                var rsaProvider = new RSACryptoServiceProvider(2048);

                rsaProvider.FromXmlString(File.ReadAllText(rutaXml));

                var bytesTextoCifrar = Encoding.Unicode.GetBytes(textoCifrar);

                var bytesTextoCifrado = rsaProvider.Encrypt(bytesTextoCifrar, false);

                return Convert.ToBase64String(bytesTextoCifrado);
            }

            return string.Empty;
        }

        public string Descifrar(string rutaXml, string textoCifrado)
        {
            if (!string.IsNullOrWhiteSpace(textoCifrado) && File.Exists(rutaXml))
            {
                var rsaProvider = new RSACryptoServiceProvider(2048);

                rsaProvider.FromXmlString(File.ReadAllText(rutaXml));

                var bytesTextoCifrado = Convert.FromBase64String(textoCifrado);

                var bytesTextoDescifrado = rsaProvider.Decrypt(bytesTextoCifrado, false);

                return Encoding.Unicode.GetString(bytesTextoDescifrado);
            }

            return string.Empty;
        }

        public string Firmar(string rutaXml, string textoFirmar)
        {
            if (File.Exists(rutaXml))
            {
                var rsaProvider = new RSACryptoServiceProvider(2048);

                rsaProvider.FromXmlString(File.ReadAllText(rutaXml));

                var bytesTextoFirmar = Encoding.UTF8.GetBytes(textoFirmar);

                var bytesTextoFirmado = rsaProvider.SignData(bytesTextoFirmar, new SHA1CryptoServiceProvider());

                return Convert.ToBase64String(bytesTextoFirmado);
            }

            return string.Empty;
        }

        public bool ValidarFirma(string rutaXml, string textoFirmado, string textoOriginal)
        {
            // TODO : Esto no me está funcionando
            if (!string.IsNullOrEmpty(textoFirmado) && ! string.IsNullOrWhiteSpace(textoOriginal) && File.Exists(rutaXml))
            {
                var rsaProvider = new RSACryptoServiceProvider(2048);

                rsaProvider.FromXmlString(File.ReadAllText(rutaXml));

                var bytesTextoOriginal = Encoding.UTF8.GetBytes(textoOriginal);
                var bytestextoFirmado = Encoding.UTF8.GetBytes(textoFirmado);

                return rsaProvider.VerifyData(bytesTextoOriginal, new SHA1CryptoServiceProvider(), bytestextoFirmado);
            }
            return false;
        }
    }
}
