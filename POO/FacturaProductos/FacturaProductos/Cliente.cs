using System;
using System.Collections.Generic;

namespace FacturaProductos
{
    public class Cliente
    {
        private string cedula;
        private string nombre;

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
