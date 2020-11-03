using System;
using System.Collections.Generic;
using System.Linq;
using Implementacion_PPAI.Clases.Builder;
using Implementacion_PPAI.Clases.Dominio;
using Implementacion_PPAI.Clases.Strategy;

namespace Implementacion_PPAI.Clases.No_Persistente
{
    class GestorInformeProductosMasPedidos
    {
        public static readonly int Descendente = 0;
        public static readonly int Ascendente = 1;
        private int _opcionSeleccionada;

        private PantallaInformeProductosMasPedidos _pantalla;
        private DateTime _fechaHoraActual;
        
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;

        private List<Pedido> _pedidos;
        private List<Carta> _cartas;
        private List<Carta> _cartasVigentes;

        private List<String> _categoriasDeCarta;
        private List<String> _subcategoriasDeCarta;

        private List<String> _nombreProductos;
        private List<String> _productosPedidos;
        private List<int> _totalesPorProducto;

        private List<List<String>> _productosDeCategorias;
        private List<int> _totalesPorCategorias;
        private List<List<String>> _productosDeSubcategorias;
        private List<int> _totalesPorSubcategorias;

        private String _usuario;

        public GestorInformeProductosMasPedidos(PantallaInformeProductosMasPedidos pantalla)
        {
            this._pantalla = pantalla;

            this._fechaHoraActual = new DateTime();
            this._fechaDesde = new DateTime();
            this._fechaHasta = new DateTime();

            this._pedidos = Datos.Datos.GetPedidos();
            this._cartas = Datos.Datos.GetCartas();
            this._cartasVigentes = new List<Carta>();
            
            this._categoriasDeCarta = new List<String> ();

            this._subcategoriasDeCarta = new List<string>();

        }
        

        public void NuevoInformeProducto()
        {
            _pantalla.SolicitarSeleccionPeriodo();
        }

        public void TomarPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            if (this.ValidarPeriodo(fechaDesde, fechaHasta))
            {
                this._fechaDesde = fechaDesde;
                this._fechaHasta = fechaHasta;

                this.BuscarCategoriasDeCartaVigentesEnPeriodo();
                this.BuscarSubCategoriasDeCategoriasSeleccionadas();
                this.ObtenerOpcionesParaOrdenar();

            }
            else
            {
                _pantalla.EmitirErrorPeriodo();
            }
        }

        public void TomarFechaHoraActual()
        {
            _fechaHoraActual = DateTime.Now;
        }

        public Boolean ValidarPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            TomarFechaHoraActual();

