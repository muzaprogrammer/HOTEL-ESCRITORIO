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
    public partial class FormAgregarServicio : Form
    {
        public FormAgregarServicio()
        {
            InitializeComponent();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            GuardarServicio();
        }
        private void GuardarServicio()
        {
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty || this.txtPrecio.Text == string.Empty)
                {
                    MensajeError("Por favor llene todos los campos con informacion valida");
                    errorIcono.SetError(txtNombre, "Ingrese un nombre valido");
                    errorIcono.SetError(txtPrecio, "Ingrese un Numero valido");
                }

                else
                {
                    rpta = NServicios.Insertar(txtNombre.Text, txtObservaciones.Text,Convert.ToDouble( txtPrecio.Text));
                    Close();
                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Se agrego el Servicio correctamente");
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
    }
}
