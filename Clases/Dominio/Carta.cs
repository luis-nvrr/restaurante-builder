using System;
using System.Collections.Generic;

namespace Implementacion_PPAI.Clases.Dominio
{
    class Carta
    {
        private DateTime _fechaCreacion;
        private DateTime _fechaInicioVigencia;
        private DateTime _fechaFinVigencia;
        private String _nombre;

        private List<CategoriaDeCarta> _categorias;

        public Carta() { }


        public Carta(DateTime fechaCreacion, DateTime fechaInicioVigencia, DateTime fechaFinVigencia, 
             String nombre, List<CategoriaDeCarta> categorias )
        {
            this._fechaCreacion = fechaCreacion;
            this._fechaInicioVigencia = fechaInicioVigencia;
            this._fechaFinVigencia = fechaFinVigencia;
            this._nombre = nombre;
            this._categorias = categorias;

        }

        public Boolean EsVigenteEnPeriodo(DateTime desde, DateTime hasta)
        {
            if (_fechaInicioVigencia >= desde && _fechaFinVigencia >= hasta)
            {
                return true;
            }

            return false;
        }


        public List<String> MostrarCategoriasDeCarta()
        {
            List<String> res = new List<String>();
            foreach (var categoria in _categorias)
            {
                res.Add(categoria.MostrarCategoria());
            }

            return res;
        }

        public List<String> MostrarSubCategorias()
        {
            List<String> res= new List<string>();
            foreach (var categoria in _categorias)
            {
                res.AddRange(categoria.MostrarSubCategoria());
            }
            return res;
        }

    }
}
