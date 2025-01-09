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
        private readonly string _dbPath;

        public DbHelper(string dbName)
        {
            _dbPath = Path.Combine(Environment.CurrentDirectory, dbName);
            if (!File.Exists(_dbPath))
            {
                CreateDatabase();
            }
        }

        private void CreateDatabase()
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();

                string sql = @"
                CREATE TABLE Record (
                    RecordId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Timestamp TEXT,
                    Person TEXT,
                    MaterialRequestNumber TEXT,
                    RepairRequestNumber TEXT,
                    Device TEXT,
                    Remarks TEXT,
                    Stock INTEGER
                )";

                connection.Execute(sql);
            }
        }

        public void InsertRecord(Record record)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = @"
                INSERT INTO Record (Timestamp, Person, MaterialRequestNumber, RepairRequestNumber, Device, Remarks, Stock)
                VALUES (@Timestamp, @Person, @MaterialRequestNumber, @RepairRequestNumber, @Device, @Remarks, @Stock)";
                connection.Execute(sql, record);
            }
        }

        public Record GetRecord(long id)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = "SELECT * FROM Record WHERE RecordId = @RecordId";
                return connection.QueryFirstOrDefault<Record>(sql, new { RecordId = id });
            }
        }

        public void DeleteRecord(long id)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = "DELETE FROM Record WHERE RecordId = @RecordId";
                connection.Execute(sql, new { RecordId = id });
            }
        }

        public void DeleteAllRecords()
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = "DELETE FROM Record";
                connection.Execute(sql);
            }
        }

        public List<Record> GetAllRecords()
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();

                string sql = @"SELECT * FROM Record";

                return connection.Query<Record>(sql).OrderByDescending(p => p.RecordId).ToList();
            }
        }

    }
}
