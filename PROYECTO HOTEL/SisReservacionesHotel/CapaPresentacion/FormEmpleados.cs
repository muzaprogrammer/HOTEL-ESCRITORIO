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
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
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
            this.txtNEmpleado.Text = string.Empty;
            this.txtNombres.Text = string.Empty;
            this.txtApellidos.Text = string.Empty;
            this.txtNDocumento.Text = string.Empty;
            this.comboxGenero.SelectedIndex = 0;
            this.txtTelefono.Text = string.Empty;
            this.txtUser.Text = string.Empty;
            this.comboBoxTurno.SelectedIndex = 0;
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[14].Visible = false;
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
            this.dataListado.DataSource = NEmpleado.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Empleados: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarId()
        {
            dataListado.DataSource = NEmpleado.BuscarId(this.txtNEmpleado.Text);
            lblTotal.Text = "Total de Empleados: " + Convert.ToString(dataListado.Rows.Count);            
        }
        private void BuscarNombresApellidos()
        {
            dataListado.DataSource = NEmpleado.BuscarNombresApellidos(this.txtNombres.Text, this.txtApellidos.Text);            
            lblTotal.Text = "Total de Empleados: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarNDocumento()
        {
            dataListado.DataSource = NEmpleado.BuscarNumeroDocumento(this.txtNDocumento.Text);            
            lblTotal.Text = "Total de Empleados: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarGenero()
        {
            dataListado.DataSource = NEmpleado.BuscarGenero(this.comboxGenero.Text);
            lblTotal.Text = "Total de Empleados: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarTelefono()
        {
            dataListado.DataSource = NEmpleado.BuscarTelefono(this.txtTelefono.Text);
            lblTotal.Text = "Total de Empleados: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarTurno()
        {
            dataListado.DataSource = NEmpleado.BuscarTurno(this.comboBoxTurno.Text);
            lblTotal.Text = "Total de Empleados: " + Convert.ToString(dataListado.Rows.Count);
        }
        private void BuscarUser()
        {
            dataListado.DataSource = NEmpleado.BuscarUser(this.txtUser.Text);
            lblTotal.Text = "Total de Empleados: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {                       
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            checkBox14.Checked = true;            
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

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                this.dataListado.Columns[11].Visible = true;
            }
            else
            {
                this.dataListado.Columns[11].Visible = false;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                this.dataListado.Columns[12].Visible = true;
            }
            else
            {
                this.dataListado.Columns[12].Visible = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                this.dataListado.Columns[13].Visible = true;
                this.dataListado.Columns[15].Visible = true;
            }
            else
            {
                this.dataListado.Columns[13].Visible = false;
                this.dataListado.Columns[15].Visible = false;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
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
                checkBox11.Checked = true;
                checkBox12.Checked = true;
                checkBox13.Checked = true;
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
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
            }
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataListado.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    FormEditarEmpleado form = FormEditarEmpleado.GetInstancia();
                    string par1, par2, par3, par4, par5, par6, par7,par8, par9, par10, par11, par12, par13, par14, par15;
                    
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
                    par11 = Convert.ToString(row.Cells[11].Value);
                    par12 = Convert.ToString(row.Cells[12].Value);
                    par13 = Convert.ToString(row.Cells[13].Value);
                    par14 = Convert.ToString(row.Cells[14].Value);
                    par15 = Convert.ToString(row.Cells[15].Value);
                    form.SetEmpleado(par1, par2, par3, par4, par5, par6, par7, par8, par9, par10, par11, par12, par13, par14, par15);
                    form.ShowDialog();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta seguro de eliminar al Empleado", "Sistema de reservaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    String Rpta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NEmpleado.Eliminar(Convert.ToInt32(Codigo));
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Elimino el Empleado Correctamente");
                            }
                            else
                            {
                                this.MensajeError("No se Elimino ningun Empleado");
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

        private void btnRefrescarList_Click(object sender, EventArgs e)
        {
            Mostrar();
            checkBox14.Checked = false;
            checkBox14.Checked = true;
            checkBox15.Checked = false;
            Limpiar();
        }

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            FormNuevoEmpleado form = new FormNuevoEmpleado();
            form.ShowDialog();
        }

        private void txtNEmpleado_TextChanged(object sender, EventArgs e)
        {
            this.BuscarId();
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombresApellidos();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombresApellidos();
        }

        private void txtNDocumento_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNDocumento();
        }

        private void comboxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuscarGenero();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            this.BuscarTelefono();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            this.BuscarUser();
        }

        private void comboBoxTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BuscarTurno();
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell checkBox15 = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Seleccionar"];
                checkBox15.Value = !Convert.ToBoolean(checkBox15.Value);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
