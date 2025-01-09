using System;
using System.Linq;
using System.Windows.Forms;
using test.Models;
using test.Repository;

namespace test.View
{
    public partial class FormSetting : Form
    {
        private readonly JsonHelper _json;

        public FormSetting()
        {
            InitializeComponent();
            _json = new JsonHelper();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void LoadItems()
        {
            listName.Items.Clear();
            listDevice.Items.Clear();
            listName.Items.AddRange(Global.PersonList.ToArray());
            listDevice.Items.AddRange(Global.DeviceList.ToArray());
        }

        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is ListBox listBox && listBox.SelectedItem != null)
            {
                listBox.DoDragDrop(listBox.SelectedItem, DragDropEffects.Move);
            }
        }

        private void ListBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void ListBox_DragDrop(object sender, DragEventArgs e)
        {
            if (sender is ListBox listBox)
            {
                var point = listBox.PointToClient(new System.Drawing.Point(e.X, e.Y));
                int index = listBox.IndexFromPoint(point);
                if (index < 0) index = listBox.Items.Count - 1;

                var data = e.Data.GetData(typeof(string));
                int oldIndex = listBox.Items.IndexOf(data);

                listBox.Items.RemoveAt(oldIndex);
                listBox.Items.Insert(index, data);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SaveData();
            Close();
        }

        private void SaveData()
        {
            Global.PersonList = listName.Items.Cast<string>().ToList();
            Global.DeviceList = listDevice.Items.Cast<string>().ToList();

            var data = new JsonData
            {
                Names = Global.PersonList,
                Devices = Global.DeviceList
            };
            _json.SaveData(data);
        }

        private void btnNameAdd_Click(object sender, EventArgs e)
        {
            var text = fName.Text.Trim();

            if (string.IsNullOrEmpty(text)) return;

            if (listName.Items.Contains(text))
            {
                MessageBox.Show("已有相同名稱");
                return;
            }

            fName.Text = string.Empty;
            listName.Items.Add(text);
        }

        private void btnNameDel_Click(object sender, EventArgs e)
        {
            if (listName.SelectedItem != null)
            {
                listName.Items.Remove(listName.SelectedItem);
            }
        }

        private void btnDeviceAdd_Click(object sender, EventArgs e)
        {
            var text = fDevice.Text.Trim();

            if (string.IsNullOrEmpty(text)) return;

            if (listDevice.Items.Contains(text))
            {
                MessageBox.Show("已有相同名稱");
                return;
            }

            fDevice.Text = string.Empty;
            listDevice.Items.Add(text);
        }

        private void btnDeviceDel_Click(object sender, EventArgs e)
        {
            if (listDevice.SelectedItem != null)
            {
                listDevice.Items.Remove(listDevice.SelectedItem);
            }
        }
    }
}
