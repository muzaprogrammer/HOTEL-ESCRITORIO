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
    public partial class FormNuevoCliente : Form
    {

        public FormNuevoCliente()
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
        
        private void  MensajeOk (string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Limpiar()
        {
            this.txtNombres.Text = string.Empty;
            this.txtApellidos.Text = string.Empty;
            this.txtTDocumento.Text = string.Empty;
            this.txtNDocumento.Text = string.Empty;
            this.comboxGenero.SelectedIndex = 0;
            this.txtTelefono.Text = string.Empty;
            this.txtPais.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
        }
        private void GuardarCliente()
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
                    rpta = NCliente.Insertar(txtNombres.Text, txtApellidos.Text, txtTDocumento.Text, txtNDocumento.Text, dtpFechaNacimiento.Value, Convert.ToString(comboxGenero.SelectedItem), txtTelefono.Text, txtPais.Text, txtEmail.Text);
                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Se agrego el Cliente correctamente");
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

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            GuardarCliente();
            Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();            
        }

        private void FormNuevoCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
