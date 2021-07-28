namespace Climbox
{
    partial class Registro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbmTipoUsuario = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtEps = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.cmbEstadousuario = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTelefEmergencia = new System.Windows.Forms.TextBox();
            this.txtNombreContac = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pAGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBorrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Location = new System.Drawing.Point(12, 641);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(274, 76);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar Información";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO DE USUARIOS BOX";
         
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(107, 140);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(196, 26);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Validated += new System.EventHandler(this.txtApellido_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 26);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Identificación:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(451, 94);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(196, 26);
            this.txtIdentificacion.TabIndex = 7;
            this.txtIdentificacion.Validated += new System.EventHandler(this.txtIdentificacion_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha Cumpleaños:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "EPS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Persona Contacto Emergencia:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Teléfono Emergencia:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Profesión/Ocupación:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tipo Usuario:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(307, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Usuario Activo:";
            // 
            // cbmTipoUsuario
            // 
            this.cbmTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmTipoUsuario.FormattingEnabled = true;
            this.cbmTipoUsuario.Items.AddRange(new object[] {
            "Seleccionar Tipo",
            "Cliente",
            "Empleado",
            "Administrador"});
            this.cbmTipoUsuario.Location = new System.Drawing.Point(451, 241);
            this.cbmTipoUsuario.Name = "cbmTipoUsuario";
            this.cbmTipoUsuario.Size = new System.Drawing.Size(196, 28);
            this.cbmTipoUsuario.TabIndex = 17;
            this.cbmTipoUsuario.Validated += new System.EventHandler(this.cbmTipoUsuario_Validated);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(451, 143);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(196, 26);
            this.txtTelefono.TabIndex = 19;
            this.txtTelefono.Validated += new System.EventHandler(this.txtTelefono_Validated);
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(107, 193);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(196, 28);
            this.cmbSexo.TabIndex = 20;
            // 
            // txtEps
            // 
            this.txtEps.Location = new System.Drawing.Point(451, 190);
            this.txtEps.Name = "txtEps";
            this.txtEps.Size = new System.Drawing.Size(196, 26);
            this.txtEps.TabIndex = 21;
            this.txtEps.Validated += new System.EventHandler(this.txtEps_Validated);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.txtOcupacion);
            this.panel1.Controls.Add(this.cmbEstadousuario);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cbmTipoUsuario);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtEps);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cmbSexo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtIdentificacion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 373);
            this.panel1.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 249);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 26);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "Email:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "aaaa/mm/dd";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(3, 332);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 26);
            this.dtpFecha.TabIndex = 25;
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Location = new System.Drawing.Point(451, 329);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(196, 26);
            this.txtOcupacion.TabIndex = 24;
            // 
            // cmbEstadousuario
            // 
            this.cmbEstadousuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadousuario.FormattingEnabled = true;
            this.cmbEstadousuario.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadousuario.Location = new System.Drawing.Point(451, 288);
            this.cmbEstadousuario.Name = "cmbEstadousuario";
            this.cmbEstadousuario.Size = new System.Drawing.Size(196, 28);
            this.cmbEstadousuario.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(156, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(289, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Información Personal del Usuario";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtTelefEmergencia);
            this.panel2.Controls.Add(this.txtNombreContac);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 183);
            this.panel2.TabIndex = 23;
            // 
            // txtTelefEmergencia
            // 
            this.txtTelefEmergencia.Location = new System.Drawing.Point(273, 104);
            this.txtTelefEmergencia.Name = "txtTelefEmergencia";
            this.txtTelefEmergencia.Size = new System.Drawing.Size(196, 26);
            this.txtTelefEmergencia.TabIndex = 25;
            this.txtTelefEmergencia.Validated += new System.EventHandler(this.txtTelefEmergencia_Validated);
            // 
            // txtNombreContac
            // 
            this.txtNombreContac.Location = new System.Drawing.Point(273, 61);
            this.txtNombreContac.Name = "txtNombreContac";
            this.txtNombreContac.Size = new System.Drawing.Size(196, 26);
            this.txtNombreContac.TabIndex = 24;
            this.txtNombreContac.Validated += new System.EventHandler(this.txtNombreContac_Validated);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(161, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(308, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "Información en caso de emergencia";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pAGOSToolStripMenuItem,
            this.movimientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pAGOSToolStripMenuItem
            // 
            this.pAGOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.pAGOSToolStripMenuItem.Name = "pAGOSToolStripMenuItem";
            this.pAGOSToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.pAGOSToolStripMenuItem.Text = "PAGOS";
            this.pAGOSToolStripMenuItem.Click += new System.EventHandler(this.pAGOSToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.movimientosToolStripMenuItem.Text = "MOVIMIENTOS";
            this.movimientosToolStripMenuItem.Click += new System.EventHandler(this.movimientosToolStripMenuItem_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultar.Location = new System.Drawing.Point(445, 642);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(274, 76);
            this.btnConsultar.TabIndex = 25;
            this.btnConsultar.Text = "Consultar Usuario";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrar.Location = new System.Drawing.Point(292, 642);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(146, 76);
            this.btnBorrar.TabIndex = 26;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 726);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Registro";
            this.Text = "CLIMB BOX-GYM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbmTipoUsuario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtEps;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbEstadousuario;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTelefEmergencia;
        private System.Windows.Forms.TextBox txtNombreContac;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pAGOSToolStripMenuItem;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
    }
}

