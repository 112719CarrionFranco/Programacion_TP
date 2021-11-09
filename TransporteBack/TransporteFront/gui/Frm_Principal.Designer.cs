
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCamionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFlotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCargasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCargasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cornsilk;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
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
            this.agregarCamionesToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.agregarCamionesToolStripMenuItem.Name = "agregarCamionesToolStripMenuItem";
            this.agregarCamionesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.agregarCamionesToolStripMenuItem.Text = "Agregar Camiones ";
            this.agregarCamionesToolStripMenuItem.Click += new System.EventHandler(this.agregarCamionesToolStripMenuItem_Click);
            // 
            // consultarFlotaToolStripMenuItem
            // 
            this.consultarFlotaToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.consultarFlotaToolStripMenuItem.Name = "consultarFlotaToolStripMenuItem";
            this.consultarFlotaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.consultarFlotaToolStripMenuItem.Text = "Consultar Flota";
            this.consultarFlotaToolStripMenuItem.Click += new System.EventHandler(this.consultarFlotaToolStripMenuItem_Click);
            // 
            // cargasToolStripMenuItem
            // 
            this.cargasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCargasToolStripMenuItem,
            this.consultarCargasToolStripMenuItem});
            this.cargasToolStripMenuItem.Name = "cargasToolStripMenuItem";
            this.cargasToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.cargasToolStripMenuItem.Text = "Cargas";
            // 
            // agregarCargasToolStripMenuItem
            // 
            this.agregarCargasToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.agregarCargasToolStripMenuItem.Name = "agregarCargasToolStripMenuItem";
            this.agregarCargasToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.agregarCargasToolStripMenuItem.Text = "Agregar Cargas";
            this.agregarCargasToolStripMenuItem.Click += new System.EventHandler(this.agregarCargasToolStripMenuItem_Click);
            // 
            // consultarCargasToolStripMenuItem
            // 
            this.consultarCargasToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.consultarCargasToolStripMenuItem.Name = "consultarCargasToolStripMenuItem";
            this.consultarCargasToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.consultarCargasToolStripMenuItem.Text = "Consultar Cargas";
            this.consultarCargasToolStripMenuItem.Click += new System.EventHandler(this.consultarCargasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TransporteFront.Properties.Resources.Scania_TRANSGOL_03;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 422);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE GESTION DE CARGAS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}