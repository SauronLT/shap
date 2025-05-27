namespace Fashion.Exceptions;

public class MalException : Exception
{
    public MalException() : base("yalnish sheyi girdin")
    {
    }
    public MalException(string errormessage) : base(errormessage)
    {
    }
}
