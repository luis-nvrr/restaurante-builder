using System;
using System.Collections.Generic;

namespace Implementacion_PPAI.Clases.Dominio
{
    class Pedido
    {
        private int _cantidadComensales;
        private DateTime _fechaHoraPedido;
        private int _numeroPedido;
        private List<DetalleDePedido> _detalles;

        public Pedido(){}

        public Pedido(int cantidadComensales, DateTime fechaHoraPedido, int numero, List<DetalleDePedido> detalles)
        {
            this._cantidadComensales = cantidadComensales;
            this._fechaHoraPedido = fechaHoraPedido;
            this._numeroPedido = numero;
            this._detalles = detalles;
        }

        public Boolean EstaEnPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            if (_fechaHoraPedido >= fechaDesde && _fechaHoraPedido <= fechaHasta)
            {
                return true;
            }

            return false;
        }

        public List<String> BuscarProductoDeSubCategoriaSeleccionada(String subcategoria)
        {
            List<String> productosSubcategoria = new List<String>();

            foreach (var detalle in _detalles)
            {
                if (detalle.TieneProductosDeSubCategoriaSeleccionada(subcategoria) != null)
                {
                    productosSubcategoria.Add(detalle.TieneProductosDeSubCategoriaSeleccionada(subcategoria));
                }
            }

            return productosSubcategoria;
        }

    }
}
