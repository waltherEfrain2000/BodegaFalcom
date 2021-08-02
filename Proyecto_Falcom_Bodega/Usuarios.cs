
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Proyecto_Falcom_Bodega
{
    public partial class Usuarios : Form
    {
        Conexion conexion = new Conexion();
        public Usuarios()
        {
            InitializeComponent();
            conexion.Busquedas1("Exec MostrarUsuario", dataGridView1);
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            txtrol.Items.Add("Administrador");
            txtrol.Items.Add("Empleado de Turno");
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {

            int Estado;
            string rol;

            if (cmbEstado.SelectedIndex == 0)
            {

                Estado = 1;
            }
            else
            {
                Estado = 0;
            }

            if (txtrol.SelectedIndex == 0)
            {
                rol = "Administrador";
            }
            else
            {
                rol = "Empleado de turno";
            }


            conexion.Modificaciones("exec CrearUsuario'" + txtnombre.Text + "', '" + txtcontraseña.Text + "' ,'" + rol + "', " + Estado + " ");

            MessageBox.Show("Datos guardados correctamente", "Sistemas Inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtnombre.Clear();
            txtcontraseña.Clear();
            cmbEstado.Text = "";
            conexion.Busquedas1("Exec MostrarUsuario", dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Estado;
            string rol;
            if (cmbEstado.SelectedIndex == 0)
            {

                Estado = 1;
            }
            else
            {
                Estado = 0;
            }
            if (txtrol.SelectedIndex == 0)
            {
                rol = "Administrador";
            }
            else
            {
                rol = "Empleado de turno";
            }
            conexion.Modificaciones("exec ModificarUsuario'" + txtnombre.Text + "', '" + txtcontraseña.Text + "' ,'" + rol + "', " + Estado + " ");

            MessageBox.Show("Datos modificados correctamente", "Bodega Falcom", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtnombre.Clear();
            txtcontraseña.Clear();
            cmbEstado.Text = "";
            conexion.Busquedas1("Exec MostrarUsuario", dataGridView1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Modificaciones("exec EliminarUsuario'" + txtnombre.Text + "' ");

            MessageBox.Show("Datos eliminados correctamente", "Bodega Falcom", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtnombre.Clear();
            txtcontraseña.Clear();
            cmbEstado.Text = "";
            conexion.Busquedas1("Exec MostrarUsuario", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Estado;
            txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtcontraseña.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtrol.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Estado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);

            if (Estado == 1)
            {
                cmbEstado.SelectedItem = "Activo";
            }
            else
            {
                cmbEstado.SelectedItem = "Inactivo";
            }
        }


        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            conexion.Busquedas1("Exec BuscarUsuario '" + txtBuscar.Text + "'", dataGridView1);

            if (txtBuscar.Text == String.Empty)
            {
                conexion.Busquedas1("Exec MostrarUsuario", dataGridView1);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = String.Empty;
            txtnombre.Text = String.Empty;
            txtcontraseña.Text = String.Empty;
            txtrol.Text = String.Empty;
            cmbEstado.Text = String.Empty;
        }
    }
}

