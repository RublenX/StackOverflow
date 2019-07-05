using CapasMvc5.CapaDatos.Modelo;
using CapasMvc5.CapaDatos.Persistencia;
using CapasMvc5.Entities.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapasMvc5.CapaDatos.AccesoDatos
{
    public class CategoriaDAL
    {
        public List<ModeloCategoria> ListarCategorias()
        {
            using (ProductosEntities bd = new ProductosEntities())
            {
                return bd.Categoria.Select(cat => new ModeloCategoria()
                {
                    CatId = cat.CatId,
                    CatNombre = cat.CatNombre
                }).ToList();
            }
        }
    }
}
