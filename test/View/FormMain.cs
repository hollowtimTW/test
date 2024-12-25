using test.Repository;
using test.View;

namespace test
{
    public partial class FormMain : Form
    {
        DatabaseHelper _dbHelper;
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dbHelper = new DatabaseHelper("MyDatabase.db");
            dataGridView1.DataSource = _dbHelper.GetAllRecords();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var form = new FormInsert();
            form.ShowDialog();
            
            if (form.Result == DialogResult.OK)
            {
                MessageBox.Show(form.Record.Person);
            }


        }
    }
}
