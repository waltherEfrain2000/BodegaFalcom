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
using System.Configuration;


namespace Proyecto_Falcom_Bodega
{
    public partial class FormularioProducto : Form
    {
        Conexion conexion = new Conexion();
        public FormularioProducto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
        }

        public void LlenarDataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SeleccionarProductos", conexion.Conectar);
                conexion.AbrirConexion();

                cmd.ExecuteNonQuery();

                SqlDataAdapter sqladapter = new SqlDataAdapter(cmd);

                DataTable datatable = new DataTable("Producto");

                sqladapter.Fill(datatable);
                dgvProducto.DataSource = datatable.DefaultView;
                sqladapter.Update(datatable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        private void dgvProducto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducto.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();
                txtCosto.Text = row.Cells[2].Value.ToString();
                txtPeso.Text = row.Cells[3].Value.ToString();
                txtDescripcion.Text = row.Cells[4].Value.ToString();
            }
        }
        public bool VerificacionDeDatos()
        {

            if (txtNombre.Text == string.Empty || txtCosto.Text == string.Empty || txtPeso.Text == null || txtDescripcion.Text == null)
            {
                MessageBox.Show("Por favor!, Verifique que las casillas" + " contengan la infromación requerida!", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public void InsertarProducto()
        {
            string Nombre = txtNombre.Text;
            double Precio = Convert.ToDouble(txtCosto.Text);
            double Peso = Convert.ToDouble(txtPeso.Text);
            string descripcion = txtDescripcion.Text;

            try
            {
                SqlCommand cmd = new SqlCommand("InsertarProducto", conexion.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.AbrirConexion();

                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@costo", Precio);
                cmd.Parameters.AddWithValue("@peso", Peso);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
                       
        }
        public void LimpiarCasillas()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCosto.Clear();
            txtPeso.Clear();
            txtDescripcion.Clear();
        }

        private void ModificarProduccion()
        {
            int Codigo = Convert.ToInt32(txtCodigo.Text);
            string Nombre = txtNombre.Text;
            double Precio = Convert.ToDouble(txtCosto.Text);
            double Peso = Convert.ToDouble(txtPeso.Text);
            string descripcion = txtDescripcion.Text;

            try
            {
                SqlCommand cmd = new SqlCommand("ModificarProducto", conexion.Conectar);
                cmd.CommandType = CommandType.StoredProcedure;

                conexion.AbrirConexion();

                cmd.Parameters.AddWithValue("@codigo", Codigo);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@costo", Precio);
                cmd.Parameters.AddWithValue("@peso", Peso);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
        private void BorrarProduccion()
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                try
                {
                    SqlCommand cmd = new SqlCommand("EliminarProducto", conexion.Conectar);
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.AbrirConexion();

                    cmd.Parameters.AddWithValue("@codigo", Codigo);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    conexion.CerrarConexion();
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificacionDeDatos())
            {
                try
                {
                    InsertarProducto();

                    MessageBox.Show("Los datos han sido ingresados de manera exitosa.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Ha habido un error al momento de ingresar los datos.");
                }
                finally
                {
                    LimpiarCasillas();
                    LlenarDataGridView();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (VerificacionDeDatos())
            {
                try
                {
                    ModificarProduccion();

                    MessageBox.Show("Los datos han sido modificados de manera exitosa.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Ha habido un error al momento de modificar los datos.");
                }
                finally
                {
                    LimpiarCasillas();
                    LlenarDataGridView();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                BorrarProduccion();

                MessageBox.Show("Los datos han sido eliminados de manera exitosa.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Ha habido un error al momento de borrar los datos.");
            }
            finally
            {
                LimpiarCasillas();
                LlenarDataGridView();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }
    }
}
