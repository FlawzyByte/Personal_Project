using System;
using System.Windows.Forms;

namespace NWRC21
{
    public partial class Payement : Form
    {
        private totPayement payement;
        private Worksheet worksheet = null;

        public Payement()
        {
            InitializeComponent();
        }
        public Payement(Form worksheet)
        {
            this.worksheet = worksheet as Worksheet;
            payement = this.worksheet.totallpayment();
            InitializeComponent();
        }
        private string totServTime(int timeCost)
        {
            int totalmin = 0;
            string time = "";

            totalmin = timeCost / 250;
            time = $"{totalmin / 60}Hr{totalmin % 60}mins";

            return time;
        }
        public void Payement_Load(object sender, EventArgs e)
        {
            if (payement != null || worksheet != null)
            {
                MatCostlbl.Text = payement.totMatPrc.ToString();
                SrvCostlbl.Text = payement.totTimePrc.ToString();
                TotalPaylbl.Text = (payement.totMatPrc + payement.totTimePrc).ToString();
                ServTimelbl.Text = totServTime((int)payement.totTimePrc);
                Numregwrklbl.Text = worksheet.WorksheetsCreated.ToString();

            }
            this.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("Did the customer already paid?", "Payement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("\nHave a good day!🎉", "      🐙NWRC21🐙");
                Application.ExitThread();

            }
        }
    }
}
