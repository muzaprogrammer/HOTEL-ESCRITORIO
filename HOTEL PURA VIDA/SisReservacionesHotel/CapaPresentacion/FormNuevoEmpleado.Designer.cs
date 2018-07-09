namespace CapaPresentacion
{
    partial class FormNuevoEmpleado
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
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboxGenero = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNDocumento = new System.Windows.Forms.TextBox();
            this.comboxTurno = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboxAcceso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errorIcono.SetIconAlignment(this.dtpFechaNacimiento, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(21, 177);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(243, 22);
            this.dtpFechaNacimiento.TabIndex = 76;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errorIcono.SetIconAlignment(this.dtpFechaIngreso, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.dtpFechaIngreso.Location = new System.Drawing.Point(287, 177);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(243, 22);
            this.dtpFechaIngreso.TabIndex = 90;
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaIngreso_ValueChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(639, 337);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 28);
            this.btnCancelar.TabIndex = 88;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(21, 337);
            this.btnGuardarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(153, 28);
            this.btnGuardarCliente.TabIndex = 87;
            this.btnGuardarCliente.Text = "Guardar ";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 85;
            this.label2.Text = "N Documento";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUsuario.Location = new System.Drawing.Point(285, 292);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(245, 22);
            this.txtUsuario.TabIndex = 84;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTelefono.Location = new System.Drawing.Point(553, 235);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(239, 22);
            this.txtTelefono.TabIndex = 82;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(547, 215);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 81;
            this.label11.Text = "Telefono";
            // 
            // txtPasword
            // 
            this.txtPasword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPasword.Location = new System.Drawing.Point(553, 292);
            this.txtPasword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Size = new System.Drawing.Size(239, 22);
            this.txtPasword.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(553, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 79;
            this.label8.Text = "Pasword";
            // 
            // comboxGenero
            // 
            this.comboxGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboxGenero.FormattingEnabled = true;
            this.comboxGenero.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Femenino"});
            this.comboxGenero.Location = new System.Drawing.Point(553, 121);
            this.comboxGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboxGenero.Name = "comboxGenero";
            this.comboxGenero.Size = new System.Drawing.Size(239, 24);
            this.comboxGenero.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 77;
            this.label7.Text = "Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // txtTDocumento
            // 
            this.txtTDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTDocumento.Location = new System.Drawing.Point(21, 122);
            this.txtTDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTDocumento.Name = "txtTDocumento";
            this.txtTDocumento.Size = new System.Drawing.Size(243, 22);
            this.txtTDocumento.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Tipo de Documento";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombres.Location = new System.Drawing.Point(21, 74);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(353, 22);
            this.txtNombres.TabIndex = 72;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApellidos.Location = new System.Drawing.Point(439, 74);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(353, 22);
            this.txtApellidos.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(159, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Digite los datos del Empleado a agregrar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 89;
            this.label10.Text = "Fecha de Ingreso";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDireccion.Location = new System.Drawing.Point(19, 235);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(320, 22);
            this.txtDireccion.TabIndex = 92;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 214);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 91;
            this.label12.Text = "Direccion";
            // 
            // txtSueldo
            // 
            this.txtSueldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSueldo.Location = new System.Drawing.Point(351, 235);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(179, 22);
            this.txtSueldo.TabIndex = 94;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(347, 214);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 93;
            this.label13.Text = "Sueldo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 271);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 95;
            this.label9.Text = "Usuario";
            // 
            // txtNDocumento
            // 
            this.txtNDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNDocumento.Location = new System.Drawing.Point(287, 122);
            this.txtNDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNDocumento.Name = "txtNDocumento";
            this.txtNDocumento.Size = new System.Drawing.Size(243, 22);
            this.txtNDocumento.TabIndex = 96;
            // 
            // comboxTurno
            // 
            this.comboxTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboxTurno.FormattingEnabled = true;
            this.comboxTurno.Items.AddRange(new object[] {
            "",
            "Matutino",
            "Vespertino"});
            this.comboxTurno.Location = new System.Drawing.Point(553, 175);
            this.comboxTurno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboxTurno.Name = "comboxTurno";
            this.comboxTurno.Size = new System.Drawing.Size(239, 24);
            this.comboxTurno.TabIndex = 98;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(551, 153);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 97;
            this.label14.Text = "Turno";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 271);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 17);
            this.label15.TabIndex = 99;
            this.label15.Text = "Acceso";
            // 
            // comboxAcceso
            // 
            this.comboxAcceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboxAcceso.FormattingEnabled = true;
            this.comboxAcceso.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Usuario"});
            this.comboxAcceso.Location = new System.Drawing.Point(21, 290);
            this.comboxAcceso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboxAcceso.Name = "comboxAcceso";
            this.comboxAcceso.Size = new System.Drawing.Size(243, 24);
            this.comboxAcceso.TabIndex = 100;
            // 
            // FormNuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 395);
            this.Controls.Add(this.comboxAcceso);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboxTurno);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNDocumento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPasword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboxGenero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTDocumento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormNuevoEmpleado";
            this.Text = "Nuevo Empleado";
            this.Load += new System.EventHandler(this.FormNuevoEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboxGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNDocumento;
        private System.Windows.Forms.ComboBox comboxTurno;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboxAcceso;
    }
}