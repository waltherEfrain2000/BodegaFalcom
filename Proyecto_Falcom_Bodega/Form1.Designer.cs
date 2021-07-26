
namespace Proyecto_Falcom_Bodega
{
    partial class Menú
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelhijo = new System.Windows.Forms.Panel();
            this.btnProducto = new MaterialSkin.Controls.MaterialButton();
            this.btnInventario = new MaterialSkin.Controls.MaterialButton();
            this.btnSolicitudes = new MaterialSkin.Controls.MaterialButton();
            this.btnColaboradores = new MaterialSkin.Controls.MaterialButton();
            this.btnClientes = new MaterialSkin.Controls.MaterialButton();
            this.btnUsuarios = new MaterialSkin.Controls.MaterialButton();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnColaboradores);
            this.panel1.Controls.Add(this.btnSolicitudes);
            this.panel1.Controls.Add(this.btnInventario);
            this.panel1.Controls.Add(this.btnProducto);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 507);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Falcom_Bodega.Properties.Resources.a;
            this.pictureBox1.Location = new System.Drawing.Point(35, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelhijo
            // 
            this.panelhijo.BackColor = System.Drawing.Color.Gainsboro;
            this.panelhijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelhijo.Location = new System.Drawing.Point(175, 64);
            this.panelhijo.Name = "panelhijo";
            this.panelhijo.Size = new System.Drawing.Size(937, 507);
            this.panelhijo.TabIndex = 1;
            // 
            // btnProducto
            // 
            this.btnProducto.AutoSize = false;
            this.btnProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProducto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProducto.Depth = 0;
            this.btnProducto.HighEmphasis = true;
            this.btnProducto.Icon = null;
            this.btnProducto.Location = new System.Drawing.Point(4, 124);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(164, 36);
            this.btnProducto.TabIndex = 2;
            this.btnProducto.Text = "Producto";
            this.btnProducto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProducto.UseAccentColor = false;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.AutoSize = false;
            this.btnInventario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInventario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInventario.Depth = 0;
            this.btnInventario.HighEmphasis = true;
            this.btnInventario.Icon = null;
            this.btnInventario.Location = new System.Drawing.Point(4, 172);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInventario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(164, 36);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInventario.UseAccentColor = false;
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.AutoSize = false;
            this.btnSolicitudes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSolicitudes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSolicitudes.Depth = 0;
            this.btnSolicitudes.HighEmphasis = true;
            this.btnSolicitudes.Icon = null;
            this.btnSolicitudes.Location = new System.Drawing.Point(4, 220);
            this.btnSolicitudes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSolicitudes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(164, 36);
            this.btnSolicitudes.TabIndex = 4;
            this.btnSolicitudes.Text = "Solicitudes";
            this.btnSolicitudes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSolicitudes.UseAccentColor = false;
            this.btnSolicitudes.UseVisualStyleBackColor = true;
            // 
            // btnColaboradores
            // 
            this.btnColaboradores.AutoSize = false;
            this.btnColaboradores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnColaboradores.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnColaboradores.Depth = 0;
            this.btnColaboradores.HighEmphasis = true;
            this.btnColaboradores.Icon = null;
            this.btnColaboradores.Location = new System.Drawing.Point(4, 268);
            this.btnColaboradores.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnColaboradores.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnColaboradores.Name = "btnColaboradores";
            this.btnColaboradores.Size = new System.Drawing.Size(164, 36);
            this.btnColaboradores.TabIndex = 5;
            this.btnColaboradores.Text = "Colaboradores";
            this.btnColaboradores.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnColaboradores.UseAccentColor = false;
            this.btnColaboradores.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.AutoSize = false;
            this.btnClientes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClientes.Depth = 0;
            this.btnClientes.HighEmphasis = true;
            this.btnClientes.Icon = null;
            this.btnClientes.Location = new System.Drawing.Point(4, 316);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(164, 36);
            this.btnClientes.TabIndex = 6;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClientes.UseAccentColor = false;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AutoSize = false;
            this.btnUsuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsuarios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUsuarios.Depth = 0;
            this.btnUsuarios.HighEmphasis = true;
            this.btnUsuarios.Icon = null;
            this.btnUsuarios.Location = new System.Drawing.Point(4, 364);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(164, 36);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUsuarios.UseAccentColor = false;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = false;
            this.btnCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.HighEmphasis = true;
            this.btnCerrarSesion.Icon = null;
            this.btnCerrarSesion.Location = new System.Drawing.Point(4, 465);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(164, 36);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCerrarSesion.UseAccentColor = false;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1115, 574);
            this.Controls.Add(this.panelhijo);
            this.Controls.Add(this.panel1);
            this.Name = "Menú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnProducto;
        private System.Windows.Forms.Panel panelhijo;
        private MaterialSkin.Controls.MaterialButton btnCerrarSesion;
        private MaterialSkin.Controls.MaterialButton btnUsuarios;
        private MaterialSkin.Controls.MaterialButton btnClientes;
        private MaterialSkin.Controls.MaterialButton btnColaboradores;
        private MaterialSkin.Controls.MaterialButton btnSolicitudes;
        private MaterialSkin.Controls.MaterialButton btnInventario;
    }
}

