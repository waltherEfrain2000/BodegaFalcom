using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Falcom_Bodega
{
    public partial class Bitacora : Form
    {
        Conexion conexion = new Conexion();
        public Bitacora()
        {
            InitializeComponent();
            conexion.Busquedas1("exec mostrarBitacoraInventario", dataGridView1);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Bitacora_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
