namespace CapaPresentacion
{
    partial class FormEditarReservacion
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.comboxEstadoPago = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.lbltxtPrecioNoche = new System.Windows.Forms.Label();
            this.txtNumNoches = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSlctHabitacion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSlctCliente = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboxDescuento = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.EmpRes = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label41 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.comboxReserva = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(7, 284);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(286, 66);
            this.txtObservaciones.TabIndex = 61;
            // 
            // comboxEstadoPago
            // 
            this.comboxEstadoPago.FormattingEnabled = true;
            this.comboxEstadoPago.Items.AddRange(new object[] {
            "DEBE",
            "COBRAR AL CHECKIN",
            "NO COBRAR EMPRESA PAGA",
            "PAGADO"});
            this.comboxEstadoPago.Location = new System.Drawing.Point(173, 194);
            this.comboxEstadoPago.Name = "comboxEstadoPago";
            this.comboxEstadoPago.Size = new System.Drawing.Size(121, 25);
            this.comboxEstadoPago.TabIndex = 60;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(88, 164);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 17);
            this.label31.TabIndex = 59;
            this.label31.Text = "O.OO";
            // 
            // lbltxtPrecioNoche
            // 
            this.lbltxtPrecioNoche.AutoSize = true;
            this.lbltxtPrecioNoche.ForeColor = System.Drawing.Color.Black;
            this.lbltxtPrecioNoche.Location = new System.Drawing.Point(88, 132);
            this.lbltxtPrecioNoche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltxtPrecioNoche.Name = "lbltxtPrecioNoche";
            this.lbltxtPrecioNoche.Size = new System.Drawing.Size(61, 17);
            this.lbltxtPrecioNoche.TabIndex = 58;
            this.lbltxtPrecioNoche.Text = "label31";
            this.lbltxtPrecioNoche.TextChanged += new System.EventHandler(this.lbltxtPrecioNoche_TextChanged);
            // 
            // txtNumNoches
            // 
            this.txtNumNoches.Location = new System.Drawing.Point(265, 162);
            this.txtNumNoches.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumNoches.Name = "txtNumNoches";
            this.txtNumNoches.Size = new System.Drawing.Size(11, 23);
            this.txtNumNoches.TabIndex = 57;
            this.txtNumNoches.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(230, 162);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(23, 23);
            this.txtTotal.TabIndex = 56;
            this.txtTotal.Visible = false;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged_1);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(4, 67);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(61, 17);
            this.label30.TabIndex = 54;
            this.label30.Text = "label30";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(4, 34);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(61, 17);
            this.label29.TabIndex = 53;
            this.label29.Text = "label29";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.ForeColor = System.Drawing.Color.Black;
            this.label101.Location = new System.Drawing.Point(158, 328);
            this.label101.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(17, 17);
            this.label101.TabIndex = 41;
            this.label101.Text = "0";
            this.label101.TextChanged += new System.EventHandler(this.label101_TextChanged);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.ForeColor = System.Drawing.Color.Black;
            this.label51.Location = new System.Drawing.Point(4, 166);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(66, 17);
            this.label51.TabIndex = 40;
            this.label51.Text = "label5.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btnSlctHabitacion
            // 
            this.btnSlctHabitacion.ForeColor = System.Drawing.Color.Black;
            this.btnSlctHabitacion.Location = new System.Drawing.Point(4, 20);
            this.btnSlctHabitacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlctHabitacion.Name = "btnSlctHabitacion";
            this.btnSlctHabitacion.Size = new System.Drawing.Size(290, 30);
            this.btnSlctHabitacion.TabIndex = 9;
            this.btnSlctHabitacion.Text = "Seleccionar una Habitacion disponible";
            this.btnSlctHabitacion.UseVisualStyleBackColor = true;
            this.btnSlctHabitacion.Click += new System.EventHandler(this.btnSlctHabitacion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "label3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(4, 328);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "label10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "label4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(4, 296);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "label9";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(89, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "label5";
            this.label5.TextChanged += new System.EventHandler(this.label5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 263);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "label8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "label7";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(11, 415);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 29);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label101);
            this.groupBox1.Controls.Add(this.label51);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSlctHabitacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(11, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(298, 355);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de habitacion";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(4, 20);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(61, 17);
            this.label28.TabIndex = 40;
            this.label28.Text = "label28";
            this.label28.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label41);
            this.groupBox2.Controls.Add(this.label49);
            this.groupBox2.Controls.Add(this.label42);
            this.groupBox2.Controls.Add(this.label46);
            this.groupBox2.Controls.Add(this.label45);
            this.groupBox2.Controls.Add(this.label43);
            this.groupBox2.Controls.Add(this.label47);
            this.groupBox2.Controls.Add(this.label48);
            this.groupBox2.Controls.Add(this.label44);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnSlctCliente);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(324, 56);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(298, 355);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(4, 52);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 49;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            // 
            // btnSlctCliente
            // 
            this.btnSlctCliente.ForeColor = System.Drawing.Color.Black;
            this.btnSlctCliente.Location = new System.Drawing.Point(4, 21);
            this.btnSlctCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSlctCliente.Name = "btnSlctCliente";
            this.btnSlctCliente.Size = new System.Drawing.Size(290, 30);
            this.btnSlctCliente.TabIndex = 8;
            this.btnSlctCliente.Text = "Seleccionar Cliennte existente o agregar";
            this.btnSlctCliente.UseVisualStyleBackColor = true;
            this.btnSlctCliente.Click += new System.EventHandler(this.btnSlctCliente_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(111, 69);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 48;
            this.label12.Text = "label12";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(111, 328);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 17);
            this.label20.TabIndex = 43;
            this.label20.Text = "label20";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(111, 102);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 47;
            this.label13.Text = "label13";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(151, 231);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 17);
            this.label17.TabIndex = 45;
            this.label17.Text = "label17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(111, 198);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "label16";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(173, 133);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 17);
            this.label14.TabIndex = 40;
            this.label14.Text = "label14";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(151, 263);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 17);
            this.label18.TabIndex = 42;
            this.label18.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(151, 296);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 17);
            this.label19.TabIndex = 44;
            this.label19.Text = "label19";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(151, 166);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 17);
            this.label15.TabIndex = 46;
            this.label15.Text = "label15";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.Location = new System.Drawing.Point(291, 19);
            this.label0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(373, 24);
            this.label0.TabIndex = 15;
            this.label0.Text = "RESERVACIONES HOTEL PURA VIDA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(923, 41);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(166, 111);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(104, 17);
            this.label27.TabIndex = 51;
            this.label27.Text = "Calcular total";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboxReserva);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txtObservaciones);
            this.groupBox3.Controls.Add(this.comboxEstadoPago);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.lbltxtPrecioNoche);
            this.groupBox3.Controls.Add(this.txtNumNoches);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.comboxDescuento);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.EmpRes);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(635, 56);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(298, 355);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Empleado";
            // 
            // comboxDescuento
            // 
            this.comboxDescuento.FormattingEnabled = true;
            this.comboxDescuento.Items.AddRange(new object[] {
            "0%",
            "5%",
            "10%",
            "15%",
            "20%",
            "25%",
            "30%",
            "35%",
            "50%",
            "Seleccione %"});
            this.comboxDescuento.Location = new System.Drawing.Point(169, 129);
            this.comboxDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.comboxDescuento.Name = "comboxDescuento";
            this.comboxDescuento.Size = new System.Drawing.Size(126, 25);
            this.comboxDescuento.TabIndex = 52;
            this.comboxDescuento.SelectedIndexChanged += new System.EventHandler(this.comboxDescuento_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(4, 132);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 17);
            this.label21.TabIndex = 45;
            this.label21.Text = "label21";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(4, 164);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 17);
            this.label22.TabIndex = 40;
            this.label22.Text = "label22";
            // 
            // EmpRes
            // 
            this.EmpRes.AutoSize = true;
            this.EmpRes.ForeColor = System.Drawing.Color.Blue;
            this.EmpRes.Location = new System.Drawing.Point(4, 99);
            this.EmpRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmpRes.Name = "EmpRes";
            this.EmpRes.Size = new System.Drawing.Size(131, 17);
            this.EmpRes.TabIndex = 50;
            this.EmpRes.Text = "Detalles de pago";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(4, 197);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 17);
            this.label23.TabIndex = 44;
            this.label23.Text = "Estado Pago";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Blue;
            this.label25.Location = new System.Drawing.Point(4, 263);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(116, 17);
            this.label25.TabIndex = 41;
            this.label25.Text = "Observaciones";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(4, 69);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(61, 17);
            this.label41.TabIndex = 58;
            this.label41.Text = "label41";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(4, 329);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(61, 17);
            this.label49.TabIndex = 53;
            this.label49.Text = "label49";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Location = new System.Drawing.Point(4, 102);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(61, 17);
            this.label42.TabIndex = 57;
            this.label42.Text = "label42";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.ForeColor = System.Drawing.Color.Black;
            this.label46.Location = new System.Drawing.Point(4, 232);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(61, 17);
            this.label46.TabIndex = 55;
            this.label46.Text = "label46";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.ForeColor = System.Drawing.Color.Black;
            this.label45.Location = new System.Drawing.Point(4, 199);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(61, 17);
            this.label45.TabIndex = 51;
            this.label45.Text = "label45";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(4, 134);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(61, 17);
            this.label43.TabIndex = 50;
            this.label43.Text = "label43";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.ForeColor = System.Drawing.Color.Black;
            this.label47.Location = new System.Drawing.Point(4, 264);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(61, 17);
            this.label47.TabIndex = 52;
            this.label47.Text = "label47";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.ForeColor = System.Drawing.Color.Black;
            this.label48.Location = new System.Drawing.Point(4, 297);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(61, 17);
            this.label48.TabIndex = 54;
            this.label48.Text = "label48";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Location = new System.Drawing.Point(4, 167);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(61, 17);
            this.label44.TabIndex = 56;
            this.label44.Text = "label44";
            // 
            // comboxReserva
            // 
            this.comboxReserva.FormattingEnabled = true;
            this.comboxReserva.Items.AddRange(new object[] {
            "DEBE",
            "COBRAR AL CHECKIN",
            "NO COBRAR EMPRESA PAGA",
            "PAGADO"});
            this.comboxReserva.Location = new System.Drawing.Point(173, 228);
            this.comboxReserva.Name = "comboxReserva";
            this.comboxReserva.Size = new System.Drawing.Size(121, 25);
            this.comboxReserva.TabIndex = 63;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Blue;
            this.label24.Location = new System.Drawing.Point(4, 231);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 17);
            this.label24.TabIndex = 62;
            this.label24.Text = "Estado Reserva";
            // 
            // FormEditarReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEditarReservacion";
            this.Text = "Editar Reservacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditarReservacion_FormClosed);
            this.Load += new System.EventHandler(this.FormEditarReservacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.ComboBox comboxEstadoPago;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lbltxtPrecioNoche;
        private System.Windows.Forms.TextBox txtNumNoches;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSlctHabitacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSlctCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboxDescuento;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label EmpRes;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox comboxReserva;
        private System.Windows.Forms.Label label24;
    }
}