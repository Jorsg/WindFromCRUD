namespace Climbox
{
    partial class Movimientos
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
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.btExportar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnual = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Location = new System.Drawing.Point(34, 96);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.RowTemplate.Height = 24;
            this.dtgDatos.Size = new System.Drawing.Size(828, 327);
            this.dtgDatos.TabIndex = 0;
            // 
            // btExportar
            // 
            this.btExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportar.Location = new System.Drawing.Point(34, 450);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(183, 54);
            this.btExportar.TabIndex = 1;
            this.btExportar.Text = "Movimientos Mes";
            this.btExportar.UseVisualStyleBackColor = true;
            this.btExportar.Click += new System.EventHandler(this.btExportar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrar.Location = new System.Drawing.Point(663, 450);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(199, 54);
            this.btBorrar.TabIndex = 2;
            this.btBorrar.Text = "Limpiar";
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(240, 57);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 26);
            this.dtpFecha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Movimiento";
            // 
            // btnAnual
            // 
            this.btnAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnual.Location = new System.Drawing.Point(240, 450);
            this.btnAnual.Name = "btnAnual";
            this.btnAnual.Size = new System.Drawing.Size(179, 54);
            this.btnAnual.TabIndex = 5;
            this.btnAnual.Text = "Movimientos Anual";
            this.btnAnual.UseVisualStyleBackColor = true;
            this.btnAnual.Click += new System.EventHandler(this.btnAnual_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(451, 450);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(185, 54);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 516);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnAnual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btExportar);
            this.Controls.Add(this.dtgDatos);
            this.Name = "Movimientos";
            this.Text = "Movimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnual;
        private System.Windows.Forms.Button btnExportar;
    }
}