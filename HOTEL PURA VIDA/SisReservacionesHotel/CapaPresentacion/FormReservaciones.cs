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
    public partial class FormReservaciones : Form
    {
        //bool Isnuevo = false;
        //bool Iseditar = false;
        public FormReservaciones()
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
        private void BuscarFecha()
        {
            this.dataListado.DataSource = NDisponibilidad.MostrarNoDisponibles(this.dateTimePicker1.Value.Date, this.dateTimePicker2.Value.Date);
        }
        private void MostrarReservas()
        {
            this.dataListado.DataSource = NReserva.MostrarReservas();
        }
        private void BuscarresPorNomCli()
        {
            dataListado.DataSource = NReserva.BuscarResClienteNombre(this.txtCli1.Text, this.txtCli2.Text);
        }
        private void BuscarresPorPaisCli()
        {
            dataListado.DataSource = NReserva.BuscarResPaisCli(this.textBox1.Text, this.textBox2.Text);
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[2].Visible = false;
            this.dataListado.Columns[7].Visible = false;
            this.dataListado.Columns[12].Visible = false;
            this.dataListado.Columns[22].Visible = false;
            this.dataListado.Columns[6].Visible = false;
        }
        private void FormReservaciones_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            MostrarReservas();
            this.dataListado.Columns[0].Visible = false;
            OcultarColumnas();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            BuscarFecha();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BuscarFecha();
        }

        private void txtCli1_TextChanged(object sender, EventArgs e)
        {
            BuscarresPorNomCli();            
        }

        private void txtCli2_TextChanged(object sender, EventArgs e)
        {
            BuscarresPorNomCli();            
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell checkBox12 = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Seleccionar"];
                checkBox12.Value = !Convert.ToBoolean(checkBox12.Value);
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormNuevaReservacion form =  FormNuevaReservacion.GetInstancia();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void limpiar()
        {
            this.checkBox12.Checked = false;
            this.txtCli1.Text = string.Empty;
            this.txtCli2.Text = string.Empty;
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            this.dateTimePicker1.Value = DateTime.Now.Date;
            this.dateTimePicker2.Value = DateTime.Now.Date;
            MostrarReservas();
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void eliminar()
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta seguro de eliminar la Reservacion", "Sistema de reservaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    String Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NReserva.EliminarReserva(Convert.ToInt32(Codigo));
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Elimino la Reserva Correctamente");
                            }
                            else
                            {
                                this.MensajeError("No se Elimino ninguna Reserva");
                            }
                        }
                    }
                    this.MostrarReservas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataListado.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    FormEditarReservacion form = FormEditarReservacion.GetInstancia();
                    string par1, par2, par3, par4, par5, par6, par7, par8, par9, par10;
                    string par12, par13, par14, par15, par16, par17, par18, par19, par20, par21;
                    string par22, par23, par24, par25;
                    string par26, par27;

                    par1 = Convert.ToString(row.Cells[1].Value);
                    form.resid = par1;
                    par2 = Convert.ToString(row.Cells[2].Value);
                    par3 = Convert.ToString(row.Cells[3].Value);
                    par4 = Convert.ToString(row.Cells[4].Value);
                    par5 = Convert.ToString(row.Cells[5].Value);
                    par6 = Convert.ToString(row.Cells[6].Value);
                    par7 = Convert.ToString(row.Cells[7].Value);
                    par8 = Convert.ToString(row.Cells[8].Value);
                    par9 = Convert.ToString(row.Cells[9].Value);
                    par10 = Convert.ToString(row.Cells[10].Value);
                    form.SetHabitacion(par2, par3, par4, par5, par6, par7, par8, par9, par10);
                    form.SetCalculateDays(Convert.ToDateTime(par8).Date, Convert.ToDateTime(par9).Date);                    
                    form.newDate = Convert.ToDateTime(par9).Date;
                    form.oldDate = Convert.ToDateTime(par8).Date;

                    par12 = Convert.ToString(row.Cells[12].Value);
                    par13 = Convert.ToString(row.Cells[13].Value);
                    par14 = Convert.ToString(row.Cells[14].Value);
                    par15 = Convert.ToString(row.Cells[15].Value);
                    par16 = Convert.ToString(row.Cells[16].Value);
                    par17 = Convert.ToString(row.Cells[17].Value);
                    par18 = Convert.ToString(row.Cells[18].Value);
                    par19 = Convert.ToString(row.Cells[19].Value);
                    par20 = Convert.ToString(row.Cells[20].Value);
                    par21 = Convert.ToString(row.Cells[21].Value);
                    form.SetCliente(par12, par13, par14, par15, par16, par17, par18, par19, par20, par21);

                    par22 = Convert.ToString(row.Cells[22].Value);
                    par23 = Convert.ToString(row.Cells[23].Value);
                    par24 = Convert.ToString(row.Cells[24].Value);
                    par25 = Convert.ToString(row.Cells[25].Value);
                    form.SetEmpleado(par22, par23, par24, par25);

                    par26 = Convert.ToString(row.Cells[26].Value);
                    par27 = Convert.ToString(row.Cells[29].Value);
                    form.SetCombox(par26, par27);

                    form.ShowDialog();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BuscarresPorPaisCli();
            textBox1.Text = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarresPorPaisCli();
        }
    }
}
