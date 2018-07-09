using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormNuevoEmpleado : Form
    {
        public FormNuevoEmpleado()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombres, "Digite el Nombre del Empleado");
            this.ttMensaje.SetToolTip(this.txtApellidos, "Digite el Apellido del Empleado");
            this.ttMensaje.SetToolTip(this.txtTDocumento, "Digite el Tipo de Documento del Empleado");
            this.ttMensaje.SetToolTip(this.txtNDocumento, "Digite el Numero de Documento del Empleado");
            this.ttMensaje.SetToolTip(this.comboxGenero, "Seleccione el Genero del Empleado");
            this.ttMensaje.SetToolTip(this.dtpFechaNacimiento, "Seleccione La Fecha de Nacimiento del Empleado");
            this.ttMensaje.SetToolTip(this.dtpFechaIngreso, "Seleccione La Fecha de Nacimiento del Empleado");
            this.ttMensaje.SetToolTip(this.comboxTurno, "Seleccione el Genero del Empleado");
            this.ttMensaje.SetToolTip(this.txtNDocumento, "Digite la Direccion del Empleado");            
            this.ttMensaje.SetToolTip(this.txtTelefono, "Digite el Telefono del Empleado");
            this.ttMensaje.SetToolTip(this.txtSueldo, "Digite el Sueldo del Empleado");
            this.ttMensaje.SetToolTip(this.txtUsuario, "Digite el Usuario del Empleado");
            this.ttMensaje.SetToolTip(this.txtPasword, "Digite el Pasword del Empleado");
            this.ttMensaje.SetToolTip(this.comboxAcceso, "Seleccione el tipo de Acceso del Empleado");
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void GuardarEmpleado()
        {
            try
            {
                string rpta = "";
                if (this.txtNombres.Text == string.Empty || this.txtApellidos.Text == string.Empty)
                {
                    MensajeError("Nombre y Apellido son campos obligatoros");
                    errorIcono.SetError(txtNombres, "Ingrese el al menos un Nombre");
                    errorIcono.SetError(txtApellidos, "Ingrese el al menos un Apellido");
                }
                else
                {
                    rpta = NEmpleado.Insertar(txtNombres.Text, txtApellidos.Text, txtTDocumento.Text, 
                    txtNDocumento.Text, txtDireccion.Text, dtpFechaNacimiento.Value, dtpFechaIngreso.Value, 
                    Convert.ToDouble(txtSueldo.Text), Convert.ToString(comboxGenero.SelectedItem), txtTelefono.Text, 
                    Convert.ToString(comboxTurno.SelectedItem), txtUsuario.Text, txtPasword.Text, Convert.ToString(comboxAcceso.SelectedItem));
                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Se agrego el Empleado correctamente");
                }
                else
                {
                    this.MensajeError("Vuelva a intentarlo");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FormNuevoEmpleado_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            this.GuardarEmpleado();
            Close();
        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
