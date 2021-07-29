using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Falcom_Bodega
{
    class Conexion
    {
        String connection = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=BodegaFalcom;Integrated Security=True";
        public SqlConnection Conectar = new SqlConnection();

        public Conexion() {
            Conectar.ConnectionString = connection;
        }

        public void AbrirConexion()
        {
            try
            {
                Conectar.Open();
                Console.WriteLine("Conexion exitosa");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                Conectar.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
