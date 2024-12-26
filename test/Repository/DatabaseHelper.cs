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
                INSERT INTO Record (Timestamp, Person, MaterialRequestNumber, RepairRequestNumber, Device, Remarks)
                VALUES (@Timestamp, @Person, @MaterialRequestNumber, @RepairRequestNumber, @Device, @Remarks)";
                connection.Execute(sql, record);
            }
        }

        public tRecord GetRecord(int id)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = "SELECT * FROM Record WHERE RecordId = @RecordId";
                return connection.QueryFirstOrDefault<tRecord>(sql, new { RecordId = id });
            }
        }

        public void DeleteRecord(int id)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = "DELETE FROM Record WHERE RecordId = @RecordId";
                connection.Execute(sql, new { RecordId = id });
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

        public void InsertPerson(string name)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = @"
                INSERT INTO Person (PersonName)
                VALUES (@PersonName)";
                connection.Execute(sql, new { PersonName = name });
            }
        }

        public tPerson GetPerson(string name)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = "SELECT * FROM Person WHERE PersonName = @PersonName";
                return connection.QueryFirstOrDefault<tPerson>(sql, new { PersonName = name });
            }
        }

        public void DeletePerson(string name)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = "DELETE FROM Person WHERE PersonName = @PersonName";
                connection.Execute(sql, new { PersonName = name });
            }
        }


        public List<string> GetAllPersons()
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = "SELECT * FROM Person";
                return connection.Query<tPerson>(sql).Select(p=>p.PersonName).ToList();
            }
        }

        public void InsertDevice(string device)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = @"
                INSERT INTO Device (DeviceName)
                VALUES (@DeviceName)";
                connection.Execute(sql, new { DeviceName = device });
            }
        }

        public tDevice GetDevice(string device)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = "SELECT * FROM Device WHERE DeviceName = @DeviceName";
                return connection.QueryFirstOrDefault<tDevice>(sql, new { DeviceName = device });
            }
        }


        public void DeleteDevice(string device)
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = "DELETE FROM Device WHERE DeviceName = @DeviceName";
                connection.Execute(sql, new { DeviceName = device });
            }
        }


        public List<string> GetAllDevices()
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string sql = "SELECT * FROM Device";
                return connection.Query<tDevice>(sql).Select(p=>p.DeviceName).ToList();
            }
        }
    }
}
