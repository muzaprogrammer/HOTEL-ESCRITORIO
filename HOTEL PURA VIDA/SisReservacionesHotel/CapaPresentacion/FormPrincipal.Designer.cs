namespace CapaPresentacion
{
    partial class FormPrincipal
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDeUsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadDeHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaReservacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuesvoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarHabitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevaHabitacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeHotelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.reservacionesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.habitacionesToolStripMenuItem,
            this.hotelesToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.viewMenu,
            this.windowsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1271, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarDeUsuarioToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(71, 24);
            this.fileMenu.Text = "&Archivo";
            // 
            // cambiarDeUsuarioToolStripMenuItem1
            // 
            this.cambiarDeUsuarioToolStripMenuItem1.Name = "cambiarDeUsuarioToolStripMenuItem1";
            this.cambiarDeUsuarioToolStripMenuItem1.Size = new System.Drawing.Size(213, 26);
            this.cambiarDeUsuarioToolStripMenuItem1.Text = "Cambiar de usuario";
            this.cambiarDeUsuarioToolStripMenuItem1.Click += new System.EventHandler(this.cambiarDeUsuarioToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // reservacionesToolStripMenuItem
            // 
            this.reservacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disponibilidadDeHabitacionesToolStripMenuItem,
            this.nuevaReservacionToolStripMenuItem,
            this.verReservacionesToolStripMenuItem});
            this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.reservacionesToolStripMenuItem.Text = "Reservaciones";
            this.reservacionesToolStripMenuItem.Click += new System.EventHandler(this.reservacionesToolStripMenuItem_Click);
            // 
            // disponibilidadDeHabitacionesToolStripMenuItem
            // 
            this.disponibilidadDeHabitacionesToolStripMenuItem.Name = "disponibilidadDeHabitacionesToolStripMenuItem";
            this.disponibilidadDeHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.disponibilidadDeHabitacionesToolStripMenuItem.Text = "Disponibilidad de Habitaciones";
            this.disponibilidadDeHabitacionesToolStripMenuItem.Click += new System.EventHandler(this.disponibilidadDeHabitacionesToolStripMenuItem_Click);
            // 
            // nuevaReservacionToolStripMenuItem
            // 
            this.nuevaReservacionToolStripMenuItem.Name = "nuevaReservacionToolStripMenuItem";
            this.nuevaReservacionToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.nuevaReservacionToolStripMenuItem.Text = "Nueva Reservacion";
            this.nuevaReservacionToolStripMenuItem.Click += new System.EventHandler(this.nuevaReservacionToolStripMenuItem_Click);
            // 
            // verReservacionesToolStripMenuItem
            // 
            this.verReservacionesToolStripMenuItem.Name = "verReservacionesToolStripMenuItem";
            this.verReservacionesToolStripMenuItem.Size = new System.Drawing.Size(294, 26);
            this.verReservacionesToolStripMenuItem.Text = "Ver Reservaciones";
            this.verReservacionesToolStripMenuItem.Click += new System.EventHandler(this.verReservacionesToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.agregarNuevoToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // agregarNuevoToolStripMenuItem
            // 
            this.agregarNuevoToolStripMenuItem.Name = "agregarNuevoToolStripMenuItem";
            this.agregarNuevoToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.agregarNuevoToolStripMenuItem.Text = "Agregar Nuevo Empleado";
            this.agregarNuevoToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarClienteToolStripMenuItem,
            this.agregarNuesvoClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // agregarNuesvoClienteToolStripMenuItem
            // 
            this.agregarNuesvoClienteToolStripMenuItem.Name = "agregarNuesvoClienteToolStripMenuItem";
            this.agregarNuesvoClienteToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.agregarNuesvoClienteToolStripMenuItem.Text = "Agregar Nuevo Cliente";
            this.agregarNuesvoClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarNuesvoClienteToolStripMenuItem_Click);
            // 
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarHabitacionesToolStripMenuItem,
            this.mostrarHabitacionesToolStripMenuItem,
            this.agregarNuevaHabitacionToolStripMenuItem});
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            this.habitacionesToolStripMenuItem.Click += new System.EventHandler(this.habitacionesToolStripMenuItem_Click);
            // 
            // buscarHabitacionesToolStripMenuItem
            // 
            this.buscarHabitacionesToolStripMenuItem.Name = "buscarHabitacionesToolStripMenuItem";
            this.buscarHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.buscarHabitacionesToolStripMenuItem.Text = "Buscar Habitaciones";
            this.buscarHabitacionesToolStripMenuItem.Click += new System.EventHandler(this.buscarHabitacionesToolStripMenuItem_Click);
            // 
            // mostrarHabitacionesToolStripMenuItem
            // 
            this.mostrarHabitacionesToolStripMenuItem.Name = "mostrarHabitacionesToolStripMenuItem";
            this.mostrarHabitacionesToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.mostrarHabitacionesToolStripMenuItem.Text = "Mantenimiento Habitaciones";
            this.mostrarHabitacionesToolStripMenuItem.Click += new System.EventHandler(this.mostrarHabitacionesToolStripMenuItem_Click);
            // 
            // agregarNuevaHabitacionToolStripMenuItem
            // 
            this.agregarNuevaHabitacionToolStripMenuItem.Name = "agregarNuevaHabitacionToolStripMenuItem";
            this.agregarNuevaHabitacionToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.agregarNuevaHabitacionToolStripMenuItem.Text = "Agregar nueva Habitacion";
            this.agregarNuevaHabitacionToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevaHabitacionToolStripMenuItem_Click);
            // 
            // hotelesToolStripMenuItem
            // 
            this.hotelesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeHotelesToolStripMenuItem,
            this.agregarNuevoHotelToolStripMenuItem});
            this.hotelesToolStripMenuItem.Name = "hotelesToolStripMenuItem";
            this.hotelesToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.hotelesToolStripMenuItem.Text = "Hoteles";
            // 
            // listadoDeHotelesToolStripMenuItem
            // 
            this.listadoDeHotelesToolStripMenuItem.Name = "listadoDeHotelesToolStripMenuItem";
            this.listadoDeHotelesToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.listadoDeHotelesToolStripMenuItem.Text = "Listado de Hoteles";
            this.listadoDeHotelesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeHotelesToolStripMenuItem_Click);
            // 
            // agregarNuevoHotelToolStripMenuItem
            // 
            this.agregarNuevoHotelToolStripMenuItem.Name = "agregarNuevoHotelToolStripMenuItem";
            this.agregarNuevoHotelToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.agregarNuevoHotelToolStripMenuItem.Text = "Agregar Nuevo Hotel";
            this.agregarNuevoHotelToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoHotelToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviciosToolStripMenuItem1,
            this.agregarServicioToolStripMenuItem});
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // serviciosToolStripMenuItem1
            // 
            this.serviciosToolStripMenuItem1.Name = "serviciosToolStripMenuItem1";
            this.serviciosToolStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.serviciosToolStripMenuItem1.Text = "Servicios";
            this.serviciosToolStripMenuItem1.Click += new System.EventHandler(this.serviciosToolStripMenuItem1_Click);
            // 
            // agregarServicioToolStripMenuItem
            // 
            this.agregarServicioToolStripMenuItem.Name = "agregarServicioToolStripMenuItem";
            this.agregarServicioToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.agregarServicioToolStripMenuItem.Text = "Agregar servicio";
            this.agregarServicioToolStripMenuItem.Click += new System.EventHandler(this.agregarServicioToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(42, 24);
            this.viewMenu.Text = "&Ver";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.toolBarToolStripMenuItem.Text = "&Barra de herramientas";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.statusBarToolStripMenuItem.Text = "&Barra de estado";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(80, 24);
            this.windowsMenu.Text = "&Ventanas";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.newWindowToolStripMenuItem.Text = "&Nueva ventana";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.cascadeToolStripMenuItem.Text = "&Cascada";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.closeAllToolStripMenuItem.Text = "C&errar todo";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.arrangeIconsToolStripMenuItem.Text = "&Organizar iconos";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1271, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(993, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ACEESO";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 558);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.Text = "Sistema de Reservaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuesvoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarDeUsuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevaHabitacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadDeHabitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaReservacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeHotelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoHotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarServicioToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}



