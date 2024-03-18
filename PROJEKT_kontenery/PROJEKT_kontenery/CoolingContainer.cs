namespace kontenery;

public class CoolingContainer : Container
{
    public double temp { get; set; }
    public CoolingContainer( double Height1, double OwnMass1, double Depth1, double MaxLoad1)
    {
        base.Height = Height1;
        base.OwnWeight = OwnMass1;
        base.Depth = Depth1;
        base.LoadMass = 0;
        base.number++;
        base.ContainerNumber = "KON-L-" + base.number;
        base.MaxLoadMass = MaxLoad1;

    }

    public CoolingContainer(double LoadMass1, String type, double temp)
    {
        
    }

    public override void EmptyContainer()
    {
        LoadMass = 0;
    }
}