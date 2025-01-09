using System.Windows.Forms;
using test.Repository;
using test.View;
using System.Drawing;
using System.Text;
using test.Models;

namespace test
{
    public partial class FormMain : Form
    {
        DbHelper _dbHelper;
        JsonHelper _json;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _dbHelper = new DbHelper();
            _json = new JsonHelper();

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
            dataView.Columns["Stock"].Visible = false;
            dataView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dataView.EnableHeadersVisualStyles = false;

            dataView.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dataView_RowPrePaint);
        }

        private void btnCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataView.Columns[e.ColumnIndex].Name == "詳細資訊")
            {
                DataGridViewRow row = dataView.Rows[e.RowIndex];
                if (row.Cells["RecordId"].Value is long id)
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
                MessageBox.Show("無資料！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Records");

                worksheet.Cell(1, 1).Value = "時間";
                worksheet.Cell(1, 2).Value = "姓名";
                worksheet.Cell(1, 3).Value = "領料單號";
                worksheet.Cell(1, 4).Value = "報修單號";
                worksheet.Cell(1, 5).Value = "領用設備";
                worksheet.Cell(1, 6).Value = "備註";

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

            var result = MessageBox.Show("資料已匯出，是否清除紀錄", "儲存成功", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                dataView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
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

        private void btnQSearch_Click(object sender, EventArgs e)
        {
            textSearch.Text = "庫存不足";
        }
    }
}
