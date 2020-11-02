using System;
using System.Collections.Generic;

namespace Implementacion_PPAI.Clases.Builder
{
    class ConstructorProductosMasPedidosPantalla : IConstructorInformeProductosMasPedidos
    {
        InformeProductosMasPedidosPantalla _informe;

        public ConstructorProductosMasPedidosPantalla()
        {

        }

        void IConstructorInformeProductosMasPedidos.ConstruirCuerpo(List<string> categorias, List<int> totalCategorias, List<string> subcategorias,
            List<int> totalSubcategorias, List<string> productos, List<int> totalProductos)
        {
            for (int i = 0; i < categorias.Count; i++)
            {
                _informe.AgregarFila();
                _informe.AgregarCategoria(categorias[i], totalCategorias[i].ToString());
                for (int j = 0; j < subcategorias.Count; j++)
                {
                    var categoria = subcategorias[j].Split('|')[0];
                    if (categoria.Equals(categorias[i]))
                    {
                        var subcategoria = subcategorias[j].Split('|')[1];
                        _informe.AgregarFila();
                        _informe.AgregarSubcategoria(subcategoria, totalSubcategorias[j].ToString());
                        for (int k = 0; k < productos.Count; k++)
                        {
                            if ((productos[k].Split('|')[1]).Equals(subcategoria))
                            {
                                var producto = productos[k].Split('|')[2];
                                var total = totalProductos[k].ToString();
                                _informe.AgregarFila();
                                _informe.AgregarProducto(producto, total);
                            }
                            
                        }
                    }
                }
            }
        }

        void IConstructorInformeProductosMasPedidos.ConstruirEncabezado(DateTime fechaDesde, DateTime fechaHasta)
        {
            _informe.SetEncabezado(fechaDesde.ToString(), fechaHasta.ToString());
        }

        void IConstructorInformeProductosMasPedidos.ConstruirPie(string usuario, DateTime fechaHora)
        {
            _informe.SetPie(usuario, fechaHora.ToString());
        }

        void IConstructorInformeProductosMasPedidos.ConstruirProducto()
        {
            _informe = new InformeProductosMasPedidosPantalla();
        }

        object IConstructorInformeProductosMasPedidos.ObtenerProducto()
        {
            return _informe;
        }
    }
}
