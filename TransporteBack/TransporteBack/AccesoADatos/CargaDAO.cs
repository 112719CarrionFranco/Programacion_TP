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
    class CargaDAO : ICargaDAO
    {
        public bool GuardarCamion(Camion oCamion)
        {
            return HelperDAO.ObtenerInstancia().GuardarCamion(oCamion);
        }
        public bool ActualizarCarga(Carga oCarga)
        {
            return HelperDAO.ObtenerInstancia().Update(oCarga);
        }

        public List<Carga> ConsultarCarga(List<Parametro> criterios)
        {
            return HelperDAO.ObtenerInstancia().GetByFilters(criterios);
        }

        public bool ControlUsuarios(string usuario, string pass)
        {
            return HelperDAO.ObtenerInstancia().ControlUsuarios(usuario, pass);
        }

        public bool Crear(Carga oCarga)
        {
            return HelperDAO.ObtenerInstancia().Save(oCarga);
        }

        public DataTable ListarProductos()
        {
            return HelperDAO.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_TIPO_CARGAS");
        }

        public Carga ObtenerCargaPorID(int nro)
        {
            return HelperDAO.ObtenerInstancia().GetById(nro);
        }

        public int ObtenerProximoNroCarga()
        {
            return HelperDAO.ObtenerInstancia().ProximoID("SP_PROXIMO_ID", "@next");
        }

        public bool RegistrarBajaCarga(int nroCarga)
        {
            return HelperDAO.ObtenerInstancia().Delete(nroCarga);
        }

        public List<Camion> ConsultarCamiones(List<Parametro> criterios)
        {
            return HelperDAO.ObtenerInstancia().GetCamiones(criterios);
        }
    }
}
