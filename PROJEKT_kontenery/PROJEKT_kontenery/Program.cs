using System.Runtime.Intrinsics.Arm;

namespace kontenery;

public class Program
{
    public static void Main(string[] args)
    {
        
        Dictionary<string, double> temperatures = new Dictionary<string, double>();
        temperatures.Add("Bananas",13.3);
        temperatures.Add("Chocolate",18);
        temperatures.Add("Fish",2);
        temperatures.Add("Meat",-15);
        temperatures.Add("Ice Cream",-18);
        temperatures.Add("Frozen Pizza",-30);
        temperatures.Add("Cheese",7.2);
        temperatures.Add("Sausages",5);
        temperatures.Add("Butter",20.5);
        temperatures.Add("Eggs",19);
        CoolingContainer.LoadTemperatures(temperatures);
        List<Ship> listOfShips = new List<Ship>();
        
        
        
        
        
        
        CoolingContainer c1 = new CoolingContainer(2000, 400, 10000, 2000,8);
        CoolingContainer c2 = new CoolingContainer(3000, 600, 8000, 1500,-30);
        LiquidContainer l1 = new LiquidContainer(2000, 400, 10000, 3000);
        GasContainer g1 = new GasContainer(3000, 2000, 10000, 1000);
        
        
        
        

        Ship alaska = new Ship("Alaska", 20, 80);
        Ship benin = new Ship("benin", 20, 80);

        try
        {
            c1.LoadToContainer(200, "Bananas");
            c1.LoadToContainer(200, "Bananas");
            c1.LoadToContainer(30, "Bananas");
            c1.PrintInfo();
            c1.EmptyContainer();
            c1.LoadToContainer(200, "Chocolate");
            c1.LoadToContainer(300, "Chocolate");
            c1.PrintInfo();
            l1.LoadLiquidContainer(200,true,"Fuel");
            l1.LoadLiquidContainer(200,false,"Gas");
            l1.EmptyContainer();
            l1.PrintInfo();
            l1.LoadLiquidContainer(1500,true,"Gas");
            g1.PrintInfo();
            g1.LoadGasContainer(300,"Helium",15.5);
            g1.PrintInfo();
            g1.EmptyContainer();
            g1.PrintInfo();
            g1.LoadGasContainer(300,"Uranium",23.3);
            Console.WriteLine("=============");
            alaska.PrintInfo();
            alaska.LoadContainer(c1);
            alaska.LoadContainer(l1);
            alaska.PrintInfo();
            alaska.PrintLoad();
            benin.PrintInfo();
            alaska.RemoveContainer(l1);
            alaska.PrintInfo();
            alaska.SwapContainers(c1,g1);
            alaska.PrintInfo();
            alaska.PrintLoad();
            alaska.MoveToOtherShip(benin, g1);
            benin.PrintInfo();
            benin.PrintLoad();
            alaska.PrintInfo();
            GasContainer t1 = new GasContainer(3000, 2000, 10000, 1000);
            GasContainer t2 = new GasContainer(3000, 2000, 10000, 1000);
            List<Container> list = new List<Container>();
            list.Add(t1);
            list.Add(t2);
            alaska.LoadListOfContainers(list);
            alaska.PrintInfo();
        }
        catch (OverfillException ex)
        {
            Console.WriteLine(ex);
        }



    }

    // public static void ShipsList(List<Ship> listOfShips )
    // {
    //     Console.WriteLine("List of containers: ");
    //     foreach (Ship ship in listOfShips)
    //     {
    //         ship.PrintInfo();
    //     }
    // }
    // public static void ShipsLoad(List<Ship> listOfShips )
    // {
    //     Console.WriteLine("List of containers: ");
    //     foreach (Ship ship in listOfShips)
    //     {
    //         ship.PrintLoad();
    //     }
    // }
    //
    // public static void PrintMenu()
    // {
    //     Console.WriteLine("Actions to take: ");
    //     Console.WriteLine("(1) Create new ship.");
    //     Console.WriteLine("(2) Delete current ship");
    //     Console.WriteLine("(3) Create Container");
    //     Console.WriteLine("(4) Add container to a ship.");
    //     Console.WriteLine("(5) Remove Container from ship");
    //     Console.WriteLine("(6) Delete Container");
    //     
    // }
}