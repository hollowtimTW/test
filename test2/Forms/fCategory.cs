using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test2.Models;
using test2.Repositories;

namespace test2.Forms
{
    public partial class fCategory : Form
    {
        dbHelper _db;

        int selectedIndex1 = -1;
        int selectedIndex2 = -1;
        List<Category> _categoryList = null;
        List<ChildCategory> _childList = null;

        public fCategory()
        {
            InitializeComponent();
            _db = new dbHelper();

            btnAdd2.Enabled = false;
            btnEdit2.Enabled = false;
            btnDel2.Enabled = false;
        }

        private void fCategory_Load(object sender, EventArgs e)
        {
            listCategory.Items.Clear();
            _categoryList = _db.GetCategories();

            foreach (var category in _categoryList)
            {
                listCategory.Items.Add(category.CategoryName);
            }
        }



        private void btnAdd1_Click(object sender, EventArgs e)
        {
            listCategory.Items.Add("");
            listCategory.SelectedIndex = listCategory.Items.Count - 1;

            TextBox editBox = new TextBox
            {
                Text = listCategory.Items[selectedIndex1].ToString(),
                Bounds = listCategory.GetItemRectangle(selectedIndex1),
                Parent = listCategory
            };
            editBox.Focus();

            editBox.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.Enter)
                {
                    editBox.Parent.Focus();
                }
            };

