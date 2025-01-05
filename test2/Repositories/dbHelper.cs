using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test2.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace test2.Repositories
{
    public class dbHelper
    {
        ESQtempdatabasedbContext _context;
        public dbHelper()
        {
            _context = new ESQtempdatabasedbContext();
        }

        #region [Category]

        public List<Category> GetCategories()
        {
            return _context.Category.ToList();
        }

        public Category AddCategory(string name)
        {
            var model = new Category
            {
                CategoryName = name
            };

            _context.Category.Add(model);
            _context.SaveChanges();

            return model;
        }

        public bool EditCategory(Category model)
        {
            var res = _context.Category.Where(p =>
                    p.CategoryId == model.CategoryId
                ).FirstOrDefault();

            if (res != null)
            {
                res.CategoryName = model.CategoryName;
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DelCategory(long id)
        {
            var res = _context.Category.Where(p => p.CategoryId == id).FirstOrDefault();

            if (res != null)
            {
                _context.Category.Remove(res);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        #endregion [Category]


        #region [ChildCategory]

        public List<ChildCategory> GetChilds(long id)
        {
            return _context.ChildCategory.Where(p => p.CategoryId == id).ToList();
        }

        public ChildCategory AddChild(long id, string name)
        {
            var model = new ChildCategory
            {
                CategoryId = id,
                ChildCategoryName = name
            };

            _context.ChildCategory.Add(model);
            _context.SaveChanges();
            return model;
        }

        public void EditChild(ChildCategory model)
        {
            var res = _context.ChildCategory.Where(p =>
                    p.ChildCategoryId == model.ChildCategoryId
                ).FirstOrDefault();

            if (res != null)
            {
                res.ChildCategoryName = model.ChildCategoryName;
                _context.SaveChanges();
            }
        }

        public bool DelChild(long id)
        {
            var res = _context.ChildCategory.Where(p => p.ChildCategoryId == id).FirstOrDefault();

            if (res != null)
            {
                _context.ChildCategory.Remove(res);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        #endregion [ChildCategory]


        #region [Record]

        public List<Record> GetRecordByCategoryId(long id)
        {
            return _context.Record.Where(p => p.CategoryId == id).ToList();
        }

        public List<Record> GetRecordByChildCategoryId(long id)
        {
            return _context.Record.Where(p => p.ChildCategoryId == id).ToList();
        }

        public List<Record> GetRecords()
        {
            return _context.Record.ToList();
        }

        public bool AddRecord(Record model)
        {
            _context.Record.Add(model);
            _context.SaveChanges();
            return true;
        }

        public bool EditRecord(Record model)
        {
            var res = _context.Record.Where(p => p.RecordId == model.RecordId).FirstOrDefault();

            if (res != null)
            {
                res.PurchaseNo = model.PurchaseNo;
                res.MaterialNo = model.MaterialNo;
                res.Model = model.Model;
                res.DeliveryDate= model.DeliveryDate;
                res.Quantity = model.Quantity;
                res.Vendor = model.Vendor;
                res.Stock = model.Stock;
                res.ReceiptNo = model.ReceiptNo;
                res.Price = model.Price;
                res.Notes = model.Notes;

                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DelRecord(Record record)
        {
            var res = _context.Record.Where(p => p.RecordId == record.RecordId).FirstOrDefault();

            if (res != null)
            {
                _context.Record.Remove(res);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        

        #endregion [Record]


    }
}
