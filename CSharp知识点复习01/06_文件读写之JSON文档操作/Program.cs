using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitJson;//引人解析Json文件的类库
using System.IO;
namespace _06_文件读写之JSON文档操作
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1
            JsonData jsonData = JsonMapper.ToObject(File.ReadAllText("json技能信息.txt"));
            List<Skill> skills = new List<Skill>();
            foreach (JsonData data in jsonData)
            {
                JsonData id = data["id"];
                JsonData name = data["name"];
                JsonData damage = data["damage"];
                Skill skill = new Skill()
                {
                    ID = (int)(id),
                    Name = (string)(name),
                    Damage = (int)(damage)
                };
                skills.Add(skill);
            }
            foreach (Skill skill in skills)
            {
                Console.WriteLine(skill);
            }
            #endregion

            Console.ReadKey();
        }
    }

    public class Skill
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Damage: {2}", ID, Name, Damage);
        }
    }
}
