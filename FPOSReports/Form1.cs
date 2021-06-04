using FPOSReports.BusinessObjects;
using System;
using System.Windows.Forms;

namespace FPOSReports
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Form1()
        {
            try
            {
                InitializeComponent();
                log4net.Config.XmlConfigurator.Configure();
                Initialize();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                log.Error("Error during initialization", e);
            }
        }

        private void Initialize()
        {
            //dtpEndDate.Value = dtpStartDate.Value = DateTime.Today;
            //this.ItemSoldTableAdapter.ClearBeforeFill = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var data = this.itemPriceTableAdapter.GetData();
            // TODO: This line of code loads data into the 'fpos5DataSet.ItemPriceTable' table. You can move, or remove it, as needed.
            this.itemPriceTableAdapter.Fill(this.fpos5DataSet.ItemPriceTable);
            PopulateData();
        }

        private void PopulateData()
        {
            try
            {
                this.itemPriceTableAdapter.Connection.ConnectionString = ConnectionString.GetXMLConnectionString(Globals.CONNECTION_STRING_NAME).ToString();
                var data = this.itemPriceTableAdapter.GetData();
                this.itemPriceTableAdapter.Fill(this.fpos5DataSet.ItemPriceTable);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
                log.Error("Error updating report data", f);
            }
    
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //var dates = new DateParameter(dtpStartDate.Value, dtpEndDate.Value);
            //PopulateData(dates);
        }

        private void pbxSettings_Click(object sender, EventArgs e)
        {
            Form connect = new ConnectionSettings();
            var result = connect.ShowDialog();
            connect.Close();
            if (result == DialogResult.OK)
            {
    
            }
            else
                connect.Close();
        }
    }
}