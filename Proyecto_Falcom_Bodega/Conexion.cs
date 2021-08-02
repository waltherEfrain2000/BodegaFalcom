using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Falcom_Bodega
{
    class Conexion
    {
        String connection = "Data Source=(local)\\SQLEXPRESS ;Initial Catalog=BodegaFalcom;Integrated Security=True";
        public SqlConnection Conectar = new SqlConnection();

        public Conexion()
        {
            Conectar.ConnectionString = connection;
        }

        public void AbrirConexion()
        {
            try
            {
                Conectar.Open();
                Console.WriteLine("Conexion exitosa");
            }
            catch (Exception e)
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
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static SqlConnection ConectarCliente()
        {
            SqlConnection cn = new SqlConnection("Data Source=(local)\\SQLEXPRESS ;Initial Catalog=BodegaFalcom;Integrated Security=True");
            cn.Open();
            return cn;
        }

        public void Busquedas1(string Comando, DataGridView grid)
        {
            DataSet dsa = new DataSet();
            BindingSource bs = new BindingSource();
            DataTable dt = new DataTable();

            string cnn = "Data Source=(local)\\SQLEXPRESS ;Initial Catalog=BodegaFalcom;Integrated Security=True";
            SqlConnection SqlCon = new SqlConnection(cnn);

            SqlDataAdapter da = new SqlDataAdapter(Comando, SqlCon);

            da.Fill(dt);
            bs.DataSource = dt.DefaultView;

            grid.DataSource = bs;

            DataSet ds = new DataSet();
            ds.Tables.Add(dt.Copy());

            DataView dv = new DataView(ds.Tables[0]);



            if (dv.Count != 0)
            {
                grid.DataSource = dv;
            }
            else
            {
                grid.DataSource = null;
            }
        }

        public bool Modificaciones(string Comando)
        {
            SqlConnection CnnSql = new SqlConnection("Data Source=(local)\\SQLEXPRESS ;Initial Catalog=BodegaFalcom;Integrated Security=True");
            SqlCommand Cmd = new SqlCommand(Comando, CnnSql);

            CnnSql.Open();
            Cmd.ExecuteNonQuery();

            CnnSql.Dispose();
            Cmd.Dispose();

            return true;
        }

        public DataSet Consultas(string Comando)
        {
            DataSet ds = new DataSet();

            DataSet dsa = new DataSet();

            SqlConnection cnnsql = new SqlConnection("Data Source=(local)\\SQLEXPRESS ;Initial Catalog=BodegaFalcom;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(Comando, cnnsql);


            da.Fill(dsa, "Tabla");
            ds = dsa;

            // dispose es para limpiar la variable
            ds.Dispose();
            dsa.Dispose();
            cnnsql.Dispose();

            return ds;
        }

        public class departamentos
        {
            public int codigoDepartamento { get; set; }
            public string nombreDepartamento { get; set; }
        }

        public static List<departamentos> CargarDatos()
        {
            var lista = new List<departamentos>();
            using (var con = new SqlConnection("Data Source=(local)\\SQLEXPRESS;Initial Catalog=BodegaFalcom;Integrated Security=True"))
            {
                con.Open();
                const string consulta = "select codigoDepartamento, nombreDepartamento from departamentos";
                var cmd = new SqlCommand(consulta, con);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    var entidad = new departamentos();
                    entidad.codigoDepartamento = Convert.ToInt32(lector[0]);
                    entidad.nombreDepartamento = Convert.ToString(lector[1]);
                    lista.Add(entidad);
                }
                return lista;
            }
        }

        public void Busquedas(string Comando, DataGridView grid, string columna)
        {
            DataSet dsa = new DataSet();
            BindingSource bs = new BindingSource();
            DataTable dt = new DataTable();

            string cnn = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=BodegaFalcom;Integrated Security=True";
            SqlConnection SqlCon = new SqlConnection(cnn);

            SqlDataAdapter da = new SqlDataAdapter(Comando, SqlCon);

            da.Fill(dt);
            bs.DataSource = dt.DefaultView;

            grid.DataSource = bs;

            DataSet ds = new DataSet();
            ds.Tables.Add(dt.Copy());

            DataView dv = new DataView(ds.Tables[0]);

            dv.RowFilter = columna;

            if (dv.Count != 0)
            {
                grid.DataSource = dv;
            }
            else
            {
                grid.DataSource = null;
            }
        }
    }
}
