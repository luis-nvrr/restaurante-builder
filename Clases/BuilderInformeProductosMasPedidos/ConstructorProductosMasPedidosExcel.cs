﻿using System;
using System.Collections.Generic;

namespace Implementacion_PPAI.Clases.BuilderInformeProductosMasPedidos
{
    class ConstructorProductosMasPedidosExcel : IConstructorInformeProductosMasPedidos
    {
        private InformeProductosMasPedidoseExcel _informe;

        public void ConstruirEncabezado(DateTime fechaDesde, DateTime fechaHasta)
        {
            throw new NotImplementedException();
        }

        public void ConstruirCuerpo(List<string> categorias, List<int> totalCategorias, List<string> subcategorias, List<int> totalSubcategorias, List<string> productoss,
            List<int> totalProductos)
        {
            throw new NotImplementedException();
        }

        public void ConstruirPie(string usuario, DateTime fechaHora)
        {
            throw new NotImplementedException();
        }

        public void ConstruirProducto()
        {
            throw new NotImplementedException();
        }

        public object ObtenerProducto()
        {
            throw new NotImplementedException();
        }
    }
}
