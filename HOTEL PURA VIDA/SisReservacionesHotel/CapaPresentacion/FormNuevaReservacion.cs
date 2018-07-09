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
    public partial class FormNuevaReservacion : Form
    {
        private static FormNuevaReservacion _Instancia;

        public static FormNuevaReservacion GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FormNuevaReservacion();
            }
            
            return _Instancia;
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
            this.label7.Text = "Checkin: "+checkin;
            this.label8.Text = "Checkout: "+checkout;
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
            this.label12.Text = "Nombres: " + par2;
            this.label13.Text = "Apellidos: " + par3;
            this.label14.Text = "Tipo de documento: " + par4;
            this.label15.Text = "No Documento: " + par5;
            this.label16.Text = "Fecha Nac: " + par6;
            this.label17.Text = "Genero: " + par7;
            this.label18.Text = "Telefono: " + par8;
            this.label19.Text = "Pais: " + par9;
            this.label20.Text = "Email: " + par10;
        }
        
        public void SetEmpleado(string id, string nombre, string apelleido, string turno)
        {
            label28.Text = id;
            label29.Text = "Nombre: "+ nombre + " " + apelleido;
            label30.Text = "Turno: " + turno;
        }
        public FormNuevaReservacion()
        {
            string sellecionar = "";
            InitializeComponent();
            SetHabitacion(sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar);
            SetCliente(sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar, sellecionar);
            this.label10.Text = "No de Noches: ";                   
            SetEmpleado(sellecionar, sellecionar, sellecionar, sellecionar);
            pago();
        }

        private void FormNuevaReservacion_Load(object sender, EventArgs e)
        {
            lbltxtPrecioNoche.Text = "";            
            comboxDescuento.SelectedIndex = 9;            
        }
        private void btnSlctHabitacion_Click_1(object sender, EventArgs e)
        {
            FormDisponibilidad form = new FormDisponibilidad();
            form.ShowDialog();
            lbltxtPrecioNoche.Text = label5.Text;
        }
        
        private void btnSlctCliente_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.ShowDialog();
        }
        private void btnSlctEmp_Click(object sender, EventArgs e)
        {
            FormEmpleados form = new FormEmpleados();
            form.ShowDialog();
  
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _Instancia = null;
            this.Close();
        }

        private void FormNuevaReservacion_FormClosed(object sender, FormClosedEventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {
            lbltxtPrecioNoche.Text = label5.Text;
        }

        private void txtPrecioNoche_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label101_Click(object sender, EventArgs e)
        {

        }

        private void label101_TextChanged(object sender, EventArgs e)
        {
            txtNumNoches.Text = label101.Text;
        }

        private void txtPrecioNoche_TextChanged_1(object sender, EventArgs e)
        {            
            txtTotal.Text=lbltxtPrecioNoche.Text;
            //comboxDescuento.SelectedIndex = 1;
            //comboxDescuento.SelectedText = "";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        public DateTime newDate, oldDate;

        private void lbltxtPrecioNoche_Click(object sender, EventArgs e)
        {

        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void GuardarReserva()
        {
            DateTime fechaHoy = DateTime.Now;
            TimeSpan ts = newDate.Date - oldDate.Date;
            int noches = ts.Days;

            int HAB_ID = Convert.ToInt32(label1.Text);
            int CLI_ID = Convert.ToInt32(label11.Text);
            int EMP_ID = Convert.ToInt32(label28.Text);
            string ESTADO_HAB = "RESERVADA";
            DateTime FECHA_RESERVACION = fechaHoy;
            DateTime CHECKIN = oldDate;
            DateTime CHECKOUT = newDate;
            int N_NOCHES = Convert.ToInt32(label101.Text);
            double COSTO_NOCHES = Convert.ToDouble(lbltxtPrecioNoche.Text);
            double COSTO_TOTAL = Convert.ToDouble(label31.Text);
            string ESTADO_PAGO = Convert.ToString(comboxEstadoPago.SelectedItem);
            string OBSERVACIONES = txtObservaciones.Text;


            try
            {
                string rpta = "";
                if (this.label1.Text == string.Empty || this.label11.Text == string.Empty || this.label28.Text == string.Empty )
                {
                    MensajeError("Faltan campos obligatorios");
                    errorIcono.SetError(label1, "Debe seleccionar una habitacion");
                    errorIcono.SetError(label11, "Debe seleccionar cliente");
                    errorIcono.SetError(label28, "Debe seleccionar empleado");
                }
                else
                {
                    rpta = NReserva.InsertarReserva(HAB_ID, CLI_ID, EMP_ID, ESTADO_HAB, FECHA_RESERVACION, CHECKIN, CHECKOUT, N_NOCHES, COSTO_NOCHES, COSTO_TOTAL, ESTADO_PAGO, OBSERVACIONES);
                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Se agrego la Reservacion correctamente");
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarReserva();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            TimeSpan ts = newDate.Date - oldDate.Date;            
            int noches = ts.Days;            
            double precio = Convert.ToDouble(txtTotal.Text);
            double total = precio * noches;
            label31.Text = Convert.ToString(total);
        }
    }
}
