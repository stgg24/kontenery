namespace kontenery;

public class Program
{
    public static void Main(string[] args)
    {
        CoolingContainer c1 = new CoolingContainer(2000, 400, 10000, 2000);
        CoolingContainer c2 = new CoolingContainer(3000, 600, 8000, 1500);

        Ship alaska = new Ship("Alaska", 20, 80);
        
        alaska.LoadContainer(c1);
        
        alaska.PrintInfo();


    }
}