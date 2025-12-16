using AbstracFactory;
using AdapterPattern;
using BridgePattern;
using BuilderPattern;
using CompositePattern;
using DecoratePattern;
using FacadePattern;
using FactoryMethod;
using Observer_Pattern;
using ProtoType;
using ProxyPattern;
using SingletonPattern;
using System.Diagnostics.Contracts;
using Strategy_Pattern;
using Car = BridgePattern.Car;
using CommandPattern;
using Chain_of_Responsibility_pattern;
using State_Pattern;
using Mediator_Pattern;
namespace Desgin_Pattern
{
    internal class Program
    {
        public static void ShowMenu(Menu menu)
        {
            foreach (var item in menu.Foods)
                Console.WriteLine($"{item.Name} : {item.Price}");
        }
        static void Main(string[] args)
        {
            #region Creational Patterns

            Console.WriteLine("                     Factory Method Pattern            ");
            Console.WriteLine();

            #region Factory Method Pattern

            var circle = ShapeFactory.CreateShape(ShapeType.Circle);
            var square = ShapeFactory.CreateShape(ShapeType.Square);

            #endregion

            #region Abstract Factory Pattern

            CarFactory northAmericaFactory = new NorthAmericanCarFactory();
            var northAmericaCar = northAmericaFactory.CreateCar();
            var northAmericaSpec = northAmericaFactory.CreateCarSpecification();
            

            CarFactory europeFactory = new EuropeanCarFactory();
            var europeCar = europeFactory.CreateCar();
            var europeSpec = europeFactory.CreateCarSpecification();

            //Console.WriteLine(northAmericaCar);
            //Console.WriteLine(northAmericaSpec);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                    Abstract Factory Pattern            ");
            Console.WriteLine();

            northAmericaCar.assemble();
            northAmericaSpec.display();
            Console.WriteLine("-----------------------------------");
            europeCar.assemble();
            europeSpec.display();
            #endregion

            #region Builder Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Builder Pattern            ");
            Console.WriteLine();

            GamingComputerBuilder gamingComputerBuilder = new GamingComputerBuilder();
            Director director = new Director();
            director.Construct(gamingComputerBuilder);

            var gamingComputer = gamingComputerBuilder.GetComputer();

            gamingComputer.DisplayConfiguration();
            #endregion

            #region Prototype Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Builder Pattern            ");
            Console.WriteLine();

            var textproto = new TextDocument("Text");

            var textclone = new TextClient(textproto).TextDocumentClone;
            
            Console.WriteLine($"Original Document Type: {textproto.Display()}");
            Console.WriteLine($"Cloned Document Type: {textclone.Display()}");

            #endregion

            #region Singleton Pattern

            // one check not thread safe
            var logBtOneCheck = Singleton.GetInstanceOneCheck();

            // two check thread safe
            var logBtTwoCheck = Singleton.GetInstanceTwoCheck();

            // lazy thread safe
            var logBtLazy = Singleton.GetInstanceByLazy();

            #endregion

            #endregion

            #region Structural Patterns


            #region Adapter Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Adapter Pattern            ");
            Console.WriteLine();

            Adaptee adaptee = new Adaptee();

            var adapter = new Adapter(adaptee);

            adapter.Request();

            #endregion

            #region Decorator Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Decorator Pattern            ");
            Console.WriteLine();
            var coffee = new SimpleCoffee();

            Console.WriteLine($"{coffee.GetDescription()} Cost: {coffee.GetCost()}");

            var milk = new MilkCoffee(coffee);
            Console.WriteLine($"{milk.GetDescription()} Cost: {milk.GetCost()}");

            var chocolate = new ChocolateCoffee(milk);
            Console.WriteLine($"{chocolate.GetDescription()} Cost: {chocolate.GetCost()}");

            #endregion

            #region Facade Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Facade Pattern            ");
            Console.WriteLine();
            var facade = new RestaurantFacade();

            ShowMenu(facade.GetVegMenu());
            ShowMenu(facade.GetNonVegMenu());
            ShowMenu(facade.GetBothMenu());


            #endregion

            #region Composite Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Composite Pattern            ");
            Console.WriteLine();

            var datafile = new CompositePattern.File("data", 10);
            var imagefile = new CompositePattern.File("image", 20);
            var folder = new Folder("Project");
            folder.Add(datafile);
            folder.Add(imagefile);

            folder.Display();

            #endregion

            #region Proxy Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Proxy Pattern            ");
            Console.WriteLine();
            var developerEmployee = new Employee("John Doe","1234","Developer");
            var sharedFolderproxy = new SharedFolderProxy(developerEmployee);
            sharedFolderproxy.PerformRWOperations();

            var adminEmployee = new Employee("John Doe", "1234", "Admin");
            sharedFolderproxy = new SharedFolderProxy(adminEmployee);
            sharedFolderproxy.PerformRWOperations();

            #endregion

            #region Bridge Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Bridge Pattern            ");
            Console.WriteLine();

            var car = new Car(new Produce(), new Assemble());
            car.manufacture();

            var bike = new Bike(new Produce(), new Assemble());

            bike.manufacture();

            #endregion

            #endregion

            #region Behavioral Patterns

            #region Observer Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Observer Pattern            ");
            Console.WriteLine();

            WeatherStation weatherStation = new WeatherStation();
            PhoneDisplay phoneDisplay = new PhoneDisplay();
            TVDisplay tvDisplay = new TVDisplay();
            weatherStation.addObserver(phoneDisplay);
            weatherStation.addObserver(tvDisplay);
            // Simulate weather change
            weatherStation.notifyObserver();
            weatherStation.removeObserver(tvDisplay);
            // Simulate another weather change
            weatherStation.notifyObserver();
            #endregion

            #region Strategy Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Strategy Pattern            ");
            Console.WriteLine();

            // Create SortingContext with BubbleSortStrategy
            SortContext sortingContext = new SortContext(new BubbleSort());
            int[] array1 = { 2,10 ,5, 3, 1, 4, 7, 6, 8, 9 };
            sortingContext.PerformSort(array1); // Output: Sorting using Bubble Sort
            sortingContext.PrintArray(array1); // Output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

            // Change strategy to QuickSortStrategy
            sortingContext.SetSortStrategy(new QuickSort());
            int[] array3 = { 2, 10, 5, 3, 1, 4, 7, 6, 8, 9 };
            sortingContext.PerformSort(array3); // Output: Sorting using Quick Sort
            sortingContext.PrintArray(array3); // Output: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
            #endregion

            #region Command Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     Command Pattern            ");
            Console.WriteLine();

            var tv = new Television();
            var  radio = new Radio();
            var tvOn = new TurnOnCommand(tv);
            var tvOff = new TurnOffCommand(tv);
            var radioOn = new TurnOnCommand(radio);
            var radioOff = new TurnOffCommand(radio);
            var changeChannel = new ChangeChannelCommand(tv, 5);
            var changeFrequency = new SetFrequencyCommand(radio, 100);
            var remoteControl = new RomoteControl();
            
            remoteControl.AddCommand(tvOn);
            remoteControl.ExecuteCommands();
            remoteControl.AddCommand(radioOn);
            remoteControl.ExecuteCommands();
            remoteControl.AddCommand(changeChannel);
            remoteControl.ExecuteCommands();
            remoteControl.AddCommand(changeFrequency);
            remoteControl.ExecuteCommands();
            remoteControl.AddCommand(tvOff);
            remoteControl.ExecuteCommands();
            remoteControl.AddCommand(radioOff);
            remoteControl.ExecuteCommands();



            #endregion

            #region Chain of Responsibility Pattern

            Console.WriteLine("--------------------------------");
            Console.WriteLine("                     Chain of Responsibility Pattern            ");
            Console.WriteLine();

            var level1Handler = new Level1Support();
            var level2Handler = new Level2Support();
            var level3Handler = new Level3Support();

            // Set Chain of Responsibility
            level1Handler.setNext(level2Handler);
            level2Handler.setNext(level3Handler);

            var request = new Request(Priority.Level1);
            level1Handler.handleRequest(request);

            request = new Request(Priority.Level2);
            level1Handler.handleRequest(request);

            request = new Request(Priority.Level3);
            level1Handler.handleRequest(request);


            #endregion

            #region State Pattern

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("                     State Pattern            ");
            Console.WriteLine();

            var vendingMachine = new VendingMachine();

            vendingMachine.request();

            vendingMachine.setState(new ProductSelectedState());
            vendingMachine.request();

            vendingMachine.setState(new PaymentPendingState());
            vendingMachine.request();
            vendingMachine.setState(new OutOfStockState());


            #endregion

            #endregion

            #region mediator pattern

            Console.WriteLine("--------------------------");
            Console.WriteLine("                     Mediator Pattern            ");
            Console.WriteLine();

            var tower = new AirportControlTower();

            var plane1 = new CommercialAirplane(tower);
            tower.TakeOff(plane1);
            tower.Land();

            
            #endregion

            Console.ReadKey();
        }
    }
}
