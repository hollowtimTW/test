using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using test.Models;

namespace test.Repository
{
    public class JsonHelper
    {
        private readonly string jsonPath;

        public JsonHelper()
        {
            jsonPath = Path.Combine(Environment.CurrentDirectory, "Data.json");
            if (!File.Exists(jsonPath))
            {
                var data = new JsonData
                {
                    Names = new List<string>(),
                    Devices = new List<string>()
                };
                File.WriteAllText(jsonPath, JsonConvert.SerializeObject(data, Formatting.Indented));
            }

            string jsonContent = File.ReadAllText(jsonPath);
            var jsonData = JsonConvert.DeserializeObject<JsonData>(jsonContent);

            if (jsonData != null)
            {
                LoadData(jsonData);
            }
        }

        private void LoadData(JsonData data)
        {
            Global.PersonList = data.Names ?? new List<string>();
            Global.DeviceList = data.Devices ?? new List<string>();
        }

        public void SaveData(JsonData data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));

            string jsonContent = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(jsonPath, jsonContent);
        }
    }
}