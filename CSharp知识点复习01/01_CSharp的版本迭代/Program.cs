using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace _01_CSharp的版本迭代
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product2> lists = Product2.GetSimpleProducts();
            List<Supplier> suppliers = Supplier.GetSimpleSuppliers();

            //foreach (Product2 product in lists)
            //    Console.WriteLine(product);
            ////循环遍历大于10的所有数据
            //lists.FindAll(p => p.Price > 10).ForEach(item => { Console.WriteLine(item); });

            #region 复杂的LINQ查询
            //var result = from product in lists
            //             join supplier in suppliers on product.Supplier.Id equals supplier.Id
            //             select new
            //             {
            //                 supplierInstance = supplier,
            //                 productInstance = product,
            //                 groupresult = from name in lists
            //                               group supplier.Name by supplier into suppliergroup
            //                               select new
            //                               {
            //                                   item = suppliergroup.Key,
            //                                   count = suppliergroup.Count()
            //                               }
            //             };
            //foreach (var item in result)
            //{
            //    foreach (var item1 in item.groupresult)
            //    {
            //        Console.WriteLine(item1.item + " " + item1.count);
            //    }
            //}
            #endregion

            #region 通过LINQ读取从XML文件中的产品数据信息
            XDocument doc = XDocument.Load(@"SimpleProductWithSupplier.xml");
            var rootNode = doc.Root;
            var prodcutsNode = rootNode.XPathSelectElement("Products");
            var suppliersNode = rootNode.XPathSelectElement("Suppliers");
            var result = from product in prodcutsNode.Elements("Product")
                         join supplier in suppliersNode.Elements("Supplier") on prodcutsNode.Attribute("SupplierId").Value equals suppliersNode.Attribute("SupplierId").Value
                         select new {

                         };

            #endregion
            Console.ReadKey();
        }
    }

    public class Supplier
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Supplier(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public static List<Supplier> GetSimpleSuppliers()
        {
            return new List<Supplier>() {
                new Supplier(1,"张三"),
                new Supplier(2,"李四")
            };
        }
        public override string ToString()
        {
            return this.Name + "   " + this.Id.ToString();
        }
    }


    public class Product1
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product1(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public static ArrayList GetSimpleProducts()
        {
            return new ArrayList() {
                new Product1("熊火腿",22),
                new Product1("熊火腿",22),
                new Product1("熊火腿",22),
                new Product1("熊火腿",22),
            };
        }
        public override string ToString()
        {
            return this.Name + " " + this.Price;
        }
    }
    public class Product2
    {
        private string _name;
        private decimal? _price;
        private Supplier _supplier;
        public string Name
        {
            get { return this._name; }
            private set { this._name = value; }
        }
        public decimal? Price
        {
            get { return this._price; }
            private set { this._price = value; }
        }
        public Supplier Supplier
        {
            get
            {
                return this._supplier;
            }
            set
            {
                this._supplier = value;
            }
        }
        public static List<Product2> GetSimpleProducts()
        {
            return new List<Product2>
         {
            new Product2("小火腿" , 22){ Supplier=new Supplier(1,"张三") } ,
            new Product2("红火腿" , 22) { Supplier=new Supplier(2,"李四") } ,
            new Product2("金火腿" , 22) { Supplier=new Supplier(1,"张三") } ,
            new Product2("绿火腿" , 22){ Supplier=new Supplier(2,"李四") }  ,
            new Product2("字火腿" , 22){ Supplier=new Supplier(1,"张三") }  ,
            new Product2("哈哈哈火腿" , 22) { Supplier=new Supplier(2,"李四") } ,
            new Product2("金刚小火腿" , 22){ Supplier=new Supplier(1,"张三") }  ,
            new Product2("666小火腿" , 22){ Supplier=new Supplier(3,"王五") } ,
            new Product2("可空类型的小火腿" ){ Supplier=new Supplier(1,"张三") } ,
            new Product2("可空类型的小火腿一号出国了" ){ Supplier=new Supplier(4,"赵六") } ,
         };
        }
        public Product2(string name, decimal? price = null)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return this.Name + " " + this.Price.ToString();
        }
        public class Product3
        {
            private readonly string _name;
            private readonly decimal _price;
            public string Name
            {
                get { return this._name; }
            }
            public decimal Price
            {
                get { return this._price; }
            }
            public static List<Product3> GetSimpleProducts()
            {
                return new List<Product3> {
            new Product3("熊火腿" , 22),
            new Product3("熊火腿" , 22),
            new Product3("熊火腿" , 22),
            new Product3("熊火腿" , 22),
         };
            }
            public Product3(string name, decimal price)
            {
                this._name = name;
                this._price = price;
            }
            public override string ToString() { return this.Name + "   " + this.Price.ToString(); }
        }
    }
}
