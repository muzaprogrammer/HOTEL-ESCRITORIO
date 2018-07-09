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
    public partial class FormEditarReservacion : Form
    {
        private static FormEditarReservacion _Instancia;
        public DateTime newDate, oldDate;
        public string resid;
        public static FormEditarReservacion GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FormEditarReservacion();
            }
            return _Instancia;
        }
        public FormEditarReservacion()
        {
            string sellecionar = "";
            InitializeComponent();
            SetHabitacion(sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar);
            SetCliente(sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar);
            this.label10.Text = "No de Noches: ";
            SetEmpleado(sellecionar, sellecionar, sellecionar, sellecionar);
            pago();
            comboxDescuento.SelectedIndex = 9;

        }
        private void FormEditarReservacion_Load(object sender, EventArgs e)
        {
            lbltxtPrecioNoche.Text = "";
            comboxDescuento.SelectedIndex = 9;            
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void SetCalculateDays(DateTime oldDate, DateTime newDate)
        {
            TimeSpan ts;
            // Diferencia de fechas
            ts = newDate.Date - oldDate.Date;

            // Diferencia de días
            int noches = ts.Days;
            this.label101.Text = Convert.ToString(noches);
            txtNumNoches.Text = Convert.ToString(noches);
        }
        public void SetHabitacion(string idHab, string NumHab, string tipo,
           string NumCam, string precio, string estado, string checkin, string checkout, string fechares)
        {

            this.label1.Text = idHab;
            this.label2.Text = "Numero de Habitacion: " + NumHab;
            this.label3.Text = "Tipo de habitaciones: " + tipo;
            this.label4.Text = "Numero de camas: " + NumCam;
            this.label51.Text = "Precio";
            this.label5.Text = precio;
            this.label6.Text = "Estado: " + estado;
            this.label7.Text = "Checkin: " + checkin;
            this.label8.Text = "Checkout: " + checkout;
            this.label9.Text = "Fecha de Reservacion: " + fechares;
        }
        public void pago()
        {
            this.label21.Text = "Precio: ";
            this.label22.Text = "Total: ";

        }
        public void SetCliente(string par1, string par2, string par3, string par4, string par5, string par6, string par7, string par8, string par9, string par10)
        {
            this.label11.Text = par1;
            this.label12.Text =  par2;
            this.label13.Text = par3;
            this.label14.Text = par4;
            this.label15.Text = par5;
            this.label16.Text = par6;
            this.label17.Text = par7;
            this.label18.Text = par8;
            this.label19.Text = par9;
            this.label20.Text = par10;
                        
            this.label41.Text = "Nombres: " ;
            this.label42.Text = "Apellidos: ";
            this.label43.Text = "Tipo de documento: " ;
            this.label44.Text = "No Documento: ";
            this.label45.Text = "Fecha Nac: " ;
            this.label46.Text = "Genero: " ;
            this.label47.Text = "Telefono: " ;
            this.label48.Text = "Pais: " ;
            this.label49.Text = "Email: ";
        }
        public void SetCombox(string estadoReserva, string estadoPago)
        {
            comboxEstadoPago.Text = estadoPago;
            comboxReserva.Text = estadoReserva;
        }

        private void btnSlctHabitacion_Click(object sender, EventArgs e)
        {
            FormDisponibilidad form = new FormDisponibilidad();
            form.ShowDialog();
            lbltxtPrecioNoche.Text = label5.Text;
        }

        private void btnSlctCliente_Click(object sender, EventArgs e)
        {
            FormEditarCliente form = FormEditarCliente.GetInstancia();
            string par1, par2, par3, par4, par5, par6, par7, par8, par9, par10;
            par1=this.label11.Text;
            par2=this.label12.Text;
            par3=this.label13.Text;
            par4=this.label14.Text;
            par5=this.label15.Text;
            par6=this.label16.Text;
            par7=this.label17.Text;
            par8=this.label18.Text;
            par9=this.label19.Text;
            par10=this.label20.Text;
            form.SetCliente(par1, par2, par3, par4, par5, par6, par7, par8, par9, par10);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Instancia = null;
            this.Close();
        }

        private void FormEditarReservacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void comboxDescuento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboxDescuento.SelectedIndex)
            {
                case 0:
                    double precioDesc;
                    lbltxtPrecioNoche.Text = Convert.ToString(label5.Text);
                    break;
                case 1:
                    precioDesc = Convert.ToDouble(this.label5.Text) - (Convert.ToDouble(this.label5.Text) * 0.05);
                    this.lbltxtPrecioNoche.Text = Convert.ToString(precioDesc);
                    break;
                case 2:
                    precioDesc = Convert.ToDouble(this.label5.Text) - (Convert.ToDouble(this.label5.Text) * 0.1);
                    this.lbltxtPrecioNoche.Text = Convert.ToString(precioDesc);
                    break;
                case 3:
                    precioDesc = Convert.ToDouble(this.label5.Text) - (Convert.ToDouble(this.label5.Text) * 0.15);
                    this.lbltxtPrecioNoche.Text = Convert.ToString(precioDesc);
                    break;
                case 4:
                    precioDesc = Convert.ToDouble(this.label5.Text) - (Convert.ToDouble(this.label5.Text) * 0.2);
                    this.lbltxtPrecioNoche.Text = Convert.ToString(precioDesc);
                    break;
                case 5:
                    precioDesc = Convert.ToDouble(this.label5.Text) - (Convert.ToDouble(this.label5.Text) * 0.25);
                    this.lbltxtPrecioNoche.Text = Convert.ToString(precioDesc);
                    break;
                case 6:
                    precioDesc = Convert.ToDouble(this.label5.Text) - (Convert.ToDouble(this.label5.Text) * 0.3);
                    this.lbltxtPrecioNoche.Text = Convert.ToString(precioDesc);
                    break;
                case 7:
                    precioDesc = Convert.ToDouble(this.label5.Text) - (Convert.ToDouble(this.label5.Text) * 0.35);
                    this.lbltxtPrecioNoche.Text = Convert.ToString(precioDesc);
                    break;
                case 8:
                    precioDesc = Convert.ToDouble(this.label5.Text) - (Convert.ToDouble(this.label5.Text) * 0.5);
                    this.lbltxtPrecioNoche.Text = Convert.ToString(precioDesc);
                    break;
                default:
                    lbltxtPrecioNoche.Text = Convert.ToString(label5.Text);
                    break;
            }
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {
            lbltxtPrecioNoche.Text = label5.Text;
        }

        private void label101_TextChanged(object sender, EventArgs e)
        {
            txtNumNoches.Text = label101.Text;
        }

        private void lbltxtPrecioNoche_TextChanged(object sender, EventArgs e)
        {
            txtTotal.Text = lbltxtPrecioNoche.Text;
        }

        public void SetEmpleado(string id, string nombre, string apelleido, string turno)
        {
            label28.Text = id;
            label29.Text = "Nombre: " + nombre + " " + apelleido;
            label30.Text = "Turno: " + turno;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarReserva();
        }
        
        private void GuardarReserva()
        {
            DateTime fechaHoy = DateTime.Now;
            TimeSpan ts = newDate.Date - oldDate.Date;
            int noches = ts.Days;

            int RES_ID = Convert.ToInt32(resid);
            int HAB_ID = Convert.ToInt32(label1.Text);
            int CLI_ID = Convert.ToInt32(label11.Text);
            int EMP_ID = Convert.ToInt32(label28.Text);
            string ESTADO_HAB = comboxReserva.Text;
            DateTime FECHA_RESERVACION = fechaHoy;
            DateTime CHECKIN = oldDate;
            DateTime CHECKOUT = newDate;
            int N_NOCHES = Convert.ToInt32(label101.Text);
            double COSTO_NOCHES = Convert.ToDouble(lbltxtPrecioNoche.Text);
            double COSTO_TOTAL = Convert.ToDouble(label31.Text);
            string ESTADO_PAGO = Convert.ToString(comboxEstadoPago.Text);
            string OBSERVACIONES = txtObservaciones.Text;


            try
            {
                string rpta = "";
                if (this.label1.Text == string.Empty || this.label11.Text == string.Empty || this.label28.Text == string.Empty)
                {
                    MensajeError("Faltan campos obligatorios");
                    errorIcono.SetError(label1, "Debe seleccionar una habitacion");
                    errorIcono.SetError(label11, "Debe seleccionar cliente");
                    errorIcono.SetError(label28, "Debe seleccionar empleado");
                }
                else
                {
                    rpta = NReserva.EditarReserva(RES_ID, HAB_ID, CLI_ID, EMP_ID, ESTADO_HAB, FECHA_RESERVACION, CHECKIN, CHECKOUT, N_NOCHES, COSTO_NOCHES, COSTO_TOTAL, ESTADO_PAGO, OBSERVACIONES);
                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Se Edito la Reservacion correctamente");
                    Close();
                }
                else
                {
                    this.MensajeError("Fallo el la reservacion");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtTotal_TextChanged_1(object sender, EventArgs e)
        {
            TimeSpan ts = newDate.Date - oldDate.Date;
            int noches = ts.Days;
            double precio = Convert.ToDouble(txtTotal.Text);
            double total = precio * noches;
            label31.Text = Convert.ToString(total);
        }
       
    }
}
