using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Proyecto_Falcom_Bodega
{
    public partial class Menú : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Menú()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green500, MaterialSkin.Primary.Green700, MaterialSkin.Primary.Green100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new prueba());
        }

        private void AbrirFormHijo(object formHija)
        {
            if(this.panelhijo.Controls.Count>0)
            {
                this.panelhijo.Controls.RemoveAt(0);
            }

            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelhijo.Controls.Add(fh);
            this.panelhijo.Tag = fh;
            fh.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
