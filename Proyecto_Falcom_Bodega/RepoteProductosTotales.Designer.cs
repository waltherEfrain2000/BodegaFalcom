
namespace Proyecto_Falcom_Bodega
{
    partial class RepoteProductosTotales
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BodegaFalcomDataSet2 = new Proyecto_Falcom_Bodega.BodegaFalcomDataSet2();
            this.MostrarProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MostrarProductosTableAdapter = new Proyecto_Falcom_Bodega.BodegaFalcomDataSet2TableAdapters.MostrarProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BodegaFalcomDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.MostrarProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Falcom_Bodega.Reporte_Inventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // BodegaFalcomDataSet
            // 
            this.BodegaFalcomDataSet2.DataSetName = "BodegaFalcomDataSet";
            this.BodegaFalcomDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MostrarProductosBindingSource
            // 
            this.MostrarProductosBindingSource.DataMember = "MostrarProductos";
            this.MostrarProductosBindingSource.DataSource = this.BodegaFalcomDataSet2;
            // 
            // MostrarProductosTableAdapter
            // 
            this.MostrarProductosTableAdapter.ClearBeforeFill = true;
            // 
            // RepoteProductosTotales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepoteProductosTotales";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RepoteProductosTotales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BodegaFalcomDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MostrarProductosBindingSource;
        private BodegaFalcomDataSet2 BodegaFalcomDataSet2;
        private BodegaFalcomDataSet2TableAdapters.MostrarProductosTableAdapter MostrarProductosTableAdapter;
    }
}

