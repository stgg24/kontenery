namespace kontenery;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsDangerous { get; set; }
    public LiquidContainer( double height, double ownMass, double depth, double maxLoad)
    {
        Height = height;
        OwnWeight = ownMass;
        Depth = depth;
        LoadMass = 0;
        number++;
        ContainerNumber = "KON-L-" + base.number;
        MaxLoadMass = maxLoad;

    }

    public void LoadLiquidContainer(double loadMass, bool isDangerous, string type)
    {
        if (TypeOfLoad == null || TypeOfLoad.Equals(type))
        {
            if (LoadMass + loadMass > MaxLoadMass)
            {
                if (isDangerous)
                {
                    Notify();
                }

                throw new OverfillException("Container capacity exceeded");

            }

            if (isDangerous && (LoadMass + loadMass) < MaxLoadMass * 0.5)
            {
                LoadMass = loadMass;
                TypeOfLoad = type;
                IsDangerous = isDangerous;
                Console.WriteLine("You've loaded " + loadMass + " of " + type + " to container " + ContainerNumber);
            }
            else if (!isDangerous && LoadMass + loadMass < MaxLoadMass * 0.9)
            {
                LoadMass = loadMass;
                TypeOfLoad = type;
                IsDangerous = isDangerous;
                Console.WriteLine("You've loaded " + loadMass + " of " + type);
            }
            else
            {
                Notify();
            }
        }
        else
        {
            Console.WriteLine("You've already loaded " + TypeOfLoad + " into container. You can't load " + type + ". Empty container first.");
        }


    }

    public override void EmptyContainer()
    {
        LoadMass = 0;
        TypeOfLoad = null;
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