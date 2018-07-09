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
    public partial class FormEditarEliminarHabitaciones : Form
    {
        public FormEditarEliminarHabitaciones()
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
            checkBox15.Checked = true;
            checkBox15.Checked = false;
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[7].Visible = false;
            this.dataListado.Columns[8].Visible = false;
        }
        private void llenarComboxHabitaciones()
        {
            comboxHabitaciones.DataSource = NHabitaciones.MostrarTodas();
            comboxHabitaciones.ValueMember = "HAB_ID";
            comboxHabitaciones.DisplayMember = "HAB_NUM";
        }
        private void llenarComboxHabitacionesTipo()
        {
            comboxTipo.DataSource = NHabitaciones.MostrarTodas();
            comboxTipo.ValueMember = "HAB_ID";
            comboxTipo.DisplayMember = "HAB_TIPO";
        }
        private void mostrar()
        {
            dataListado.DataSource = NHabitaciones.MostrarTodas();
            lblTotal.Text = "Total de habitaciones: " + Convert.ToString(dataListado.Rows.Count);
            this.OcultarColumnas();
        }
        private void FormEditarEliminarHabitaciones_Load(object sender, EventArgs e)
        {
            this.mostrar();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        private void btnRefrescarList_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.mostrar();
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell checkBox15 = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Seleccionar"];
                checkBox15.Value = !Convert.ToBoolean(checkBox15.Value);
            }
        }
        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            FormAgregarHabitacion form = new FormAgregarHabitacion();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboxHabitaciones_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dataListado.DataSource = NHabitaciones.BuscarNum(this.comboxHabitaciones.Text);
            lblTotal.Text = "Habitaciones " + Convert.ToString(dataListado.Rows.Count);
        }

        private void comboxPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {           
            switch (comboxPrecio.SelectedIndex)
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

        private void comboxTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboxTipo.SelectedIndex)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta seguro de eliminar la Habitacion", "Sistema de reservaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    String Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NHabitaciones.Eliminar(Convert.ToInt32(Codigo));
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Elimino la Habitacion Correctamente");
                            }
                            else
                            {
                                this.MensajeError("No se Elimino ninguna Habitacion");
                            }

                        }
                    }
                    this.mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataListado.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    FormEditarHabitacion form = FormEditarHabitacion.GetInstancia();
                    string par1, par2, par3, par4, par5, par6;

                    par1 = Convert.ToString(row.Cells[1].Value);
                    par2 = Convert.ToString(row.Cells[2].Value);
                    par3 = Convert.ToString(row.Cells[3].Value);
                    par4 = Convert.ToString(row.Cells[4].Value);
                    par5 = Convert.ToString(row.Cells[5].Value);
                    par6 = Convert.ToString(row.Cells[6].Value);
                    
                    form.SetHabitacion(par1, par2, par3, par4, par5, par6);
                    form.ShowDialog();
                }
            }
        }
    }
}
