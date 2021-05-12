
namespace Twitter_System_UI
{
    partial class StreamerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelNumOfTweets = new System.Windows.Forms.Label();
            this.BoxNumOfTweets = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.KeywordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelNumOfTweets
            // 
            this.LabelNumOfTweets.AutoSize = true;
            this.LabelNumOfTweets.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumOfTweets.Location = new System.Drawing.Point(61, 102);
            this.LabelNumOfTweets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNumOfTweets.Name = "LabelNumOfTweets";
            this.LabelNumOfTweets.Size = new System.Drawing.Size(252, 22);
            this.LabelNumOfTweets.TabIndex = 0;
            this.LabelNumOfTweets.Text = "Number of tweets to stream: ";
            // 
            // BoxNumOfTweets
            // 
            this.BoxNumOfTweets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.BoxNumOfTweets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxNumOfTweets.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNumOfTweets.ForeColor = System.Drawing.Color.White;
            this.BoxNumOfTweets.Location = new System.Drawing.Point(465, 95);
            this.BoxNumOfTweets.Margin = new System.Windows.Forms.Padding(4);
            this.BoxNumOfTweets.Name = "BoxNumOfTweets";
            this.BoxNumOfTweets.Size = new System.Drawing.Size(224, 29);
            this.BoxNumOfTweets.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "List of keywords to query tweets with:\r\n(comma separated)";
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.RunButton.ForeColor = System.Drawing.Color.White;
            this.RunButton.Location = new System.Drawing.Point(305, 468);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(105, 31);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(433, 468);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(105, 31);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // KeywordBox
            // 
            this.KeywordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.KeywordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeywordBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeywordBox.ForeColor = System.Drawing.Color.White;
            this.KeywordBox.Location = new System.Drawing.Point(465, 241);
            this.KeywordBox.Margin = new System.Windows.Forms.Padding(4);
            this.KeywordBox.Multiline = true;
            this.KeywordBox.Name = "KeywordBox";
            this.KeywordBox.Size = new System.Drawing.Size(224, 176);
            this.KeywordBox.TabIndex = 7;
            // 
            // StreamerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(875, 541);
            this.Controls.Add(this.KeywordBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxNumOfTweets);
            this.Controls.Add(this.LabelNumOfTweets);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StreamerForm";
            this.Text = "StreamerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNumOfTweets;
        private System.Windows.Forms.TextBox BoxNumOfTweets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox KeywordBox;
    }
}