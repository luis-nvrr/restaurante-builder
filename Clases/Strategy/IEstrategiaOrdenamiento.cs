using System.Collections.Generic;
using Implementacion_PPAI.Clases.No_Persistente;

namespace Implementacion_PPAI.Clases.Strategy
{
    interface IEstrategiaOrdenamiento
    {
        void Ordenar(List<string> nombreProductos, List<int> totalesPorProducto, List<string> subcategoriasDeCarta,
            List<int> totalesPorSubcategorias, List<string> categoriasDeCarta,
            List<int> totalesPorCategorias, GestorInformeProductosMasPedidos gestor);

    }
}
