using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Falcom_Bodega
{
    class Solicitudes
    {

        public int globalSolicitud;

        public void RecibirCodigoSolicitud(int tipoIngreso, int idSolicitud)
        {
            Solicitudes conexion = new Solicitudes();
            try
            {
                SqlCommand crearSolicitud = new SqlCommand("IngresarDetalleSolicitud", conexion.Conectarbd);
                crearSolicitud.CommandType = CommandType.StoredProcedure;

                crearSolicitud.Parameters.AddWithValue("@TipoIngreso", tipoIngreso);
                crearSolicitud.Parameters.AddWithValue("@idSolicitud", idSolicitud);

                conexion.abrir();

                crearSolicitud.ExecuteNonQuery();
                globalSolicitud = Convert.ToInt32(crearSolicitud.ExecuteScalar());
            }
            catch (Exception)
            {
            }
            finally
            {
                conexion.cerrar();
            }

        }


        //----------------------------- ↓↓↓ Apartado para conexion ↓↓↓ -----------------------------

        String Cadena = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=BodegaFalcom;Integrated Security=True";
        public SqlConnection Conectarbd = new SqlConnection();

        public Solicitudes()
        {
            Conectarbd.ConnectionString = Cadena;
        }
        public void abrir()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BD " + ex.Message);
            }
        }

        public void cerrar()
        {
            Conectarbd.Close();
        }

        //----------------------------- ↑↑↑ Apartado para conexion ↑↑↑ -----------------------------

    }
}
