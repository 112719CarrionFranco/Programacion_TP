using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporteBack.Servicios;
using TrasnporteDeCargas.Dominio;

namespace TransporteBack.AccesoADatos
{
    public interface ICargaDAO
    {
        public int ObtenerProximoNroCarga();
        public DataTable ListarProductos();
        public bool Crear(Carga oCarga);
        public Carga ObtenerCargaPorID(int nro);
        public List<Carga> ConsultarCarga(List<Parametro> criterios);
        public bool RegistrarBajaCarga(int nroCarga);
        public bool ActualizarCarga(Carga oCarga);
        public bool ControlUsuarios(string usuario, string pass);
        public bool GuardarCamion(Camion oCamion);
        public List<Camion> GetByFilters(List<Parametro> criterios);
        public bool SaveBajaCamion(string patente);
        public List<Camion> GetByFiltersSP(string sp);


    }
}
