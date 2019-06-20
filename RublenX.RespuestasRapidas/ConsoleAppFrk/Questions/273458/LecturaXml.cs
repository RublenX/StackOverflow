using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleAppFrk.Questions._273458
{
    public static class LecturaXml
    {
        public static void Lanzar()
        {
            var rutaEnsamblado = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var rutaXml = Path.Combine(rutaEnsamblado, @"Questions\273458\FicheroOK.xml");

            if (File.Exists(rutaXml))
            {
                XmlDocument document = new XmlDocument();
                document.Load(rutaXml);

                foreach (XmlNode node in document.DocumentElement.SelectNodes("listaTransacciones/transaccion"))
                {
                    // Serializa nodo transacción
                    Console.WriteLine($"{node.Name} - {node.SelectSingleNode("idProducto").InnerText}");
                }
            }

            rutaXml = Path.Combine(rutaEnsamblado, @"Questions\273458\FicheroKO.xml");

            if (File.Exists(rutaXml))
            {
                XmlDocument document = new XmlDocument();
                document.Load(rutaXml);

                foreach (XmlNode node in document.DocumentElement.SelectNodes("listaParametros/parametro"))
                {
                    // Serializa nodo transacción
                    Console.WriteLine($"{node.Name} - {node.SelectSingleNode("ordinal").InnerText}");
                }
            }

        }
    }
}
