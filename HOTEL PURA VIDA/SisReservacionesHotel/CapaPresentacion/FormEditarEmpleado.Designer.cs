namespace CapaPresentacion
{
    partial class FormEditarEmpleado
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
            this.comboxTurno = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNDocumento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
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
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIdEmp = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboxAcceso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // comboxTurno
            // 
            this.comboxTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.comboxTurno.FormattingEnabled = true;
            this.comboxTurno.Items.AddRange(new object[] {
            "",
            "Matutino",
            "Vespertino"});
            this.comboxTurno.Location = new System.Drawing.Point(410, 137);
            this.comboxTurno.Name = "comboxTurno";
            this.comboxTurno.Size = new System.Drawing.Size(180, 21);
            this.comboxTurno.TabIndex = 127;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(409, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 126;
            this.label14.Text = "Turno";
            // 
            // txtNDocumento
            // 
            this.txtNDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtNDocumento.Location = new System.Drawing.Point(211, 94);
            this.txtNDocumento.Name = "txtNDocumento";
            this.txtNDocumento.Size = new System.Drawing.Size(183, 20);
            this.txtNDocumento.TabIndex = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 124;
            this.label9.Text = "Usuario";
            // 
            // txtSueldo
            // 
            this.txtSueldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSueldo.Location = new System.Drawing.Point(265, 186);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(129, 20);
            this.txtSueldo.TabIndex = 123;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 122;
            this.label13.Text = "Sueldo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtDireccion.Location = new System.Drawing.Point(10, 186);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(240, 20);
            this.txtDireccion.TabIndex = 121;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 120;
            this.label12.Text = "Direccion";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errorIcono.SetIconAlignment(this.dtpFechaIngreso, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.dtpFechaIngreso.Location = new System.Drawing.Point(211, 139);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(183, 20);
            this.dtpFechaIngreso.TabIndex = 119;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 118;
            this.label10.Text = "Fecha de Ingreso";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(475, 269);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 23);
            this.btnCancelar.TabIndex = 117;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Location = new System.Drawing.Point(11, 269);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(115, 23);
            this.btnGuardarCliente.TabIndex = 116;
            this.btnGuardarCliente.Text = "Guardar ";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "N Documento";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtUsuario.Location = new System.Drawing.Point(209, 232);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(185, 20);
            this.txtUsuario.TabIndex = 114;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTelefono.Location = new System.Drawing.Point(410, 186);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 20);
            this.txtTelefono.TabIndex = 113;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 112;
            this.label11.Text = "Telefono";
            // 
            // txtPasword
            // 
            this.txtPasword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPasword.Location = new System.Drawing.Point(410, 232);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Size = new System.Drawing.Size(180, 20);
            this.txtPasword.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 110;
            this.label8.Text = "Pasword";
            // 
            // comboxGenero
            // 
            this.comboxGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.comboxGenero.FormattingEnabled = true;
            this.comboxGenero.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Femenino"});
            this.comboxGenero.Location = new System.Drawing.Point(410, 93);
            this.comboxGenero.Name = "comboxGenero";
            this.comboxGenero.Size = new System.Drawing.Size(180, 21);
            this.comboxGenero.TabIndex = 109;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 108;
            this.label7.Text = "Genero";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errorIcono.SetIconAlignment(this.dtpFechaNacimiento, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(11, 139);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(183, 20);
            this.dtpFechaNacimiento.TabIndex = 107;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // txtTDocumento
            // 
            this.txtTDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTDocumento.Location = new System.Drawing.Point(11, 94);
            this.txtTDocumento.Name = "txtTDocumento";
            this.txtTDocumento.Size = new System.Drawing.Size(183, 20);
            this.txtTDocumento.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 104;
            this.label5.Text = "Tipo de Documento";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtNombres.Location = new System.Drawing.Point(11, 55);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(266, 20);
            this.txtNombres.TabIndex = 103;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtApellidos.Location = new System.Drawing.Point(325, 55);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(266, 20);
            this.txtApellidos.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 100;
            this.label3.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(115, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 20);
            this.label1.TabIndex = 99;
            this.label1.Text = "Digite los datos del Empleado a editar";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.Location = new System.Drawing.Point(10, 11);
            this.txtIdEmp.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.Size = new System.Drawing.Size(76, 20);
            this.txtIdEmp.TabIndex = 128;
            this.txtIdEmp.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 129;
            this.label15.Text = "Acceso";
            // 
            // comboxAcceso
            // 
            this.comboxAcceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.comboxAcceso.FormattingEnabled = true;
            this.comboxAcceso.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Usuario"});
            this.comboxAcceso.Location = new System.Drawing.Point(11, 231);
            this.comboxAcceso.Name = "comboxAcceso";
            this.comboxAcceso.Size = new System.Drawing.Size(192, 21);
            this.comboxAcceso.TabIndex = 130;
            // 
            // FormEditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 313);
            this.Controls.Add(this.comboxAcceso);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtIdEmp);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEditarEmpleado";
            this.Text = "Editar Empleado";
            this.Load += new System.EventHandler(this.FormEditarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxTurno;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNDocumento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label10;
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
        private System.Windows.Forms.TextBox txtIdEmp;
        private System.Windows.Forms.ComboBox comboxAcceso;
        private System.Windows.Forms.Label label15;
    }
}