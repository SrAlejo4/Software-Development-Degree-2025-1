using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    public class Usuario
    {
        long id;
        double saldo = 0;
        string nombre = string.Empty;
        string genero = string.Empty;

        public Usuario(long id, double saldo, string nombre, string genero)
        {
            this.id = id;
            this.saldo = saldo;
            this.nombre = nombre;
            this.genero = genero;
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

    }
}