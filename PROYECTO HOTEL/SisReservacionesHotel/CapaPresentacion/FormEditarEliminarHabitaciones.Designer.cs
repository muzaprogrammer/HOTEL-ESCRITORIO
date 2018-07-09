﻿namespace CapaPresentacion
{
    partial class FormEditarEliminarHabitaciones
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
            this.comboxTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboxPrecio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.btnAgregarNuevo = new System.Windows.Forms.Button();
            this.btnRefrescarList = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.comboxHabitaciones = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // comboxTipo
            // 
            this.comboxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboxTipo.FormattingEnabled = true;
            this.comboxTipo.Items.AddRange(new object[] {
            "",
            "SENCILLA",
            "DOBLE",
            "TRIPLE",
            "SUITE"});
            this.comboxTipo.Location = new System.Drawing.Point(325, 53);
            this.comboxTipo.Name = "comboxTipo";
            this.comboxTipo.Size = new System.Drawing.Size(194, 21);
            this.comboxTipo.TabIndex = 158;
            this.comboxTipo.SelectedIndexChanged += new System.EventHandler(this.comboxTipo_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 157;
            this.label3.Text = "Tipo";
            // 
            // comboxPrecio
            // 
            this.comboxPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboxPrecio.FormattingEnabled = true;
            this.comboxPrecio.Items.AddRange(new object[] {
            "",
            "Habitaciones de precio maximo",
            "Habitaciones de precio minimo"});
            this.comboxPrecio.Location = new System.Drawing.Point(109, 53);
            this.comboxPrecio.Name = "comboxPrecio";
            this.comboxPrecio.Size = new System.Drawing.Size(210, 21);
            this.comboxPrecio.TabIndex = 156;
            this.comboxPrecio.SelectedIndexChanged += new System.EventHandler(this.comboxPrecio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 155;
            this.label2.Text = "Precio";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(18, 478);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(93, 23);
            this.btnEditar.TabIndex = 154;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkBox15.Location = new System.Drawing.Point(14, 92);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(233, 17);
            this.checkBox15.TabIndex = 153;
            this.checkBox15.Text = "Seleccione Habitacion para editar o eliminar";
            this.checkBox15.UseVisualStyleBackColor = false;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(282, 93);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 150;
            this.lblTotal.Text = "label6";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataListado.Location = new System.Drawing.Point(18, 115);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(501, 357);
            this.dataListado.TabIndex = 148;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            // 
            // btnAgregarNuevo
            // 
            this.btnAgregarNuevo.Location = new System.Drawing.Point(409, 478);
            this.btnAgregarNuevo.Name = "btnAgregarNuevo";
            this.btnAgregarNuevo.Size = new System.Drawing.Size(110, 23);
            this.btnAgregarNuevo.TabIndex = 147;
            this.btnAgregarNuevo.Text = "Agregar Habitacion";
            this.btnAgregarNuevo.UseVisualStyleBackColor = true;
            this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
            // 
            // btnRefrescarList
            // 
            this.btnRefrescarList.Location = new System.Drawing.Point(216, 478);
            this.btnRefrescarList.Name = "btnRefrescarList";
            this.btnRefrescarList.Size = new System.Drawing.Size(93, 23);
            this.btnRefrescarList.TabIndex = 146;
            this.btnRefrescarList.Text = "Refrescar Lista";
            this.btnRefrescarList.UseVisualStyleBackColor = true;
            this.btnRefrescarList.Click += new System.EventHandler(this.btnRefrescarList_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(117, 478);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 23);
            this.btnEliminar.TabIndex = 145;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // comboxHabitaciones
            // 
            this.comboxHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboxHabitaciones.FormattingEnabled = true;
            this.comboxHabitaciones.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.comboxHabitaciones.Location = new System.Drawing.Point(14, 53);
            this.comboxHabitaciones.Name = "comboxHabitaciones";
            this.comboxHabitaciones.Size = new System.Drawing.Size(89, 21);
            this.comboxHabitaciones.TabIndex = 132;
            this.comboxHabitaciones.SelectedIndexChanged += new System.EventHandler(this.comboxHabitaciones_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 131;
            this.label7.Text = "Habitaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 130;
            this.label1.Text = "Mantenimiento Habitaciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(315, 478);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 23);
            this.btnSalir.TabIndex = 159;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormEditarEliminarHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(535, 513);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.comboxTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboxPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.checkBox15);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.btnAgregarNuevo);
            this.Controls.Add(this.btnRefrescarList);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.comboxHabitaciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "FormEditarEliminarHabitaciones";
            this.Text = "Mantenimiento Habitaciones";
            this.Load += new System.EventHandler(this.FormEditarEliminarHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboxTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboxPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.Button btnAgregarNuevo;
        private System.Windows.Forms.Button btnRefrescarList;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox comboxHabitaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Button btnSalir;
    }
}