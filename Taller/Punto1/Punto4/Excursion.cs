using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    public abstract class Excursion
    {
        private string Destino;
        private string NombreCliente;
        private long CedulaCliente;
        private DateTime FechaViaje;

        public Excursion(string Destino, string NombreCliente, long CedulaCliente, DateTime FechaViaje)
        {
            this.Destino = Destino;
            this.NombreCliente = NombreCliente;
            this.CedulaCliente = CedulaCliente;
            this.FechaViaje = FechaViaje;
        }
        public string getDestino()
        {
            return Destino;
        }
        public void setDestino(string Destino)
        {
            this.Destino = Destino;
        }
        public string getNombreCliente()
        {
            return NombreCliente;
        }
        public void setNombreCliente(string NombreCliente)
        {
            this.NombreCliente = NombreCliente;
        }
        public long getCedulaCliente()
        {
            return CedulaCliente;
        }
        public void setCedulaCliente(long CedulaCliente)
        {
            this.CedulaCliente = CedulaCliente;
        }
        public DateTime getFechaViaje()
        {
            return FechaViaje;
        }
        public void setFechaViaje(DateTime FechaViaje)
        {
            this.FechaViaje = FechaViaje;
        }

        public abstract double CalcularCosto();

    }
}
