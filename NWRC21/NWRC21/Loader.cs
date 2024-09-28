using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace NWRC21
{
    internal class Loader
    {

        public List<T> loader<T>(string fpath)
        {
            try
            {
                List<Work> works = new List<Work>();

                OpenFileDialog openFileDialog = new OpenFileDialog();
                Parser parser = new Parser();
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fpath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        while (!reader.EndOfStream)
                        {
                            string[] entries = reader.ReadLine().Split(';');
                            works.Add(parser.Parse(entries));
                        }
                    }
                }

                return new List<T>(works as IEnumerable<T>);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<T>();
            }
        }
    }
}