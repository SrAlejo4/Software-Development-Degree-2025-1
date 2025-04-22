using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaHerencia
{
    public class Salario : Trabajador
    {
        private double salarioBasico;

        public Salario(long cedula, string nombre, double deducciones, double salarioBasico) 
                            : base(cedula, nombre, deducciones)
        {
            this.salarioBasico = salarioBasico; 
        }

        public double SalarioBasico 
        {
            get { return salarioBasico; }
            set { salarioBasico = value; }
        }

        public override double salario() //OVERRIDE PARA SOBRESCRIBIR MÉTODO HEREDADO
        {
            double valorDeducciones = (salarioBasico * deducciones/100);
            return salarioBasico - valorDeducciones;
        }

    }
}
