using ConsoleAppFrk.Questions._273458;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFrk
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LecturaXml.Lanzar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR : " + ex.Message);
            }

            Console.WriteLine("Presione cualquier tecla para cerrar...");
            Console.ReadKey();
        }
    }
}
