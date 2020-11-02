using System;

namespace Implementacion_PPAI.Clases.Dominio
{
    class Usuario
    {
        private String _nombre;
        private String _contraseña;
        private DateTime _fechaCreacion;
        private DateTime _fechaBaja;

        public Usuario(String nombre, String contraseña, DateTime fechaCreacion)
        {
            this._nombre = nombre;
            this._contraseña = contraseña;
            this._fechaCreacion = fechaCreacion;
        }

        public String GetNombre()
        {
            return this._nombre;
        }
    }
}
