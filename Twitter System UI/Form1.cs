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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NavigationPanel.Height = MainMenuButton.Height;
            NavigationPanel.Top = MainMenuButton.Top;
            NavigationPanel.Left = MainMenuButton.Left;
            MainMenuButton.BackColor = Color.FromArgb(255, 140, 105);
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
        }

        private void DatabaseButton_Click(object sender, EventArgs e)
        {
            NavigationPanel.Height = DatabaseButton.Height;
            NavigationPanel.Top = DatabaseButton.Top;
            DatabaseButton.BackColor = Color.FromArgb(255, 140, 105);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            NavigationPanel.Height = SettingsButton.Height;
            NavigationPanel.Top = SettingsButton.Top;
            SettingsButton.BackColor = Color.FromArgb(255, 140, 105);
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

        private void SettingsButton_Leave(object sender, EventArgs e)
        {
            SettingsButton.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
