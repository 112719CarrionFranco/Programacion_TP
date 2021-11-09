
namespace TransporteFront.gui
{
    partial class Frm_Alta_Cargas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Alta_Cargas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumCarga = new System.Windows.Forms.Label();
            this.lblCargaMinima = new System.Windows.Forms.Label();
            this.lblCargaMaxima = new System.Windows.Forms.Label();
            this.lblPesoTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpìar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.idTipoCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_Carga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.nudCarga = new System.Windows.Forms.NumericUpDown();
            this.cboCarga = new System.Windows.Forms.ComboBox();
            this.cboCamion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoForm = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.lblNumCarga);
            this.groupBox1.Controls.Add(this.lblCargaMinima);
            this.groupBox1.Controls.Add(this.lblCargaMaxima);
            this.groupBox1.Controls.Add(this.lblPesoTotal);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnLimpìar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.dgvDetalles);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.nudCarga);
            this.groupBox1.Controls.Add(this.cboCarga);
            this.groupBox1.Controls.Add(this.cboCamion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTipoForm);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblNumCarga
            // 
            this.lblNumCarga.AutoSize = true;
            this.lblNumCarga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumCarga.Location = new System.Drawing.Point(367, 23);
            this.lblNumCarga.Name = "lblNumCarga";
            this.lblNumCarga.Size = new System.Drawing.Size(135, 19);
            this.lblNumCarga.TabIndex = 15;
            this.lblNumCarga.Text = "Numero de carga: ";
            // 
            // lblCargaMinima
            // 
            this.lblCargaMinima.AutoSize = true;
            this.lblCargaMinima.Location = new System.Drawing.Point(392, 87);
            this.lblCargaMinima.Name = "lblCargaMinima";
            this.lblCargaMinima.Size = new System.Drawing.Size(85, 15);
            this.lblCargaMinima.TabIndex = 14;
            this.lblCargaMinima.Text = "Carga Minima:";
            // 
            // lblCargaMaxima
            // 
            this.lblCargaMaxima.AutoSize = true;
            this.lblCargaMaxima.Location = new System.Drawing.Point(392, 72);
            this.lblCargaMaxima.Name = "lblCargaMaxima";
            this.lblCargaMaxima.Size = new System.Drawing.Size(87, 15);
            this.lblCargaMaxima.TabIndex = 13;
            this.lblCargaMaxima.Text = "Carga Maxima:";
            // 
            // lblPesoTotal
            // 
            this.lblPesoTotal.AutoSize = true;
            this.lblPesoTotal.Location = new System.Drawing.Point(392, 327);
            this.lblPesoTotal.Name = "lblPesoTotal";
            this.lblPesoTotal.Size = new System.Drawing.Size(63, 15);
            this.lblPesoTotal.TabIndex = 12;
            this.lblPesoTotal.Text = "Peso Total:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(109, 327);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpìar
            // 
            this.btnLimpìar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpìar.Location = new System.Drawing.Point(206, 327);
            this.btnLimpìar.Name = "btnLimpìar";
            this.btnLimpìar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpìar.TabIndex = 10;
            this.btnLimpìar.Text = "Limpiar";
            this.btnLimpìar.UseVisualStyleBackColor = true;
            this.btnLimpìar.Click += new System.EventHandler(this.btnLimpìar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(300, 327);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoCarga,
            this.tipo_Carga,
            this.peso,
            this.cantidad,
            this.pesoTotal,
            this.accion});
            this.dgvDetalles.Location = new System.Drawing.Point(12, 148);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowTemplate.Height = 25;
            this.dgvDetalles.Size = new System.Drawing.Size(546, 173);
            this.dgvDetalles.TabIndex = 8;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // idTipoCarga
            // 
            this.idTipoCarga.HeaderText = "Column1";
            this.idTipoCarga.Name = "idTipoCarga";
            this.idTipoCarga.ReadOnly = true;
            this.idTipoCarga.Visible = false;
            // 
            // tipo_Carga
            // 
            this.tipo_Carga.HeaderText = "Tipo de Carga";
            this.tipo_Carga.Name = "tipo_Carga";
            this.tipo_Carga.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // pesoTotal
            // 
            this.pesoTotal.HeaderText = "Peso Total";
            this.pesoTotal.Name = "pesoTotal";
            this.pesoTotal.ReadOnly = true;
            // 
            // accion
            // 
            this.accion.HeaderText = "Quitar";
            this.accion.Name = "accion";
            this.accion.ReadOnly = true;
            this.accion.Text = "Quitar";
            this.accion.ToolTipText = "Quitar";
            this.accion.UseColumnTextForButtonValue = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(408, 119);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nudCarga
            // 
            this.nudCarga.Location = new System.Drawing.Point(282, 119);
            this.nudCarga.Name = "nudCarga";
            this.nudCarga.Size = new System.Drawing.Size(120, 23);
            this.nudCarga.TabIndex = 6;
            // 
            // cboCarga
            // 
            this.cboCarga.FormattingEnabled = true;
            this.cboCarga.Location = new System.Drawing.Point(56, 119);
            this.cboCarga.Name = "cboCarga";
            this.cboCarga.Size = new System.Drawing.Size(220, 23);
            this.cboCarga.TabIndex = 5;
            // 
            // cboCamion
            // 
            this.cboCamion.FormattingEnabled = true;
            this.cboCamion.Location = new System.Drawing.Point(187, 72);
            this.cboCamion.Name = "cboCamion";
            this.cboCamion.Size = new System.Drawing.Size(181, 23);
            this.cboCamion.TabIndex = 4;
            this.cboCamion.SelectedIndexChanged += new System.EventHandler(this.cboCamion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Camion asignado";
            // 
            // txtTipoForm
            // 
            this.txtTipoForm.AutoSize = true;
            this.txtTipoForm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTipoForm.Location = new System.Drawing.Point(6, 19);
            this.txtTipoForm.Name = "txtTipoForm";
            this.txtTipoForm.Size = new System.Drawing.Size(151, 23);
            this.txtTipoForm.TabIndex = 1;
            this.txtTipoForm.Text = "Datos de la Carga:";
            // 
            // Frm_Alta_Cargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(589, 379);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Alta_Cargas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE CARGAS";
            this.Load += new System.EventHandler(this.Frm_Alta_Cargas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudCarga;
        private System.Windows.Forms.ComboBox cboCarga;
        private System.Windows.Forms.ComboBox cboCamion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTipoForm;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpìar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCargaMinima;
        private System.Windows.Forms.Label lblCargaMaxima;
        private System.Windows.Forms.Label lblPesoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tipo_carga;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_Carga;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoTotal;
        private System.Windows.Forms.DataGridViewButtonColumn accion;
        private System.Windows.Forms.Label lblNumCarga;
    }
}