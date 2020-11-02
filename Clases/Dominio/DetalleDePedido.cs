using System;
using System.Text;

namespace Implementacion_PPAI.Clases.Dominio
{
    class DetalleDePedido
    {
        private int _cantidad;
        private DateTime _hora;
        private float _precio;
        private ProductoDeCarta _producto;


        public DetalleDePedido(int cantidad, DateTime hora, float precio, ProductoDeCarta producto)
        {
            this._cantidad = cantidad;
            this._hora = hora;
            this._precio = precio;
            this._producto = producto;
        }


        public String TieneProductosDeSubCategoriaSeleccionada(String subcategoria)
        {
            String res = null;
            if (_producto.EsDeSubCategoriaSeleccionada(subcategoria))
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(_producto.ObtenerCategoriaDeCarta());
                stringBuilder.Append("|");
                stringBuilder.Append(subcategoria);
                stringBuilder.Append("|");
                stringBuilder.Append(_producto.ObtenerNombreProducto());
                stringBuilder.Append("|");
                stringBuilder.Append(this.GetCantidad());
                res = stringBuilder.ToString();
            } 
            return res;
        }

        public int GetCantidad()
        {
            return this._cantidad;
        }
    }
}
