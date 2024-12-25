using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Model;

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

        public FormInsert()
        {
            InitializeComponent();
        }

        private void FormInsert_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _record = new tRecord
            {
                Person = fName.Text,
                MaterialRequestNumber = fMaterialRequestNumber.Text,
                RepairRequestNumber = fRepairRequestNumber.Text,
                Device = fDevice.Text,
                Remarks = fRemarks.Text,
                Timestamp = fDate.Value.Date + fTime.Value.TimeOfDay
            };

            _result = DialogResult.OK;
            this.Close();
        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
