using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.IO;

namespace Twitter_System_UI
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV files|*.csv";
            openFileDialog1.ShowDialog();
            string uploadFilename = openFileDialog1.FileName;
            string fileEnding = Path.GetExtension(uploadFilename);
            if (fileEnding == ".csv")
            {
                string args = string.Format(@"/k cd C:\Users\gandh\OneDrive\Documents\Programming\NEA\ML-Twitter-Hate-Speech-Detection & python Database.py w {0}", uploadFilename);
                ProcessStartInfo process = new ProcessStartInfo();
                process.FileName = "cmd.exe";
                process.Arguments = args;
                Process proStart = new Process();
                proStart.StartInfo = process;
                proStart.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proStart.StartInfo.RedirectStandardError = true;
                proStart.StartInfo.UseShellExecute = false;
                try
                {
                    proStart.Start();
                    StreamReader streamReader = proStart.StandardError;
                    if (streamReader.ReadToEnd() == "")
                    {
                         MessageBox.Show("Success!");
                    }
                    else
                    {
                        MessageBox.Show("Please choose a file that has not already been uploaded to the database!");
                    }
                }
                catch (Exception c)
                {
                        MessageBox.Show(c.Message);
                }
            }
        }

        private void DatabaseViewButton_Click(object sender, EventArgs e)
        {
            string args = string.Format(@"/k cd C:\Users\gandh\OneDrive\Documents\Programming\NEA\ML-Twitter-Hate-Speech-Detection & python Database.py r");
            ProcessStartInfo process = new ProcessStartInfo();
            process.FileName = "cmd.exe";
            process.Arguments = args;
            Process proStart = new Process();
            proStart.StartInfo = process;
            proStart.Start();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
