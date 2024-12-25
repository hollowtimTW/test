using System;
using System.Data.SQLite;
using System.IO;
using Dapper;
using Microsoft.VisualBasic.FileIO;
using test.Model;

namespace test.Repository
{
    public class DatabaseHelper
    {
        private readonly string _dbPath;

        public DatabaseHelper(string dbName)
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
                    Timestamp DATETIME,
                    Person TEXT,
                    MaterialRequestNumber TEXT,
                    RepairRequestNumber TEXT,
                    Device TEXT,
                    Remarks TEXT
                );
                CREATE TABLE Person (
                    PersonId INTEGER PRIMARY KEY AUTOINCREMENT,
                    PersonName TEXT
                );
                CREATE TABLE Device (
                    DeviceId INTEGER PRIMARY KEY AUTOINCREMENT,
                    DeviceName TEXT
                )";
                connection.Execute(sql);
                Console.WriteLine("Database and tables created.");
            }
        }

        public void InsertRecord(tRecord record)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = @"
                INSERT INTO Record (Timestamp, PersonId, MaterialRequestNumber, RepairRequestNumber, DeviceId, Remarks)
                VALUES (@Timestamp, @PersonId, @MaterialRequestNumber, @RepairRequestNumber, @DeviceId, @Remarks)";
                connection.Execute(sql, record);
            }
        }

        public List<Record> GetAllRecords()
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();

                string sql = @"SELECT * FROM Record";

                return connection.Query<Record>(sql).ToList();
            }
        }

        public void InsertPerson(tPerson person)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = @"
                INSERT INTO Person (PersonName)
                VALUES (@PersonName)";
                connection.Execute(sql, person);
            }
        }

        public List<tPerson> GetAllPersons()
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = "SELECT * FROM Person";
                return connection.Query<tPerson>(sql).ToList();
            }
        }

        public void InsertDevice(tDevice device)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = @"
                INSERT INTO Device (DeviceName)
                VALUES (@DeviceName)";
                connection.Execute(sql, device);
            }
        }

        public List<tDevice> GetAllDevices()
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = "SELECT * FROM Device";
                return connection.Query<tDevice>(sql).ToList();
            }
        }
    }
}
