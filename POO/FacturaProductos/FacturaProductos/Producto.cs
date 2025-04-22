using System;
using System.Collections.Generic;

namespace FacturaProductos
{
    public class Producto
    {
        private string codigo;
        private string nombre;
        private int cantidad;
        private double valorUnitario;
        private double descuento = 0;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double ValorUnitario
        {
            get { return valorUnitario; }
            set { valorUnitario = value; }
        }

        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
    }
}
