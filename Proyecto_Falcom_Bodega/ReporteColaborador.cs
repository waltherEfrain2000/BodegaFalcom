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
    public partial class ReporteColaborador : Form
    {
        public ReporteColaborador()
        {
            InitializeComponent();
        }

        private void ReporteColaborador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BodegaFalcomDataSet.colaboradores' Puede moverla o quitarla según sea necesario.
            this.colaboradoresTableAdapter.Fill(this.BodegaFalcomDataSet.colaboradores);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
