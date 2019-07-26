using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _06_文件读写之XML文档操作
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1
            //List<Skill> skills = new List<Skill>();
            //XmlDocument xmlDocument = new XmlDocument();
            //xmlDocument.LoadXml(File.ReadAllText("SkillInfo.txt"));
            //XmlNode rootNode = xmlDocument.FirstChild;
            //XmlNodeList nodes = rootNode.ChildNodes;
            //foreach (XmlNode skillNode in nodes)
            //{
            //    Skill skill = new Skill();
            //    XmlNodeList fileNodeList = skillNode.ChildNodes;
            //    foreach (XmlNode fileNode in fileNodeList)
            //    {
            //        if (fileNode.Name == "id")
            //            skill.ID = Convert.ToInt32(fileNode.InnerText);
            //        else
            //        {
            //            if (fileNode.Name == "name")
            //            {
            //                skill.Name = fileNode.InnerText;
            //                skill.Language = Convert.ToString(fileNode.Attributes[0].Value);
            //            }
            //            else
            //                skill.Damage = Convert.ToInt32(fileNode.InnerText);
            //        }
            //    }
            //    skills.Add(skill);
            //}
            //Console.WriteLine("~~~~~~~~~");
            //foreach (Skill skill in skills)
            //    Console.WriteLine(skill); 
            #endregion

            #region Example 2
            //List<Skill> skillList = new List<Skill>();
            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(File.ReadAllText("xml技能信息.txt"));
            //XmlNode skillNodeLists = doc.FirstChild.FirstChild;
            //XmlNodeList skillNodeList = skillNodeLists.ChildNodes;
            //foreach (XmlNode item in skillNodeList)
            //{
            //    Skill skill = new Skill();
            //    XmlElement element = item["Name"];
            //    skill.Name = element.InnerText;
            //    XmlAttributeCollection collection = item.Attributes;
            //    skill.ID = Convert.ToInt32(collection[0].Value);
            //    skillList.Add(skill);
            //}
            //foreach (var item in skillList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Example 3
            //List<Test> tests = new List<Test>();
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load("TestXML.txt");
            //XmlNode rootNode = xmlDoc.FirstChild.FirstChild;
            //XmlNodeList xmlNodeList = rootNode.ChildNodes;
            //foreach (XmlNode node in xmlNodeList)
            //{
            //    Test test = new Test();
            //    test.Name = node.InnerText;
            //    XmlAttributeCollection collection = node.Attributes;
            //    test.ID = Convert.ToInt32(collection[0].Value);
            //    test.TestName = collection[1].Value;
            //    tests.Add(test);
            //}

            //foreach (var item in tests)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            Console.ReadKey();
        }
    }
    public class Test
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string TestName { get; set; }
        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, TestName: {2}", ID, Name, TestName);
        }
    }
    public class Skill
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public double Damage { get; set; }
        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Language: {2}, Damage: {3}", ID, Name, Language, Damage);
        }
    }
}
