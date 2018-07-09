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
    public partial class FormHoteles : Form
    {
        public FormHoteles()
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
        private void Mostrar()
        {
            dataListado.DataSource = NHoteles.Mostrar();
        }
        private void BuscarNombre()
        {
            dataListado.DataSource = NHoteles.Buscar(txtNombre.Text, txtPais.Text);
        }
        private void FormHoteles_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            BuscarNombre();
        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {
            BuscarNombre();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta seguro de eliminar el Hotel", "Sistema de reservaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    String Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NHoteles.Eliminar(Convert.ToInt32(Codigo));
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Elimino el Hotel Correctamente");
                            }
                            else
                            {
                                this.MensajeError("No se Elimino el registro");
                            }

                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAgregarHotel form = new FormAgregarHotel();
            form.Show();
        }
    }
}

