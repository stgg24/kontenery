namespace kontenery;

public class GasContainer : Container, IHazardNotifier
{
    public double CurrentPressureLevel { get; set; }
    public static int Number = 0;
    public GasContainer( double height, double ownMass, double depth, double maxLoad)
    {
        Height = height;
        OwnWeight = ownMass;
        Depth = depth;
        LoadMass = 0;
        Number++;
        ContainerNumber = "KON-G-" + Number;
        MaxLoadMass = maxLoad;

    }

    public void LoadGasContainer(double loadMass, string type, double pressure)
    {
        
            if(TypeOfLoad == null || TypeOfLoad.Equals(type))
            {
                    if (LoadMass + loadMass < MaxLoadMass)
                    {
                        LoadMass += loadMass;
                        TypeOfLoad = type;
                        CurrentPressureLevel = pressure;
                        Console.WriteLine(ContainerNumber + " - You've loaded " +  loadMass + " kgs of " +  type + " correctly");
                    }
                    else
                    {
                        throw new OverfillException("Container capacity exceeded");
                        Notify();
                        
                    }
            }
            
            else
            {
                Console.WriteLine("You've already loaded " + TypeOfLoad + " into container. You can't load " + type);
            }
    }
    
    public override void EmptyContainer()
    {
        LoadMass = 0.05 * LoadMass;
        Console.WriteLine(ContainerNumber + " - You've  emptied container ");
    }

    
    public void Notify()
    {
        Console.WriteLine("Dangerous action. Container: " + ContainerNumber);
    }
}