            if (fechaDesde <= fechaHasta && fechaDesde <= _fechaHoraActual && fechaHasta <= _fechaHoraActual)
            {
                return true;
            }
            return false;
        }

        public void BuscarCategoriasDeCartaVigentesEnPeriodo()
        {
            List<String> res = new List<String>();

            foreach (var carta in _cartas)
            {
                if (carta.EsVigenteEnPeriodo(_fechaDesde, _fechaHasta))
                {
                    this._cartasVigentes.Add(carta);
                    res.AddRange(carta.MostrarCategoriasDeCarta());
                }
            }
            this._categoriasDeCarta = res;
            _pantalla.MostrarCategoriasDeCartaParaSeleccionar(_categoriasDeCarta);
        }


        public void BuscarSubCategoriasDeCategoriasSeleccionadas()
        {
            List<String> res = new List<String>();

            foreach (var carta in _cartasVigentes)
            {
                res.AddRange(carta.MostrarSubCategorias());
            }
            this._subcategoriasDeCarta = res;

            _pantalla.MostrarSubCategoriasDeCartaParaSeleccionar(_subcategoriasDeCarta);
        }


        public void ObtenerOpcionesParaOrdenar()
        {
            _pantalla.SolicitarSeleccionOpcionParaOrdenar();
        }

        public void TomarOpcionParaOrdenar(int opcion)
        {
            this._opcionSeleccionada = opcion;
            _pantalla.SolicitarConfirmacion();
        }

        public void TomarConfirmacion()
        {
            BuscarPedidosCumplenFiltros();
            AgruparProductos();
            CalcularCantidadTotalPorProducto();
            CalcularCantidadTotalPorSubcategoria();
            CalcularCantidadTotalPorCategoria();
            OrdenarTotales();
            ObtenerFormaVisualizacion();

        }

        public void BuscarPedidosCumplenFiltros()
        {
            List<String> productos = new List<String>();
            foreach(var pedido in _pedidos)
            {
                foreach (var subcategoria in _subcategoriasDeCarta)
                {
                    if (pedido.EstaEnPeriodo(_fechaDesde, _fechaHasta))
                    {
                        productos.AddRange(pedido.BuscarProductoDeSubCategoriaSeleccionada(subcategoria.Split('|')[1]));
                    }
                }
            }
            _productosPedidos = productos;
        }


        public void AgruparProductos()
        {
            List<List<String>> productosCategorias = new List<List<String>>();
            List<List<String>> productosSubcategorias = new List<List<String>>();

            for (int i = 0; i < _categoriasDeCarta.Count; i++)
            {
                List<String> productosDeCadaCategoria = new List<string>();
                var categoria = _categoriasDeCarta[i];

                for (int j = 0; j < _productosPedidos.Count; j++)
                {
                    var producto = _productosPedidos[j];
                    if (producto.Split('|')[0].Equals(categoria))
                    {
                        productosDeCadaCategoria.Add(producto);
                    }
                }

                productosCategorias.Add(productosDeCadaCategoria);
            }

            this._productosDeCategorias = productosCategorias;


            for (int i = 0; i < _subcategoriasDeCarta.Count; i++)
            {
                List<String> productosDeCadaSubcategoria = new List<string>();
                var subcategoria = _subcategoriasDeCarta[i];

                for (int j = 0; j < _productosPedidos.Count; j++)
                {
                    var producto = _productosPedidos[j];
                    if (producto.Split('|')[1].Equals(subcategoria.Split('|')[1]))
                    {
                       productosDeCadaSubcategoria.Add(producto);
                    }
                }
                productosSubcategorias.Add(productosDeCadaSubcategoria);
            }
            this._productosDeSubcategorias = productosSubcategorias;
        }


        public void CalcularCantidadTotalPorProducto()
        {

            int[] total = new int[_productosPedidos.Count];
            HashSet<String> listaProductos = new HashSet<String>(_productosPedidos.Count);

            foreach(var p in _productosPedidos)
            {
                var cat = p.Split('|')[0];
                var sub = p.Split('|')[1];
                var pro = p.Split('|')[2];
                listaProductos.Add(cat+"|"+sub+"|"+pro);
            }
            _nombreProductos = listaProductos.ToList();

            for (int i = 0; i < _nombreProductos.Count; i++)
            {
                foreach (var productoPedido in _productosPedidos)
                {
                    if (_nombreProductos[i].Split('|')[2].Equals(productoPedido.Split('|')[2]))
                    {
                        var old = total[i];
                        total[i] = old + Int32.Parse(productoPedido.Split('|')[3]);
                    }
                }
            }
            _totalesPorProducto = total.ToList();
            
        }


        public void CalcularCantidadTotalPorSubcategoria()
        {
            int[] total = new int[_subcategoriasDeCarta.Count];

            for (int i = 0; i < _subcategoriasDeCarta.Count; i++)
            {
                for (int j = 0; j < _productosDeSubcategorias[i].Count; j++)
                {
                    var producto = _productosDeSubcategorias[i][j];
                    var old = total[i];
                    total[i] = old + Int32.Parse(producto.Split('|')[3]);
                }
            }
            _totalesPorSubcategorias = total.ToList();
        }


        public void CalcularCantidadTotalPorCategoria()
        {
            int[] total = new int[_categoriasDeCarta.Count];

            for (int i = 0; i < _categoriasDeCarta.Count; i++)
            {
                for (int j = 0; j < _productosDeCategorias[i].Count; j++)
                {
                    var producto = _productosDeCategorias[i][j];
                    var old = total[i];
                    total[i] = old + Int32.Parse(producto.Split('|')[3]);
                }
            }
            _totalesPorCategorias = total.ToList();
        }


        public void OrdenarTotales()
        {
            IEstrategiaOrdenamiento estrategia;

            if (_opcionSeleccionada.Equals(Ascendente))
            {
                estrategia= new OrdenamientoAscendente();
                estrategia.Ordenar(_nombreProductos, _totalesPorProducto,
                    _subcategoriasDeCarta, _totalesPorSubcategorias,
                    _categoriasDeCarta, _totalesPorCategorias,this);
            }

            if (_opcionSeleccionada.Equals(Descendente))
            {
                estrategia = new OrdenamientoDescendente();
                estrategia.Ordenar(_nombreProductos, _totalesPorProducto,
                    _subcategoriasDeCarta, _totalesPorSubcategorias,
                    _categoriasDeCarta, _totalesPorCategorias, this);
            }

        }

        public void SetCategoriasDeCarta(List<String> categoriasDeCarta)
        {
            this._categoriasDeCarta = categoriasDeCarta;
        }

        public void SetTotalesPorCategorias(List<int> totalesPorCategorias)
        {
            this._totalesPorCategorias = totalesPorCategorias;
        }

        public void SetSubcategoriasDeCarta(List<String> subcategoriasDeCarta)
        {
            this._subcategoriasDeCarta = subcategoriasDeCarta;
        }

        public void SetTotalesPorSubategorias(List<int> totalesPorSubcategorias)
        {
            this._totalesPorSubcategorias = totalesPorSubcategorias;
        }

        public void SetNombresProductos(List<String> nombresProductos)
        {
            this._nombreProductos = nombresProductos;
        }

        public void SetTotalesPorProducto(List<int> totalesPorProducto)
        {
            this._totalesPorProducto = totalesPorProducto;
        }

        public void ObtenerFormaVisualizacion()
        {
            _pantalla.SolicitarSeleccionFormasVisualizacion();
        }

        public void TomarFormaVisualizacion(String formaVisualizacion)
        {
            if (formaVisualizacion.Equals("por pantalla"))
            {
                TomarFechaHoraActual();
                BuscarUsuarioLogueado();
                GenerarReportePantalla();
            }
           
        }

        public void BuscarUsuarioLogueado()
        {
            Sesion sesion = Datos.Datos.GetSesion();
            this._usuario = sesion.ConocerUsuario();
        }


        public void GenerarReportePantalla()
        {
            IConstructorInformeProductosMasPedidos constructor = new ConstructorProductosMasPedidosPantalla();
            DirectorConstructorInforme director = new DirectorConstructorInforme(constructor);

            director.Construir(_fechaDesde, _fechaHasta, _categoriasDeCarta, _totalesPorCategorias, _subcategoriasDeCarta, 
                _totalesPorSubcategorias, _nombreProductos, _totalesPorProducto,_usuario, _fechaHoraActual);

            InformeProductosMasPedidosPantalla producto = (InformeProductosMasPedidosPantalla) constructor.ObtenerProducto();
            producto.VisualizarProducto();
        }
       
    }
}
