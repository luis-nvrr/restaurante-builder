using System;
using System.Collections.Generic;

namespace Implementacion_PPAI.Clases.Dominio
{
    class CategoriaDeCarta
    {
        private Categoria _categoria;
        private List<SubCategoriaDeCarta> _subcategorias;

        public CategoriaDeCarta(){}

        public CategoriaDeCarta(Categoria categoria, List<SubCategoriaDeCarta> subcategorias)
        {
            this._categoria = categoria;
            this._subcategorias = subcategorias;
        }

        public String MostrarCategoria()
        {
            return _categoria.GetNombre();
        }

        public List<String> MostrarSubCategoria()
        {
            List<String> res = new List<String>();
            foreach (var subcategoria in _subcategorias)
            {
                res.Add(this.MostrarCategoria() +"|"+ subcategoria.MostrarSubCategoria());
            }
            return res;
        }

    }
}
