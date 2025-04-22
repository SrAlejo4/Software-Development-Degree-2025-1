using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaHerencia
{
    public class Horas : Trabajador
    {
        private int horasTrabajadas;
        private double valorHora;

        public Horas(long cedula, string nombre, double deducciones, int horasTrabajadas, double valorHora)
                            : base(cedula, nombre, deducciones)
        {
            this.horasTrabajadas = horasTrabajadas;
            this.valorHora = valorHora;
        }

        public int HorasTrabajadas
        {
            get { return horasTrabajadas; }
            set { horasTrabajadas = value; }
        }

        public double ValorHora 
        {
            get { return valorHora; }
            set { valorHora = value; }
        }

        public override double salario() //OVERRIDE PERMITE SOBRESCRIBIR EL MÉTODO ABSTRACTO QUE SE HEREDA
        {
            double valorDeduccion = (horasTrabajadas * valorHora) * deducciones/100;
            return horasTrabajadas * valorHora - valorDeduccion;
        }
    }
}
