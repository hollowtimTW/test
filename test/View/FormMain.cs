using System.Windows.Forms;
using test.Repository;
using test.View;
using System.Drawing;
using System.Text;

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
            btnCell.HeaderText = "詳細資訊";
            btnCell.Name = "詳細資訊";
            btnCell.Text = "查看";
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
            if (e.RowIndex >= 0 && dataView.Columns[e.ColumnIndex].Name == "詳細資訊")
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
            dataView.DataSource = _dbHelper.GetAllRecords();
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
            var data = _dbHelper.GetAllRecords();

            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("時間,姓名,領料單號,報修單號,領用設備,備註");

            foreach (var record in data)
            {
                csvContent.AppendLine($"{record.Timestamp},{record.Person},{record.MaterialRequestNumber},{record.RepairRequestNumber},{record.Device},{record.Remarks}");
            }

            string csvFilePath = "records.csv";
            File.WriteAllText(csvFilePath, csvContent.ToString(), Encoding.UTF8);

            MessageBox.Show("資料已儲存", "儲存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dataView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
            }
        }
    }
}
