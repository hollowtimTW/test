using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test.Repository;

namespace test.View
{
    public partial class FormSetting : Form
    {
        DatabaseHelper _dbHelper;

        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            _dbHelper = new DatabaseHelper("MyDatabase.db");

            listName.Items.AddRange(_dbHelper.GetAllPersons().ToArray());
            listDevice.Items.AddRange(_dbHelper.GetAllDevices().ToArray());
        }

        private void UpdateListName()
        {
            Global.PersonList = _dbHelper.GetAllPersons();
            listName.Items.Clear();
            listName.Items.AddRange(Global.PersonList.ToArray());
        }

        private void UpdateListDevice()
        {
            Global.DeviceList = _dbHelper.GetAllDevices();
            listDevice.Items.Clear();
            listDevice.Items.AddRange(Global.DeviceList.ToArray());
        }

        private void btnNameAdd_Click(object sender, EventArgs e)
        {
            var name = fName.Text.Trim();
            fName.Text = "";

            if (String.IsNullOrEmpty(name))
                return;

            if (_dbHelper.GetPerson(name) != null)
            {
                MessageBox.Show("Name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _dbHelper.InsertPerson(name);
            UpdateListName();
        }
        private void btnNameDel_Click(object sender, EventArgs e)
        {
            if (listName.SelectedItem == null)
                return;

            var name = listName.SelectedItem.ToString();

            _dbHelper.DeletePerson(name);
            UpdateListName();
        }

        private void btnDeviceAdd_Click(object sender, EventArgs e)
        {
            var device = fDevice.Text.Trim();
            fDevice.Text = "";

            if (String.IsNullOrEmpty(device))
                return;

            if (_dbHelper.GetDevice(device) != null)
            {
                MessageBox.Show("Device already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _dbHelper.InsertDevice(device);
            UpdateListDevice();
        }

        private void btnDeviceDel_Click(object sender, EventArgs e)
        {
            if (listDevice.SelectedItem == null)
                return;

            var device = listDevice.SelectedItem.ToString();

            _dbHelper.DeleteDevice(device);
            UpdateListDevice();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
