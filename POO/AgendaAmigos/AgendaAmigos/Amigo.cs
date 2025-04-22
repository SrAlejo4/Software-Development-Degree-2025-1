using System;
using System.Collections.Generic;

namespace AgendaAmigos
{
    public class Amigo
    {
        private string codigo;
        private string nombre;
        private string telefono;
        private string correo;
        private string direccion;

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
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

    }
}
