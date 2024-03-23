namespace kontenery;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool isDangerous { get; set; }
    public LiquidContainer( double Height1, double OwnMass1, double Depth1, double MaxLoad1)
    {
        base.Height = Height1;
        base.OwnWeight = OwnMass1;
        base.Depth = Depth1;
        base.LoadMass = 0;
        base.number++;
        base.ContainerNumber = "KON-L-" + base.number;
        base.MaxLoadMass = MaxLoad1;

    }

    public void LoadLiquidContainer(double LoadMass1, bool isDangerous, String TypeOfLoad1)
    {
        if (LoadMass > MaxLoadMass)
        {
            throw new OverfillException();
        }
        else
        {
            if (isDangerous && LoadMass + LoadMass1 < MaxLoadMass * 0.5)
            {
                LoadMass = LoadMass1;
                TypeOfLoad = TypeOfLoad1;
                isDangerous = true;
            }
            else if (LoadMass + LoadMass1 < MaxLoadMass * 0.9)
            {
                LoadMass = LoadMass1;
                TypeOfLoad = TypeOfLoad1;
                isDangerous = false;
            }
            else
            {
                notify(ContainerNumber);
            }
        }

    }

    public override void EmptyContainer()
    {
        LoadMass = 0;
    }

    public override void PrintInfo()
    {
        throw new NotImplementedException();
    }

    public void notify(String ContainerNumber)
    {
        Console.WriteLine("Dangerous action. Container: " + ContainerNumber);
    }
}