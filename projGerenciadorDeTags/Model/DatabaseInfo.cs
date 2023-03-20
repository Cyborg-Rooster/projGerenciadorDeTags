using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace projGerenciadorDeTags.Model
{
    class DatabaseInfo
    {
        [JsonPropertyName("version")] public string version { get; set; }

        public void UpdateVersion()
        {
            int tmpVersion = int.Parse(version[version.Length - 1].ToString());
            tmpVersion++;

            version = "1." + tmpVersion.ToString();
        }

        public int GetVersion()
        {
            return int.Parse(version[version.Length - 1].ToString());
        }
    }
}
