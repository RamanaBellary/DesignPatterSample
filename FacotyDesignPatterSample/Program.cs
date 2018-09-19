using System;
using DesignPatternsSample.Creational;
using DesignPatternsSample.Behavioural;
using DesignPatternsSample.Structural;
using System.Text;

namespace DesignPatternsSample
{
    static class Program
    {
        static void Main()
        {
            Execute();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1()); 
            Console.ReadKey();
        }

        private static void Execute()
        {
            #region Singleton Pattern
            ////Singleton
            //SingletonClass instance = SingletonClass.GetInstance();
            //instance = SingletonClass.GetInstance();

            //string s;
            ////Factory
            //IImposition obj = ImposeFactory.GetImpositionObject("CNS");
            //obj.Impose();

            //obj = ImposeFactory.GetImpositionObject("SS");
            //obj.Impose(); 
            #endregion

            #region Factory Pattern
            //IImposition imposition = ImposeFactory.GetImpositionObject("CNS");
            //imposition.Impose();
            //imposition = ImposeFactory.GetImpositionObject("SS");
            //imposition.Impose();
            #endregion

            #region Abstract Facory Pattern  
            #region Example1 Mobile Factory
            //PhoneFactory pf = new NokiaFactory();
            //s = pf.GetSmart().Name();
            //s = pf.GetNoraml().Name();

            //pf = new SamsungFactory();
            //s = pf.GetSmart().Name();
            //s = pf.GetNoraml().Name(); 
            #endregion
            #region Example2 Vehicle Factory
            //HondaFacory hf =new HondaFacory();
            //IBike bike = hf.GetBike("Shine");
            //int cost = bike.Cost();  
            #endregion
            #endregion

            #region Prototype Pattern
            ////Prototype
            Developer dev = new Developer();
            dev.Name = "Rahul";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";
            dev.AdditionalDetails.Fitness = 5;
            dev.AdditionalDetails.Charisma = 5;

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "asdf";
            devCopy.AdditionalDetails.Fitness = 15;
            devCopy.AdditionalDetails.Charisma = 15;
            #endregion

            #region Builder Pattern
            //Builder Pattern: 
            //used to create objects made from a bunch of other objects.
            //used when creation of these parts to be independent of main object.
            //hide the creation of parts from client so both aren't dependent.
            //builder know the specifics and no body else does.

            //RobotBuilder oldStyleRobot = new OldRobotBuilder();
            //RobotEngineer re = new RobotEngineer(oldStyleRobot);
            //re.MakeRobot();
            //Robot r1 = re.GetRobot(); 
            #endregion

            #region Strategy pattern
            //Strategy pattern: When u want to use one of the several behaviours dynamically.
            #region Example1
            //List<int> lstInt = new List<int> { 9, 1, 8, 3 };

            //SortContext quickSort = new SortContext(new QuickSort());
            //quickSort.Sort(lstInt);

            //SortContext shellSort = new SortContext(new ShellSort());
            //shellSort.Sort(lstInt); 
            #endregion

            #region Example2
            //Animal dog = new Dog();
            //dog.TryToFly();
            //Animal eagle = new Eagle();
            //eagle.TryToFly();
            #endregion

            #region Example3
            //Context add = new Context(new Add());
            //MessageBox.Show("10+20=" + add.PerformOperation(10, 20));

            //Context mul = new Context(new Multiply());
            //MessageBox.Show("10*20=" + mul.PerformOperation(10, 20)); 
            #endregion
            #endregion

            #region Observer Pattern
            ////Observer pattern: When you need many other objects to be notified when another object changes.
            ////Loose coupling is the benifit.
            #region Example1
            //Stock ibm = new IBM("IBM", 100);
            //Stock msft = new MSFT("MSFT", 150);
            //Investor I1 = new Investor("I1");
            //ibm.Register(I1);
            //msft.Register(I1);
            //Investor I2 = new Investor("I2");
            //ibm.Register(I2);
            //ibm.Price = 200;
            //msft.Price = 300; 
            #endregion
            #region Example2
            //StockGrabber stockGrabber = new StockGrabber();
            //StockObserver stockObserver1 = new StockObserver(stockGrabber);
            //stockGrabber.SetIBMPrice(200);
            //StockObserver stockObserver2 = new StockObserver(stockGrabber);
            //stockGrabber.SetIBMPrice(400);
            //StockObserver stockObserver3 = new StockObserver(stockGrabber);
            //stockGrabber.SetIBMPrice(600);

            //stockGrabber.UnRegister(stockObserver2);
            //stockGrabber.SetIBMPrice(10000);  
            #endregion
            #endregion

            #region Prototype Pattern
            ////Creation new objects(Instances) by cloning(Copy) other objects.
            //IEmployee d1 = new Developer { Name = "D1", Role = "R1", PreferredLanguage = "L1", WordsPerMinute = 1, AdditionalDetails = new AdditionalDetails { Charisma = 1, Fitness = 1 } }; ;
            //IEmployee d2 = d1.Clone();
            //((Developer)d2).Name = "adsa";
            //((Developer)d2).AdditionalDetails.Fitness = 20;
            //if (d2 != null)
            //{ }
            #endregion

            #region Chain Of Responsibility
            //Approver director = new Director();
            //Approver vp = new VicePresident();
            //Approver president = new President();

            //director.SetSuccessor(vp);
            //vp.SetSuccessor(president);


            //Purchase p = new Purchase(1, 10000.0, "New chair");
            //MessageBox.Show(director.ProcessRequest(p));
            //p = new Purchase(2, 25000.0, "New Laptop");
            //MessageBox.Show(director.ProcessRequest(p));
            //p = new Purchase(3, 100000.0, "New Server");
            //MessageBox.Show(director.ProcessRequest(p));
            //p = new Purchase(4, 1000000.0, "New Branch");
            //MessageBox.Show(director.ProcessRequest(p));
            #endregion

            #region Template Method
            //DataAccessRetriever categoriesRetriever = new CategoriesRetriever();
            //categoriesRetriever.Run();

            //DataAccessRetriever productsRetriever = new ProductRetriever();
            //productsRetriever.Run();
            #endregion

            #region Iterator
            //Collection collection = new Collection();
            //collection[0] = new Item("Item0");
            //collection[1] = new Item("Item1");
            //collection[2] = new Item("Item2");
            //collection[3] = new Item("Item3");
            //collection[4] = new Item("Item4");

            //Iterator iterator = new Iterator(collection);
            //iterator.Step = 1;
            //for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            //{
            //    Console.WriteLine(item.Name);
            //    //Do the necessary opeartion here..
            //}

            #endregion

            #region Facade
            #region Example1
            //Facade facade = new Facade();
            //facade.MethodA();
            //facade.MethodB();
            #endregion

            #region Example2
            //Customer c = new Customer("Ramana");
            //Mortgage mortgage = new Mortgage();
            //mortgage.IsEligible(c, 300000);
            #endregion
            #endregion

            #region Proxy
            //Proxy proxy = new Proxy();
            //proxy.Request();
            #endregion

            //TODO: Composite, Adapter
        }
    }
}
