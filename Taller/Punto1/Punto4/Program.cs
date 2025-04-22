using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Destino = GeneralIO.lea("Ingrese el destino:");
            string NombreCliente = GeneralIO.lea("Ingrese el nombre del cliente:");
            long CedulaCliente = long.Parse(GeneralIO.lea("Ingrese la cédula del cliente:"));
            DateTime FechaViaje = DateTime.Parse(GeneralIO.lea("Ingrese la fecha del viaje (YYYY-MM-DD):"));
            int tipoExcursion = Int32.Parse(GeneralIO.lea("Seleccione el tipo de excursión (1. Barco, 2. Avión):"));

            Excursion excursion;

            switch (tipoExcursion)
            {
                case 1:
                    int numDiasViaje = Int32.Parse(GeneralIO.lea("Ingrese el número de días de viaje:"));
                    string tipoCamarote = GeneralIO.lea("Ingrese el tipo de camarote (lujo, normal, economica):");
                    int numDiasEstadia = Int32.Parse(GeneralIO.lea("Ingrese el número de días de estadía:"));
                    string tipoHabitacion = GeneralIO.lea("Ingrese el tipo de habitación (suite, normal):");
                    double transporteMuelle = Double.Parse(GeneralIO.lea("Ingrese el valor del transporte al muelle:"));

                    excursion = new ExcursionBarco(Destino, NombreCliente, CedulaCliente, FechaViaje, numDiasViaje, numDiasEstadia, tipoCamarote, tipoHabitacion, transporteMuelle);
                    break;

                case 2:
                    double valorMinutoVuelo = Double.Parse(GeneralIO.lea("Ingrese el valor por minuto de vuelo:"));
                    int minutosVuelo = Int32.Parse(GeneralIO.lea("Ingrese la cantidad de minutos de vuelo:"));
                    double tasaAeroportuaria = Double.Parse(GeneralIO.lea("Ingrese el valor de la tasa aeroportuaria:"));
                    double transporteAeropuerto = Double.Parse(GeneralIO.lea("Ingrese el valor del transporte al aeropuerto:"));

                    excursion = new ExcursionAvion(Destino, NombreCliente, CedulaCliente, FechaViaje, valorMinutoVuelo, minutosVuelo, tasaAeroportuaria, transporteAeropuerto);
                    break;

                default:
                    GeneralIO.imp("Opción inválida.");
                    return;
            }

            GeneralIO.imp($"El costo total de la excursión para " + NombreCliente + " es: " + excursion.CalcularCosto());
        }
    }
}
