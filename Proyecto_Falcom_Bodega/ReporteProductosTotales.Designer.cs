
namespace Proyecto_Falcom_Bodega
{
    partial class ReporteProductosTotales
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BodegaFalcomDataSet = new Proyecto_Falcom_Bodega.BodegaFalcomDataSet();
            this.MostrarProductos2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MostrarProductos2TableAdapter = new Proyecto_Falcom_Bodega.BodegaFalcomDataSetTableAdapters.MostrarProductos2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BodegaFalcomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarProductos2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MostrarProductos2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Falcom_Bodega.ReporteProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // BodegaFalcomDataSet
            // 
            this.BodegaFalcomDataSet.DataSetName = "BodegaFalcomDataSet";
            this.BodegaFalcomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MostrarProductos2BindingSource
            // 
            this.MostrarProductos2BindingSource.DataMember = "MostrarProductos2";
            this.MostrarProductos2BindingSource.DataSource = this.BodegaFalcomDataSet;
            // 
            // MostrarProductos2TableAdapter
            // 
            this.MostrarProductos2TableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProductosTotales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteProductosTotales";
            this.Text = "ReporteProductosTotales";
            this.Load += new System.EventHandler(this.ReporteProductosTotales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BodegaFalcomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MostrarProductos2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MostrarProductos2BindingSource;
        private BodegaFalcomDataSet BodegaFalcomDataSet;
        private BodegaFalcomDataSetTableAdapters.MostrarProductos2TableAdapter MostrarProductos2TableAdapter;
    }
}