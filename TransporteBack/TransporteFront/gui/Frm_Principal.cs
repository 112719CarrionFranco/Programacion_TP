using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransporteFront.gui
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AcercaDe frmAcerca = new Frm_AcercaDe();
            frmAcerca.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void agregarCamionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alta_Camion frmCamionNuevo = new Frm_Alta_Camion();
            frmCamionNuevo.ShowDialog();
        }

        private void consultarFlotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Consultar_Flota frmCFlota = new Frm_Consultar_Flota();
            frmCFlota.ShowDialog();
        }

        private void agregarCargasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alta_Cargas frmAltaCargas = new Frm_Alta_Cargas(Accion.NUEVO,0);
            frmAltaCargas.ShowDialog();
        }

 

        private void consultarCargasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Consulta_Cargas frmConsultaCargas = new Frm_Consulta_Cargas();
            frmConsultaCargas.ShowDialog();
        }
    }
}
