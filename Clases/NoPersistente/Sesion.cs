using System;
using Implementacion_PPAI.Clases.Dominio;

namespace Implementacion_PPAI.Clases.NoPersistente
{
    class Sesion
    {
        private Usuario _usuario;
        public Sesion(Usuario usuario)
        {
            this._usuario = usuario;
        }

        public String ConocerUsuario()
        {
            return _usuario.GetNombre();
        }

    }
}
