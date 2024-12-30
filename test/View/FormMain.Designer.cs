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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataView = new DataGridView();
            btnInsert = new Button();
            btnSetting = new Button();
            btnToCSV = new Button();
            panel1 = new Panel();
            textSearch = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataView
            // 
            dataView.AllowUserToAddRows = false;
            dataView.AllowUserToDeleteRows = false;
            dataView.AllowUserToResizeColumns = false;
            dataView.AllowUserToResizeRows = false;
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataView.BackgroundColor = SystemColors.Control;
            dataView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 136);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataView.DefaultCellStyle = dataGridViewCellStyle2;
            dataView.Location = new Point(12, 138);
            dataView.MultiSelect = false;
            dataView.Name = "dataView";
            dataView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataView.RowHeadersVisible = false;
            dataView.RowHeadersWidth = 51;
            dataView.RowTemplate.Height = 50;
            dataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataView.Size = new Size(1562, 285);
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
            btnInsert.Size = new Size(1222, 120);
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
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(textSearch);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1240, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 54);
            panel1.TabIndex = 16;
            // 
            // textSearch
            // 
            textSearch.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textSearch.Location = new Point(76, 8);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(245, 37);
            textSearch.TabIndex = 16;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(60, 30);
            label2.TabIndex = 17;
            label2.Text = "搜尋";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1582, 438);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataView;
        private Button btnInsert;
        private Button btnSetting;
        private Button btnToCSV;
        private Panel panel1;
        private TextBox textSearch;
        private Label label2;
    }
}
