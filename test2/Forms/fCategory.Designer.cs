namespace test2.Forms
{
    partial class fCategory
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
            listCategory = new ListBox();
            listChildCategory = new ListBox();
            btnAdd1 = new Button();
            btnEdit1 = new Button();
            btnDel1 = new Button();
            btnAdd2 = new Button();
            btnEdit2 = new Button();
            btnDel2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listCategory
            // 
            listCategory.BackColor = Color.LightGray;
            listCategory.Font = new Font("新細明體", 12F, FontStyle.Bold);
            listCategory.FormattingEnabled = true;
            listCategory.Location = new Point(50, 68);
            listCategory.Name = "listCategory";
            listCategory.Size = new Size(199, 364);
            listCategory.TabIndex = 0;
            listCategory.SelectedIndexChanged += listCategory_SelectedIndexChanged;
            // 
            // listChildCategory
            // 
            listChildCategory.BackColor = Color.LightGray;
            listChildCategory.Font = new Font("新細明體", 12F, FontStyle.Bold);
            listChildCategory.FormattingEnabled = true;
            listChildCategory.Location = new Point(306, 68);
            listChildCategory.Name = "listChildCategory";
            listChildCategory.Size = new Size(210, 364);
            listChildCategory.TabIndex = 0;
            listChildCategory.SelectedIndexChanged += listChildCategory_SelectedIndexChanged;
            // 
            // btnAdd1
            // 
            btnAdd1.Font = new Font("新細明體", 12F, FontStyle.Bold);
            btnAdd1.Location = new Point(50, 438);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.Size = new Size(100, 30);
            btnAdd1.TabIndex = 1;
            btnAdd1.Text = "新增";
            btnAdd1.UseVisualStyleBackColor = true;
            btnAdd1.Click += btnAdd1_Click;
            // 
            // btnEdit1
            // 
            btnEdit1.Font = new Font("新細明體", 12F, FontStyle.Bold);
            btnEdit1.Location = new Point(50, 473);
            btnEdit1.Name = "btnEdit1";
            btnEdit1.Size = new Size(100, 30);
            btnEdit1.TabIndex = 1;
            btnEdit1.Text = "編輯";
            btnEdit1.UseVisualStyleBackColor = true;
            btnEdit1.Click += btnEdit1_Click;
            // 
            // btnDel1
            // 
            btnDel1.Font = new Font("新細明體", 12F, FontStyle.Bold);
            btnDel1.Location = new Point(50, 508);
            btnDel1.Name = "btnDel1";
            btnDel1.Size = new Size(100, 30);
            btnDel1.TabIndex = 1;
            btnDel1.Text = "刪除";
            btnDel1.UseVisualStyleBackColor = true;
            btnDel1.Click += btnDel1_Click;
            // 
            // btnAdd2
            // 
            btnAdd2.Font = new Font("新細明體", 12F, FontStyle.Bold);
            btnAdd2.Location = new Point(306, 438);
            btnAdd2.Name = "btnAdd2";
            btnAdd2.Size = new Size(100, 30);
            btnAdd2.TabIndex = 1;
            btnAdd2.Text = "新增";
            btnAdd2.UseVisualStyleBackColor = true;
            btnAdd2.Click += btnAdd2_Click;
            // 
            // btnEdit2
            // 
            btnEdit2.Font = new Font("新細明體", 12F, FontStyle.Bold);
            btnEdit2.Location = new Point(306, 473);
            btnEdit2.Name = "btnEdit2";
            btnEdit2.Size = new Size(100, 30);
            btnEdit2.TabIndex = 1;
            btnEdit2.Text = "編輯";
            btnEdit2.UseVisualStyleBackColor = true;
            btnEdit2.Click += btnEdit2_Click;
            // 
            // btnDel2
            // 
            btnDel2.Font = new Font("新細明體", 12F, FontStyle.Bold);
            btnDel2.Location = new Point(306, 508);
            btnDel2.Name = "btnDel2";
            btnDel2.Size = new Size(100, 30);
            btnDel2.TabIndex = 1;
            btnDel2.Text = "刪除";
            btnDel2.UseVisualStyleBackColor = true;
            btnDel2.Click += btnDel2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("新細明體", 12F, FontStyle.Bold);
            label1.Location = new Point(50, 35);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 2;
            label1.Text = "分類";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("新細明體", 12F, FontStyle.Bold);
            label2.Location = new Point(306, 35);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "子分類";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fCategory
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 583);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDel2);
            Controls.Add(btnDel1);
            Controls.Add(btnEdit2);
            Controls.Add(btnEdit1);
            Controls.Add(btnAdd2);
            Controls.Add(btnAdd1);
            Controls.Add(listChildCategory);
            Controls.Add(listCategory);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "fCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fCategory";
            Load += fCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listCategory;
        private ListBox listChildCategory;
        private Button btnAdd1;
        private Button btnEdit1;
        private Button btnDel1;
        private Button btnAdd2;
        private Button btnEdit2;
        private Button btnDel2;
        private Label label1;
        private Label label2;
    }
}