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
    public enum Accion
    {
        NUEVO,
        VER,
        EDITAR
    }

    public partial class Frm_Alta_Cargas : Form
    {
        Carga oCarga = new Carga();
        private Accion modo;
        private int nro;
        //El service hay que sacarlo para poner la consulta que llena los combos en la api
        private IService servicio;

        public Frm_Alta_Cargas(Accion modo, int nro)
        {
            InitializeComponent();
            this.modo = modo;
            this.nro = nro;
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
            DialogResult rta = MessageBox.Show("¿Está seguro que desea Cancelar?", "Cancelar",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rta == DialogResult.Yes)
            {
                if (modo.Equals(Accion.NUEVO))
                    LimpiarCampos();
                if (modo.Equals(Accion.EDITAR))
                    this.Dispose();
            }
        }

        private  async void Frm_Alta_Cargas_Load(object sender, EventArgs e)
        {
            

            if (modo.Equals(Accion.NUEVO))
            {
                //para la api despues
                CargarComboCamion();
                CargarComboCarga();
                //await CargarNroCarga();
            }
            //------------------------------------------------------------
            if (modo.Equals(Accion.VER))
            {
                cboCamion.Enabled = false;
                cboCarga.Enabled = false;
                nudCarga.Enabled = false;
                btnAgregar.Enabled = false;
                btnGuardar.Enabled = false;
                btnLimpìar.Enabled = false;
                btnCancelar.Text = "Salir";
                this.Text = "Visualizar Datos de la Carga";
                await CargarConsultaCargaIDAsync(this.nro);
            }
            //------------------------------------------------------------
            if (modo.Equals(Accion.EDITAR))
            {
                CargarComboCamion();
                CargarComboCarga();
                this.Text = "Editar Carga";
                await CargarConsultaCargaIDAsync(this.nro);

            }
        }

        
        private async Task CargarConsultaCargaIDAsync(int idC)
        {
            string url = "https://localhost:44311/api/Cargas/" + nro.ToString();
            var resultado = await ClienteSingleton.GetInstance().GetAsync(url);

            this.oCarga = JsonConvert.DeserializeObject<Carga>(resultado);

            dgvDetalles.Rows.Clear();
            foreach (DetalleCargas oDetalle in oCarga.Detalles)
            {
                dgvDetalles.Rows.Add(new object[]{
                    oDetalle.TipoCarga.IdTipoCarga,
                    oDetalle.TipoCarga.Nombre,
                    oDetalle.TipoCarga.Peso,
                    oDetalle.Cantidad,
                    oDetalle.CalcularPesoTotal(),
                    });
            }

            calcularPesosTotales();
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
            

            if (modo.Equals(Accion.NUEVO))
            {
                if (ValidarCampos())
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
                }
            }
            if (modo.Equals(Accion.EDITAR))
            {
                if (ValidarCampos())
                {
                    oCarga.PesoTotal = Convert.ToInt32(calcularPesosTotales());
                    oCarga.Patente = (cboCamion.Text);

                    var updateOK = await ActualizarCargaAsync(oCarga);

                    if (updateOK)
                    {
                        MessageBox.Show("El Cliente se ha Actualizado con éxito",
                            "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("El Cliente no pudo Actualizarse, consulte al Administrador",
                            "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async Task<bool> ActualizarCargaAsync(Carga oCarga)
        {
            string url = "https://localhost:44311/api/Cargas/actualizar";
            string json = JsonConvert.SerializeObject(oCarga);
            var result = await ClienteSingleton.GetInstance().PostAsync(url, json);
            return result.Equals("true");
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
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            dgvDetalles.Rows.Clear();
            nudCarga.Value = 0;
            cboCamion.SelectedIndex = -1;
        }

        private bool ValidarCampos()
        {
            if (nudCarga.Value == 0)
            {
                MessageBox.Show("Debe Ingresar una cantidad valida",
                    "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudCarga.Focus();
                return false;
            }
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar Al menos una carga",
                    "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvDetalles.Focus();
                return false;
            }
            //if (calcularPesosTotales() < (o))
            //{
            //    MessageBox.Show("Debe ingresar un Apellido de Cliente",
            //        "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtApellido.Focus();
            //    return false;
            //}
            

            return true;
        }

        private void CargaMaxima()
        {
            DataTable tabla = servicio.ConsultarSP("SP_CONSULTAR_CAMIONES_SINP");

            //source es una lista de objetos
            

            //Revisar cbo para que meustre la carga maxima y desp hacer la validacion para que no deje salir sin el 75% o pasado de peso
            //lblCargaMaxima.Text = "Carga Maxima: " + tabla.Columns[2]();

        }

        private void cboCamion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
