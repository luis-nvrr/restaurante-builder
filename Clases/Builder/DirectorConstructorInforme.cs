using System;
using System.Collections.Generic;

namespace Implementacion_PPAI.Clases.Builder
{
    class DirectorConstructorInforme
    {
        private IConstructorInformeProductosMasPedidos _constructor;

        public DirectorConstructorInforme(IConstructorInformeProductosMasPedidos constructor)
        {
            this._constructor = constructor;
        }

        public void Construir(DateTime fechaDesde, DateTime fechaHasta, List<String> categorias,
            List<int> totalCategorias, List<String> subcategorias,
            List<int> totalSubcategorias, List<String> productos, List<int> totalProductos, String usuario,
            DateTime fechaHora)
        {
            this._constructor.ConstruirProducto();
            this._constructor.ConstruirEncabezado(fechaDesde, fechaHasta);
            this._constructor.ConstruirCuerpo(categorias, totalCategorias, subcategorias, totalSubcategorias, productos,
                totalProductos);
            this._constructor.ConstruirPie(usuario, fechaHora);
        }

    }
}
