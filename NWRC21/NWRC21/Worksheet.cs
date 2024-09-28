using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static NWRC21.Worksheet;

namespace NWRC21
{
    public partial class Worksheet : Form
    {
        private List<Work> loadedWork;
        public List<Work> loadedWorks() { return loadedWork; }

        public int worksheetsCreated;
        public int WorksheetsCreated { get { return worksheetsCreated; } set { worksheetsCreated = value; } }
        
        private int timecostPrc;
        public int TimeCostPrice { get { return timecostPrc; } set { timecostPrc = value; } }
        
        private int matPrc;
        public int MaterialPrice { get { return matPrc; } set { matPrc = value; } }
        
        private int totCostPrc;
        public int  TotalCostPrice { get { return   totCostPrc; } set { totCostPrc = value; } }

        

        public totPayement totalpayement = new totPayement()
        {
            totMatPrc = 0,
            totTimePrc = 0,
            totalWorksheetPrices = 0,
        };
        public totPayement totallpayment()
        {
            return totalpayement;
        }

        public static int TimeCost(string timeData)
        {
            int cost = 0;
            string[] parts = timeData.Split(' ');
            int hours = 0;
            int minutes = 0;

            foreach (string part in parts)
            {
                if (part.Contains("h"))
                {
                    int.TryParse(part.Replace("h", ""), out hours);
                }
                else if (part.Contains("m"))
                {
                    int.TryParse(part.Replace("m", ""), out minutes);
                }
            }
            int totalTime = hours * 60 + minutes;
            
            if (totalTime < 30)
            {
                totalTime = 30;
            }
            cost = 250 * totalTime;

            return cost;
        }

        private string ConvertTime(string timeData)
        {
            int totMin = int.Parse(timeData);

            int hours = totMin / 60;
            int minutes = totMin % 60;

            if (hours > 0)
            {
                if (minutes > 0)
                {
                    return $"{hours} h {minutes} m";
                }
                else
                {
                    return $"{hours} h";
                }
            }
            else
            {
                return $"{minutes} m";
            }
        }
        private void addUserControl(List<Work> text, FlowLayoutPanel flp)
        {
            flp.Controls.Clear();
            for (int i = 0; i < text.Count; i++)
            {
                UserControl1 serviceDescription = new UserControl1(this);
                serviceDescription.Name = "service" + i;
                serviceDescription.Service = text.ElementAt(i).servicename();
                serviceDescription.reqTime = ConvertTime(text.ElementAt(i).timeMin()); //var
                serviceDescription.materialcost = text.ElementAt(i).matrCost();
                flp.Controls.Add(serviceDescription);
            }
        }




        public Worksheet(List<Work> loadedWorks)
        {
            InitializeComponent();
            this.loadedWork = loadedWorks;
        }
        
        private void Worksheet_load(object sender, EventArgs e)
        {
            matPrc = 0;
            timecostPrc = 0;
            totCostPrc = 0;
            matCostLbl.Text = "";
            timeCostlbl.Text = "";
         addUserControl(loadedWork, flowLayoutPanel);
        }

        private void Worksheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void Text4_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            worksheetsCreated++;
            totalpayement.totMatPrc += matPrc;
            totalpayement.totTimePrc += timecostPrc;
            totalpayement.totalWorksheetPrices += totCostPrc;
            Worksheet_load(sender, e);
        }

        private void Text2_Click(object sender, EventArgs e)
        {

        }

        private void Pay_Click(object sender, EventArgs e)
        {
            DialogResult ptt = MessageBox.Show("Do you want further additions?","Pay",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (ptt == DialogResult.No) 
            { 
            Payement payement = new Payement(this);
            totalpayement.totMatPrc += matPrc;
            totalpayement.totTimePrc += timecostPrc;
            totalpayement.totalWorksheetPrices += totCostPrc;
            this.Hide();
            payement.Payement_Load(sender, e);
        
            }
            else 
            {
                return;
    
            }
        }
    }
}
