namespace kontenery;

public class OverfillException : Exception
{
    public OverfillException() : base(" Mass load is bigger than maximum capacity. ")
    {}
}