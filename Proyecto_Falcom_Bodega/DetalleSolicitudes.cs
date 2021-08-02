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
    public partial class DetalleSolicitudes : Form
    {
        Solicitudes conexion = new Solicitudes();
        public DetalleSolicitudes()
        {
            InitializeComponent();
            MostrarSolicitudes();
            conexion.RecibirCodigoSolicitud(1, 1);
            lblSolicitud.Text = Convert.ToString(conexion.globalSolicitud);
        }

        private void DetalleSolicitudes_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'bodegaFalcomDataSet1.MostrarProductosInventarioSolicitud' Puede moverla o quitarla según sea necesario.
            //this.mostrarProductosInventarioSolicitudTableAdapter.Fill(this.bodegaFalcomDataSet1.MostrarProductosInventarioSolicitud);
            //// TODO: esta línea de código carga datos en la tabla 'bodegaFalcomDataSet.Producto' Puede moverla o quitarla según sea necesario.
            //this.productoTableAdapter.Fill(this.bodegaFalcomDataSet.Producto);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar una solicitud de la lista.");
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este producto?", "Advertencia", botones);

                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        int codigoDetalle = Convert.ToInt32(dgvCarrito.CurrentRow.Cells["Codigo"].Value.ToString());
                        SqlCommand crearMarca = new SqlCommand("EliminarProductoSolicitud", conexion.Conectarbd);
                        crearMarca.CommandType = CommandType.StoredProcedure;
                        crearMarca.Parameters.AddWithValue("@codigoDetalle", codigoDetalle);
                        crearMarca.Parameters.AddWithValue("@codigoSolicitud", conexion.globalSolicitud);
                        conexion.abrir();
                        crearMarca.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error" + ex);
                    }
                    finally
                    {
                        conexion.cerrar();
                        MostrarSolicitudes();
                        MessageBox.Show("Solicitud eliminada correctamente.");
                    }
                }
                else { }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (txtCantidad.Text == null || cmbProducto.SelectedItem == null)
            { MessageBox.Show("Debe llenar todos los campos solicitados."); }
            else
            {

                try
                {
                    SqlCommand crearSolicitud = new SqlCommand("AgregarDetalleSolicitud", conexion.Conectarbd);
                    crearSolicitud.CommandType = CommandType.StoredProcedure;

                    crearSolicitud.Parameters.AddWithValue("@codigoSolicitud", Convert.ToInt32(conexion.globalSolicitud));
                    crearSolicitud.Parameters.AddWithValue("@codigoProducto", Convert.ToInt32(cmbProducto.SelectedValue));
                    crearSolicitud.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txtCantidad.Text));

                    conexion.abrir();

                    crearSolicitud.ExecuteNonQuery();
                    MessageBox.Show("Producto agregado correctamente.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error.");
                }
                finally
                {
                    conexion.cerrar();
                    MostrarSolicitudes();
                }
            }
        }

        private void MostrarSolicitudes()
        {
            try
            {
                string query = @"EXEC MostrarProductosSolicitud @codigoSolicitud";

                conexion.abrir();
                SqlCommand sqlCommand = new SqlCommand(query, conexion.Conectarbd);
                sqlCommand.Parameters.AddWithValue("@codigoSolicitud", conexion.globalSolicitud);

                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable("DetalleSolicitud");
                sqlDataAdapter.Fill(dataTable);
                dgvCarrito.DataSource = dataTable.DefaultView;
                sqlDataAdapter.Update(dataTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrearSolicitud ventana = new CrearSolicitud();
            ventana.Show();
            this.Hide();
        }

        private void DetalleSolicitudes_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bodegaFalcomDataSet.MostrarProductosInventarioSolicitud' Puede moverla o quitarla según sea necesario.
            this.mostrarProductosInventarioSolicitudTableAdapter.Fill(this.bodegaFalcomDataSet.MostrarProductosInventarioSolicitud);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Hide();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtCantidad.Text == null || cmbProducto.SelectedItem == null)
            { MessageBox.Show("Debe llenar todos los campos solicitados."); }
            else
            {

                try
                {
                    SqlCommand crearSolicitud = new SqlCommand("AgregarDetalleSolicitud", conexion.Conectarbd);
                    crearSolicitud.CommandType = CommandType.StoredProcedure;

                    crearSolicitud.Parameters.AddWithValue("@codigoSolicitud", Convert.ToInt32(conexion.globalSolicitud));
                    crearSolicitud.Parameters.AddWithValue("@codigoProducto", Convert.ToInt32(cmbProducto.SelectedValue));
                    crearSolicitud.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txtCantidad.Text));

                    conexion.abrir();

                    crearSolicitud.ExecuteNonQuery();
                    MessageBox.Show("Producto agregado correctamente.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error.");
                }
                finally
                {
                    conexion.cerrar();
                    MostrarSolicitudes();
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar una solicitud de la lista.");
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar este producto?", "Advertencia", botones);

                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        int codigoDetalle = Convert.ToInt32(dgvCarrito.CurrentRow.Cells["Codigo"].Value.ToString());
                        SqlCommand crearMarca = new SqlCommand("EliminarProductoSolicitud", conexion.Conectarbd);
                        crearMarca.CommandType = CommandType.StoredProcedure;
                        crearMarca.Parameters.AddWithValue("@codigoDetalle", codigoDetalle);
                        crearMarca.Parameters.AddWithValue("@codigoSolicitud", conexion.globalSolicitud);
                        conexion.abrir();
                        crearMarca.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error" + ex);
                    }
                    finally
                    {
                        conexion.cerrar();
                        MostrarSolicitudes();
                        MessageBox.Show("Solicitud eliminada correctamente.");
                    }
                }
                else { }
            }
        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
