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
    public partial class FormHabitaciones : Form
    {
        public FormHabitaciones()
        {
            InitializeComponent();
            this.llenarComboxHabitaciones();
            this.llenarComboxHabitacionesTipo();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Systema Reservaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Limpiar()
        {
            
            this.comboxHabitaciones.SelectedIndex = 0;           
            this.comboxPrecio.SelectedIndex = 0;
            this.comboxTipo.SelectedIndex = 0;
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[7].Visible = false;
            this.dataListado.Columns[8].Visible = false;
        }

        private void FormHabitaciones_Load(object sender, EventArgs e)
        {
            mostrar();
        }
        private void mostrar()
        {            
            dataListado.DataSource = NHabitaciones.MostrarTodas();
            lblTotal.Text = "Total de habitaciones: " + Convert.ToString(dataListado.Rows.Count);
            this.OcultarColumnas();
        }
        private void llenarComboxHabitaciones()
        {
            comboxHabitaciones.DataSource = NHabitaciones.MostrarTodas();
            comboxHabitaciones.ValueMember = "HAB_ID";
            comboxHabitaciones.DisplayMember= "HAB_NUM";
        }
        private void llenarComboxHabitacionesTipo()
        {
            comboxTipo.DataSource = NHabitaciones.MostrarTodas();
            comboxTipo.ValueMember = "HAB_ID";
            comboxTipo.DisplayMember = "HAB_TIPO";
        }
        private void comboxHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string par;
                //par=Convert.ToString(row.Cells[2].Value);
            dataListado.DataSource = NHabitaciones.BuscarNum(this.comboxHabitaciones.Text);
            lblTotal.Text = "Habitaciones " + Convert.ToString(dataListado.Rows.Count);
        }

        private void comboxPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboxPrecio.SelectedIndex)
            {
                case 1:
                    this.dataListado.DataSource = NHabitaciones.MostrarPrecioMax();
                    lblTotal.Text = "Total de Habitaciones de precio maximo: " + Convert.ToString(dataListado.Rows.Count);
                    break;

                case 2:
                    this.dataListado.DataSource = NHabitaciones.MostrarPrecioMin();
                    lblTotal.Text = "Total de Habitaciones de precio minimo: " + Convert.ToString(dataListado.Rows.Count);
                    break;

                default:
                    this.dataListado.DataSource = NHabitaciones.MostrarTodas();
                    lblTotal.Text = "Total de Habitaciones: " + Convert.ToString(dataListado.Rows.Count);
                    break;
            }
        }

        private void comboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch(comboxTipo.SelectedIndex)
            {
                case 1:
                    dataListado.DataSource = NHabitaciones.BuscarTipo(this.comboxTipo.Text);
                    lblTotal.Text = "Total de Habitaciones Sencillas: " + Convert.ToString(dataListado.Rows.Count);
                    break;

                case 2:
                    dataListado.DataSource = NHabitaciones.BuscarTipo(this.comboxTipo.Text);
                    lblTotal.Text = "Total de Habitaciones Dobles: " + Convert.ToString(dataListado.Rows.Count);
                    break;

                case 3:
                    dataListado.DataSource = NHabitaciones.BuscarTipo(this.comboxTipo.Text);
                    lblTotal.Text = "Total de Habitaciones Triples: " + Convert.ToString(dataListado.Rows.Count);
                    break;

                case 4:
                    dataListado.DataSource = NHabitaciones.BuscarTipo(this.comboxTipo.Text);
                    lblTotal.Text = "Total de Habitaciones Suite: " + Convert.ToString(dataListado.Rows.Count);
                    break;

                default:
                    this.dataListado.DataSource = NHabitaciones.MostrarTodas();
                    lblTotal.Text = "Total de Habitaciones: " + Convert.ToString(dataListado.Rows.Count);
                    break;
            }
        }

        private void btnRefrescarList_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
