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

namespace Twitter_System_UI
{
    public partial class AnalyserForm : Form
    {
        public AnalyserForm()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            string importFilename = openFileDialog1.FileName;
            string exportFilename = ExportFileBox.Text + ".csv";
            string args = string.Format(@"/k cd C:\Users\gandh\OneDrive\Documents\Programming\NEA\ML-Twitter-Hate-Speech-Detection & python Classifier.py {0} {1}", importFilename, exportFilename);
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
