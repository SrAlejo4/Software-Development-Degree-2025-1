using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    public class ExcursionAvion : Excursion
    {
        private double ValorMinutoVuelo;
        private int MinutosVuelo;
        private double TasaAeroportuaria;
        private double TransporteAeropuerto;

        public ExcursionAvion(string Destino, string NombreCliente, long CedulaCliente, DateTime FechaViaje,
                              double ValorMinutoVuelo, int MinutosVuelo, double TasaAeroportuaria, double TransporteAeropuerto)
                              : base(Destino, NombreCliente, CedulaCliente, FechaViaje)
        {
            this.ValorMinutoVuelo = ValorMinutoVuelo;
            this.MinutosVuelo = MinutosVuelo;
            this.TasaAeroportuaria = TasaAeroportuaria;
            this.TransporteAeropuerto = TransporteAeropuerto;
        }

        public double getValorMinutoVuelo()
        {
            return ValorMinutoVuelo;
        }
        public void setValorMinutoVuelo(double ValorMinutoVuelo)
        {
            this.ValorMinutoVuelo = ValorMinutoVuelo;
        }
        public int getMinutosVuelo()
        {
            return MinutosVuelo;
        }
        public void setMinutosVuelo(int MinutosVuelo)
        {
            this.MinutosVuelo = MinutosVuelo;
        }
        public double getTasaAeroportuaria()
        {
            return TasaAeroportuaria;
        }
        public void setTasaAeroportuaria(double TasaAeroportuaria)
        {
            this.TasaAeroportuaria = TasaAeroportuaria;
        }
        public double getTransporteAeropuerto()
        {
            return TransporteAeropuerto;
        }
        public void setTransporteAeropuerto(double TransporteAeropuerto)
        {
            this.TransporteAeropuerto = TransporteAeropuerto;
        }

        public override double CalcularCosto()
        {
            return (MinutosVuelo * ValorMinutoVuelo) + TasaAeroportuaria + TransporteAeropuerto;
        }
    }
}
