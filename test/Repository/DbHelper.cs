using System;
using System.Data.SQLite;
using System.IO;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using test.Models;

namespace test.Repository
{
    public class DbHelper
    {
        private readonly AppDbContext _context;

        public DbHelper()
        {
            string dbPath = Path.Combine(Environment.CurrentDirectory, "MyDatabase.db");
            _context = new AppDbContext(dbPath);
            if (!File.Exists(dbPath))
            {
                _context.Database.Migrate();
            }

        }

        public void InsertRecord(Record record)
        {
            _context.Record.Add(record);
            _context.SaveChanges();
        }

        public Record GetRecord(long id)
        {
            return _context.Record.Find(id);
        }

        public void DeleteRecord(long id)
        {
            var record = _context.Record.Find(id);
            if (record != null)
            {
                _context.Record.Remove(record);
                _context.SaveChanges();
            }
        }
        public void DeleteAllRecords()
        {
            _context.Record.RemoveRange(_context.Record);
            _context.SaveChanges();
        }

        public List<Record> GetAllRecords()
        {
            return _context.Record.OrderByDescending(r => r.RecordId).ToList();
        }
        
    }
}
