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

namespace TransporteFront.gui
{
    public partial class Frm_Login : Form
    {
        private IService servicio;

        public Frm_Login()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearService();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            
            if(servicio.ControlUsuarios(usuario, contraseña))
            {
                this.Hide();
                Frm_Principal principal = new Frm_Principal();
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            servicio = new ServiceFactoryImp().CrearService();
            txtContraseña.PasswordChar = '*';
        }

     
    }
}
