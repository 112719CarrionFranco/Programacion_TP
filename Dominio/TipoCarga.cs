using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrasnporteDeCargas.Dominio
{
    public class TipoCarga
    {
        public Camion Camion { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public TipoCarga()
        {
            Camion = new Camion();
            Codigo = 0;
            Nombre = "";
        }
    }
}
