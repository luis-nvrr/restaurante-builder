using System;

namespace Implementacion_PPAI.Clases.Dominio
{
    class SubCategoria
    {
        private String _nombre;

        public SubCategoria(){}

        public SubCategoria(String nombre)
        {
            this._nombre = nombre;
        }

        public String GetNombre()
        {
            return _nombre;
        }
    }
}
