namespace Climbox
{
    partial class PagoClientes
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.tipoFormaPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgPagos = new System.Windows.Forms.DataGridView();
            this.climboxDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnConsultarPa = new System.Windows.Forms.Button();
            this.btnPago = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoFormaPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.climboxDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbTipoPago);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpFechaPago);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIdentificacion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 216);
            this.panel1.TabIndex = 0;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tipoFormaPagoBindingSource, "Descripcion", true));
            this.cmbTipoPago.DataSource = this.tipoFormaPagoBindingSource;
            this.cmbTipoPago.DisplayMember = "Descripcion";
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(540, 160);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(200, 28);
            this.cmbTipoPago.TabIndex = 12;
            this.cmbTipoPago.ValueMember = "Id";
            // 
            // tipoFormaPagoBindingSource
            // 
            this.tipoFormaPagoBindingSource.DataMember = "TipoFormaPago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tipo de Pago:";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPago.Location = new System.Drawing.Point(540, 114);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaPago.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha Pago:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(540, 59);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(207, 26);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad Meses:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(147, 162);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(207, 26);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.Tag = "";
            this.txtDescripcion.Text = "Mensualidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripción:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(147, 108);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(207, 26);
            this.txtValor.TabIndex = 4;
            this.txtValor.Text = "130000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor del Pago:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(147, 62);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(207, 26);
            this.txtIdentificacion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realizar Pagos";
            // 
            // dtgPagos
            // 
            this.dtgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPagos.Location = new System.Drawing.Point(19, 269);
            this.dtgPagos.Name = "dtgPagos";
            this.dtgPagos.RowHeadersWidth = 51;
            this.dtgPagos.RowTemplate.Height = 24;
            this.dtgPagos.Size = new System.Drawing.Size(757, 216);
            this.dtgPagos.TabIndex = 3;
            // 
            // btnConsultarPa
            // 
            this.btnConsultarPa.BackColor = System.Drawing.Color.White;
            this.btnConsultarPa.Location = new System.Drawing.Point(784, 155);
            this.btnConsultarPa.Name = "btnConsultarPa";
            this.btnConsultarPa.Size = new System.Drawing.Size(208, 73);
            this.btnConsultarPa.TabIndex = 5;
            this.btnConsultarPa.Text = "Consultar Pagos";
            this.btnConsultarPa.UseVisualStyleBackColor = false;
            this.btnConsultarPa.Click += new System.EventHandler(this.btnConsultarPa_Click);
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.White;
            this.btnPago.Location = new System.Drawing.Point(784, 12);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(208, 73);
            this.btnPago.TabIndex = 6;
            this.btnPago.Text = "Guardar Pago";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(784, 93);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(208, 54);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // PagoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 562);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.btnConsultarPa);
            this.Controls.Add(this.dtgPagos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PagoClientes";
            this.Text = "Pagos ";
            this.Load += new System.EventHandler(this.PagoClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoFormaPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.climboxDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgPagos;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;       
        private System.Windows.Forms.BindingSource tipoFormaPagoBindingSource;      
        private System.Windows.Forms.BindingSource climboxDataSet1BindingSource;
        private System.Windows.Forms.Button btnConsultarPa;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Button btnBorrar;
    }
}