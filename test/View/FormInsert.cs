using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using test.Model;
using test.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test.View
{
    public partial class FormInsert : Form
    {
        private DialogResult _result = DialogResult.Cancel;
        public DialogResult Result
        {
            get { return _result; }
        }
        private tRecord _record;
        public tRecord Record
        {
            get { return _record; }
        }


        public FormInsert(tRecord record = null)
        {
            InitializeComponent();
            _record = record;
        }

        private void FormInsert_Load(object sender, EventArgs e)
        {
            if (_record == null)
            {
                btnDel.Visible = false;

                fName.Items.AddRange(Global.PersonList.ToArray());
                fDevice.Items.AddRange(Global.DeviceList.ToArray());

                fRepairRequestNumber.Text = $"L{DateTime.Now.Year}";
            }
            else
            {
                btnOk.Visible = false;

                fNamee.Visible = true;
                fMaterialRequestNumber.ReadOnly = true;
                fRepairRequestNumber.ReadOnly = true;
                fDevicee.Visible = true;
                fRemarks.ReadOnly = true;
                fDatetime.Visible = true;

                fNamee.Text = _record.Person;
                fMaterialRequestNumber.Text = _record.MaterialRequestNumber;
                fRepairRequestNumber.Text = _record.RepairRequestNumber;
                fDevicee.Text = _record.Device;
                fRemarks.Text = _record.Remarks;
                fDatetime.Text = _record.Timestamp.ToString();
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(fName.Text))
            {
                MessageBox.Show("請選擇姓名！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(fMaterialRequestNumber.Text))
            {
                MessageBox.Show("請輸入領料單號！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (fMaterialRequestNumber.Text.Length != 6)
            {
                MessageBox.Show("領料單號須為6碼！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(fRepairRequestNumber.Text))
            {
                MessageBox.Show("請輸入報修單號！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (fRepairRequestNumber.Text.Length != 10)
            {
                MessageBox.Show("報修單號須為10碼！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(fDevice.Text))
            {
                MessageBox.Show("請選擇領用設備！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            if (Global.DataList.Where(p => p.MaterialRequestNumber == fMaterialRequestNumber.Text).Any())
            {
                MessageBox.Show("領料單號已存在！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Global.DataList.Where(p => p.RepairRequestNumber == fRepairRequestNumber.Text).Any())
            {
                MessageBox.Show("報修單號已存在！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _record = new tRecord
            {
                Person = fName.Text,
                MaterialRequestNumber = fMaterialRequestNumber.Text,
                RepairRequestNumber = fRepairRequestNumber.Text,
                Device = fDevice.Text,
                Remarks = fRemarks.Text,
                Timestamp = fDate.Text + fTime.Text
            };

            _result = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("是否取消提交紀錄?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            _result = DialogResult.Yes;
            this.Close();
        }

        private void fMaterialRequestNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fRepairRequestNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fRepairRequestNumber_TextChanged(object sender, EventArgs e)
        {
            fRepairRequestNumber.Text = fRepairRequestNumber.Text.ToUpper();
            fRepairRequestNumber.SelectionStart = fRepairRequestNumber.Text.Length;
        }
    }
}

