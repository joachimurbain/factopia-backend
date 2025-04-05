namespace factopia_backend.BLL.CustomExceptions;

public class EntityNotFoundException : Exception
{
    public EntityNotFoundException():base("Entity Not Found."){}
    public EntityNotFoundException(string message, Exception innerException) : base(message, innerException) { }
}
