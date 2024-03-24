namespace kontenery;

public class CoolingContainer : Container
{

    public static Dictionary<string, double> Temperatures { get; set; }
    public double TempInContainer { get; set; }
    public static int Number = 0;
    public CoolingContainer(double height, double ownMass, double depth, double maxLoad, double tempInContainer)
    {
        Height = height;
        OwnWeight = ownMass;
        Depth = depth;
        LoadMass = 0;
        Number++;
        ContainerNumber = "KON-C-" + Number;
        MaxLoadMass = maxLoad;
        TempInContainer = tempInContainer;

    }

    public void LoadToContainer(double loadMass, string type)
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
                       Console.WriteLine(ContainerNumber + " - You've loaded " + loadMass + " kgs of " + type +
                                         " correctly");
                   }
                   else
                   {
                       Console.WriteLine("There's not enough space in container");
                       throw new OverfillException("Container capacity exceeded");
                   }
               }
               else
               {
                   Console.WriteLine("Temperature in Container is too high");
               }
           }
           else
           {
               Console.WriteLine("You've already loaded " + TypeOfLoad + " into container. You can't load " + type + ". Empty container first.");
           }
        }
        else
        {
            Console.WriteLine("You can't load " + type + ". Your containters can't store that.");
        }

    }

    public override void EmptyContainer()
    {
        LoadMass = 0;
        TypeOfLoad = null;
        Console.WriteLine(ContainerNumber + " - You've  emptied container ");
    }

    

    public static void LoadTemperatures( Dictionary<string, double> temperatures)
    {
        Temperatures = temperatures;
    }
}