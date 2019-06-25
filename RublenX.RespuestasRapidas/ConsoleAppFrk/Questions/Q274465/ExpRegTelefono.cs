using System.Text.RegularExpressions;

namespace ConsoleAppFrk.Questions.Q274465
{
    public class ExpRegTelefono
    {
        public static bool Validar(string telefono)
        {
            Regex exreg = new Regex("^\\d{7,10}$");
            return exreg.IsMatch(telefono);
        }
    }
}
