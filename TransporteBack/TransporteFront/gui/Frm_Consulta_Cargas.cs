﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransporteBack.Servicios;
using TransporteFront.cliente;
using TrasnporteDeCargas.Dominio;

namespace TransporteFront.gui
{
    public partial class Frm_Consulta_Cargas : Form
    {
        private Carga oCarga;
        private IService servicio;

        public Frm_Consulta_Cargas()
        {
            InitializeComponent();
            oCarga = new Carga();
            servicio = new ServiceFactoryImp().CrearService();

        }

        private async Task<List<Carga>> CargarConsultaCargaASYNC(List<Parametro> filtros)
        {
            List<Carga> listCamion = new List<Carga>();

            string filtrosJson = JsonConvert.SerializeObject(filtros);
            string url = "https://localhost:44311/api/Cargas/consultaparamCarga";

            var resultado = await ClienteSingleton.GetInstance().PostAsync(url, filtrosJson);

            listCamion = JsonConvert.DeserializeObject<List<Carga>>(resultado);

            return listCamion;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResultados.Rows.Clear();
            List<Parametro> filtros = new List<Parametro>();

            if (dtpFechaDesde.Value.Date >= dtpFechaHasta.Value.Date)
            {
                MessageBox.Show("Ingrese Fechas Validas");
                return;
            }
            object valor1 = DBNull.Value, valor2 = DBNull.Value, valor3 = DBNull.Value;
            string conBaja = "N";
            //----------------------------------------------
            valor1 = Convert.ToDateTime(dtpFechaDesde.Value.Date);
            filtros.Add(new Parametro("@fecha_desde", valor1));
            //----------------------------------------------
            valor1 = Convert.ToDateTime(dtpFechaHasta.Value.Date);
            filtros.Add(new Parametro("@fecha_hasta", valor1));
            //----------------------------------------------
            if (!String.IsNullOrEmpty(txtPatente.Text))
                valor3 = txtPatente.Text;
            filtros.Add(new Parametro("@patente", valor3));

            List<Carga> lista = await CargarConsultaCargaASYNC(filtros);

            foreach (Carga oCarga in lista)
            {
                dgvResultados.Rows.Add(new object[]{
                    oCarga.IdCarga,
                    oCarga.Fecha,
                    oCarga.Patente,
                    oCarga.PesoTotal,});
            }

            if (dgvResultados.RowCount == 0)
                MessageBox.Show("No Existen Coincidencias para los Parámetros de su Consulta",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvResultados.CurrentRow;

            if (row != null)
            {
                int idCarga = Int32.Parse(row.Cells["idCarga"].Value.ToString()); // fila actual o seleccionada
                if (MessageBox.Show("Seguro que desea eliminar la carga seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool respuesta = servicio.RegistrarBajaCarga(idCarga);

                    if (respuesta)
                    {
                        MessageBox.Show("Presupuesto eliminado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.btnConsultar_Click(null, null);
                    }
                    else
                        MessageBox.Show("Error al intentar borrar el presupuesto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        //private async Task<bool> BajaCargaAsync(int idCarga)
        //{
        //    string url = "https://localhost:44311/api/Cargas/deleteCarga" + idCarga.ToString();
        //    var result = await ClienteSingleton.GetInstance().DeleteAsync(url);
        //    return result.Equals("true");
        //}
    }
}
