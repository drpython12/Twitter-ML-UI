
namespace Twitter_System_UI
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.DatabaseButton = new System.Windows.Forms.Button();
            this.AnalysisButton = new System.Windows.Forms.Button();
            this.StreamerButton = new System.Windows.Forms.Button();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HomeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.analyserFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyserFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.NavigationPanel);
            this.panel1.Controls.Add(this.DatabaseButton);
            this.panel1.Controls.Add(this.AnalysisButton);
            this.panel1.Controls.Add(this.StreamerButton);
            this.panel1.Controls.Add(this.MainMenuButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 559);
            this.panel1.TabIndex = 0;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.Brown;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 164);
            this.NavigationPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(3, 85);
            this.NavigationPanel.TabIndex = 3;
            // 
            // DatabaseButton
            // 
            this.DatabaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DatabaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DatabaseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DatabaseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatabaseButton.FlatAppearance.BorderSize = 0;
            this.DatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatabaseButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseButton.ForeColor = System.Drawing.Color.White;
            this.DatabaseButton.Image = global::Twitter_System_UI.Properties.Resources.database_free_download_png_5a22aad4e16b56_2847272415122213969233;
            this.DatabaseButton.Location = new System.Drawing.Point(0, 276);
            this.DatabaseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatabaseButton.Name = "DatabaseButton";
            this.DatabaseButton.Size = new System.Drawing.Size(165, 48);
            this.DatabaseButton.TabIndex = 1;
            this.DatabaseButton.Text = "Database";
            this.DatabaseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DatabaseButton.UseVisualStyleBackColor = false;
            this.DatabaseButton.Click += new System.EventHandler(this.DatabaseButton_Click_1);
            this.DatabaseButton.Leave += new System.EventHandler(this.DatabaseButton_Leave);
            // 
            // AnalysisButton
            // 
            this.AnalysisButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.AnalysisButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AnalysisButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AnalysisButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AnalysisButton.FlatAppearance.BorderSize = 0;
            this.AnalysisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnalysisButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalysisButton.ForeColor = System.Drawing.Color.White;
            this.AnalysisButton.Image = global::Twitter_System_UI.Properties.Resources.diagram;
            this.AnalysisButton.Location = new System.Drawing.Point(0, 228);
            this.AnalysisButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnalysisButton.Name = "AnalysisButton";
            this.AnalysisButton.Size = new System.Drawing.Size(165, 48);
            this.AnalysisButton.TabIndex = 1;
            this.AnalysisButton.Text = "Tweet Analysis";
            this.AnalysisButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AnalysisButton.UseVisualStyleBackColor = false;
            this.AnalysisButton.Click += new System.EventHandler(this.AnalysisButton_Click);
            this.AnalysisButton.Leave += new System.EventHandler(this.AnalysisButton_Leave);
            // 
            // StreamerButton
            // 
            this.StreamerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.StreamerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StreamerButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.StreamerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StreamerButton.FlatAppearance.BorderSize = 0;
            this.StreamerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StreamerButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreamerButton.ForeColor = System.Drawing.Color.White;
            this.StreamerButton.Image = global::Twitter_System_UI.Properties.Resources.calendar;
            this.StreamerButton.Location = new System.Drawing.Point(0, 180);
            this.StreamerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StreamerButton.Name = "StreamerButton";
            this.StreamerButton.Size = new System.Drawing.Size(165, 48);
            this.StreamerButton.TabIndex = 1;
            this.StreamerButton.Text = "Streamer";
            this.StreamerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.StreamerButton.UseVisualStyleBackColor = false;
            this.StreamerButton.Click += new System.EventHandler(this.StreamerButton_Click);
            this.StreamerButton.Leave += new System.EventHandler(this.StreamerButton_Leave);
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.MainMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainMenuButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainMenuButton.FlatAppearance.BorderSize = 0;
            this.MainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuButton.ForeColor = System.Drawing.Color.White;
            this.MainMenuButton.Image = global::Twitter_System_UI.Properties.Resources.home;
            this.MainMenuButton.Location = new System.Drawing.Point(0, 132);
            this.MainMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(165, 48);
            this.MainMenuButton.TabIndex = 1;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            this.MainMenuButton.Leave += new System.EventHandler(this.MainMenuButton_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 132);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time Logged In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Twitter_System_UI.Properties.Resources.twitter_logo;
            this.pictureBox1.Location = new System.Drawing.Point(53, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(105)))));
            this.label3.Location = new System.Drawing.Point(179, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Main Menu";
            // 
            // HomeChart
            // 
            this.HomeChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            chartArea1.Name = "ChartArea1";
            this.HomeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.HomeChart.Legends.Add(legend1);
            this.HomeChart.Location = new System.Drawing.Point(248, 123);
            this.HomeChart.Name = "HomeChart";
            this.HomeChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "FK Scores";
            this.HomeChart.Series.Add(series1);
            this.HomeChart.Size = new System.Drawing.Size(470, 382);
            this.HomeChart.TabIndex = 4;
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            this.HomeChart.Titles.Add(title1);
            // 
            // analyserFormBindingSource
            // 
            this.analyserFormBindingSource.DataSource = typeof(Twitter_System_UI.AnalyserForm);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(846, 559);
            this.Controls.Add(this.HomeChart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeForm";
            this.Text = "Home Page";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyserFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DatabaseButton;
        private System.Windows.Forms.Button AnalysisButton;
        private System.Windows.Forms.Button StreamerButton;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart HomeChart;
        private System.Windows.Forms.BindingSource analyserFormBindingSource;
    }
}

