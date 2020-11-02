using System;

namespace Implementacion_PPAI.Clases.Dominio
{
    class ProductoDeCarta
    {
        private SubCategoriaDeCarta _subcategoria;
        private Producto _producto;

        public ProductoDeCarta(){}

        public ProductoDeCarta(SubCategoriaDeCarta subcategoria, Producto producto)
        {
            this._subcategoria = subcategoria;
            this._producto = producto;
        }
        public Boolean EsDeSubCategoriaSeleccionada(String subcat)
        {
            if (subcat.Equals(this._subcategoria.MostrarSubCategoria()))
            {
                return true;
            }

            return false;
        }

        public String ObtenerCategoriaDeCarta()
        {
            return this._subcategoria.ObtenerCategoriaDeCarta();
        }

        public String ObtenerNombreProducto()
        {
            return _producto.GetNombre();
        }
    }
}
