namespace kontenery;

public class GasContainer : Container, IHazardNotifier
{
    public double CurrentPressureLevel { get; set; }
    
    public GasContainer( double Height1, double OwnMass1, double Depth1, double MaxLoad1)
    {
        base.Height = Height1;
        base.OwnWeight = OwnMass1;
        base.Depth = Depth1;
        base.LoadMass = 0;
        base.number++;
        base.ContainerNumber = "KON-G-" + base.number;
        base.MaxLoadMass = MaxLoad1;

    }

    public void LoadGasContainer(double loadMass, String type, double pressure)
    {
        
            if(TypeOfLoad == null || TypeOfLoad.Equals(type))
            {
                    if (LoadMass + loadMass < MaxLoadMass)
                    {
                        LoadMass += loadMass;
                        TypeOfLoad = type;
                        CurrentPressureLevel = pressure;
                        Console.WriteLine("You've loaded " + type + " correctly to " + ContainerNumber + " container.");
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
        Console.WriteLine("You've  emptied container " + ContainerNumber);
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Container: " + ContainerNumber + " Load: " + TypeOfLoad + ", " + LoadMass);
    }
    public void Notify()
    {
        Console.WriteLine("Dangerous action. Container: " + ContainerNumber);
    }
}