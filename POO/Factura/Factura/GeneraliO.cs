using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class GeneraliO
    {
        public static void imp(string mensaje)
        {
            System.Console.WriteLine(mensaje);
        }

        public static void imp(Producto obj)
        {
            imp("Los datos del producto son: \n"
                + "Codigo: " + obj.getId() +
                "\nNombre: " + obj.getNombre() +
                "\nCantidad: " + obj.getCantidad() +
                "\nValor Unitario: " + obj.getValorUnitario() +
                "\nValor de Ahorro: " + obj.valorDescuento() +
                "\nSub Total: " + obj.subTotal() + 
                "\n----------------------------------------\n");
        }
        public static string lea(string mensaje)
        {
            imp(mensaje);
            string dato = System.Console.ReadLine();
            return dato;
        }

        public static void lea(Producto obj)
        {
            obj.setNombre(lea("Digite el nombre: "));
            obj.setvalorUnitario(Double.Parse(lea("Ingrese el valor del Producto: ")));
            obj.setCantidad(Int32.Parse(lea("Ingrese la cantidad: ")));
            obj.setDescuento(Double.Parse(lea("Ingrese el porcentaje de descuento: ")));
        }
    }
}
