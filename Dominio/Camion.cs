using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrasnporteDeCargas.Dominio
{
    public class Camion
    {
        public string Patente { get; set; }
        public bool Estado { get; set; }
        public int PesoMaximo { get; set; }
        public List<TipoCarga> Detalles { get; }

        public Camion()
        {
            // Generar la relacion 1 a muchos
            Detalles = new List<TipoCarga>();
        }

        // Funcion para agregar los detalles del mismo presupuesto a una lista
        // pq un presupuesto tiene muchos detalles
        public void AgregarDetalle(TipoCarga detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int nro)
        {
            Detalles.RemoveAt(nro);
        }










    }
}
