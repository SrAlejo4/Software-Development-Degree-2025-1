using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    public class ExcursionBarco : Excursion
    {
        private int NumDiasViaje;
        private int NumDiasEstadia;
        private string TipoCamarote;
        private string TipoHabitacion;
        private double TransporteMuelle;

        public ExcursionBarco(string Destino, string NombreCliente, long CedulaCliente, DateTime FechaViaje,
                          int NumDiasViaje, int NumDiasEstadia, string TipoCamarote, string TipoHabitacion,
                          double TransporteMuelle)
        : base(Destino, NombreCliente, CedulaCliente, FechaViaje)
        {
            this.NumDiasViaje = NumDiasViaje;
            this.NumDiasEstadia = NumDiasEstadia;
            this.TipoCamarote = TipoCamarote;
            this.TipoHabitacion = TipoHabitacion;
            this.TransporteMuelle = TransporteMuelle;
        }

        public int getNumDiasViaje()
        {
            return NumDiasViaje;
        }
        public void setNumDiasViaje(int NumDiasViaje)
        {
            this.NumDiasViaje = NumDiasViaje;
        }
        public int getNumDiasEstadia()
        {
            return NumDiasEstadia;
        }
        public void setNumDiasEstadia(int NumDiasEstadia)
        {
            this.NumDiasEstadia = NumDiasEstadia;
        }
        public string getTipoCamarote()
        {
            return TipoCamarote;
        }
        public void setTipoCamarote(string TipoCamarote)
        {
            this.TipoCamarote = TipoCamarote;
        }
        public string getTipoHabitacion()
        {
            return TipoHabitacion;
        }
        public void setTipoHabitacion(string TipoHabitacion)
        {
            this.TipoHabitacion = TipoHabitacion;
        }
        public double getTransporteMuelle()
        {
            return TransporteMuelle;
        }
        public void setTransporteMuelle(double TransporteMuelle)
        {
            this.TransporteMuelle = TransporteMuelle;
        }
        public override double CalcularCosto()
        {
            double costoCamarote = 0;
            if (TipoCamarote.ToLower() == "lujo")
                costoCamarote = 70000;
            else if (TipoCamarote.ToLower() == "normal")
                costoCamarote = 60000;
            else if (TipoCamarote.ToLower() == "economico")
                costoCamarote = 40000;

            double costoHabitacion = (TipoHabitacion.ToLower() == "suite") ? 90000 : 55000;

            return (NumDiasViaje * costoCamarote) + (NumDiasEstadia * costoHabitacion) + TransporteMuelle;
        }
    }
}
