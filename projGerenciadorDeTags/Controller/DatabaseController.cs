using projGerenciadorDeTags.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projGerenciadorDeTags.Controller
{
    class DatabaseController
    {
        static readonly string databasePath = Application.StartupPath + @"\database.xml";
        static XDocument Xml;

        public async static Task Initialize()
        {
            try
            {
                HttpClient client = new HttpClient();
                Stream stream = await client.GetStreamAsync("https://www.portalltb.com.br/tags-api/index.php/database/get?");
                List<DatabaseInfo> infos = await JsonSerializer.DeserializeAsync<List<DatabaseInfo>>(stream);
                var info = infos.First();

                if (File.Exists(databasePath)) await LoadDatabase(info);
                else await CreateDatabase(info.version);
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        private static async Task LoadDatabase(DatabaseInfo info)
        {
            Xml = XDocument.Load(databasePath);

            if(info.GetVersion() > GetLocalDatabaseVersion())
            {
                File.Delete(databasePath);
                await CreateDatabase(info.version);
            }
        }

        private async static Task CreateDatabase(string version)
        {
            XElement xml = new XElement
            (
                "Database", new XElement
                (
                    "Tags", new XElement("Branch"), new XElement("City")
                ), 
                new XAttribute("Version", version)
            );

            HttpClient client = new HttpClient();
            Stream stream = await client.GetStreamAsync("https://www.portalltb.com.br/tags-api/index.php/branch/get?all");
            List<Tag> branchs = await JsonSerializer.DeserializeAsync<List<Tag>>(stream);

            foreach(var b in branchs)
            {
                XElement XTag = new XElement
                (
                    "Tag",
                    new XAttribute("Id", b.Id),
                    new XAttribute("Title", b.Title),
                    new XAttribute("Content", b.Content)
                );
                //.Element("Database").Element("Tags").Element("Branch")
                xml.Element("Tags").Element("Branch").Add(XTag);
            }

            stream = await client.GetStreamAsync("https://www.portalltb.com.br/tags-api/index.php/city/get?all");
            List<Tag> cities = await JsonSerializer.DeserializeAsync<List<Tag>>(stream);

            foreach (var c in cities)
            {
                XElement XTag = new XElement
                (
                    "Tag",
                    new XAttribute("Id", c.Id),
                    new XAttribute("Title", c.Title),
                    new XAttribute("Content", c.Content)
                );

                xml.Element("Tags").Element("City").Add(XTag);
            }

            xml.Save(databasePath);
            Xml = XDocument.Load(databasePath);
        }

        public static int GetLocalDatabaseVersion()
        {
            string tmp = Xml.Element("Database").Attribute("Version").Value;
            return int.Parse(tmp[tmp.Length - 1].ToString());
        }

        public static async Task Create(Tag tag, string tagType)
        {
            string json = JsonSerializer.Serialize(tag);

            using var client = new HttpClient();
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"https://www.portalltb.com.br/tags-api/index.php/{tagType.ToLower()}/post?"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request);
            var j = JsonSerializer.Deserialize<List<Tag>>(response.Content.ReadAsStringAsync().Result);

            XElement XTag = new XElement("Tag",
                new XAttribute("Id", j[0].Id),
                new XAttribute("Title", tag.Title),
                new XAttribute("Content", tag.Content)
            );

            Xml.Element("Database").Element("Tags").Element(tagType).Add(XTag);
            Xml.Save(databasePath);

            Task.Run(() => UpdateDatabaseVersion());
        }

        public static string LoadTag(string branchTitle, string cityTitle)
        {
            var branch = Xml.Element("Database").Element("Tags").Element("Branch").Elements();
            var city = Xml.Element("Database").Element("Tags").Element("City").Elements();

            var queryBranch = from s in branch
                              where
                        s.Attribute("Title").Value == branchTitle
                              select s;
            var queryCity = from s in city
                            where
                        s.Attribute("Title").Value == cityTitle
                            select s;

            return $"{queryBranch.First().Attribute("Content").Value.Replace("[cidade]", cityTitle, StringComparison.OrdinalIgnoreCase)}{Environment.NewLine}" +
                $"{Environment.NewLine}{queryCity.First().Attribute("Content").Value}";
        }

        public static Tag LoadTagAsTag(string branchTitle, string tagType)
        {
            var root = Xml.Element("Database").Element("Tags").Element(tagType).Elements();

            var query = from s in root
                              where
                        s.Attribute("Title").Value == branchTitle
                              select s;

            return new Tag()
            {
                Id = int.Parse(query.First().Attribute("Id").Value),
                Title = query.First().Attribute("Title").Value,
                Content = query.First().Attribute("Content").Value
            };
        }

        public static string[] LoadTagsTitle(string tagType)
        {
            List<string> tagsTitle = new List<string>();

            var xml = Xml.Element("Database").Element("Tags").Element(tagType).Elements();

            foreach(var t in xml) tagsTitle.Add(t.Attribute("Title").Value);

            tagsTitle.Sort();
            return tagsTitle.ToArray();
        }

        public static async Task Edit(Tag tag,string tagName, string tagType)
        {
            string json = JsonSerializer.Serialize(tag);

            using var client = new HttpClient();
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri($"https://www.portalltb.com.br/tags-api/index.php/{tagType.ToLower()}/put?id={tag.Id}"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = client.SendAsync(request).Result;

            Task.Run(() => UpdateDatabaseVersion());

            var xml = Xml.Element("Database").Element("Tags").Element(tagType).Elements().
                Where(e => e.Attribute("Title").Value == tagName);

            foreach (var t in xml)
            {
                t.Attribute("Id");
                t.Attribute("Title").Value = tag.Title;
                t.Attribute("Content").Value = tag.Content;
            }
            Xml.Save(databasePath);
        }

        public static async Task Remove(string id, string tagType)
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri($"https://www.portalltb.com.br/tags-api/index.php/{tagType.ToLower()}/delete?id={id}")
            };

            var response = client.SendAsync(request).Result;

            var xml = Xml.Element("Database").Element("Tags").Element(tagType).Elements().
                Where(e => e.Attribute("Id").Value == id);

            foreach (var t in xml) t.Remove();
            Xml.Save(databasePath);

            Task.Run(() => UpdateDatabaseVersion());
        }

        private static async Task UpdateDatabaseVersion()
        {
            var root = Xml.Element("Database");

            var info = new DatabaseInfo()
            {
                version = root.Attribute("Version").Value
            };

            info.UpdateVersion();

            Xml.Element("Database").Attribute("Version").Value = info.version;

            Xml.Save(databasePath);

            string json = JsonSerializer.Serialize(info);
            using var client = new HttpClient();


            var response = await client.PutAsync
            (
                $"https://www.portalltb.com.br/tags-api/index.php/database/put?version={info.version}",
                new StringContent(json, Encoding.UTF8, "application/json")
            );

            var result = await response.Content.ReadAsStringAsync();
        }
    }
}
