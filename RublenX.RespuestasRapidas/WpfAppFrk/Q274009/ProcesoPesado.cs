using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WpfAppFrk.Q274009
{
    public class ProcesoPesado
    {
        public static void ArranqueAplicacion()
        {
            // Hace lo que tenga que hacer, y lo simulo con un Thread.Sleep
            Thread.Sleep(5000);
        }

        public static async Task ArranqueAplicacionAsync()
        {
            await Task.Run(() => ArranqueAplicacion());
        }
    }
}
