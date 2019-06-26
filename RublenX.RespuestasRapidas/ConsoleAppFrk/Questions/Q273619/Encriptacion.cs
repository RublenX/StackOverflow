using System.Globalization;
using System.Text;

namespace ConsoleAppFrk.Questions.Q273619
{
    public static class Encriptacion
    {
        #region Métodos Estáticos
        public static string ByteArrayToStringHex(byte[] inputArray)
        {
            StringBuilder output = new StringBuilder("");
            for (int i = 0; i < inputArray.Length; i++)
            {
                output.Append(inputArray[i].ToString("X2"));
            }
            return output.ToString();
        }

        public static byte[] StringHexToByteArray(string texto)
        {
            byte[] salidaBytes = new byte[texto.Length / 2];

            for (int i = 0; i < texto.Length; i = i + 2)
            {
                salidaBytes[i / 2] = byte.Parse(texto.Substring(i, 2), NumberStyles.HexNumber);
            }

            return salidaBytes;
        }
        #endregion
    }
}
