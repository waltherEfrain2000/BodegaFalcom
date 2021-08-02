using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace Proyecto_Falcom_Bodega
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Conexion.ConectarCliente();
            MessageBox.Show("conexion exitosa");
            dgvClientes.DataSource = llenar_grid();
            txtCodClientes.Enabled = false;
            txtNombreCliente.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodClientes.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                txtNombreCliente.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnGuardarCliente_Click(object sender, EventArgs e)
        {
            Conexion.ConectarCliente();
            string insertar = "INSERT INTO CLIENTES (Nombre_Cliente,Identificador_Cliente,Direccion_Cliente,Telefono)VALUES(@Nombre_Cliente,@Identificador_Cliente,@Direccion_Cliente,@Telefono)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.ConectarCliente());
            cmd1.Parameters.AddWithValue("@Nombre_Cliente", txtNombreCliente.Text);
            cmd1.Parameters.AddWithValue("@Identificador_Cliente", txtIdentificadorCliente.Text);
            cmd1.Parameters.AddWithValue("@Direccion_Cliente", txtDireccionCliente.Text);
            cmd1.Parameters.AddWithValue("@Telefono", txtTelefonoCliente.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("Los datos fueron agregador correctamente");
            dgvClientes.DataSource = llenar_grid();

        }
        public DataTable llenar_grid()
        {
            // para mostrar los datos en el datagridview

            Conexion.ConectarCliente();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM CLIENTES";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.ConectarCliente());
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            Conexion.ConectarCliente();
            string actualizar = "UPDATE CLIENTES SET Nombre=@Nombre_Cliente, Identificador_Cliente=@Identificador_Cliente,Direccion-Cliente=@Direccion_Cliente,Telefono=@Telefono WHERE Nombre_Cliente=@Nombre_Cliente";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.ConectarCliente());

            cmd2.Parameters.AddWithValue("@Nombre_Cliente", txtNombreCliente.Text);
            cmd2.Parameters.AddWithValue("@Identificador_Cliente", txtIdentificadorCliente.Text);
            cmd2.Parameters.AddWithValue("@Direccion_Cliente", txtDireccionCliente.Text);
            cmd2.Parameters.AddWithValue("@Telefono", txtTelefonoCliente.Text);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron actualizados correctamente");
            dgvClientes.DataSource = llenar_grid();
        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            Conexion.ConectarCliente();
            string eliminar = "DELETE FROM CLIENTES WHERE Cod_cliente = @Cod_Cliente";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.ConectarCliente());

            cmd3.Parameters.AddWithValue("@Cod_cliente", txtCodClientes.Text);
            cmd3.ExecuteNonQuery();

            MessageBox.Show("Datos eliminados correctamente");
            dgvClientes.DataSource = llenar_grid();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            txtCodClientes.Clear();
            txtNombreCliente.Clear();
            txtIdentificadorCliente.Clear();
            txtDireccionCliente.Clear();
            txtTelefonoCliente.Clear();
            txtNombreCliente.Focus();

        }
    }
}
