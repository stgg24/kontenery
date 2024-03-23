namespace kontenery;

public class CoolingContainer : Container
{

    public new string TypeOfLoad { get; set; }
    public static Dictionary<string, double> Temperatures { get; set; }
    public double TempInContainer { get; set; }
    public CoolingContainer(double Height1, double OwnMass1, double Depth1, double MaxLoad1, double tempInContainer)
    {
        base.Height = Height1;
        base.OwnWeight = OwnMass1;
        base.Depth = Depth1;
        base.LoadMass = 0;
        base.number++;
        base.ContainerNumber = "KON-C-" + base.number;
        base.MaxLoadMass = MaxLoad1;
        TempInContainer = tempInContainer;

    }

    public void LoadToContainer(double loadMass, String type)
    {
        if (Temperatures.ContainsKey(type))
        {
           if(TypeOfLoad == null || TypeOfLoad.Equals(type))
            {
                double temp;
                Temperatures.TryGetValue(type, out temp);
                if (temp > TempInContainer)
                {
                    if (LoadMass + loadMass < MaxLoadMass)
                    {
                        LoadMass += loadMass;
                        TypeOfLoad = type;
                        Console.WriteLine("You've loaded " + type + " correctly to this container.");
                    }
                    else
                    {
                        Console.WriteLine("There's not enough space in container");
                    }
                }
                else
                {
                    Console.WriteLine("Temperature in Container is too high");
                }
            }
            else
            {
                Console.WriteLine("You've already loaded " + TypeOfLoad + " into container. You can't load " + type + ".\nEmpty container first.");
            }
        }
        else
        {
            Console.WriteLine("You can't load " + type);
        }

    }

    public override void EmptyContainer()
    {
        LoadMass = 0;
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Container: " + ContainerNumber + " Load: ");
        
    }

    public static void LoadTemperatures( Dictionary<string, double> temperatures)
    {
        Temperatures = temperatures;
    }
}