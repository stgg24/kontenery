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
        
        
        CoolingContainer c1 = new CoolingContainer(2000, 400, 10000, 2000,8);
        CoolingContainer c2 = new CoolingContainer(3000, 600, 8000, 1500,-2);

        Ship alaska = new Ship("Alaska", 20, 80);
        
        c1.LoadToContainer(200,"Bananas");
        c1.LoadToContainer(200,"Bananas");


    }
}