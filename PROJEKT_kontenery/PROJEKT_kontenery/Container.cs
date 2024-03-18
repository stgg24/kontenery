namespace kontenery;

public abstract class Container
{
    public double LoadMass { get; set; }
    public double Height { get; set; }
    public double OwnWeight { get; set; }
    public double Depth { get; set; }
    public int number { get; set; }
    public double MaxLoadMass { get; set; }
    public String ContainerNumber { get; set; }

    public String TypeOfLoad { get; set; }
    
    

    public abstract void EmptyContainer();

}

