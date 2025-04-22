using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class Producto
    {
        private int id;
        private string nombre;
        private int cantidad;
        private double valorUnitario;
        private double descuento;
        private static int contador = 0;

        public Producto()
        {
            contador = contador + 1;
            id = contador;
            nombre = "";
            cantidad = 0;
            valorUnitario = 0;
            descuento = 0;
        }

        public Producto(string nombre, int cantidad, double valorUnitario, double descuento)
        {
            contador = contador + 1;
            id = contador;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.valorUnitario = valorUnitario;
            this.descuento = descuento;
        }

        public int getId()
        {
            return id; 
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public int getCantidad()
        {
            return cantidad;
        }
        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
        public double getValorUnitario()
        {
            return valorUnitario;
        }
        public void setvalorUnitario(double valorUnitario)
        {
            this.valorUnitario = valorUnitario;
        }
        public double getDescuento()
        {
            return descuento;
        }
        public void setDescuento(double descuento)
        {
            this.descuento = descuento;
        }
        public double valorDescuento()
        {
            return subTotal() * (descuento / 100);
        }
        public double subTotal()
        {
            return (cantidad * valorUnitario);
        }
    }
}
