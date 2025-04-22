using System;
using System.Collections.Generic;

namespace FacturaProductos
{
    public class Factura
    {
        private string facturaCliente;
        private double ivaFactura;
        private double totalFactura;
        public string FacturaCliente
        {
            get { return facturaCliente; }
            set { facturaCliente = value; }
        }

        public void registrarFactura(ListaProductos lista, Cliente cliente)
        {

            Console.Write("\nIngrese la cedula del cliente: ");
            cliente.Cedula = Console.ReadLine();
            Console.Write("Ingrese el nombre del cliente: ");
            cliente.Nombre = Console.ReadLine();
            LinkedList<Producto> listaProductos = lista.llenarLista();

            Console.WriteLine($"\n\n ------------------------- " +
                "\n - - - - - FACTURA DE VENTA - - - - - " +
                $"\nCEDULA CLIENTE: {cliente.Cedula} " +
                $"\nNOMBRE CLIENTE: {cliente.Nombre} \n");
            lista.mostrarLista(listaProductos);
            calcularTotalFactura(listaProductos);
            calcularIVA();
            Console.WriteLine($"IVA: {ivaFactura}");
            Console.WriteLine($"Total factura: {totalFactura + ivaFactura}");
        }

        public void calcularTotalFactura(LinkedList<Producto> lista)
        {
            foreach (Producto p in lista) 
            {
                double totalProducto = 0;
                if (p.Descuento > 0) {
                    totalProducto = (p.ValorUnitario - p.Descuento) * p.Cantidad;
                }
                else
                {
                    totalProducto = p.ValorUnitario * p.Cantidad;
                }

                totalFactura += totalProducto;
            }
        }
        public void calcularIVA() 
        {
            ivaFactura = totalFactura * 0.19;
        }
    }
}
