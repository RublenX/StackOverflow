using CapasMvc5.Entities.Dominio;

namespace CapasMvc5.CapaDatos.Modelo
{
    public partial class Categoria
    {
        public static explicit operator Categoria(ModeloCategoria modelo)
        {
            return new Categoria()
            {
                CatId = modelo.CatId,
                CatNombre = modelo.CatNombre
            };
        }

        public static explicit operator ModeloCategoria(Categoria cat)
        {
            return new ModeloCategoria()
            {
                CatId = cat.CatId,
                CatNombre = cat.CatNombre
            };
        }
    }
}
