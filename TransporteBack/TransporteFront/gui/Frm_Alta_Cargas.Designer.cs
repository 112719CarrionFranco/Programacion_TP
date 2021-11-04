
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTipoForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCamion = new System.Windows.Forms.ComboBox();
            this.cboCarga = new System.Windows.Forms.ComboBox();
            this.nudCarga = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpìar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblPesoParcial = new System.Windows.Forms.Label();
            this.lblCargaMaxima = new System.Windows.Forms.Label();
            this.lblCargaMinima = new System.Windows.Forms.Label();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_Carga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCargaMinima);
            this.groupBox1.Controls.Add(this.lblCargaMaxima);
            this.groupBox1.Controls.Add(this.lblPesoParcial);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnLimpìar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.nudCarga);
            this.groupBox1.Controls.Add(this.cboCarga);
            this.groupBox1.Controls.Add(this.cboCamion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTipoForm);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            // cboCamion
            // 
            this.cboCamion.FormattingEnabled = true;
            this.cboCamion.Location = new System.Drawing.Point(187, 72);
            this.cboCamion.Name = "cboCamion";
            this.cboCamion.Size = new System.Drawing.Size(181, 23);
            this.cboCamion.TabIndex = 4;
            // 
            // cboCarga
            // 
            this.cboCarga.FormattingEnabled = true;
            this.cboCarga.Location = new System.Drawing.Point(56, 119);
            this.cboCarga.Name = "cboCarga";
            this.cboCarga.Size = new System.Drawing.Size(220, 23);
            this.cboCarga.TabIndex = 5;
            // 
            // nudCarga
            // 
            this.nudCarga.Location = new System.Drawing.Point(282, 119);
            this.nudCarga.Name = "nudCarga";
            this.nudCarga.Size = new System.Drawing.Size(120, 23);
            this.nudCarga.TabIndex = 6;
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalle,
            this.tipo_Carga,
            this.peso,
            this.cantidad,
            this.pesoTotal,
            this.accion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(554, 173);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(109, 327);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
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
            // 
            // lblPesoParcial
            // 
            this.lblPesoParcial.AutoSize = true;
            this.lblPesoParcial.Location = new System.Drawing.Point(392, 327);
            this.lblPesoParcial.Name = "lblPesoParcial";
            this.lblPesoParcial.Size = new System.Drawing.Size(73, 15);
            this.lblPesoParcial.TabIndex = 12;
            this.lblPesoParcial.Text = "Peso Parcial:";
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
            // lblCargaMinima
            // 
            this.lblCargaMinima.AutoSize = true;
            this.lblCargaMinima.Location = new System.Drawing.Point(392, 87);
            this.lblCargaMinima.Name = "lblCargaMinima";
            this.lblCargaMinima.Size = new System.Drawing.Size(85, 15);
            this.lblCargaMinima.TabIndex = 14;
            this.lblCargaMinima.Text = "Carga Minima:";
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Column1";
            this.detalle.Name = "detalle";
            this.detalle.Visible = false;
            // 
            // tipo_Carga
            // 
            this.tipo_Carga.HeaderText = "Tipo de Carga";
            this.tipo_Carga.Name = "tipo_Carga";
            // 
            // peso
            // 
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // pesoTotal
            // 
            this.pesoTotal.HeaderText = "Peso Total";
            this.pesoTotal.Name = "pesoTotal";
            // 
            // accion
            // 
            this.accion.HeaderText = "Quitar";
            this.accion.Name = "accion";
            // 
            // Frm_Alta_Cargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 379);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Alta_Cargas";
            this.Text = "Alta Cargas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudCarga;
        private System.Windows.Forms.ComboBox cboCarga;
        private System.Windows.Forms.ComboBox cboCamion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTipoForm;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpìar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCargaMinima;
        private System.Windows.Forms.Label lblCargaMaxima;
        private System.Windows.Forms.Label lblPesoParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_Carga;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoTotal;
        private System.Windows.Forms.DataGridViewButtonColumn accion;
    }
}