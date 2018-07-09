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
    public partial class FormAgregarHotel : Form
    {
        public FormAgregarHotel()
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
        private void GuardarHotel()
        {
            try
            {
                string rpta = "";
                if (this.txtNoHab.Text == string.Empty || this.txtPais.Text == string.Empty)
                {
                    MensajeError("Por favor llene todos los campos con informacion valida");
                    errorIcono.SetError(txtNoHab, "Ingrese un nombre valido");
                    errorIcono.SetError(txtPais, "Ingrese un pais valido");
                }

                else
                {
                    rpta = NHoteles.Insertar(txtNoHab.Text, txtPais.Text);
                    Close();                    
                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Se agrego Hotel correctamente");
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
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            GuardarHotel();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAgregarHotel_Load(object sender, EventArgs e)
        {

        }
    }
}
