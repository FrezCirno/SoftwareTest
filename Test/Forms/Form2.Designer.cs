
namespace ProgramTest.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pieChart = new Sunny.UI.UIPieChart();
            this.TestName = new Sunny.UI.UIComboBox();
            this.testVersion = new Sunny.UI.UIComboBox();
            this.StartButton = new Sunny.UI.UIButton();
            this.testMethod = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.ResetButton = new Sunny.UI.UIButton();
            this.dataGridView = new Sunny.UI.UIDataGridView();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.PagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PagePanel
            // 
            this.PagePanel.Controls.Add(this.uiLabel5);
            this.PagePanel.Controls.Add(this.uiLabel4);
            this.PagePanel.Controls.Add(this.dataGridView);
            this.PagePanel.Controls.Add(this.uiLabel3);
            this.PagePanel.Controls.Add(this.uiLabel2);
            this.PagePanel.Controls.Add(this.uiLabel1);
            this.PagePanel.Controls.Add(this.TestName);
            this.PagePanel.Controls.Add(this.testVersion);
            this.PagePanel.Controls.Add(this.ResetButton);
            this.PagePanel.Controls.Add(this.StartButton);
            this.PagePanel.Controls.Add(this.testMethod);
            this.PagePanel.Controls.Add(this.pieChart);
            this.PagePanel.Size = new System.Drawing.Size(825, 720);
            // 
            // pieChart
            // 
            this.pieChart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pieChart.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pieChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.pieChart.Location = new System.Drawing.Point(12, 47);
            this.pieChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(400, 261);
            this.pieChart.TabIndex = 6;
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
            // testVersion
            // 
            this.testVersion.FillColor = System.Drawing.Color.White;
            this.testVersion.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.testVersion.FormattingEnabled = true;
            this.testVersion.Location = new System.Drawing.Point(586, 98);
            this.testVersion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testVersion.MinimumSize = new System.Drawing.Size(63, 0);
            this.testVersion.Name = "testVersion";
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
            // testMethod
            // 
            this.testMethod.FillColor = System.Drawing.Color.White;
            this.testMethod.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.testMethod.FormattingEnabled = true;
            this.testMethod.Location = new System.Drawing.Point(586, 151);
            this.testMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testMethod.MinimumSize = new System.Drawing.Size(63, 0);
            this.testMethod.Name = "testMethod";
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
            // ResetButton
            // 
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ResetButton.Location = new System.Drawing.Point(623, 220);
            this.ResetButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(118, 30);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "重置";
            this.ResetButton.Click += new System.EventHandler(this.On_resetButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dataGridView.Location = new System.Drawing.Point(12, 352);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.SelectedIndex = -1;
            this.dataGridView.ShowGridLine = true;
            this.dataGridView.Size = new System.Drawing.Size(801, 356);
            this.dataGridView.TabIndex = 12;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel4.Location = new System.Drawing.Point(12, 315);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(801, 34);
            this.uiLabel4.TabIndex = 13;
            this.uiLabel4.Text = "测试数据：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(12, 3);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(400, 41);
            this.uiLabel5.TabIndex = 13;
            this.uiLabel5.Text = "测试数据：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 755);
            this.Name = "Form2";
            this.ShowTitle = false;
            this.Text = "Form2";
            this.PagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPieChart pieChart;
        private Sunny.UI.UIComboBox TestName;
        private Sunny.UI.UIComboBox testVersion;
        private Sunny.UI.UIButton StartButton;
        private Sunny.UI.UIComboBox testMethod;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton ResetButton;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIDataGridView dataGridView;
        private Sunny.UI.UILabel uiLabel5;
    }
}