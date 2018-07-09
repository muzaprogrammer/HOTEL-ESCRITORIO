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
    public partial class FormClientes : Form
    {
        public FormClientes()
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
        private void Limpiar()
        {
            this.txtNCliente.Text = string.Empty;
            this.txtNombres.Text = string.Empty;
            this.txtApellidos.Text = string.Empty;
            this.txtNDocumento.Text = string.Empty;
            this.comboxGenero.SelectedIndex = 0;           
            this.txtTelefono.Text = string.Empty;
            this.txtPais1.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            //this.dataListado.Columns[1].Visible = false;
            //this.dataListado.Columns[2].Visible = false;
            //this.dataListado.Columns[3].Visible = false;
            //this.dataListado.Columns[4].Visible = false;
            //this.dataListado.Columns[5].Visible = false;
            //this.dataListado.Columns[6].Visible = false;
            //this.dataListado.Columns[7].Visible = false;
            //this.dataListado.Columns[8].Visible = false;
            //this.dataListado.Columns[9].Visible = false;
            //this.dataListado.Columns[10].Visible = false;
        }
        private void Mostrar()
        {
            this.dataListado.DataSource = NCliente.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text="Total de Clientes: "+ Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarNombre()
        {
            dataListado.DataSource = NCliente.BuscarNombre(this.txtNombres.Text);
            //this.OcultarColumnas();
            lblTotal.Text = "Total de Clientes: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarNombreApellido()
        {
            dataListado.DataSource = NCliente.BuscarNombreApellido(this.txtNombres.Text, this.txtApellidos.Text);
            //this.OcultarColumnas();
            lblTotal.Text = "Total de Clientes: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarApellido()
        {
            dataListado.DataSource = NCliente.BuscarApellido(this.txtApellidos.Text);
            //this.OcultarColumnas();
            lblTotal.Text = "Total de Clientes: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarDocumento()
        {
            dataListado.DataSource = NCliente.BuscarNumDocumento(this.txtNDocumento.Text);            
            lblTotal.Text = "Total de Clientes: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarIdCliente()
        {
            dataListado.DataSource = NCliente.BuscarId(this.txtNCliente.Text);            
            lblTotal.Text = "Total de Clientes: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarTelefono()
        {
            dataListado.DataSource = NCliente.BuscarTelefono(this.txtTelefono.Text);            
            lblTotal.Text = "Total de Clientes: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarGenero()
        {
            dataListado.DataSource = NCliente.BuscarGenero(this.comboxGenero.Text);
            lblTotal.Text = "Total de Clientes: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarPais()
        {
            dataListado.DataSource = NCliente.BuscarPais(this.txtPais1.Text, this.txtPais2.Text);
            lblTotal.Text = "Total de Clientes: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarEmail()
        {
            dataListado.DataSource = NCliente.BuscarEmail(this.txtEmail.Text);
            lblTotal.Text = "Total de Clientes: " + Convert.ToString(dataListado.Rows.Count);
        }
            
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                this.dataListado.Columns[5].Visible = true;
            }
            else
            {
                this.dataListado.Columns[5].Visible = false;
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            checkBox11.Checked = true;            
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                this.dataListado.Columns[10].Visible = true;
            }
            else
            {
                this.dataListado.Columns[10].Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.dataListado.Columns[2].Visible = true;
            }
            else
            {
                this.dataListado.Columns[2].Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                this.dataListado.Columns[3].Visible = true;
            }
            else
            {
                this.dataListado.Columns[3].Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                this.dataListado.Columns[4].Visible = true;
            }
            else
            {
                this.dataListado.Columns[4].Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.dataListado.Columns[1].Visible = true;
            }
            else
            {
                this.dataListado.Columns[1].Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarIdCliente();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            BuscarEmail();
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mostrar();
            checkBox11.Checked = false;
            checkBox11.Checked = true;
            checkBox12.Checked = false;
            Limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar();
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged_1(object sender, EventArgs e)
        {
            this.BuscarNombreApellido();
            //this.BuscarNombre();
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==dataListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell checkBox12 = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Seleccionar"];
                checkBox12.Value = !Convert.ToBoolean(checkBox12.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataListado.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    FormEditarCliente form = FormEditarCliente.GetInstancia();                                                           
                    string par1, par2, par3, par4, par5, par6, par8, par9, par10;
                    string par7;
                    par1 = Convert.ToString(row.Cells[1].Value);
                    par2 = Convert.ToString(row.Cells[2].Value);
                    par3 = Convert.ToString(row.Cells[3].Value);
                    par4 = Convert.ToString(row.Cells[4].Value);
                    par5 = Convert.ToString(row.Cells[5].Value);
                    par6 = Convert.ToString(row.Cells[6].Value);
                    par7 = Convert.ToString(row.Cells[7].Value);
                    par8 = Convert.ToString(row.Cells[8].Value);
                    par9 = Convert.ToString(row.Cells[9].Value);
                    par10 = Convert.ToString(row.Cells[10].Value);
                    form.SetCliente(par1, par2, par3, par4, par5, par6, par7, par8, par9, par10);
                    form.ShowDialog();
                }
            }                    
                
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta seguro de eliminar al Cliente", "Sistema de reservaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(Opcion==DialogResult.OK)
                {
                    string Codigo;
                    String Rpta = "";

                    foreach(DataGridViewRow row in dataListado.Rows)
                    {
                        if(Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NCliente.Eliminar(Convert.ToInt32(Codigo));
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Elimino el Cliente Correctamente");
                            }
                            else
                            {
                                this.MensajeError("No se Elimino ningun Cliente");
                            }

                        }
                    }
                    this.Mostrar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormNuevoCliente form = new FormNuevoCliente();
            form.ShowDialog();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombreApellido();
            //BuscarApellido();
        }

        private void txtNDocumento_TextChanged(object sender, EventArgs e)
        {
            BuscarDocumento();
        }

        private void comboxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarGenero();
        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {
            BuscarPais();
            txtPais2.Text = txtPais1.Text;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            BuscarTelefono();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox12.Checked)
            {
                this.dataListado.Columns[0].Visible = true;
            }
            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                this.dataListado.Columns[6].Visible = true;
            }
            else
            {
                this.dataListado.Columns[6].Visible = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                this.dataListado.Columns[7].Visible = true;
            }
            else
            {
                this.dataListado.Columns[7].Visible = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                this.dataListado.Columns[8].Visible = true;
            }
            else
            {
                this.dataListado.Columns[8].Visible = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                this.dataListado.Columns[9].Visible = true;
            }
            else
            {
                this.dataListado.Columns[9].Visible = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                checkBox5.Checked = true;
                checkBox6.Checked = true;
                checkBox7.Checked = true;
                checkBox8.Checked = true;                
                checkBox9.Checked = true;
                checkBox10.Checked = true;                
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            FormNuevaReservacion form = FormNuevaReservacion.GetInstancia();

            string par1, par2, par3, par4, par5, par6, par7, par8, par9, par10;
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["CLI_ID"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["CLI_NOMBRES"].Value);
            par3 = Convert.ToString(this.dataListado.CurrentRow.Cells["CLI_APELLIDOS"].Value);
            par4 = Convert.ToString(this.dataListado.CurrentRow.Cells["CLI_TIPO_DOCUMENTO"].Value);
            par5 = Convert.ToString(this.dataListado.CurrentRow.Cells["CLI_N_DOCUMENTO"].Value);
            par6 = Convert.ToString(this.dataListado.CurrentRow.Cells["CLI_FECHA_NAC"].Value);
            par7 = Convert.ToString(this.dataListado.CurrentRow.Cells["CLI_GENERO"].Value);
            par8 = Convert.ToString(this.dataListado.CurrentRow.Cells["CLI_TELEFONO"].Value);
            par9 = Convert.ToString(this.dataListado.CurrentRow.Cells["CLI_PAIS"].Value);
            par10 = Convert.ToString(this.dataListado.CurrentRow.Cells["CLI_EMAIL"].Value);

            form.SetCliente(par1, par2, par3, par4, par5, par6, par7, par8, par9, par10);
            
            this.Hide();
        }

        private void txtPais2_TextChanged(object sender, EventArgs e)
        {
            BuscarPais();
        }
    }
}
