namespace CapaPresentacion
{
    partial class FormHabitaciones
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.btnRefrescarList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboxHabitaciones = new System.Windows.Forms.ComboBox();
            this.comboxPrecio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboxTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 93);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 120;
            this.lblTotal.Text = "label6";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataListado.Location = new System.Drawing.Point(12, 109);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(505, 362);
            this.dataListado.TabIndex = 118;
            // 
            // btnRefrescarList
            // 
            this.btnRefrescarList.Location = new System.Drawing.Point(12, 477);
            this.btnRefrescarList.Name = "btnRefrescarList";
            this.btnRefrescarList.Size = new System.Drawing.Size(115, 23);
            this.btnRefrescarList.TabIndex = 115;
            this.btnRefrescarList.Text = "Refrescar Lista";
            this.btnRefrescarList.UseVisualStyleBackColor = true;
            this.btnRefrescarList.Click += new System.EventHandler(this.btnRefrescarList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(182, 7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Buscar Habitaciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "Habitaciones";
            // 
            // comboxHabitaciones
            // 
            this.comboxHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboxHabitaciones.FormattingEnabled = true;
            this.comboxHabitaciones.Location = new System.Drawing.Point(12, 52);
            this.comboxHabitaciones.Name = "comboxHabitaciones";
            this.comboxHabitaciones.Size = new System.Drawing.Size(89, 21);
            this.comboxHabitaciones.TabIndex = 96;
            this.comboxHabitaciones.SelectedIndexChanged += new System.EventHandler(this.comboxHabitaciones_SelectedIndexChanged);
            // 
            // comboxPrecio
            // 
            this.comboxPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboxPrecio.FormattingEnabled = true;
            this.comboxPrecio.Items.AddRange(new object[] {
            "",
            "Habitaciones de precio maximo",
            "Habitaciones de precio minimo"});
            this.comboxPrecio.Location = new System.Drawing.Point(107, 52);
            this.comboxPrecio.Name = "comboxPrecio";
            this.comboxPrecio.Size = new System.Drawing.Size(210, 21);
            this.comboxPrecio.TabIndex = 127;
            this.comboxPrecio.SelectedIndexChanged += new System.EventHandler(this.comboxPrecio_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 126;
            this.label2.Text = "Precio";
            // 
            // comboxTipo
            // 
            this.comboxTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboxTipo.FormattingEnabled = true;
            this.comboxTipo.Location = new System.Drawing.Point(323, 52);
            this.comboxTipo.Name = "comboxTipo";
            this.comboxTipo.Size = new System.Drawing.Size(194, 21);
            this.comboxTipo.TabIndex = 129;
            this.comboxTipo.SelectedIndexChanged += new System.EventHandler(this.comboxTipo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 128;
            this.label3.Text = "Tipo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 130;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboxTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboxPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataListado);
            this.Controls.Add(this.btnRefrescarList);
            this.Controls.Add(this.comboxHabitaciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "FormHabitaciones";
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.FormHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button btnRefrescarList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ComboBox comboxHabitaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboxTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboxPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}