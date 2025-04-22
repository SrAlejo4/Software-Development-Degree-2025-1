using System;
using System.Collections.Generic;


namespace FacturaProductos
{
    public class ListaProductos
    {
        public LinkedList<Producto> llenarLista() 
        {
            LinkedList<Producto> listaProductos = new LinkedList<Producto>();
            int opcion = 0;
            do
            {
                Producto p = new Producto();
                Console.Write("\nIngrese el código del producto: ");
                p.Codigo = Console.ReadLine();

                Console.Write("Ingrese el nombre del producto: ");
                p.Nombre = Console.ReadLine();

                Console.Write("Ingrese la cantidad a llevar del producto: ");
                p.Cantidad = Int32.Parse(Console.ReadLine());

                Console.Write("Ingrese el valor unitario del producto: ");
                p.ValorUnitario = Double.Parse(Console.ReadLine());

                if (p.ValorUnitario > 50000) 
                {
                    p.Descuento = p.ValorUnitario * 0.15;
                }

                listaProductos.AddLast(p);

                Console.WriteLine("\nDesea agregar más productos a la factura? 1: SI, 2: NO");
                opcion = Int32.Parse(Console.ReadLine());
            
            } while (opcion == 1);

            return listaProductos;
        }

        public void mostrarLista(LinkedList<Producto> listaProductos) 
        {
            if (!(listaProductos.Count == 0))
            {
                foreach (Producto p in listaProductos)
                {
                    Console.Write("\nCódigo producto: " + p.Codigo);
                    Console.Write("\nNombre: " + p.Nombre);
                    Console.Write("\nCantidad: " + p.Cantidad);
                    Console.Write("\nValor unitario: " + p.ValorUnitario);
                    Console.Write("\nDescuento: " + p.Descuento);
                    Console.Write("\n ------------------------ \n");
                }
            }
            else {
                Console.Write("\nNo se han incluido productos en la compra");
            }
        
        }
    }
}
