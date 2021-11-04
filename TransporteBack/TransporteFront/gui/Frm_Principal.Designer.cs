
namespace TransporteFront.gui
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCamionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFlotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCargasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCargasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTipoDeCargasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTipoDeCargasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.camionesToolStripMenuItem,
            this.cargasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // camionesToolStripMenuItem
            // 
            this.camionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCamionesToolStripMenuItem,
            this.consultarFlotaToolStripMenuItem});
            this.camionesToolStripMenuItem.Name = "camionesToolStripMenuItem";
            this.camionesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.camionesToolStripMenuItem.Text = "Camiones";
            // 
            // agregarCamionesToolStripMenuItem
            // 
            this.agregarCamionesToolStripMenuItem.Name = "agregarCamionesToolStripMenuItem";
            this.agregarCamionesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.agregarCamionesToolStripMenuItem.Text = "Agregar Camiones ";
            this.agregarCamionesToolStripMenuItem.Click += new System.EventHandler(this.agregarCamionesToolStripMenuItem_Click);
            // 
            // consultarFlotaToolStripMenuItem
            // 
            this.consultarFlotaToolStripMenuItem.Name = "consultarFlotaToolStripMenuItem";
            this.consultarFlotaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.consultarFlotaToolStripMenuItem.Text = "Consultar Flota";
            this.consultarFlotaToolStripMenuItem.Click += new System.EventHandler(this.consultarFlotaToolStripMenuItem_Click);
            // 
            // cargasToolStripMenuItem
            // 
            this.cargasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCargasToolStripMenuItem,
            this.consultarCargasToolStripMenuItem,
            this.agregarTipoDeCargasToolStripMenuItem,
            this.consultarTipoDeCargasToolStripMenuItem});
            this.cargasToolStripMenuItem.Name = "cargasToolStripMenuItem";
            this.cargasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cargasToolStripMenuItem.Text = "Cargas";
            // 
            // agregarCargasToolStripMenuItem
            // 
            this.agregarCargasToolStripMenuItem.Name = "agregarCargasToolStripMenuItem";
            this.agregarCargasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.agregarCargasToolStripMenuItem.Text = "Agregar Cargas";
            this.agregarCargasToolStripMenuItem.Click += new System.EventHandler(this.agregarCargasToolStripMenuItem_Click);
            // 
            // consultarCargasToolStripMenuItem
            // 
            this.consultarCargasToolStripMenuItem.Name = "consultarCargasToolStripMenuItem";
            this.consultarCargasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.consultarCargasToolStripMenuItem.Text = "Consultar Cargas";
            this.consultarCargasToolStripMenuItem.Click += new System.EventHandler(this.consultarCargasToolStripMenuItem_Click);
            // 
            // agregarTipoDeCargasToolStripMenuItem
            // 
            this.agregarTipoDeCargasToolStripMenuItem.Name = "agregarTipoDeCargasToolStripMenuItem";
            this.agregarTipoDeCargasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.agregarTipoDeCargasToolStripMenuItem.Text = "Agregar Tipo de Cargas";
            this.agregarTipoDeCargasToolStripMenuItem.Click += new System.EventHandler(this.agregarTipoDeCargasToolStripMenuItem_Click);
            // 
            // consultarTipoDeCargasToolStripMenuItem
            // 
            this.consultarTipoDeCargasToolStripMenuItem.Name = "consultarTipoDeCargasToolStripMenuItem";
            this.consultarTipoDeCargasToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.consultarTipoDeCargasToolStripMenuItem.Text = "Consultar Tipo de cargas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.Text = "SGC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem camionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCamionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFlotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCargasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCargasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTipoDeCargasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTipoDeCargasToolStripMenuItem;
    }
}