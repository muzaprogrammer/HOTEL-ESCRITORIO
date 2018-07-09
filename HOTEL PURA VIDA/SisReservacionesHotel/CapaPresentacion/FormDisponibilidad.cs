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
        }

        private void FormDisponibilidad_Load(object sender, EventArgs e)
        {
            MostrarDisponibles();
            MostrarNoDisponibles();
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
            this.dataGridView1.DataSource = NDisponibilidad.MostrarNoDisponibles(this.dateTimePicker3.Value.Date, this.dateTimePicker4.Value.Date);
            label5.Text = "Total de Habitaciones No Disponibles: " + Convert.ToString(dataGridView1.Rows.Count);
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            FormNuevaReservacion form = FormNuevaReservacion.GetInstancia();
            FormEditarReservacion form2 = FormEditarReservacion.GetInstancia();        

            string par1, par2, par3, par4, par5, par6, par7, par8, par9;
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["HAB_ID"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["#HABITACION"].Value);
            par3 = Convert.ToString(this.dataListado.CurrentRow.Cells["HAB_TIPO"].Value);
            par4 = Convert.ToString(this.dataListado.CurrentRow.Cells["HAB_NUM_CAMAS"].Value);
            par5 = Convert.ToString(this.dataListado.CurrentRow.Cells["PRECIO"].Value);
            par6 = Convert.ToString(this.dataListado.CurrentRow.Cells["HAB_ESTADO"].Value);
            par7 = Convert.ToString(this.dateTimePicker1.Value.ToShortDateString());
            par8 = Convert.ToString(this.dateTimePicker2.Value.ToShortDateString());
            par9 = DateTime.Now.ToShortDateString();

            form.SetHabitacion(par1, par2, par3, par4, par5, par6, par7, par8, par9);
            form2.SetHabitacion(par1, par2, par3, par4, par5, par6, par7, par8, par9);
            form.SetCalculateDays(dateTimePicker1.Value, dateTimePicker2.Value);
            form2.SetCalculateDays(dateTimePicker1.Value, dateTimePicker2.Value);
            form.newDate = dateTimePicker2.Value;
            form.oldDate = dateTimePicker1.Value;
            form2.newDate = dateTimePicker2.Value;
            form2.oldDate = dateTimePicker1.Value;
            this.Hide();
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
