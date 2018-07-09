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
    public partial class FormEditarHabitacion : Form
    {
        public FormEditarHabitacion()
        {
            InitializeComponent();
        }
        private static FormEditarHabitacion _Instancia;

        public static FormEditarHabitacion GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FormEditarHabitacion();
            }
            return _Instancia;
        }
        public void SetHabitacion(string id, string num, string piso, string tipo, string numcamas,
            string precio)
        {

            this.txtIdHab.Text = id;
            this.txtNoHab.Text = num;
            this.txtPiso.Text = piso;
            this.comboxTipo.Text = tipo;
            this.txtNoCamas.Text = numcamas;
            this.txtPrecio.Text = precio;            
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void FormEditarHabitacion_Load(object sender, EventArgs e)
        {

        }
        private void EditarHabitacion()
        {
            try
            {
                string rpta = "";
                if (this.txtNoHab.Text == string.Empty || this.txtPiso.Text == string.Empty || this.comboxTipo.Text == string.Empty || this.txtNoCamas.Text == string.Empty || this.txtPrecio.Text == string.Empty)
                {
                    MensajeError("Por favor llene todos los campos con informacion valida");
                    errorIcono.SetError(txtNoHab, "Ingrese un numero de habitacion valido");
                    errorIcono.SetError(txtPiso, "Ingrese un numero de piso valido");
                    errorIcono.SetError(txtNoCamas, "Ingrese un numero de camas valido");
                    errorIcono.SetError(comboxTipo, "Ingrese un tipo de Habitacion valido");
                    errorIcono.SetError(txtPiso, "Ingrese un precio valido");
                }
                else
                {
                    rpta = NHabitaciones.Editar(Convert.ToInt32(txtIdHab.Text), Convert.ToInt32(txtNoHab.Text), Convert.ToInt32(txtPiso.Text), comboxTipo.Text,
                    Convert.ToInt32(txtNoCamas.Text), Convert.ToDouble(txtPrecio.Text), "DISPONIBLE", 1);

                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Se Editaron los datos de la Habitacion correctamente");
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
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            this.EditarHabitacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
