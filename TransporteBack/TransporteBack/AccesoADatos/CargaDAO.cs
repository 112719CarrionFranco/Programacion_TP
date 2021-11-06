using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public List<Camion> GetByFilters(List<Parametro> criterios)
        {
            List<Camion> listCam = new List<Camion>();
            DataTable tabla = HelperDAO.ObtenerInstancia().ConsultaTablaParam("SP_CONSULTAR_CAMIONES", criterios);

            foreach (DataRow row in tabla.Rows)
            {
                Camion oCamion = new Camion();
                oCamion.Patente = row["PATENTE"].ToString();
                oCamion.Estado = row["ESTADO"].ToString();
                oCamion.PesoMaximo = Convert.ToInt32(row["PESO_MAXIMO"].ToString());
                oCamion.Marca = row["MARCA"].ToString();
                oCamion.Modelo = row["MODELO"].ToString();
                listCam.Add(oCamion);
            }

            return listCam;
        }

        public DataTable GetByFilterSP(string sp)
        {
            return HelperDAO.ObtenerInstancia().ConsultaSQL(sp);
        }


        public bool SaveBajaCamion(string patente)
        {
            return HelperDAO.ObtenerInstancia().DeleteById("SP_ELIMINAR_CAMION", patente);
        }
    }
}
