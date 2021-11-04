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
using TrasnporteDeCargas.Dominio;

namespace TransporteFront.gui
{
    public partial class Frm_Alta_Camion : Form
    {
        Camion oCamion = new Camion();
        private IService servicio;

        public Frm_Alta_Camion()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearService();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpìar_Click(object sender, EventArgs e)
        {
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPatente.Text = "";
            txtEstado.Text = "";
            txtPMax.Text = "";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Agregar camion
            //DialogResult result = MessageBox.Show("Desea Agregar a la flota?", "Confirmación", MessageBoxButtons.YesNo);
            

            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                MessageBox.Show("Falta ingresar la marca del Camion", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMarca.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                MessageBox.Show("Falta ingresar el modelo del Camion", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModelo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPatente.Text))
            {
                MessageBox.Show("Falta ingresar la patente del Camion", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPatente.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtEstado.Text))
            {
                MessageBox.Show("Debe ingreaar el estado del camion", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEstado.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPMax.Text))
            {
                MessageBox.Show("Debe ingresar el peso maximo", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPMax.Focus();
                return;
            }


            oCamion.Patente = txtPatente.Text;
            oCamion.Marca = txtMarca.Text;
            oCamion.Modelo = txtModelo.Text;
            oCamion.PesoMaximo = Convert.ToInt32(txtPMax.Text);
            oCamion.Estado = txtEstado.Text;

            if (servicio.GuardarCamion(oCamion))
            {
                MessageBox.Show("Camion guardado con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error al intentar agregar el camion a la flota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
