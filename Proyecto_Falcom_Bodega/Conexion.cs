using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Proyecto_Falcom_Bodega
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=FOXHOUND//SQLEXPRESS;DATABASE=BODEGA_FALCON;integratd security=true");
            cn.Open();
            return cn;  
        }
    }
}
