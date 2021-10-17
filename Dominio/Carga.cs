using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrasnporteDeCargas.Dominio
{
    public class Carga
    {
        public double Peso { get; set; }
        public string Tipo { get; set; }

        public Carga()
        {

        }

        public override string ToString()
        {
            return Tipo.ToString() + "-" + Peso;
        }





    }
}
