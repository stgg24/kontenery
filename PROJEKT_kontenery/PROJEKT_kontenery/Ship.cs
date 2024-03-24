namespace kontenery;

public class Ship
{
    
    public String ShipName { get; set; }
    public double MaxSpeed { get; set; }
    public int MaxContainers { get; set; }
    public int ShipNumber { get; set; }
    
    
    private List<Container> ListOfContainers = new List<Container>();
    public static int Number = 1;

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
            Console.WriteLine("Ship:  [" + ShipName + "] Container: [" + container.ContainerNumber + "] added.");
        }
        else
        {
            Console.WriteLine("Ship:  [" + ShipName + "] is full.");
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
            Console.WriteLine("Ship: [" + ShipName + "] Containers added.");
        }
        else
        {
            var numberOfContainersOverLimit = ListOfContainers.Count + list.Count - MaxContainers;
            Console.WriteLine("Ship: [" + ShipName + "]  doesn't have enough space. You need to remove " + numberOfContainersOverLimit + " containers.");
        }
    }

    public void RemoveContainer(Container container)
    {
        ListOfContainers.Remove(container);
        Console.WriteLine("Ship:  [" + ShipName + "] Container: [" + container.ContainerNumber + "] removed");
    }

    public void SwapContainers(Container ToSwap, Container NewContainer )
    {
        if (ListOfContainers.Contains(ToSwap))
        {
            ListOfContainers.Remove(ToSwap);
            ListOfContainers.Add(NewContainer);
            Console.WriteLine("Ship:  [" + ShipName + "] Containers swapped.");
        }
        else
        {
            Console.WriteLine("Container: [" + ToSwap.ContainerNumber + "] is not on Ship: [" + ShipName + "].");
        }
    }

    public void MoveToOtherShip(Ship ship, Container container)
        {
            if(ListOfContainers.Contains(container))
            {
                ListOfContainers.Remove(container);
                ship.ListOfContainers.Add(container);
                Console.WriteLine("Container: [" +container.ContainerNumber + "] moved to Ship: [" + ship.ShipName + "].");
            }
            
    }

    public void PrintInfo()
    {
        Console.WriteLine("Ship: [" + ShipName + "], Number: [" + ShipNumber + "], Containers: [" + ListOfContainers.Count +
                          "], maxCapacity: [" + MaxContainers + "],MaxSpeed: [" + MaxSpeed + "]");
    }

    public void PrintLoad()
    {
        Console.WriteLine("Ship: [" + ShipName + "], List of containers:");
        foreach (Container container in ListOfContainers)
        {
            container.PrintInfo();
        }
        Console.WriteLine("=========================================");
    }
    
    
    
}   