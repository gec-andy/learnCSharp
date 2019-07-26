using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_结构化查询之Linq查询
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 构建LINQ查询的对象
            //初始化武林高手
            var masterList = new List<MartialArtsMaster>()
            {
                new MartialArtsMaster() {Id = 1, Name = "黄蓉", Age = 18, Menpai = "丐帮", Kongfu = "打狗棒法", Level = 9},
                new MartialArtsMaster() {Id = 2, Name = "洪七公", Age = 70, Menpai = "丐帮", Kongfu = "打狗棒法", Level = 10},
                new MartialArtsMaster() {Id = 3, Name = "郭靖", Age = 22, Menpai = "丐帮", Kongfu = "降龙十八掌", Level = 10},
                new MartialArtsMaster() {Id = 4, Name = "任我行", Age = 50, Menpai = "明教", Kongfu = "葵花宝典", Level = 1},
                new MartialArtsMaster() {Id = 5, Name = "东方不败", Age = 35, Menpai = "明教", Kongfu = "葵花宝典", Level = 10},
                new MartialArtsMaster() {Id = 6, Name = "林平之", Age = 23, Menpai = "华山", Kongfu = "葵花宝典", Level = 7},
                new MartialArtsMaster() {Id = 7, Name = "岳不群", Age = 50, Menpai = "华山", Kongfu = "葵花宝典", Level = 8},
                new MartialArtsMaster() {Id = 8, Name = "令狐冲", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10},
                new MartialArtsMaster() {Id = 9, Name = "梅超风", Age = 23, Menpai = "桃花岛", Kongfu = "九阴真经", Level = 8},
                new MartialArtsMaster() {Id = 10, Name = "黄药师", Age = 23, Menpai = "梅花岛", Kongfu = "弹指神通", Level = 10},
                new MartialArtsMaster() {Id = 11, Name = "风清扬", Age = 23, Menpai = "华山", Kongfu = "独孤九剑", Level = 10}
            };
            //初始化武学
            var kongfuList = new List<Kongfu>()
            {
                new Kongfu() {Id = 1, Name = "打狗棒法", Lethality = 90},
                new Kongfu() {Id = 2, Name = "降龙十八掌", Lethality = 95},
                new Kongfu() {Id = 3, Name = "葵花宝典", Lethality = 100},
                new Kongfu() {Id = 4, Name = "独孤九剑", Lethality = 100},
                new Kongfu() {Id = 5, Name = "九阴真经", Lethality = 100},
                new Kongfu() {Id = 6, Name = "弹指神通", Lethality = 100}
            };
            //Todo:查询所有武学级别大于8的武林高手

            #region Eg——1 通过循环遍历数据
            //var list = new List<MartialArtsMaster>();
            //foreach (var item in masterList)
            //{
            //    if (item.Level >= 8)
            //        list.Add(item); 
            //}
            #endregion

            #region Eg——2 通过LINQ查询数据

            #region 01_Lamba 表达式
            //var res = masterList.Where(martialArtsMaster => martialArtsMaster.Level > 8 && martialArtsMaster.Menpai == "丐帮");
            //var res1 = masterList.SelectMany(item => kongfuList, (masterItem, kongfuItem) =>
            //            new
            //            {
            //                masterItem,
            //                kongfuItem
            //            }).
            //    Where(@t =>
            //            @t.masterItem.Kongfu == "打狗棒法" && @t.kongfuItem.Name == "打狗棒法").
            //    Select(@t =>
            //            new
            //            {
            //                newMaster = @t.masterItem,
            //                newkongfu = @t.kongfuItem
            //            });

            //Console.WriteLine(res1.GetType());
            //foreach (var item in res1)
            //{
            //    Console.WriteLine(item.newkongfu.ToString() + " " + item.newMaster.ToString());
            //}
            #endregion

            #endregion

            #endregion

            #region MyRegion
            //string[] names = { "张三", "王五        ", "李四      王献之         ", "我那个号心凉·1", "王老吉", "dwawdawdj" };
            //StringBuilder builder = new StringBuilder();
            //names = names.Where(str => str.Length > 2).ToArray();
            ////foreach (string str in names)
            ////{
            ////    if (str.Contains(" "))
            ////        builder.Append($"姓名：{str}");
            ////}
            ////Console.WriteLine(builder.ToString());
            //var result = from name in names
            //             where name.Contains(" ")
            //             orderby name.Length descending
            //             select new { name1 = name };
            //foreach (var item in result)
            //    Console.WriteLine(item);    
            #endregion

            #region 使用LINQ操作数据集合 _1
            //List<Car> cars = new List<Car>() {
            //        new Car(){PetName="熊啊汽车",Color="黄色",Speed=50,Make="美国" },
            //        new Car(){ PetName="美国狗熊牌汽车",Color="绿色",Speed=120,Make="因果"},
            //        new Car(){PetName="日本京东安倍晋三狗车",Color="绿色",Speed=250,Make="日本" },
            //        new Car(){PetName="美国特朗普拉洗车",Color="绿色",Speed=120,Make="美国" } ,
            //};
            //var result = from car in cars
            //             where car.Speed > 50 && car.Make == "美国"
            //             select car;
            //foreach (var item in result)
            //    Console.WriteLine(item.PetName);
            #endregion

            #region 使用LINQ操作数据集合 _2
            List<ProductInfo> productInfoList = new List<ProductInfo>()
             {
                 new ProductInfo(){ Name="火腿肠",Description="垃圾食品,不可多食",NumberInStock=22},
                 new ProductInfo(){ Name="小鸡巴",Description="垃圾食品,不可多食",NumberInStock=35},
                 new ProductInfo(){ Name="李宇春",Description="垃圾食品,不可多食",NumberInStock=45},
                 new ProductInfo(){ Name="铁观音",Description="垃圾食品,不可多食",NumberInStock=10},
                 new ProductInfo(){ Name="美味刀",Description="垃圾食品,不可多食",NumberInStock=5},
                 new ProductInfo(){ Name="帖老妹",Description="垃圾食品,不可多食",NumberInStock=6},
                 new ProductInfo(){ Name="王吹瓶",Description="垃圾食品,不可多食",NumberInStock=77},
                 new ProductInfo(){ Name="天王肉",Description="垃圾食品,不可多食",NumberInStock=120},
                 new ProductInfo(){ Name="狗鸡巴",Description="垃圾食品,不可多食",NumberInStock=10},
             };
            //var products = from productInfo in productInfoList
            //               select productInfo;
            //foreach (var item in products)
            //    Console.WriteLine(item);

            //var result = from info in productInfoList
            //             where info.NumberInStock > 10
            //             orderby info.NumberInStock descending
            //             select info;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            Console.ReadKey();
        }
    }

    public class Car
    {
        public string PetName { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public string Make { get; set; }
        public Car() { }
    }
    public class ProductInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberInStock { get; set; }
        public override string ToString()
        {
            return string.Format("商品名称：{0} 商品描述信息：{1} 商品数量：{2}", this.Name, Description, NumberInStock);
        }
    }
    public class ProductInfoCompare : IComparer<ProductInfo>
    {
        public int Compare(ProductInfo x, ProductInfo y)
        {
            if (x.NumberInStock > y.NumberInStock)
                return 1;
            else if (x.NumberInStock < y.NumberInStock)
                return -1;
            else
                return 0;
        }
    }

    /// <summary>
    /// 武林高手
    /// </summary>
    class MartialArtsMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Menpai { get; set; }
        public string Kongfu { get; set; }
        public int Level { get; set; }
        public override string ToString()
        {
            return string.Format("武林高手编号: {0}, 武林高手名字: {1}, 武林门派: {2}, 武林高手年龄: {3}, 武林功夫: {4}, 武林高手等级: {5}", Id, Name, Menpai, Age, Kongfu, Level);
        }
    }
    public class Kongfu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Lethality { get; set; }
        public override string ToString()
        {
            return $"功夫编号：{this.Id},功夫名称：{this.Name},功夫伤害：{this.Lethality}。";
        }
    }



    public class Racer : IComparable<Racer>, IFormattable
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Wins { get; set; }
        public int Starts { get; set; }
        public string Country { get; set; }
        public IList<int> Years { get; set; }
        public IList<string> Cars { get; set; }
        public Racer(string firstName, string lastName, int wins, int starts, string country, IList<int> years, IList<string> cars) { }
        public int CompareTo(Racer other)
        {
            return other != null && string.Compare(this.LastName, other.LastName, StringComparison.Ordinal) == 0 ? 0 : -1;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null)
                return this.ToString();
            switch (format)
            {
                case "F":
                    return this.FirstName;
                case "L":
                    return this.LastName;
                case "W":
                    return this.Wins.ToString();
                case "s":
                    return this.Starts.ToString();
                case "C":
                    return this.Country;
                case "A":
                    return $"{this.FirstName} {this.LastName} {this.Country} {this.Starts} {this.Wins}";
                default:
                    return this.ToString();

            }
        }
        public override string ToString()
        {
            return $"{this.FirstName}, {this.LastName}";
        }
    }

    public class Team
    {
        public string TeamName { get; set; }
        public List<int> Years { get; set; }
        public Team(string strTeamName, List<int> years)
        {
            this.TeamName = strTeamName;
            this.Years = years;
        }
    }

    public class RacerInfo
    {
        public RacerInfo()
        {

        }
        public string FirstNaame { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }
        public int Position { get; set; }
        public override string ToString()
        {
            return $"{this.Year}, {this.Position}, {this.FirstNaame}, {this.LastName}";
        }
    }
}
