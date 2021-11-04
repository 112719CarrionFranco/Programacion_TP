using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporteBack.Dominio;

namespace TrasnporteDeCargas.Dominio
{
    public class Carga
    {
        public int IdCarga { get; set; }
        public DateTime Fecha { get; set; }
        public double PesoTotal { get; set; }
        public string Patente { get; set; }

        public List<DetalleCargas> Detalles { get; }

        public Carga()
        {
            // Generar la relacion 1 a muchos
            Detalles = new List<DetalleCargas>();
        }

        // Funcion para agregar los detalles del mismo presupuesto a una lista
        // pq un presupuesto tiene muchos detalles
        public void AgregarDetalle(DetalleCargas detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int nro)
        {
            Detalles.RemoveAt(nro);
        }






    }
}
