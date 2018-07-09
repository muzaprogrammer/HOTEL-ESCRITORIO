using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class FormPrincipal : Form
    {
        private int childFormNumber = 0;
        public string IdTrabajador = "";
        public string Apellidos = "";
        public string Nombres = "";
        public string Acceso="";
                      
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleados form = new FormEmpleados();
            form.MdiParent = this;
            form.Show();
        }

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevoEmpleado form = new FormNuevoEmpleado();
            form.MdiParent = this;
            form.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.MdiParent = this;
            form.Show();
        }

        private void agregarNuesvoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevoCliente form = new FormNuevoCliente();
            form.MdiParent = this;
            form.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //this.GestionUsuario();
        }
     
        public void GestionUsuario()
        {
            if(Acceso =="Administrador")
            {
                this.empleadosToolStripMenuItem.Enabled= true;
                this.clientesToolStripMenuItem.Enabled = true;
                this.habitacionesToolStripMenuItem.Enabled = true;
                this.reservacionesToolStripMenuItem.Enabled = true;
                this.herramientasToolStripMenuItem.Enabled = true;              
                
            }
            else if (Acceso =="Usuario")
            {
                this.empleadosToolStripMenuItem.Enabled = true;
                this.clientesToolStripMenuItem.Enabled = true;
                this.habitacionesToolStripMenuItem.Enabled = false;
                this.reservacionesToolStripMenuItem.Enabled = false;
                this.herramientasToolStripMenuItem.Enabled = false;
                
            }
            else
            {
                this.empleadosToolStripMenuItem.Enabled = false;
                this.clientesToolStripMenuItem.Enabled = false;
                this.habitacionesToolStripMenuItem.Enabled = false;
                this.reservacionesToolStripMenuItem.Enabled = false;
                this.herramientasToolStripMenuItem.Enabled = false;
               
            }
        }      

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void buscarHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHabitaciones form = new FormHabitaciones();
            form.MdiParent = this;
            form.Show();
        }

        private void mostrarHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditarEliminarHabitaciones form = new FormEditarEliminarHabitaciones();
            form.MdiParent = this;
            form.Show();
        }

        private void cambiarDeUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            this.Close();
            form.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarNuevaHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarHabitacion form = new FormAgregarHabitacion();
            form.MdiParent = this;
            form.Show();
        }

        private void disponibilidadDeHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisponibilidad form = new FormDisponibilidad();
            form.MdiParent = this;
            form.Show();
        }

        private void nuevaReservacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevaReservacion form = new FormNuevaReservacion();
            form.MdiParent = this;
            form.Show();
        }
    }
}
