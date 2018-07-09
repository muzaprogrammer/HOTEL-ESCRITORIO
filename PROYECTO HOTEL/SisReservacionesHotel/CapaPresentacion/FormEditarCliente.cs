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
    public partial class FormEditarCliente : Form
    {
        private static FormEditarCliente _Instancia;

        public static FormEditarCliente GetInstancia()
        {
            if (_Instancia==null)
            {
                _Instancia = new FormEditarCliente();
            }
            return _Instancia;
        }
        public void SetCliente (string idcliente, string nombre, string apellido, string tipodoc, string ndoc,
            string fechanac, string genero, string telefono, string pais, string email)
        {
            
            this.txtIdCliente.Text = idcliente;
            this.txtNombres.Text = nombre;
            this.txtApellidos.Text = apellido;
            this.txtTDocumento.Text = tipodoc;
            this.txtNDocumento.Text = ndoc;
            this.comboxGenero.Text = genero;
            this.dtpFechaNacimiento.Value = Convert.ToDateTime(fechanac);
            this.txtPais.Text = pais;
            this.txtEmail.Text = email;
            this.txtTelefono.Text = telefono;
        }
        public FormEditarCliente()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombres, "Digite el Nombre del Cliente");
            this.ttMensaje.SetToolTip(this.txtApellidos, "Digite el Apellido del Cliente");
            this.ttMensaje.SetToolTip(this.txtTDocumento, "Digite el Tipo de Documento del Cliente");
            this.ttMensaje.SetToolTip(this.txtNDocumento, "Digite el Numero de Documento del Cliente");
            this.ttMensaje.SetToolTip(this.comboxGenero, "Seleccione el Genero del Cliente");
            this.ttMensaje.SetToolTip(this.dtpFechaNacimiento, "Seleccione La Fecha de Nacimiento del Cliente");
            this.ttMensaje.SetToolTip(this.txtPais, "Digite el Pais del Cliente");
            this.ttMensaje.SetToolTip(this.txtEmail, "Digite el Email del Cliente");
            this.ttMensaje.SetToolTip(this.txtTelefono, "Digite el Telefono del Cliente");
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void EditarCliente()
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
                    rpta = NCliente.Editar(Convert.ToInt32(txtIdCliente.Text), txtNombres.Text, txtApellidos.Text, txtTDocumento.Text, txtNDocumento.Text, dtpFechaNacimiento.Value, Convert.ToString(comboxGenero.SelectedItem), txtTelefono.Text, txtPais.Text, txtEmail.Text);

                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Se Editaron los datos del Cliente correctamente");
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
        private void FormEditarCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            EditarCliente();
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
