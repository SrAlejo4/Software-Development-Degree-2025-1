using System;
using System.Collections.Generic;


namespace FacturaProductos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --------- BIENVENIDO A SUPERMERCADO LOS OLIVOS --------- " +
                              "\n --------- Sistema de facturación para clientes --------- " +
                              "\n Los productos con un valor superior a $50.000 tendrán un descuento del 15% ");
            int opcion = 0;

            Cliente objCliente = new Cliente();
            ListaProductos objLista = new ListaProductos();    
            Factura objFactura = new Factura();

            do
            {
                objFactura.registrarFactura(objLista, objCliente);
                Console.WriteLine("\nDesea registrar otra factura? 1. SI, 2. NO");
                opcion = Int32.Parse(Console.ReadLine());

            } while (opcion == 1);

            Console.WriteLine(" ---------- FIN PROGRAMA ---------- ");
        }
    }
}
