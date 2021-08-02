
namespace Proyecto_Falcom_Bodega
{
    partial class CrearSolicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listEmpleado = new System.Windows.Forms.ListBox();
            this.listCliente = new System.Windows.Forms.ListBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaFalcomDataSet = new Proyecto_Falcom_Bodega.BodegaFalcomDataSet();
            this.clientesTableAdapter = new Proyecto_Falcom_Bodega.BodegaFalcomDataSetTableAdapters.ClientesTableAdapter();
            this.colaboradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colaboradoresTableAdapter = new Proyecto_Falcom_Bodega.BodegaFalcomDataSetTableAdapters.colaboradoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaFalcomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = ">>";
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.AllowUserToResizeRows = false;
            this.dgvSolicitudes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(442, 62);
            this.dgvSolicitudes.MultiSelect = false;
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudes.Size = new System.Drawing.Size(462, 336);
            this.dgvSolicitudes.TabIndex = 20;
            this.dgvSolicitudes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Crear Solicitud";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(69, 357);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(80, 24);
            this.lblfecha.TabIndex = 18;
            this.lblfecha.Text = "12/12/12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha: ";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(230, 341);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(137, 57);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Solicitud Nueva";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Solicitudes Existentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Colaboradores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Clientes";
            // 
            // listEmpleado
            // 
            this.listEmpleado.DataSource = this.colaboradoresBindingSource;
            this.listEmpleado.DisplayMember = "nombreColaborador";
            this.listEmpleado.FormattingEnabled = true;
            this.listEmpleado.Location = new System.Drawing.Point(230, 62);
            this.listEmpleado.Name = "listEmpleado";
            this.listEmpleado.Size = new System.Drawing.Size(137, 251);
            this.listEmpleado.TabIndex = 11;
            this.listEmpleado.ValueMember = "codigoColaborador";
            // 
            // listCliente
            // 
            this.listCliente.DataSource = this.clientesBindingSource;
            this.listCliente.DisplayMember = "NombreCliente";
            this.listCliente.FormattingEnabled = true;
            this.listCliente.Location = new System.Drawing.Point(12, 62);
            this.listCliente.Name = "listCliente";
            this.listCliente.Size = new System.Drawing.Size(137, 251);
            this.listCliente.TabIndex = 10;
            this.listCliente.ValueMember = "CodigoCliente";
            this.listCliente.SelectedIndexChanged += new System.EventHandler(this.listCliente_SelectedIndexChanged);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.bodegaFalcomDataSet;
            // 
            // bodegaFalcomDataSet
            // 
            this.bodegaFalcomDataSet.DataSetName = "BodegaFalcomDataSet";
            this.bodegaFalcomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // colaboradoresBindingSource
            // 
            this.colaboradoresBindingSource.DataMember = "colaboradores";
            this.colaboradoresBindingSource.DataSource = this.bodegaFalcomDataSet;
            // 
            // colaboradoresTableAdapter
            // 
            this.colaboradoresTableAdapter.ClearBeforeFill = true;
            // 
            // CrearSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 416);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listEmpleado);
            this.Controls.Add(this.listCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearSolicitud";
            this.Text = "CrearSolicitud";
            this.Load += new System.EventHandler(this.CrearSolicitud_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaFalcomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listEmpleado;
        private System.Windows.Forms.ListBox listCliente;
        private BodegaFalcomDataSet bodegaFalcomDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private BodegaFalcomDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource colaboradoresBindingSource;
        private BodegaFalcomDataSetTableAdapters.colaboradoresTableAdapter colaboradoresTableAdapter;
    }
}