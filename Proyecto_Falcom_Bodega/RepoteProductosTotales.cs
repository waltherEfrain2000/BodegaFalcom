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
    public partial class RepoteProductosTotales : Form
    {
        public RepoteProductosTotales()
        {
            InitializeComponent();
        }

        private void RepoteProductosTotales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BodegaFalcomDataSet.MostrarProductos' Puede moverla o quitarla según sea necesario.
            this.MostrarProductosTableAdapter.Fill(this.BodegaFalcomDataSet2.MostrarProductos);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
