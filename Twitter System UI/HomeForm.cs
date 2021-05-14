using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Twitter_System_UI
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            NavigationPanel.Height = MainMenuButton.Height;
            NavigationPanel.Top = MainMenuButton.Top;
            NavigationPanel.Left = MainMenuButton.Left;
            HomeChart.Titles.Add("FK Score Breakdown Of Hate Tweets");
            HomeChart.BackColor = Color.FromArgb(46, 51, 73);
            HomeChart.Series["FK Scores"].Points.AddXY("31-50", "4.8");
            HomeChart.Series["FK Scores"].Points.AddXY("51-60", "6.3");
            HomeChart.Series["FK Scores"].Points.AddXY("61-70", "9.5");
            HomeChart.Series["FK Scores"].Points.AddXY("71-80", "19.0");
            HomeChart.Series["FK Scores"].Points.AddXY("81-90", "28.6");
            HomeChart.Series["FK Scores"].Points.AddXY("91-100", "30.2");
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            NavigationPanel.Height = MainMenuButton.Height;
            NavigationPanel.Top = MainMenuButton.Top;
            NavigationPanel.Left = MainMenuButton.Left;
            MainMenuButton.BackColor = Color.FromArgb(255, 140, 105);
        }

        private void StreamerButton_Click(object sender, EventArgs e)
        {
            NavigationPanel.Height = StreamerButton.Height;
            NavigationPanel.Top = StreamerButton.Top;
            StreamerButton.BackColor = Color.FromArgb(255, 140, 105);
            StreamerForm openForm = new StreamerForm();
            openForm.Show();
        }

        private void AnalysisButton_Click(object sender, EventArgs e)
        {
            NavigationPanel.Height = AnalysisButton.Height;
            NavigationPanel.Top = AnalysisButton.Top;
            AnalysisButton.BackColor = Color.FromArgb(255, 140, 105);
            AnalyserForm openForm = new AnalyserForm();
            openForm.Show();
        }

        private void DatabaseButton_Click(object sender, EventArgs e)
        {
            NavigationPanel.Height = DatabaseButton.Height;
            NavigationPanel.Top = DatabaseButton.Top;
            DatabaseButton.BackColor = Color.FromArgb(255, 140, 105);
        }

        private void MainMenuButton_Leave(object sender, EventArgs e)
        {
            MainMenuButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void StreamerButton_Leave(object sender, EventArgs e)
        {
            StreamerButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void AnalysisButton_Leave(object sender, EventArgs e)
        {
            AnalysisButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void DatabaseButton_Leave(object sender, EventArgs e)
        {
            DatabaseButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void DatabaseButton_Click_1(object sender, EventArgs e)
        {
            NavigationPanel.Height = DatabaseButton.Height;
            NavigationPanel.Top = DatabaseButton.Top;
            DatabaseButton.BackColor = Color.FromArgb(255, 140, 105);
            DatabaseForm openForm = new DatabaseForm();
            openForm.Show();
        }
    }
}
