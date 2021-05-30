
namespace ProgramTest.Tests
{
    partial class Form2
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
            this.chart1 = new Sunny.UI.UIPieChart();
            this.TestName = new Sunny.UI.UIComboBox();
            this.testVersion = new Sunny.UI.UIComboBox();
            this.StartButton = new Sunny.UI.UIButton();
            this.testMethod = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiLabel3);
            this.PagePanel.Controls.Add(this.uiLabel2);
            this.PagePanel.Controls.Add(this.uiLabel1);
            this.PagePanel.Controls.Add(this.TestName);
            this.PagePanel.Controls.Add(this.testVersion);
            this.PagePanel.Controls.Add(this.uiButton1);
            this.PagePanel.Controls.Add(this.StartButton);
            this.PagePanel.Controls.Add(this.testMethod);
            this.PagePanel.Controls.Add(this.chart1);
            this.PagePanel.Size = new System.Drawing.Size(800, 415);
            // 
            // chart1
            // 
            this.chart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.chart1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.chart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.chart1.Location = new System.Drawing.Point(12, 6);
            this.chart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(400, 302);
            this.chart1.TabIndex = 6;
            // 
            // TestName
            // 
            this.TestName.FillColor = System.Drawing.Color.White;
            this.TestName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.TestName.FormattingEnabled = true;
            this.TestName.Location = new System.Drawing.Point(586, 49);
            this.TestName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TestName.MinimumSize = new System.Drawing.Size(63, 0);
            this.TestName.Name = "TestName";
            this.TestName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.TestName.Size = new System.Drawing.Size(155, 34);
            this.TestName.TabIndex = 7;
            this.TestName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TestVersion
            // 
            this.testVersion.FillColor = System.Drawing.Color.White;
            this.testVersion.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.testVersion.FormattingEnabled = true;
            this.testVersion.Location = new System.Drawing.Point(586, 98);
            this.testVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testVersion.MinimumSize = new System.Drawing.Size(63, 0);
            this.testVersion.Name = "TestVersion";
            this.testVersion.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.testVersion.Size = new System.Drawing.Size(155, 34);
            this.testVersion.TabIndex = 10;
            this.testVersion.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.StartButton.Location = new System.Drawing.Point(467, 220);
            this.StartButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(118, 30);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "开始测试";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // TestMethod
            // 
            this.testMethod.FillColor = System.Drawing.Color.White;
            this.testMethod.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.testMethod.FormattingEnabled = true;
            this.testMethod.Location = new System.Drawing.Point(586, 151);
            this.testMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testMethod.MinimumSize = new System.Drawing.Size(63, 0);
            this.testMethod.Name = "TestMethod";
            this.testMethod.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.testMethod.Size = new System.Drawing.Size(155, 34);
            this.testMethod.TabIndex = 8;
            this.testMethod.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(462, 49);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(117, 34);
            this.uiLabel1.TabIndex = 11;
            this.uiLabel1.Text = "测试程序：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(462, 98);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(117, 34);
            this.uiLabel2.TabIndex = 11;
            this.uiLabel2.Text = "测试版本：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(462, 151);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(117, 34);
            this.uiLabel3.TabIndex = 11;
            this.uiLabel3.Text = "测试方法：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(623, 220);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(118, 30);
            this.uiButton1.TabIndex = 9;
            this.uiButton1.Text = "重置";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form2";
            this.Text = "Form2";
            this.PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPieChart chart1;
        private Sunny.UI.UIComboBox TestName;
        private Sunny.UI.UIComboBox testVersion;
        private Sunny.UI.UIButton StartButton;
        private Sunny.UI.UIComboBox testMethod;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton1;
    }
}