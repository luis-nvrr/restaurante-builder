using System;

namespace Implementacion_PPAI.Clases.Dominio
{
    class Categoria
    {
        private String _nombre;

        public Categoria(){}

        public Categoria(String nombre)
        {
            this._nombre = nombre;
        }

        public String GetNombre()
        {
            return this._nombre;
        }
    }
}
