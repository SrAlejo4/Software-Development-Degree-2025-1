using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Facuracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            GestionFactura.crearProductos();

            do
            {
                try
                {
                    Console.Clear();
                    Console.Write("\tMenu facturacion" +
                                            "\nIngrese la cantidad de productos que va a registrar: ");

                    int tam = Int32.Parse(Console.ReadLine());
                    GestionFactura.definirCarrito(tam);
                    GestionFactura.registrarProducto();
                    GestionFactura.generarFactura();

                    Console.WriteLine("\nDesea registrar otra factura? (1. SI, 0. NO)");
                    op = Int32.Parse(Console.ReadLine());
                    if (op == 0)
                    {
                        Console.WriteLine("\nSaliendo del programa . . .");
                        Thread.Sleep(3000);
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nError: " + e.Message);
                    Console.WriteLine("Ingrese una tecla para regresar");
                    Console.ReadKey();
                }

            } while (true);
        }
    }
}
