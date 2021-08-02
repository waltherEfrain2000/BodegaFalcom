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
    public partial class ReporteProductosTotales : Form
    {
        public ReporteProductosTotales()
        {
            InitializeComponent();
        }

        private void ReporteProductosTotales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BodegaFalcomDataSet.MostrarProductos2' Puede moverla o quitarla según sea necesario.
            this.MostrarProductos2TableAdapter.Fill(this.BodegaFalcomDataSet.MostrarProductos2);

            this.reportViewer1.RefreshReport();
        }
    }
}
