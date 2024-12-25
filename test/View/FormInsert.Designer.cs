namespace test.View
{
    partial class FormInsert
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            fName = new ComboBox();
            fMaterialRequestNumber = new TextBox();
            fRepairRequestNumber = new TextBox();
            fDevice = new ComboBox();
            fRemarks = new RichTextBox();
            fDate = new DateTimePicker();
            fTime = new DateTimePicker();
            btnOk = new Button();
            btnCannel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(43, 19);
            label1.Name = "label1";
            label1.Size = new Size(120, 30);
            label1.TabIndex = 0;
            label1.Text = "姓名";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(43, 67);
            label2.Name = "label2";
            label2.Size = new Size(120, 30);
            label2.TabIndex = 0;
            label2.Text = "領料單號";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(43, 115);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
            label3.TabIndex = 0;
            label3.Text = "報修單號";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(43, 163);
            label4.Name = "label4";
            label4.Size = new Size(120, 30);
            label4.TabIndex = 0;
            label4.Text = "領用設備";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(43, 211);
            label5.Name = "label5";
            label5.Size = new Size(120, 30);
            label5.TabIndex = 0;
            label5.Text = "備註";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(43, 490);
            label6.Name = "label6";
            label6.Size = new Size(120, 30);
            label6.TabIndex = 0;
            label6.Text = "時間";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fName
            // 
            fName.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fName.FormattingEnabled = true;
            fName.Location = new Point(188, 12);
            fName.Name = "fName";
            fName.Size = new Size(461, 37);
            fName.TabIndex = 1;
            // 
            // fMaterialRequestNumber
            // 
            fMaterialRequestNumber.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fMaterialRequestNumber.Location = new Point(188, 60);
            fMaterialRequestNumber.Name = "fMaterialRequestNumber";
            fMaterialRequestNumber.Size = new Size(461, 37);
            fMaterialRequestNumber.TabIndex = 2;
            // 
            // fRepairRequestNumber
            // 
            fRepairRequestNumber.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fRepairRequestNumber.Location = new Point(188, 108);
            fRepairRequestNumber.Name = "fRepairRequestNumber";
            fRepairRequestNumber.Size = new Size(461, 37);
            fRepairRequestNumber.TabIndex = 2;
            // 
            // fDevice
            // 
            fDevice.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fDevice.FormattingEnabled = true;
            fDevice.Location = new Point(188, 156);
            fDevice.Name = "fDevice";
            fDevice.Size = new Size(461, 37);
            fDevice.TabIndex = 3;
            // 
            // fRemarks
            // 
            fRemarks.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fRemarks.Location = new Point(188, 209);
            fRemarks.Name = "fRemarks";
            fRemarks.Size = new Size(461, 268);
            fRemarks.TabIndex = 4;
            fRemarks.Text = "";
            // 
            // fDate
            // 
            fDate.CustomFormat = "";
            fDate.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fDate.Location = new Point(188, 483);
            fDate.Name = "fDate";
            fDate.Size = new Size(260, 37);
            fDate.TabIndex = 5;
            // 
            // fTime
            // 
            fTime.CustomFormat = "";
            fTime.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fTime.Format = DateTimePickerFormat.Time;
            fTime.Location = new Point(454, 483);
            fTime.Name = "fTime";
            fTime.Size = new Size(195, 37);
            fTime.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            btnOk.Location = new Point(392, 551);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(120, 40);
            btnOk.TabIndex = 6;
            btnOk.Text = "確認";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCannel
            // 
            btnCannel.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            btnCannel.Location = new Point(529, 551);
            btnCannel.Name = "btnCannel";
            btnCannel.Size = new Size(120, 40);
            btnCannel.TabIndex = 6;
            btnCannel.Text = "取消";
            btnCannel.UseVisualStyleBackColor = true;
            btnCannel.Click += btnCannel_Click;
            // 
            // FormInsert
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 603);
            ControlBox = false;
            Controls.Add(btnCannel);
            Controls.Add(btnOk);
            Controls.Add(fTime);
            Controls.Add(fDate);
            Controls.Add(fRemarks);
            Controls.Add(fDevice);
            Controls.Add(fRepairRequestNumber);
            Controls.Add(fMaterialRequestNumber);
            Controls.Add(fName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormInsert";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "領用";
            Load += FormInsert_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox fName;
        private TextBox fMaterialRequestNumber;
        private TextBox fRepairRequestNumber;
        private ComboBox fDevice;
        private RichTextBox fRemarks;
        private DateTimePicker fDate;
        private DateTimePicker fTime;
        private Button btnOk;
        private Button btnCannel;
    }
}