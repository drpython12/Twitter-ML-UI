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
    public partial class StreamerForm : Form
    {
        public StreamerForm()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            string string_num_of_tweets = BoxNumOfTweets.Text;
            int int_num_of_tweets; 
            bool intResultTryParse = int.TryParse(string_num_of_tweets, out int_num_of_tweets);
            if (intResultTryParse == false)
            {
                MessageBox.Show("Please input a number...");
            }
            else
            {
                string[] keywords = KeywordBox.Text.Split(',');
                string args = string.Format(@"/k cd C:\Users\gandh\OneDrive\Documents\Programming\NEA\ML-Twitter-Hate-Speech-Detection & python Streamer.py {0} {1}", keywords, int_num_of_tweets);
                ProcessStartInfo process = new ProcessStartInfo();
                process.FileName = "cmd.exe";
                process.Arguments = args;
                Process proStart = new Process();
                proStart.StartInfo = process;
                proStart.Start();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
