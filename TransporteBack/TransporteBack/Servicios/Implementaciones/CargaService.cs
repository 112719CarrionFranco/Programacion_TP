using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporteBack.AccesoADatos;
using TrasnporteDeCargas.Dominio;

namespace TransporteBack.Servicios.Implementaciones
{
    class CargaService : IService
    {
        private ICargaDAO dao;

        public CargaService()
        {
            dao = new CargaDAO();
        }

        public bool ActualizarCarga(Carga oCarga)
        {
            return dao.ActualizarCarga(oCarga);
        }

        public List<Carga> ConsultarCarga(List<Parametro> criterios)
        {
            return dao.ConsultarCarga(criterios);
        }

        public bool Crear(Carga oCarga)
        {
            return dao.Crear(oCarga);
        }

        public DataTable ListarProductos()
        {
            return dao.ListarProductos();
        }

        public Carga ObtenerCargaPorID(int nro)
        {
            return dao.ObtenerCargaPorID(nro);
        }


        public bool RegistrarBajaCarga(int nroCarga)
        {
            return dao.RegistrarBajaCarga(nroCarga);
        }

        public bool ControlUsuarios(string usuario, string pass)
        {
            return dao.ControlUsuarios(usuario, pass);
        }


        
        public bool GuardarCamion(Camion oCamion)
        {
            return dao.GuardarCamion(oCamion);
        }

        public List<Camion> ConsultarCamiones(List<Parametro> criterios)
        {
            return dao.GetByFilters(criterios);
        }

        public bool RegistrarBajaCamion(string patente)
        {
            return dao.SaveBajaCamion(patente);
        }

        public DataTable ConsultarSP(string sp)
        {
            return dao.GetByFilterSP(sp);
        }

        public int ConsultaPesoMax(string patente)
        {
            return dao.GetPesoMax(patente);
        }

        public int ConsultaEstado(string patente)
        {
            return dao.ConsultarEstado(patente);
        }
    }
}
