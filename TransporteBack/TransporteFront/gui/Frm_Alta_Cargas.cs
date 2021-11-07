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
using TransporteBack.Dominio;
using TransporteBack.Servicios;
using TransporteFront.cliente;
using TrasnporteDeCargas.Dominio;

namespace TransporteFront.gui
{
    public partial class Frm_Alta_Cargas : Form
    {
        Carga oCarga = new Carga();
        Camion oCamion = new Camion();
        private IService servicio;
        public Frm_Alta_Cargas()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearService();
        }

        private void CargarComboCamion()
        {
            DataTable tabla = servicio.ConsultarSP("SP_CONSULTAR_CAMIONES_SINP");

            //source es una lista de objetos
            cboCamion.DataSource = tabla;
            cboCamion.ValueMember = tabla.Columns[0].ColumnName; //patente
            cboCamion.DisplayMember = tabla.Columns[0].ColumnName; //patente
            //Revisar cbo para que meustre la carga maxima y desp hacer la validacion para que no deje salir sin el 75% o pasado de peso
            //lblCargaMaxima.Text = "Carga Maxima: " + tabla.Columns[2]();

        }

        private void CargarComboCarga()
        {
            DataTable tabla = servicio.ConsultarSP("SP_CONSULTAR_TIPO_CARGAS");

            //source es una lista de objetos
            cboCarga.DataSource = tabla;
            cboCarga.DisplayMember = tabla.Columns[1].ColumnName; //NOMBRE
            cboCarga.ValueMember = tabla.Columns[0].ColumnName; //ID_TIPO_CARGA

        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_Alta_Cargas_Load(object sender, EventArgs e)
        {
            CargarComboCamion();
            CargarComboCarga();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (ExisteProductoEnGrilla(cboCarga.Text))
            //{
            //    MessageBox.Show("Producto ya agregado como detalle", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}


            DialogResult result = MessageBox.Show("Desea Agregar?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                
                DetalleCargas item = new DetalleCargas();
                item.Cantidad = Convert.ToInt32(nudCarga.Value);

                DataRowView oDataRow = (DataRowView)cboCarga.SelectedItem;

                TipoCarga oTipoCarga = new TipoCarga(); ;
                oTipoCarga.IdTipoCarga = Int32.Parse(oDataRow[0].ToString());
                oTipoCarga.Nombre = oDataRow[1].ToString();
                oTipoCarga.Peso = Convert.ToInt32(oDataRow[2].ToString());
                item.TipoCarga = oTipoCarga;

                oCarga.AgregarDetalle(item);

                // te voy a dar un array de objetos
                dgvDetalles.Rows.Add(new object[] { "", oTipoCarga.Nombre, oTipoCarga.Peso, item.Cantidad, item.CalcularPesoTotal() });

                calcularPesosTotales();
            }
        }

        private int calcularPesosTotales()
        {
            int peso = oCarga.CalcularTotal();
            lblPesoTotal.Text = "Peso Total: " + peso.ToString() + " KG";
            return peso;
        }

        private bool ExisteProductoEnGrilla(object tipoCarga)
        {
            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                string col = fila.Cells["tipo_Carga"].Value.ToString();
                if (col.Equals(tipoCarga))
                {
                    return true;
                }
            }
            return false;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            oCarga.PesoTotal = Convert.ToInt32(calcularPesosTotales());
            oCarga.Patente = (cboCamion.Text);
            var saveOK = await RegistrarCargaAsync(oCarga);

            if (saveOK)
            {
                MessageBox.Show("Carga registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la carga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //para meter el update
            //if (banderaUpdate)
            //{
            //    if (gestor.ActualizarPresupuesto(oPresupuesto))
            //    {
            //        MessageBox.Show("Presupuesto Actualizado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Dispose();
            //    }
            //    else
            //    {
            //        MessageBox.Show("ERROR. No se pudo registrar el presupuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    if (servicio.Crear(oCarga))
            //    {
            //        MessageBox.Show("Carga registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Dispose();
            //    }
            //    else
            //    {
            //        MessageBox.Show("ERROR. No se pudo registrar la carga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private async Task<bool> RegistrarCargaAsync(Carga oCarga)
        {
            string url = "https://localhost:44311/api/Cargas/registro";
            string json = JsonConvert.SerializeObject(oCarga);
            var result = await ClienteSingleton.GetInstance().PostAsync(url, json);
            return result.Equals("true");
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 5)
            {
                oCarga.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                calcularPesosTotales();
            }
        }

        private void btnLimpìar_Click(object sender, EventArgs e)
        {
            dgvDetalles.Rows.Clear();
            nudCarga.Value = 0;
            cboCamion.SelectedIndex = -1;
        }
    }
}
