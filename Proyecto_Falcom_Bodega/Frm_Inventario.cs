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


namespace Proyecto_Falcom_Bodega
{
    public partial class Frm_Inventario : Form
    {

        Conexion conexion = new Conexion();

        public Frm_Inventario()
        {
            InitializeComponent();
        }

        private void Frm_Inventario_Load(object sender, EventArgs e)
        {
            conexion.Busquedas1("Select * from Producto", dataGridView1);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodProducto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnomProducto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
