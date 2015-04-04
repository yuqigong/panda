using System;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public class DBManager
    {
        public const string fpath = "C:\\boolhotelinfo.json";
        public static DbData Data = new DbData();

        static DBManager()
        {
            Load();
        }

        public static void Load()
        {
            string json = File.ReadAllText(fpath);

            Data = JsonConvert.DeserializeObject<DbData>(json);
        }

        public static void SaveToDisc()
        {
            string json = Data.ToJson();

            if (File.Exists(fpath))
            {
                File.Move(fpath, String.Format("C:\\json_bak\\boolhotelinfo{0}.json", DateTime.Now.ToString("MM_dd_HH_mm_ss")));
            }

            File.WriteAllText(fpath, json);
        }
    }
}