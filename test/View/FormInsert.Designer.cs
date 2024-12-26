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
            panel1 = new Panel();
            fDatetime = new TextBox();
            fDevicee = new TextBox();
            fNamee = new TextBox();
            btnClose = new Button();
            btnDel = new Button();
            btnOk = new Button();
            fTime = new DateTimePicker();
            fDate = new DateTimePicker();
            fRemarks = new RichTextBox();
            fDevice = new ComboBox();
            fRepairRequestNumber = new TextBox();
            fMaterialRequestNumber = new TextBox();
            fName = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(fDatetime);
            panel1.Controls.Add(fDevicee);
            panel1.Controls.Add(fNamee);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnDel);
            panel1.Controls.Add(btnOk);
            panel1.Controls.Add(fTime);
            panel1.Controls.Add(fDate);
            panel1.Controls.Add(fRemarks);
            panel1.Controls.Add(fDevice);
            panel1.Controls.Add(fRepairRequestNumber);
            panel1.Controls.Add(fMaterialRequestNumber);
            panel1.Controls.Add(fName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 590);
            panel1.TabIndex = 10;
            // 
            // fDatetime
            // 
            fDatetime.BackColor = Color.White;
            fDatetime.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fDatetime.Location = new Point(177, 489);
            fDatetime.Name = "fDatetime";
            fDatetime.ReadOnly = true;
            fDatetime.Size = new Size(461, 37);
            fDatetime.TabIndex = 27;
            fDatetime.Visible = false;
            // 
            // fDevicee
            // 
            fDevicee.BackColor = Color.White;
            fDevicee.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fDevicee.Location = new Point(177, 162);
            fDevicee.Name = "fDevicee";
            fDevicee.ReadOnly = true;
            fDevicee.Size = new Size(461, 37);
            fDevicee.TabIndex = 26;
            fDevicee.Visible = false;
            // 
            // fNamee
            // 
            fNamee.BackColor = Color.White;
            fNamee.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fNamee.Location = new Point(177, 18);
            fNamee.Name = "fNamee";
            fNamee.ReadOnly = true;
            fNamee.Size = new Size(461, 37);
            fNamee.TabIndex = 25;
            fNamee.Visible = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Silver;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            btnClose.Location = new Point(518, 538);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 40);
            btnClose.TabIndex = 24;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Silver;
            btnDel.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            btnDel.Location = new Point(32, 538);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(120, 40);
            btnDel.TabIndex = 23;
            btnDel.Text = "刪除紀錄";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Silver;
            btnOk.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            btnOk.Location = new Point(381, 538);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(120, 40);
            btnOk.TabIndex = 23;
            btnOk.Text = "確認";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // fTime
            // 
            fTime.CustomFormat = "";
            fTime.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fTime.Format = DateTimePickerFormat.Time;
            fTime.Location = new Point(443, 489);
            fTime.Name = "fTime";
            fTime.Size = new Size(195, 37);
            fTime.TabIndex = 22;
            // 
            // fDate
            // 
            fDate.CustomFormat = "";
            fDate.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fDate.Location = new Point(177, 489);
            fDate.Name = "fDate";
            fDate.Size = new Size(260, 37);
            fDate.TabIndex = 21;
            // 
            // fRemarks
            // 
            fRemarks.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fRemarks.Location = new Point(177, 215);
            fRemarks.Name = "fRemarks";
            fRemarks.Size = new Size(461, 268);
            fRemarks.TabIndex = 20;
            fRemarks.Text = "";
            // 
            // fDevice
            // 
            fDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            fDevice.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fDevice.FormattingEnabled = true;
            fDevice.Location = new Point(177, 162);
            fDevice.Name = "fDevice";
            fDevice.Size = new Size(461, 37);
            fDevice.TabIndex = 19;
            // 
            // fRepairRequestNumber
            // 
            fRepairRequestNumber.BackColor = Color.White;
            fRepairRequestNumber.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fRepairRequestNumber.Location = new Point(177, 114);
            fRepairRequestNumber.Name = "fRepairRequestNumber";
            fRepairRequestNumber.Size = new Size(461, 37);
            fRepairRequestNumber.TabIndex = 18;
            // 
            // fMaterialRequestNumber
            // 
            fMaterialRequestNumber.BackColor = Color.White;
            fMaterialRequestNumber.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fMaterialRequestNumber.Location = new Point(177, 66);
            fMaterialRequestNumber.Name = "fMaterialRequestNumber";
            fMaterialRequestNumber.Size = new Size(461, 37);
            fMaterialRequestNumber.TabIndex = 17;
            // 
            // fName
            // 
            fName.DropDownHeight = 300;
            fName.DropDownStyle = ComboBoxStyle.DropDownList;
            fName.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fName.FormattingEnabled = true;
            fName.IntegralHeight = false;
            fName.ItemHeight = 29;
            fName.Location = new Point(177, 18);
            fName.Name = "fName";
            fName.Size = new Size(461, 37);
            fName.TabIndex = 16;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(32, 496);
            label6.Name = "label6";
            label6.Size = new Size(120, 30);
            label6.TabIndex = 10;
            label6.Text = "時間";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(32, 217);
            label5.Name = "label5";
            label5.Size = new Size(120, 30);
            label5.TabIndex = 11;
            label5.Text = "備註";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(32, 169);
            label4.Name = "label4";
            label4.Size = new Size(120, 30);
            label4.TabIndex = 12;
            label4.Text = "領用設備";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(32, 121);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
            label3.TabIndex = 13;
            label3.Text = "報修單號";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(32, 73);
            label2.Name = "label2";
            label2.Size = new Size(120, 30);
            label2.TabIndex = 14;
            label2.Text = "領料單號";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(120, 30);
            label1.TabIndex = 15;
            label1.Text = "姓名";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormInsert
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(680, 600);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FormInsert";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "領用";
            Load += FormInsert_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Button btnOk;
        private DateTimePicker fTime;
        private DateTimePicker fDate;
        private RichTextBox fRemarks;
        private ComboBox fDevice;
        private TextBox fRepairRequestNumber;
        private TextBox fMaterialRequestNumber;
        private ComboBox fName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDel;
        private TextBox fDevicee;
        private TextBox fNamee;
        private TextBox fDatetime;
    }
}