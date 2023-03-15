using projGerenciadorDeTags.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace projGerenciadorDeTags.Controller
{
    class DatabaseController
    {
        static readonly string databasePath = Application.StartupPath + @"\database.xml";
        static XDocument Xml;

        public static void Initialize()
        {
            if (File.Exists(databasePath)) LoadDatabase();
            else CreateDatabase();
        }

        public static void CreateDatabase()
        {
            //FileStream fs = File.Create(databasePath);
            XElement xml = new XElement
            (
                "Database", new XElement
                (
                    "Tags", new XElement("Branch"),new XElement("City")
                )
            );
            xml.Save(databasePath);
            LoadDatabase();
        }

        public static void LoadDatabase()
        {
            Xml = XDocument.Load(databasePath);
        }

        public static void Create(Tag tag, string tagType)
        {
            XElement XTag = new XElement("Tag",
                new XAttribute("Title", tag.Title),
                new XAttribute("Content", tag.Content)
            );

            Xml.Element("Database").Element("Tags").Element(tagType).Add(XTag);
            Xml.Save(databasePath);
        }

        public static string LoadTag(string branchTitle, string cityTitle)
        {
            var branch = Xml.Element("Database").Element("Tags").Element("Branch").Elements();
            var city = Xml.Element("Database").Element("Tags").Element("City").Elements();

            var queryBranch = from s in branch where 
                        s.Attribute("Title").Value == branchTitle select s;
            var queryCity = from s in city where
                        s.Attribute("Title").Value == cityTitle select s;

            return $"{queryBranch.First().Attribute("Content").Value}{Environment.NewLine}" +
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

        public static void Edit(Tag tag,string tagName, string tagType)
        {
            var xml = Xml.Element("Database").Element("Tags").Element(tagType).Elements().
                Where(e => e.Attribute("Title").Value == tagName);

            foreach (var t in xml)
            {
                t.Attribute("Title").Value = tag.Title;
                t.Attribute("Content").Value = tag.Content;
            }
            Xml.Save(databasePath);
        }

        public static void Remove(string tagName, string tagType)
        {
            var xml = Xml.Element("Database").Element("Tags").Element(tagType).Elements().
                Where(e => e.Attribute("Title").Value == tagName);

            foreach (var t in xml) t.Remove();
            Xml.Save(databasePath);
        }
    }
}
