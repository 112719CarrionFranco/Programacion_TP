using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrasnporteDeCargas.Dominio;

namespace TransporteBack.Servicios
{
    public interface IService
    {
        public int ObtenerProximoNroCarga();
        public DataTable ListarProductos();
        public bool Crear(Carga oCarga);
        public Carga ObtenerCargaPorID(int nro);
        public List<Carga> ConsultarCarga(List<Parametro> criterios);
        public List<Camion> ConsultarCamiones(List<Parametro> criterios);
        public bool RegistrarBajaCarga(int nroCarga);
        public bool ActualizarCarga(Carga oCarga);
        public bool ControlUsuarios(string usuario, string pass);
        public bool GuardarCamion(Camion oCamion);
        public bool RegistrarBajaCamion(string patente);
        public List<Camion> ConsultarCamionesSP();

    }
}
