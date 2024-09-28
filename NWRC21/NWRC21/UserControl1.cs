using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace NWRC21
{
    public partial class UserControl1 : UserControl
    {
        private Worksheet worksheet;

        public string Service
        {
            get { return lbl01.Text; }
            set { lbl01.Text = value; }
        }
        public string materialcost
        {
            get { return lbl02.Text; }
            set { lbl02.Text = value; }
        }

        public string reqTime
        {
            get { return lbl03.Text; }
            set { lbl03.Text = value; }
        }

        public bool checkbox
        {
            get { return chkBx01.Checked; }
            set { chkBx01.Checked = value; }
        }
        public string timecost
        {
            get { return lbl04.Text; }
            set { lbl04.Text = value; }
        }
        public UserControl1(Form panels)
        {
            InitializeComponent();
            worksheet = panels as Worksheet;
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {


        }

        private void chkBx01_CheckedChanged(object sender, EventArgs e)
        {
            System.Collections.IList list = worksheet.panel1.Controls;
            if (this.chkBx01.Checked)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Control data = list[i] as Control;
                    if (data is Label)
                    {
                        if (data.Name == "matCostLbl")
                        {
                            Match match = Regex.Match(lbl02.Text, @"\d+");
                            if (match.Success)
                            {
                                int cost = int.Parse(match.Value);
                                worksheet.MaterialPrice += cost;
                                data.Text = worksheet.MaterialPrice.ToString();
                            }
                        }
                        else if (data.Name == "timeCostlbl")
                        {
                            worksheet.TimeCostPrice += Worksheet.TimeCost(reqTime);
                            data.Text = worksheet.TimeCostPrice.ToString();
                        }
                        else if (data.Name == "lbl04")
                        {
                            Match match = Regex.Match(lbl02.Text, @"\d+");
                            if (match.Success)
                            {
                                int cost = int.Parse(match.Value);
                                worksheet.TotalCostPrice += (cost + Worksheet.TimeCost(reqTime));
                                data.Text = worksheet.TotalCostPrice.ToString();
                            }
                        }
                    }
                }
                lbl04.Text = Worksheet.TimeCost(reqTime).ToString();
            }
            else // If chkbx01 is unchecked!!
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Control data = list[i] as Control;
                    if (data is Label)
                    {
                        if (data.Name == "matCostLbl")
                        {
                            Match match = Regex.Match(lbl02.Text, @"\d+");
                            if (match.Success)
                            {
                                int cost = int.Parse(match.Value);
                                worksheet.MaterialPrice -= cost;
                                data.Text = worksheet.MaterialPrice.ToString();
                            }
                        }
                        else if (data.Name == "timeCostbl")
                        {
                            worksheet.TimeCostPrice -= Worksheet.TimeCost(reqTime);
                            data.Text = worksheet.TimeCostPrice.ToString();
                        }
                        else if (data.Name == "lbl04")
                        {
                            Match match = Regex.Match(lbl02.Text, @"\d+");
                            if (match.Success)
                            {
                                int cost = int.Parse(match.Value);
                                worksheet.TotalCostPrice -= (cost + Worksheet.TimeCost(reqTime));
                                data.Text = worksheet.TotalCostPrice.ToString();
                            }
                        }
                    }
                }
                lbl04.Text = "";
            }
        }
    }
}


