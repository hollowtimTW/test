using System.Windows.Forms;
using test.Repository;
using test.View;
using System.Drawing;
using System.Text;
using test.Model;

namespace test
{
    public partial class FormMain : Form
    {
        DatabaseHelper _dbHelper;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _dbHelper = new DatabaseHelper("MyDatabase.db");

            Global.PersonList = _dbHelper.GetAllPersons();
            Global.DeviceList = _dbHelper.GetAllDevices();

            UpdateView();

            DataGridViewButtonColumn btnCell = new DataGridViewButtonColumn();
            btnCell.HeaderText = "�ԲӸ�T";
            btnCell.Name = "�ԲӸ�T";
            btnCell.Text = "�d��";
            btnCell.UseColumnTextForButtonValue = true;
            btnCell.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            btnCell.DefaultCellStyle.BackColor = Color.LightGray;
            btnCell.DefaultCellStyle.Font = new Font("Microsoft JhengHei UI", 13.8f, FontStyle.Bold);
            dataView.Columns.Add(btnCell);
            dataView.CellClick += new DataGridViewCellEventHandler(btnCell_Click);

            dataView.Columns["RecordId"].Visible = false;
            dataView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dataView.EnableHeadersVisualStyles = false;

            dataView.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dataView_RowPrePaint);
        }

        private void btnCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataView.Columns[e.ColumnIndex].Name == "�ԲӸ�T")
            {
                DataGridViewRow row = dataView.Rows[e.RowIndex];
                if (row.Cells["RecordId"].Value is int id)
                {
                    var model = _dbHelper.GetRecord(id);
                    var form = new FormInsert(model);
                    form.ShowDialog();

                    if (form.Result != DialogResult.Cancel)
                    {
                        _dbHelper.DeleteRecord(form.Record.RecordId);
                        UpdateView();
                    }
                }
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            var form = new FormInsert();
            form.ShowDialog();

            if (form.Result == DialogResult.Cancel)
                return;

            _dbHelper.InsertRecord(form.Record);
            UpdateView();
        }

        private void UpdateView()
        {

            Global.DataList = _dbHelper.GetAllRecords();
            dataView.DataSource = Global.DataList;
        }

        private void dataView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataView.Rows)
            {
                row.Selected = false;
            }
        }

        private void btnToCSV_Click(object sender, EventArgs e)
        {
            var data = Global.DataList;

            if (data.Count == 0)
            {
                MessageBox.Show("�L��ơI", "���~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Records");

                worksheet.Cell(1, 1).Value = "�ɶ�";
                worksheet.Cell(1, 2).Value = "�m�W";
                worksheet.Cell(1, 3).Value = "��Ƴ渹";
                worksheet.Cell(1, 4).Value = "���׳渹";
                worksheet.Cell(1, 5).Value = "��γ]��";
                worksheet.Cell(1, 6).Value = "�Ƶ�";

                for (int i = 0; i < data.Count; i++)
                {
                    var record = data[i];
                    worksheet.Cell(i + 2, 1).Value = record.Timestamp;
                    worksheet.Cell(i + 2, 2).Value = record.Person;
                    worksheet.Cell(i + 2, 3).Value = record.MaterialRequestNumber;
                    worksheet.Cell(i + 2, 4).Value = record.RepairRequestNumber;
                    worksheet.Cell(i + 2, 5).Value = record.Device;
                    worksheet.Cell(i + 2, 6).Value = record.Remarks;
                }

                string xlsxFilePath = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";
                workbook.SaveAs(xlsxFilePath);
            }

            var result = MessageBox.Show("��Ƥw�ץX�A�O�_�M������", "�x�s���\", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _dbHelper.DeleteAllRecords();
                UpdateView();
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            var form = new FormSetting();
            form.ShowDialog();
        }

        private void dataView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 1)
            {
                dataView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.AntiqueWhite;
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

            string searchText = textSearch.Text.ToLower();

            var filteredData = Global.DataList 
                .Where(p => 
                    p.Timestamp.Contains(searchText) ||
                    p.Person.Contains(searchText) ||
                    p.MaterialRequestNumber.Contains(searchText) ||
                    p.RepairRequestNumber.Contains(searchText) ||
                    p.Device.Contains(searchText) 
                    )
                .ToList();

            dataView.DataSource = filteredData;
        }
    }
}
