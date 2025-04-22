using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaHerencia
{
    public class GeneralIo
    {
        public static void imp(string mensaje) 
        {
            Console.WriteLine(mensaje);
        }

        public static void imp(Trabajador obj)
        {
            imp("Los datos del trabajador son: " + 
                    "\nCedula: " + obj.Cedula +
                    "\nNombre: " + obj.Nombre + 
                    "\nTotal a pagar es: " + obj.salario());
        }

        public static string lea(string mensaje) 
        {
            string dato = "";
            imp(mensaje);
            dato = Console.ReadLine();
            return dato;
        }

        public static Trabajador lea() 
        {
            Trabajador obj  = null;
            long cedula = Int64.Parse(lea("Digite la cedula del empleado: "));
            string nombre = lea("Ingrese el nombre del empleado: ");
            int op = Int32.Parse(lea("Digite 1 para Empleado por Horas "+ 
                                                    "y 0 para Empleado con Salario Básico: "));
            double deducciones = Double.Parse(lea("Ingrese el porcentaje de deducciones: "));

            switch (op)
            {
                case 0:
                    double salarioBasico = Double.Parse(lea("Cual es el salario básico: "));
                    obj = new Salario(cedula, nombre, deducciones, salarioBasico);
                    break;
                case 1:
                    int horasTrabajadas = Int32.Parse(lea("Cantidad de horas trabajadas: "));
                    double valorHora = Double.Parse(lea("Valor de la hora: "));
                    obj = new Horas(cedula, nombre, deducciones, horasTrabajadas, valorHora);
                    break;
                default:
                    imp("Opción no válida. Elija 1 o 0");
                    break;
            }
            return obj;
        }
    }
}
