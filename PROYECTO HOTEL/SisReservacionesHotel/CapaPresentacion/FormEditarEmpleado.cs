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
    public partial class FormEditarEmpleado : Form
    {
        public FormEditarEmpleado()
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
        private static FormEditarEmpleado _Instancia;

        public static FormEditarEmpleado GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FormEditarEmpleado();
            }
            return _Instancia;
        }
        public void SetEmpleado(string id, string nombre, string apellido, string tipodoc, string ndoc,
            string direccion, string fechanac, string fechaingreso, string sueldo, string genero, 
            string telefono, string turno, string usuario, string pasword, string acceso)
        {

            this.txtIdEmp.Text = id;
            this.txtNombres.Text = nombre;
            this.txtApellidos.Text = apellido;
            this.txtTDocumento.Text = tipodoc;
            this.txtNDocumento.Text = ndoc;
            this.comboxGenero.Text = genero;
            this.dtpFechaNacimiento.Value = Convert.ToDateTime(fechanac);
            this.dtpFechaIngreso.Value = Convert.ToDateTime(fechaingreso);
            this.comboxTurno.Text = turno;
            this.txtDireccion.Text = direccion;
            this.txtTelefono.Text = telefono;
            this.txtSueldo.Text = sueldo;
            this.txtUsuario.Text = usuario;
            this.txtPasword.Text = pasword;
            this.comboxAcceso.Text = acceso;
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }       
        private void EditarEmpleado()
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
                    rpta = NEmpleado.Editar(Convert.ToInt32(txtIdEmp.Text), txtNombres.Text, txtApellidos.Text, txtTDocumento.Text,
                    txtNDocumento.Text, txtDireccion.Text, dtpFechaNacimiento.Value, dtpFechaIngreso.Value,
                    Convert.ToDouble(txtSueldo.Text), Convert.ToString(comboxGenero.SelectedItem), txtTelefono.Text,
                    Convert.ToString(comboxTurno.SelectedItem), txtUsuario.Text, txtPasword.Text, Convert.ToString(comboxAcceso.SelectedItem));

                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Se Editaron los datos del Empleado correctamente");
                }
                else
                {
                    this.MensajeError("Vuelva a intentarlo");
                }
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FormEditarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            this.EditarEmpleado();
        }
    }
}
