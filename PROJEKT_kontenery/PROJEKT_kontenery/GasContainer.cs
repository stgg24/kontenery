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

    public void LoadGasContainer(double LoadMass1, double Pressure1, String Type)
    {
        if (LoadMass > MaxLoadMass)
        {
            throw new OverfillException();
        }

        LoadMass = LoadMass1;
        TypeOfLoad = Type;
        CurrentPressureLevel = Pressure1;

    }

    public override void EmptyContainer()
    {
        LoadMass = 0.05 * LoadMass;
    }
}