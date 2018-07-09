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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }       
        public void accederalsistema()
        {
            DataTable Datos = CapaNegocio.NEmpleado.Login(this.txtUsuario.Text, this.txtPasword.Text);
            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("No tiene acceso al sistema", "Sistema de reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormPrincipal form = new FormPrincipal();
                form.IdTrabajador = Datos.Rows[0][0].ToString();
                form.Apellidos = Datos.Rows[0][1].ToString();
                form.Nombres = Datos.Rows[0][2].ToString();
                form.Acceso = Datos.Rows[0][3].ToString();
                form.Show();
                this.Hide();
                
            }
        }
       
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            accederalsistema();
        }       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
