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
            List<Camion> lst = servicio.ConsultarCamionesSP();

            //source es una lista de objetos
            cboCamion.DataSource = lst;
            //valueMember y DisplayMember serán las properties de los objetos
            cboCamion.ValueMember = "PATENTE";
            cboCamion.DisplayMember = "Camion";
            //Revisar cbo para que meustre la carga maxima y desp hacer la validacion para que no deje salir sin el 75% o pasado de peso
            //lblCargaMaxima.Text = "Carga Maxima: " + oCamion.PesoMaximo;

        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_Alta_Cargas_Load(object sender, EventArgs e)
        {
            CargarComboCamion();
        }
    }
}
