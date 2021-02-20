using System;
using System.Collections.Generic;

namespace Ventas
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor v1 = new Vendedor();
            v1.nombre = "Juan";
            v1.edad = 23;

            Vendedor v2 = new Vendedor();
            v2.nombre = "Pedro";
            v2.edad = 26;

            Vendedor v3 = new Vendedor();
            v3.nombre = "Juan Camilo";
            v3.edad = 22;

            Producto p1 = new Producto();
            p1.nombre = "Jabon";
            p1.valor = 500;

            Producto p2 = new Producto();
            p2.nombre = "Arroz";
            p2.valor = 500;

            Producto p3 = new Producto();
            p3.nombre = "Mani";
            p3.valor = 150;

            Venta venta1 = new Venta();
            venta1.producto = p1;
            venta1.vendedor = v1;
            venta1.comentario = "Gracias por su compra";

            Venta venta2 = new Venta();
            venta2.producto = p2;
            venta2.vendedor = v2;
            venta2.comentario = "Gracias por su compra";

            Venta venta3 = new Venta();
            venta3.producto = p3;
            venta3.vendedor = v3;
            venta3.comentario = "Gracias por su compra";

            List<Venta> ventasResueltas = new List<Venta>();
            ventasResueltas.Add(venta1);
            ventasResueltas.Add(venta2);
            ventasResueltas.Add(venta3);

            int total = 0;
            foreach (Venta v in ventasResueltas)
            {
                total = total + v.producto.valor;
            }
            Console.WriteLine("El total de ventas es: " + total);
            Console.ReadKey();
        }
    }
}
