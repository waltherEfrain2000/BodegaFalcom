using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_Falcom_Bodega
{
    public partial class Frm_Inventario : Form
    {

        Conexion conexion = new Conexion();
        private const char SignoDecimal = '.'; // Carácter separador decimal
        private string _prevTextBoxValue; // Variable que almacena el valor anterior del Textbox

        public Frm_Inventario()
        {
            InitializeComponent();
        }

        private void Frm_Inventario_Load(object sender, EventArgs e)
        {
            conexion.Busquedas1("Select * from Producto", dataGridView1);
            conexion.Busquedas1(@"Select p.codigoInventario as 'Codigo Inventario',p.codigoProducto as 'Codigo Producto', v.nombreproducto ,p.[cantidad],
p.[fechaIngreso],p.[fechaCaducidad],p.[duracionPromedio] from [Inventario] as p
inner join Producto as v on v.codigoProducto= p.codigoProducto", dataGridView2);

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
            if (txtcantidad.Text == "" || txtcodProducto.Text == " ")
            {

                MessageBox.Show("Algunos campos estan vacios, Favor revisar si selecciono el producto y que las casillas esten llenas", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            else
            {

                try
                {
                    decimal cantidad;
                    int codpro;
                    string fechaingreso, fechapodrido, duracion;

                    cantidad = Convert.ToDecimal(txtcantidad.Text);
                    codpro = Convert.ToInt32(txtcodProducto.Text);
                    fechaingreso = dateTimePicker1.Text.ToString();
                    fechapodrido = dateTimePicker2.Text.ToString();
                    duracion = dateTimePicker3.Text.ToString();


                    conexion.Modificaciones("Insert into Inventario values('" + codpro + "','" + cantidad + "','" + fechaingreso + "','" + fechapodrido + "','" + duracion + "' ) ");
                    //conexion.Modificaciones("Insert into Inventario values('" + txtcantidad.Text + "','" + txtcodProducto.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "' ) ");

                }
                catch (Exception)
                {

                    MessageBox.Show("Ha ocurrido un error , revise los campos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Se ha Insertado el producto correctamente", "Se ingreso el valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Busquedas1("Select * from Producto", dataGridView1);
                    conexion.Busquedas1(@"Select p.codigoInventario as 'Codigo Inventario',p.codigoProducto as 'Codigo Producto', v.nombreproducto ,p.[cantidad],
p.[fechaIngreso],p.[fechaCaducidad],p.[duracionPromedio] from [Inventario] as p
inner join Producto as v on v.codigoProducto= p.codigoProducto", dataGridView2);
                    LimpiarCasillas();
                }
            }



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

        public void LimpiarCasillas()
        {
            txtcodProducto.Text = "";
            txtcodinventario.Text = "";
            txtnomProducto.Text = "";
            txtcantidad.Text = "";
            btnInsertar.Enabled = true;
            btneliminar.Enabled = true;
            btnmodificar.Enabled = true;
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            dateTimePicker3.Text = "";


        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodinventario.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtcodProducto.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtnomProducto.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtcantidad.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                dateTimePicker2.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                dateTimePicker3.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                btnInsertar.Enabled = false;
                txtcodinventario.Enabled = false;
                txtnomProducto.Enabled = false;
                txtcodProducto.Enabled = false;

            }
            catch (Exception)
            {

                MessageBox.Show("Al parecer a ocurrido un error vuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcodinventario.Text == "")
            {
                MessageBox.Show("Asegurese de seleccionar un producto de el listado de abajo para poder modificar un producto", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    decimal cantidad;
                    int codpro, codinventario;
                    string fechaingreso, fechapodrido, duracion;
                    codinventario = Convert.ToInt32(txtcodinventario.Text);
                    cantidad = Convert.ToDecimal(txtcantidad.Text);
                    codpro = Convert.ToInt32(txtcodProducto.Text);
                    fechaingreso = dateTimePicker1.Text.ToString();
                    fechapodrido = dateTimePicker2.Text.ToString();
                    duracion = dateTimePicker3.Text.ToString();


                    conexion.Modificaciones("Update Inventario Set codigoProducto ='" + codpro + "',cantidad='" + cantidad + "', fechaIngreso='" + fechaingreso + "',fechaCaducidad='" + fechapodrido + "',duracionPromedio='" + duracion + "' where codigoInventario= '" + codinventario + "'");
                    //conexion.Modificaciones("Insert into Inventario values('" + txtcantidad.Text + "','" + txtcodProducto.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "' ) ");
                }
                catch (Exception)
                {

                    MessageBox.Show("Al parecer ha ocurrido un error al momento de modificar el product, favor revisar datos y casillas", "Error al modificar producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Se ha Modificado el producto correctamente", "Se ingreso el valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Busquedas1("Select * from Producto", dataGridView1);
                    conexion.Busquedas1(@"Select p.codigoInventario as 'Codigo Inventario',p.codigoProducto as 'Codigo Producto', v.nombreproducto ,p.[cantidad],
p.[fechaIngreso],p.[fechaCaducidad],p.[duracionPromedio] from [Inventario] as p
inner join Producto as v on v.codigoProducto= p.codigoProducto", dataGridView2);

                    LimpiarCasillas();
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtcodinventario.Text == "")
            {
                MessageBox.Show("Asegurese de seleccionar un producto de el listado de abajo para poder eliminar un producto", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    decimal cantidad;
                    int codpro, codinventario;
                    string fechaingreso, fechapodrido, duracion;
                    codinventario = Convert.ToInt32(txtcodinventario.Text);
                    cantidad = Convert.ToDecimal(txtcantidad.Text);
                    codpro = Convert.ToInt32(txtcodProducto.Text);
                    fechaingreso = dateTimePicker1.Text.ToString();
                    fechapodrido = dateTimePicker2.Text.ToString();
                    duracion = dateTimePicker3.Text.ToString();


                    conexion.Modificaciones(" Delete from Inventario where codigoInventario= '" + codinventario + "'");
                    //conexion.Modificaciones("Insert into Inventario values('" + txtcantidad.Text + "','" + txtcodProducto.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "' ) ");
                }
                catch (Exception)
                {

                    MessageBox.Show("Al parecer ha ocurrido un error al momento de Eliminar el producto, favor revisar datos y casillas", "Error al modificar producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Se ha Eliminado el producto correctamente", "Se ingreso el valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Busquedas1("Select * from Producto", dataGridView1);
                    conexion.Busquedas1(@"Select p.codigoInventario as 'Codigo Inventario',p.codigoProducto as 'Codigo Producto', v.nombreproducto ,p.[cantidad],
p.[fechaIngreso],p.[fechaCaducidad],p.[duracionPromedio] from [Inventario] as p
inner join Producto as v on v.codigoProducto= p.codigoProducto", dataGridView2);
                    LimpiarCasillas();
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

            var textBox = (TextBox)sender;
            // Comprueba si el valor del TextBox se ajusta a un valor válido
            if (Regex.IsMatch(textBox.Text, @"^(?:\d+\.?\d*)?$"))
            {
                // Si es válido se almacena el valor actual en la variable privada
                _prevTextBoxValue = textBox.Text;
            }
            else
            {
                // Si no es válido se recupera el valor de la variable privada con el valor anterior
                // Calcula el nº de caracteres después del cursor para dejar el cursor en la misma posición
                var charsAfterCursor = textBox.TextLength - textBox.SelectionStart - textBox.SelectionLength;
                // Recupera el valor anterior
                textBox.Text = _prevTextBoxValue;
                // Posiciona el cursor en la misma posición
                textBox.SelectionStart = Math.Max(0, textBox.TextLength - charsAfterCursor);
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            // Si el carácter pulsado no es un carácter válido se anula
            e.Handled = !char.IsDigit(e.KeyChar) // No es dígito
                        && !char.IsControl(e.KeyChar) // No es carácter de control (backspace)
                        && (e.KeyChar != SignoDecimal // No es signo decimal o es la 1ª posición o ya hay un signo decimal
                            || textBox.SelectionStart == 0
                            || textBox.Text.Contains(SignoDecimal));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ReporteProductosTotales reporteProductosTotales = new ReporteProductosTotales();
            reporteProductosTotales.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ReporteProductosTotales reporteProductosTotales = new ReporteProductosTotales();
            reporteProductosTotales.Show();
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            if (txtcantidad.Text == "" || txtcodProducto.Text == " ")
            {

                MessageBox.Show("Algunos campos estan vacios, Favor revisar si selecciono el producto y que las casillas esten llenas", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            }
            else
            {

                try
                {
                    decimal cantidad;
                    int codpro;
                    string fechaingreso, fechapodrido, duracion;

                    cantidad = Convert.ToDecimal(txtcantidad.Text);
                    codpro = Convert.ToInt32(txtcodProducto.Text);
                    fechaingreso = dateTimePicker1.Text.ToString();
                    fechapodrido = dateTimePicker2.Text.ToString();
                    duracion = dateTimePicker3.Text.ToString();


                    conexion.Modificaciones("Insert into Inventario values('" + codpro + "','" + cantidad + "','" + fechaingreso + "','" + fechapodrido + "','" + duracion + "' ) ");
                    //conexion.Modificaciones("Insert into Inventario values('" + txtcantidad.Text + "','" + txtcodProducto.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "' ) ");

                }
                catch (Exception)
                {

                    MessageBox.Show("Ha ocurrido un error , revise los campos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Se ha Insertado el producto correctamente", "Se ingreso el valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Busquedas1("Select * from Producto", dataGridView1);
                    conexion.Busquedas1(@"Select p.codigoInventario as 'Codigo Inventario',p.codigoProducto as 'Codigo Producto', v.nombreproducto ,p.[cantidad],
                    p.[fechaIngreso],p.[fechaCaducidad],p.[duracionPromedio] from [Inventario] as p
                    inner join Producto as v on v.codigoProducto= p.codigoProducto", dataGridView2);
                    LimpiarCasillas();
                }
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (txtcodinventario.Text == "")
            {
                MessageBox.Show("Asegurese de seleccionar un producto de el listado de abajo para poder modificar un producto", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    decimal cantidad;
                    int codpro, codinventario;
                    string fechaingreso, fechapodrido, duracion;
                    codinventario = Convert.ToInt32(txtcodinventario.Text);
                    cantidad = Convert.ToDecimal(txtcantidad.Text);
                    codpro = Convert.ToInt32(txtcodProducto.Text);
                    fechaingreso = dateTimePicker1.Text.ToString();
                    fechapodrido = dateTimePicker2.Text.ToString();
                    duracion = dateTimePicker3.Text.ToString();


                    conexion.Modificaciones("Update Inventario Set codigoProducto ='" + codpro + "',cantidad='" + cantidad + "', fechaIngreso='" + fechaingreso + "',fechaCaducidad='" + fechapodrido + "',duracionPromedio='" + duracion + "' where codigoInventario= '" + codinventario + "'");
                    //conexion.Modificaciones("Insert into Inventario values('" + txtcantidad.Text + "','" + txtcodProducto.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "' ) ");
                }
                catch (Exception)
                {

                    MessageBox.Show("Al parecer ha ocurrido un error al momento de modificar el product, favor revisar datos y casillas", "Error al modificar producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Se ha Modificado el producto correctamente", "Se ingreso el valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Busquedas1("Select * from Producto", dataGridView1);
                    conexion.Busquedas1(@"Select p.codigoInventario as 'Codigo Inventario',p.codigoProducto as 'Codigo Producto', v.nombreproducto ,p.[cantidad],
p.[fechaIngreso],p.[fechaCaducidad],p.[duracionPromedio] from [Inventario] as p
inner join Producto as v on v.codigoProducto= p.codigoProducto", dataGridView2);

                    LimpiarCasillas();
                }


            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (txtcodinventario.Text == "")
            {
                MessageBox.Show("Asegurese de seleccionar un producto de el listado de abajo para poder eliminar un producto", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    decimal cantidad;
                    int codpro, codinventario;
                    string fechaingreso, fechapodrido, duracion;
                    codinventario = Convert.ToInt32(txtcodinventario.Text);
                    cantidad = Convert.ToDecimal(txtcantidad.Text);
                    codpro = Convert.ToInt32(txtcodProducto.Text);
                    fechaingreso = dateTimePicker1.Text.ToString();
                    fechapodrido = dateTimePicker2.Text.ToString();
                    duracion = dateTimePicker3.Text.ToString();


                    conexion.Modificaciones(" Delete from Inventario where codigoInventario= '" + codinventario + "'");
                    //conexion.Modificaciones("Insert into Inventario values('" + txtcantidad.Text + "','" + txtcodProducto.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "' ) ");
                }
                catch (Exception)
                {

                    MessageBox.Show("Al parecer ha ocurrido un error al momento de Eliminar el producto, favor revisar datos y casillas", "Error al modificar producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show("Se ha Eliminado el producto correctamente", "Se ingreso el valor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Busquedas1("Select * from Producto", dataGridView1);
                    conexion.Busquedas1(@"Select p.codigoInventario as 'Codigo Inventario',p.codigoProducto as 'Codigo Producto', v.nombreproducto ,p.[cantidad],
p.[fechaIngreso],p.[fechaCaducidad],p.[duracionPromedio] from [Inventario] as p
inner join Producto as v on v.codigoProducto= p.codigoProducto", dataGridView2);
                    LimpiarCasillas();
                }
            }
        }

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtcodinventario.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtcodProducto.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtnomProducto.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtcantidad.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                dateTimePicker2.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                dateTimePicker3.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                btnInsertar.Enabled = false;
                txtcodinventario.Enabled = false;
                txtnomProducto.Enabled = false;
                txtcodProducto.Enabled = false;

            }
            catch (Exception)
            {

                MessageBox.Show("Al parecer a ocurrido un error vuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Frm_Inventario_Load_1(object sender, EventArgs e)
        {
            conexion.Busquedas1("Select * from Producto", dataGridView1);
            conexion.Busquedas1(@"Select p.codigoInventario as 'Codigo Inventario',p.codigoProducto as 'Codigo Producto', v.nombreproducto ,p.[cantidad],
p.[fechaIngreso],p.[fechaCaducidad],p.[duracionPromedio] from [Inventario] as p
inner join Producto as v on v.codigoProducto= p.codigoProducto", dataGridView2);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy'-'MM'-'dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy'-'MM'-'dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy'-'MM'-'dd";
        }
    }
}