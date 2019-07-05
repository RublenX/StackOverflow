using CapasMvc5.CapaDatos.AccesoDatos;
using CapasMvc5.Entities.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapasMvc5.CapaNegocios.Servicios
{
    public class CategoriaBL
    {
        public static List<ModeloCategoria> ListarCategorias()
        {
            CategoriaDAL cat = new CategoriaDAL();
            return cat.ListarCategorias();
        }

        #region Métodos Asíncronos
        public static async Task<List<ModeloCategoria>> ListarCategoriasAsync()
        {
            return await Task.Run(() => { return ListarCategorias(); } );
        }
        #endregion
    }
}
