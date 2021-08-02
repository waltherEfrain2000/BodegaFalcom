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
    public partial class Login : Form
    {

        Conexion con = new Conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataSet dsa = new DataSet();

            dsa = con.Consultas("exec BuscarUsuario '" + txtusuario.Text + "' ");

            //validacion para ver si el usuario existe en la base
            if (dsa.Tables[0].Rows.Count >= 1)
            {
                if (dsa.Tables[0].Rows[0][2].ToString() == txtcontraseña.Text)
                {
                    if (dsa.Tables[0].Rows[0][4].ToString() == "1")
                    {
                        if (dsa.Tables[0].Rows[0][3].ToString() == "Administrador")
                        {
                            MessageBox.Show("Bienvenido al sistema!", "Bodega Falcom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Usuarios frm1 = new Usuarios();
                            frm1.Show();
                            this.Hide();
                        }
                        else if (dsa.Tables[0].Rows[0][3].ToString() == "")
                        {
                            MessageBox.Show("Bienvenido al sistema!", "Bodega Falcom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1 frm2 = new Form1();
                            frm2.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre y/o contraseña incorrecta " + dsa.Tables[0].Rows[0][4].ToString(), "Bodega Falcom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nombre y/o contraseña incorrecta", "Bodega Falcom", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nombre y/o contraseña incorrecta", "Sistemas inteligentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
