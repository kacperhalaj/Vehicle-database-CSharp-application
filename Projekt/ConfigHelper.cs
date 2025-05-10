using System.IO;
using Newtonsoft.Json.Linq;

namespace Projekt
{
    public static class ConfigHelper
    {
        public static string ConfigPath => "appsettings.json";

        public static string GetConnectionString()
        {
            var json = JObject.Parse(File.ReadAllText(ConfigPath));
            return json["ConnectionStrings"]?["DefaultConnection"]?.ToString();
        }

        public static void SetConnectionString(string connStr)
        {
            var json = JObject.Parse(File.ReadAllText(ConfigPath));
            json["ConnectionStrings"]["DefaultConnection"] = connStr;
            File.WriteAllText(ConfigPath, json.ToString());
        }
    }
}