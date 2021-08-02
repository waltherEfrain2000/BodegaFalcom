using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Proyecto_Falcom_Bodega
{
    public partial class Colaboradores : Form
    {
        Conexion conexion = new Conexion();
        public Colaboradores()
        {
            InitializeComponent();
            conexion.Busquedas1("exec mostrarColaboradores", dataGridView1);
        }

        private void Colaboradores_Load(object sender, EventArgs e)
        {
            cmbDepartamento.DataSource = Conexion.CargarDatos();
            cmbDepartamento.DisplayMember = "nombreDepartamento";
            cmbDepartamento.ValueMember = "codigoDepartamento";
            //cmbDepartamento.SelectedIndex = "codigoDepartamento";

            limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validaciones() == true)
                {
                    int departamento = Convert.ToInt32(cmbDepartamento.SelectedIndex) + 1;
                    string nombre = txtNombre.Text;
                    string identidad = txtIdentidad.Text;
                    string fechaNacimiento = txtfechaNacimiento.Text;
                    string correo = txtCorreo.Text;
                    decimal salario = Convert.ToDecimal(txtSalario.Text);
                    string telefono = txtTelefono.Text;
                    string civil = txtEstadoCivil.Text;


                    conexion.Modificaciones("exec ingresarColaborador '" + departamento + "', '" + nombre + "', '" + identidad + "', '" + fechaNacimiento + "', '" + correo + "', '" + salario + "', '" + telefono + "', '" + civil + "' ");
                    MessageBox.Show("¡la información del colaborador a sido ingresada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexion.Busquedas1("exec mostrarColaboradores", dataGridView1);
                    limpiar();
                }
            }
            catch (Exception)
            {

            }           
        }
        private void limpiar ()
        {
            txtNombre.Clear();
            txtIdentidad.Clear();
            txtfechaNacimiento.Clear();
            txtCorreo.Clear();
            txtSalario.Clear();
            txtTelefono.Clear();
            cmbDepartamento.Text = null;
            txtEstadoCivil.Clear();
        }

        private bool validaciones ()
        {
            if (txtNombre.Text == "" || txtIdentidad.Text == "" || txtfechaNacimiento.Text == "" || txtCorreo.Text == "" || txtSalario.Text == "" || txtTelefono.Text == "" || txtEstadoCivil.Text == "")
            {
                MessageBox.Show("favor, llenar todas las cajas de texto", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (cmbDepartamento.DisplayMember == "")
            {
                MessageBox.Show("favor, llenar departamento", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validacionEliminar ()
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("favor, seleccione un colaborador antes de continuar", "Precaución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            conexion.Busquedas("exec busquedaColab  ", dataGridView1, "nombreColaborador LIKE '%" + txtBuscar.Text + "%' ");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtIdentidad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                //cmbDepartamento.DisplayMember = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtfechaNacimiento.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtCorreo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtSalario.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                txtEstadoCivil.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validaciones() == true)
                {
                    int id = Convert.ToInt32(txtCodigo.Text);
                    int departamento = Convert.ToInt32(cmbDepartamento.SelectedIndex) + 1;
                    string nombre = txtNombre.Text;
                    string identidad = txtIdentidad.Text;
                    string fechaNacimiento = txtfechaNacimiento.Text;
                    string correo = txtCorreo.Text;
                    decimal salario = Convert.ToDecimal(txtSalario.Text);
                    string telefono = txtTelefono.Text;
                    string civil = txtEstadoCivil.Text;


                    conexion.Modificaciones("exec modificarColab '" + id +"' ,'" + departamento + "', '" + nombre + "', '" + identidad + "', '" + fechaNacimiento + "', '" + correo + "', '" + salario + "', '" + telefono + "', '" + civil + "' ");
                    MessageBox.Show("¡la información del colaborador a sido modificada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexion.Busquedas1("exec mostrarColaboradores", dataGridView1);
                    limpiar();
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validacionEliminar() == true)
                {
                    if (MessageBox.Show("¿Seguro Desea eliminar este colaborador?", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(txtCodigo.Text);

                        conexion.Modificaciones("exec EliminarColab '" + id + "' ");
                        MessageBox.Show("El colaborador a sido eliminado...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        conexion.Busquedas1("exec mostrarColaboradores", dataGridView1);
                        limpiar();
                    }
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ReporteColaborador reporteColaborador = new ReporteColaborador();
            reporteColaborador.Show();
        }
    }
}
