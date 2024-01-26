namespace NerdStore.Core.Domainobject;

public class DomainException : Exception
{
    public DomainException() //uma estancia
    { }

    public DomainException(string message) : base(message) //passa a mesangem expecializada
    { }

    public DomainException(string message, Exception innerException) : base(message, innerException)//uma excepion que iniciou internamente (uma excepion dentro de outra)
    { }
}
