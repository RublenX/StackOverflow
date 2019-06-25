using ConsoleAppFrk.Questions._273458;
using ConsoleAppFrk.Questions.Q274465;
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
                //LecturaXml.Lanzar();

                bool salir = false;

                while (!salir)
                {
                    Console.WriteLine("Introduzca un número de teléfono y presione ENTER... 0 para salir de la aplicación");
                    string telefono = Console.ReadLine();

                    if (telefono == "0")
                    {
                        salir = true;
                    }
                    else if (ExpRegTelefono.Validar(telefono))
                    {
                        Console.WriteLine("Teléfono válido");
                    }
                    else
                    {
                        Console.WriteLine("Teléfono inválido");
                    }
                }
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
