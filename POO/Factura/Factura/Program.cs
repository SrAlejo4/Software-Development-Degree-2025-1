using System;
using System.Runtime.Remoting.Lifetime;

namespace Factura
{
    public class Program
    {
        static void Main(string[] args)
        {
            GeneraliO.imp("\tPrograma Factura");
            int op = 0;
            do
            {
                op = Int32.Parse(GeneraliO.lea("\tMenú de facturación\n\n" + 
                                                                "1. Agregar producto a la factura\n" + 
                                                                "2. Fin de la factura\n" + 
                                                                "0. Salir"));

                Producto objProducto = new Producto();
                switch (op) 
                {
                    case 1:
                        GeneraliO.lea(objProducto);
                        break;
                    case 2:
                        GeneraliO.imp(objProducto);
                        break;
                    case 0:
                        Console.WriteLine("FIN PROGRAMA ... ");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }while (op != 0);
        }
    }
}
