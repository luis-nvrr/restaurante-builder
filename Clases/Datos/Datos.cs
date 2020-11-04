using System;
using System.Collections.Generic;
using Implementacion_PPAI.Clases.Dominio;
using Implementacion_PPAI.Clases.NoPersistente;

namespace Implementacion_PPAI.Clases.Datos
{
    class Datos
    {
        private static List<Carta> _cartas;
        private static List<Pedido> _pedidos;
        private static Sesion _sesion;


        static Datos()
        {
            _cartas = new List<Carta>();
            _pedidos = new List<Pedido>();
            List<CategoriaDeCarta> categoriasDeCarta = new List<CategoriaDeCarta>();

            // CREAR ESTRUCTURA DE CARTA

            // POSTRES
            SubCategoria helados = new SubCategoria("Helados");
            SubCategoriaDeCarta heladosDeCarta = new SubCategoriaDeCarta(helados);

            SubCategoria tortas = new SubCategoria("Tortas");
            SubCategoriaDeCarta tortasDeCarta = new SubCategoriaDeCarta(tortas);

            SubCategoria flanes = new SubCategoria("Flanes");
            SubCategoriaDeCarta flanesDeCarta = new SubCategoriaDeCarta(flanes);

            List<SubCategoriaDeCarta> subcategoriasDePostres = new List<SubCategoriaDeCarta>();
            subcategoriasDePostres.Add(heladosDeCarta);
            subcategoriasDePostres.Add(tortasDeCarta);
            subcategoriasDePostres.Add(flanesDeCarta);

            Categoria postres = new Categoria("Postres");
            CategoriaDeCarta postresDeCarta = new CategoriaDeCarta(postres, subcategoriasDePostres);
            heladosDeCarta.SetCategoriaCarta(postresDeCarta);
            tortasDeCarta.SetCategoriaCarta(postresDeCarta);
            flanesDeCarta.SetCategoriaCarta(postresDeCarta);

            // PLATOS PRINCIPALES

            SubCategoria carnesRojas = new SubCategoria("Carnes Rojas");
            SubCategoriaDeCarta carnesRojasDeCarta = new SubCategoriaDeCarta(carnesRojas);
            SubCategoria carnesBlancas = new SubCategoria("Carnes Blancas");
            SubCategoriaDeCarta carnesBlancasDeCarta = new SubCategoriaDeCarta(carnesBlancas);
            SubCategoria pescados = new SubCategoria("Pescados");
            SubCategoriaDeCarta pescadosDeCarta = new SubCategoriaDeCarta(pescados);
            SubCategoria pastas = new SubCategoria("Pastas");
            SubCategoriaDeCarta pastasDeCarta = new SubCategoriaDeCarta(pastas);

            List<SubCategoriaDeCarta> subcategoriasPlatosPrincipales = new List<SubCategoriaDeCarta>();
            subcategoriasPlatosPrincipales.Add(carnesRojasDeCarta);
            subcategoriasPlatosPrincipales.Add(carnesBlancasDeCarta);
            subcategoriasPlatosPrincipales.Add(pescadosDeCarta);
            subcategoriasPlatosPrincipales.Add(pastasDeCarta);

            Categoria platosPrincipales = new Categoria("Platos principales");
            CategoriaDeCarta platosPrincipalesDeCarta = new CategoriaDeCarta(platosPrincipales, subcategoriasPlatosPrincipales);
            carnesRojasDeCarta.SetCategoriaCarta(platosPrincipalesDeCarta);
            carnesBlancasDeCarta.SetCategoriaCarta(platosPrincipalesDeCarta);
            pescadosDeCarta.SetCategoriaCarta(platosPrincipalesDeCarta);
            pastasDeCarta.SetCategoriaCarta(platosPrincipalesDeCarta);

            // SALSAS
            SubCategoria aderezos = new SubCategoria("Aderezos");
            SubCategoriaDeCarta aderezosDeCarta = new SubCategoriaDeCarta(aderezos);
            SubCategoria embotelladas = new SubCategoria("Salsas Embotelladas");
            SubCategoriaDeCarta embotelladasDeCarta = new SubCategoriaDeCarta(embotelladas);
            SubCategoria picantes = new SubCategoria("Salsas Picantes");
            SubCategoriaDeCarta picantesDeCarta = new SubCategoriaDeCarta(picantes);
            SubCategoria vinagretas = new SubCategoria("Vinagretas");
            SubCategoriaDeCarta vinagretasDeCarta = new SubCategoriaDeCarta(vinagretas);

            List<SubCategoriaDeCarta> subcategoriasSalsas = new List<SubCategoriaDeCarta>();
            subcategoriasSalsas.Add(aderezosDeCarta);
            subcategoriasSalsas.Add(embotelladasDeCarta);
            subcategoriasSalsas.Add(picantesDeCarta);
            subcategoriasSalsas.Add(vinagretasDeCarta);

            Categoria salsas = new Categoria("Salsas");
            CategoriaDeCarta salsasDeCarta = new CategoriaDeCarta(salsas, subcategoriasSalsas);
            aderezosDeCarta.SetCategoriaCarta(salsasDeCarta);
            embotelladasDeCarta.SetCategoriaCarta(salsasDeCarta);
            picantesDeCarta.SetCategoriaCarta(salsasDeCarta);
            vinagretasDeCarta.SetCategoriaCarta(salsasDeCarta);


            // CATEGORIAS DE CARTA

            categoriasDeCarta.Add(postresDeCarta);
            categoriasDeCarta.Add(platosPrincipalesDeCarta);
            categoriasDeCarta.Add(salsasDeCarta);

            // PRODUCTOS PARA POSTRES

            Producto heladoVainilla = new Producto(DateTime.Now.Date, "Helado de vainilla", 12f);
            Producto heladoGranizado = new Producto(DateTime.Now.Date, "Helado granizado", 12f);
            Producto flanCafe = new Producto(DateTime.Now.Date, "Flan de cafe", 12f);
            Producto flanCoco = new Producto(DateTime.Now.Date, "Flan de coco", 12f);
            Producto tortaHelada = new Producto(DateTime.Now.Date, "Torta helada", 12f);
            Producto tortaChocolate = new Producto(DateTime.Now.Date, "Torta de chocolate", 12f);


            ProductoDeCarta heladoVanillaCarta = new ProductoDeCarta(heladosDeCarta, heladoVainilla);
            ProductoDeCarta heladoGranizadoCarta = new ProductoDeCarta(heladosDeCarta, heladoGranizado);
            ProductoDeCarta flanCafeCarta = new ProductoDeCarta(flanesDeCarta, flanCafe);
            ProductoDeCarta flanCocoCarta = new ProductoDeCarta(flanesDeCarta, flanCoco);
            ProductoDeCarta tortaHeladaCarta = new ProductoDeCarta(tortasDeCarta, tortaHelada);
            ProductoDeCarta tortaChocolateCarta = new ProductoDeCarta(tortasDeCarta, tortaChocolate);

            // PRODUCTOS PARA PLATOS PRINCIPALES

            Producto carneAsada = new Producto(DateTime.Now.Date, "Carne asada", 12f);
            Producto bifePimienta = new Producto(DateTime.Now.Date, "Bife a la pimienta", 12f);
            Producto polloHorno = new Producto(DateTime.Now.Date, "Pollo al horno", 12f);
            Producto pechugaRellena = new Producto(DateTime.Now.Date, "Pechuga rellena", 12f);
            Producto salmonHorno = new Producto(DateTime.Now.Date, "Salmon al Horno", 12f);
            Producto merluzaRellena = new Producto(DateTime.Now.Date, "Merluza Rellena", 12f);
            Producto spaghetti = new Producto(DateTime.Now.Date, "Spaghetti", 12f);
            Producto lasagna = new Producto(DateTime.Now.Date, "Lasagna", 12f);

            ProductoDeCarta carneAsadaDeCarta = new ProductoDeCarta(carnesRojasDeCarta, carneAsada);
            ProductoDeCarta bifePimientaDeCarta = new ProductoDeCarta(carnesRojasDeCarta, bifePimienta);
            ProductoDeCarta polloHornoDeCarta = new ProductoDeCarta(carnesBlancasDeCarta, polloHorno);
            ProductoDeCarta pechugaRellenaDeCarta = new ProductoDeCarta(carnesBlancasDeCarta, pechugaRellena);
            ProductoDeCarta salmonHornoDeCarta = new ProductoDeCarta(pescadosDeCarta, salmonHorno);
            ProductoDeCarta merluzaRellenaDeCarta = new ProductoDeCarta(pescadosDeCarta, merluzaRellena);
            ProductoDeCarta spaghettiDeCarta = new ProductoDeCarta(pastasDeCarta, spaghetti);
            ProductoDeCarta lasagnaDeCarta = new ProductoDeCarta(pastasDeCarta, lasagna);


            // PRODUCTOS PARA SALSAS

            Producto mayonesa = new Producto(DateTime.Now.Date, "Mayonesa", 12f);
            Producto jalapeño = new Producto(DateTime.Now.Date, "Jalapeño", 12f);
            Producto vinagretaLimon = new Producto(DateTime.Now.Date, "Vinagreta de limon y albahaca", 12f);
            Producto embotelladaCasera = new Producto(DateTime.Now.Date, "Embotellada casera", 12f);

            ProductoDeCarta mayonesaCarta = new ProductoDeCarta(aderezosDeCarta, mayonesa);
            ProductoDeCarta jalapeñodDeCarta = new ProductoDeCarta(picantesDeCarta, jalapeño);
            ProductoDeCarta vinagretaDeCarta = new ProductoDeCarta(vinagretasDeCarta, vinagretaLimon);
            ProductoDeCarta embotelladaCaserCarta = new ProductoDeCarta(embotelladasDeCarta, embotelladaCasera);

            // CARTA

            Carta carta = new Carta(DateTime.Parse("16/07/2020"),
                DateTime.Parse("20/07/2020"), DateTime.Parse("20/12/2020"),
                "Carta de Noviembre", categoriasDeCarta);
            _cartas.Add(carta);


            // CREAR PEDIDO 1

            DetalleDePedido detalle1 = new DetalleDePedido(1, DateTime.UtcNow, 12f, carneAsadaDeCarta);
            DetalleDePedido detalle2 = new DetalleDePedido(2, DateTime.UtcNow, 12f, polloHornoDeCarta);
            DetalleDePedido detalle3 = new DetalleDePedido(3, DateTime.UtcNow, 12f, heladoGranizadoCarta);
            DetalleDePedido detalle4 = new DetalleDePedido(4, DateTime.UtcNow, 12f, tortaChocolateCarta);
            DetalleDePedido detalle5 = new DetalleDePedido(1, DateTime.UtcNow, 12f, spaghettiDeCarta);
            DetalleDePedido detalle6 = new DetalleDePedido(1, DateTime.UtcNow, 12f, flanCafeCarta);


            List<DetalleDePedido> detallesPedido1 = new List<DetalleDePedido>();
            detallesPedido1.Add(detalle1);
            detallesPedido1.Add(detalle2);
            detallesPedido1.Add(detalle3);
            detallesPedido1.Add(detalle4);
            detallesPedido1.Add(detalle5);
            detallesPedido1.Add(detalle6);

            Pedido pedido1 = new Pedido(2, DateTime.Parse("02/07/2020"), 1, detallesPedido1);
            _pedidos.Add(pedido1);


            // CREAR PEDIDO 2

            DetalleDePedido detalle7 = new DetalleDePedido(2, DateTime.UtcNow, 12f, bifePimientaDeCarta);
            DetalleDePedido detalle8 = new DetalleDePedido(5, DateTime.UtcNow, 12f, salmonHornoDeCarta);
            DetalleDePedido detalle9 = new DetalleDePedido(3, DateTime.UtcNow, 12f, heladoVanillaCarta);
            DetalleDePedido detalle10 = new DetalleDePedido(2, DateTime.UtcNow, 12f, tortaHeladaCarta);
            DetalleDePedido detalle11 = new DetalleDePedido(2, DateTime.UtcNow, 12f, lasagnaDeCarta);
            DetalleDePedido detalle12 = new DetalleDePedido(6, DateTime.UtcNow, 12f, flanCocoCarta);
            DetalleDePedido detalle13 = new DetalleDePedido(1, DateTime.UtcNow, 12f, mayonesaCarta);

            List<DetalleDePedido> detallesPedido2 = new List<DetalleDePedido>();
            detallesPedido2.Add(detalle7);
            detallesPedido2.Add(detalle8);
            detallesPedido2.Add(detalle9);
            detallesPedido2.Add(detalle10);
            detallesPedido2.Add(detalle11);
            detallesPedido2.Add(detalle12);
            detallesPedido2.Add(detalle13);

            Pedido pedido2 = new Pedido(5, DateTime.Parse("02/07/2020"), 2, detallesPedido2);
            _pedidos.Add(pedido2);


            // CREAR SESION
            Usuario usuario = new Usuario("John Doe", "prueba", DateTime.Parse("20/05/1999"));
            _sesion = new Sesion(usuario);
        }

        public static List<Pedido> GetPedidos()
        {
            return _pedidos;
        }

        public static List<Carta> GetCartas()
        {
            return _cartas;
        }


        public static Sesion GetSesion()
        {
            return _sesion;
        }
    }
}
