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

        private async void btnBuscar_Click(object sender, EventArgs e)
        {

            List<Parametro> filtros = new List<Parametro>();

            object val = DBNull.Value;
            if (!String.IsNullOrEmpty(txtPatente.Text))
                val = txtPatente.Text;
            filtros.Add(new Parametro("@patente", val));


            if (!String.IsNullOrEmpty(txtEstado.Text))
                filtros.Add(new Parametro("@estado", txtEstado.Text));

            List<Camion> lst = null;

            string filtrosJSON = JsonConvert.SerializeObject(filtros);
            string url = "https://localhost:44311/api/Cargas/consultar";

            var resultado = await ClienteSingleton.GetInstancia().PostAsync(url, filtrosJSON);

            lst = JsonConvert.DeserializeObject<List<Camion>>(resultado);


            lst = servicio.ConsultarCamiones(filtros);
            dgvCamiones.Rows.Clear();
            foreach (Camion oCamion in lst)
            {
                dgvCamiones.Rows.Add(new object[]{
                                        oCamion.Patente,
                                        oCamion.Estado,
                                        oCamion.PesoMaximo,
                 }); ;
            }



        }
    }
}
