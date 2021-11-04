using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrasnporteDeCargas.Dominio
{
    public class TipoCarga
    {

        public int IdTipoCarga { get; set; }
        public string Nombre { get; set; }
        public double Peso { get; set; }

        public TipoCarga()
        {
            

        }

        public override string ToString()
        {

            return IdTipoCarga.ToString() + "-" + Nombre + "-" + Peso.ToString();

        }
    }
}
