using System.Collections.Generic;
using Implementacion_PPAI.Clases.No_Persistente;

namespace Implementacion_PPAI.Clases.Strategy
{
    class OrdenamientoAscendente: IEstrategiaOrdenamiento
    {
        public void Ordenar(List<string> nombreProductos, List<int> totalesPorProducto, List<string> subcategoriasDeCarta, List<int> totalesPorSubcategorias, List<string> categoriasDeCarta,
            List<int> totalesPorCategorias, GestorInformeProductosMasPedidos gestor)
        {
            for (int i = 0; i < totalesPorCategorias.Count - 1; i++)
            {
                for (int j = i; j < totalesPorCategorias.Count; j++)
                {
                    if (totalesPorCategorias[i] > totalesPorCategorias[j])
                    {
                        var temp = totalesPorCategorias[i];
                        totalesPorCategorias[i] = totalesPorCategorias[j];
                        totalesPorCategorias[j] = temp;

                        var tempCat = categoriasDeCarta[i];
                        categoriasDeCarta[i] = categoriasDeCarta[j];
                        categoriasDeCarta[j] = tempCat;
                    }
                }
            }

            for (int i = 0; i < totalesPorSubcategorias.Count - 1; i++)
            {
                for (int j = i; j < totalesPorSubcategorias.Count; j++)
                {
                    if (totalesPorSubcategorias[i] > totalesPorSubcategorias[j])
                    {
                        var temp = totalesPorSubcategorias[i];
                        totalesPorSubcategorias[i] = totalesPorSubcategorias[j];
                        totalesPorSubcategorias[j] = temp;

                        var tempCat = subcategoriasDeCarta[i];
                        subcategoriasDeCarta[i] = subcategoriasDeCarta[j];
                        subcategoriasDeCarta[j] = tempCat;
                    }
                }
            }

            for (int i = 0; i < totalesPorProducto.Count - 1; i++)
            {
                for (int j = i; j < totalesPorProducto.Count; j++)
                {
                    if (totalesPorProducto[i] > totalesPorProducto[j])
                    {
                        var temp = totalesPorProducto[i];
                        totalesPorProducto[i] = totalesPorProducto[j];
                        totalesPorProducto[j] = temp;

                        var tempCat = nombreProductos[i];
                        nombreProductos[i] = nombreProductos[j];
                        nombreProductos[j] = tempCat;
                    }
                }
            }

            gestor.SetCategoriasDeCarta(categoriasDeCarta);
            gestor.SetTotalesPorCategorias(totalesPorCategorias);
            gestor.SetSubcategoriasDeCarta(subcategoriasDeCarta);
            gestor.SetTotalesPorSubategorias(totalesPorSubcategorias);
            gestor.SetNombresProductos(nombreProductos);
            gestor.SetTotalesPorProducto(totalesPorProducto);
        }
    }
}
