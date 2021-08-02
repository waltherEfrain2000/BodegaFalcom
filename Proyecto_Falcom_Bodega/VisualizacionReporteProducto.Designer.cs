
namespace Proyecto_Falcom_Bodega
{
    partial class VisualizacionReporteProducto
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
            this.ReporteProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteProductoTableAdapter = new Proyecto_Falcom_Bodega.BodegaFalcomDataSetTableAdapters.ReporteProductoTableAdapter();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BodegaFalcomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetProducto";
            reportDataSource1.Value = this.ReporteProductoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Proyecto_Falcom_Bodega.ReporteProducto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(31, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(785, 480);
            this.reportViewer1.TabIndex = 1;
            // 
            // BodegaFalcomDataSet
            // 
            this.BodegaFalcomDataSet.DataSetName = "BodegaFalcomDataSet";
            this.BodegaFalcomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteProductoBindingSource
            // 
            this.ReporteProductoBindingSource.DataMember = "ReporteProducto";
            this.ReporteProductoBindingSource.DataSource = this.BodegaFalcomDataSet;
            // 
            // ReporteProductoTableAdapter
            // 
            this.ReporteProductoTableAdapter.ClearBeforeFill = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCerrar.Location = new System.Drawing.Point(706, 515);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 48);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // VisualizacionReporteProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 575);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisualizacionReporteProducto";
            this.Text = "VisualizacionReporteProducto";
            this.Load += new System.EventHandler(this.VisualizacionReporteProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BodegaFalcomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteProductoBindingSource;
        private BodegaFalcomDataSet BodegaFalcomDataSet;
        private BodegaFalcomDataSetTableAdapters.ReporteProductoTableAdapter ReporteProductoTableAdapter;
        private System.Windows.Forms.Button btnCerrar;
    }
}