using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facuracion
{
    public class Producto
    {
        private int codigo;
        private string nombre;
        private double valorUnitario;
        private int stock;
        private int cantidadRegistro;
        private double descuento;

        public Producto() { }
        public Producto(int codigo, string nombre, double valorUnitario, int stock, double descuento)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.valorUnitario = valorUnitario;
            this.stock = stock;
            this.descuento = descuento;
        }

        public int Codigo {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }

        public double ValorUnitario
        {
            get { return valorUnitario; }
            set { valorUnitario = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public int CantidadRegistro 
        {
            get { return cantidadRegistro; }
            set { cantidadRegistro = value;  }
        }

        public double Descuento {
            set { descuento = value; }
        }

        public double calcularDescuento() 
        {
            return (calcularSubTotal() * (descuento / 100));
        }

        public double calcularSubTotal()
        { 
            return (cantidadRegistro * valorUnitario) ;
        }

    }
}

