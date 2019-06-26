using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFrk.Questions.Q273619
{
    public class ConsumirSHA
    {
        public void Prueba1(byte[] DataToSign)
        {
            var rsa = new RSACryptoServiceProvider();
            var privKey = rsa.ExportParameters(true);
            var pubKey = rsa.ExportParameters(false);

            //we need some buffer
            var sw = new System.IO.StringWriter();
            //we need a serializer
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            //serialize the key into the stream
            xs.Serialize(sw, pubKey);
            //get the string from the stream
            var pubKeyString = sw.ToString();

            //get a stream from the string
            var sr = new System.IO.StringReader(pubKeyString);
            //we need a deserializer
            xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            //get the object back from the stream
            var pubKey2 = (RSAParameters)xs.Deserialize(sr);

            var shaInstance = SHA1.Create();
            rsa.SignData(DataToSign, new SHA1CryptoServiceProvider());
        }
    }
}
