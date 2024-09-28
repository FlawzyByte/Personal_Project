using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NWRC21
{
    public partial class Form1 : Form
    {
        private List<Work> loadedWorks;
        public Form1()
        {
            InitializeComponent();
            loadedWorks = new List<Work>(); 
        }
        private void ABOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DateTime data = DateTime.Now;
            MessageBox.Show("Raji Amine Tebai\nNWRC21\n" + data.ToString(),"About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit.", "QUIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }

        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fpath = "";
            Loader loader = new Loader();
            loadedWorks = loader.loader<Work>(fpath);
            if (fpath != null || loadedWorks.Count != 0)
            {
                MessageBox.Show("File successfully uploaded! ","Loaded File");
            }
            else
            {
                MessageBox.Show("File is inappropriate!\nPlease select another file","Error Loading File");
            }
        }

        private void worksheetRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedWorks.Count == 0)
            {
                MessageBox.Show("Please upload your text file firstly,\nThen you can use our Worksheet Registration feature! :)", "ERROR");
            }
            else
            {
                Worksheet worksheet = new Worksheet(loadedWorks);
                worksheet.ShowDialog();
            }
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedWorks.Count == 0)
            {
                MessageBox.Show("Please pass the worksheet firstly,\nThen you can use our Payment feature! :)", "ERROR");
            }
            else
            {
                Payement payment = new Payement();
            }
        }
    }
}
