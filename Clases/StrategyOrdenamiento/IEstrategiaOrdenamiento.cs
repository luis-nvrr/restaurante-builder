using System.Collections.Generic;
using Implementacion_PPAI.Clases.NoPersistente;

namespace Implementacion_PPAI.Clases.StrategyOrdenamiento
{
    interface IEstrategiaOrdenamiento
    {
        void Ordenar(List<string> nombreProductos, List<int> totalesPorProducto, List<string> subcategoriasDeCarta,
            List<int> totalesPorSubcategorias, List<string> categoriasDeCarta,
            List<int> totalesPorCategorias, GestorInformeProductosMasPedidos gestor);

    }
}
