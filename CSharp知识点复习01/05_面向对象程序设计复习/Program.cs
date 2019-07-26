using System;
using System.Collections.Generic;
using System.Threading;

namespace _05_面向对象程序设计复习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 面向对象之类的使用
            //People[] peopleArray = {
            //    new Chinese(),
            //    new American(),
            //    new EnglishMen(),
            //    new Germans()
            //};
            //foreach (var people in peopleArray)
            //{
            //    people.SayHello();
            //    people.Eating();
            //    people.Sleeping();
            //    people.Playing();
            //} 
            #endregion

            #region 封装载具的一些东西
            //Vehicle vehicle = new Car()
            //{
            //    Name = "傻逼牌汽车~",
            //    Speed = 20,
            //    GenerationDate = DateTime.Now
            //};

            //GenerationVehicle.Generation(vehicle);
            //vehicle.Run();
            //vehicle.ShowResult();
            #endregion

            #region 封装员工的一些东西
            //Employee employee = new Employee("张萨安", 33, "", "", 5000);
            //employee.GiveBouns(500);
            //Console.WriteLine(employee);
            #endregion
            Console.ReadKey();
        }
    }


    #region 模拟汽车
    /// <summary>
    /// 载具类
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// 载具名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 载具速度
        /// </summary>
        public int Speed { get; set; }
        /// <summary>
        /// 当前速度
        /// </summary>
        public int CurentSpeed { get; set; }
        /// <summary>
        /// 最大速度(固定常量,一般不会变动)
        /// </summary>
        public static int MaxSpeed { get; set; }
        /// <summary>
        /// 生产日期
        /// </summary>
        public DateTime GenerationDate { get; set; }
        /// <summary>
        /// 生产地址
        /// </summary>
        public string GenerationAddress { get; set; }
        /// <summary>
        /// 载具收音机
        /// </summary>
        public Radio Radio { get; set; }
        /// <summary>
        /// 载具是否挂了
        /// </summary>
        public bool IsDead { get; set; }
        public string[] array = new string[10];
        static Vehicle()
        {
            MaxSpeed = 100;
        }
        public Vehicle()
        {

        }
        public Vehicle(string name)
        {
            this.Name = name;
        }
        public Vehicle(string name, DateTime date)
        {
            this.Name = name;
            this.GenerationDate = date;
        }
        public Vehicle(string name, int speed, DateTime date) : this(name, date)
        {
            this.Speed = speed;
        }
        public Vehicle(string name, int speed, DateTime generationDate, string generationAddress) : this(name, speed, generationDate)
        {
            this.GenerationAddress = generationAddress;
        }
        public virtual void ShowResult()
        {
            Console.WriteLine($"当前的汽车{Name},当前汽车的速度{Speed}");
            Thread.Sleep(1000);
            VehicleAction.IncrementSpeed(this);
            Console.WriteLine($"当前的汽车{Name},当前汽车的速度{Speed}");
            Thread.Sleep(1000);
            VehicleAction.IncrementSpeed(this);
            Console.WriteLine($"当前的汽车{Name},当前汽车的速度{Speed}");
            Thread.Sleep(1000);
            Console.WriteLine($"{this.Name} 抵达终点了~");
            Console.WriteLine("汽车名称：{0} 当前速度：{1} 最大速度：{2}", this.Name, this.CurentSpeed, MaxSpeed);
        }
        public void Run()
        {
            VehicleAction.ToRun(this);
        }
        public string this[int parameterIndex]
        {
            get { return this.array[parameterIndex]; }
            set { this.array[parameterIndex] = value; }
        }
    }

    public class Radio
    {
        public bool IsOpen { get; set; }
        public void OnTurn(bool isOpen)
        {
            this.IsOpen = IsOpen;
            if (IsOpen)
            {
                Console.WriteLine("打开收音机~");
            }
            else
            {
                Console.WriteLine("关闭收音机~");
            }
        }
    }

    public class Car : Vehicle
    {
        public Car() : base("", DateTime.Now) { }
        public override void ShowResult()
        {

            Console.WriteLine($"这是 {this.Name} 的运行结果~");
            base.ShowResult();
        }
    }
    /// <summary>
    /// 公共汽车
    /// </summary>
    public class Bus : Car { }
    /// <summary>
    /// 奥迪轿车
    /// </summary>
    public class AudiCar : Car
    {
        //   public AudiCar() : this("", DateTime.Now) { }
        public override void ShowResult()
        {
            Console.WriteLine($"这是 {this.Name} 的运行结果~");
            base.ShowResult();
        }

    }

    /// <summary>
    /// 载具行为
    /// </summary>
    public class VehicleAction
    {
        /// <summary>
        /// 加速
        /// </summary>
        /// <param name="vehicle"></param>
        public static void IncrementSpeed(Vehicle vehicle)
        {
            vehicle.Speed += 3;
            if (vehicle.Speed >= Vehicle.MaxSpeed)
            {
                vehicle.Speed = Vehicle.MaxSpeed;
                Thread.Sleep(3000);
                vehicle.IsDead = true;
            }
            if (vehicle.IsDead == true)
            {
                Console.WriteLine("载具因为过热,导致载具已经爆炸致死");
                return;
            }
            else
                vehicle.CurentSpeed = vehicle.Speed;
        }
        /// <summary>
        /// 驾驶
        /// </summary>
        /// <param name="vehicle"></param>
        public static void ToRun(Vehicle vehicle)
        {
            Console.WriteLine($"{vehicle.Name} 启动了~");
        }

        public static void CrankTunes(Vehicle vehicle, bool state)
        {
            vehicle.Radio.OnTurn(state);
        }
    }
    /// <summary>
    /// 载具事件参数
    /// </summary>
    public class VehicleEventArgs : EventArgs
    {
        public string Message { get; set; }
        public Vehicle Vehicle { get; set; }
        public VehicleEventArgs(Vehicle vehicle)
        {
            if (vehicle != null)
            {
                this.Vehicle = vehicle;
                this.Message = $@"新车抵达: -> 车的名称: {this.Vehicle.Name}  车的生产地址: {this.Vehicle.GenerationAddress}   车的生产日期: {this.Vehicle.GenerationDate.ToShortDateString()}  ";
            }
        }
    }
    /// <summary>
    /// 新载具管理者
    /// </summary>
    public sealed class NewVehicleManager
    {
        public event EventHandler<VehicleEventArgs> VehicleEvent;
        public void NewVehicle(VehicleEventArgs args)
        {
            this.OnVehicleEvent(this, args);
        }
        /// <summary>
        /// 触发新载具入库的事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnVehicleEvent(object sender, VehicleEventArgs args)
        {
            this.VehicleEvent?.Invoke(sender, args);
            if (sender != null && args != null)
                Console.WriteLine(args.Message);
        }
    }
    /// <summary>
    /// 生产载具类
    /// </summary>
    public class GenerationVehicle
    {
        /// <summary>
        /// 新载具管理者
        /// </summary>
        private static NewVehicleManager manager = new NewVehicleManager();
        public GenerationVehicle()
        {

        }
        /// <summary>
        /// 生产载具
        /// </summary>
        /// <param name="vehicles"></param>
        public static void Generation(params Vehicle[] vehicles)
        {
            if (vehicles == null)
                return;
            if (vehicles.Length == 0)
                return;
            foreach (Vehicle vehicle in vehicles)
            {
                manager.NewVehicle(new VehicleEventArgs(vehicle));
            }
        }
    }
    #endregion

    #region 模拟人类
    /// <summary>
    /// 人类共同持有的行为
    /// </summary>
    public interface IPeopleable
    {
        void Eating();
        void Sleeping();
        void Playing();
        void SayHello();
    }
    public interface IEatable { void Eat(); }
    public interface IDuckable { void Duck(); }
    public interface IFireAttackable
    {
        void SingleFireAttack();
        void MuitlFireAttack();
    }
    /// <summary>
    /// 人类抽象类
    /// </summary>
    public abstract class People : IPeopleable, IEatable, IDuckable, IFireAttackable
    {
        private string _name;
        private int _age;
        private string _gender;
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get { return this._name; } set { this._name = value; } }
        /// <summary>
        /// 年龄（带有约束的属性值）
        /// </summary>
        public int Age
        {
            get
            {
                if (this._age > 18 && this._age < 101)
                {
                    return this._age;
                }
                return 10;
            }
            set
            {
                if (value >= 18 && value <= 101)
                {
                    this._age = value;
                }
                else
                {
                    this.Age = 18;
                }
            }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get { return this._gender; } set { this._gender = value; } }

        public void Duck()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Eating() { Console.WriteLine("我可以吃饭"); }

        public void MuitlFireAttack()
        {
            throw new NotImplementedException();
        }

        public void Playing() { Console.WriteLine("我可以玩"); }

        public abstract void SayHello();

        public void SingleFireAttack()
        {
            throw new NotImplementedException();
        }

        public void Sleeping() { Console.WriteLine("我可以睡觉"); }
    }
    public class Chinese : People
    {
        public override void SayHello()
        {
            Console.WriteLine("这是中国人在打招呼~");
        }
    }
    public class American : People
    {
        public override void SayHello()
        {
            Console.WriteLine("这是美国人在打招呼~");
        }
    }
    public class EnglishMen : People
    {
        public override void SayHello()
        {
            Console.WriteLine("这是英国人在打招呼~");
        }
    }
    public class Germans : People
    {
        public override void SayHello()
        {
            Console.WriteLine("这是德国人在打招呼~");
        }
    }


    public class ClassInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ClassInfo()
        {

        }
        public ClassInfo(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
        public override string ToString()
        {
            return $"{this.Id} {this.Name} {this.Description}";
        }
    }
    #endregion

    #region 面向对象抽象化思想
    public enum Color
    {
        White, Black, Grreen, Blue, Red
    }
    public static class MyClass
    {
        private static Color _color;
        private static DateTime _dateTime;
        static MyClass()
        {
            MyClass._dateTime = DateTime.Now;
        }
    }
    public class Person
    {
        private string _name;
        private int _age;
        private string _emailAddress;
        private string _homeAddress;

        public string GetName() => this._name;
        public void SetName(string name) => this._name = name;

        public int GetAge() => this._age;
        public void SetAge(int age) => this._age = age;

        public string EmailAddress
        {
            get
            {
                return this._emailAddress;
            }
            set
            {
                this._emailAddress = value;
            }
        }
        public string HomeAddress
        {
            get
            {
                return this._homeAddress;
            }
            set { this._homeAddress = value; }
        }
        public Person(string name, int age, string emailAddress, string homeAddress)
        {
            this.SetName(name);
            this.SetAge(age);
            this.EmailAddress = emailAddress;
            this.HomeAddress = homeAddress;
        }
        public override string ToString()
        {
            return $"{this.GetName()}, {this.GetAge()}, {EmailAddress}, {HomeAddress}";
        }
    }

    public sealed class MathSimple
    {
        private static int _numX, _numY;
        public MathSimple(int numX, int numY)
        {
            _numX = numX;
            _numY = numY;
        }
        public static int GetSumValue() => _numX + _numY;
        public static void Add(int leftNumber, int rightNumber, out int result)
        {
            result = leftNumber + rightNumber;
        }
        public static void Sub(int leftNumber, int rightNumber, out int result) => result = leftNumber - rightNumber;
    }
    #endregion

    #region 模拟员工
    public enum EmployeeType
    {
        Bose, Manager, Normal
    }
    public class Employee : Person
    {
        public int Id { get; set; }
        public EmployeeType Type { get; set; }
        public string SocialSecurityNumber { get; set; }
        public decimal Salary { get; set; }
        protected static BenefitPackage BenefitPackage { get; set; }
        static Employee()
        {
            BenefitPackage = new BenefitPackage();
        }
        public Employee(string name, int age, string emailAddress, string homeAddress)
            : base(name, age, emailAddress, homeAddress)
        {
        }
        public Employee(string name, int age, string emailAddress, string homeAddress, decimal salary)
            : base(name, age, emailAddress, homeAddress)
        {
            this.Salary = salary;
        }
        public void GiveBouns(decimal amount)
        {
            if (amount > 0)
                this.Salary += amount;
        }
        public override string ToString()
        {
            return base.ToString() + $", {this.Salary}";
        }
    }

    public class Manager : Employee
    {
        public int StockOptions { get; set; }
        public decimal StockBouns { get; set; }
        private Random random = new Random();
        public Manager(string name, int age, string emailAddress, string homeAddress) : base(name, age, emailAddress, homeAddress)
        {
        }

        public Manager(string name, int age, string emailAddress, string homeAddress, decimal salary) : base(name, age, emailAddress, homeAddress, salary)
        {
        }
        public Manager(string name, int age, string emailAddress, string homeAddress, decimal salary, int sttockOptions, decimal stockBouns) : base(name, age, emailAddress, homeAddress, salary)
        {
            this.StockBouns = stockBouns;
            this.StockOptions = StockOptions;
        }
    }

    public class BenefitPackage
    {
        public double ComputePayDeduction = 125.0f;
    }

    public class Currency
    {
        private readonly uint _dollars;
        private readonly ushort _cents;
        public Currency(uint dollars, ushort cents)
        {
            this._dollars = dollars;
            this._cents = cents;
        }
        public static implicit operator Currency(float value)
        {
            uint dollars = (uint)value;
            ushort cents = (ushort)((value - dollars) * 100.0f);
            return new Currency(dollars, cents);
        }
        public string GetCurrencyUnit() => $"{nameof(this._dollars).ToUpper()}";
    }



    #endregion

}
