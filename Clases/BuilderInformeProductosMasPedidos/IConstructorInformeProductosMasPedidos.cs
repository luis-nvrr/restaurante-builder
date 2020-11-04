using System;
using System.Collections.Generic;

namespace Implementacion_PPAI.Clases.BuilderInformeProductosMasPedidos
{ 
    interface IConstructorInformeProductosMasPedidos
    {
        void ConstruirEncabezado(DateTime fechaDesde, DateTime fechaHasta);

        void ConstruirCuerpo(List<String> categorias, List<int> totalCategorias, List<String> subcategorias,
            List<int> totalSubcategorias,
            List<string> productos, List<int> totalProductos);

        void ConstruirPie(String usuario, DateTime fechaHora);

        void ConstruirProducto();
        Object ObtenerProducto();

    }
}
