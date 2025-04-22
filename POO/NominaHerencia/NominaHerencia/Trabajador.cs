using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaHerencia
{
    public abstract class Trabajador
    {
        private long cedula;
        private string nombre;
        protected double deducciones;

        public Trabajador(long cedula, string nombre, double deducciones)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.deducciones = deducciones;
        }

        public long Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Deducciones
        { 
            get { return deducciones; }
            set { deducciones = value; }
        }

        public abstract double salario(); // MÉTODO ABSTRACTO

    }
}
