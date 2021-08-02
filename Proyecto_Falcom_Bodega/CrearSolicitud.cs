using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar los namespaces requeridos
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Proyecto_Falcom_Bodega
{
    public partial class CrearSolicitud : Form
    {

        Solicitudes conexion = new Solicitudes();
        public CrearSolicitud()
        {
            InitializeComponent();
            lblfecha.Text = string.Format("{0}", DateTime.Now.ToString());
            MostrarSolicitudes();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int verificacionCampos = VerificarCampos();
            conexion.abrir();
            if (verificacionCampos == 1)
            {
                MessageBox.Show("Debe un cliente y un empleado.");
            }
            else if (verificacionCampos == 0)
            {
                int idCliente = Convert.ToInt32(listCliente.SelectedValue);
                int idEmpleado = Convert.ToInt32(listEmpleado.SelectedValue);
                try
                {
                    SqlCommand crearSolicitud = new SqlCommand("AgregarSolicitud", conexion.Conectarbd);
                    crearSolicitud.CommandType = CommandType.StoredProcedure;

                    crearSolicitud.Parameters.AddWithValue("@codigoCliente", idCliente);
                    crearSolicitud.Parameters.AddWithValue("@codigoColaborador", idEmpleado);
                    crearSolicitud.Parameters.AddWithValue("@fechaSolicitud", lblfecha.Text);

                    conexion.abrir();

                    crearSolicitud.ExecuteNonQuery();
                    MessageBox.Show("Solicitud creada correctamente.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error.");
                }
                finally
                {
                    conexion.cerrar();
                    MostrarSolicitudes();
                    conexion.RecibirCodigoSolicitud(1, 1);
                    DetalleSolicitudes ventana = new DetalleSolicitudes();
                    ventana.Show();
                    this.Hide();
                }
            }

        }

        private int VerificarCampos()
        {
            int verificacion;
            if (listCliente.SelectedItem == null || listEmpleado.SelectedItem == null)
            {
                verificacion = 1;
            }
            else
            {
                verificacion = 0;
            }
            return verificacion;
        }

        private void CrearSolicitud_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'bodegaFalcomDataSet.colaboradores' Puede moverla o quitarla según sea necesario.
            //this.colaboradoresTableAdapter.Fill(this.bodegaFalcomDataSet.colaboradores);
            //// TODO: esta línea de código carga datos en la tabla 'bodegaFalcomDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.bodegaFalcomDataSet.Clientes);
        }


        private void MostrarSolicitudes()
        {
            try
            {
                string query = @"EXEC VerSolicitudes";

                conexion.abrir();
                SqlCommand sqlCommand = new SqlCommand(query, conexion.Conectarbd);

                sqlCommand.ExecuteNonQuery();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable("Solicitudes");
                sqlDataAdapter.Fill(dataTable);
                dgvSolicitudes.DataSource = dataTable.DefaultView;
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


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSolicitudes.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar una solicitud de la lista.");
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar esta solicitud?", "Advertencia", botones);

                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        conexion.globalSolicitud = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells["Solicitud"].Value.ToString());
                        SqlCommand crearMarca = new SqlCommand("EliminarSolicitud", conexion.Conectarbd);
                        crearMarca.CommandType = CommandType.StoredProcedure;
                        crearMarca.Parameters.AddWithValue("@codigoSolicitud", conexion.globalSolicitud);
                        conexion.abrir();
                        crearMarca.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
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

        private void listCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CrearSolicitud_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bodegaFalcomDataSet.colaboradores' Puede moverla o quitarla según sea necesario.
            this.colaboradoresTableAdapter.Fill(this.bodegaFalcomDataSet.colaboradores);
            // TODO: esta línea de código carga datos en la tabla 'bodegaFalcomDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.bodegaFalcomDataSet.Clientes);

        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            int verificacionCampos = VerificarCampos();
            conexion.abrir();
            if (verificacionCampos == 1)
            {
                MessageBox.Show("Debe un cliente y un empleado.");
            }
            else if (verificacionCampos == 0)
            {
                int idCliente = Convert.ToInt32(listCliente.SelectedValue);
                int idEmpleado = Convert.ToInt32(listEmpleado.SelectedValue);
                try
                {
                    SqlCommand crearSolicitud = new SqlCommand("AgregarSolicitud", conexion.Conectarbd);
                    crearSolicitud.CommandType = CommandType.StoredProcedure;

                    crearSolicitud.Parameters.AddWithValue("@codigoCliente", idCliente);
                    crearSolicitud.Parameters.AddWithValue("@codigoColaborador", idEmpleado);
                    crearSolicitud.Parameters.AddWithValue("@fechaSolicitud", lblfecha.Text);

                    conexion.abrir();

                    crearSolicitud.ExecuteNonQuery();
                    MessageBox.Show("Solicitud creada correctamente.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error.");
                }
                finally
                {
                    conexion.cerrar();
                    MostrarSolicitudes();
                    conexion.RecibirCodigoSolicitud(1, 1);
                    DetalleSolicitudes ventana = new DetalleSolicitudes();
                    ventana.Show();
                    this.Hide();
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvSolicitudes.SelectedRows == null)
            {
                MessageBox.Show("Debe seleccionar una solicitud de la lista.");
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar esta solicitud?", "Advertencia", botones);

                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        conexion.globalSolicitud = Convert.ToInt32(dgvSolicitudes.CurrentRow.Cells["Solicitud"].Value.ToString());
                        SqlCommand crearMarca = new SqlCommand("EliminarSolicitud", conexion.Conectarbd);
                        crearMarca.CommandType = CommandType.StoredProcedure;
                        crearMarca.Parameters.AddWithValue("@codigoSolicitud", conexion.globalSolicitud);
                        conexion.abrir();
                        crearMarca.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
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

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
