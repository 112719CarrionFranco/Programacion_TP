using Newtonsoft.Json;
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
    public partial class Frm_Consultar_Flota : Form
    {
        private IService servicio;

        public Frm_Consultar_Flota()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearService();
        }


        private async void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dgvCamiones.Rows.Clear();
            List<Parametro> filtros = new List<Parametro>();

            object valor1 = DBNull.Value, valor2 = DBNull.Value;
            string conBaja = "N";

            //----------------------------------------------
            if (!String.IsNullOrEmpty(txtPatente.Text))
                valor1 = txtPatente.Text;
            filtros.Add(new Parametro("@patente", valor1));
            //----------------------------------------------
            if (!String.IsNullOrEmpty(txtEstado.Text))
                valor2 = txtEstado.Text;
            filtros.Add(new Parametro("@estado", valor2));

            List<Camion> lista = await CargarConsultaCamionesAsync(filtros);

            foreach (Camion oCamion in lista)
            {
                dgvCamiones.Rows.Add(new object[]{
                    oCamion.Patente,
                    oCamion.Marca,
                    oCamion.Modelo,
                    oCamion.Estado,
                    oCamion.PesoMaximo,
                });
            }

            if (dgvCamiones.RowCount == 0)
                MessageBox.Show("No Existen Coincidencias para los Parámetros de su Consulta",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task<List<Camion>> CargarConsultaCamionesAsync(List<Parametro> filtros)
        {
            List<Camion> listCamion = new List<Camion>();

            string filtrosJson = JsonConvert.SerializeObject(filtros);
            string url = "https://localhost:44311/api/Cargas/consultaparam";

            var resultado = await ClienteSingleton.GetInstance().PostAsync(url, filtrosJson);

            listCamion = JsonConvert.DeserializeObject<List<Camion>>(resultado);

            return listCamion;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvCamiones.CurrentRow;
            if (row != null)
            {
                string patente = (row.Cells["patente"].Value.ToString());

                if (MessageBox.Show("Seguro que desea quitar el camion de la flota?",
                                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool respuesta = await QuitarCamionAsync(patente);

                    if (respuesta)
                    {
                        MessageBox.Show("El Cliente ha sido dado de Baja",
                                        "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.btnConsultar_Click(null, null);
                    }
                    else
                        MessageBox.Show("La Baja de Cliente no pudo realizarse",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task<bool> QuitarCamionAsync(string patente)
        {
            string url = "https://localhost:44311/api/Cargas/" + patente.ToString();
            var result = await ClienteSingleton.GetInstance().DeleteAsync(url);
            return result.Equals("true");
        }
    }
}
