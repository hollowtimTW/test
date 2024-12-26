namespace test
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataView = new DataGridView();
            btnInsert = new Button();
            btnSetting = new Button();
            btnToCSV = new Button();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            SuspendLayout();
            // 
            // dataView
            // 
            dataView.AllowUserToAddRows = false;
            dataView.AllowUserToDeleteRows = false;
            dataView.AllowUserToResizeColumns = false;
            dataView.AllowUserToResizeRows = false;
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataView.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 136);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataView.DefaultCellStyle = dataGridViewCellStyle4;
            dataView.Location = new Point(10, 138);
            dataView.MultiSelect = false;
            dataView.Name = "dataView";
            dataView.ReadOnly = true;
            dataView.RowHeadersVisible = false;
            dataView.RowHeadersWidth = 51;
            dataView.RowTemplate.Height = 42;
            dataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataView.Size = new Size(1562, 605);
            dataView.TabIndex = 0;
            dataView.RowPrePaint += dataView_RowPrePaint;
            dataView.SelectionChanged += dataView_SelectionChanged;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Lime;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Bold);
            btnInsert.Location = new Point(12, 12);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(1398, 120);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "領用";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.FromArgb(224, 224, 224);
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            btnSetting.Location = new Point(1497, 12);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(75, 40);
            btnSetting.TabIndex = 1;
            btnSetting.Text = "設定";
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnToCSV
            // 
            btnToCSV.BackColor = Color.FromArgb(224, 224, 224);
            btnToCSV.FlatStyle = FlatStyle.Flat;
            btnToCSV.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnToCSV.Location = new Point(1416, 12);
            btnToCSV.Name = "btnToCSV";
            btnToCSV.Size = new Size(75, 40);
            btnToCSV.TabIndex = 1;
            btnToCSV.Text = "匯出";
            btnToCSV.UseVisualStyleBackColor = false;
            btnToCSV.Click += btnToCSV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1582, 753);
            Controls.Add(btnToCSV);
            Controls.Add(btnSetting);
            Controls.Add(btnInsert);
            Controls.Add(dataView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "領料登記系統";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataView;
        private Button btnInsert;
        private Button btnSetting;
        private Button btnToCSV;
    }
}
