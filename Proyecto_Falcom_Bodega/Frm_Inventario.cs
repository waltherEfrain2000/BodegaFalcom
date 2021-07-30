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

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy'-'MM'-'dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy'-'MM'-'dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy'-'MM'-'dd";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodProducto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtnomProducto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Al parecer a ocurrido un error vuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            decimal cantidad;
            int codpro;
      string fechaingreso, fechapodrido, duracion;

            cantidad = Convert.ToDecimal( txtcantidad.Text);
            codpro = Convert.ToInt32(txtcodProducto.Text);
            fechaingreso = dateTimePicker1.Text.ToString();
            fechapodrido = dateTimePicker2.Text.ToString();
            duracion = dateTimePicker3.Text.ToString();


            conexion.Modificaciones("Insert into Inventario values('" + codpro + "','" + cantidad + "','" + fechaingreso + "','" + fechapodrido + "','" + duracion + "' ) ");
            //conexion.Modificaciones("Insert into Inventario values('" + txtcantidad.Text + "','" + txtcodProducto.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "' ) ");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
