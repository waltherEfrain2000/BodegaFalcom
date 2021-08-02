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
    public partial class VisualizacionReporteProducto : Form
    {
        public VisualizacionReporteProducto()
        {
            InitializeComponent();
        }

        private void VisualizacionReporteProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BodegaFalcomDataSet.ReporteProducto' Puede moverla o quitarla según sea necesario.
            this.ReporteProductoTableAdapter.Fill(this.BodegaFalcomDataSet.ReporteProducto);

            this.reportViewer1.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
