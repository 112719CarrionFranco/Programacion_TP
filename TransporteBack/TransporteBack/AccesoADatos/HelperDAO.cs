using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransporteBack.Dominio;
using TransporteBack.Servicios;
using TrasnporteDeCargas.Dominio;

namespace TransporteBack.AccesoADatos
{
    class HelperDAO
    {
        private static HelperDAO instancia;
        private string cadenaConexion;
        private HelperDAO()
        {
            cadenaConexion = @"Data Source=PC\SQLEXPRESS;Initial Catalog=Transporte_Cargas;Integrated Security=True";
        }

        public static HelperDAO ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDAO();
            }
            return instancia;
        }

        public DataTable ConsultaSQL(string nombreSP)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = cadenaConexion;
                cnn.Open();

                // Command Productos
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;

                tabla.Load(cmd.ExecuteReader());

                return tabla;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

        }

        //public List<Camion> GetByFilterSP()
        //{
        //    List<Camion> lst = new List<Camion>();
        //    SqlConnection cnn = new SqlConnection();
        //    cnn.ConnectionString = cadenaConexion;


        //    cnn.Open();
        //    SqlCommand cmd2 = new SqlCommand("SP_CONSULTAR_CAMIONES_SINP", cnn);

        //    cmd2.CommandType = CommandType.StoredProcedure;

        //    DataTable table = new DataTable();
        //    table.Load(cmd2.ExecuteReader());

        //    cnn.Close();

        //    foreach (DataRow row in table.Rows)
        //    {
        //        Camion oCamion = new Camion();
        //        oCamion.Patente = (row["PATENTE"].ToString());
        //        oCamion.PesoMaximo = Convert.ToInt32(row["PESO_MAXIMO"].ToString());
        //        oCamion.Marca = (row["MARCA"].ToString());
        //        oCamion.Modelo = (row["MODELO"].ToString());
        //        lst.Add(oCamion);
        //    }

        //    return lst;
        //}

        public int ProximoID(string nombreSP, string nombreParametro)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlParameter param = new SqlParameter();

            try
            {
                cnn.ConnectionString = cadenaConexion;
                cnn.Open();

                // Command proximo ID
                cmd.Connection = cnn;

                // Command Type para el Tipo de COmando que quiero ejecutar
                // cmd.CommandText = CommandType.Text;  ejecutamos sql como texto plano
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;

                param.ParameterName = nombreParametro;
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(param);
                cmd.ExecuteReader(); // no estoy esperando que el SP me devuelva un SELECT

                return (int)param.Value;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        public int EjecutarSQL(string nombreSP, Dictionary<string, object> parametros)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction trans = null;
            try
            {
                cnn.ConnectionString = cadenaConexion;
                cnn.Open();

                // Command proximo ID
                cmd.Connection = cnn;
                trans = cnn.BeginTransaction();

                // Command Type para el Tipo de COmando que quiero ejecutar
                // cmd.CommandText = CommandType.Text;  ejecutamos sql como texto plano
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;

                cmd.Transaction = trans;

                foreach (KeyValuePair<string, object> item in parametros)
                {
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                int filasAfectadas = cmd.ExecuteNonQuery();
                trans.Commit();
                return filasAfectadas;
            }
            catch (SqlException ex)
            {
                trans.Rollback();
                throw (ex);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        } // Botta

        public bool Save(Carga oCarga)
        {
            SqlConnection cnn = new SqlConnection();
            SqlTransaction trans = null;
            bool resultado = true;

            try
            {
                cnn.ConnectionString = cadenaConexion;
                cnn.Open();
                trans = cnn.BeginTransaction();

                SqlCommand cmd = new SqlCommand("SP_INSERTAR_MAESTRO", cnn, trans);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PATENTE", oCarga.Patente);
                cmd.Parameters.AddWithValue("@TOTAL_KG", oCarga.PesoTotal);

                SqlParameter param = new SqlParameter("@ID_CARGA", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int IdCarga = Convert.ToInt32(param.Value);
                int cDetalles = 1; // es el ID que forma de la PK doble entre ID_PRESUPUESTO E ID_DETALLE
                


                foreach (DetalleCargas det in oCarga.Detalles)
                {
                    SqlCommand cmdDet = new SqlCommand("SP_INSERTAR_DETALLE", cnn);
                    cmdDet.CommandType = CommandType.StoredProcedure;
                    cmdDet.Transaction = trans;
                    cmdDet.Parameters.AddWithValue("@ID_CARGA", IdCarga);
                    cmdDet.Parameters.AddWithValue("@DETALLE_NRO", cDetalles);
                    cmdDet.Parameters.AddWithValue("@ID_TIPO_CARGA", det.TipoCarga.IdTipoCarga);
                    cmdDet.Parameters.AddWithValue("@CANTIDAD", det.Cantidad);
                    cmdDet.Parameters.AddWithValue("@PESO", det.TipoCarga.Peso);
                    cmdDet.ExecuteNonQuery();

                    cDetalles++;
                }


                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                resultado = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }


            return resultado;
        }

        public Carga GetById(int id)
        {
            Carga oCarga = new Carga();
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = cadenaConexion;
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CONSULTAR_CARGA_POR_ID";
            cmd.Parameters.AddWithValue("@carga_nro", id);
            SqlDataReader reader = cmd.ExecuteReader();
            bool esPrimerRegistro = true;

            while (reader.Read())
            {
                if (esPrimerRegistro)
                {
                    //solo para el primer resultado recuperamos los datos del MAESTRO:
                    oCarga.IdCarga = Convert.ToInt32(reader["carga_nro"].ToString());
                    oCarga.PesoTotal = Convert.ToInt32(reader["peso"].ToString());
                    oCarga.Fecha = Convert.ToDateTime(reader["fecha"].ToString());
                    oCarga.Patente = (reader["patente"].ToString());
                    esPrimerRegistro = false;
                }

                DetalleCargas oDetalle = new DetalleCargas();
                TipoCarga oTipoCarga = new TipoCarga();
                oTipoCarga.IdTipoCarga = Convert.ToInt32(reader["id_tipoCarga"].ToString());
                oTipoCarga.Nombre = reader["nombreTC"].ToString();
                oTipoCarga.Peso = Convert.ToInt32(reader["peso"].ToString());
                oDetalle.TipoCarga = oTipoCarga;
                oDetalle.Cantidad = Convert.ToInt32(reader["cantidad"].ToString());
                esPrimerRegistro = false;
                oCarga.AgregarDetalle(oDetalle);
            }
            return oCarga;
        }

        public bool Delete(int idCarga)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = cadenaConexion;
            SqlTransaction t = null;
            int affected = 0;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("[SP_ELIMINAR_CARGA]", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_Carga", idCarga);
                affected = cmd.ExecuteNonQuery();


                SqlCommand cmd2 = new SqlCommand("[SP_ELIMINAR_DETALLE_CARGA]", cnn, t);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@id_Carga", idCarga);
                affected = cmd.ExecuteNonQuery();
                t.Commit();

            }
            catch (SqlException)
            {
                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return affected == 1;
        }

        public List<Carga> GetByFilters(List<Parametro> criterios)
        {
            List<Carga> lst = new List<Carga>();
            DataTable table = new DataTable();
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = cadenaConexion;
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("[SP_CONSULTAR_CARGAS]", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (Parametro p in criterios)
                {
                    cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
                }

                table.Load(cmd.ExecuteReader());
                //mappear los registros como objetos del dominio:

                foreach (DataRow row in table.Rows)
                {
                    //Por cada registro creamos un objeto del dominio
                    Carga oCarga = new Carga();
                    oCarga.Patente = row["PATENTE"].ToString();
                    oCarga.Fecha = Convert.ToDateTime(row["FECHA"].ToString());
                    oCarga.PesoTotal = Convert.ToInt32(row["TOTAL_KG"].ToString());
                    oCarga.IdCarga = Convert.ToInt32(row["ID_CARGA"].ToString());
                    lst.Add(oCarga);
                }

                cnn.Close();
            }
            catch (SqlException)
            {
                lst = null;
            }
            return lst;
        }

        public bool Update(Carga oCarga)
        {
            bool resultado = true;
            SqlConnection cnn = new SqlConnection();
            SqlTransaction trans = null;

            try
            {
                cnn.ConnectionString = cadenaConexion;
                cnn.Open();
                trans = cnn.BeginTransaction();

                SqlCommand cmd = new SqlCommand("SP_UPDATE_CARGAS", cnn, trans);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_carga", oCarga.IdCarga);
                cmd.Parameters.AddWithValue("@patente", oCarga.Patente);
                cmd.Parameters.AddWithValue("@total_kg", oCarga.PesoTotal);
                cmd.ExecuteNonQuery();

                SqlCommand cmdElimnar = new SqlCommand("SP_ELIMINAR_DETALLE_PRESUPUESTO", cnn, trans);
                cmdElimnar.CommandType = CommandType.StoredProcedure;
                cmdElimnar.Parameters.AddWithValue("@id_carga", oCarga.IdCarga);
                cmdElimnar.ExecuteNonQuery();


                int cDetalles = 1; // es el ID que forma de la PK doble entre ID_PRESUPUESTO E ID_DETALLE
                foreach (DetalleCargas det in oCarga.Detalles)
                {
                    SqlCommand cmdDet = new SqlCommand("SP_INSERTAR_DETALLE", cnn);
                    cmdDet.CommandType = CommandType.StoredProcedure;
                    cmdDet.Transaction = trans;
                    cmdDet.Parameters.AddWithValue("@ID_CARGA", oCarga.IdCarga);
                    cmdDet.Parameters.AddWithValue("@DETALLE_NRO", cDetalles);
                    cmdDet.Parameters.AddWithValue("@ID_TIPO_CARGA", det.TipoCarga.IdTipoCarga);
                    cmdDet.Parameters.AddWithValue("@CANTIDAD", det.Cantidad);
                    cmdDet.Parameters.AddWithValue("@PESO", det.TipoCarga.Peso);
                    cmdDet.ExecuteNonQuery();

                    cDetalles++;
                }

                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                resultado = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return resultado;
        }

        public bool ControlUsuarios(string usuario, string contraseña)
        {

            bool flag = false;
            SqlConnection cnn = new SqlConnection();
            int resultado;
           
            cnn.ConnectionString = cadenaConexion;
            cnn.Open();

            SqlCommand cmdControl = new SqlCommand("SP_CONTROL_USUARIO", cnn);
            cmdControl.CommandType = CommandType.StoredProcedure;
            cmdControl.Parameters.AddWithValue("@usuario", usuario);
            cmdControl.Parameters.AddWithValue("@pass", contraseña);
            SqlDataReader dr = cmdControl.ExecuteReader();

            if (dr.Read())
            {
                flag = true;
            }

            if (cnn != null && cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            
            return flag;
        }

        public bool GuardarCamion(Camion oCamion)
        {
            SqlConnection cnn = new SqlConnection();
            SqlTransaction trans = null;
            bool resultado = true;

            try
            {
                cnn.ConnectionString = cadenaConexion;
                cnn.Open();
                trans = cnn.BeginTransaction();

                SqlCommand cmd = new SqlCommand("SP_INSERTAR_CAMIONES", cnn, trans);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@patente", oCamion.Patente);
                cmd.Parameters.AddWithValue("@estado", oCamion.Estado);
                cmd.Parameters.AddWithValue("@peso_max", oCamion.PesoMaximo);
                cmd.Parameters.AddWithValue("@marca", oCamion.Marca);
                cmd.Parameters.AddWithValue("@modelo", oCamion.Modelo);

                cmd.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                resultado = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return resultado;
        }

        

        public DataTable ConsultaTablaParam(string storeName, List<Parametro> criterios)
        {
            List<Camion> lst = new List<Camion>();
            DataTable tabla = new DataTable();
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = cadenaConexion;

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(storeName, cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (Parametro param in criterios)
                {
                    if (param.Valor == null)
                        cmd.Parameters.AddWithValue(param.Nombre, DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue(param.Nombre, param.Valor.ToString());
                }

                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return tabla;

        }

        public bool DeleteById(string storeName, string patente)
        {
            
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = cadenaConexion;
            bool rta = true;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(storeName, cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@patente", patente);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return rta;
        }
    }
}
