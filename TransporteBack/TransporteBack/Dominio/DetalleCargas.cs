using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrasnporteDeCargas.Dominio;

namespace TransporteBack.Dominio
{
    public class DetalleCargas
    {
        public TipoCarga TipoCarga { get; set; }
        
        public int Cantidad { get; set; }

        public DetalleCargas()
        {
            TipoCarga = new TipoCarga();
            Cantidad = 0;
        }

        public int CalcularPesoTotal()
        {
            return TipoCarga.Peso * Cantidad;
        }


    }
}
