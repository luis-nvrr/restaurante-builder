using System;

namespace Implementacion_PPAI.Clases.Dominio
{
    class Producto
    {
        private DateTime _fechaCreacion;
        private String _nombre;
        private float _precio;

        public Producto(DateTime fechaCreacion, String nombre, float precio)
        {
            this._fechaCreacion = fechaCreacion;
            this._nombre = nombre;
            this._precio = precio;
        }

        public String GetNombre()
        {
            return this._nombre;
        }

    }
}
