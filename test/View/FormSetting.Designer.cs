namespace test.View
{
    partial class FormSetting
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
            btnDeviceDel = new Button();
            btnNameDel = new Button();
            fDevice = new TextBox();
            btnDeviceAdd = new Button();
            btnNameAdd = new Button();
            fName = new TextBox();
            label4 = new Label();
            label1 = new Label();
            btnClose = new Button();
            listDevice = new ListBox();
            listName = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnDeviceDel);
            panel1.Controls.Add(btnNameDel);
            panel1.Controls.Add(fDevice);
            panel1.Controls.Add(btnDeviceAdd);
            panel1.Controls.Add(btnNameAdd);
            panel1.Controls.Add(fName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(listDevice);
            panel1.Controls.Add(listName);
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 680);
            panel1.TabIndex = 0;
            // 
            // btnDeviceDel
            // 
            btnDeviceDel.BackColor = Color.Red;
            btnDeviceDel.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnDeviceDel.FlatStyle = FlatStyle.Flat;
            btnDeviceDel.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold);
            btnDeviceDel.Location = new Point(487, 516);
            btnDeviceDel.Name = "btnDeviceDel";
            btnDeviceDel.Size = new Size(60, 30);
            btnDeviceDel.TabIndex = 35;
            btnDeviceDel.Text = "Del";
            btnDeviceDel.UseVisualStyleBackColor = false;
            btnDeviceDel.Click += btnDeviceDel_Click;
            // 
            // btnNameDel
            // 
            btnNameDel.BackColor = Color.Red;
            btnNameDel.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnNameDel.FlatStyle = FlatStyle.Flat;
            btnNameDel.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold);
            btnNameDel.Location = new Point(157, 516);
            btnNameDel.Name = "btnNameDel";
            btnNameDel.Size = new Size(60, 30);
            btnNameDel.TabIndex = 35;
            btnNameDel.Text = "Del";
            btnNameDel.UseVisualStyleBackColor = false;
            btnNameDel.Click += btnNameDel_Click;
            // 
            // fDevice
            // 
            fDevice.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fDevice.Location = new Point(289, 573);
            fDevice.Name = "fDevice";
            fDevice.Size = new Size(258, 37);
            fDevice.TabIndex = 33;
            // 
            // btnDeviceAdd
            // 
            btnDeviceAdd.BackColor = Color.Lime;
            btnDeviceAdd.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnDeviceAdd.FlatStyle = FlatStyle.Flat;
            btnDeviceAdd.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnDeviceAdd.Location = new Point(223, 575);
            btnDeviceAdd.Name = "btnDeviceAdd";
            btnDeviceAdd.Size = new Size(60, 30);
            btnDeviceAdd.TabIndex = 32;
            btnDeviceAdd.Text = "Add";
            btnDeviceAdd.UseVisualStyleBackColor = false;
            btnDeviceAdd.Click += btnDeviceAdd_Click;
            // 
            // btnNameAdd
            // 
            btnNameAdd.BackColor = Color.Lime;
            btnNameAdd.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnNameAdd.FlatStyle = FlatStyle.Flat;
            btnNameAdd.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnNameAdd.Location = new Point(15, 575);
            btnNameAdd.Name = "btnNameAdd";
            btnNameAdd.Size = new Size(60, 30);
            btnNameAdd.TabIndex = 32;
            btnNameAdd.Text = "Add";
            btnNameAdd.UseVisualStyleBackColor = false;
            btnNameAdd.Click += btnNameAdd_Click;
            // 
            // fName
            // 
            fName.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            fName.Location = new Point(81, 570);
            fName.Name = "fName";
            fName.Size = new Size(136, 37);
            fName.TabIndex = 31;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(223, 9);
            label4.Name = "label4";
            label4.Size = new Size(120, 30);
            label4.TabIndex = 29;
            label4.Text = "領用設備";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 30);
            label1.TabIndex = 30;
            label1.Text = "姓名";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Silver;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            btnClose.Location = new Point(427, 626);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 40);
            btnClose.TabIndex = 28;
            btnClose.Text = "關閉";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // listDevice
            // 
            listDevice.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            listDevice.FormattingEnabled = true;
            listDevice.ItemHeight = 29;
            listDevice.Location = new Point(223, 42);
            listDevice.Name = "listDevice";
            listDevice.Size = new Size(324, 468);
            listDevice.TabIndex = 26;
            // 
            // listName
            // 
            listName.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold);
            listName.FormattingEnabled = true;
            listName.ItemHeight = 29;
            listName.Location = new Point(15, 42);
            listName.Name = "listName";
            listName.Size = new Size(202, 468);
            listName.TabIndex = 27;
            // 
            // FormSetting
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(580, 700);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FormSetting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSetting";
            Load += FormSetting_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private ListBox listDevice;
        private ListBox listName;
        private Label label4;
        private Label label1;
        private TextBox fDevice;
        private Button btnNameAdd;
        private TextBox fName;
        private Button btnDeviceDel;
        private Button btnNameDel;
        private Button btnDeviceAdd;
    }
}