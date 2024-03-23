namespace kontenery;

public class Ship
{
    public String ShipName { get; set; }
    public double MaxSpeed { get; set; }
    public int MaxContainers { get; set; }
    public int ShipNumber { get; set; }
    
    
    private List<Container> ListOfContainers = new List<Container>();
    public static int Number = 0;

    public Ship(string shipName, int maxContainers, double maxSpeed)
    {
        ShipNumber = Number++;
        ShipName = shipName;
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;

    }

    public void LoadContainer(Container container)
    {
        if (ListOfContainers.Count < MaxContainers)
        {
            ListOfContainers.Add(container);
            Console.WriteLine("You've added container successfully!!");
        }
        else
        {
            Console.WriteLine("You ship is full.");
        }
    }

    public void LoadListOfContainers(List<Container> list)
    {
        if ((ListOfContainers.Count + list.Count) < MaxContainers)
        {
            foreach (Container container in list)
            {
                ListOfContainers.Add(container);
            }
            Console.WriteLine("You've successfully added list of containers!");
        }
        else
        {
            int NumberOfContainersOverLimit = ListOfContainers.Count + list.Count - MaxContainers;
            Console.WriteLine("Your ship doesn't have enough space. You need to remove " + NumberOfContainersOverLimit + " containers.");
        }
    }

    public void RemoveContainer(Container container)
    {
        ListOfContainers.Remove(container);
    }

    public void SwapContainers(Container ToSwap, Container NewContainer)
    {
        if (ListOfContainers.Contains(ToSwap))
        {
            ListOfContainers.Remove(ToSwap);
            ListOfContainers.Add(NewContainer);
            Console.WriteLine("You've successfully swapped containers.");
        }
        else
        {
            Console.WriteLine("Container you wanted to remove doesn't belong to this ship.");
        }
    }

    public void MoveToOtherShip(Ship ship, Container container)
        {
            if(ListOfContainers.Contains(container))
            {
                ListOfContainers.Remove(container);
                ship.ListOfContainers.Add(container);
            }
    }

    public void PrintInfo()
    {
        Console.WriteLine("Ship number " + ShipNumber + " currently has " + ListOfContainers.Count +
                          " containers. It's maximum capacity is " + MaxContainers + " containers.\nMaximum speed of" +
                          "that ship is " + MaxSpeed + " knots.");
    }

    public void PrintLoad()
    {
        Console.WriteLine("List of containers on this ship:");
        foreach (Container container in ListOfContainers)
        {
            
        }
    }
    
    
    
}   