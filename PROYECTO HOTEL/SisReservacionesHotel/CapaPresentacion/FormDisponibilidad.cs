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
    public partial class FormDisponibilidad : Form
    {
        public FormDisponibilidad()
        {
            InitializeComponent();
            this.llenarComboxHabitacionesNum();
            this.llenarComboxHabitacionesNum2();
        }

        private void FormDisponibilidad_Load(object sender, EventArgs e)
        {
            MostrarDisponibles();
            MostrarNoDisponibles();
        }
        private void llenarComboxHabitacionesNum()
        {
            comboxHabitaciones.DataSource = NHabitaciones.MostrarTodas();
            comboxHabitaciones.ValueMember = "HAB_ID";
            comboxHabitaciones.DisplayMember = "HAB_NUM";
        }
        private void llenarComboxHabitacionesNum2()
        {
            comboBox1.DataSource = NHabitaciones.MostrarTodas();
            comboBox1.ValueMember = "HAB_ID";
            comboBox1.DisplayMember = "HAB_NUM";
        }
        private void comboxHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataListado.DataSource = NDisponibilidad.MostrarDisponiblesNum(this.dateTimePicker1.Value, this.dateTimePicker2.Value, this.comboxHabitaciones.Text);
            lblTotal.Text = "Total de Habitaciones Disponibles: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MostrarDisponibles();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            MostrarDisponibles();
        }
        private void MostrarDisponibles()
        {
            this.dataListado.Columns[0].Visible = false;            
            this.dataListado.DataSource = NDisponibilidad.MostrarDisponibles(this.dateTimePicker1.Value, this.dateTimePicker2.Value);
            lblTotal.Text = "Total de Habitaciones Disponibles: " + Convert.ToString(dataListado.Rows.Count);
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = NDisponibilidad.MostrarNoDisponiblesNum(this.dateTimePicker3.Value, this.dateTimePicker3.Value, this.comboBox1.Text);
            label5.Text = "Total de Habitaciones Disponibles: " + Convert.ToString(dataGridView1.Rows.Count);
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            MostrarNoDisponibles();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            MostrarNoDisponibles();
        }
        private void MostrarNoDisponibles()
        {
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.DataSource = NDisponibilidad.MostrarNoDisponibles(this.dateTimePicker3.Value, this.dateTimePicker4.Value);
            label5.Text = "Total de Habitaciones No Disponibles: " + Convert.ToString(dataGridView1.Rows.Count);
        }
    }
}
