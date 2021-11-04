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
            MessageBox.Show("Sistema de gestion de cargas. \nRealizado por Franco Carrion", "SGC",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            Frm_Alta_Cargas frmAltaCargas = new Frm_Alta_Cargas();
            frmAltaCargas.ShowDialog();
        }

        private void consultarCargasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarTipoDeCargasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alta_Tipo_Carga frmAltaTipoCarga = new Frm_Alta_Tipo_Carga();
            frmAltaTipoCarga.ShowDialog();
        }



    }
}
