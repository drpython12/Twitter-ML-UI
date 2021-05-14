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
            openFileDialog1.ShowDialog();
            string uploadFilename = openFileDialog1.FileName;
            string args = string.Format(@"");
            ProcessStartInfo process = new ProcessStartInfo();
            process.FileName = "cmd.exe";
            process.Arguments = args;
            Process proStart = new Process();
            proStart.StartInfo = process;
            proStart.Start();
        }

        private void DatabaseViewButton_Click(object sender, EventArgs e)
        {
            runQuery();
        }

        private void runQuery()
        {
            string query = "SELECT * FROM User, Tweet, TweetEntities, TweetAnalysis";
            string MySQLConnection = "datasource=127.0.0.1;port=3306;username=root;password=Palashg12;database=TwitterMachineLearningDatabase";
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnection);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
            }catch(Exception e)
            {
                MessageBox.Show("Query Error: " + e.Message);
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
