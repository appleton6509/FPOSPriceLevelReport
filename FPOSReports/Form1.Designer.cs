namespace FPOSReports
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.itemPriceTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fpos5DataSet = new FPOSReports.fpos5DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlViewer = new System.Windows.Forms.Panel();
            this.pbxSettings = new System.Windows.Forms.PictureBox();
            this.tableAdapterManager1 = new FPOSReports.fpos5DataSetTableAdapters.TableAdapterManager();
            this.itemPriceTableAdapter = new FPOSReports.fpos5DataSetTableAdapters.ItemPriceTableAdapter();
            this.fpos5DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fpos5DataSet1 = new FPOSReports.fpos5DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.itemPriceTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpos5DataSet)).BeginInit();
            this.pnlViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpos5DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpos5DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPriceTableBindingSource
            // 
            this.itemPriceTableBindingSource.DataMember = "ItemPriceTable";
            this.itemPriceTableBindingSource.DataSource = this.fpos5DataSet;
            // 
            // fpos5DataSet
            // 
            this.fpos5DataSet.DataSetName = "fpos5DataSet";
            this.fpos5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AllowDrop = true;
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 1;
            reportDataSource1.Name = "ItemPriceDS";
            reportDataSource1.Value = this.itemPriceTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FPOSReports.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(832, 603);
            this.reportViewer1.TabIndex = 0;
            // 
            // pnlViewer
            // 
            this.pnlViewer.Controls.Add(this.pbxSettings);
            this.pnlViewer.Controls.Add(this.reportViewer1);
            this.pnlViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewer.Location = new System.Drawing.Point(0, 0);
            this.pnlViewer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlViewer.Name = "pnlViewer";
            this.pnlViewer.Size = new System.Drawing.Size(832, 603);
            this.pnlViewer.TabIndex = 1;
            // 
            // pbxSettings
            // 
            this.pbxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSettings.Image = global::FPOSReports.Properties.Resources.cog_gear;
            this.pbxSettings.Location = new System.Drawing.Point(496, 3);
            this.pbxSettings.Name = "pbxSettings";
            this.pbxSettings.Size = new System.Drawing.Size(29, 23);
            this.pbxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSettings.TabIndex = 7;
            this.pbxSettings.TabStop = false;
            this.pbxSettings.Click += new System.EventHandler(this.pbxSettings_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = FPOSReports.fpos5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemPriceTableAdapter
            // 
            this.itemPriceTableAdapter.ClearBeforeFill = true;
            // 
            // fpos5DataSetBindingSource
            // 
            this.fpos5DataSetBindingSource.DataSource = this.fpos5DataSet;
            this.fpos5DataSetBindingSource.Position = 0;
            // 
            // fpos5DataSet1
            // 
            this.fpos5DataSet1.DataSetName = "fpos5DataSet";
            this.fpos5DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.pnlViewer);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(835, 600);
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPOS - Price Level Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemPriceTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpos5DataSet)).EndInit();
            this.pnlViewer.ResumeLayout(false);
            this.pnlViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpos5DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpos5DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private fpos5DataSet fpos5DataSet;
        private System.Windows.Forms.Panel pnlViewer;
        private fpos5DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.PictureBox pbxSettings;
        private System.Windows.Forms.BindingSource itemPriceTableBindingSource;
        private fpos5DataSetTableAdapters.ItemPriceTableAdapter itemPriceTableAdapter;
        private System.Windows.Forms.BindingSource fpos5DataSetBindingSource;
        private fpos5DataSet fpos5DataSet1;
    }
}