            editBox.LostFocus += (s, ev) =>
            {
                InsertCategory(editBox);
            };
        }

        private void InsertCategory(TextBox editBox)
        {
            var text = editBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                editBox.Dispose();
                listCategory.Items.RemoveAt(selectedIndex1);
                return;
            }

            if (_categoryList.Where(p => p.CategoryName == text).Any())
            {
                MessageBox.Show("已有此分類名稱！");
                editBox.Focus();
                return;
            }

            if (MessageBox.Show($"新增分類 [{text}]", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                editBox.Dispose();
                listCategory.Items.RemoveAt(selectedIndex1);
                return;
            }

            editBox.Dispose();
            listCategory.Items[selectedIndex1] = text;

            _categoryList.Add(_db.AddCategory(text));

            listCategory.SelectedIndex = -1;
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            if (selectedIndex1 == -1)
            {
                MessageBox.Show("未選擇分類！");
                return;
            }

            TextBox editBox = new TextBox
            {
                Text = listCategory.Items[selectedIndex1].ToString(),
                Bounds = listCategory.GetItemRectangle(selectedIndex1),
                Parent = listCategory
            };
            editBox.Focus();

            editBox.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.Enter)
                {
                    editBox.Parent.Focus();
                }
            };

            editBox.LostFocus += (s, ev) =>
            {
                UpdateCategory(editBox);
            };
        }

        private void UpdateCategory(TextBox editBox)
        {
            var text = editBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("不可為空白");
                editBox.Dispose();
                return;
            }

            if (text == listCategory.Items[selectedIndex1].ToString())
            {
                editBox.Dispose();
                return;
            }

            if (_categoryList.Where(p => p.CategoryName == text).Any())
            {
                MessageBox.Show("已有此分類名稱！");
                editBox.Dispose();
                return;
            }

            if (MessageBox.Show("確認更改", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                editBox.Dispose();
                return;
            }
            editBox.Dispose();

            listCategory.Items[selectedIndex1] = text;

            var id = _categoryList[selectedIndex1].CategoryId;

            _db.EditCategory(new Category
            {
                CategoryId = id,
                CategoryName = text.Trim()
            });

            _categoryList.First(c => c.CategoryId == id).CategoryName = text;
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            if (selectedIndex1 == -1)
            {
                MessageBox.Show("未選擇分類！");
                return;
            }

            if (MessageBox.Show("確認刪除？", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (_childList.Any())
            {
                MessageBox.Show("請先刪除子分類。");
                return;
            }

            var id = _categoryList[selectedIndex1].CategoryId;

            if (_db.GetRecordByCategoryId(id).Any())
            {
                MessageBox.Show("無法刪除，尚有紀錄存在！");
                return;
            }

            _db.DelCategory(id);
            listCategory.Items.RemoveAt(selectedIndex1);

            _categoryList.RemoveAll(p => p.CategoryId == id);
        }


        private void btnAdd2_Click(object sender, EventArgs e)
        {
            listChildCategory.Items.Add("");
            listChildCategory.SelectedIndex = listChildCategory.Items.Count - 1;

            TextBox editBox = new TextBox
            {
                Text = listChildCategory.Items[selectedIndex2].ToString(),
                Bounds = listChildCategory.GetItemRectangle(selectedIndex2),
                Parent = listChildCategory
            };
            editBox.Focus();

            editBox.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.Enter)
                {
                    editBox.Parent.Focus();
                }
            };

            editBox.LostFocus += (s, ev) =>
            {
                InsertChild(editBox);
            };
        }

        private void InsertChild(TextBox editBox)
        {
            var text = editBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                editBox.Dispose();
                listChildCategory.Items.RemoveAt(selectedIndex2);
                return;
            }

            if (_childList.Where(p => p.ChildCategoryName == text).Any())
            {
                MessageBox.Show("已有此子分類名稱！");
                editBox.Focus();
                return;
            }

            if (MessageBox.Show($"新增子分類 [{text}]", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                editBox.Dispose();
                listChildCategory.Items.RemoveAt(selectedIndex2);
                return;
            }

            editBox.Dispose();
            listChildCategory.Items[selectedIndex2] = text;

            var id = _categoryList[selectedIndex1].CategoryId;

            _childList.Add(_db.AddChild(id, text));

            listChildCategory.SelectedIndex = -1;
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            if (selectedIndex2 == -1)
            {
                MessageBox.Show("未選擇子分類！");
                return;
            }

            TextBox editBox = new TextBox
            {
                Text = listChildCategory.Items[selectedIndex2].ToString(),
                Bounds = listChildCategory.GetItemRectangle(selectedIndex2),
                Parent = listChildCategory
            };
            editBox.Focus();

            editBox.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.Enter)
                {
                    editBox.Parent.Focus();
                }
            };

            editBox.LostFocus += (s, ev) =>
            {
                UpdateChild(editBox);
            };
        }

        private void UpdateChild(TextBox editBox)
        {
            var text = editBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("不可為空白");
                editBox.Dispose();
                return;
            }

            if (text == listChildCategory.Items[selectedIndex2].ToString())
            {
                editBox.Dispose();
                return;
            }

            if (_childList.Where(p => p.ChildCategoryName == text).Any())
            {
                MessageBox.Show("已有此子分類名稱！");
                editBox.Dispose();
                return;
            }

            if (MessageBox.Show("確認更改", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                editBox.Dispose();
                return;
            }
            editBox.Dispose();

            listChildCategory.Items[selectedIndex2] = text;

            var id = _childList[selectedIndex2].ChildCategoryId;

            _db.EditChild(new ChildCategory
            {
                ChildCategoryId = id,
                ChildCategoryName = text.Trim()
            });

            _childList.First(c => c.ChildCategoryId == id).ChildCategoryName = text;

        }

        private void btnDel2_Click(object sender, EventArgs e)
        {
            if (selectedIndex2 == -1)
            {
                MessageBox.Show("未選擇子分類！");
                return;
            }

            if (MessageBox.Show("確認刪除？", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            var id = _childList[selectedIndex2].ChildCategoryId;

            if (_db.GetRecordByChildCategoryId(id).Any())
            {
                MessageBox.Show("無法刪除，尚有紀錄存在！");
                return;
            }

            _db.DelChild(id);
            listChildCategory.Items.RemoveAt(selectedIndex2);

            _childList.RemoveAll(p => p.ChildCategoryId == id);
        }





        private void listCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex1 = listCategory.SelectedIndex;
            listChildCategory.Items.Clear();

            if (selectedIndex1 >= _categoryList.Count || selectedIndex1 == -1)
            {
                btnAdd2.Enabled = false;
                btnEdit2.Enabled = false;
                btnDel2.Enabled = false;
                return;
            }

            btnAdd2.Enabled = true;
            btnEdit2.Enabled = true;
            btnDel2.Enabled = true;

            var id = _categoryList[selectedIndex1].CategoryId;

            _childList = _db.GetChilds(id);

            foreach (var child in _childList)
            {
                listChildCategory.Items.Add(child.ChildCategoryName);
            }
        }


        private void listChildCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex2 = listChildCategory.SelectedIndex;
        }

  
    }
}
