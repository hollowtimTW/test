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
            dataGridView1 = new DataGridView();
            btnInsert = new Button();
            btnSetting = new Button();
            btnToCSV = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 263);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1582, 490);
            dataGridView1.TabIndex = 0;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(78, 51);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(120, 120);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "領用";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnSetting
            // 
            btnSetting.Location = new Point(330, 51);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(120, 120);
            btnSetting.TabIndex = 1;
            btnSetting.Text = "設定";
            btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnToCSV
            // 
            btnToCSV.Location = new Point(204, 51);
            btnToCSV.Name = "btnToCSV";
            btnToCSV.Size = new Size(120, 120);
            btnToCSV.TabIndex = 1;
            btnToCSV.Text = "匯出資料";
            btnToCSV.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 753);
            Controls.Add(btnToCSV);
            Controls.Add(btnSetting);
            Controls.Add(btnInsert);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnInsert;
        private Button btnSetting;
        private Button btnToCSV;
    }
}
