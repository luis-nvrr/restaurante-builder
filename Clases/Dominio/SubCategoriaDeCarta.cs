using System;

namespace Implementacion_PPAI.Clases.Dominio
{
    class SubCategoriaDeCarta
    {
        private SubCategoria _subcategoria;
        private CategoriaDeCarta _categoria;

        public SubCategoriaDeCarta(SubCategoria subcategoria)
        {
            this._subcategoria = subcategoria;
        }

        public SubCategoriaDeCarta()
        {
            this._subcategoria = new SubCategoria();
        }

        public void SetCategoriaCarta(CategoriaDeCarta categoria)
        {
            this._categoria = categoria;
        }

        public String MostrarSubCategoria()
        {
            return _subcategoria.GetNombre();
        }

        public String ObtenerCategoriaDeCarta()
        {
            return _categoria.MostrarCategoria();
        }
    }
}
